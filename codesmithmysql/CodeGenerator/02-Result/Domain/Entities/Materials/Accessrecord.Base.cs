using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Materials {
    /// <summary>
    ///  领用记录
    /// </summary>
    [Description( " 领用记录" )]
    public partial class Accessrecord : Entity,ISoftDelete {
        /// <summary>
        /// 初始化 领用记录
        /// </summary>
        public Accessrecord(){
        }
        /// <summary>
        /// 物资ID
        /// </summary>
        [StringLength( 144, ErrorMessage = "物资ID输入过长，不能超过144位" )]
        public string MaterialsId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "名称输入过长，不能超过400位" )]
        public string Name { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        [StringLength( 400, ErrorMessage = "规格输入过长，不能超过400位" )]
        public string Specifications { get; set; }
        /// <summary>
        /// 领用数量
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        [StringLength( 200, ErrorMessage = "单位输入过长，不能超过200位" )]
        public string Unit { get; set; }
        /// <summary>
        /// 领用情况
        /// </summary>
        public int? AccessStatus { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        [Required(ErrorMessage = "创建者不能为空")]
        [StringLength( 144, ErrorMessage = "创建者输入过长，不能超过144位" )]
        public string RecipientId { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [StringLength( 400, ErrorMessage = "创建人输入过长，不能超过400位" )]
        public string Recipient { get; set; }
        /// <summary>
        /// 产地
        /// </summary>
        [StringLength( 4000, ErrorMessage = "产地输入过长，不能超过4000位" )]
        public string Remark { get; set; }
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