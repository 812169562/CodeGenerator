using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Orders;


namespace Sand.Domain.Queries.Orders {
    /// <summary>
    /// 订单明细查询实体
    /// </summary>
    public class PrescriptionorderinfoQuery :  BaseQuery<Prescriptionorderinfo> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 订单明细编号
        /// </summary>
        [Display(Name="订单明细编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
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
        
        private string _orderId = string.Empty;
        /// <summary>
        /// 订单编号
        /// </summary>
        [Display(Name="订单编号")]
        public string OrderId {
            get { return _orderId == null ? string.Empty : _orderId.Trim(); }
            set{ _orderId=value;}
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
        
        private string _usageName = string.Empty;
        /// <summary>
        /// 使用方法
        /// </summary>
        [Display(Name="使用方法")]
        public string UsageName {
            get { return _usageName == null ? string.Empty : _usageName.Trim(); }
            set{ _usageName=value;}
        }        
        
        private string _usageId = string.Empty;
        /// <summary>
        /// 使用方法编号
        /// </summary>
        [Display(Name="使用方法编号")]
        public string UsageId {
            get { return _usageId == null ? string.Empty : _usageId.Trim(); }
            set{ _usageId=value;}
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
        
        private string _remark = string.Empty;
        /// <summary>
        /// 项目备注
        /// </summary>
        [Display(Name="项目备注")]
        public string Remark {
            get { return _remark == null ? string.Empty : _remark.Trim(); }
            set{ _remark=value;}
        }        
        /// <summary>
        /// 项目顺序
        /// </summary>
        [Display(Name="项目顺序")]
        public int? Sort { get; set; }
        
        private string _groupNo = string.Empty;
        /// <summary>
        /// 项目分组
        /// </summary>
        [Display(Name="项目分组")]
        public string GroupNo {
            get { return _groupNo == null ? string.Empty : _groupNo.Trim(); }
            set{ _groupNo=value;}
        }        
        
        private string _sbCode = string.Empty;
        /// <summary>
        /// 项目社保编号
        /// </summary>
        [Display(Name="项目社保编号")]
        public string SbCode {
            get { return _sbCode == null ? string.Empty : _sbCode.Trim(); }
            set{ _sbCode=value;}
        }        
        
        private string _standardCode = string.Empty;
        /// <summary>
        /// 标准编号
        /// </summary>
        [Display(Name="标准编号")]
        public string StandardCode {
            get { return _standardCode == null ? string.Empty : _standardCode.Trim(); }
            set{ _standardCode=value;}
        }        
        /// <summary>
        /// 单次用量
        /// </summary>
        [Display(Name="单次用量")]
        public decimal? UsageCount { get; set; }
        
        private string _usageUnit = string.Empty;
        /// <summary>
        /// 单次用量单位
        /// </summary>
        [Display(Name="单次用量单位")]
        public string UsageUnit {
            get { return _usageUnit == null ? string.Empty : _usageUnit.Trim(); }
            set{ _usageUnit=value;}
        }        
        /// <summary>
        /// 用法比例
        /// </summary>
        [Display(Name="用法比例")]
        public decimal? UsageRatio { get; set; }
        
        private string _frequencyId = string.Empty;
        /// <summary>
        /// 频率编号
        /// </summary>
        [Display(Name="频率编号")]
        public string FrequencyId {
            get { return _frequencyId == null ? string.Empty : _frequencyId.Trim(); }
            set{ _frequencyId=value;}
        }        
        
        private string _frequency = string.Empty;
        /// <summary>
        /// 频率
        /// </summary>
        [Display(Name="频率")]
        public string Frequency {
            get { return _frequency == null ? string.Empty : _frequency.Trim(); }
            set{ _frequency=value;}
        }        
        /// <summary>
        /// 频率比例
        /// </summary>
        [Display(Name="频率比例")]
        public decimal? FrequencyRatio { get; set; }
        
        private string _dropNumber = string.Empty;
        /// <summary>
        /// 滴数
        /// </summary>
        [Display(Name="滴数")]
        public string DropNumber {
            get { return _dropNumber == null ? string.Empty : _dropNumber.Trim(); }
            set{ _dropNumber=value;}
        }        
        /// <summary>
        /// 皮试标志
        /// </summary>
        [Display(Name="皮试标志")]
        public int? SkinTest { get; set; }
        
        private string _skinTestResult = string.Empty;
        /// <summary>
        /// 皮试结果
        /// </summary>
        [Display(Name="皮试结果")]
        public string SkinTestResult {
            get { return _skinTestResult == null ? string.Empty : _skinTestResult.Trim(); }
            set{ _skinTestResult=value;}
        }        
        /// <summary>
        /// 天数
        /// </summary>
        [Display(Name="天数")]
        public int? Day { get; set; }
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
