using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Consults {
    /// <summary>
    /// 问卷表
    /// </summary>
    [Description( "问卷表" )]
    public partial class Questionnaire : Entity,ISoftDelete {
        /// <summary>
        /// 初始化问卷表
        /// </summary>
        public Questionnaire(){
        }
        /// <summary>
        ///  标题
        /// </summary>
        [StringLength( 400, ErrorMessage = " 标题输入过长，不能超过400位" )]
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [StringLength( 65535, ErrorMessage = "内容输入过长，不能超过65535位" )]
        public string Context { get; set; }
        /// <summary>
        /// 回答类，问卷类）
        /// </summary>
        public int? Type { get; set; }
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