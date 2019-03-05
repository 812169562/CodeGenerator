using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Medicinestores {
    /// <summary>
    /// 药品更新日志
    /// </summary>
    [Description( "药品更新日志" )]
    public partial class Drugupdatelog : Entity,ISoftDelete {
        /// <summary>
        /// 初始化药品更新日志
        /// </summary>
        public Drugupdatelog(){
        }
        /// <summary>
        /// 药品编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "药品编号输入过长，不能超过108位" )]
        public string DrugId { get; set; }
        /// <summary>
        /// 更新前数据
        /// </summary>
        [StringLength( 65535, ErrorMessage = "更新前数据输入过长，不能超过65535位" )]
        public string BeforeData { get; set; }
        /// <summary>
        /// 更新后数据
        /// </summary>
        [StringLength( 65535, ErrorMessage = "更新后数据输入过长，不能超过65535位" )]
        public string AfterData { get; set; }
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