using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Essentialinformations;


namespace Sand.Domain.Queries.Essentialinformations {
    /// <summary>
    /// 用户表查询实体
    /// </summary>
    public class UsersQuery :  BaseQuery<Users> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 用户主键编号
        /// </summary>
        [Display(Name="用户主键编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _userName = string.Empty;
        /// <summary>
        /// 用户名
        /// </summary>
        [Display(Name="用户名")]
        public string UserName {
            get { return _userName == null ? string.Empty : _userName.Trim(); }
            set{ _userName=value;}
        }        
        
        private string _loginCode = string.Empty;
        /// <summary>
        /// 登陆号
        /// </summary>
        [Display(Name="登陆号")]
        public string LoginCode {
            get { return _loginCode == null ? string.Empty : _loginCode.Trim(); }
            set{ _loginCode=value;}
        }        
        
        private string _tel = string.Empty;
        /// <summary>
        /// 电话号码
        /// </summary>
        [Display(Name="电话号码")]
        public string Tel {
            get { return _tel == null ? string.Empty : _tel.Trim(); }
            set{ _tel=value;}
        }        
        
        private string _pwd = string.Empty;
        /// <summary>
        /// 密码
        /// </summary>
        [Display(Name="密码")]
        public string Pwd {
            get { return _pwd == null ? string.Empty : _pwd.Trim(); }
            set{ _pwd=value;}
        }        
        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name="性别")]
        public int? Sex { get; set; }
        
        private string _wxOpenId = string.Empty;
        /// <summary>
        /// 微信识别号
        /// </summary>
        [Display(Name="微信识别号")]
        public string WxOpenId {
            get { return _wxOpenId == null ? string.Empty : _wxOpenId.Trim(); }
            set{ _wxOpenId=value;}
        }        
        
        private string _qqOpenId = string.Empty;
        /// <summary>
        /// QQ识别号
        /// </summary>
        [Display(Name="QQ识别号")]
        public string QqOpenId {
            get { return _qqOpenId == null ? string.Empty : _qqOpenId.Trim(); }
            set{ _qqOpenId=value;}
        }        
        /// <summary>
        /// 类型
        /// </summary>
        [Display(Name="类型")]
        public int? Type { get; set; }
        
        private string _eMail = string.Empty;
        /// <summary>
        /// 电子邮件
        /// </summary>
        [Display(Name="电子邮件")]
        public string EMail {
            get { return _eMail == null ? string.Empty : _eMail.Trim(); }
            set{ _eMail=value;}
        }        
        /// <summary>
        /// 是否可用
        /// </summary>
        [Display(Name="是否可用")]
        public sbyte? IsEnable { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
        [Display(Name="是否锁定")]
        public sbyte? IsLock { get; set; }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreateTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreateTime { get; set; }        
        
        private string _createId = string.Empty;
        /// <summary>
        /// 创建者
        /// </summary>
        [Display(Name="创建者")]
        public string CreateId {
            get { return _createId == null ? string.Empty : _createId.Trim(); }
            set{ _createId=value;}
        }        
        
        private string _createName = string.Empty;
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name="创建人")]
        public string CreateName {
            get { return _createName == null ? string.Empty : _createName.Trim(); }
            set{ _createName=value;}
        }        
        /// <summary>
        /// 起始最近更新时间
        /// </summary>
        [Display( Name = "起始最近更新时间" )]
        public DateTime? BeginLastUpdateTime { get; set; }
        /// <summary>
        /// 结束最近更新时间
        /// </summary>
        [Display( Name = "结束最近更新时间" )]
        public DateTime? EndLastUpdateTime { get; set; }        
        
        private string _lastUpdateId = string.Empty;
        /// <summary>
        /// 最近更新者
        /// </summary>
        [Display(Name="最近更新者")]
        public string LastUpdateId {
            get { return _lastUpdateId == null ? string.Empty : _lastUpdateId.Trim(); }
            set{ _lastUpdateId=value;}
        }        
        
        private string _lastUpdateName = string.Empty;
        /// <summary>
        /// 最近更新人
        /// </summary>
        [Display(Name="最近更新人")]
        public string LastUpdateName {
            get { return _lastUpdateName == null ? string.Empty : _lastUpdateName.Trim(); }
            set{ _lastUpdateName=value;}
        }        
        
        private string _version = string.Empty;
        /// <summary>
        /// 版本号
        /// </summary>
        [Display(Name="版本号")]
        public string Version {
            get { return _version == null ? string.Empty : _version.Trim(); }
            set{ _version=value;}
        }        
        /// <summary>
        /// 删除标志
        /// </summary>
        [Display(Name="删除标志")]
        public sbyte? IsDeleted { get; set; }
        
    }
}
