using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Orders {
    /// <summary>
    ///  支付信息明细
    /// </summary>
    [Description( " 支付信息明细" )]
    public partial class Paymentinformationdetail : Entity,ISoftDelete {
        /// <summary>
        /// 初始化 支付信息明细
        /// </summary>
        public Paymentinformationdetail(){
        }
        /// <summary>
        /// 支付编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "支付编号输入过长，不能超过108位" )]
        public string PaymentInformationId { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目编号输入过长，不能超过108位" )]
        public string ItemId { get; set; }
        /// <summary>
        /// 项目批次编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目批次编号输入过长，不能超过108位" )]
        public string ItemBatchId { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目名称输入过长，不能超过900位" )]
        public string ItemName { get; set; }
        /// <summary>
        /// 项目规格
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目规格输入过长，不能超过900位" )]
        public string ItemFormat { get; set; }
        /// <summary>
        /// 销售数量
        /// </summary>
        public decimal? SalesCount { get; set; }
        /// <summary>
        /// 销售单价
        /// </summary>
        public decimal? SalesPrice { get; set; }
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "销售单位输入过长，不能超过300位" )]
        public string SalesUnit { get; set; }
        /// <summary>
        /// 项目备注
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目备注输入过长，不能超过900位" )]
        public string Remark { get; set; }
        /// <summary>
        /// 项目类型编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目类型编号输入过长，不能超过108位" )]
        public string ItemTypeId { get; set; }
        /// <summary>
        /// 项目类型
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目类型输入过长，不能超过900位" )]
        public string ItemType { get; set; }
        /// <summary>
        /// 项目类型关系编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目类型关系编号输入过长，不能超过108位" )]
        public string ItemTypeRelationId { get; set; }
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