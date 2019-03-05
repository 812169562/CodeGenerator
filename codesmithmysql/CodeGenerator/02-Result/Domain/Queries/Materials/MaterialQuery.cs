using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Materials;


namespace Sand.Domain.Queries.Materials {
    /// <summary>
    /// 物资查询实体
    /// </summary>
    public class MaterialQuery :  BaseQuery<Material> {
        
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
        
        private string _name = string.Empty;
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name="名称")]
        public string Name {
            get { return _name == null ? string.Empty : _name.Trim(); }
            set{ _name=value;}
        }        
        
        private string _code = string.Empty;
        /// <summary>
        /// 编号
        /// </summary>
        [Display(Name="编号")]
        public string Code {
            get { return _code == null ? string.Empty : _code.Trim(); }
            set{ _code=value;}
        }        
        
        private string _unit = string.Empty;
        /// <summary>
        /// 单位
        /// </summary>
        [Display(Name="单位")]
        public string Unit {
            get { return _unit == null ? string.Empty : _unit.Trim(); }
            set{ _unit=value;}
        }        
        
        private string _specifications = string.Empty;
        /// <summary>
        /// 规格
        /// </summary>
        [Display(Name="规格")]
        public string Specifications {
            get { return _specifications == null ? string.Empty : _specifications.Trim(); }
            set{ _specifications=value;}
        }        
        
        private string _trademark = string.Empty;
        /// <summary>
        /// 品牌
        /// </summary>
        [Display(Name="品牌")]
        public string Trademark {
            get { return _trademark == null ? string.Empty : _trademark.Trim(); }
            set{ _trademark=value;}
        }        
        
        private string _type = string.Empty;
        /// <summary>
        /// 型号
        /// </summary>
        [Display(Name="型号")]
        public string Type {
            get { return _type == null ? string.Empty : _type.Trim(); }
            set{ _type=value;}
        }        
        
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
        /// <summary>
        /// 起始采购时间
        /// </summary>
        [Display( Name = "起始采购时间" )]
        public DateTime? BeginPurchasingTime { get; set; }
        /// <summary>
        /// 结束采购时间
        /// </summary>
        [Display( Name = "结束采购时间" )]
        public DateTime? EndPurchasingTime { get; set; }        
        /// <summary>
        /// 起始有效期
        /// </summary>
        [Display( Name = "起始有效期" )]
        public DateTime? BeginPeriodTime { get; set; }
        /// <summary>
        /// 结束有效期
        /// </summary>
        [Display( Name = "结束有效期" )]
        public DateTime? EndPeriodTime { get; set; }        
        
        private string _place = string.Empty;
        /// <summary>
        /// 产地
        /// </summary>
        [Display(Name="产地")]
        public string Place {
            get { return _place == null ? string.Empty : _place.Trim(); }
            set{ _place=value;}
        }        
        
        private string _remark = string.Empty;
        /// <summary>
        /// 产地
        /// </summary>
        [Display(Name="产地")]
        public string Remark {
            get { return _remark == null ? string.Empty : _remark.Trim(); }
            set{ _remark=value;}
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
        
        private string _wubi = string.Empty;
        /// <summary>
        /// 五笔
        /// </summary>
        [Display(Name="五笔")]
        public string Wubi {
            get { return _wubi == null ? string.Empty : _wubi.Trim(); }
            set{ _wubi=value;}
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
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? Status { get; set; }
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
        /// 是否可用
        /// </summary>
        [Display(Name="是否可用")]
        public sbyte? IsEnable { get; set; }
        /// <summary>
        /// 删除标志
        /// </summary>
        [Display(Name="删除标志")]
        public sbyte? IsDeleted { get; set; }
        
    }
}
