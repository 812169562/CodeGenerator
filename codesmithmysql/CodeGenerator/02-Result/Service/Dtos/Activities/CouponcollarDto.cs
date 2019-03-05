using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Activities {
    /// <summary>
    /// 优惠券领用数据传输对象
    /// </summary>
    [DataContract]
    public class CouponcollarDto : BaseDto {
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
        /// 客户(患者)编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "客户(患者)编号输入过长，不能超过108位" )]
        [Display( Name = "客户(患者)编号" )]
        [DataMember]
        public string CustomertId { get; set; }
        
        /// <summary>
        /// 客户(患者)姓名
        /// </summary>
        [StringLength( 300, ErrorMessage = "客户(患者)姓名输入过长，不能超过300位" )]
        [Display( Name = "客户(患者)姓名" )]
        [DataMember]
        public string CustomerName { get; set; }
        
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
        
    }
}
