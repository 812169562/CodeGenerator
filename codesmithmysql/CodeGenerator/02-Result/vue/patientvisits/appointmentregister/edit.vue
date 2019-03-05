<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="坐诊Id" hintText="请输入坐诊Id" v-model="form.doctorSittingId"  lab labelFloat/>
         <mu-text-field label="医生Id" hintText="请输入医生Id" v-model="form.doctorId"  lab labelFloat/>
         <mu-text-field label="医生姓名" hintText="请输入医生姓名" v-model="form.doctorName"  lab labelFloat/>
         <mu-text-field label="科室Id" hintText="请输入科室Id" v-model="form.departmentId"  lab labelFloat/>
         <mu-text-field label="科室名称" hintText="请输入科室名称" v-model="form.departmentName"  lab labelFloat/>
         <mu-text-field label="坐诊地点" hintText="请输入坐诊地点" v-model="form.sittingAddress"  lab labelFloat/>
         <mu-text-field label="支付状态" hintText="请输入支付状态" v-model="form.paymentStatus"  lab labelFloat/>
         <mu-text-field label="挂号Id" hintText="请输入挂号Id" v-model="form.registerId"  lab labelFloat/>
         <mu-text-field label="病人Id" hintText="请输入病人Id" v-model="form.patientId"  lab labelFloat/>
         <mu-text-field label="是否超时" hintText="请输入是否超时" v-model="form.isTimeout"  lab labelFloat/>
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
  name: 'appointmentregister-edit',
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
      title: '新增预约挂号信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 坐诊Id */
        doctorSittingId: '',
        /** 医生Id */
        doctorId: '',
        /** 医生姓名 */
        doctorName: '',
        /** 科室Id */
        departmentId: '',
        /** 科室名称 */
        departmentName: '',
        /** 坐诊地点 */
        sittingAddress: '',
        /** 支付状态 */
        paymentStatus: 0,
        /** 挂号Id */
        registerId: '',
        /** 病人Id */
        patientId: '',
        /** 是否超时 */
        isTimeout: '',
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
      this.$request.save('appointmentregister', this.form, function(respose) {
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
        this.title = '编辑预约挂号信息'
        const _this = this
        this.$request.get('appointmentregister/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
