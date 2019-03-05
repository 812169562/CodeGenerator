using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Medicinestores;


namespace Sand.Domain.Queries.Medicinestores {
    /// <summary>
    /// 出入库明细表查询实体
    /// </summary>
    public class DruginoutinfoQuery :  BaseQuery<Druginoutinfo> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 出入库明细编号
        /// </summary>
        [Display(Name="出入库明细编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _drugInOutId = string.Empty;
        /// <summary>
        /// 出入库编号
        /// </summary>
        [Display(Name="出入库编号")]
        public string DrugInOutId {
            get { return _drugInOutId == null ? string.Empty : _drugInOutId.Trim(); }
            set{ _drugInOutId=value;}
        }        
        
        private string _batchId = string.Empty;
        /// <summary>
        /// 批次编号
        /// </summary>
        [Display(Name="批次编号")]
        public string BatchId {
            get { return _batchId == null ? string.Empty : _batchId.Trim(); }
            set{ _batchId=value;}
        }        
        
        private string _drugId = string.Empty;
        /// <summary>
        /// 药品编号
        /// </summary>
        [Display(Name="药品编号")]
        public string DrugId {
            get { return _drugId == null ? string.Empty : _drugId.Trim(); }
            set{ _drugId=value;}
        }        
        
        private string _drugName = string.Empty;
        /// <summary>
        /// 药品名称
        /// </summary>
        [Display(Name="药品名称")]
        public string DrugName {
            get { return _drugName == null ? string.Empty : _drugName.Trim(); }
            set{ _drugName=value;}
        }        
        
        private string _format = string.Empty;
        /// <summary>
        /// 规格
        /// </summary>
        [Display(Name="规格")]
        public string Format {
            get { return _format == null ? string.Empty : _format.Trim(); }
            set{ _format=value;}
        }        
        /// <summary>
        /// 销售价(包装单位)
        /// </summary>
        [Display(Name="销售价(包装单位)")]
        public decimal? SalesPrice { get; set; }
        
        private string _salesUnitId = string.Empty;
        /// <summary>
        /// 销售单位
        /// </summary>
        [Display(Name="销售单位")]
        public string SalesUnitId {
            get { return _salesUnitId == null ? string.Empty : _salesUnitId.Trim(); }
            set{ _salesUnitId=value;}
        }        
        
        private string _salesUnit = string.Empty;
        /// <summary>
        /// 销售单位
        /// </summary>
        [Display(Name="销售单位")]
        public string SalesUnit {
            get { return _salesUnit == null ? string.Empty : _salesUnit.Trim(); }
            set{ _salesUnit=value;}
        }        
        /// <summary>
        /// 成本价(包装单位)
        /// </summary>
        [Display(Name="成本价(包装单位)")]
        public decimal? CostPrice { get; set; }
        /// <summary>
        /// 调拨入库数量(销售单位为数量)
        /// </summary>
        [Display(Name="调拨入库数量(销售单位为数量)")]
        public int? InOutCount { get; set; }
        
        private string _batchCode = string.Empty;
        /// <summary>
        /// 药品生产批号
        /// </summary>
        [Display(Name="药品生产批号")]
        public string BatchCode {
            get { return _batchCode == null ? string.Empty : _batchCode.Trim(); }
            set{ _batchCode=value;}
        }        
        /// <summary>
        /// 起始有效期
        /// </summary>
        [Display( Name = "起始有效期" )]
        public DateTime? BeginExpiryDate { get; set; }
        /// <summary>
        /// 结束有效期
        /// </summary>
        [Display( Name = "结束有效期" )]
        public DateTime? EndExpiryDate { get; set; }        
        /// <summary>
        /// 起始生产日期
        /// </summary>
        [Display( Name = "起始生产日期" )]
        public DateTime? BeginManufactureDate { get; set; }
        /// <summary>
        /// 结束生产日期
        /// </summary>
        [Display( Name = "结束生产日期" )]
        public DateTime? EndManufactureDate { get; set; }        
        /// <summary>
        /// 是否调价
        /// </summary>
        [Display(Name="是否调价")]
        public sbyte? IsModifyPrice { get; set; }
        /// <summary>
        /// 调整之后价格
        /// </summary>
        [Display(Name="调整之后价格")]
        public decimal? ModifyPrice { get; set; }
        /// <summary>
        /// 起始调价生效日期
        /// </summary>
        [Display( Name = "起始调价生效日期" )]
        public DateTime? BeginModifyPriceDate { get; set; }
        /// <summary>
        /// 结束调价生效日期
        /// </summary>
        [Display( Name = "结束调价生效日期" )]
        public DateTime? EndModifyPriceDate { get; set; }        
        /// <summary>
        /// 剩余多少库存之后调价生效
        /// </summary>
        [Display(Name="剩余多少库存之后调价生效")]
        public int? ModifyPriceCount { get; set; }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreateTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreateTime { get; set; }        
        
        private string _createId = string.Empty;
        /// <summary>
        /// 创建者
        /// </summary>
        [Display(Name="创建者")]
        public string CreateId {
            get { return _createId == null ? string.Empty : _createId.Trim(); }
            set{ _createId=value;}
        }        
        
        private string _createName = string.Empty;
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name="创建人")]
        public string CreateName {
            get { return _createName == null ? string.Empty : _createName.Trim(); }
            set{ _createName=value;}
        }        
        /// <summary>
        /// 起始最近更新时间
        /// </summary>
        [Display( Name = "起始最近更新时间" )]
        public DateTime? BeginLastUpdateTime { get; set; }
        /// <summary>
        /// 结束最近更新时间
        /// </summary>
        [Display( Name = "结束最近更新时间" )]
        public DateTime? EndLastUpdateTime { get; set; }        
        
        private string _lastUpdateId = string.Empty;
        /// <summary>
        /// 最近更新者
        /// </summary>
        [Display(Name="最近更新者")]
        public string LastUpdateId {
            get { return _lastUpdateId == null ? string.Empty : _lastUpdateId.Trim(); }
            set{ _lastUpdateId=value;}
        }        
        
        private string _lastUpdateName = string.Empty;
        /// <summary>
        /// 最近更新人
        /// </summary>
        [Display(Name="最近更新人")]
        public string LastUpdateName {
            get { return _lastUpdateName == null ? string.Empty : _lastUpdateName.Trim(); }
            set{ _lastUpdateName=value;}
        }        
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? Status { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        [Display(Name="是否可用")]
        public sbyte? IsEnable { get; set; }
        
        private string _version = string.Empty;
        /// <summary>
        /// 版本号
        /// </summary>
        [Display(Name="版本号")]
        public string Version {
            get { return _version == null ? string.Empty : _version.Trim(); }
            set{ _version=value;}
        }        
        /// <summary>
        /// 删除标志
        /// </summary>
        [Display(Name="删除标志")]
        public sbyte? IsDeleted { get; set; }
        
    }
}
