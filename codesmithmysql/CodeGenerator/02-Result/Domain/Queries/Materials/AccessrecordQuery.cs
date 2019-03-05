using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Materials;


namespace Sand.Domain.Queries.Materials {
    /// <summary>
    ///  领用记录查询实体
    /// </summary>
    public class AccessrecordQuery :  BaseQuery<Accessrecord> {
        
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
        
        private string _materialsId = string.Empty;
        /// <summary>
        /// 物资ID
        /// </summary>
        [Display(Name="物资ID")]
        public string MaterialsId {
            get { return _materialsId == null ? string.Empty : _materialsId.Trim(); }
            set{ _materialsId=value;}
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
        
        private string _specifications = string.Empty;
        /// <summary>
        /// 规格
        /// </summary>
        [Display(Name="规格")]
        public string Specifications {
            get { return _specifications == null ? string.Empty : _specifications.Trim(); }
            set{ _specifications=value;}
        }        
        /// <summary>
        /// 领用数量
        /// </summary>
        [Display(Name="领用数量")]
        public int? Count { get; set; }
        
        private string _unit = string.Empty;
        /// <summary>
        /// 单位
        /// </summary>
        [Display(Name="单位")]
        public string Unit {
            get { return _unit == null ? string.Empty : _unit.Trim(); }
            set{ _unit=value;}
        }        
        /// <summary>
        /// 领用情况
        /// </summary>
        [Display(Name="领用情况")]
        public int? AccessStatus { get; set; }
        
        private string _recipientId = string.Empty;
        /// <summary>
        /// 创建者
        /// </summary>
        [Display(Name="创建者")]
        public string RecipientId {
            get { return _recipientId == null ? string.Empty : _recipientId.Trim(); }
            set{ _recipientId=value;}
        }        
        
        private string _recipient = string.Empty;
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name="创建人")]
        public string Recipient {
            get { return _recipient == null ? string.Empty : _recipient.Trim(); }
            set{ _recipient=value;}
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
