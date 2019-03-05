using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Essentialinformations {
    /// <summary>
    /// 租户用户多对多关系表
    /// </summary>
    [Description( "租户用户多对多关系表" )]
    public partial class Tenantuserrelation : Entityint,ISoftDelete {
        /// <summary>
        /// 初始化租户用户多对多关系表
        /// </summary>
        public Tenantuserrelation(){
        }
        /// <summary>
        /// 用户编号
        /// </summary>
        [Required(ErrorMessage = "用户编号不能为空")]
        [StringLength( 144, ErrorMessage = "用户编号输入过长，不能超过144位" )]
        public string UserId { get; set; }
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