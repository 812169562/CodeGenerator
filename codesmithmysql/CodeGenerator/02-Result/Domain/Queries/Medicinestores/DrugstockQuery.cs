using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Medicinestores;


namespace Sand.Domain.Queries.Medicinestores {
    /// <summary>
    /// 库存(均以销售单位为库存量)查询实体
    /// </summary>
    public class DrugstockQuery :  BaseQuery<Drugstock> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 编号
        /// </summary>
        [Display(Name="编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _tenantId = string.Empty;
        /// <summary>
        /// 医馆号
        /// </summary>
        [Display(Name="医馆号")]
        public string TenantId {
            get { return _tenantId == null ? string.Empty : _tenantId.Trim(); }
            set{ _tenantId=value;}
        }        
        
        private string _stroeName = string.Empty;
        /// <summary>
        ///  门店
        /// </summary>
        [Display(Name=" 门店")]
        public string StroeName {
            get { return _stroeName == null ? string.Empty : _stroeName.Trim(); }
            set{ _stroeName=value;}
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
        
        private string _drugstoreId = string.Empty;
        /// <summary>
        /// 药房编号
        /// </summary>
        [Display(Name="药房编号")]
        public string DrugstoreId {
            get { return _drugstoreId == null ? string.Empty : _drugstoreId.Trim(); }
            set{ _drugstoreId=value;}
        }        
        
        private string _drugstoreName = string.Empty;
        /// <summary>
        /// 药房
        /// </summary>
        [Display(Name="药房")]
        public string DrugstoreName {
            get { return _drugstoreName == null ? string.Empty : _drugstoreName.Trim(); }
            set{ _drugstoreName=value;}
        }        
        /// <summary>
        /// 库存量(销售单位)
        /// </summary>
        [Display(Name="库存量(销售单位)")]
        public decimal? InventoryCount { get; set; }
        /// <summary>
        /// 锁定量
        /// </summary>
        [Display(Name="锁定量")]
        public decimal? LockCount { get; set; }
        
        private string _checkNumber = string.Empty;
        /// <summary>
        /// 盘点顺序表
        /// </summary>
        [Display(Name="盘点顺序表")]
        public string CheckNumber {
            get { return _checkNumber == null ? string.Empty : _checkNumber.Trim(); }
            set{ _checkNumber=value;}
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
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? Status { get; set; }
        
    }
}
