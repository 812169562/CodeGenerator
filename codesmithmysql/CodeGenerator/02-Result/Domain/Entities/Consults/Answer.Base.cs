using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Consults {
    /// <summary>
    /// 答案表
    /// </summary>
    [Description( "答案表" )]
    public partial class Answer : Entity,ISoftDelete {
        /// <summary>
        /// 初始化答案表
        /// </summary>
        public Answer(){
        }
        /// <summary>
        /// 选项值
        /// </summary>
        [StringLength( 108, ErrorMessage = "选项值输入过长，不能超过108位" )]
        public string OptionsId { get; set; }
        /// <summary>
        /// 答案内容
        /// </summary>
        [StringLength( 300, ErrorMessage = "答案内容输入过长，不能超过300位" )]
        public string Content { get; set; }
        /// <summary>
        /// 类型 （回答类，问卷类）
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 选项值
        /// </summary>
        public int? Value { get; set; }
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 300, ErrorMessage = "父级输入过长，不能超过300位" )]
        public string Suggestion { get; set; }
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 108, ErrorMessage = "父级输入过长，不能超过108位" )]
        public string QuestionnaireId { get; set; }
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