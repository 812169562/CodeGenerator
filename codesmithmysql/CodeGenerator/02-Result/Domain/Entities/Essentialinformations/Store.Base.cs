using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Essentialinformations {
    /// <summary>
    /// 门店
    /// </summary>
    [Description( "门店" )]
    public partial class Store : Entity,ISoftDelete {
        /// <summary>
        /// 初始化门店
        /// </summary>
        public Store(){
        }
        /// <summary>
        /// 租户名
        /// </summary>
        [Required(ErrorMessage = "租户名不能为空")]
        [StringLength( 640, ErrorMessage = "租户名输入过长，不能超过640位" )]
        public string TenantName { get; set; }
        /// <summary>
        /// 店长编号
        /// </summary>
        [Required(ErrorMessage = "店长编号不能为空")]
        [StringLength( 144, ErrorMessage = "店长编号输入过长，不能超过144位" )]
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
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        public string Code { get; set; }
        /// <summary>
        /// 坐标
        /// </summary>
        [StringLength( 320, ErrorMessage = "坐标输入过长，不能超过320位" )]
        public string Coordinate { get; set; }
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