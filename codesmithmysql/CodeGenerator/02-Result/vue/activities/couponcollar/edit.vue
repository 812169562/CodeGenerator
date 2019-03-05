<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="优惠卷编号" hintText="请输入优惠卷编号" v-model="form.couponId"  lab labelFloat/>
         <mu-text-field label="客户(患者)编号" hintText="请输入客户(患者)编号" v-model="form.customertId"  lab labelFloat/>
         <mu-text-field label="客户(患者)姓名" hintText="请输入客户(患者)姓名" v-model="form.customerName"  lab labelFloat/>
         <mu-date-picker  label="开始时间" hintText="请输入开始时间" v-model="form.startTime"  lab labelFloat/>
         <mu-date-picker  label="结束时间" hintText="请输入结束时间" v-model="form.endTime"  lab labelFloat/>
         <mu-text-field label="排序" hintText="请输入排序" v-model="form.sort"  lab labelFloat/>
         <mu-text-field label="类型" hintText="请输入类型" v-model="form.type"  lab labelFloat/>
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
  name: 'couponcollar-edit',
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
      title: '新增优惠券领用信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 优惠卷编号 */
        couponId: '',
        /** 客户(患者)编号 */
        customertId: '',
        /** 客户(患者)姓名 */
        customerName: '',
        /** 开始时间 */
        startTime: Date.now(),
        /** 结束时间 */
        endTime: Date.now(),
        /** 排序 */
        sort: 0,
        /** 类型 */
        type: 0,
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
      this.$request.save('couponcollar', this.form, function(respose) {
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
        this.title = '编辑优惠券领用信息'
        const _this = this
        this.$request.get('couponcollar/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
