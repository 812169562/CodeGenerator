using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Essentialinformations {
    /// <summary>
    /// 医馆
    /// </summary>
    [Description( "医馆" )]
    public partial class Tenant : Entityint,ISoftDelete {
        /// <summary>
        /// 初始化医馆
        /// </summary>
        public Tenant(){
        }
        /// <summary>
        /// 医馆名
        /// </summary>
        [Required(ErrorMessage = "医馆名不能为空")]
        [StringLength( 640, ErrorMessage = "医馆名输入过长，不能超过640位" )]
        public string TenantName { get; set; }
        /// <summary>
        /// 用户号
        /// </summary>
        [Required(ErrorMessage = "用户号不能为空")]
        [StringLength( 144, ErrorMessage = "用户号输入过长，不能超过144位" )]
        public string UserId { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        [StringLength( 160, ErrorMessage = "联系人输入过长，不能超过160位" )]
        public string TelName { get; set; }
        /// <summary>
        /// 联系地址
        /// </summary>
        [StringLength( 640, ErrorMessage = "联系地址输入过长，不能超过640位" )]
        public string Address { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        [Required(ErrorMessage = "联系电话不能为空")]
        [StringLength( 44, ErrorMessage = "联系电话输入过长，不能超过44位" )]
        public string TelPhone { get; set; }
        /// <summary>
        /// 坐标
        /// </summary>
        [StringLength( 320, ErrorMessage = "坐标输入过长，不能超过320位" )]
        public string Coordinate { get; set; }
        /// <summary>
        /// 营业证书
        /// </summary>
        [StringLength( 144, ErrorMessage = "营业证书输入过长，不能超过144位" )]
        public string BusinessCertificate { get; set; }
        /// <summary>
        /// 最大门店数量
        /// </summary>
        public int? MaxStore { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 144, ErrorMessage = "代码输入过长，不能超过144位" )]
        public string Code { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        [StringLength( 1600, ErrorMessage = "简介输入过长，不能超过1600位" )]
        public string Description { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        public int Type { get; set; }
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