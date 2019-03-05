using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Activities {
    /// <summary>
    /// 优惠券领用
    /// </summary>
    [Description( "优惠券领用" )]
    public partial class Couponcollar : Entity,ISoftDelete {
        /// <summary>
        /// 初始化优惠券领用
        /// </summary>
        public Couponcollar(){
        }
        /// <summary>
        /// 优惠卷编号
        /// </summary>
        [Required(ErrorMessage = "优惠卷编号不能为空")]
        [StringLength( 108, ErrorMessage = "优惠卷编号输入过长，不能超过108位" )]
        public string CouponId { get; set; }
        /// <summary>
        /// 客户(患者)编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "客户(患者)编号输入过长，不能超过108位" )]
        public string CustomertId { get; set; }
        /// <summary>
        /// 客户(患者)姓名
        /// </summary>
        [StringLength( 300, ErrorMessage = "客户(患者)姓名输入过长，不能超过300位" )]
        public string CustomerName { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Required(ErrorMessage = "排序不能为空")]
        public int Sort { get; set; }
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