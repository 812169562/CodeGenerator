
<template>
<div>
  <el-row>
    <el-col :xs="18" :sm="18" :md="14" :lg="17" :xl="18">
       <el-button type="primary" plain @click="add()">新增</el-button>
       <el-button  type="danger" plain secondary backgroundColor="#f78989" @click="stop(null,false)">停用</el-button>
       <el-button  type="success" plain backgroundColor="#85ce61" @click="stop(null,true)">启用</el-button>
       <el-button  type="info" plain class="demo-raised-button" backgroundColor="#909399" @click="del()">删除</el-button>
    </el-col>
    <el-col :xs="6" :sm="6" :md="10" :lg="7" :xl="6">
      <mu-text-field   class="appbar-search-field"  hintText="请输入搜索内容" v-model="queryData"  />
      <el-button type="success" plain size="small" @click="query()">检索</el-button>
    </el-col>
</el-row>
 <el-table ref="multipleTable"  column-key="id" tooltip-effect="dark" style="width: 100%" max-height="780" :height="fullHeight" size="small" :data="paymentinformationData"  @selection-change="handleSelectionChange">
 <el-table-column prop="selected" fixed="left" type="selection"  width="55" > </el-table-column>
 <el-table-column type="index"  fixed="left" label="序号"    width="55"></el-table-column>
         <el-table-column prop="flowNumber" label="支付流水号" width="100"></el-table-column>
         <el-table-column prop="paySerialNumber" label="第三方支付流水号" width="100"></el-table-column>
         <el-table-column prop="payItemCode" label="支付项目编号" width="100"></el-table-column>
         <el-table-column prop="payItemName" label="支付项目名称" width="100"></el-table-column>
         <el-table-column prop="orderId" label="订单号" width="100"></el-table-column>
         <el-table-column prop="noteCode" label="发票编号" width="100"></el-table-column>
         <el-table-column prop="customertId" label="客户(患者)编号" width="100"></el-table-column>
         <el-table-column prop="customerName" label="客户(患者)姓名" width="100"></el-table-column>
         <el-table-column prop="customerOthterMessage" label="客户(患者)其他信息" width="100"></el-table-column>
         <el-table-column prop="payMoeny" label="支付总金额" width="100"></el-table-column>
         <el-table-column prop="payTime" label="缴费时间" width="180"></el-table-column>
         <el-table-column prop="type" label="申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)" width="100"></el-table-column>
         <el-table-column prop="sourceType" label="来源类型(1门诊，2.住院.3. 购药)" width="100"></el-table-column>
         <el-table-column prop="payCount" label="支付总条数（单付金额需要除以此项）" width="100"></el-table-column>
         <el-table-column prop="cash" label="现金支付金额" width="100"></el-table-column>
         <el-table-column prop="weixin" label="微信支付" width="100"></el-table-column>
         <el-table-column prop="alipay" label="支付宝支付" width="100"></el-table-column>
         <el-table-column prop="bankCard" label="银行卡支付" width="100"></el-table-column>
         <el-table-column prop="cardType" label="银行卡类型" width="100"></el-table-column>
         <el-table-column prop="ybMoney" label="医保支付" width="100"></el-table-column>
         <el-table-column prop="ybType" label="医保类型" width="100"></el-table-column>
         <el-table-column prop="deductiblePayment" label="抵扣金额" width="100"></el-table-column>
         <el-table-column prop="collegeStudentPayment" label="大学生减免金额" width="100"></el-table-column>
         <el-table-column prop="tollCollectorUserId" label="收费员编号" width="100"></el-table-column>
         <el-table-column prop="tollCollectorUserName" label="收费员" width="100"></el-table-column>
         <el-table-column prop="refundUserId" label="退费前收费员" width="100"></el-table-column>
         <el-table-column prop="refundUserName" label="退费前收费员" width="100"></el-table-column>
         <el-table-column prop="originalDate" label="退费前收费时间" width="180"></el-table-column>
         <el-table-column prop="moenyDifference" label="抹零差价" width="100"></el-table-column>
         <el-table-column prop="userId" label="开单人编号" width="100"></el-table-column>
         <el-table-column prop="userName" label="开单人" width="100"></el-table-column>
         <el-table-column prop="orderDate" label="开单时间" width="180"></el-table-column>
         <el-table-column prop="departmentId" label="科室编号" width="100"></el-table-column>
         <el-table-column prop="department" label="科室" width="100"></el-table-column>
         <el-table-column prop="openTime" label="开单时间" width="180"></el-table-column>
         <el-table-column prop="accountingDepartmentId" label="核算科室编号" width="100"></el-table-column>
         <el-table-column prop="accountingDepartment" label="核算科室" width="100"></el-table-column>
         <el-table-column prop="accountingUserId" label="核算人" width="100"></el-table-column>
         <el-table-column prop="accountingUserName" label="核算人" width="100"></el-table-column>
         <el-table-column prop="accountingTime" label="核算时间" width="180"></el-table-column>
         <el-table-column prop="settlementTime" label="结算时间" width="180"></el-table-column>
         <el-table-column prop="remark" label="备注" width="100"></el-table-column>
    <el-table-column label="操作"  align="right">
    <template slot-scope="scope">
      <el-button size="mini" plain type="primary"  @click="edit(scope.row)">编辑</el-button>   
      <el-button size="mini" plain type="danger" v-if="scope.row.isEnable"  @click="stop(scope.row,false)">停用</el-button>
      <el-button size="mini" plain type="success"  v-else @click="stop(scope.row,true)">启用</el-button>
      <el-button size="mini" plain type="info"  @click="del(scope.row)">删除</el-button>
      </template>
    </el-table-column>
  </el-table>
    <el-pagination
         @size-change="sizeChange"
         @current-change="currentChange"
         :current-page="current"
         :page-sizes="pageSizeOption"
         :page-size="pageSize"
         layout="total, sizes, prev, pager, next, jumper"
         :total="total">
        </el-pagination>
 <paymentinformation-edit :dialogVisible="dialog" @closeAdd="_addClose" :id="childId"></paymentinformation-edit>
