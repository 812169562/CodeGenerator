using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Orders {
    /// <summary>
    ///  支付信息明细数据传输对象
    /// </summary>
    [DataContract]
    public class PaymentinformationdetailDto : BaseDto {
        /// <summary>
        /// 支付编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "支付编号输入过长，不能超过108位" )]
        [Display( Name = "支付编号" )]
        [DataMember]
        public string PaymentInformationId { get; set; }
        
        /// <summary>
        /// 项目编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目编号输入过长，不能超过108位" )]
        [Display( Name = "项目编号" )]
        [DataMember]
        public string ItemId { get; set; }
        
        /// <summary>
        /// 项目批次编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目批次编号输入过长，不能超过108位" )]
        [Display( Name = "项目批次编号" )]
        [DataMember]
        public string ItemBatchId { get; set; }
        
        /// <summary>
        /// 项目名称
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目名称输入过长，不能超过900位" )]
        [Display( Name = "项目名称" )]
        [DataMember]
        public string ItemName { get; set; }
        
        /// <summary>
        /// 项目规格
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目规格输入过长，不能超过900位" )]
        [Display( Name = "项目规格" )]
        [DataMember]
        public string ItemFormat { get; set; }
        
        /// <summary>
        /// 销售数量
        /// </summary>
        [Display( Name = "销售数量" )]
        [DataMember]
        public decimal? SalesCount { get; set; }
        
        /// <summary>
        /// 销售单价
        /// </summary>
        [Display( Name = "销售单价" )]
        [DataMember]
        public decimal? SalesPrice { get; set; }
        
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "销售单位输入过长，不能超过300位" )]
        [Display( Name = "销售单位" )]
        [DataMember]
        public string SalesUnit { get; set; }
        
        /// <summary>
        /// 项目备注
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目备注输入过长，不能超过900位" )]
        [Display( Name = "项目备注" )]
        [DataMember]
        public string Remark { get; set; }
        
        /// <summary>
        /// 项目类型编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目类型编号输入过长，不能超过108位" )]
        [Display( Name = "项目类型编号" )]
        [DataMember]
        public string ItemTypeId { get; set; }
        
        /// <summary>
        /// 项目类型
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目类型输入过长，不能超过900位" )]
        [Display( Name = "项目类型" )]
        [DataMember]
        public string ItemType { get; set; }
        
        /// <summary>
        /// 项目类型关系编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目类型关系编号输入过长，不能超过108位" )]
        [Display( Name = "项目类型关系编号" )]
        [DataMember]
        public string ItemTypeRelationId { get; set; }
        
    }
}
