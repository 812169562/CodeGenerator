using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Essentialinformations {
    /// <summary>
    /// 用户表
    /// </summary>
    [Description( "用户表" )]
    public partial class Users : Entity,ISoftDelete {
        /// <summary>
        /// 初始化用户表
        /// </summary>
        public Users(){
        }
        /// <summary>
        /// 用户名
        /// </summary>
        [Required(ErrorMessage = "用户名不能为空")]
        [StringLength( 144, ErrorMessage = "用户名输入过长，不能超过144位" )]
        public string UserName { get; set; }
        /// <summary>
        /// 登陆号
        /// </summary>
        [Required(ErrorMessage = "登陆号不能为空")]
        [StringLength( 72, ErrorMessage = "登陆号输入过长，不能超过72位" )]
        public string LoginCode { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        [Required(ErrorMessage = "电话号码不能为空")]
        [StringLength( 72, ErrorMessage = "电话号码输入过长，不能超过72位" )]
        public string Tel { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [StringLength( 72, ErrorMessage = "密码输入过长，不能超过72位" )]
        public string Pwd { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int? Sex { get; set; }
        /// <summary>
        /// 微信识别号
        /// </summary>
        [StringLength( 512, ErrorMessage = "微信识别号输入过长，不能超过512位" )]
        public string WxOpenId { get; set; }
        /// <summary>
        /// QQ识别号
        /// </summary>
        [StringLength( 512, ErrorMessage = "QQ识别号输入过长，不能超过512位" )]
        public string QqOpenId { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        [StringLength( 240, ErrorMessage = "电子邮件输入过长，不能超过240位" )]
        public string EMail { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
        public sbyte? IsLock { get; set; }
         /// <summary>
        /// 删除标志
        /// </summary>
        [Required(ErrorMessage = "删除标志不能为空")]
        public bool IsDeleted { get; set; }
        
        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init()
        {
            this.Id = Uuid.Next();
            base.Init();
        }
 
        /// <summary>
        /// 加载
        /// </summary>
        public override void Load(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}