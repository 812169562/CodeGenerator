using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Consults {
    /// <summary>
    /// 咨询
    /// </summary>
    [Description( "咨询" )]
    public partial class Consult : Entity,ISoftDelete {
        /// <summary>
        /// 初始化咨询
        /// </summary>
        public Consult(){
        }
        /// <summary>
        /// 咨询内容
        /// </summary>
        [StringLength( 300, ErrorMessage = "咨询内容输入过长，不能超过300位" )]
        public string Content { get; set; }
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 108, ErrorMessage = "父级输入过长，不能超过108位" )]
        public string Initial { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public int? Result { get; set; }
        /// <summary>
        /// 评价
        /// </summary>
        [StringLength( 300, ErrorMessage = "评价输入过长，不能超过300位" )]
        public string Evaluate { get; set; }
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