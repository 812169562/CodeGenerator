<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="门店名" hintText="请输入门店名" v-model="form.stroeName"  lab labelFloat/>
         <mu-text-field label="处方编号" hintText="请输入处方编号" v-model="form.code"  lab labelFloat/>
         <mu-text-field label="名称" hintText="请输入名称" v-model="form.name"  lab labelFloat/>
         <mu-text-field label="申请单编号" hintText="请输入申请单编号" v-model="form.prescriptionCode"  lab labelFloat/>
         <mu-text-field label="申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)" hintText="请输入申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="处方类型(0.普通,1.精一.2.精二.3.中药饮片,4.中药免检.5.中药小包装)" hintText="请输入处方类型(0.普通,1.精一.2.精二.3.中药饮片,4.中药免检.5.中药小包装)" v-model="form.prescriptionType"  lab labelFloat/>
         <mu-text-field label="来源类型(1门诊，2.住院.3. 购药)" hintText="请输入来源类型(1门诊，2.住院.3. 购药)" v-model="form.sourceType"  lab labelFloat/>
         <mu-text-field label="客户(患者)编号" hintText="请输入客户(患者)编号" v-model="form.customertId"  lab labelFloat/>
         <mu-text-field label="客户(患者)姓名" hintText="请输入客户(患者)姓名" v-model="form.customerName"  lab labelFloat/>
         <mu-text-field label="客户(患者)其他信息" hintText="请输入客户(患者)其他信息" v-model="form.customerOthterMessage"  lab labelFloat/>
         <mu-date-picker  label="订单过期时间" hintText="请输入订单过期时间" v-model="form.expiryTime"  lab labelFloat/>
         <mu-text-field label="项目条数" hintText="请输入项目条数" v-model="form.count"  lab labelFloat/>
         <mu-text-field label="项目金额" hintText="请输入项目金额" v-model="form.money"  lab labelFloat/>
         <mu-text-field label="抵扣金额" hintText="请输入抵扣金额" v-model="form.reductionMoeny"  lab labelFloat/>
         <mu-text-field label="开单人编号" hintText="请输入开单人编号" v-model="form.userId"  lab labelFloat/>
         <mu-text-field label="开单人" hintText="请输入开单人" v-model="form.userName"  lab labelFloat/>
         <mu-date-picker  label="开单时间" hintText="请输入开单时间" v-model="form.orderDate"  lab labelFloat/>
         <mu-text-field label="科室编号" hintText="请输入科室编号" v-model="form.departmentId"  lab labelFloat/>
         <mu-text-field label="科室" hintText="请输入科室" v-model="form.department"  lab labelFloat/>
         <mu-text-field label="核算科室编号" hintText="请输入核算科室编号" v-model="form.accountingDepartmentId"  lab labelFloat/>
         <mu-text-field label="核算科室" hintText="请输入核算科室" v-model="form.accountingDepartment"  lab labelFloat/>
         <mu-text-field label="核算人" hintText="请输入核算人" v-model="form.accountingUserId"  lab labelFloat/>
         <mu-text-field label="核算人" hintText="请输入核算人" v-model="form.accountingUserName"  lab labelFloat/>
         <mu-date-picker  label="核算时间" hintText="请输入核算时间" v-model="form.accountingDate"  lab labelFloat/>
         <mu-text-field label="备注说明" hintText="请输入备注说明" v-model="form.remark"  lab labelFloat/>
         <mu-text-field label="是否允许修改" hintText="请输入是否允许修改" v-model="form.isModify"  lab labelFloat/>
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
  name: 'prescriptionorder-edit',
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
      title: '新增订单处方信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 门店名 */
        stroeName: '',
        /** 处方编号 */
        code: '',
        /** 名称 */
        name: '',
        /** 申请单编号 */
        prescriptionCode: '',
        /** 申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号) */
        type: 0,
        /** 处方类型(0.普通,1.精一.2.精二.3.中药饮片,4.中药免检.5.中药小包装) */
        prescriptionType: 0,
        /** 来源类型(1门诊，2.住院.3. 购药) */
        sourceType: 0,
        /** 客户(患者)编号 */
        customertId: '',
        /** 客户(患者)姓名 */
        customerName: '',
        /** 客户(患者)其他信息 */
        customerOthterMessage: '',
        /** 订单过期时间 */
        expiryTime: Date.now(),
        /** 项目条数 */
        count: 0,
        /** 项目金额 */
        money: 0,
        /** 抵扣金额 */
        reductionMoeny: 0,
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
        /** 核算科室编号 */
        accountingDepartmentId: '',
        /** 核算科室 */
        accountingDepartment: '',
        /** 核算人 */
        accountingUserId: '',
        /** 核算人 */
        accountingUserName: '',
        /** 核算时间 */
        accountingDate: Date.now(),
        /** 备注说明 */
        remark: '',
        /** 是否允许修改 */
        isModify: '',
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
      this.$request.save('prescriptionorder', this.form, function(respose) {
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
        this.title = '编辑订单处方信息'
        const _this = this
        this.$request.get('prescriptionorder/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
