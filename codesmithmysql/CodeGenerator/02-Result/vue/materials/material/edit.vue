﻿<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="名称" hintText="请输入名称" v-model="form.name"  lab labelFloat/>
         <mu-text-field label="编号" hintText="请输入编号" v-model="form.code"  lab labelFloat/>
         <mu-text-field label="单位" hintText="请输入单位" v-model="form.unit"  lab labelFloat/>
         <mu-text-field label="规格" hintText="请输入规格" v-model="form.specifications"  lab labelFloat/>
         <mu-text-field label="品牌" hintText="请输入品牌" v-model="form.trademark"  lab labelFloat/>
         <mu-text-field label="型号" hintText="请输入型号" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="生产厂家" hintText="请输入生产厂家" v-model="form.manufacturerId"  lab labelFloat/>
         <mu-text-field label="生产厂家" hintText="请输入生产厂家" v-model="form.manufacturer"  lab labelFloat/>
         <mu-date-picker  label="采购时间" hintText="请输入采购时间" v-model="form.purchasingTime"  lab labelFloat/>
         <mu-date-picker  label="有效期" hintText="请输入有效期" v-model="form.periodTime"  lab labelFloat/>
         <mu-text-field label="产地" hintText="请输入产地" v-model="form.place"  lab labelFloat/>
         <mu-text-field label="产地" hintText="请输入产地" v-model="form.remark"  lab labelFloat/>
         <mu-text-field label="五笔" hintText="请输入五笔" v-model="form.wubi"  lab labelFloat/>
         <mu-text-field label="拼音简拼" hintText="请输入拼音简拼" v-model="form.pinYin"  lab labelFloat/>
         <mu-text-field label="全拼" hintText="请输入全拼" v-model="form.fullPinYin"  lab labelFloat/>
         <mu-text-field label="等级" hintText="请输入等级" v-model="form.level"  lab labelFloat/>
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
  name: 'material-edit',
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
      title: '新增物资信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 名称 */
        name: '',
        /** 编号 */
        code: '',
        /** 单位 */
        unit: '',
        /** 规格 */
        specifications: '',
        /** 品牌 */
        trademark: '',
        /** 型号 */
        type: '',
        /** 生产厂家 */
        manufacturerId: '',
        /** 生产厂家 */
        manufacturer: '',
        /** 采购时间 */
        purchasingTime: Date.now(),
        /** 有效期 */
        periodTime: Date.now(),
        /** 产地 */
        place: '',
        /** 产地 */
        remark: '',
        /** 五笔 */
        wubi: '',
        /** 拼音简拼 */
        pinYin: '',
        /** 全拼 */
        fullPinYin: '',
        /** 等级 */
        level: 0,
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
      this.$request.save('material', this.form, function(respose) {
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
        this.title = '编辑物资信息'
        const _this = this
        this.$request.get('material/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
