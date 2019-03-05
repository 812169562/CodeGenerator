using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Patientvisits;


namespace Sand.Domain.Queries.Patientvisits {
    /// <summary>
    /// 诊断信息查询实体
    /// </summary>
    public class DiagnosisQuery :  BaseQuery<Diagnosis> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 诊断编号
        /// </summary>
        [Display(Name="诊断编号")]
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
        
        private string _patId = string.Empty;
        /// <summary>
        /// 患者编号
        /// </summary>
        [Display(Name="患者编号")]
        public string PatId {
            get { return _patId == null ? string.Empty : _patId.Trim(); }
            set{ _patId=value;}
        }        
        
        private string _visitId = string.Empty;
        /// <summary>
        /// 就诊编号
        /// </summary>
        [Display(Name="就诊编号")]
        public string VisitId {
            get { return _visitId == null ? string.Empty : _visitId.Trim(); }
            set{ _visitId=value;}
        }        
        /// <summary>
        /// 诊断类型(1.中医,2.西医)
        /// </summary>
        [Display(Name="诊断类型(1.中医,2.西医)")]
        public int? Type { get; set; }
        
        private string _diagnosisId = string.Empty;
        /// <summary>
        /// 诊断编号
        /// </summary>
        [Display(Name="诊断编号")]
        public string DiagnosisId {
            get { return _diagnosisId == null ? string.Empty : _diagnosisId.Trim(); }
            set{ _diagnosisId=value;}
        }        
        
        private string _diagnosisName = string.Empty;
        /// <summary>
        /// 诊断名
        /// </summary>
        [Display(Name="诊断名")]
        public string DiagnosisName {
            get { return _diagnosisName == null ? string.Empty : _diagnosisName.Trim(); }
            set{ _diagnosisName=value;}
        }        
        
        private string _attachDiagnosisId = string.Empty;
        /// <summary>
        /// 附加诊断编号
        /// </summary>
        [Display(Name="附加诊断编号")]
        public string AttachDiagnosisId {
            get { return _attachDiagnosisId == null ? string.Empty : _attachDiagnosisId.Trim(); }
            set{ _attachDiagnosisId=value;}
        }        
        
        private string _attachDiagnosisName = string.Empty;
        /// <summary>
        /// 附加诊断名称(部分诊断Icd只能作为附加诊断)
        /// </summary>
        [Display(Name="附加诊断名称(部分诊断Icd只能作为附加诊断)")]
        public string AttachDiagnosisName {
            get { return _attachDiagnosisName == null ? string.Empty : _attachDiagnosisName.Trim(); }
            set{ _attachDiagnosisName=value;}
        }        
        
        private string _syndromeId = string.Empty;
        /// <summary>
        /// 证型编号
        /// </summary>
        [Display(Name="证型编号")]
        public string SyndromeId {
            get { return _syndromeId == null ? string.Empty : _syndromeId.Trim(); }
            set{ _syndromeId=value;}
        }        
        
        private string _syndromeName = string.Empty;
        /// <summary>
        /// 证型
        /// </summary>
        [Display(Name="证型")]
        public string SyndromeName {
            get { return _syndromeName == null ? string.Empty : _syndromeName.Trim(); }
            set{ _syndromeName=value;}
        }        
        
        private string _syndromeId2 = string.Empty;
        /// <summary>
        /// 证型编号
        /// </summary>
        [Display(Name="证型编号")]
        public string SyndromeId2 {
            get { return _syndromeId2 == null ? string.Empty : _syndromeId2.Trim(); }
            set{ _syndromeId2=value;}
        }        
        
        private string _syndromeName2 = string.Empty;
        /// <summary>
        /// 证型
        /// </summary>
        [Display(Name="证型")]
        public string SyndromeName2 {
            get { return _syndromeName2 == null ? string.Empty : _syndromeName2.Trim(); }
            set{ _syndromeName2=value;}
        }        
        
        private string _syndromeId3 = string.Empty;
        /// <summary>
        /// 证型编号
        /// </summary>
        [Display(Name="证型编号")]
        public string SyndromeId3 {
            get { return _syndromeId3 == null ? string.Empty : _syndromeId3.Trim(); }
            set{ _syndromeId3=value;}
        }        
        
        private string _syndromeName3 = string.Empty;
        /// <summary>
        /// 证型
        /// </summary>
        [Display(Name="证型")]
        public string SyndromeName3 {
            get { return _syndromeName3 == null ? string.Empty : _syndromeName3.Trim(); }
            set{ _syndromeName3=value;}
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
