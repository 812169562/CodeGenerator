using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Medicinestores;


namespace Sand.Domain.Queries.Medicinestores {
    /// <summary>
    /// 药品批次信息查询实体
    /// </summary>
    public class DrugbatchQuery :  BaseQuery<Drugbatch> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 编号
        /// </summary>
        [Display(Name="编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _batchNumber = string.Empty;
        /// <summary>
        /// 批次号（系统按照日期生成）
        /// </summary>
        [Display(Name="批次号（系统按照日期生成）")]
        public string BatchNumber {
            get { return _batchNumber == null ? string.Empty : _batchNumber.Trim(); }
            set{ _batchNumber=value;}
        }        
        
        private string _batchCode = string.Empty;
        /// <summary>
        /// 药品生产批号
        /// </summary>
        [Display(Name="药品生产批号")]
        public string BatchCode {
            get { return _batchCode == null ? string.Empty : _batchCode.Trim(); }
            set{ _batchCode=value;}
        }        
        
        private string _tenantId = string.Empty;
        /// <summary>
        /// 医馆
        /// </summary>
        [Display(Name="医馆")]
        public string TenantId {
            get { return _tenantId == null ? string.Empty : _tenantId.Trim(); }
            set{ _tenantId=value;}
        }        
        
        private string _stroeId = string.Empty;
        /// <summary>
        /// 门店号
        /// </summary>
        [Display(Name="门店号")]
        public string StroeId {
            get { return _stroeId == null ? string.Empty : _stroeId.Trim(); }
            set{ _stroeId=value;}
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
        /// <summary>
        /// 最小单位价格(自动计算)
        /// </summary>
        [Display(Name="最小单位价格(自动计算)")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 销售价(包装单位)
        /// </summary>
        [Display(Name="销售价(包装单位)")]
        public decimal? SalesPrice { get; set; }
        /// <summary>
        /// 成本价(包装单位)
        /// </summary>
        [Display(Name="成本价(包装单位)")]
        public decimal? CostPrice { get; set; }
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
        /// 保质期
        /// </summary>
        [Display(Name="保质期")]
        public int? HelflifeDay { get; set; }
        
        private string _supplierId = string.Empty;
        /// <summary>
        /// 供应商
        /// </summary>
        [Display(Name="供应商")]
        public string SupplierId {
            get { return _supplierId == null ? string.Empty : _supplierId.Trim(); }
            set{ _supplierId=value;}
        }        
        
        private string _supplier = string.Empty;
        /// <summary>
        /// 供应商
        /// </summary>
        [Display(Name="供应商")]
        public string Supplier {
            get { return _supplier == null ? string.Empty : _supplier.Trim(); }
            set{ _supplier=value;}
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
