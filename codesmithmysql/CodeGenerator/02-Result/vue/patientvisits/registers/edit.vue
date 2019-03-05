<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-date-picker  label="挂号日期" hintText="请输入挂号日期" v-model="form.registerDate"  lab labelFloat/>
         <mu-text-field label="挂号顺序号" hintText="请输入挂号顺序号" v-model="form.registerNumber"  lab labelFloat/>
         <mu-text-field label="挂号时间段 (1.上午，2.下午.3.夜晚)" hintText="请输入挂号时间段 (1.上午，2.下午.3.夜晚)" v-model="form.timeSlot"  lab labelFloat/>
         <mu-text-field label="患者类型" hintText="请输入患者类型" v-model="form.patType"  lab labelFloat/>
         <mu-text-field label="患者编号" hintText="请输入患者编号" v-model="form.userId"  lab labelFloat/>
         <mu-text-field label="患者姓名" hintText="请输入患者姓名" v-model="form.userName"  lab labelFloat/>
         <mu-date-picker  label="患者生日" hintText="请输入患者生日" v-model="form.userBorn"  lab labelFloat/>
         <mu-text-field label="患者电话号码" hintText="请输入患者电话号码" v-model="form.userPhone"  lab labelFloat/>
         <mu-text-field label="患者地址" hintText="请输入患者地址" v-model="form.userAddress"  lab labelFloat/>
         <mu-text-field label="患者性别" hintText="请输入患者性别" v-model="form.userSex"  lab labelFloat/>
         <mu-text-field label="科室" hintText="请输入科室" v-model="form.departmentId"  lab labelFloat/>
         <mu-text-field label="科室" hintText="请输入科室" v-model="form.department"  lab labelFloat/>
         <mu-text-field label="挂号医生" hintText="请输入挂号医生" v-model="form.doctorId"  lab labelFloat/>
         <mu-text-field label="挂号姓名" hintText="请输入挂号姓名" v-model="form.doctorName"  lab labelFloat/>
         <mu-text-field label="患者来源 (0.正常挂号，1.预约挂号)" hintText="请输入患者来源 (0.正常挂号，1.预约挂号)" v-model="form.userFrom"  lab labelFloat/>
         <mu-date-picker  label="接诊日期" hintText="请输入接诊日期" v-model="form.receiveDate"  lab labelFloat/>
         <mu-text-field label="接诊医生" hintText="请输入接诊医生" v-model="form.receiveDoctorId"  lab labelFloat/>
         <mu-text-field label="接诊医生" hintText="请输入接诊医生" v-model="form.receiveDoctorName"  lab labelFloat/>
         <mu-text-field label="挂号类型(0,普通挂号，1.急诊挂号，2.便民门诊)" hintText="请输入挂号类型(0,普通挂号，1.急诊挂号，2.便民门诊)" v-model="form.registerType"  lab labelFloat/>
         <mu-text-field label="诊疗类型(0.初诊,1复诊)" hintText="请输入诊疗类型(0.初诊,1复诊)" v-model="form.treatmentType"  lab labelFloat/>
         <mu-date-picker  label="支付时间" hintText="请输入支付时间" v-model="form.payDate"  lab labelFloat/>
         <mu-text-field label="挂号金额=检查费+就诊费=社保支付+现金支付+会员卡支付+银行卡支付+支付宝+微信" hintText="请输入挂号金额=检查费+就诊费=社保支付+现金支付+会员卡支付+银行卡支付+支付宝+微信" v-model="form.money"  lab labelFloat/>
         <mu-text-field label="检查费金额" hintText="请输入检查费金额" v-model="form.checkMoney"  lab labelFloat/>
         <mu-text-field label="挂号费金额" hintText="请输入挂号费金额" v-model="form.registerMoney"  lab labelFloat/>
         <mu-text-field label="社保支付金额" hintText="请输入社保支付金额" v-model="form.sbMoney"  lab labelFloat/>
         <mu-text-field label="现金支付金额" hintText="请输入现金支付金额" v-model="form.cashMoney"  lab labelFloat/>
         <mu-text-field label="会员卡支付金额" hintText="请输入会员卡支付金额" v-model="form.cardMoney"  lab labelFloat/>
         <mu-text-field label="银行支付金额" hintText="请输入银行支付金额" v-model="form.bankMoney"  lab labelFloat/>
         <mu-text-field label="微信支付金额" hintText="请输入微信支付金额" v-model="form.weiXinMoeny"  lab labelFloat/>
         <mu-text-field label="支付宝支付金额" hintText="请输入支付宝支付金额" v-model="form.alipayMoeny"  lab labelFloat/>
         <mu-text-field label="支付状态" hintText="请输入支付状态" v-model="form.paymentStatus"  lab labelFloat/>
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
  name: 'registers-edit',
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
      title: '新增挂号信息信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 挂号日期 */
        registerDate: Date.now(),
        /** 挂号顺序号 */
        registerNumber: 0,
        /** 挂号时间段 (1.上午，2.下午.3.夜晚) */
        timeSlot: 0,
        /** 患者类型 */
        patType: 0,
        /** 患者编号 */
        userId: '',
        /** 患者姓名 */
        userName: '',
        /** 患者生日 */
        userBorn: Date.now(),
        /** 患者电话号码 */
        userPhone: '',
        /** 患者地址 */
        userAddress: '',
        /** 患者性别 */
        userSex: '',
        /** 科室 */
        departmentId: '',
        /** 科室 */
        department: '',
        /** 挂号医生 */
        doctorId: '',
        /** 挂号姓名 */
        doctorName: '',
        /** 患者来源 (0.正常挂号，1.预约挂号) */
        userFrom: 0,
        /** 接诊日期 */
        receiveDate: Date.now(),
        /** 接诊医生 */
        receiveDoctorId: '',
        /** 接诊医生 */
        receiveDoctorName: '',
        /** 删除标志 */
        isDeleted: '',
        /** 挂号类型(0,普通挂号，1.急诊挂号，2.便民门诊) */
        registerType: 0,
        /** 诊疗类型(0.初诊,1复诊) */
        treatmentType: 0,
        /** 支付时间 */
        payDate: Date.now(),
        /** 挂号金额=检查费+就诊费=社保支付+现金支付+会员卡支付+银行卡支付+支付宝+微信 */
        money: 0,
        /** 检查费金额 */
        checkMoney: 0,
        /** 挂号费金额 */
        registerMoney: 0,
        /** 社保支付金额 */
        sbMoney: 0,
        /** 现金支付金额 */
        cashMoney: 0,
        /** 会员卡支付金额 */
        cardMoney: 0,
        /** 银行支付金额 */
        bankMoney: 0,
        /** 微信支付金额 */
        weiXinMoeny: 0,
        /** 支付宝支付金额 */
        alipayMoeny: 0,
        /** 支付状态 */
        paymentStatus: 0,
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
      this.$request.save('registers', this.form, function(respose) {
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
        this.title = '编辑挂号信息信息'
        const _this = this
        this.$request.get('registers/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
