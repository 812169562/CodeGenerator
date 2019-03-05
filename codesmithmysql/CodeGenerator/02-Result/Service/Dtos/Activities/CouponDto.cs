using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Activities {
    /// <summary>
    /// 优惠券数据传输对象
    /// </summary>
    [DataContract]
    public class CouponDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 优惠活动编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "优惠活动编号输入过长，不能超过108位" )]
        [Display( Name = "优惠活动编号" )]
        [DataMember]
        public string ActivityId { get; set; }
        
        /// <summary>
        /// 图片地址
        /// </summary>
        [StringLength( 900, ErrorMessage = "图片地址输入过长，不能超过900位" )]
        [Display( Name = "图片地址" )]
        [DataMember]
        public string ImgPath { get; set; }
        
        /// <summary>
        /// 活动内容
        /// </summary>
        [StringLength( 450, ErrorMessage = "活动内容输入过长，不能超过450位" )]
        [Display( Name = "活动内容" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        [Display( Name = "类型" )]
        [DataMember]
        public int Type { get; set; }
        
        /// <summary>
        /// 等级
        /// </summary>
        [Display( Name = "等级" )]
        [DataMember]
        public int? Level { get; set; }
        
        /// <summary>
        /// 活动编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "活动编号输入过长，不能超过108位" )]
        [Display( Name = "活动编号" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 库存
        /// </summary>
        [Display( Name = "库存" )]
        [DataMember]
        public int? Stock { get; set; }
        
        /// <summary>
        /// 使用上限
        /// </summary>
        [Display( Name = "使用上限" )]
        [DataMember]
        public int? UseLine { get; set; }
        
        /// <summary>
        /// 是否允许和其他优惠卷进行叠加
        /// </summary>
        [Display( Name = "是否允许和其他优惠卷进行叠加" )]
        [DataMember]
        public int? AllowableSuperposition { get; set; }
        
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
        /// 
        /// </summary>
        [StringLength( 1500, ErrorMessage = "输入过长，不能超过1500位" )]
        [Display( Name = "" )]
        [DataMember]
        public string Instructions { get; set; }
        
    }
}
