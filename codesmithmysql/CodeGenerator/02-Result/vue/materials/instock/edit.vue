﻿<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="类型" hintText="请输入类型" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="物资ID" hintText="请输入物资ID" v-model="form.materialsId"  lab labelFloat/>
         <mu-text-field label="名称" hintText="请输入名称" v-model="form.name"  lab labelFloat/>
         <mu-text-field label="规格" hintText="请输入规格" v-model="form.specifications"  lab labelFloat/>
         <mu-text-field label="采购价格" hintText="请输入采购价格" v-model="form.price"  lab labelFloat/>
         <mu-text-field label="数量" hintText="请输入数量" v-model="form.count"  lab labelFloat/>
         <mu-text-field label="单位" hintText="请输入单位" v-model="form.unit"  lab labelFloat/>
         <mu-text-field label="购买情况" hintText="请输入购买情况" v-model="form.purchasesId"  lab labelFloat/>
         <mu-text-field label="购买情况" hintText="请输入购买情况" v-model="form.purchases"  lab labelFloat/>
         <mu-date-picker  label="购买日期" hintText="请输入购买日期" v-model="form.purchaseDate"  lab labelFloat/>
         <mu-text-field label="库房" hintText="请输入库房" v-model="form.storehouseId"  lab labelFloat/>
         <mu-text-field label="库房" hintText="请输入库房" v-model="form.storehouse"  lab labelFloat/>
         <mu-text-field label="采购人" hintText="请输入采购人" v-model="form.purchaserId"  lab labelFloat/>
         <mu-text-field label="采购人" hintText="请输入采购人" v-model="form.purchaser"  lab labelFloat/>
         <mu-text-field label="产地" hintText="请输入产地" v-model="form.remark"  lab labelFloat/>
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
  name: 'instock-edit',
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
      title: '新增入库记录信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 类型 */
        type: 0,
        /** 物资ID */
        materialsId: '',
        /** 名称 */
        name: '',
        /** 规格 */
        specifications: '',
        /** 采购价格 */
        price: 0,
        /** 数量 */
        count: 0,
        /** 单位 */
        unit: '',
        /** 购买情况 */
        purchasesId: '',
        /** 购买情况 */
        purchases: '',
        /** 购买日期 */
        purchaseDate: Date.now(),
        /** 库房 */
        storehouseId: '',
        /** 库房 */
        storehouse: '',
        /** 采购人 */
        purchaserId: '',
        /** 采购人 */
        purchaser: '',
        /** 产地 */
        remark: '',
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
      this.$request.save('instock', this.form, function(respose) {
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
        this.title = '编辑入库记录信息'
        const _this = this
        this.$request.get('instock/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
