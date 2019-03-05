using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Medicinestores {
    /// <summary>
    /// 库存(均以销售单位为库存量)
    /// </summary>
    [Description( "库存(均以销售单位为库存量)" )]
    public partial class Drugstock : Entity,ISoftDelete {
        /// <summary>
        /// 初始化库存(均以销售单位为库存量)
        /// </summary>
        public Drugstock(){
        }
        /// <summary>
        ///  门店
        /// </summary>
        [StringLength( 108, ErrorMessage = " 门店输入过长，不能超过108位" )]
        public string StroeName { get; set; }
        /// <summary>
        /// 批次编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "批次编号输入过长，不能超过108位" )]
        public string BatchId { get; set; }
        /// <summary>
        /// 药品编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "药品编号输入过长，不能超过108位" )]
        public string DrugId { get; set; }
        /// <summary>
        /// 药房编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "药房编号输入过长，不能超过108位" )]
        public string DrugstoreId { get; set; }
        /// <summary>
        /// 药房
        /// </summary>
        [StringLength( 300, ErrorMessage = "药房输入过长，不能超过300位" )]
        public string DrugstoreName { get; set; }
        /// <summary>
        /// 库存量(销售单位)
        /// </summary>
        public decimal? InventoryCount { get; set; }
        /// <summary>
        /// 锁定量
        /// </summary>
        public decimal? LockCount { get; set; }
        /// <summary>
        /// 盘点顺序表
        /// </summary>
        [StringLength( 24, ErrorMessage = "盘点顺序表输入过长，不能超过24位" )]
        public string CheckNumber { get; set; }
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