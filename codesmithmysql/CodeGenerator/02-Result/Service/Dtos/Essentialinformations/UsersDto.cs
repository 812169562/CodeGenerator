using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Essentialinformations {
    /// <summary>
    /// 用户表数据传输对象
    /// </summary>
    [DataContract]
    public class UsersDto : BaseDto {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required(ErrorMessage = "用户名不能为空")]
        [StringLength( 144, ErrorMessage = "用户名输入过长，不能超过144位" )]
        [Display( Name = "用户名" )]
        [DataMember]
        public string UserName { get; set; }
        
        /// <summary>
        /// 登陆号
        /// </summary>
        [Required(ErrorMessage = "登陆号不能为空")]
        [StringLength( 72, ErrorMessage = "登陆号输入过长，不能超过72位" )]
        [Display( Name = "登陆号" )]
        [DataMember]
        public string LoginCode { get; set; }
        
        /// <summary>
        /// 电话号码
        /// </summary>
        [Required(ErrorMessage = "电话号码不能为空")]
        [StringLength( 72, ErrorMessage = "电话号码输入过长，不能超过72位" )]
        [Display( Name = "电话号码" )]
        [DataMember]
        public string Tel { get; set; }
        
        /// <summary>
        /// 密码
        /// </summary>
        [StringLength( 72, ErrorMessage = "密码输入过长，不能超过72位" )]
        [Display( Name = "密码" )]
        [DataMember]
        public string Pwd { get; set; }
        
        /// <summary>
        /// 性别
        /// </summary>
        [Display( Name = "性别" )]
        [DataMember]
        public int? Sex { get; set; }
        
        /// <summary>
        /// 微信识别号
        /// </summary>
        [StringLength( 512, ErrorMessage = "微信识别号输入过长，不能超过512位" )]
        [Display( Name = "微信识别号" )]
        [DataMember]
        public string WxOpenId { get; set; }
        
        /// <summary>
        /// QQ识别号
        /// </summary>
        [StringLength( 512, ErrorMessage = "QQ识别号输入过长，不能超过512位" )]
        [Display( Name = "QQ识别号" )]
        [DataMember]
        public string QqOpenId { get; set; }
        
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        [Display( Name = "类型" )]
        [DataMember]
        public int Type { get; set; }
        
        /// <summary>
        /// 电子邮件
        /// </summary>
        [StringLength( 240, ErrorMessage = "电子邮件输入过长，不能超过240位" )]
        [Display( Name = "电子邮件" )]
        [DataMember]
        public string EMail { get; set; }
        
        /// <summary>
        /// 是否锁定
        /// </summary>
        [Display( Name = "是否锁定" )]
        [DataMember]
        public sbyte? IsLock { get; set; }
        
    }
}
