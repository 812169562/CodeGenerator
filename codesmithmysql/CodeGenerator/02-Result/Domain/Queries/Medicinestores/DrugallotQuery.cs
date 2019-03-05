using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Medicinestores;


namespace Sand.Domain.Queries.Medicinestores {
    /// <summary>
    /// 药品调拨查询实体
    /// </summary>
    public class DrugallotQuery :  BaseQuery<Drugallot> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 调拨编号
        /// </summary>
        [Display(Name="调拨编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        /// <summary>
        /// 调拨类型
        /// </summary>
        [Display(Name="调拨类型")]
        public int? Type { get; set; }
        
        private string _code = string.Empty;
        /// <summary>
        /// 调拨单号
        /// </summary>
        [Display(Name="调拨单号")]
        public string Code {
            get { return _code == null ? string.Empty : _code.Trim(); }
            set{ _code=value;}
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
        /// 备注
        /// </summary>
        [Display(Name="备注")]
        public string ApplyRemark {
            get { return _applyRemark == null ? string.Empty : _applyRemark.Trim(); }
            set{ _applyRemark=value;}
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
        
        private string _inId = string.Empty;
        /// <summary>
        /// 入库编号
        /// </summary>
        [Display(Name="入库编号")]
        public string InId {
            get { return _inId == null ? string.Empty : _inId.Trim(); }
            set{ _inId=value;}
        }        
        
        private string _inStroeId = string.Empty;
        /// <summary>
        /// 调拨入库库房编号
        /// </summary>
        [Display(Name="调拨入库库房编号")]
        public string InStroeId {
            get { return _inStroeId == null ? string.Empty : _inStroeId.Trim(); }
            set{ _inStroeId=value;}
        }        
        
        private string _inStroeName = string.Empty;
        /// <summary>
        /// 调拨入库库房
        /// </summary>
        [Display(Name="调拨入库库房")]
        public string InStroeName {
            get { return _inStroeName == null ? string.Empty : _inStroeName.Trim(); }
            set{ _inStroeName=value;}
        }        
        
        private string _inCode = string.Empty;
        /// <summary>
        /// 入库单据号
        /// </summary>
        [Display(Name="入库单据号")]
        public string InCode {
            get { return _inCode == null ? string.Empty : _inCode.Trim(); }
            set{ _inCode=value;}
        }        
        
        private string _outId = string.Empty;
        /// <summary>
        /// 出库编号
        /// </summary>
        [Display(Name="出库编号")]
        public string OutId {
            get { return _outId == null ? string.Empty : _outId.Trim(); }
            set{ _outId=value;}
        }        
        
        private string _outStroeId = string.Empty;
        /// <summary>
        /// 调拨出库库房编号
        /// </summary>
        [Display(Name="调拨出库库房编号")]
        public string OutStroeId {
            get { return _outStroeId == null ? string.Empty : _outStroeId.Trim(); }
            set{ _outStroeId=value;}
        }        
        
        private string _outStroeName = string.Empty;
        /// <summary>
        /// 调拨出库库房
        /// </summary>
        [Display(Name="调拨出库库房")]
        public string OutStroeName {
            get { return _outStroeName == null ? string.Empty : _outStroeName.Trim(); }
            set{ _outStroeName=value;}
        }        
        
        private string _outCode = string.Empty;
        /// <summary>
        /// 出库库单据号
        /// </summary>
        [Display(Name="出库库单据号")]
        public string OutCode {
            get { return _outCode == null ? string.Empty : _outCode.Trim(); }
            set{ _outCode=value;}
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
