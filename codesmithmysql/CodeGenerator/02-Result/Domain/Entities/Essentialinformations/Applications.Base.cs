using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Essentialinformations {
    /// <summary>
    /// 应用程序
    /// </summary>
    [Description( "应用程序" )]
    public partial class Applications : Entity,ISoftDelete {
        /// <summary>
        /// 初始化应用程序
        /// </summary>
        public Applications(){
        }
        /// <summary>
        /// 应用程序名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "应用程序名称输入过长，不能超过400位" )]
        public string Name { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 144, ErrorMessage = "代码输入过长，不能超过144位" )]
        public string Code { get; set; }
        /// <summary>
        /// 主机
        /// </summary>
        [StringLength( 800, ErrorMessage = "主机输入过长，不能超过800位" )]
        public string LocalHost { get; set; }
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