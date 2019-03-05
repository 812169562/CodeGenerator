using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Essentialinformations;


namespace Sand.Domain.Queries.Essentialinformations {
    /// <summary>
    /// 资源查询实体
    /// </summary>
    public class ResourceQuery :  BaseQuery<Resource> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 编号
        /// </summary>
        [Display(Name="编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _name = string.Empty;
        /// <summary>
        /// 资源名称
        /// </summary>
        [Display(Name="资源名称")]
        public string Name {
            get { return _name == null ? string.Empty : _name.Trim(); }
            set{ _name=value;}
        }        
        
        private string _stroeId = string.Empty;
        /// <summary>
        /// 门店编号
        /// </summary>
        [Display(Name="门店编号")]
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
        
        private string _tenantId = string.Empty;
        /// <summary>
        /// 医馆编号
        /// </summary>
        [Display(Name="医馆编号")]
        public string TenantId {
            get { return _tenantId == null ? string.Empty : _tenantId.Trim(); }
            set{ _tenantId=value;}
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
        
        private string _url = string.Empty;
        /// <summary>
        /// 地址
        /// </summary>
        [Display(Name="地址")]
        public string Url {
            get { return _url == null ? string.Empty : _url.Trim(); }
            set{ _url=value;}
        }        
        
        private string _path = string.Empty;
        /// <summary>
        /// 路径
        /// </summary>
        [Display(Name="路径")]
        public string Path {
            get { return _path == null ? string.Empty : _path.Trim(); }
            set{ _path=value;}
        }        
        
        private string _para = string.Empty;
        /// <summary>
        /// 参数
        /// </summary>
        [Display(Name="参数")]
        public string Para {
            get { return _para == null ? string.Empty : _para.Trim(); }
            set{ _para=value;}
        }        
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? Status { get; set; }
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
        /// 是否可用
        /// </summary>
        [Display(Name="是否可用")]
        public sbyte? IsEnable { get; set; }
        
        private string _applicationsId = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        [Display(Name="")]
        public string ApplicationsId {
            get { return _applicationsId == null ? string.Empty : _applicationsId.Trim(); }
            set{ _applicationsId=value;}
        }        
        
    }
}
