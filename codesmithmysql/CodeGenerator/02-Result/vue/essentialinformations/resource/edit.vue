<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="资源名称" hintText="请输入资源名称" v-model="form.name"  lab labelFloat/>
         <mu-text-field label="门店编号" hintText="请输入门店编号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="代码" hintText="请输入代码" v-model="form.code"  lab labelFloat/>
         <mu-text-field label="关系" hintText="请输入关系" v-model="form.relationShip"  lab labelFloat/>
         <mu-text-field label="父级" hintText="请输入父级" v-model="form.parent"  lab labelFloat/>
         <mu-text-field label="等级" hintText="请输入等级" v-model="form.level"  lab labelFloat/>
         <mu-text-field label="排序" hintText="请输入排序" v-model="form.sort"  lab labelFloat/>
         <mu-text-field label="地址" hintText="请输入地址" v-model="form.url"  lab labelFloat/>
         <mu-text-field label="路径" hintText="请输入路径" v-model="form.path"  lab labelFloat/>
         <mu-text-field label="参数" hintText="请输入参数" v-model="form.para"  lab labelFloat/>
         <mu-text-field label="" hintText="请输入" v-model="form.applicationsId"  lab labelFloat/>
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
  name: 'resource-edit',
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
      title: '新增资源信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 资源名称 */
        name: '',
        /** 门店编号 */
        stroeId: '',
        /** 代码 */
        code: '',
        /** 关系 */
        relationShip: '',
        /** 父级 */
        parent: '',
        /** 等级 */
        level: 0,
        /** 排序 */
        sort: 0,
        /** 地址 */
        url: '',
        /** 路径 */
        path: '',
        /** 参数 */
        para: '',
        /** 删除标志 */
        isDeleted: '',
        /**  */
        applicationsId: '',
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
      this.$request.save('resource', this.form, function(respose) {
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
        this.title = '编辑资源信息'
        const _this = this
        this.$request.get('resource/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
