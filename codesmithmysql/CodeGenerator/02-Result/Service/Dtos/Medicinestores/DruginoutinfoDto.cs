using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Medicinestores {
    /// <summary>
    /// 出入库明细表数据传输对象
    /// </summary>
    [DataContract]
    public class DruginoutinfoDto : BaseDto {
        /// <summary>
        /// 出入库编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "出入库编号输入过长，不能超过108位" )]
        [Display( Name = "出入库编号" )]
        [DataMember]
        public string DrugInOutId { get; set; }
        
        /// <summary>
        /// 批次编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "批次编号输入过长，不能超过108位" )]
        [Display( Name = "批次编号" )]
        [DataMember]
        public string BatchId { get; set; }
        
        /// <summary>
        /// 药品编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "药品编号输入过长，不能超过108位" )]
        [Display( Name = "药品编号" )]
        [DataMember]
        public string DrugId { get; set; }
        
        /// <summary>
        /// 药品名称
        /// </summary>
        [StringLength( 300, ErrorMessage = "药品名称输入过长，不能超过300位" )]
        [Display( Name = "药品名称" )]
        [DataMember]
        public string DrugName { get; set; }
        
        /// <summary>
        /// 规格
        /// </summary>
        [StringLength( 150, ErrorMessage = "规格输入过长，不能超过150位" )]
        [Display( Name = "规格" )]
        [DataMember]
        public string Format { get; set; }
        
        /// <summary>
        /// 销售价(包装单位)
        /// </summary>
        [Display( Name = "销售价(包装单位)" )]
        [DataMember]
        public decimal? SalesPrice { get; set; }
        
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "销售单位输入过长，不能超过108位" )]
        [Display( Name = "销售单位" )]
        [DataMember]
        public string SalesUnitId { get; set; }
        
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "销售单位输入过长，不能超过300位" )]
        [Display( Name = "销售单位" )]
        [DataMember]
        public string SalesUnit { get; set; }
        
        /// <summary>
        /// 成本价(包装单位)
        /// </summary>
        [Display( Name = "成本价(包装单位)" )]
        [DataMember]
        public decimal? CostPrice { get; set; }
        
        /// <summary>
        /// 调拨入库数量(销售单位为数量)
        /// </summary>
        [Display( Name = "调拨入库数量(销售单位为数量)" )]
        [DataMember]
        public int? InOutCount { get; set; }
        
        /// <summary>
        /// 药品生产批号
        /// </summary>
        [StringLength( 150, ErrorMessage = "药品生产批号输入过长，不能超过150位" )]
        [Display( Name = "药品生产批号" )]
        [DataMember]
        public string BatchCode { get; set; }
        
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
        /// 是否调价
        /// </summary>
        [Display( Name = "是否调价" )]
        [DataMember]
        public sbyte? IsModifyPrice { get; set; }
        
        /// <summary>
        /// 调整之后价格
        /// </summary>
        [Display( Name = "调整之后价格" )]
        [DataMember]
        public decimal? ModifyPrice { get; set; }
        
        /// <summary>
        /// 调价生效日期
        /// </summary>
        [Display( Name = "调价生效日期" )]
        [DataMember]
        public DateTime? ModifyPriceDate { get; set; }
        
        /// <summary>
        /// 剩余多少库存之后调价生效
        /// </summary>
        [Display( Name = "剩余多少库存之后调价生效" )]
        [DataMember]
        public int? ModifyPriceCount { get; set; }
        
    }
}
