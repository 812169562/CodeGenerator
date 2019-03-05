using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Essentialinformations {
    /// <summary>
    /// 人员部门信息
    /// </summary>
    [Description( "人员部门信息" )]
    public partial class Userdepartment : Entity,ISoftDelete {
        /// <summary>
        /// 初始化人员部门信息
        /// </summary>
        public Userdepartment(){
        }
        /// <summary>
        /// 用户编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "用户编号输入过长，不能超过144位" )]
        public string UserId { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "部门编号输入过长，不能超过144位" )]
        public string DepartmentId { get; set; }
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