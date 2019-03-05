<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="出入库编号" hintText="请输入出入库编号" v-model="form.drugInOutId"  lab labelFloat/>
         <mu-text-field label="批次编号" hintText="请输入批次编号" v-model="form.batchId"  lab labelFloat/>
         <mu-text-field label="药品编号" hintText="请输入药品编号" v-model="form.drugId"  lab labelFloat/>
         <mu-text-field label="药品名称" hintText="请输入药品名称" v-model="form.drugName"  lab labelFloat/>
         <mu-text-field label="规格" hintText="请输入规格" v-model="form.format"  lab labelFloat/>
         <mu-text-field label="销售价(包装单位)" hintText="请输入销售价(包装单位)" v-model="form.salesPrice"  lab labelFloat/>
         <mu-text-field label="销售单位" hintText="请输入销售单位" v-model="form.salesUnitId"  lab labelFloat/>
         <mu-text-field label="销售单位" hintText="请输入销售单位" v-model="form.salesUnit"  lab labelFloat/>
         <mu-text-field label="成本价(包装单位)" hintText="请输入成本价(包装单位)" v-model="form.costPrice"  lab labelFloat/>
         <mu-text-field label="调拨入库数量(销售单位为数量)" hintText="请输入调拨入库数量(销售单位为数量)" v-model="form.inOutCount"  lab labelFloat/>
         <mu-text-field label="药品生产批号" hintText="请输入药品生产批号" v-model="form.batchCode"  lab labelFloat/>
         <mu-date-picker  label="有效期" hintText="请输入有效期" v-model="form.expiryDate"  lab labelFloat/>
         <mu-date-picker  label="生产日期" hintText="请输入生产日期" v-model="form.manufactureDate"  lab labelFloat/>
         <mu-text-field label="是否调价" hintText="请输入是否调价" v-model="form.isModifyPrice"  lab labelFloat/>
         <mu-text-field label="调整之后价格" hintText="请输入调整之后价格" v-model="form.modifyPrice"  lab labelFloat/>
         <mu-date-picker  label="调价生效日期" hintText="请输入调价生效日期" v-model="form.modifyPriceDate"  lab labelFloat/>
         <mu-text-field label="剩余多少库存之后调价生效" hintText="请输入剩余多少库存之后调价生效" v-model="form.modifyPriceCount"  lab labelFloat/>
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
  name: 'druginoutinfo-edit',
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
      title: '新增出入库明细表信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 出入库编号 */
        drugInOutId: '',
        /** 批次编号 */
        batchId: '',
        /** 药品编号 */
        drugId: '',
        /** 药品名称 */
        drugName: '',
        /** 规格 */
        format: '',
        /** 销售价(包装单位) */
        salesPrice: 0,
        /** 销售单位 */
        salesUnitId: '',
        /** 销售单位 */
        salesUnit: '',
        /** 成本价(包装单位) */
        costPrice: 0,
        /** 调拨入库数量(销售单位为数量) */
        inOutCount: 0,
        /** 药品生产批号 */
        batchCode: '',
        /** 有效期 */
        expiryDate: Date.now(),
        /** 生产日期 */
        manufactureDate: Date.now(),
        /** 是否调价 */
        isModifyPrice: '',
        /** 调整之后价格 */
        modifyPrice: 0,
        /** 调价生效日期 */
        modifyPriceDate: Date.now(),
        /** 剩余多少库存之后调价生效 */
        modifyPriceCount: 0,
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
      this.$request.save('druginoutinfo', this.form, function(respose) {
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
        this.title = '编辑出入库明细表信息'
        const _this = this
        this.$request.get('druginoutinfo/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
