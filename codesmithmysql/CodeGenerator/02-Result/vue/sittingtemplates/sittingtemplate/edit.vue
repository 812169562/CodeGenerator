<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="医生Id" hintText="请输入医生Id" v-model="form.doctorId"  lab labelFloat/>
         <mu-text-field label="科室Id" hintText="请输入科室Id" v-model="form.departmentId"  lab labelFloat/>
         <mu-text-field label="坐诊地点Id" hintText="请输入坐诊地点Id" v-model="form.sittingAddressId"  lab labelFloat/>
         <mu-text-field label="坐诊地点" hintText="请输入坐诊地点" v-model="form.sittingAddressName"  lab labelFloat/>
         <mu-text-field label="上午/下午" hintText="请输入上午/下午" v-model="form.dayType"  lab labelFloat/>
         <mu-text-field label="限制预约数量" hintText="请输入限制预约数量" v-model="form.appointmentCount"  lab labelFloat/>
         <mu-text-field label="号别" hintText="请输入号别" v-model="form.numberTypeId"  lab labelFloat/>
         <mu-text-field label="号别名称" hintText="请输入号别名称" v-model="form.numberTypeName"  lab labelFloat/>
         <mu-text-field label="开始时间" hintText="请输入开始时间" v-model="form.startTime"  lab labelFloat/>
         <mu-text-field label="结束时间" hintText="请输入结束时间" v-model="form.endTime"  lab labelFloat/>
         <mu-text-field label="放号数量" hintText="请输入放号数量" v-model="form.count"  lab labelFloat/>
         <mu-text-field label="星期几" hintText="请输入星期几" v-model="form.weekday"  lab labelFloat/>
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
  name: 'sittingtemplate-edit',
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
      title: '新增 坐诊模板信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 删除标志 */
        isDeleted: '',
        /** 医生Id */
        doctorId: '',
        /** 科室Id */
        departmentId: '',
        /** 坐诊地点Id */
        sittingAddressId: '',
        /** 坐诊地点 */
        sittingAddressName: '',
        /** 上午/下午 */
        dayType: 0,
        /** 限制预约数量 */
        appointmentCount: 0,
        /** 号别 */
        numberTypeId: '',
        /** 号别名称 */
        numberTypeName: '',
        /** 开始时间 */
        startTime: '',
        /** 结束时间 */
        endTime: '',
        /** 放号数量 */
        count: 0,
        /** 星期几 */
        weekday: 0,
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
      this.$request.save('sittingtemplate', this.form, function(respose) {
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
        this.title = '编辑 坐诊模板信息'
        const _this = this
        this.$request.get('sittingtemplate/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
