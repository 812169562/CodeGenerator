<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="出入库单号" hintText="请输入出入库单号" v-model="form.code"  lab labelFloat/>
         <mu-text-field label="出入库类型" hintText="请输入出入库类型" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="出入库类型（来自字典表）" hintText="请输入出入库类型（来自字典表）" v-model="form.inOutTypeId"  lab labelFloat/>
         <mu-text-field label="出入库类型（来自字典表）" hintText="请输入出入库类型（来自字典表）" v-model="form.inOutTypeName"  lab labelFloat/>
         <mu-text-field label="供应商" hintText="请输入供应商" v-model="form.supplierId"  lab labelFloat/>
         <mu-text-field label="供应商" hintText="请输入供应商" v-model="form.supplier"  lab labelFloat/>
         <mu-text-field label="申请人" hintText="请输入申请人" v-model="form.applyId"  lab labelFloat/>
         <mu-text-field label="申请人" hintText="请输入申请人" v-model="form.applyName"  lab labelFloat/>
         <mu-date-picker  label="申请日期" hintText="请输入申请日期" v-model="form.applyDate"  lab labelFloat/>
         <mu-text-field label="申请备注" hintText="请输入申请备注" v-model="form.applyRemark"  lab labelFloat/>
         <mu-text-field label="出入库房" hintText="请输入出入库房" v-model="form.storeId"  lab labelFloat/>
         <mu-text-field label="出入库房" hintText="请输入出入库房" v-model="form.storeName"  lab labelFloat/>
         <mu-text-field label="审核编号" hintText="请输入审核编号" v-model="form.auditId"  lab labelFloat/>
         <mu-text-field label="审核人" hintText="请输入审核人" v-model="form.auditName"  lab labelFloat/>
         <mu-date-picker  label="审核时间" hintText="请输入审核时间" v-model="form.auditDate"  lab labelFloat/>
         <mu-text-field label="审核意见" hintText="请输入审核意见" v-model="form.auditOpinion"  lab labelFloat/>
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
  name: 'druginout-edit',
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
      title: '新增药品出入库信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 出入库单号 */
        code: '',
        /** 出入库类型 */
        type: 0,
        /** 出入库类型（来自字典表） */
        inOutTypeId: '',
        /** 出入库类型（来自字典表） */
        inOutTypeName: '',
        /** 供应商 */
        supplierId: '',
        /** 供应商 */
        supplier: '',
        /** 申请人 */
        applyId: '',
        /** 申请人 */
        applyName: '',
        /** 申请日期 */
        applyDate: Date.now(),
        /** 申请备注 */
        applyRemark: '',
        /** 出入库房 */
        storeId: '',
        /** 出入库房 */
        storeName: '',
        /** 审核编号 */
        auditId: '',
        /** 审核人 */
        auditName: '',
        /** 审核时间 */
        auditDate: Date.now(),
        /** 审核意见 */
        auditOpinion: '',
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
      this.$request.save('druginout', this.form, function(respose) {
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
        this.title = '编辑药品出入库信息'
        const _this = this
        this.$request.get('druginout/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
