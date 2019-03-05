﻿using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Activities;


namespace Sand.Domain.Queries.Activities {
    /// <summary>
    /// 优惠券领用查询实体
    /// </summary>
    public class CouponcollarQuery :  BaseQuery<Couponcollar> {
        
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
        
        private string _couponId = string.Empty;
        /// <summary>
        /// 优惠卷编号
        /// </summary>
        [Display(Name="优惠卷编号")]
        public string CouponId {
            get { return _couponId == null ? string.Empty : _couponId.Trim(); }
            set{ _couponId=value;}
        }        
        
        private string _customertId = string.Empty;
        /// <summary>
        /// 客户(患者)编号
        /// </summary>
        [Display(Name="客户(患者)编号")]
        public string CustomertId {
            get { return _customertId == null ? string.Empty : _customertId.Trim(); }
            set{ _customertId=value;}
        }        
        
        private string _customerName = string.Empty;
        /// <summary>
        /// 客户(患者)姓名
        /// </summary>
        [Display(Name="客户(患者)姓名")]
        public string CustomerName {
            get { return _customerName == null ? string.Empty : _customerName.Trim(); }
            set{ _customerName=value;}
        }        
        /// <summary>
        /// 起始开始时间
        /// </summary>
        [Display( Name = "起始开始时间" )]
        public DateTime? BeginStartTime { get; set; }
        /// <summary>
        /// 结束开始时间
        /// </summary>
        [Display( Name = "结束开始时间" )]
        public DateTime? EndStartTime { get; set; }        
        /// <summary>
        /// 起始结束时间
        /// </summary>
        [Display( Name = "起始结束时间" )]
        public DateTime? BeginEndTime { get; set; }
        /// <summary>
        /// 结束结束时间
        /// </summary>
        [Display( Name = "结束结束时间" )]
        public DateTime? EndEndTime { get; set; }        
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
        /// 排序
        /// </summary>
        [Display(Name="排序")]
        public int? Sort { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Display(Name="类型")]
        public int? Type { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? Status { get; set; }
        
    }
}
