using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Consults {
    /// <summary>
    /// 选项表
    /// </summary>
    [Description( "选项表" )]
    public partial class Options : Entity,ISoftDelete {
        /// <summary>
        /// 初始化选项表
        /// </summary>
        public Options(){
        }
        /// <summary>
        /// 选项值
        /// </summary>
        public int? Value { get; set; }
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 144, ErrorMessage = "父级输入过长，不能超过144位" )]
        public string QuestionnaireId { get; set; }
        /// <summary>
        /// 问卷名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "问卷名称输入过长，不能超过400位" )]
        public string Name { get; set; }
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