using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Patientvisits;


namespace Sand.Domain.Queries.Patientvisits {
    /// <summary>
    /// 预约挂号查询实体
    /// </summary>
    public class AppointmentregisterQuery :  BaseQuery<Appointmentregister> {
        
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
        
        private string _doctorSittingId = string.Empty;
        /// <summary>
        /// 坐诊Id
        /// </summary>
        [Display(Name="坐诊Id")]
        public string DoctorSittingId {
            get { return _doctorSittingId == null ? string.Empty : _doctorSittingId.Trim(); }
            set{ _doctorSittingId=value;}
        }        
        
        private string _doctorId = string.Empty;
        /// <summary>
        /// 医生Id
        /// </summary>
        [Display(Name="医生Id")]
        public string DoctorId {
            get { return _doctorId == null ? string.Empty : _doctorId.Trim(); }
            set{ _doctorId=value;}
        }        
        
        private string _doctorName = string.Empty;
        /// <summary>
        /// 医生姓名
        /// </summary>
        [Display(Name="医生姓名")]
        public string DoctorName {
            get { return _doctorName == null ? string.Empty : _doctorName.Trim(); }
            set{ _doctorName=value;}
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
        
        private string _departmentName = string.Empty;
        /// <summary>
        /// 科室名称
        /// </summary>
        [Display(Name="科室名称")]
        public string DepartmentName {
            get { return _departmentName == null ? string.Empty : _departmentName.Trim(); }
            set{ _departmentName=value;}
        }        
        
        private string _sittingAddress = string.Empty;
        /// <summary>
        /// 坐诊地点
        /// </summary>
        [Display(Name="坐诊地点")]
        public string SittingAddress {
            get { return _sittingAddress == null ? string.Empty : _sittingAddress.Trim(); }
            set{ _sittingAddress=value;}
        }        
        /// <summary>
        /// 支付状态
        /// </summary>
        [Display(Name="支付状态")]
        public int? PaymentStatus { get; set; }
        /// <summary>
        /// 状态(-1已退号,0.未就诊，1.已就诊，2.就诊完成)
        /// </summary>
        [Display(Name="状态(-1已退号,0.未就诊，1.已就诊，2.就诊完成)")]
        public int? Status { get; set; }
        
        private string _registerId = string.Empty;
        /// <summary>
        /// 挂号Id
        /// </summary>
        [Display(Name="挂号Id")]
        public string RegisterId {
            get { return _registerId == null ? string.Empty : _registerId.Trim(); }
            set{ _registerId=value;}
        }        
        
        private string _patientId = string.Empty;
        /// <summary>
        /// 病人Id
        /// </summary>
        [Display(Name="病人Id")]
        public string PatientId {
            get { return _patientId == null ? string.Empty : _patientId.Trim(); }
            set{ _patientId=value;}
        }        
        /// <summary>
        /// 是否超时
        /// </summary>
        [Display(Name="是否超时")]
        public sbyte? IsTimeout { get; set; }
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
        ///  创建者
        /// </summary>
        [Display(Name=" 创建者")]
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
        /// 最近更新人
        /// </summary>
        [Display(Name="最近更新人")]
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
