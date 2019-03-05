using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Medicinestores;


namespace Sand.Domain.Queries.Medicinestores {
    /// <summary>
    /// 药品出入库查询实体
    /// </summary>
    public class DruginoutQuery :  BaseQuery<Druginout> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 调拨编号
        /// </summary>
        [Display(Name="调拨编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _tenantId = string.Empty;
        /// <summary>
        /// 医馆
        /// </summary>
        [Display(Name="医馆")]
        public string TenantId {
            get { return _tenantId == null ? string.Empty : _tenantId.Trim(); }
            set{ _tenantId=value;}
        }        
        
        private string _stroeId = string.Empty;
        /// <summary>
        /// 门店号
        /// </summary>
        [Display(Name="门店号")]
        public string StroeId {
            get { return _stroeId == null ? string.Empty : _stroeId.Trim(); }
            set{ _stroeId=value;}
        }        
        
        private string _code = string.Empty;
        /// <summary>
        /// 出入库单号
        /// </summary>
        [Display(Name="出入库单号")]
        public string Code {
            get { return _code == null ? string.Empty : _code.Trim(); }
            set{ _code=value;}
        }        
        /// <summary>
        /// 出入库类型
        /// </summary>
        [Display(Name="出入库类型")]
        public int? Type { get; set; }
        
        private string _inOutTypeId = string.Empty;
        /// <summary>
        /// 出入库类型（来自字典表）
        /// </summary>
        [Display(Name="出入库类型（来自字典表）")]
        public string InOutTypeId {
            get { return _inOutTypeId == null ? string.Empty : _inOutTypeId.Trim(); }
            set{ _inOutTypeId=value;}
        }        
        
        private string _inOutTypeName = string.Empty;
        /// <summary>
        /// 出入库类型（来自字典表）
        /// </summary>
        [Display(Name="出入库类型（来自字典表）")]
        public string InOutTypeName {
            get { return _inOutTypeName == null ? string.Empty : _inOutTypeName.Trim(); }
            set{ _inOutTypeName=value;}
        }        
        
        private string _supplierId = string.Empty;
        /// <summary>
        /// 供应商
        /// </summary>
        [Display(Name="供应商")]
        public string SupplierId {
            get { return _supplierId == null ? string.Empty : _supplierId.Trim(); }
            set{ _supplierId=value;}
        }        
        
        private string _supplier = string.Empty;
        /// <summary>
        /// 供应商
        /// </summary>
        [Display(Name="供应商")]
        public string Supplier {
            get { return _supplier == null ? string.Empty : _supplier.Trim(); }
            set{ _supplier=value;}
        }        
        
        private string _applyId = string.Empty;
        /// <summary>
        /// 申请人
        /// </summary>
        [Display(Name="申请人")]
        public string ApplyId {
            get { return _applyId == null ? string.Empty : _applyId.Trim(); }
            set{ _applyId=value;}
        }        
        
        private string _applyName = string.Empty;
        /// <summary>
        /// 申请人
        /// </summary>
        [Display(Name="申请人")]
        public string ApplyName {
            get { return _applyName == null ? string.Empty : _applyName.Trim(); }
            set{ _applyName=value;}
        }        
        /// <summary>
        /// 起始申请日期
        /// </summary>
        [Display( Name = "起始申请日期" )]
        public DateTime? BeginApplyDate { get; set; }
        /// <summary>
        /// 结束申请日期
        /// </summary>
        [Display( Name = "结束申请日期" )]
        public DateTime? EndApplyDate { get; set; }        
        
        private string _applyRemark = string.Empty;
        /// <summary>
        /// 申请备注
        /// </summary>
        [Display(Name="申请备注")]
        public string ApplyRemark {
            get { return _applyRemark == null ? string.Empty : _applyRemark.Trim(); }
            set{ _applyRemark=value;}
        }        
        
        private string _storeId = string.Empty;
        /// <summary>
        /// 出入库房
        /// </summary>
        [Display(Name="出入库房")]
        public string StoreId {
            get { return _storeId == null ? string.Empty : _storeId.Trim(); }
            set{ _storeId=value;}
        }        
        
        private string _storeName = string.Empty;
        /// <summary>
        /// 出入库房
        /// </summary>
        [Display(Name="出入库房")]
        public string StoreName {
            get { return _storeName == null ? string.Empty : _storeName.Trim(); }
            set{ _storeName=value;}
        }        
        
        private string _auditId = string.Empty;
        /// <summary>
        /// 审核编号
        /// </summary>
        [Display(Name="审核编号")]
        public string AuditId {
            get { return _auditId == null ? string.Empty : _auditId.Trim(); }
            set{ _auditId=value;}
        }        
        
        private string _auditName = string.Empty;
        /// <summary>
        /// 审核人
        /// </summary>
        [Display(Name="审核人")]
        public string AuditName {
            get { return _auditName == null ? string.Empty : _auditName.Trim(); }
            set{ _auditName=value;}
        }        
        /// <summary>
        /// 起始审核时间
        /// </summary>
        [Display( Name = "起始审核时间" )]
        public DateTime? BeginAuditDate { get; set; }
        /// <summary>
        /// 结束审核时间
        /// </summary>
        [Display( Name = "结束审核时间" )]
        public DateTime? EndAuditDate { get; set; }        
        
        private string _auditOpinion = string.Empty;
        /// <summary>
        /// 审核意见
        /// </summary>
        [Display(Name="审核意见")]
        public string AuditOpinion {
            get { return _auditOpinion == null ? string.Empty : _auditOpinion.Trim(); }
            set{ _auditOpinion=value;}
        }        
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreateTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreateTime { get; set; }        
        
        private string _createId = string.Empty;
        /// <summary>
        /// 创建者
        /// </summary>
        [Display(Name="创建者")]
        public string CreateId {
            get { return _createId == null ? string.Empty : _createId.Trim(); }
            set{ _createId=value;}
        }        
        
        private string _createName = string.Empty;
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name="创建人")]
        public string CreateName {
            get { return _createName == null ? string.Empty : _createName.Trim(); }
            set{ _createName=value;}
        }        
        /// <summary>
        /// 起始最近更新时间
        /// </summary>
        [Display( Name = "起始最近更新时间" )]
        public DateTime? BeginLastUpdateTime { get; set; }
        /// <summary>
        /// 结束最近更新时间
        /// </summary>
        [Display( Name = "结束最近更新时间" )]
        public DateTime? EndLastUpdateTime { get; set; }        
        
        private string _lastUpdateId = string.Empty;
        /// <summary>
        /// 最近更新者
        /// </summary>
        [Display(Name="最近更新者")]
        public string LastUpdateId {
            get { return _lastUpdateId == null ? string.Empty : _lastUpdateId.Trim(); }
            set{ _lastUpdateId=value;}
        }        
        
        private string _lastUpdateName = string.Empty;
        /// <summary>
        /// 最近更新人
        /// </summary>
        [Display(Name="最近更新人")]
        public string LastUpdateName {
            get { return _lastUpdateName == null ? string.Empty : _lastUpdateName.Trim(); }
            set{ _lastUpdateName=value;}
        }        
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? Status { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        [Display(Name="是否可用")]
        public sbyte? IsEnable { get; set; }
        
        private string _version = string.Empty;
        /// <summary>
        /// 版本号
        /// </summary>
        [Display(Name="版本号")]
        public string Version {
            get { return _version == null ? string.Empty : _version.Trim(); }
            set{ _version=value;}
        }        
        /// <summary>
        /// 删除标志
        /// </summary>
        [Display(Name="删除标志")]
        public sbyte? IsDeleted { get; set; }
        
    }
}
