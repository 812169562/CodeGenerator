using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Patientvisits {
    /// <summary>
    /// 预约挂号数据传输对象
    /// </summary>
    [DataContract]
    public class AppointmentregisterDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [Required(ErrorMessage = "门店号不能为空")]
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 坐诊Id
        /// </summary>
        [Required(ErrorMessage = "坐诊Id不能为空")]
        [StringLength( 144, ErrorMessage = "坐诊Id输入过长，不能超过144位" )]
        [Display( Name = "坐诊Id" )]
        [DataMember]
        public string DoctorSittingId { get; set; }
        
        /// <summary>
        /// 医生Id
        /// </summary>
        [Required(ErrorMessage = "医生Id不能为空")]
        [StringLength( 144, ErrorMessage = "医生Id输入过长，不能超过144位" )]
        [Display( Name = "医生Id" )]
        [DataMember]
        public string DoctorId { get; set; }
        
        /// <summary>
        /// 医生姓名
        /// </summary>
        [Required(ErrorMessage = "医生姓名不能为空")]
        [StringLength( 400, ErrorMessage = "医生姓名输入过长，不能超过400位" )]
        [Display( Name = "医生姓名" )]
        [DataMember]
        public string DoctorName { get; set; }
        
        /// <summary>
        /// 科室Id
        /// </summary>
        [Required(ErrorMessage = "科室Id不能为空")]
        [StringLength( 144, ErrorMessage = "科室Id输入过长，不能超过144位" )]
        [Display( Name = "科室Id" )]
        [DataMember]
        public string DepartmentId { get; set; }
        
        /// <summary>
        /// 科室名称
        /// </summary>
        [Required(ErrorMessage = "科室名称不能为空")]
        [StringLength( 400, ErrorMessage = "科室名称输入过长，不能超过400位" )]
        [Display( Name = "科室名称" )]
        [DataMember]
        public string DepartmentName { get; set; }
        
        /// <summary>
        /// 坐诊地点
        /// </summary>
        [Required(ErrorMessage = "坐诊地点不能为空")]
        [StringLength( 400, ErrorMessage = "坐诊地点输入过长，不能超过400位" )]
        [Display( Name = "坐诊地点" )]
        [DataMember]
        public string SittingAddress { get; set; }
        
        /// <summary>
        /// 支付状态
        /// </summary>
        [Required(ErrorMessage = "支付状态不能为空")]
        [Display( Name = "支付状态" )]
        [DataMember]
        public int PaymentStatus { get; set; }
        
        /// <summary>
        /// 挂号Id
        /// </summary>
        [Required(ErrorMessage = "挂号Id不能为空")]
        [StringLength( 144, ErrorMessage = "挂号Id输入过长，不能超过144位" )]
        [Display( Name = "挂号Id" )]
        [DataMember]
        public string RegisterId { get; set; }
        
        /// <summary>
        /// 病人Id
        /// </summary>
        [Required(ErrorMessage = "病人Id不能为空")]
        [StringLength( 144, ErrorMessage = "病人Id输入过长，不能超过144位" )]
        [Display( Name = "病人Id" )]
        [DataMember]
        public string PatientId { get; set; }
        
        /// <summary>
        /// 是否超时
        /// </summary>
        [Required(ErrorMessage = "是否超时不能为空")]
        [Display( Name = "是否超时" )]
        [DataMember]
        public sbyte IsTimeout { get; set; }
        
    }
}
