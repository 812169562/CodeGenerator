using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Medicinestores;


namespace Sand.Domain.Queries.Medicinestores {
    /// <summary>
    /// 药品基本信息查询实体
    /// </summary>
    public class DrugsQuery :  BaseQuery<Drugs> {
        
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
        
        private string _stroeId = string.Empty;
        /// <summary>
        /// 门店号
        /// </summary>
        [Display(Name="门店号")]
        public string StroeId {
            get { return _stroeId == null ? string.Empty : _stroeId.Trim(); }
            set{ _stroeId=value;}
        }        
        
        private string _code = string.Empty;
        /// <summary>
        /// 代码
        /// </summary>
        [Display(Name="代码")]
        public string Code {
            get { return _code == null ? string.Empty : _code.Trim(); }
            set{ _code=value;}
        }        
        /// <summary>
        /// （如：成药,精麻,等等）
        /// </summary>
        [Display(Name="（如：成药,精麻,等等）")]
        public int? Type { get; set; }
        
        private string _barcode = string.Empty;
        /// <summary>
        /// 条码
        /// </summary>
        [Display(Name="条码")]
        public string Barcode {
            get { return _barcode == null ? string.Empty : _barcode.Trim(); }
            set{ _barcode=value;}
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
        
        private string _alias = string.Empty;
        /// <summary>
        /// 别名
        /// </summary>
        [Display(Name="别名")]
        public string Alias {
            get { return _alias == null ? string.Empty : _alias.Trim(); }
            set{ _alias=value;}
        }        
        
        private string _drugTypeId = string.Empty;
        /// <summary>
        /// 药品分类
        /// </summary>
        [Display(Name="药品分类")]
        public string DrugTypeId {
            get { return _drugTypeId == null ? string.Empty : _drugTypeId.Trim(); }
            set{ _drugTypeId=value;}
        }        
        
        private string _drugType = string.Empty;
        /// <summary>
        /// 药品分类
        /// </summary>
        [Display(Name="药品分类")]
        public string DrugType {
            get { return _drugType == null ? string.Empty : _drugType.Trim(); }
            set{ _drugType=value;}
        }        
        
        private string _drugTypeRelationShip = string.Empty;
        /// <summary>
        /// 药品分类类型
        /// </summary>
        [Display(Name="药品分类类型")]
        public string DrugTypeRelationShip {
            get { return _drugTypeRelationShip == null ? string.Empty : _drugTypeRelationShip.Trim(); }
            set{ _drugTypeRelationShip=value;}
        }        
        
        private string _englishName = string.Empty;
        /// <summary>
        /// 英文名
        /// </summary>
        [Display(Name="英文名")]
        public string EnglishName {
            get { return _englishName == null ? string.Empty : _englishName.Trim(); }
            set{ _englishName=value;}
        }        
        
        private string _storeroomUnitId = string.Empty;
        /// <summary>
        /// 库房单位
        /// </summary>
        [Display(Name="库房单位")]
        public string StoreroomUnitId {
            get { return _storeroomUnitId == null ? string.Empty : _storeroomUnitId.Trim(); }
            set{ _storeroomUnitId=value;}
        }        
        
        private string _storeroomUnit = string.Empty;
        /// <summary>
        /// 库房单位
        /// </summary>
        [Display(Name="库房单位")]
        public string StoreroomUnit {
            get { return _storeroomUnit == null ? string.Empty : _storeroomUnit.Trim(); }
            set{ _storeroomUnit=value;}
        }        
        
        private string _useUnitId = string.Empty;
        /// <summary>
        /// 使用单位
        /// </summary>
        [Display(Name="使用单位")]
        public string UseUnitId {
            get { return _useUnitId == null ? string.Empty : _useUnitId.Trim(); }
            set{ _useUnitId=value;}
        }        
        
        private string _useUnit = string.Empty;
        /// <summary>
        /// 使用单位
        /// </summary>
        [Display(Name="使用单位")]
        public string UseUnit {
            get { return _useUnit == null ? string.Empty : _useUnit.Trim(); }
            set{ _useUnit=value;}
        }        
        
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
        
        private string _basicUnitId = string.Empty;
        /// <summary>
        /// 基本单位
        /// </summary>
        [Display(Name="基本单位")]
        public string BasicUnitId {
            get { return _basicUnitId == null ? string.Empty : _basicUnitId.Trim(); }
            set{ _basicUnitId=value;}
        }        
        
        private string _basicUnit = string.Empty;
        /// <summary>
        /// 基本单位
        /// </summary>
        [Display(Name="基本单位")]
        public string BasicUnit {
            get { return _basicUnit == null ? string.Empty : _basicUnit.Trim(); }
            set{ _basicUnit=value;}
        }        
        /// <summary>
        /// 是否按照实际库存卖
        /// </summary>
        [Display(Name="是否按照实际库存卖")]
        public sbyte? IsActualInventory { get; set; }
        /// <summary>
        /// 库房比例
        /// </summary>
        [Display(Name="库房比例")]
        public decimal? StoreroomRatio { get; set; }
        /// <summary>
        /// 销售比例
        /// </summary>
        [Display(Name="销售比例")]
        public decimal? SalesRatio { get; set; }
        /// <summary>
        /// 常用剂量
        /// </summary>
        [Display(Name="常用剂量")]
        public decimal? CommonDose { get; set; }
        /// <summary>
        /// 儿童常用剂量
        /// </summary>
        [Display(Name="儿童常用剂量")]
        public decimal? ChlidCommonDose { get; set; }
        
        private string _manufacturerId = string.Empty;
        /// <summary>
        /// 生产厂家
        /// </summary>
        [Display(Name="生产厂家")]
        public string ManufacturerId {
            get { return _manufacturerId == null ? string.Empty : _manufacturerId.Trim(); }
            set{ _manufacturerId=value;}
        }        
        
        private string _manufacturer = string.Empty;
        /// <summary>
        /// 生产厂家
        /// </summary>
        [Display(Name="生产厂家")]
        public string Manufacturer {
            get { return _manufacturer == null ? string.Empty : _manufacturer.Trim(); }
            set{ _manufacturer=value;}
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
        
        private string _place = string.Empty;
        /// <summary>
        /// 产地
        /// </summary>
        [Display(Name="产地")]
        public string Place {
            get { return _place == null ? string.Empty : _place.Trim(); }
            set{ _place=value;}
        }        
        /// <summary>
        /// 下限提醒
        /// </summary>
        [Display(Name="下限提醒")]
        public int? LowerLimit { get; set; }
        /// <summary>
        /// 是否为处方药品
        /// </summary>
        [Display(Name="是否为处方药品")]
        public int? IsPrescription { get; set; }
        
        private string _drugCommCode = string.Empty;
        /// <summary>
        ///  药品通用码（869）
        /// </summary>
        [Display(Name=" 药品通用码（869）")]
        public string DrugCommCode {
            get { return _drugCommCode == null ? string.Empty : _drugCommCode.Trim(); }
            set{ _drugCommCode=value;}
        }        
        
        private string _remarks = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name="备注")]
        public string Remarks {
            get { return _remarks == null ? string.Empty : _remarks.Trim(); }
            set{ _remarks=value;}
        }        
        
