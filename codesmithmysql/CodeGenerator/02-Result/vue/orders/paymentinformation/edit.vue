<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="支付流水号" hintText="请输入支付流水号" v-model="form.flowNumber"  lab labelFloat/>
         <mu-text-field label="第三方支付流水号" hintText="请输入第三方支付流水号" v-model="form.paySerialNumber"  lab labelFloat/>
         <mu-text-field label="支付项目编号" hintText="请输入支付项目编号" v-model="form.payItemCode"  lab labelFloat/>
         <mu-text-field label="支付项目名称" hintText="请输入支付项目名称" v-model="form.payItemName"  lab labelFloat/>
         <mu-text-field label="订单号" hintText="请输入订单号" v-model="form.orderId"  lab labelFloat/>
         <mu-text-field label="发票编号" hintText="请输入发票编号" v-model="form.noteCode"  lab labelFloat/>
         <mu-text-field label="客户(患者)编号" hintText="请输入客户(患者)编号" v-model="form.customertId"  lab labelFloat/>
         <mu-text-field label="客户(患者)姓名" hintText="请输入客户(患者)姓名" v-model="form.customerName"  lab labelFloat/>
         <mu-text-field label="客户(患者)其他信息" hintText="请输入客户(患者)其他信息" v-model="form.customerOthterMessage"  lab labelFloat/>
         <mu-text-field label="支付总金额" hintText="请输入支付总金额" v-model="form.payMoeny"  lab labelFloat/>
         <mu-date-picker  label="缴费时间" hintText="请输入缴费时间" v-model="form.payTime"  lab labelFloat/>
         <mu-text-field label="申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)" hintText="请输入申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="来源类型(1门诊，2.住院.3. 购药)" hintText="请输入来源类型(1门诊，2.住院.3. 购药)" v-model="form.sourceType"  lab labelFloat/>
         <mu-text-field label="支付总条数（单付金额需要除以此项）" hintText="请输入支付总条数（单付金额需要除以此项）" v-model="form.payCount"  lab labelFloat/>
         <mu-text-field label="现金支付金额" hintText="请输入现金支付金额" v-model="form.cash"  lab labelFloat/>
         <mu-text-field label="微信支付" hintText="请输入微信支付" v-model="form.weixin"  lab labelFloat/>
         <mu-text-field label="支付宝支付" hintText="请输入支付宝支付" v-model="form.alipay"  lab labelFloat/>
         <mu-text-field label="银行卡支付" hintText="请输入银行卡支付" v-model="form.bankCard"  lab labelFloat/>
         <mu-text-field label="银行卡类型" hintText="请输入银行卡类型" v-model="form.cardType"  lab labelFloat/>
         <mu-text-field label="医保支付" hintText="请输入医保支付" v-model="form.ybMoney"  lab labelFloat/>
         <mu-text-field label="医保类型" hintText="请输入医保类型" v-model="form.ybType"  lab labelFloat/>
         <mu-text-field label="抵扣金额" hintText="请输入抵扣金额" v-model="form.deductiblePayment"  lab labelFloat/>
         <mu-text-field label="大学生减免金额" hintText="请输入大学生减免金额" v-model="form.collegeStudentPayment"  lab labelFloat/>
         <mu-text-field label="收费员编号" hintText="请输入收费员编号" v-model="form.tollCollectorUserId"  lab labelFloat/>
         <mu-text-field label="收费员" hintText="请输入收费员" v-model="form.tollCollectorUserName"  lab labelFloat/>
         <mu-text-field label="退费前收费员" hintText="请输入退费前收费员" v-model="form.refundUserId"  lab labelFloat/>
         <mu-text-field label="退费前收费员" hintText="请输入退费前收费员" v-model="form.refundUserName"  lab labelFloat/>
         <mu-date-picker  label="退费前收费时间" hintText="请输入退费前收费时间" v-model="form.originalDate"  lab labelFloat/>
         <mu-text-field label="抹零差价" hintText="请输入抹零差价" v-model="form.moenyDifference"  lab labelFloat/>
         <mu-text-field label="开单人编号" hintText="请输入开单人编号" v-model="form.userId"  lab labelFloat/>
         <mu-text-field label="开单人" hintText="请输入开单人" v-model="form.userName"  lab labelFloat/>
         <mu-date-picker  label="开单时间" hintText="请输入开单时间" v-model="form.orderDate"  lab labelFloat/>
         <mu-text-field label="科室编号" hintText="请输入科室编号" v-model="form.departmentId"  lab labelFloat/>
         <mu-text-field label="科室" hintText="请输入科室" v-model="form.department"  lab labelFloat/>
         <mu-date-picker  label="开单时间" hintText="请输入开单时间" v-model="form.openTime"  lab labelFloat/>
         <mu-text-field label="核算科室编号" hintText="请输入核算科室编号" v-model="form.accountingDepartmentId"  lab labelFloat/>
         <mu-text-field label="核算科室" hintText="请输入核算科室" v-model="form.accountingDepartment"  lab labelFloat/>
         <mu-text-field label="核算人" hintText="请输入核算人" v-model="form.accountingUserId"  lab labelFloat/>
         <mu-text-field label="核算人" hintText="请输入核算人" v-model="form.accountingUserName"  lab labelFloat/>
         <mu-date-picker  label="核算时间" hintText="请输入核算时间" v-model="form.accountingTime"  lab labelFloat/>
         <mu-date-picker  label="结算时间" hintText="请输入结算时间" v-model="form.settlementTime"  lab labelFloat/>
         <mu-text-field label="备注" hintText="请输入备注" v-model="form.remark"  lab labelFloat/>
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
  name: 'paymentinformation-edit',
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
      title: '新增支付信息信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 支付流水号 */
        flowNumber: '',
        /** 第三方支付流水号 */
        paySerialNumber: '',
        /** 支付项目编号 */
        payItemCode: '',
        /** 支付项目名称 */
        payItemName: '',
        /** 订单号 */
        orderId: '',
        /** 发票编号 */
        noteCode: '',
        /** 客户(患者)编号 */
        customertId: '',
        /** 客户(患者)姓名 */
        customerName: '',
        /** 客户(患者)其他信息 */
        customerOthterMessage: '',
        /** 支付总金额 */
        payMoeny: 0,
        /** 缴费时间 */
        payTime: Date.now(),
        /** 申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号) */
        type: 0,
        /** 来源类型(1门诊，2.住院.3. 购药) */
        sourceType: 0,
        /** 支付总条数（单付金额需要除以此项） */
        payCount: 0,
        /** 现金支付金额 */
        cash: 0,
        /** 微信支付 */
        weixin: 0,
        /** 支付宝支付 */
        alipay: 0,
        /** 银行卡支付 */
        bankCard: 0,
        /** 银行卡类型 */
        cardType: 0,
        /** 医保支付 */
        ybMoney: 0,
        /** 医保类型 */
        ybType: 0,
        /** 抵扣金额 */
        deductiblePayment: 0,
        /** 大学生减免金额 */
        collegeStudentPayment: 0,
        /** 收费员编号 */
        tollCollectorUserId: '',
        /** 收费员 */
        tollCollectorUserName: '',
        /** 退费前收费员 */
        refundUserId: '',
        /** 退费前收费员 */
        refundUserName: '',
        /** 退费前收费时间 */
        originalDate: Date.now(),
        /** 抹零差价 */
        moenyDifference: 0,
        /** 开单人编号 */
        userId: '',
        /** 开单人 */
        userName: '',
        /** 开单时间 */
        orderDate: Date.now(),
        /** 科室编号 */
        departmentId: '',
        /** 科室 */
        department: '',
        /** 开单时间 */
        openTime: Date.now(),
        /** 核算科室编号 */
        accountingDepartmentId: '',
        /** 核算科室 */
        accountingDepartment: '',
        /** 核算人 */
        accountingUserId: '',
        /** 核算人 */
        accountingUserName: '',
        /** 核算时间 */
        accountingTime: Date.now(),
        /** 结算时间 */
        settlementTime: Date.now(),
        /** 备注 */
        remark: '',
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
      this.$request.save('paymentinformation', this.form, function(respose) {
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
        this.title = '编辑支付信息信息'
        const _this = this
        this.$request.get('paymentinformation/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