</div>
</template>
<script>
import PaymentinformationEdit from './edit'
export default {
  /** 页面绑定数据 */
  data() {
    return {
      /** 页面table绑定数据 */
      paymentinformationData: [],
      /** 新增编辑页面弹出框  */
      dialog: false,
      /** 分页总数据 初次加载绑定用 */
      total: 15,
      /** 当前页 */
      current: 1,
      /** 是否显示分页大小 */
      showSizeChanger: true,
      /** 当前页 */
      pageSize: 15,
      /** 每页数据大小 */
      pageSizeOption: [15, 30, 50, 100],
      /** 查询数据 */
      queryData: '',
      /** 已选中的数据 */
      multipleSelection: [],
      /** 当前窗体高度 */
      fullHeight: document.documentElement.clientHeight - 200,
      /** 子页面编号 */
      childId: ''
    }
  },
  /**  初始化只执行一次 */
  mounted: function() {
    this.query()
    // 然后监听window的resize事件．在浏览器窗口变化时再设置下背景图高度．
    const that = this
    window.onresize = () => {
      that.fullHeight = document.documentElement.clientHeight - 200
    }
  },
  methods: {
    /**  查询分页信息 @for Paymentinformation */
    query() {
      const _this = this
      this.$request.get(
        'paymentinformation/page',
        {
          pageIndex: _this.current,
          pageSize: _this.pageSize,
          queryData: _this.queryData
        },
        respose => {
          _this.paymentinformationData = respose.data.result
          _this.total = respose.data.totalCount
          _this.current = respose.data.pageIndex
        }
      )
    },
    /**  弹出添加数据页面 @for Paymentinformation */
    add() {
      this.childId = ''
      this.dialog = true
    },
    /**  删除选中数据  @for Paymentinformation
     * @param 当前选中数据
     */
    del(row) {
      const paymentinformation = this.selectdata(row)
      if (!paymentinformation || paymentinformation.length === 0) {
        this.$message.error('请选择一条数据！')
        return
      }
      this.$request.delete('paymentinformation', { paymentinformation }, respose => {
        this.query()
      })
    },
    /**  编辑选中数据  @for Paymentinformation
     * @param 当前选中数据
     */
    edit(paymentinformation) {
      this.childId = paymentinformation.id
      this.dialog = true
    },
    /**  停用选中数据  @for Paymentinformation
     * @param 当前选中数据
     */
    stop(row, isEnable) {
      const paymentinformation = this.selectdata(row)
      if (!paymentinformation || paymentinformation.length === 0) {
        this.$message.error('请选择一条数据！')
        return
      }
      if (paymentinformation.find(t => t.isEnable === isEnable)) {
        this.$message.error('请选择同一种类型进行批量操作！')
        return
      }
      let msg = ''
      if (isEnable) {
        msg = '是否启用该项目？'
      }
      this.$request.stop(
        'paymentinformation/stop',
        { paymentinformation, isEnable },
        respose => {
          this.query()
        },
        null,
        msg
      )
    },
    /**  事件-修改分页大小  @for Paymentinformation
     * @param 选中分页大小
     */
    sizeChange(pageSize) {
      this.pageSize = pageSize
      this.query()
    },
    /** 事件-改变分页当前页   @for Paymentinformation
     * @param 选中分页大小
     */
    currentChange(current) {
      this.current = current
      this.query()
    },
    /** 事件-选中行   @for Paymentinformation
     * @param 当前选中行
     */
    handleSelectionChange(val) {
      this.multipleSelection = val
    },
    /** 回调-子窗口添加完成之后回调关闭刷新当前页面   @for Paymentinformation
     * @param 当前选中行
     */
    _addClose(evtValue, refresh) {
      this.dialog = evtValue
      if (refresh) {
        this.query()
      }
    },
    /** 添加当前选中数据到集合内   @for Paymentinformation
     * @param 当前选中行
     */
    selectdata(row) {
      const paymentinformation = []
      if (row) {
        paymentinformation.push(row)
      } else {
        this.multipleSelection.forEach(element => {
          paymentinformation.push(element)
        })
      }
      return paymentinformation
    },
    /** 页面验证
     * @param 类型
     * @return true 通过 false 未通过
     */
    checked(type) {}
  },
  /** 引用组建 */
  components: {
    'paymentinformation-edit': PaymentinformationEdit
  }
}
</script>
