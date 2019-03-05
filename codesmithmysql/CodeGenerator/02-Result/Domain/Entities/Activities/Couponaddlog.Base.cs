using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Activities {
    /// <summary>
    /// 优惠卷库存新增记录
    /// </summary>
    [Description( "优惠卷库存新增记录" )]
    public partial class Couponaddlog : Entity,ISoftDelete {
        /// <summary>
        /// 初始化优惠卷库存新增记录
        /// </summary>
        public Couponaddlog(){
        }
        /// <summary>
        /// 优惠卷编号
        /// </summary>
        [Required(ErrorMessage = "优惠卷编号不能为空")]
        [StringLength( 108, ErrorMessage = "优惠卷编号输入过长，不能超过108位" )]
        public string CouponId { get; set; }
        /// <summary>
        /// 新增条数
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 300, ErrorMessage = "备注输入过长，不能超过300位" )]
        public string Remark { get; set; }
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