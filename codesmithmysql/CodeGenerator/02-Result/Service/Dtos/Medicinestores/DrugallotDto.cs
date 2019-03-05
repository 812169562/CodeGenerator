using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Medicinestores {
    /// <summary>
    /// 药品调拨数据传输对象
    /// </summary>
    [DataContract]
    public class DrugallotDto : BaseDto {
        /// <summary>
        /// 调拨类型
        /// </summary>
        [Display( Name = "调拨类型" )]
        [DataMember]
        public int? Type { get; set; }
        
        /// <summary>
        /// 调拨单号
        /// </summary>
        [StringLength( 150, ErrorMessage = "调拨单号输入过长，不能超过150位" )]
        [Display( Name = "调拨单号" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 申请人
        /// </summary>
        [StringLength( 108, ErrorMessage = "申请人输入过长，不能超过108位" )]
        [Display( Name = "申请人" )]
        [DataMember]
        public string ApplyId { get; set; }
        
        /// <summary>
        /// 申请人
        /// </summary>
        [StringLength( 300, ErrorMessage = "申请人输入过长，不能超过300位" )]
        [Display( Name = "申请人" )]
        [DataMember]
        public string ApplyName { get; set; }
        
        /// <summary>
        /// 申请日期
        /// </summary>
        [Display( Name = "申请日期" )]
        [DataMember]
        public DateTime? ApplyDate { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 1200, ErrorMessage = "备注输入过长，不能超过1200位" )]
        [Display( Name = "备注" )]
        [DataMember]
        public string ApplyRemark { get; set; }
        
        /// <summary>
        /// 审核编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "审核编号输入过长，不能超过108位" )]
        [Display( Name = "审核编号" )]
        [DataMember]
        public string AuditId { get; set; }
        
        /// <summary>
        /// 审核人
        /// </summary>
        [StringLength( 300, ErrorMessage = "审核人输入过长，不能超过300位" )]
        [Display( Name = "审核人" )]
        [DataMember]
        public string AuditName { get; set; }
        
        /// <summary>
        /// 审核时间
        /// </summary>
        [Display( Name = "审核时间" )]
        [DataMember]
        public DateTime? AuditDate { get; set; }
        
        /// <summary>
        /// 审核意见
        /// </summary>
        [StringLength( 1200, ErrorMessage = "审核意见输入过长，不能超过1200位" )]
        [Display( Name = "审核意见" )]
        [DataMember]
        public string AuditOpinion { get; set; }
        
        /// <summary>
        /// 入库编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "入库编号输入过长，不能超过108位" )]
        [Display( Name = "入库编号" )]
        [DataMember]
        public string InId { get; set; }
        
        /// <summary>
        /// 调拨入库库房编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "调拨入库库房编号输入过长，不能超过108位" )]
        [Display( Name = "调拨入库库房编号" )]
        [DataMember]
        public string InStroeId { get; set; }
        
        /// <summary>
        /// 调拨入库库房
        /// </summary>
        [StringLength( 300, ErrorMessage = "调拨入库库房输入过长，不能超过300位" )]
        [Display( Name = "调拨入库库房" )]
        [DataMember]
        public string InStroeName { get; set; }
        
        /// <summary>
        /// 入库单据号
        /// </summary>
        [StringLength( 75, ErrorMessage = "入库单据号输入过长，不能超过75位" )]
        [Display( Name = "入库单据号" )]
        [DataMember]
        public string InCode { get; set; }
        
        /// <summary>
        /// 出库编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "出库编号输入过长，不能超过108位" )]
        [Display( Name = "出库编号" )]
        [DataMember]
        public string OutId { get; set; }
        
        /// <summary>
        /// 调拨出库库房编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "调拨出库库房编号输入过长，不能超过108位" )]
        [Display( Name = "调拨出库库房编号" )]
        [DataMember]
        public string OutStroeId { get; set; }
        
        /// <summary>
        /// 调拨出库库房
        /// </summary>
        [StringLength( 300, ErrorMessage = "调拨出库库房输入过长，不能超过300位" )]
        [Display( Name = "调拨出库库房" )]
        [DataMember]
        public string OutStroeName { get; set; }
        
        /// <summary>
        /// 出库库单据号
        /// </summary>
        [StringLength( 75, ErrorMessage = "出库库单据号输入过长，不能超过75位" )]
        [Display( Name = "出库库单据号" )]
        [DataMember]
        public string OutCode { get; set; }
        
    }
}
