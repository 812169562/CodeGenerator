<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="支付编号" hintText="请输入支付编号" v-model="form.paymentInformationId"  lab labelFloat/>
         <mu-text-field label="项目编号" hintText="请输入项目编号" v-model="form.itemId"  lab labelFloat/>
         <mu-text-field label="项目批次编号" hintText="请输入项目批次编号" v-model="form.itemBatchId"  lab labelFloat/>
         <mu-text-field label="项目名称" hintText="请输入项目名称" v-model="form.itemName"  lab labelFloat/>
         <mu-text-field label="项目规格" hintText="请输入项目规格" v-model="form.itemFormat"  lab labelFloat/>
         <mu-text-field label="销售数量" hintText="请输入销售数量" v-model="form.salesCount"  lab labelFloat/>
         <mu-text-field label="销售单价" hintText="请输入销售单价" v-model="form.salesPrice"  lab labelFloat/>
         <mu-text-field label="销售单位" hintText="请输入销售单位" v-model="form.salesUnit"  lab labelFloat/>
         <mu-text-field label="项目备注" hintText="请输入项目备注" v-model="form.remark"  lab labelFloat/>
         <mu-text-field label="项目类型编号" hintText="请输入项目类型编号" v-model="form.itemTypeId"  lab labelFloat/>
         <mu-text-field label="项目类型" hintText="请输入项目类型" v-model="form.itemType"  lab labelFloat/>
         <mu-text-field label="项目类型关系编号" hintText="请输入项目类型关系编号" v-model="form.itemTypeRelationId"  lab labelFloat/>
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
  name: 'paymentinformationdetail-edit',
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
      title: '新增 支付信息明细信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 支付编号 */
        paymentInformationId: '',
        /** 项目编号 */
        itemId: '',
        /** 项目批次编号 */
        itemBatchId: '',
        /** 项目名称 */
        itemName: '',
        /** 项目规格 */
        itemFormat: '',
        /** 销售数量 */
        salesCount: 0,
        /** 销售单价 */
        salesPrice: 0,
        /** 销售单位 */
        salesUnit: '',
        /** 项目备注 */
        remark: '',
        /** 项目类型编号 */
        itemTypeId: '',
        /** 项目类型 */
        itemType: '',
        /** 项目类型关系编号 */
        itemTypeRelationId: '',
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
      this.$request.save('paymentinformationdetail', this.form, function(respose) {
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
        this.title = '编辑 支付信息明细信息'
        const _this = this
        this.$request.get('paymentinformationdetail/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
