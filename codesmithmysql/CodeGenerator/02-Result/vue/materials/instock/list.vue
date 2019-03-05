
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
 <el-table ref="multipleTable"  column-key="id" tooltip-effect="dark" style="width: 100%" max-height="780" :height="fullHeight" size="small" :data="instockData"  @selection-change="handleSelectionChange">
 <el-table-column prop="selected" fixed="left" type="selection"  width="55" > </el-table-column>
 <el-table-column type="index"  fixed="left" label="序号"    width="55"></el-table-column>
         <el-table-column prop="stroeId" label="门店号" width="100"></el-table-column>
         <el-table-column prop="type" label="类型" width="100"></el-table-column>
         <el-table-column prop="materialsId" label="物资ID" width="100"></el-table-column>
         <el-table-column prop="name" label="名称" width="100"></el-table-column>
         <el-table-column prop="specifications" label="规格" width="100"></el-table-column>
         <el-table-column prop="price" label="采购价格" width="100"></el-table-column>
         <el-table-column prop="count" label="数量" width="100"></el-table-column>
         <el-table-column prop="unit" label="单位" width="100"></el-table-column>
         <el-table-column prop="purchasesId" label="购买情况" width="100"></el-table-column>
         <el-table-column prop="purchases" label="购买情况" width="100"></el-table-column>
         <el-table-column prop="purchaseDate" label="购买日期" width="180"></el-table-column>
         <el-table-column prop="storehouseId" label="库房" width="100"></el-table-column>
         <el-table-column prop="storehouse" label="库房" width="100"></el-table-column>
         <el-table-column prop="purchaserId" label="采购人" width="100"></el-table-column>
         <el-table-column prop="purchaser" label="采购人" width="100"></el-table-column>
         <el-table-column prop="remark" label="产地" width="100"></el-table-column>
         <el-table-column prop="level" label="等级" width="100"></el-table-column>
         <el-table-column prop="sort" label="排序" width="100"></el-table-column>
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
 <instock-edit :dialogVisible="dialog" @closeAdd="_addClose" :id="childId"></instock-edit>
</div>
</template>
<script>
import InstockEdit from './edit'
export default {
  /** 页面绑定数据 */
  data() {
    return {
      /** 页面table绑定数据 */
      instockData: [],
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
    /**  查询分页信息 @for Instock */
    query() {
      const _this = this
      this.$request.get(
        'instock/page',
        {
          pageIndex: _this.current,
          pageSize: _this.pageSize,
          queryData: _this.queryData
        },
        respose => {
          _this.instockData = respose.data.result
          _this.total = respose.data.totalCount
          _this.current = respose.data.pageIndex
        }
      )
    },
    /**  弹出添加数据页面 @for Instock */
    add() {
      this.childId = ''
      this.dialog = true
    },
    /**  删除选中数据  @for Instock
     * @param 当前选中数据
     */
    del(row) {
      const instock = this.selectdata(row)
      if (!instock || instock.length === 0) {
        this.$message.error('请选择一条数据！')
        return
      }
      this.$request.delete('instock', { instock }, respose => {
        this.query()
      })
    },
    /**  编辑选中数据  @for Instock
     * @param 当前选中数据
     */
    edit(instock) {
      this.childId = instock.id
      this.dialog = true
    },
    /**  停用选中数据  @for Instock
     * @param 当前选中数据
     */
    stop(row, isEnable) {
      const instock = this.selectdata(row)
      if (!instock || instock.length === 0) {
        this.$message.error('请选择一条数据！')
        return
      }
      if (instock.find(t => t.isEnable === isEnable)) {
        this.$message.error('请选择同一种类型进行批量操作！')
        return
      }
      let msg = ''
      if (isEnable) {
        msg = '是否启用该项目？'
      }
      this.$request.stop(
        'instock/stop',
        { instock, isEnable },
        respose => {
          this.query()
        },
        null,
        msg
      )
    },
    /**  事件-修改分页大小  @for Instock
     * @param 选中分页大小
     */
    sizeChange(pageSize) {
      this.pageSize = pageSize
      this.query()
    },
    /** 事件-改变分页当前页   @for Instock
     * @param 选中分页大小
     */
    currentChange(current) {
      this.current = current
      this.query()
    },
    /** 事件-选中行   @for Instock
     * @param 当前选中行
     */
    handleSelectionChange(val) {
      this.multipleSelection = val
    },
    /** 回调-子窗口添加完成之后回调关闭刷新当前页面   @for Instock
     * @param 当前选中行
     */
    _addClose(evtValue, refresh) {
      this.dialog = evtValue
      if (refresh) {
        this.query()
      }
    },
    /** 添加当前选中数据到集合内   @for Instock
     * @param 当前选中行
     */
    selectdata(row) {
      const instock = []
      if (row) {
        instock.push(row)
      } else {
        this.multipleSelection.forEach(element => {
          instock.push(element)
        })
      }
      return instock
    },
    /** 页面验证
     * @param 类型
     * @return true 通过 false 未通过
     */
    checked(type) {}
  },
  /** 引用组建 */
  components: {
    'instock-edit': InstockEdit
  }
}
</script>
