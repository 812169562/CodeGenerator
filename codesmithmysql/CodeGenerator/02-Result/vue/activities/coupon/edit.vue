<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="优惠活动编号" hintText="请输入优惠活动编号" v-model="form.activityId"  lab labelFloat/>
         <mu-text-field label="图片地址" hintText="请输入图片地址" v-model="form.imgPath"  lab labelFloat/>
         <mu-text-field label="活动内容" hintText="请输入活动内容" v-model="form.name"  lab labelFloat/>
         <mu-text-field label="类型" hintText="请输入类型" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="等级" hintText="请输入等级" v-model="form.level"  lab labelFloat/>
         <mu-text-field label="活动编号" hintText="请输入活动编号" v-model="form.code"  lab labelFloat/>
         <mu-text-field label="库存" hintText="请输入库存" v-model="form.stock"  lab labelFloat/>
         <mu-text-field label="使用上限" hintText="请输入使用上限" v-model="form.useLine"  lab labelFloat/>
         <mu-text-field label="是否允许和其他优惠卷进行叠加" hintText="请输入是否允许和其他优惠卷进行叠加" v-model="form.allowableSuperposition"  lab labelFloat/>
         <mu-date-picker  label="开始时间" hintText="请输入开始时间" v-model="form.startTime"  lab labelFloat/>
         <mu-date-picker  label="结束时间" hintText="请输入结束时间" v-model="form.endTime"  lab labelFloat/>
         <mu-text-field label="排序" hintText="请输入排序" v-model="form.sort"  lab labelFloat/>
         <mu-text-field label="" hintText="请输入" v-model="form.instructions"  lab labelFloat/>
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
  name: 'coupon-edit',
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
      title: '新增优惠券信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 优惠活动编号 */
        activityId: '',
        /** 图片地址 */
        imgPath: '',
        /** 活动内容 */
        name: '',
        /** 类型 */
        type: 0,
        /** 等级 */
        level: 0,
        /** 活动编号 */
        code: '',
        /** 库存 */
        stock: 0,
        /** 使用上限 */
        useLine: 0,
        /** 是否允许和其他优惠卷进行叠加 */
        allowableSuperposition: 0,
        /** 开始时间 */
        startTime: Date.now(),
        /** 结束时间 */
        endTime: Date.now(),
        /** 删除标志 */
        isDeleted: 0,
        /** 排序 */
        sort: 0,
        /**  */
        instructions: '',
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
      this.$request.save('coupon', this.form, function(respose) {
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
        this.title = '编辑优惠券信息'
        const _this = this
        this.$request.get('coupon/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
