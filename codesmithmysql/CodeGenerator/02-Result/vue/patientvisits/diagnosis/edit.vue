<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="患者编号" hintText="请输入患者编号" v-model="form.patId"  lab labelFloat/>
         <mu-text-field label="就诊编号" hintText="请输入就诊编号" v-model="form.visitId"  lab labelFloat/>
         <mu-text-field label="诊断类型(1.中医,2.西医)" hintText="请输入诊断类型(1.中医,2.西医)" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="诊断编号" hintText="请输入诊断编号" v-model="form.diagnosisId"  lab labelFloat/>
         <mu-text-field label="诊断名" hintText="请输入诊断名" v-model="form.diagnosisName"  lab labelFloat/>
         <mu-text-field label="附加诊断编号" hintText="请输入附加诊断编号" v-model="form.attachDiagnosisId"  lab labelFloat/>
         <mu-text-field label="附加诊断名称(部分诊断Icd只能作为附加诊断)" hintText="请输入附加诊断名称(部分诊断Icd只能作为附加诊断)" v-model="form.attachDiagnosisName"  lab labelFloat/>
         <mu-text-field label="证型编号" hintText="请输入证型编号" v-model="form.syndromeId"  lab labelFloat/>
         <mu-text-field label="证型" hintText="请输入证型" v-model="form.syndromeName"  lab labelFloat/>
         <mu-text-field label="证型编号" hintText="请输入证型编号" v-model="form.syndromeId2"  lab labelFloat/>
         <mu-text-field label="证型" hintText="请输入证型" v-model="form.syndromeName2"  lab labelFloat/>
         <mu-text-field label="证型编号" hintText="请输入证型编号" v-model="form.syndromeId3"  lab labelFloat/>
         <mu-text-field label="证型" hintText="请输入证型" v-model="form.syndromeName3"  lab labelFloat/>
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
  name: 'diagnosis-edit',
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
      title: '新增诊断信息信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 患者编号 */
        patId: '',
        /** 就诊编号 */
        visitId: '',
        /** 诊断类型(1.中医,2.西医) */
        type: 0,
        /** 诊断编号 */
        diagnosisId: '',
        /** 诊断名 */
        diagnosisName: '',
        /** 附加诊断编号 */
        attachDiagnosisId: '',
        /** 附加诊断名称(部分诊断Icd只能作为附加诊断) */
        attachDiagnosisName: '',
        /** 证型编号 */
        syndromeId: '',
        /** 证型 */
        syndromeName: '',
        /** 证型编号 */
        syndromeId2: '',
        /** 证型 */
        syndromeName2: '',
        /** 证型编号 */
        syndromeId3: '',
        /** 证型 */
        syndromeName3: '',
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
      this.$request.save('diagnosis', this.form, function(respose) {
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
        this.title = '编辑诊断信息信息'
        const _this = this
        this.$request.get('diagnosis/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
