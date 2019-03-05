<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="调拨类型" hintText="请输入调拨类型" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="调拨单号" hintText="请输入调拨单号" v-model="form.code"  lab labelFloat/>
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="申请人" hintText="请输入申请人" v-model="form.applyId"  lab labelFloat/>
         <mu-text-field label="申请人" hintText="请输入申请人" v-model="form.applyName"  lab labelFloat/>
         <mu-date-picker  label="申请日期" hintText="请输入申请日期" v-model="form.applyDate"  lab labelFloat/>
         <mu-text-field label="备注" hintText="请输入备注" v-model="form.applyRemark"  lab labelFloat/>
         <mu-text-field label="审核编号" hintText="请输入审核编号" v-model="form.auditId"  lab labelFloat/>
         <mu-text-field label="审核人" hintText="请输入审核人" v-model="form.auditName"  lab labelFloat/>
         <mu-date-picker  label="审核时间" hintText="请输入审核时间" v-model="form.auditDate"  lab labelFloat/>
         <mu-text-field label="审核意见" hintText="请输入审核意见" v-model="form.auditOpinion"  lab labelFloat/>
         <mu-text-field label="入库编号" hintText="请输入入库编号" v-model="form.inId"  lab labelFloat/>
         <mu-text-field label="调拨入库库房编号" hintText="请输入调拨入库库房编号" v-model="form.inStroeId"  lab labelFloat/>
         <mu-text-field label="调拨入库库房" hintText="请输入调拨入库库房" v-model="form.inStroeName"  lab labelFloat/>
         <mu-text-field label="入库单据号" hintText="请输入入库单据号" v-model="form.inCode"  lab labelFloat/>
         <mu-text-field label="出库编号" hintText="请输入出库编号" v-model="form.outId"  lab labelFloat/>
         <mu-text-field label="调拨出库库房编号" hintText="请输入调拨出库库房编号" v-model="form.outStroeId"  lab labelFloat/>
         <mu-text-field label="调拨出库库房" hintText="请输入调拨出库库房" v-model="form.outStroeName"  lab labelFloat/>
         <mu-text-field label="出库库单据号" hintText="请输入出库库单据号" v-model="form.outCode"  lab labelFloat/>
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
  name: 'drugallot-edit',
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
      title: '新增药品调拨信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 调拨类型 */
        type: 0,
        /** 调拨单号 */
        code: '',
        /** 门店号 */
        stroeId: '',
        /** 申请人 */
        applyId: '',
        /** 申请人 */
        applyName: '',
        /** 申请日期 */
        applyDate: Date.now(),
        /** 备注 */
        applyRemark: '',
        /** 审核编号 */
        auditId: '',
        /** 审核人 */
        auditName: '',
        /** 审核时间 */
        auditDate: Date.now(),
        /** 审核意见 */
        auditOpinion: '',
        /** 入库编号 */
        inId: '',
        /** 调拨入库库房编号 */
        inStroeId: '',
        /** 调拨入库库房 */
        inStroeName: '',
        /** 入库单据号 */
        inCode: '',
        /** 出库编号 */
        outId: '',
        /** 调拨出库库房编号 */
        outStroeId: '',
        /** 调拨出库库房 */
        outStroeName: '',
        /** 出库库单据号 */
        outCode: '',
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
      this.$request.save('drugallot', this.form, function(respose) {
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
        this.title = '编辑药品调拨信息'
        const _this = this
        this.$request.get('drugallot/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
