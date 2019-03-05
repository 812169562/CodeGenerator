using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Sittingtemplates;


namespace Sand.Domain.Queries.Sittingtemplates {
    /// <summary>
    ///  坐诊模板查询实体
    /// </summary>
    public class SittingtemplateQuery :  BaseQuery<Sittingtemplate> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 编号
        /// </summary>
        [Display(Name="编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _tenantId = string.Empty;
        /// <summary>
        /// 医馆Id
        /// </summary>
        [Display(Name="医馆Id")]
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
        /// 创建者
        /// </summary>
        [Display(Name="创建者")]
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
        /// 最近更新人Id
        /// </summary>
        [Display(Name="最近更新人Id")]
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
        
        private string _doctorId = string.Empty;
        /// <summary>
        /// 医生Id
        /// </summary>
        [Display(Name="医生Id")]
        public string DoctorId {
            get { return _doctorId == null ? string.Empty : _doctorId.Trim(); }
            set{ _doctorId=value;}
        }        
        
        private string _departmentId = string.Empty;
        /// <summary>
        /// 科室Id
        /// </summary>
        [Display(Name="科室Id")]
        public string DepartmentId {
            get { return _departmentId == null ? string.Empty : _departmentId.Trim(); }
            set{ _departmentId=value;}
        }        
        
        private string _sittingAddressId = string.Empty;
        /// <summary>
        /// 坐诊地点Id
        /// </summary>
        [Display(Name="坐诊地点Id")]
        public string SittingAddressId {
            get { return _sittingAddressId == null ? string.Empty : _sittingAddressId.Trim(); }
            set{ _sittingAddressId=value;}
        }        
        
        private string _sittingAddressName = string.Empty;
        /// <summary>
        /// 坐诊地点
        /// </summary>
        [Display(Name="坐诊地点")]
        public string SittingAddressName {
            get { return _sittingAddressName == null ? string.Empty : _sittingAddressName.Trim(); }
            set{ _sittingAddressName=value;}
        }        
        /// <summary>
        /// 上午/下午
        /// </summary>
        [Display(Name="上午/下午")]
        public int? DayType { get; set; }
        /// <summary>
        /// 限制预约数量
        /// </summary>
        [Display(Name="限制预约数量")]
        public int? AppointmentCount { get; set; }
        
        private string _numberTypeId = string.Empty;
        /// <summary>
        /// 号别
        /// </summary>
        [Display(Name="号别")]
        public string NumberTypeId {
            get { return _numberTypeId == null ? string.Empty : _numberTypeId.Trim(); }
            set{ _numberTypeId=value;}
        }        
        
        private string _numberTypeName = string.Empty;
        /// <summary>
        /// 号别名称
        /// </summary>
        [Display(Name="号别名称")]
        public string NumberTypeName {
            get { return _numberTypeName == null ? string.Empty : _numberTypeName.Trim(); }
            set{ _numberTypeName=value;}
        }        
        /// <summary>
        /// 开始时间
        /// </summary>
        [Display(Name="开始时间")]
        public TimeSpan? StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [Display(Name="结束时间")]
        public TimeSpan? EndTime { get; set; }
        /// <summary>
        /// 放号数量
        /// </summary>
        [Display(Name="放号数量")]
        public int? Count { get; set; }
        /// <summary>
        /// 星期几
        /// </summary>
        [Display(Name="星期几")]
        public int? Weekday { get; set; }
        
    }
}
