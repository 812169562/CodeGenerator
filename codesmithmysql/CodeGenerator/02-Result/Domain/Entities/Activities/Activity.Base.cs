using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Activities {
    /// <summary>
    /// 优惠活动 
    /// </summary>
    [Description( "优惠活动 " )]
    public partial class Activity : Entity,ISoftDelete {
        /// <summary>
        /// 初始化优惠活动 
        /// </summary>
        public Activity(){
        }
        /// <summary>
        /// 活动内容
        /// </summary>
        [StringLength( 65535, ErrorMessage = "活动内容输入过长，不能超过65535位" )]
        public string Name { get; set; }
        /// <summary>
        /// 活动编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "活动编号输入过长，不能超过108位" )]
        public string Code { get; set; }
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
        /// 
        /// </summary>
        [StringLength( 300, ErrorMessage = "输入过长，不能超过300位" )]
        public string Title { get; set; }
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