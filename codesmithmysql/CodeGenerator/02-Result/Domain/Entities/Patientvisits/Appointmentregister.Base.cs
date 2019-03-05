using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Patientvisits {
    /// <summary>
    /// 预约挂号
    /// </summary>
    [Description( "预约挂号" )]
    public partial class Appointmentregister : Entity,ISoftDelete {
        /// <summary>
        /// 初始化预约挂号
        /// </summary>
        public Appointmentregister(){
        }
        /// <summary>
        /// 坐诊Id
        /// </summary>
        [Required(ErrorMessage = "坐诊Id不能为空")]
        [StringLength( 144, ErrorMessage = "坐诊Id输入过长，不能超过144位" )]
        public string DoctorSittingId { get; set; }
        /// <summary>
        /// 医生Id
        /// </summary>
        [Required(ErrorMessage = "医生Id不能为空")]
        [StringLength( 144, ErrorMessage = "医生Id输入过长，不能超过144位" )]
        public string DoctorId { get; set; }
        /// <summary>
        /// 医生姓名
        /// </summary>
        [Required(ErrorMessage = "医生姓名不能为空")]
        [StringLength( 400, ErrorMessage = "医生姓名输入过长，不能超过400位" )]
        public string DoctorName { get; set; }
        /// <summary>
        /// 科室Id
        /// </summary>
        [Required(ErrorMessage = "科室Id不能为空")]
        [StringLength( 144, ErrorMessage = "科室Id输入过长，不能超过144位" )]
        public string DepartmentId { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        [Required(ErrorMessage = "科室名称不能为空")]
        [StringLength( 400, ErrorMessage = "科室名称输入过长，不能超过400位" )]
        public string DepartmentName { get; set; }
        /// <summary>
        /// 坐诊地点
        /// </summary>
        [Required(ErrorMessage = "坐诊地点不能为空")]
        [StringLength( 400, ErrorMessage = "坐诊地点输入过长，不能超过400位" )]
        public string SittingAddress { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        [Required(ErrorMessage = "支付状态不能为空")]
        public int PaymentStatus { get; set; }
        /// <summary>
        /// 挂号Id
        /// </summary>
        [Required(ErrorMessage = "挂号Id不能为空")]
        [StringLength( 144, ErrorMessage = "挂号Id输入过长，不能超过144位" )]
        public string RegisterId { get; set; }
        /// <summary>
        /// 病人Id
        /// </summary>
        [Required(ErrorMessage = "病人Id不能为空")]
        [StringLength( 144, ErrorMessage = "病人Id输入过长，不能超过144位" )]
        public string PatientId { get; set; }
        /// <summary>
        /// 是否超时
        /// </summary>
        [Required(ErrorMessage = "是否超时不能为空")]
        public sbyte IsTimeout { get; set; }
         /// <summary>
        /// 删除标志
        /// </summary>
        [Required(ErrorMessage = "删除标志不能为空")]
        public bool IsDeleted { get; set; }
        
        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init()
        {
            this.Id = Uuid.Next();
            base.Init();
        }
 
        /// <summary>
        /// 加载
        /// </summary>
        public override void Load(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}