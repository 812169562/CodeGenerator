<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="患者编号" hintText="请输入患者编号" v-model="form.patId"  lab labelFloat/>
         <mu-text-field label="挂号编号" hintText="请输入挂号编号" v-model="form.registerId"  lab labelFloat/>
         <mu-date-picker  label="发病日期" hintText="请输入发病日期" v-model="form.diseaseDate"  lab labelFloat/>
         <mu-text-field label="舒张压" hintText="请输入舒张压" v-model="form.diastolicPressure"  lab labelFloat/>
         <mu-text-field label="收缩压" hintText="请输入收缩压" v-model="form.systolicPressure"  lab labelFloat/>
         <mu-text-field label="主诉" hintText="请输入主诉" v-model="form.chiefComplaint"  lab labelFloat/>
         <mu-text-field label="现病史" hintText="请输入现病史" v-model="form.presentIllness"  lab labelFloat/>
         <mu-text-field label="既往史" hintText="请输入既往史" v-model="form.pastIllness"  lab labelFloat/>
         <mu-text-field label="个人史" hintText="请输入个人史" v-model="form.selefHistory"  lab labelFloat/>
         <mu-text-field label="家族史" hintText="请输入家族史" v-model="form.familyHistory"  lab labelFloat/>
         <mu-text-field label="月经史" hintText="请输入月经史" v-model="form.menstrualHistory"  lab labelFloat/>
         <mu-text-field label="辅助检查" hintText="请输入辅助检查" v-model="form.supplementaryExamination"  lab labelFloat/>
         <mu-text-field label="体格检查" hintText="请输入体格检查" v-model="form.physicalexamination"  lab labelFloat/>
         <mu-text-field label="治疗意见" hintText="请输入治疗意见" v-model="form.treatmentOpinion"  lab labelFloat/>
         <mu-text-field label="图片" hintText="请输入图片" v-model="form.imgPath"  lab labelFloat/>
         <mu-text-field label="备注" hintText="请输入备注" v-model="form.remark"  lab labelFloat/>
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
  name: 'visit-edit',
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
      title: '新增就诊信息信息'
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
        /** 挂号编号 */
        registerId: '',
        /** 发病日期 */
        diseaseDate: Date.now(),
        /** 舒张压 */
        diastolicPressure: '',
        /** 收缩压 */
        systolicPressure: '',
        /** 主诉 */
        chiefComplaint: '',
        /** 现病史 */
        presentIllness: '',
        /** 既往史 */
        pastIllness: '',
        /** 个人史 */
        selefHistory: '',
        /** 家族史 */
        familyHistory: '',
        /** 月经史 */
        menstrualHistory: '',
        /** 辅助检查 */
        supplementaryExamination: '',
        /** 体格检查 */
        physicalexamination: '',
        /** 治疗意见 */
        treatmentOpinion: '',
        /** 图片 */
        imgPath: '',
        /** 备注 */
        remark: '',
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
      this.$request.save('visit', this.form, function(respose) {
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
        this.title = '编辑就诊信息信息'
        const _this = this
        this.$request.get('visit/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
