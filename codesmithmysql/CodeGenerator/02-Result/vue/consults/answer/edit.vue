<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="选项值" hintText="请输入选项值" v-model="form.optionsId"  lab labelFloat/>
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="答案内容" hintText="请输入答案内容" v-model="form.content"  lab labelFloat/>
         <mu-text-field label="类型 （回答类，问卷类）" hintText="请输入类型 （回答类，问卷类）" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="选项值" hintText="请输入选项值" v-model="form.value"  lab labelFloat/>
         <mu-text-field label="父级" hintText="请输入父级" v-model="form.suggestion"  lab labelFloat/>
         <mu-text-field label="父级" hintText="请输入父级" v-model="form.questionnaireId"  lab labelFloat/>
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
  name: 'answer-edit',
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
      title: '新增答案表信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 选项值 */
        optionsId: '',
        /** 门店号 */
        stroeId: '',
        /** 答案内容 */
        content: '',
        /** 类型 （回答类，问卷类） */
        type: 0,
        /** 选项值 */
        value: 0,
        /** 父级 */
        suggestion: '',
        /** 父级 */
        questionnaireId: '',
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
      this.$request.save('answer', this.form, function(respose) {
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
        this.title = '编辑答案表信息'
        const _this = this
        this.$request.get('answer/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
