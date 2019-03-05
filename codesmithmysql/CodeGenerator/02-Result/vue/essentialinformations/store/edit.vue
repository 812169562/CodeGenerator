<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="租户名" hintText="请输入租户名" v-model="form.tenantName"  lab labelFloat/>
         <mu-text-field label="店长编号" hintText="请输入店长编号" v-model="form.userId"  lab labelFloat/>
         <mu-text-field label="联系人" hintText="请输入联系人" v-model="form.telName"  lab labelFloat/>
         <mu-text-field label="联系地址" hintText="请输入联系地址" v-model="form.address"  lab labelFloat/>
         <mu-text-field label="联系电话" hintText="请输入联系电话" v-model="form.telPhone"  lab labelFloat/>
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.code"  lab labelFloat/>
         <mu-text-field label="坐标" hintText="请输入坐标" v-model="form.coordinate"  lab labelFloat/>
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
  name: 'store-edit',
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
      title: '新增门店信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 租户名 */
        tenantName: '',
        /** 店长编号 */
        userId: '',
        /** 联系人 */
        telName: '',
        /** 联系地址 */
        address: '',
        /** 联系电话 */
        telPhone: '',
        /** 门店号 */
        code: '',
        /** 坐标 */
        coordinate: '',
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
      this.$request.save('store', this.form, function(respose) {
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
        this.title = '编辑门店信息'
        const _this = this
        this.$request.get('store/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
