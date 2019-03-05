using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Patientvisits;


namespace Sand.Domain.Queries.Patientvisits {
    /// <summary>
    /// 四诊信息查询实体
    /// </summary>
    public class DiseaseQuery :  BaseQuery<Disease> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 四诊信息编号
        /// </summary>
        [Display(Name="四诊信息编号")]
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
        
        private string _visitId = string.Empty;
        /// <summary>
        /// 就诊编号
        /// </summary>
        [Display(Name="就诊编号")]
        public string VisitId {
            get { return _visitId == null ? string.Empty : _visitId.Trim(); }
            set{ _visitId=value;}
        }        
        
        private string _diseaseId = string.Empty;
        /// <summary>
        /// 四诊数据编号
        /// </summary>
        [Display(Name="四诊数据编号")]
        public string DiseaseId {
            get { return _diseaseId == null ? string.Empty : _diseaseId.Trim(); }
            set{ _diseaseId=value;}
        }        
        
        private string _diseaseName = string.Empty;
        /// <summary>
        /// 四诊信息说明
        /// </summary>
        [Display(Name="四诊信息说明")]
        public string DiseaseName {
            get { return _diseaseName == null ? string.Empty : _diseaseName.Trim(); }
            set{ _diseaseName=value;}
        }        
        /// <summary>
        /// 轻重程度(-1代表无此症状,0轻微症状,1严重症状,2非常严重)
        /// </summary>
        [Display(Name="轻重程度(-1代表无此症状,0轻微症状,1严重症状,2非常严重)")]
        public int? Degree { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name="排序")]
        public int? Sort { get; set; }
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
        
    }
}
