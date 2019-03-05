
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
 <el-table ref="multipleTable"  column-key="id" tooltip-effect="dark" style="width: 100%" max-height="780" :height="fullHeight" size="small" :data="druginoutinfoData"  @selection-change="handleSelectionChange">
 <el-table-column prop="selected" fixed="left" type="selection"  width="55" > </el-table-column>
 <el-table-column type="index"  fixed="left" label="序号"    width="55"></el-table-column>
         <el-table-column prop="drugInOutId" label="出入库编号" width="100"></el-table-column>
         <el-table-column prop="batchId" label="批次编号" width="100"></el-table-column>
         <el-table-column prop="drugId" label="药品编号" width="100"></el-table-column>
         <el-table-column prop="drugName" label="药品名称" width="100"></el-table-column>
         <el-table-column prop="format" label="规格" width="100"></el-table-column>
         <el-table-column prop="salesPrice" label="销售价(包装单位)" width="100"></el-table-column>
         <el-table-column prop="salesUnitId" label="销售单位" width="100"></el-table-column>
         <el-table-column prop="salesUnit" label="销售单位" width="100"></el-table-column>
         <el-table-column prop="costPrice" label="成本价(包装单位)" width="100"></el-table-column>
         <el-table-column prop="inOutCount" label="调拨入库数量(销售单位为数量)" width="100"></el-table-column>
         <el-table-column prop="batchCode" label="药品生产批号" width="100"></el-table-column>
         <el-table-column prop="expiryDate" label="有效期" width="180"></el-table-column>
         <el-table-column prop="manufactureDate" label="生产日期" width="180"></el-table-column>
         <el-table-column prop="isModifyPrice" label="是否调价" width="100"></el-table-column>
         <el-table-column prop="modifyPrice" label="调整之后价格" width="100"></el-table-column>
         <el-table-column prop="modifyPriceDate" label="调价生效日期" width="180"></el-table-column>
         <el-table-column prop="modifyPriceCount" label="剩余多少库存之后调价生效" width="100"></el-table-column>
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
 <druginoutinfo-edit :dialogVisible="dialog" @closeAdd="_addClose" :id="childId"></druginoutinfo-edit>
</div>
</template>
<script>
import DruginoutinfoEdit from './edit'
export default {
  /** 页面绑定数据 */
  data() {
    return {
      /** 页面table绑定数据 */
      druginoutinfoData: [],
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
    /**  查询分页信息 @for Druginoutinfo */
    query() {
      const _this = this
      this.$request.get(
        'druginoutinfo/page',
        {
          pageIndex: _this.current,
          pageSize: _this.pageSize,
          queryData: _this.queryData
        },
        respose => {
          _this.druginoutinfoData = respose.data.result
          _this.total = respose.data.totalCount
          _this.current = respose.data.pageIndex
        }
      )
    },
    /**  弹出添加数据页面 @for Druginoutinfo */
    add() {
      this.childId = ''
      this.dialog = true
    },
    /**  删除选中数据  @for Druginoutinfo
     * @param 当前选中数据
     */
    del(row) {
      const druginoutinfo = this.selectdata(row)
      if (!druginoutinfo || druginoutinfo.length === 0) {
        this.$message.error('请选择一条数据！')
        return
      }
      this.$request.delete('druginoutinfo', { druginoutinfo }, respose => {
        this.query()
      })
    },
    /**  编辑选中数据  @for Druginoutinfo
     * @param 当前选中数据
     */
    edit(druginoutinfo) {
      this.childId = druginoutinfo.id
      this.dialog = true
    },
    /**  停用选中数据  @for Druginoutinfo
     * @param 当前选中数据
     */
    stop(row, isEnable) {
      const druginoutinfo = this.selectdata(row)
      if (!druginoutinfo || druginoutinfo.length === 0) {
        this.$message.error('请选择一条数据！')
        return
      }
      if (druginoutinfo.find(t => t.isEnable === isEnable)) {
        this.$message.error('请选择同一种类型进行批量操作！')
        return
      }
      let msg = ''
      if (isEnable) {
        msg = '是否启用该项目？'
      }
      this.$request.stop(
        'druginoutinfo/stop',
        { druginoutinfo, isEnable },
        respose => {
          this.query()
        },
        null,
        msg
      )
    },
    /**  事件-修改分页大小  @for Druginoutinfo
     * @param 选中分页大小
     */
    sizeChange(pageSize) {
      this.pageSize = pageSize
      this.query()
    },
    /** 事件-改变分页当前页   @for Druginoutinfo
     * @param 选中分页大小
     */
    currentChange(current) {
      this.current = current
      this.query()
    },
    /** 事件-选中行   @for Druginoutinfo
     * @param 当前选中行
     */
    handleSelectionChange(val) {
      this.multipleSelection = val
    },
    /** 回调-子窗口添加完成之后回调关闭刷新当前页面   @for Druginoutinfo
     * @param 当前选中行
     */
    _addClose(evtValue, refresh) {
      this.dialog = evtValue
      if (refresh) {
        this.query()
      }
    },
    /** 添加当前选中数据到集合内   @for Druginoutinfo
     * @param 当前选中行
     */
    selectdata(row) {
      const druginoutinfo = []
      if (row) {
        druginoutinfo.push(row)
      } else {
        this.multipleSelection.forEach(element => {
          druginoutinfo.push(element)
        })
      }
      return druginoutinfo
    },
    /** 页面验证
     * @param 类型
     * @return true 通过 false 未通过
     */
    checked(type) {}
  },
  /** 引用组建 */
  components: {
    'druginoutinfo-edit': DruginoutinfoEdit
  }
}
</script>
