using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Activities {
    /// <summary>
    /// 优惠卷消费记录
    /// </summary>
    [Description( "优惠卷消费记录" )]
    public partial class Couponlog : Entity,ISoftDelete {
        /// <summary>
        /// 初始化优惠卷消费记录
        /// </summary>
        public Couponlog(){
        }
        /// <summary>
        /// 优惠卷编号
        /// </summary>
        [Required(ErrorMessage = "优惠卷编号不能为空")]
        [StringLength( 108, ErrorMessage = "优惠卷编号输入过长，不能超过108位" )]
        public string CouponId { get; set; }
        /// <summary>
        /// 使用人编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "使用人编号输入过长，不能超过108位" )]
        public string UserId { get; set; }
        /// <summary>
        /// 消费条数
        /// </summary>
        public int? Count { get; set; }
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