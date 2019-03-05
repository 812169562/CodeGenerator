<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="代码" hintText="请输入代码" v-model="form.code"  lab labelFloat/>
         <mu-text-field label="（如：成药,精麻,等等）" hintText="请输入（如：成药,精麻,等等）" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="条码" hintText="请输入条码" v-model="form.barcode"  lab labelFloat/>
         <mu-text-field label="药品名称" hintText="请输入药品名称" v-model="form.drugName"  lab labelFloat/>
         <mu-text-field label="别名" hintText="请输入别名" v-model="form.alias"  lab labelFloat/>
         <mu-text-field label="药品分类" hintText="请输入药品分类" v-model="form.drugTypeId"  lab labelFloat/>
         <mu-text-field label="药品分类" hintText="请输入药品分类" v-model="form.drugType"  lab labelFloat/>
         <mu-text-field label="药品分类类型" hintText="请输入药品分类类型" v-model="form.drugTypeRelationShip"  lab labelFloat/>
         <mu-text-field label="英文名" hintText="请输入英文名" v-model="form.englishName"  lab labelFloat/>
         <mu-text-field label="库房单位" hintText="请输入库房单位" v-model="form.storeroomUnitId"  lab labelFloat/>
         <mu-text-field label="库房单位" hintText="请输入库房单位" v-model="form.storeroomUnit"  lab labelFloat/>
         <mu-text-field label="使用单位" hintText="请输入使用单位" v-model="form.useUnitId"  lab labelFloat/>
         <mu-text-field label="使用单位" hintText="请输入使用单位" v-model="form.useUnit"  lab labelFloat/>
         <mu-text-field label="销售单位" hintText="请输入销售单位" v-model="form.salesUnitId"  lab labelFloat/>
         <mu-text-field label="销售单位" hintText="请输入销售单位" v-model="form.salesUnit"  lab labelFloat/>
         <mu-text-field label="基本单位" hintText="请输入基本单位" v-model="form.basicUnitId"  lab labelFloat/>
         <mu-text-field label="基本单位" hintText="请输入基本单位" v-model="form.basicUnit"  lab labelFloat/>
         <mu-text-field label="是否按照实际库存卖" hintText="请输入是否按照实际库存卖" v-model="form.isActualInventory"  lab labelFloat/>
         <mu-text-field label="库房比例" hintText="请输入库房比例" v-model="form.storeroomRatio"  lab labelFloat/>
         <mu-text-field label="销售比例" hintText="请输入销售比例" v-model="form.salesRatio"  lab labelFloat/>
         <mu-text-field label="常用剂量" hintText="请输入常用剂量" v-model="form.commonDose"  lab labelFloat/>
         <mu-text-field label="儿童常用剂量" hintText="请输入儿童常用剂量" v-model="form.chlidCommonDose"  lab labelFloat/>
         <mu-text-field label="生产厂家" hintText="请输入生产厂家" v-model="form.manufacturerId"  lab labelFloat/>
         <mu-text-field label="生产厂家" hintText="请输入生产厂家" v-model="form.manufacturer"  lab labelFloat/>
         <mu-text-field label="规格" hintText="请输入规格" v-model="form.format"  lab labelFloat/>
         <mu-text-field label="产地" hintText="请输入产地" v-model="form.place"  lab labelFloat/>
         <mu-text-field label="下限提醒" hintText="请输入下限提醒" v-model="form.lowerLimit"  lab labelFloat/>
         <mu-text-field label="是否为处方药品" hintText="请输入是否为处方药品" v-model="form.isPrescription"  lab labelFloat/>
         <mu-text-field label=" 药品通用码（869）" hintText="请输入 药品通用码（869）" v-model="form.drugCommCode"  lab labelFloat/>
         <mu-text-field label="备注" hintText="请输入备注" v-model="form.remarks"  lab labelFloat/>
         <mu-text-field label="使用说明书地址" hintText="请输入使用说明书地址" v-model="form.usePath"  lab labelFloat/>
         <mu-text-field label="药品图片" hintText="请输入药品图片" v-model="form.img"  lab labelFloat/>
         <mu-text-field label="DDD规格" hintText="请输入DDD规格" v-model="form.dddFomat"  lab labelFloat/>
         <mu-text-field label="DDD值" hintText="请输入DDD值" v-model="form.dddValue"  lab labelFloat/>
         <mu-text-field label="拼音简拼" hintText="请输入拼音简拼" v-model="form.pinYin"  lab labelFloat/>
         <mu-text-field label="全拼" hintText="请输入全拼" v-model="form.fullPinYin"  lab labelFloat/>
         <mu-text-field label="五笔" hintText="请输入五笔" v-model="form.wubi"  lab labelFloat/>
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
  name: 'drugs-edit',
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
      title: '新增药品基本信息信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 门店号 */
        stroeId: '',
        /** 代码 */
        code: '',
        /** （如：成药,精麻,等等） */
        type: 0,
        /** 条码 */
        barcode: '',
        /** 药品名称 */
        drugName: '',
        /** 别名 */
        alias: '',
        /** 药品分类 */
        drugTypeId: '',
        /** 药品分类 */
        drugType: '',
        /** 药品分类类型 */
        drugTypeRelationShip: '',
        /** 英文名 */
        englishName: '',
        /** 库房单位 */
        storeroomUnitId: '',
        /** 库房单位 */
        storeroomUnit: '',
        /** 使用单位 */
        useUnitId: '',
        /** 使用单位 */
        useUnit: '',
        /** 销售单位 */
        salesUnitId: '',
        /** 销售单位 */
        salesUnit: '',
        /** 基本单位 */
        basicUnitId: '',
        /** 基本单位 */
        basicUnit: '',
        /** 是否按照实际库存卖 */
        isActualInventory: '',
        /** 库房比例 */
        storeroomRatio: 0,
        /** 销售比例 */
        salesRatio: 0,
        /** 常用剂量 */
        commonDose: 0,
        /** 儿童常用剂量 */
        chlidCommonDose: 0,
        /** 生产厂家 */
        manufacturerId: '',
        /** 生产厂家 */
        manufacturer: '',
        /** 规格 */
        format: '',
        /** 产地 */
        place: '',
        /** 下限提醒 */
        lowerLimit: 0,
        /** 是否为处方药品 */
        isPrescription: 0,
        /**  药品通用码（869） */
        drugCommCode: '',
        /** 备注 */
        remarks: '',
        /** 使用说明书地址 */
        usePath: '',
        /** 药品图片 */
        img: '',
        /** DDD规格 */
        dddFomat: 0,
        /** DDD值 */
        dddValue: 0,
        /** 拼音简拼 */
        pinYin: '',
        /** 全拼 */
        fullPinYin: '',
        /** 五笔 */
        wubi: '',
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
      this.$request.save('drugs', this.form, function(respose) {
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
        this.title = '编辑药品基本信息信息'
        const _this = this
        this.$request.get('drugs/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
