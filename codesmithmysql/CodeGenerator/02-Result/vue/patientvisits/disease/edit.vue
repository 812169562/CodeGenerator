<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="就诊编号" hintText="请输入就诊编号" v-model="form.visitId"  lab labelFloat/>
         <mu-text-field label="四诊数据编号" hintText="请输入四诊数据编号" v-model="form.diseaseId"  lab labelFloat/>
         <mu-text-field label="四诊信息说明" hintText="请输入四诊信息说明" v-model="form.diseaseName"  lab labelFloat/>
         <mu-text-field label="轻重程度(-1代表无此症状,0轻微症状,1严重症状,2非常严重)" hintText="请输入轻重程度(-1代表无此症状,0轻微症状,1严重症状,2非常严重)" v-model="form.degree"  lab labelFloat/>
         <mu-text-field label="排序" hintText="请输入排序" v-model="form.sort"  lab labelFloat/>
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
  name: 'disease-edit',
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
      title: '新增四诊信息信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 就诊编号 */
        visitId: '',
        /** 四诊数据编号 */
        diseaseId: '',
        /** 四诊信息说明 */
        diseaseName: '',
        /** 轻重程度(-1代表无此症状,0轻微症状,1严重症状,2非常严重) */
        degree: 0,
        /** 排序 */
        sort: 0,
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
      this.$request.save('disease', this.form, function(respose) {
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
        this.title = '编辑四诊信息信息'
        const _this = this
        this.$request.get('disease/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
