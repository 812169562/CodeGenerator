﻿using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Medicinestores {
    /// <summary>
    /// 出入库明细表
    /// </summary>
    [Description( "出入库明细表" )]
    public partial class Druginoutinfo : Entity,ISoftDelete {
        /// <summary>
        /// 初始化出入库明细表
        /// </summary>
        public Druginoutinfo(){
        }
        /// <summary>
        /// 出入库编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "出入库编号输入过长，不能超过108位" )]
        public string DrugInOutId { get; set; }
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
        /// 药品名称
        /// </summary>
        [StringLength( 300, ErrorMessage = "药品名称输入过长，不能超过300位" )]
        public string DrugName { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        [StringLength( 150, ErrorMessage = "规格输入过长，不能超过150位" )]
        public string Format { get; set; }
        /// <summary>
        /// 销售价(包装单位)
        /// </summary>
        public decimal? SalesPrice { get; set; }
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "销售单位输入过长，不能超过108位" )]
        public string SalesUnitId { get; set; }
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "销售单位输入过长，不能超过300位" )]
        public string SalesUnit { get; set; }
        /// <summary>
        /// 成本价(包装单位)
        /// </summary>
        public decimal? CostPrice { get; set; }
        /// <summary>
        /// 调拨入库数量(销售单位为数量)
        /// </summary>
        public int? InOutCount { get; set; }
        /// <summary>
        /// 药品生产批号
        /// </summary>
        [StringLength( 150, ErrorMessage = "药品生产批号输入过长，不能超过150位" )]
        public string BatchCode { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime? ExpiryDate { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime? ManufactureDate { get; set; }
        /// <summary>
        /// 是否调价
        /// </summary>
        public sbyte? IsModifyPrice { get; set; }
        /// <summary>
        /// 调整之后价格
        /// </summary>
        public decimal? ModifyPrice { get; set; }
        /// <summary>
        /// 调价生效日期
        /// </summary>
        public DateTime? ModifyPriceDate { get; set; }
        /// <summary>
        /// 剩余多少库存之后调价生效
        /// </summary>
        public int? ModifyPriceCount { get; set; }
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