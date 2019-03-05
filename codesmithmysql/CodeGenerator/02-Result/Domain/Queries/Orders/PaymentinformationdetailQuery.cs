using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Orders;


namespace Sand.Domain.Queries.Orders {
    /// <summary>
    ///  支付信息明细查询实体
    /// </summary>
    public class PaymentinformationdetailQuery :  BaseQuery<Paymentinformationdetail> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 支付明细编号
        /// </summary>
        [Display(Name="支付明细编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _paymentInformationId = string.Empty;
        /// <summary>
        /// 支付编号
        /// </summary>
        [Display(Name="支付编号")]
        public string PaymentInformationId {
            get { return _paymentInformationId == null ? string.Empty : _paymentInformationId.Trim(); }
            set{ _paymentInformationId=value;}
        }        
        
        private string _itemId = string.Empty;
        /// <summary>
        /// 项目编号
        /// </summary>
        [Display(Name="项目编号")]
        public string ItemId {
            get { return _itemId == null ? string.Empty : _itemId.Trim(); }
            set{ _itemId=value;}
        }        
        
        private string _itemBatchId = string.Empty;
        /// <summary>
        /// 项目批次编号
        /// </summary>
        [Display(Name="项目批次编号")]
        public string ItemBatchId {
            get { return _itemBatchId == null ? string.Empty : _itemBatchId.Trim(); }
            set{ _itemBatchId=value;}
        }        
        
        private string _itemName = string.Empty;
        /// <summary>
        /// 项目名称
        /// </summary>
        [Display(Name="项目名称")]
        public string ItemName {
            get { return _itemName == null ? string.Empty : _itemName.Trim(); }
            set{ _itemName=value;}
        }        
        
        private string _itemFormat = string.Empty;
        /// <summary>
        /// 项目规格
        /// </summary>
        [Display(Name="项目规格")]
        public string ItemFormat {
            get { return _itemFormat == null ? string.Empty : _itemFormat.Trim(); }
            set{ _itemFormat=value;}
        }        
        /// <summary>
        /// 销售数量
        /// </summary>
        [Display(Name="销售数量")]
        public decimal? SalesCount { get; set; }
        /// <summary>
        /// 销售单价
        /// </summary>
        [Display(Name="销售单价")]
        public decimal? SalesPrice { get; set; }
        
        private string _salesUnit = string.Empty;
        /// <summary>
        /// 销售单位
        /// </summary>
        [Display(Name="销售单位")]
        public string SalesUnit {
            get { return _salesUnit == null ? string.Empty : _salesUnit.Trim(); }
            set{ _salesUnit=value;}
        }        
        
        private string _remark = string.Empty;
        /// <summary>
        /// 项目备注
        /// </summary>
        [Display(Name="项目备注")]
        public string Remark {
            get { return _remark == null ? string.Empty : _remark.Trim(); }
            set{ _remark=value;}
        }        
        
        private string _itemTypeId = string.Empty;
        /// <summary>
        /// 项目类型编号
        /// </summary>
        [Display(Name="项目类型编号")]
        public string ItemTypeId {
            get { return _itemTypeId == null ? string.Empty : _itemTypeId.Trim(); }
            set{ _itemTypeId=value;}
        }        
        
        private string _itemType = string.Empty;
        /// <summary>
        /// 项目类型
        /// </summary>
        [Display(Name="项目类型")]
        public string ItemType {
            get { return _itemType == null ? string.Empty : _itemType.Trim(); }
            set{ _itemType=value;}
        }        
        
        private string _itemTypeRelationId = string.Empty;
        /// <summary>
        /// 项目类型关系编号
        /// </summary>
        [Display(Name="项目类型关系编号")]
        public string ItemTypeRelationId {
            get { return _itemTypeRelationId == null ? string.Empty : _itemTypeRelationId.Trim(); }
            set{ _itemTypeRelationId=value;}
        }        
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
