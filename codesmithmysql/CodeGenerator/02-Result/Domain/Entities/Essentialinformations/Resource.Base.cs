using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Essentialinformations {
    /// <summary>
    /// 资源
    /// </summary>
    [Description( "资源" )]
    public partial class Resource : Entity,ISoftDelete {
        /// <summary>
        /// 初始化资源
        /// </summary>
        public Resource(){
        }
        /// <summary>
        /// 资源名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "资源名称输入过长，不能超过400位" )]
        public string Name { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 144, ErrorMessage = "代码输入过长，不能超过144位" )]
        public string Code { get; set; }
        /// <summary>
        /// 关系
        /// </summary>
        [StringLength( 1480, ErrorMessage = "关系输入过长，不能超过1480位" )]
        public string RelationShip { get; set; }
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 144, ErrorMessage = "父级输入过长，不能超过144位" )]
        public string Parent { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Required(ErrorMessage = "排序不能为空")]
        public int Sort { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [StringLength( 400, ErrorMessage = "地址输入过长，不能超过400位" )]
        public string Url { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        [StringLength( 400, ErrorMessage = "路径输入过长，不能超过400位" )]
        public string Path { get; set; }
        /// <summary>
        /// 参数
        /// </summary>
        [StringLength( 400, ErrorMessage = "参数输入过长，不能超过400位" )]
        public string Para { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [StringLength( 144, ErrorMessage = "输入过长，不能超过144位" )]
        public string ApplicationsId { get; set; }
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