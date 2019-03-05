<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="医馆名" hintText="请输入医馆名" v-model="form.tenantName"  lab labelFloat/>
         <mu-text-field label="用户号" hintText="请输入用户号" v-model="form.userId"  lab labelFloat/>
         <mu-text-field label="联系人" hintText="请输入联系人" v-model="form.telName"  lab labelFloat/>
         <mu-text-field label="联系地址" hintText="请输入联系地址" v-model="form.address"  lab labelFloat/>
         <mu-text-field label="联系电话" hintText="请输入联系电话" v-model="form.telPhone"  lab labelFloat/>
         <mu-text-field label="坐标" hintText="请输入坐标" v-model="form.coordinate"  lab labelFloat/>
         <mu-text-field label="营业证书" hintText="请输入营业证书" v-model="form.businessCertificate"  lab labelFloat/>
         <mu-text-field label="最大门店数量" hintText="请输入最大门店数量" v-model="form.maxStore"  lab labelFloat/>
         <mu-text-field label="代码" hintText="请输入代码" v-model="form.code"  lab labelFloat/>
         <mu-date-picker  label="结束日期" hintText="请输入结束日期" v-model="form.endTime"  lab labelFloat/>
         <mu-text-field label="简介" hintText="请输入简介" v-model="form.description"  lab labelFloat/>
         <mu-text-field label="类型" hintText="请输入类型" v-model="form.type"  lab labelFloat/>
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
  name: 'tenant-edit',
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
      title: '新增医馆信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 医馆名 */
        tenantName: '',
        /** 用户号 */
        userId: '',
        /** 联系人 */
        telName: '',
        /** 联系地址 */
        address: '',
        /** 联系电话 */
        telPhone: '',
        /** 坐标 */
        coordinate: '',
        /** 营业证书 */
        businessCertificate: '',
        /** 最大门店数量 */
        maxStore: 0,
        /** 代码 */
        code: '',
        /** 结束日期 */
        endTime: Date.now(),
        /** 简介 */
        description: '',
        /** 类型 */
        type: 0,
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
      this.$request.save('tenant', this.form, function(respose) {
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
        this.title = '编辑医馆信息'
        const _this = this
        this.$request.get('tenant/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
