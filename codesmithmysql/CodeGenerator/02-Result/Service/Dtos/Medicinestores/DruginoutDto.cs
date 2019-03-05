using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Medicinestores {
    /// <summary>
    /// 药品出入库数据传输对象
    /// </summary>
    [DataContract]
    public class DruginoutDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 出入库单号
        /// </summary>
        [StringLength( 300, ErrorMessage = "出入库单号输入过长，不能超过300位" )]
        [Display( Name = "出入库单号" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 出入库类型
        /// </summary>
        [Display( Name = "出入库类型" )]
        [DataMember]
        public int? Type { get; set; }
        
        /// <summary>
        /// 出入库类型（来自字典表）
        /// </summary>
        [StringLength( 108, ErrorMessage = "出入库类型（来自字典表）输入过长，不能超过108位" )]
        [Display( Name = "出入库类型（来自字典表）" )]
        [DataMember]
        public string InOutTypeId { get; set; }
        
        /// <summary>
        /// 出入库类型（来自字典表）
        /// </summary>
        [StringLength( 300, ErrorMessage = "出入库类型（来自字典表）输入过长，不能超过300位" )]
        [Display( Name = "出入库类型（来自字典表）" )]
        [DataMember]
        public string InOutTypeName { get; set; }
        
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
        /// 申请备注
        /// </summary>
        [StringLength( 1200, ErrorMessage = "申请备注输入过长，不能超过1200位" )]
        [Display( Name = "申请备注" )]
        [DataMember]
        public string ApplyRemark { get; set; }
        
        /// <summary>
        /// 出入库房
        /// </summary>
        [StringLength( 108, ErrorMessage = "出入库房输入过长，不能超过108位" )]
        [Display( Name = "出入库房" )]
        [DataMember]
        public string StoreId { get; set; }
        
        /// <summary>
        /// 出入库房
        /// </summary>
        [StringLength( 300, ErrorMessage = "出入库房输入过长，不能超过300位" )]
        [Display( Name = "出入库房" )]
        [DataMember]
        public string StoreName { get; set; }
        
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
        
    }
}
