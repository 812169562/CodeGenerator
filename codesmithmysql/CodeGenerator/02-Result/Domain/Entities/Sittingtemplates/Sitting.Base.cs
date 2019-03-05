using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Sittingtemplates {
    /// <summary>
    ///  医生坐诊表
    /// </summary>
    [Description( " 医生坐诊表" )]
    public partial class Sitting : Entity,ISoftDelete {
        /// <summary>
        /// 初始化 医生坐诊表
        /// </summary>
        public Sitting(){
        }
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
        /// 坐诊地点Id
        /// </summary>
        [Required(ErrorMessage = "坐诊地点Id不能为空")]
        [StringLength( 144, ErrorMessage = "坐诊地点Id输入过长，不能超过144位" )]
        public string SittingAddressId { get; set; }
        /// <summary>
        /// 坐诊地点
        /// </summary>
        [Required(ErrorMessage = "坐诊地点不能为空")]
        [StringLength( 400, ErrorMessage = "坐诊地点输入过长，不能超过400位" )]
        public string SittingAddressName { get; set; }
        /// <summary>
        /// 上午/下午
        /// </summary>
        [Required(ErrorMessage = "上午/下午不能为空")]
        public int DayType { get; set; }
        /// <summary>
        /// 放号数量
        /// </summary>
        [Required(ErrorMessage = "放号数量不能为空")]
        public int Count { get; set; }
        /// <summary>
        /// 使用号数
        /// </summary>
        [Required(ErrorMessage = "使用号数不能为空")]
        public int UseCount { get; set; }
        /// <summary>
        /// 限制预约数量
        /// </summary>
        [Required(ErrorMessage = "限制预约数量不能为空")]
        public int AppointmentCount { get; set; }
        /// <summary>
        /// 已预约数量
        /// </summary>
        public int? UseAppointmentCount { get; set; }
        /// <summary>
        /// 号别
        /// </summary>
        [Required(ErrorMessage = "号别不能为空")]
        [StringLength( 144, ErrorMessage = "号别输入过长，不能超过144位" )]
        public string NumberTypeId { get; set; }
        /// <summary>
        /// 号别名称
        /// </summary>
        [Required(ErrorMessage = "号别名称不能为空")]
        [StringLength( 400, ErrorMessage = "号别名称输入过长，不能超过400位" )]
        public string NumberTypeName { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [Required(ErrorMessage = "开始时间不能为空")]
        public TimeSpan StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [Required(ErrorMessage = "结束时间不能为空")]
        public TimeSpan EndTime { get; set; }
        /// <summary>
        /// 坐诊日期
        /// </summary>
        [Required(ErrorMessage = "坐诊日期不能为空")]
        public DateTime SittingDate { get; set; }
        /// <summary>
        /// 星期几
        /// </summary>
        [Required(ErrorMessage = "星期几不能为空")]
        public int Weekday { get; set; }
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