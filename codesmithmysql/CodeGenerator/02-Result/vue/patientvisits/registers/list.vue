
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
 <el-table ref="multipleTable"  column-key="id" tooltip-effect="dark" style="width: 100%" max-height="780" :height="fullHeight" size="small" :data="registersData"  @selection-change="handleSelectionChange">
 <el-table-column prop="selected" fixed="left" type="selection"  width="55" > </el-table-column>
 <el-table-column type="index"  fixed="left" label="序号"    width="55"></el-table-column>
         <el-table-column prop="stroeId" label="门店号" width="100"></el-table-column>
         <el-table-column prop="registerDate" label="挂号日期" width="180"></el-table-column>
         <el-table-column prop="registerNumber" label="挂号顺序号" width="100"></el-table-column>
         <el-table-column prop="timeSlot" label="挂号时间段 (1.上午，2.下午.3.夜晚)" width="100"></el-table-column>
         <el-table-column prop="patType" label="患者类型" width="100"></el-table-column>
         <el-table-column prop="userId" label="患者编号" width="100"></el-table-column>
         <el-table-column prop="userName" label="患者姓名" width="100"></el-table-column>
         <el-table-column prop="userBorn" label="患者生日" width="180"></el-table-column>
         <el-table-column prop="userPhone" label="患者电话号码" width="100"></el-table-column>
         <el-table-column prop="userAddress" label="患者地址" width="100"></el-table-column>
         <el-table-column prop="userSex" label="患者性别" width="100"></el-table-column>
         <el-table-column prop="departmentId" label="科室" width="100"></el-table-column>
         <el-table-column prop="department" label="科室" width="100"></el-table-column>
         <el-table-column prop="doctorId" label="挂号医生" width="100"></el-table-column>
         <el-table-column prop="doctorName" label="挂号姓名" width="100"></el-table-column>
         <el-table-column prop="userFrom" label="患者来源 (0.正常挂号，1.预约挂号)" width="100"></el-table-column>
         <el-table-column prop="receiveDate" label="接诊日期" width="180"></el-table-column>
         <el-table-column prop="receiveDoctorId" label="接诊医生" width="100"></el-table-column>
         <el-table-column prop="receiveDoctorName" label="接诊医生" width="100"></el-table-column>
         <el-table-column prop="registerType" label="挂号类型(0,普通挂号，1.急诊挂号，2.便民门诊)" width="100"></el-table-column>
         <el-table-column prop="treatmentType" label="诊疗类型(0.初诊,1复诊)" width="100"></el-table-column>
         <el-table-column prop="payDate" label="支付时间" width="180"></el-table-column>
         <el-table-column prop="money" label="挂号金额=检查费+就诊费=社保支付+现金支付+会员卡支付+银行卡支付+支付宝+微信" width="100"></el-table-column>
         <el-table-column prop="checkMoney" label="检查费金额" width="100"></el-table-column>
         <el-table-column prop="registerMoney" label="挂号费金额" width="100"></el-table-column>
         <el-table-column prop="sbMoney" label="社保支付金额" width="100"></el-table-column>
         <el-table-column prop="cashMoney" label="现金支付金额" width="100"></el-table-column>
         <el-table-column prop="cardMoney" label="会员卡支付金额" width="100"></el-table-column>
         <el-table-column prop="bankMoney" label="银行支付金额" width="100"></el-table-column>
         <el-table-column prop="weiXinMoeny" label="微信支付金额" width="100"></el-table-column>
         <el-table-column prop="alipayMoeny" label="支付宝支付金额" width="100"></el-table-column>
         <el-table-column prop="paymentStatus" label="支付状态" width="100"></el-table-column>
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
 <registers-edit :dialogVisible="dialog" @closeAdd="_addClose" :id="childId"></registers-edit>
</div>
</template>
<script>
import RegistersEdit from './edit'
export default {
  /** 页面绑定数据 */
  data() {
    return {
      /** 页面table绑定数据 */
      registersData: [],
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
    /**  查询分页信息 @for Registers */
    query() {
      const _this = this
      this.$request.get(
        'registers/page',
        {
          pageIndex: _this.current,
          pageSize: _this.pageSize,
          queryData: _this.queryData
        },
        respose => {
          _this.registersData = respose.data.result
          _this.total = respose.data.totalCount
          _this.current = respose.data.pageIndex
        }
      )
    },
    /**  弹出添加数据页面 @for Registers */
    add() {
      this.childId = ''
      this.dialog = true
    },
    /**  删除选中数据  @for Registers
     * @param 当前选中数据
     */
    del(row) {
      const registers = this.selectdata(row)
      if (!registers || registers.length === 0) {
        this.$message.error('请选择一条数据！')
        return
      }
      this.$request.delete('registers', { registers }, respose => {
        this.query()
      })
    },
    /**  编辑选中数据  @for Registers
     * @param 当前选中数据
     */
    edit(registers) {
      this.childId = registers.id
      this.dialog = true
    },
    /**  停用选中数据  @for Registers
     * @param 当前选中数据
     */
    stop(row, isEnable) {
      const registers = this.selectdata(row)
      if (!registers || registers.length === 0) {
        this.$message.error('请选择一条数据！')
        return
      }
      if (registers.find(t => t.isEnable === isEnable)) {
        this.$message.error('请选择同一种类型进行批量操作！')
        return
      }
      let msg = ''
      if (isEnable) {
        msg = '是否启用该项目？'
      }
      this.$request.stop(
        'registers/stop',
        { registers, isEnable },
        respose => {
          this.query()
        },
        null,
        msg
      )
    },
    /**  事件-修改分页大小  @for Registers
     * @param 选中分页大小
     */
    sizeChange(pageSize) {
      this.pageSize = pageSize
      this.query()
    },
    /** 事件-改变分页当前页   @for Registers
     * @param 选中分页大小
     */
    currentChange(current) {
      this.current = current
      this.query()
    },
    /** 事件-选中行   @for Registers
     * @param 当前选中行
     */
    handleSelectionChange(val) {
      this.multipleSelection = val
    },
    /** 回调-子窗口添加完成之后回调关闭刷新当前页面   @for Registers
     * @param 当前选中行
     */
    _addClose(evtValue, refresh) {
      this.dialog = evtValue
      if (refresh) {
        this.query()
      }
    },
    /** 添加当前选中数据到集合内   @for Registers
     * @param 当前选中行
     */
    selectdata(row) {
      const registers = []
      if (row) {
        registers.push(row)
      } else {
        this.multipleSelection.forEach(element => {
          registers.push(element)
        })
      }
      return registers
    },
    /** 页面验证
     * @param 类型
     * @return true 通过 false 未通过
     */
    checked(type) {}
  },
  /** 引用组建 */
  components: {
    'registers-edit': RegistersEdit
  }
}
</script>
