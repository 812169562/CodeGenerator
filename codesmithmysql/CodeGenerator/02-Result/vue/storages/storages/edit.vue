<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="重新生成的名字" hintText="请输入重新生成的名字" v-model="form.newName"  lab labelFloat/>
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="类型(用于区分压缩后文件比例等）" hintText="请输入类型(用于区分压缩后文件比例等）" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="文件目录（上传的文件的分类）" hintText="请输入文件目录（上传的文件的分类）" v-model="form.catalog"  lab labelFloat/>
         <mu-text-field label="文件全名" hintText="请输入文件全名" v-model="form.name"  lab labelFloat/>
         <mu-text-field label="文件路径" hintText="请输入文件路径" v-model="form.path"  lab labelFloat/>
         <mu-text-field label="排序" hintText="请输入排序" v-model="form.sort"  lab labelFloat/>
  </el-form>
  <span slot="footer" class="dialog-footer">
     <el-button type="danger" @click="hidden()" plain>取 消</el-button>
     <el-button type="primary" @click="save()" plain>确 定</el-button>
  </span>
</el-dialog>
</template>
<script>
export default {
  /** 组件名称 */
  name: 'storages-edit',
  /** 属性
   * @property 是否可见
   * @property 选中数据编号
   */
  props: {
    dialogVisible: {
      type: Boolean,
      default: false
    },
    id: {
      type: String,
      default: ''
    }
  },
  /** 绑定数据 */
  data() {
    return {
      /** 表单数据 */
      form: {},
      /** 表单标题 */
      title: '新增存储信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 重新生成的名字 */
        newName: '',
        /** 门店号 */
        stroeId: '',
        /** 类型(用于区分压缩后文件比例等） */
        type: 0,
        /** 文件目录（上传的文件的分类） */
        catalog: 0,
        /** 文件全名 */
        name: '',
        /** 文件路径 */
        path: '',
        /** 排序 */
        sort: 0,
        /** 删除标志 */
        isDeleted: '',
        /**  页面缓存*/
        pagecache: ''
      }
    },
    /** 隐藏页面 */
    hidden(refresh) {
      this.$emit('closeAdd', false, refresh)
    },
    /** 保存页面信息 */
    save() {
      const _this = this
      this.$request.save('storages', this.form, function(respose) {
        if (respose.code === 1) {
          _this.init()
          _this.hidden(true)
        }
      }, this.id)
    },
    /** 打开页面信息 */
    open() {
      if (!this.id) {
        this.init()
      } else {
        this.title = '编辑存储信息'
        const _this = this
        this.$request.get('storages/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
