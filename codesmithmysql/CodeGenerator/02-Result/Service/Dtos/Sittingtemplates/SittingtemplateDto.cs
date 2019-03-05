using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Sittingtemplates {
    /// <summary>
    ///  坐诊模板数据传输对象
    /// </summary>
    [DataContract]
    public class SittingtemplateDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [Required(ErrorMessage = "门店号不能为空")]
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 医生Id
        /// </summary>
        [Required(ErrorMessage = "医生Id不能为空")]
        [StringLength( 144, ErrorMessage = "医生Id输入过长，不能超过144位" )]
        [Display( Name = "医生Id" )]
        [DataMember]
        public string DoctorId { get; set; }
        
        /// <summary>
        /// 科室Id
        /// </summary>
        [Required(ErrorMessage = "科室Id不能为空")]
        [StringLength( 144, ErrorMessage = "科室Id输入过长，不能超过144位" )]
        [Display( Name = "科室Id" )]
        [DataMember]
        public string DepartmentId { get; set; }
        
        /// <summary>
        /// 坐诊地点Id
        /// </summary>
        [Required(ErrorMessage = "坐诊地点Id不能为空")]
        [StringLength( 144, ErrorMessage = "坐诊地点Id输入过长，不能超过144位" )]
        [Display( Name = "坐诊地点Id" )]
        [DataMember]
        public string SittingAddressId { get; set; }
        
        /// <summary>
        /// 坐诊地点
        /// </summary>
        [Required(ErrorMessage = "坐诊地点不能为空")]
        [StringLength( 400, ErrorMessage = "坐诊地点输入过长，不能超过400位" )]
        [Display( Name = "坐诊地点" )]
        [DataMember]
        public string SittingAddressName { get; set; }
        
        /// <summary>
        /// 上午/下午
        /// </summary>
        [Required(ErrorMessage = "上午/下午不能为空")]
        [Display( Name = "上午/下午" )]
        [DataMember]
        public int DayType { get; set; }
        
        /// <summary>
        /// 限制预约数量
        /// </summary>
        [Required(ErrorMessage = "限制预约数量不能为空")]
        [Display( Name = "限制预约数量" )]
        [DataMember]
        public int AppointmentCount { get; set; }
        
        /// <summary>
        /// 号别
        /// </summary>
        [Required(ErrorMessage = "号别不能为空")]
        [StringLength( 144, ErrorMessage = "号别输入过长，不能超过144位" )]
        [Display( Name = "号别" )]
        [DataMember]
        public string NumberTypeId { get; set; }
        
        /// <summary>
        /// 号别名称
        /// </summary>
        [Required(ErrorMessage = "号别名称不能为空")]
        [StringLength( 400, ErrorMessage = "号别名称输入过长，不能超过400位" )]
        [Display( Name = "号别名称" )]
        [DataMember]
        public string NumberTypeName { get; set; }
        
        /// <summary>
        /// 开始时间
        /// </summary>
        [Required(ErrorMessage = "开始时间不能为空")]
        [Display( Name = "开始时间" )]
        [DataMember]
        public TimeSpan StartTime { get; set; }
        
        /// <summary>
        /// 结束时间
        /// </summary>
        [Required(ErrorMessage = "结束时间不能为空")]
        [Display( Name = "结束时间" )]
        [DataMember]
        public TimeSpan EndTime { get; set; }
        
        /// <summary>
        /// 放号数量
        /// </summary>
        [Required(ErrorMessage = "放号数量不能为空")]
        [Display( Name = "放号数量" )]
        [DataMember]
        public int Count { get; set; }
        
        /// <summary>
        /// 星期几
        /// </summary>
        [Required(ErrorMessage = "星期几不能为空")]
        [Display( Name = "星期几" )]
        [DataMember]
        public int Weekday { get; set; }
        
    }
}
