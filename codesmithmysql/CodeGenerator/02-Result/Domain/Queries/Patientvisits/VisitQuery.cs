using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Patientvisits;


namespace Sand.Domain.Queries.Patientvisits {
    /// <summary>
    /// 就诊信息查询实体
    /// </summary>
    public class VisitQuery :  BaseQuery<Visit> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 就诊编号
        /// </summary>
        [Display(Name="就诊编号")]
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
        
        private string _registerId = string.Empty;
        /// <summary>
        /// 挂号编号
        /// </summary>
        [Display(Name="挂号编号")]
        public string RegisterId {
            get { return _registerId == null ? string.Empty : _registerId.Trim(); }
            set{ _registerId=value;}
        }        
        /// <summary>
        /// 起始发病日期
        /// </summary>
        [Display( Name = "起始发病日期" )]
        public DateTime? BeginDiseaseDate { get; set; }
        /// <summary>
        /// 结束发病日期
        /// </summary>
        [Display( Name = "结束发病日期" )]
        public DateTime? EndDiseaseDate { get; set; }        
        
        private string _diastolicPressure = string.Empty;
        /// <summary>
        /// 舒张压
        /// </summary>
        [Display(Name="舒张压")]
        public string DiastolicPressure {
            get { return _diastolicPressure == null ? string.Empty : _diastolicPressure.Trim(); }
            set{ _diastolicPressure=value;}
        }        
        
        private string _systolicPressure = string.Empty;
        /// <summary>
        /// 收缩压
        /// </summary>
        [Display(Name="收缩压")]
        public string SystolicPressure {
            get { return _systolicPressure == null ? string.Empty : _systolicPressure.Trim(); }
            set{ _systolicPressure=value;}
        }        
        
        private string _chiefComplaint = string.Empty;
        /// <summary>
        /// 主诉
        /// </summary>
        [Display(Name="主诉")]
        public string ChiefComplaint {
            get { return _chiefComplaint == null ? string.Empty : _chiefComplaint.Trim(); }
            set{ _chiefComplaint=value;}
        }        
        
        private string _presentIllness = string.Empty;
        /// <summary>
        /// 现病史
        /// </summary>
        [Display(Name="现病史")]
        public string PresentIllness {
            get { return _presentIllness == null ? string.Empty : _presentIllness.Trim(); }
            set{ _presentIllness=value;}
        }        
        
        private string _pastIllness = string.Empty;
        /// <summary>
        /// 既往史
        /// </summary>
        [Display(Name="既往史")]
        public string PastIllness {
            get { return _pastIllness == null ? string.Empty : _pastIllness.Trim(); }
            set{ _pastIllness=value;}
        }        
        
        private string _selefHistory = string.Empty;
        /// <summary>
        /// 个人史
        /// </summary>
        [Display(Name="个人史")]
        public string SelefHistory {
            get { return _selefHistory == null ? string.Empty : _selefHistory.Trim(); }
            set{ _selefHistory=value;}
        }        
        
        private string _familyHistory = string.Empty;
        /// <summary>
        /// 家族史
        /// </summary>
        [Display(Name="家族史")]
        public string FamilyHistory {
            get { return _familyHistory == null ? string.Empty : _familyHistory.Trim(); }
            set{ _familyHistory=value;}
        }        
        
        private string _menstrualHistory = string.Empty;
        /// <summary>
        /// 月经史
        /// </summary>
        [Display(Name="月经史")]
        public string MenstrualHistory {
            get { return _menstrualHistory == null ? string.Empty : _menstrualHistory.Trim(); }
            set{ _menstrualHistory=value;}
        }        
        
        private string _supplementaryExamination = string.Empty;
        /// <summary>
        /// 辅助检查
        /// </summary>
        [Display(Name="辅助检查")]
        public string SupplementaryExamination {
            get { return _supplementaryExamination == null ? string.Empty : _supplementaryExamination.Trim(); }
            set{ _supplementaryExamination=value;}
        }        
        
        private string _physicalexamination = string.Empty;
        /// <summary>
        /// 体格检查
        /// </summary>
        [Display(Name="体格检查")]
        public string Physicalexamination {
            get { return _physicalexamination == null ? string.Empty : _physicalexamination.Trim(); }
            set{ _physicalexamination=value;}
        }        
        
        private string _treatmentOpinion = string.Empty;
        /// <summary>
        /// 治疗意见
        /// </summary>
        [Display(Name="治疗意见")]
        public string TreatmentOpinion {
            get { return _treatmentOpinion == null ? string.Empty : _treatmentOpinion.Trim(); }
            set{ _treatmentOpinion=value;}
        }        
        
        private string _imgPath = string.Empty;
        /// <summary>
        /// 图片
        /// </summary>
        [Display(Name="图片")]
        public string ImgPath {
            get { return _imgPath == null ? string.Empty : _imgPath.Trim(); }
            set{ _imgPath=value;}
        }        
        
        private string _remark = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name="备注")]
        public string Remark {
            get { return _remark == null ? string.Empty : _remark.Trim(); }
            set{ _remark=value;}
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
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? Status { get; set; }
        
    }
}
