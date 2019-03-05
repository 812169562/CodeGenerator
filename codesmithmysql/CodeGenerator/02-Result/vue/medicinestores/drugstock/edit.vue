<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label=" 门店" hintText="请输入 门店" v-model="form.stroeName"  lab labelFloat/>
         <mu-text-field label="门店号" hintText="请输入门店号" v-model="form.stroeId"  lab labelFloat/>
         <mu-text-field label="批次编号" hintText="请输入批次编号" v-model="form.batchId"  lab labelFloat/>
         <mu-text-field label="药品编号" hintText="请输入药品编号" v-model="form.drugId"  lab labelFloat/>
         <mu-text-field label="药房编号" hintText="请输入药房编号" v-model="form.drugstoreId"  lab labelFloat/>
         <mu-text-field label="药房" hintText="请输入药房" v-model="form.drugstoreName"  lab labelFloat/>
         <mu-text-field label="库存量(销售单位)" hintText="请输入库存量(销售单位)" v-model="form.inventoryCount"  lab labelFloat/>
         <mu-text-field label="锁定量" hintText="请输入锁定量" v-model="form.lockCount"  lab labelFloat/>
         <mu-text-field label="盘点顺序表" hintText="请输入盘点顺序表" v-model="form.checkNumber"  lab labelFloat/>
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
  name: 'drugstock-edit',
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
      title: '新增库存(均以销售单位为库存量)信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /**  门店 */
        stroeName: '',
        /** 门店号 */
        stroeId: '',
        /** 批次编号 */
        batchId: '',
        /** 药品编号 */
        drugId: '',
        /** 药房编号 */
        drugstoreId: '',
        /** 药房 */
        drugstoreName: '',
        /** 库存量(销售单位) */
        inventoryCount: 0,
        /** 锁定量 */
        lockCount: 0,
        /** 盘点顺序表 */
        checkNumber: '',
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
      this.$request.save('drugstock', this.form, function(respose) {
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
        this.title = '编辑库存(均以销售单位为库存量)信息'
        const _this = this
        this.$request.get('drugstock/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
