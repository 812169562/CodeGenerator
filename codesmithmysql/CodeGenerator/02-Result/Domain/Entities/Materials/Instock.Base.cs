using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Materials {
    /// <summary>
    /// 入库记录
    /// </summary>
    [Description( "入库记录" )]
    public partial class Instock : Entity,ISoftDelete {
        /// <summary>
        /// 初始化入库记录
        /// </summary>
        public Instock(){
        }
        /// <summary>
        /// 类型
        /// </summary>
        public int? Type { get; set; }
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
        /// 采购价格
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        [StringLength( 200, ErrorMessage = "单位输入过长，不能超过200位" )]
        public string Unit { get; set; }
        /// <summary>
        /// 购买情况
        /// </summary>
        [StringLength( 144, ErrorMessage = "购买情况输入过长，不能超过144位" )]
        public string PurchasesId { get; set; }
        /// <summary>
        /// 购买情况
        /// </summary>
        [StringLength( 200, ErrorMessage = "购买情况输入过长，不能超过200位" )]
        public string Purchases { get; set; }
        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime? PurchaseDate { get; set; }
        /// <summary>
        /// 库房
        /// </summary>
        [StringLength( 144, ErrorMessage = "库房输入过长，不能超过144位" )]
        public string StorehouseId { get; set; }
        /// <summary>
        /// 库房
        /// </summary>
        [StringLength( 200, ErrorMessage = "库房输入过长，不能超过200位" )]
        public string Storehouse { get; set; }
        /// <summary>
        /// 采购人
        /// </summary>
        [StringLength( 144, ErrorMessage = "采购人输入过长，不能超过144位" )]
        public string PurchaserId { get; set; }
        /// <summary>
        /// 采购人
        /// </summary>
        [StringLength( 200, ErrorMessage = "采购人输入过长，不能超过200位" )]
        public string Purchaser { get; set; }
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