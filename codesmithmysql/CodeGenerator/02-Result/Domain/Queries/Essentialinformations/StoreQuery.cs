﻿using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Essentialinformations;


namespace Sand.Domain.Queries.Essentialinformations {
    /// <summary>
    /// 门店查询实体
    /// </summary>
    public class StoreQuery :  BaseQuery<Store> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 门店编号
        /// </summary>
        [Display(Name="门店编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _tenantId = string.Empty;
        /// <summary>
        /// 租户
        /// </summary>
        [Display(Name="租户")]
        public string TenantId {
            get { return _tenantId == null ? string.Empty : _tenantId.Trim(); }
            set{ _tenantId=value;}
        }        
        
        private string _tenantName = string.Empty;
        /// <summary>
        /// 租户名
        /// </summary>
        [Display(Name="租户名")]
        public string TenantName {
            get { return _tenantName == null ? string.Empty : _tenantName.Trim(); }
            set{ _tenantName=value;}
        }        
        
        private string _userId = string.Empty;
        /// <summary>
        /// 店长编号
        /// </summary>
        [Display(Name="店长编号")]
        public string UserId {
            get { return _userId == null ? string.Empty : _userId.Trim(); }
            set{ _userId=value;}
        }        
        
        private string _telName = string.Empty;
        /// <summary>
        /// 联系人
        /// </summary>
        [Display(Name="联系人")]
        public string TelName {
            get { return _telName == null ? string.Empty : _telName.Trim(); }
            set{ _telName=value;}
        }        
        
        private string _address = string.Empty;
        /// <summary>
        /// 联系地址
        /// </summary>
        [Display(Name="联系地址")]
        public string Address {
            get { return _address == null ? string.Empty : _address.Trim(); }
            set{ _address=value;}
        }        
        
        private string _telPhone = string.Empty;
        /// <summary>
        /// 联系电话
        /// </summary>
        [Display(Name="联系电话")]
        public string TelPhone {
            get { return _telPhone == null ? string.Empty : _telPhone.Trim(); }
            set{ _telPhone=value;}
        }        
        
        private string _code = string.Empty;
        /// <summary>
        /// 门店号
        /// </summary>
        [Display(Name="门店号")]
        public string Code {
            get { return _code == null ? string.Empty : _code.Trim(); }
            set{ _code=value;}
        }        
        
        private string _coordinate = string.Empty;
        /// <summary>
        /// 坐标
        /// </summary>
        [Display(Name="坐标")]
        public string Coordinate {
            get { return _coordinate == null ? string.Empty : _coordinate.Trim(); }
            set{ _coordinate=value;}
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
        
    }
}
