using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Medicinestores {
    /// <summary>
    /// 药品批次信息
    /// </summary>
    [Description( "药品批次信息" )]
    public partial class Drugbatch : Entity,ISoftDelete {
        /// <summary>
        /// 初始化药品批次信息
        /// </summary>
        public Drugbatch(){
        }
        /// <summary>
        /// 批次号（系统按照日期生成）
        /// </summary>
        [StringLength( 108, ErrorMessage = "批次号（系统按照日期生成）输入过长，不能超过108位" )]
        public string BatchNumber { get; set; }
        /// <summary>
        /// 药品生产批号
        /// </summary>
        [StringLength( 300, ErrorMessage = "药品生产批号输入过长，不能超过300位" )]
        public string BatchCode { get; set; }
        /// <summary>
        /// 药品编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "药品编号输入过长，不能超过108位" )]
        public string DrugId { get; set; }
        /// <summary>
        /// 最小单位价格(自动计算)
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// 销售价(包装单位)
        /// </summary>
        public decimal? SalesPrice { get; set; }
        /// <summary>
        /// 成本价(包装单位)
        /// </summary>
        public decimal? CostPrice { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime? ExpiryDate { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime? ManufactureDate { get; set; }
        /// <summary>
        /// 保质期
        /// </summary>
        public int? HelflifeDay { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        [StringLength( 108, ErrorMessage = "供应商输入过长，不能超过108位" )]
        public string SupplierId { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        [StringLength( 300, ErrorMessage = "供应商输入过长，不能超过300位" )]
        public string Supplier { get; set; }
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