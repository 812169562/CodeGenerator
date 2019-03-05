using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Activities {
    /// <summary>
    /// 优惠活动 数据传输对象
    /// </summary>
    [DataContract]
    public class ActivityDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 活动内容
        /// </summary>
        [StringLength( 65535, ErrorMessage = "活动内容输入过长，不能超过65535位" )]
        [Display( Name = "活动内容" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 活动编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "活动编号输入过长，不能超过108位" )]
        [Display( Name = "活动编号" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 开始时间
        /// </summary>
        [Display( Name = "开始时间" )]
        [DataMember]
        public DateTime? StartTime { get; set; }
        
        /// <summary>
        /// 结束时间
        /// </summary>
        [Display( Name = "结束时间" )]
        [DataMember]
        public DateTime? EndTime { get; set; }
        
        /// <summary>
        /// 排序
        /// </summary>
        [Required(ErrorMessage = "排序不能为空")]
        [Display( Name = "排序" )]
        [DataMember]
        public int Sort { get; set; }
        
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        [Display( Name = "类型" )]
        [DataMember]
        public int Type { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength( 300, ErrorMessage = "输入过长，不能超过300位" )]
        [Display( Name = "" )]
        [DataMember]
        public string Title { get; set; }
        
    }
}
