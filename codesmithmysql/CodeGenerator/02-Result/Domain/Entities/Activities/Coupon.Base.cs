using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Activities {
    /// <summary>
    /// 优惠券
    /// </summary>
    [Description( "优惠券" )]
    public partial class Coupon : Entity,ISoftDelete {
        /// <summary>
        /// 初始化优惠券
        /// </summary>
        public Coupon(){
        }
        /// <summary>
        /// 优惠活动编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "优惠活动编号输入过长，不能超过108位" )]
        public string ActivityId { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        [StringLength( 900, ErrorMessage = "图片地址输入过长，不能超过900位" )]
        public string ImgPath { get; set; }
        /// <summary>
        /// 活动内容
        /// </summary>
        [StringLength( 450, ErrorMessage = "活动内容输入过长，不能超过450位" )]
        public string Name { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// 活动编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "活动编号输入过长，不能超过108位" )]
        public string Code { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public int? Stock { get; set; }
        /// <summary>
        /// 使用上限
        /// </summary>
        public int? UseLine { get; set; }
        /// <summary>
        /// 是否允许和其他优惠卷进行叠加
        /// </summary>
        public int? AllowableSuperposition { get; set; }
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
        /// 
        /// </summary>
        [StringLength( 1500, ErrorMessage = "输入过长，不能超过1500位" )]
        public string Instructions { get; set; }
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