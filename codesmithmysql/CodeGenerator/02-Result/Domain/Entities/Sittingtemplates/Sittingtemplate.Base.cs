using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Sittingtemplates {
    /// <summary>
    ///  坐诊模板
    /// </summary>
    [Description( " 坐诊模板" )]
    public partial class Sittingtemplate : Entity,ISoftDelete {
        /// <summary>
        /// 初始化 坐诊模板
        /// </summary>
        public Sittingtemplate(){
        }
        /// <summary>
        /// 医生Id
        /// </summary>
        [Required(ErrorMessage = "医生Id不能为空")]
        [StringLength( 144, ErrorMessage = "医生Id输入过长，不能超过144位" )]
        public string DoctorId { get; set; }
        /// <summary>
        /// 科室Id
        /// </summary>
        [Required(ErrorMessage = "科室Id不能为空")]
        [StringLength( 144, ErrorMessage = "科室Id输入过长，不能超过144位" )]
        public string DepartmentId { get; set; }
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
        /// 限制预约数量
        /// </summary>
        [Required(ErrorMessage = "限制预约数量不能为空")]
        public int AppointmentCount { get; set; }
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
        /// 放号数量
        /// </summary>
        [Required(ErrorMessage = "放号数量不能为空")]
        public int Count { get; set; }
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