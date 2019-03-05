<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="类型" hintText="请输入类型" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="代码" hintText="请输入代码" v-model="form.code"  lab labelFloat/>
         <mu-text-field label="名称" hintText="请输入名称" v-model="form.name"  lab labelFloat/>
         <mu-text-field label="拼音简拼" hintText="请输入拼音简拼" v-model="form.pinYin"  lab labelFloat/>
         <mu-text-field label="全拼" hintText="请输入全拼" v-model="form.fullPinYin"  lab labelFloat/>
         <mu-text-field label="五笔" hintText="请输入五笔" v-model="form.wubi"  lab labelFloat/>
         <mu-text-field label="关系" hintText="请输入关系" v-model="form.relationShip"  lab labelFloat/>
         <mu-text-field label="父级" hintText="请输入父级" v-model="form.parent"  lab labelFloat/>
         <mu-text-field label="等级" hintText="请输入等级" v-model="form.level"  lab labelFloat/>
         <mu-text-field label="排序" hintText="请输入排序" v-model="form.sort"  lab labelFloat/>
         <mu-text-field label="是否可共享科室患者" hintText="请输入是否可共享科室患者" v-model="form.isSharePatient"  lab labelFloat/>
         <mu-text-field label="是否为执行科室" hintText="请输入是否为执行科室" v-model="form.isExecute"  lab labelFloat/>
         <mu-text-field label="是否为药房" hintText="请输入是否为药房" v-model="form.isPharmacy"  lab labelFloat/>
         <mu-text-field label="是否为库房" hintText="请输入是否为库房" v-model="form.isStorageRoom"  lab labelFloat/>
         <mu-text-field label="科室挂号费" hintText="请输入科室挂号费" v-model="form.registerPrice"  lab labelFloat/>
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
  name: 'department-edit',
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
      title: '新增部门信息信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 类型 */
        type: 0,
        /** 代码 */
        code: '',
        /** 名称 */
        name: '',
        /** 拼音简拼 */
        pinYin: '',
        /** 全拼 */
        fullPinYin: '',
        /** 五笔 */
        wubi: '',
        /** 关系 */
        relationShip: '',
        /** 父级 */
        parent: '',
        /** 等级 */
        level: 0,
        /** 排序 */
        sort: 0,
        /** 删除标志 */
        isDeleted: '',
        /** 是否可共享科室患者 */
        isSharePatient: '',
        /** 是否为执行科室 */
        isExecute: '',
        /** 是否为药房 */
        isPharmacy: '',
        /** 是否为库房 */
        isStorageRoom: '',
        /** 科室挂号费 */
        registerPrice: 0,
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
      this.$request.save('department', this.form, function(respose) {
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
        this.title = '编辑部门信息信息'
        const _this = this
        this.$request.get('department/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
