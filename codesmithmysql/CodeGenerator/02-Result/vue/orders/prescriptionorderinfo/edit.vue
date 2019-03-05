<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="订单编号" hintText="请输入订单编号" v-model="form.orderId"  lab labelFloat/>
         <mu-text-field label="项目编号" hintText="请输入项目编号" v-model="form.itemId"  lab labelFloat/>
         <mu-text-field label="项目批次编号" hintText="请输入项目批次编号" v-model="form.itemBatchId"  lab labelFloat/>
         <mu-text-field label="项目名称" hintText="请输入项目名称" v-model="form.itemName"  lab labelFloat/>
         <mu-text-field label="项目规格" hintText="请输入项目规格" v-model="form.itemFormat"  lab labelFloat/>
         <mu-text-field label="使用方法" hintText="请输入使用方法" v-model="form.usageName"  lab labelFloat/>
         <mu-text-field label="使用方法编号" hintText="请输入使用方法编号" v-model="form.usageId"  lab labelFloat/>
         <mu-text-field label="销售数量" hintText="请输入销售数量" v-model="form.salesCount"  lab labelFloat/>
         <mu-text-field label="销售单价" hintText="请输入销售单价" v-model="form.salesPrice"  lab labelFloat/>
         <mu-text-field label="销售单位" hintText="请输入销售单位" v-model="form.salesUnit"  lab labelFloat/>
         <mu-text-field label="项目类型编号" hintText="请输入项目类型编号" v-model="form.itemTypeId"  lab labelFloat/>
         <mu-text-field label="项目类型" hintText="请输入项目类型" v-model="form.itemType"  lab labelFloat/>
         <mu-text-field label="项目类型关系编号" hintText="请输入项目类型关系编号" v-model="form.itemTypeRelationId"  lab labelFloat/>
         <mu-text-field label="项目备注" hintText="请输入项目备注" v-model="form.remark"  lab labelFloat/>
         <mu-text-field label="项目顺序" hintText="请输入项目顺序" v-model="form.sort"  lab labelFloat/>
         <mu-text-field label="项目分组" hintText="请输入项目分组" v-model="form.groupNo"  lab labelFloat/>
         <mu-text-field label="项目社保编号" hintText="请输入项目社保编号" v-model="form.sbCode"  lab labelFloat/>
         <mu-text-field label="标准编号" hintText="请输入标准编号" v-model="form.standardCode"  lab labelFloat/>
         <mu-text-field label="单次用量" hintText="请输入单次用量" v-model="form.usageCount"  lab labelFloat/>
         <mu-text-field label="单次用量单位" hintText="请输入单次用量单位" v-model="form.usageUnit"  lab labelFloat/>
         <mu-text-field label="用法比例" hintText="请输入用法比例" v-model="form.usageRatio"  lab labelFloat/>
         <mu-text-field label="频率编号" hintText="请输入频率编号" v-model="form.frequencyId"  lab labelFloat/>
         <mu-text-field label="频率" hintText="请输入频率" v-model="form.frequency"  lab labelFloat/>
         <mu-text-field label="频率比例" hintText="请输入频率比例" v-model="form.frequencyRatio"  lab labelFloat/>
         <mu-text-field label="滴数" hintText="请输入滴数" v-model="form.dropNumber"  lab labelFloat/>
         <mu-text-field label="皮试标志" hintText="请输入皮试标志" v-model="form.skinTest"  lab labelFloat/>
         <mu-text-field label="皮试结果" hintText="请输入皮试结果" v-model="form.skinTestResult"  lab labelFloat/>
         <mu-text-field label="天数" hintText="请输入天数" v-model="form.day"  lab labelFloat/>
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
  name: 'prescriptionorderinfo-edit',
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
      title: '新增订单明细信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 订单编号 */
        orderId: '',
        /** 项目编号 */
        itemId: '',
        /** 项目批次编号 */
        itemBatchId: '',
        /** 项目名称 */
        itemName: '',
        /** 项目规格 */
        itemFormat: '',
        /** 使用方法 */
        usageName: '',
        /** 使用方法编号 */
        usageId: '',
        /** 销售数量 */
        salesCount: 0,
        /** 销售单价 */
        salesPrice: 0,
        /** 销售单位 */
        salesUnit: '',
        /** 项目类型编号 */
        itemTypeId: '',
        /** 项目类型 */
        itemType: '',
        /** 项目类型关系编号 */
        itemTypeRelationId: '',
        /** 项目备注 */
        remark: '',
        /** 项目顺序 */
        sort: 0,
        /** 项目分组 */
        groupNo: '',
        /** 项目社保编号 */
        sbCode: '',
        /** 标准编号 */
        standardCode: '',
        /** 单次用量 */
        usageCount: 0,
        /** 单次用量单位 */
        usageUnit: '',
        /** 用法比例 */
        usageRatio: 0,
        /** 频率编号 */
        frequencyId: '',
        /** 频率 */
        frequency: '',
        /** 频率比例 */
        frequencyRatio: 0,
        /** 滴数 */
        dropNumber: '',
        /** 皮试标志 */
        skinTest: 0,
        /** 皮试结果 */
        skinTestResult: '',
        /** 天数 */
        day: 0,
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
      this.$request.save('prescriptionorderinfo', this.form, function(respose) {
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
        this.title = '编辑订单明细信息'
        const _this = this
        this.$request.get('prescriptionorderinfo/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
