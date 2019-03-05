using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Essentialinformations;


namespace Sand.Domain.Queries.Essentialinformations {
    /// <summary>
    /// 部门信息查询实体
    /// </summary>
    public class DepartmentQuery :  BaseQuery<Department> {
        
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
        /// <summary>
        /// 类型
        /// </summary>
        [Display(Name="类型")]
        public int? Type { get; set; }
        
        private string _code = string.Empty;
        /// <summary>
        /// 代码
        /// </summary>
        [Display(Name="代码")]
        public string Code {
            get { return _code == null ? string.Empty : _code.Trim(); }
            set{ _code=value;}
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
        
        private string _relationShip = string.Empty;
        /// <summary>
        /// 关系
        /// </summary>
        [Display(Name="关系")]
        public string RelationShip {
            get { return _relationShip == null ? string.Empty : _relationShip.Trim(); }
            set{ _relationShip=value;}
        }        
        
        private string _parent = string.Empty;
        /// <summary>
        /// 父级
        /// </summary>
        [Display(Name="父级")]
        public string Parent {
            get { return _parent == null ? string.Empty : _parent.Trim(); }
            set{ _parent=value;}
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
        /// 是否可共享科室患者
        /// </summary>
        [Display(Name="是否可共享科室患者")]
        public sbyte? IsSharePatient { get; set; }
        /// <summary>
        /// 是否为执行科室
        /// </summary>
        [Display(Name="是否为执行科室")]
        public sbyte? IsExecute { get; set; }
        /// <summary>
        /// 是否为药房
        /// </summary>
        [Display(Name="是否为药房")]
        public sbyte? IsPharmacy { get; set; }
        /// <summary>
        /// 是否为库房
        /// </summary>
        [Display(Name="是否为库房")]
        public sbyte? IsStorageRoom { get; set; }
        /// <summary>
        /// 科室挂号费
        /// </summary>
        [Display(Name="科室挂号费")]
        public decimal? RegisterPrice { get; set; }
        
    }
}
