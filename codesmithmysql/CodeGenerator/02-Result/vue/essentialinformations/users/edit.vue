<template>
 <el-dialog :title="title" :visible.sync="dialogVisible" width="55%" height="75%" :close-on-click-modal="false" :before-close="hidden" @open="open"  @close="hidden">
    <el-form :model="form">
         <mu-text-field label="用户名" hintText="请输入用户名" v-model="form.userName"  lab labelFloat/>
         <mu-text-field label="登陆号" hintText="请输入登陆号" v-model="form.loginCode"  lab labelFloat/>
         <mu-text-field label="电话号码" hintText="请输入电话号码" v-model="form.tel"  lab labelFloat/>
         <mu-text-field label="密码" hintText="请输入密码" v-model="form.pwd"  lab labelFloat/>
         <mu-text-field label="性别" hintText="请输入性别" v-model="form.sex"  lab labelFloat/>
         <mu-text-field label="微信识别号" hintText="请输入微信识别号" v-model="form.wxOpenId"  lab labelFloat/>
         <mu-text-field label="QQ识别号" hintText="请输入QQ识别号" v-model="form.qqOpenId"  lab labelFloat/>
         <mu-text-field label="类型" hintText="请输入类型" v-model="form.type"  lab labelFloat/>
         <mu-text-field label="电子邮件" hintText="请输入电子邮件" v-model="form.eMail"  lab labelFloat/>
         <mu-text-field label="是否锁定" hintText="请输入是否锁定" v-model="form.isLock"  lab labelFloat/>
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
  name: 'users-edit',
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
      title: '新增用户表信息'
    }
  },
  methods: {
    /** 初始化 */
    init() {
      this.form = {
        /** 用户名 */
        userName: '',
        /** 登陆号 */
        loginCode: '',
        /** 电话号码 */
        tel: '',
        /** 密码 */
        pwd: '',
        /** 性别 */
        sex: 0,
        /** 微信识别号 */
        wxOpenId: '',
        /** QQ识别号 */
        qqOpenId: '',
        /** 类型 */
        type: 0,
        /** 电子邮件 */
        eMail: '',
        /** 是否锁定 */
        isLock: '',
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
      this.$request.save('users', this.form, function(respose) {
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
        this.title = '编辑用户表信息'
        const _this = this
        this.$request.get('users/' + this.id, {}, (respose) => {
          _this.form = respose.data
        })
      }
    }
  }
}
</script>