        private string _usePath = string.Empty;
        /// <summary>
        /// 使用说明书地址
        /// </summary>
        [Display(Name="使用说明书地址")]
        public string UsePath {
            get { return _usePath == null ? string.Empty : _usePath.Trim(); }
            set{ _usePath=value;}
        }        
        
        private string _img = string.Empty;
        /// <summary>
        /// 药品图片
        /// </summary>
        [Display(Name="药品图片")]
        public string Img {
            get { return _img == null ? string.Empty : _img.Trim(); }
            set{ _img=value;}
        }        
        /// <summary>
        /// DDD规格
        /// </summary>
        [Display(Name="DDD规格")]
        public decimal? DddFomat { get; set; }
        /// <summary>
        /// DDD值
        /// </summary>
        [Display(Name="DDD值")]
        public decimal? DddValue { get; set; }
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
        
        private string _pinYin = string.Empty;
        /// <summary>
        /// 拼音简拼
        /// </summary>
        [Display(Name="拼音简拼")]
        public string PinYin {
            get { return _pinYin == null ? string.Empty : _pinYin.Trim(); }
            set{ _pinYin=value;}
        }        
        
        private string _fullPinYin = string.Empty;
        /// <summary>
        /// 全拼
        /// </summary>
        [Display(Name="全拼")]
        public string FullPinYin {
            get { return _fullPinYin == null ? string.Empty : _fullPinYin.Trim(); }
            set{ _fullPinYin=value;}
        }        
        
        private string _wubi = string.Empty;
        /// <summary>
        /// 五笔
        /// </summary>
        [Display(Name="五笔")]
        public string Wubi {
            get { return _wubi == null ? string.Empty : _wubi.Trim(); }
            set{ _wubi=value;}
        }        
        /// <summary>
        /// 等级
        /// </summary>
        [Display(Name="等级")]
        public int? Level { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name="排序")]
        public int? Sort { get; set; }
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
