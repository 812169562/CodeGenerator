using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Medicinestores {
    /// <summary>
    /// 药品批次信息数据传输对象
    /// </summary>
    [DataContract]
    public class DrugbatchDto : BaseDto {
        /// <summary>
        /// 批次号（系统按照日期生成）
        /// </summary>
        [StringLength( 108, ErrorMessage = "批次号（系统按照日期生成）输入过长，不能超过108位" )]
        [Display( Name = "批次号（系统按照日期生成）" )]
        [DataMember]
        public string BatchNumber { get; set; }
        
        /// <summary>
        /// 药品生产批号
        /// </summary>
        [StringLength( 300, ErrorMessage = "药品生产批号输入过长，不能超过300位" )]
        [Display( Name = "药品生产批号" )]
        [DataMember]
        public string BatchCode { get; set; }
        
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 药品编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "药品编号输入过长，不能超过108位" )]
        [Display( Name = "药品编号" )]
        [DataMember]
        public string DrugId { get; set; }
        
        /// <summary>
        /// 最小单位价格(自动计算)
        /// </summary>
        [Display( Name = "最小单位价格(自动计算)" )]
        [DataMember]
        public decimal? Price { get; set; }
        
        /// <summary>
        /// 销售价(包装单位)
        /// </summary>
        [Display( Name = "销售价(包装单位)" )]
        [DataMember]
        public decimal? SalesPrice { get; set; }
        
        /// <summary>
        /// 成本价(包装单位)
        /// </summary>
        [Display( Name = "成本价(包装单位)" )]
        [DataMember]
        public decimal? CostPrice { get; set; }
        
        /// <summary>
        /// 有效期
        /// </summary>
        [Display( Name = "有效期" )]
        [DataMember]
        public DateTime? ExpiryDate { get; set; }
        
        /// <summary>
        /// 生产日期
        /// </summary>
        [Display( Name = "生产日期" )]
        [DataMember]
        public DateTime? ManufactureDate { get; set; }
        
        /// <summary>
        /// 保质期
        /// </summary>
        [Display( Name = "保质期" )]
        [DataMember]
        public int? HelflifeDay { get; set; }
        
        /// <summary>
        /// 供应商
        /// </summary>
        [StringLength( 108, ErrorMessage = "供应商输入过长，不能超过108位" )]
        [Display( Name = "供应商" )]
        [DataMember]
        public string SupplierId { get; set; }
        
        /// <summary>
        /// 供应商
        /// </summary>
        [StringLength( 300, ErrorMessage = "供应商输入过长，不能超过300位" )]
        [Display( Name = "供应商" )]
        [DataMember]
        public string Supplier { get; set; }
        
    }
}
