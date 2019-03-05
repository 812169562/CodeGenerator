<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="批次号（系统按照日期生成）" hintText="请输入批次号（系统按照日期生成）" v-model="form.batchNumber"  lab labelFloat/>
         <mu-text-field label="药品生产批号" hintText="请输入药品生产批号" v-model="form.batchCode"  lab labelFloat/>
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="药品编号" hintText="请输入药品编号" v-model="form.drugId"  lab labelFloat/>
         <mu-text-field label="最小单位价格(自动计算)" hintText="请输入最小单位价格(自动计算)" v-model="form.price"  lab labelFloat/>
         <mu-text-field label="销售价(包装单位)" hintText="请输入销售价(包装单位)" v-model="form.salesPrice"  lab labelFloat/>
         <mu-text-field label="成本价(包装单位)" hintText="请输入成本价(包装单位)" v-model="form.costPrice"  lab labelFloat/>
         <mu-date-picker  label="有效期" hintText="请输入有效期" v-model="form.expiryDate"  lab labelFloat/>
         <mu-date-picker  label="生产日期" hintText="请输入生产日期" v-model="form.manufactureDate"  lab labelFloat/>
         <mu-text-field label="保质期" hintText="请输入保质期" v-model="form.helflifeDay"  lab labelFloat/>
         <mu-text-field label="供应商" hintText="请输入供应商" v-model="form.supplierId"  lab labelFloat/>
         <mu-text-field label="供应商" hintText="请输入供应商" v-model="form.supplier"  lab labelFloat/>
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
  name: 'drugbatch-edit',
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
      title: '新增药品批次信息信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 批次号（系统按照日期生成） */
        batchNumber: '',
        /** 药品生产批号 */
        batchCode: '',
        /** 门店号 */
        stroeId: '',
        /** 药品编号 */
        drugId: '',
        /** 最小单位价格(自动计算) */
        price: 0,
        /** 销售价(包装单位) */
        salesPrice: 0,
        /** 成本价(包装单位) */
        costPrice: 0,
        /** 有效期 */
        expiryDate: Date.now(),
        /** 生产日期 */
        manufactureDate: Date.now(),
        /** 保质期 */
        helflifeDay: 0,
        /** 供应商 */
        supplierId: '',
        /** 供应商 */
        supplier: '',
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
      this.$request.save('drugbatch', this.form, function(respose) {
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
        this.title = '编辑药品批次信息信息'
        const _this = this
        this.$request.get('drugbatch/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
