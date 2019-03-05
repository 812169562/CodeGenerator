using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Activities {
    /// <summary>
    /// 优惠卷消费记录数据传输对象
    /// </summary>
    [DataContract]
    public class CouponlogDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 优惠卷编号
        /// </summary>
        [Required(ErrorMessage = "优惠卷编号不能为空")]
        [StringLength( 108, ErrorMessage = "优惠卷编号输入过长，不能超过108位" )]
        [Display( Name = "优惠卷编号" )]
        [DataMember]
        public string CouponId { get; set; }
        
        /// <summary>
        /// 使用人编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "使用人编号输入过长，不能超过108位" )]
        [Display( Name = "使用人编号" )]
        [DataMember]
        public string UserId { get; set; }
        
        /// <summary>
        /// 消费条数
        /// </summary>
        [Display( Name = "消费条数" )]
        [DataMember]
        public int? Count { get; set; }
        
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        [Display( Name = "类型" )]
        [DataMember]
        public int Type { get; set; }
        
    }
}
