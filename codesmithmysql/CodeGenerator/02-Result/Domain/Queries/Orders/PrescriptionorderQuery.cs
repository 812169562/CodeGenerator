using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Orders;


namespace Sand.Domain.Queries.Orders {
    /// <summary>
    /// 订单处方查询实体
    /// </summary>
    public class PrescriptionorderQuery :  BaseQuery<Prescriptionorder> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 订单编号
        /// </summary>
        [Display(Name="订单编号")]
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
        
        private string _stroeName = string.Empty;
        /// <summary>
        /// 门店名
        /// </summary>
        [Display(Name="门店名")]
        public string StroeName {
            get { return _stroeName == null ? string.Empty : _stroeName.Trim(); }
            set{ _stroeName=value;}
        }        
        
        private string _code = string.Empty;
        /// <summary>
        /// 处方编号
        /// </summary>
        [Display(Name="处方编号")]
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
        
        private string _prescriptionCode = string.Empty;
        /// <summary>
        /// 申请单编号
        /// </summary>
        [Display(Name="申请单编号")]
        public string PrescriptionCode {
            get { return _prescriptionCode == null ? string.Empty : _prescriptionCode.Trim(); }
            set{ _prescriptionCode=value;}
        }        
        /// <summary>
        /// 申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)
        /// </summary>
        [Display(Name="申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)")]
        public int? Type { get; set; }
        /// <summary>
        /// 处方类型(0.普通,1.精一.2.精二.3.中药饮片,4.中药免检.5.中药小包装)
        /// </summary>
        [Display(Name="处方类型(0.普通,1.精一.2.精二.3.中药饮片,4.中药免检.5.中药小包装)")]
        public int? PrescriptionType { get; set; }
        /// <summary>
        /// 来源类型(1门诊，2.住院.3. 购药)
        /// </summary>
        [Display(Name="来源类型(1门诊，2.住院.3. 购药)")]
        public int? SourceType { get; set; }
        
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
        
        private string _customerOthterMessage = string.Empty;
        /// <summary>
        /// 客户(患者)其他信息
        /// </summary>
        [Display(Name="客户(患者)其他信息")]
        public string CustomerOthterMessage {
            get { return _customerOthterMessage == null ? string.Empty : _customerOthterMessage.Trim(); }
            set{ _customerOthterMessage=value;}
        }        
        /// <summary>
        /// 起始订单过期时间
        /// </summary>
        [Display( Name = "起始订单过期时间" )]
        public DateTime? BeginExpiryTime { get; set; }
        /// <summary>
        /// 结束订单过期时间
        /// </summary>
        [Display( Name = "结束订单过期时间" )]
        public DateTime? EndExpiryTime { get; set; }        
        /// <summary>
        /// 项目条数
        /// </summary>
        [Display(Name="项目条数")]
        public decimal? Count { get; set; }
        /// <summary>
        /// 项目金额
        /// </summary>
        [Display(Name="项目金额")]
        public decimal? Money { get; set; }
        /// <summary>
        /// 抵扣金额
        /// </summary>
        [Display(Name="抵扣金额")]
        public decimal? ReductionMoeny { get; set; }
        
        private string _userId = string.Empty;
        /// <summary>
        /// 开单人编号
        /// </summary>
        [Display(Name="开单人编号")]
        public string UserId {
            get { return _userId == null ? string.Empty : _userId.Trim(); }
            set{ _userId=value;}
        }        
        
        private string _userName = string.Empty;
        /// <summary>
        /// 开单人
        /// </summary>
        [Display(Name="开单人")]
        public string UserName {
            get { return _userName == null ? string.Empty : _userName.Trim(); }
            set{ _userName=value;}
        }        
        /// <summary>
        /// 起始开单时间
        /// </summary>
        [Display( Name = "起始开单时间" )]
        public DateTime? BeginOrderDate { get; set; }
        /// <summary>
        /// 结束开单时间
        /// </summary>
        [Display( Name = "结束开单时间" )]
        public DateTime? EndOrderDate { get; set; }        
        
        private string _departmentId = string.Empty;
        /// <summary>
        /// 科室编号
        /// </summary>
        [Display(Name="科室编号")]
        public string DepartmentId {
            get { return _departmentId == null ? string.Empty : _departmentId.Trim(); }
            set{ _departmentId=value;}
        }        
        
        private string _department = string.Empty;
        /// <summary>
        /// 科室
        /// </summary>
        [Display(Name="科室")]
        public string Department {
            get { return _department == null ? string.Empty : _department.Trim(); }
            set{ _department=value;}
        }        
        
        private string _accountingDepartmentId = string.Empty;
        /// <summary>
        /// 核算科室编号
        /// </summary>
        [Display(Name="核算科室编号")]
        public string AccountingDepartmentId {
            get { return _accountingDepartmentId == null ? string.Empty : _accountingDepartmentId.Trim(); }
            set{ _accountingDepartmentId=value;}
        }        
        
        private string _accountingDepartment = string.Empty;
        /// <summary>
        /// 核算科室
        /// </summary>
        [Display(Name="核算科室")]
        public string AccountingDepartment {
            get { return _accountingDepartment == null ? string.Empty : _accountingDepartment.Trim(); }
            set{ _accountingDepartment=value;}
        }        
        
        private string _accountingUserId = string.Empty;
        /// <summary>
        /// 核算人
        /// </summary>
        [Display(Name="核算人")]
        public string AccountingUserId {
            get { return _accountingUserId == null ? string.Empty : _accountingUserId.Trim(); }
            set{ _accountingUserId=value;}
        }        
        
        private string _accountingUserName = string.Empty;
        /// <summary>
        /// 核算人
        /// </summary>
        [Display(Name="核算人")]
        public string AccountingUserName {
            get { return _accountingUserName == null ? string.Empty : _accountingUserName.Trim(); }
            set{ _accountingUserName=value;}
        }        
        /// <summary>
        /// 起始核算时间
        /// </summary>
        [Display( Name = "起始核算时间" )]
        public DateTime? BeginAccountingDate { get; set; }
        /// <summary>
        /// 结束核算时间
        /// </summary>
        [Display( Name = "结束核算时间" )]
        public DateTime? EndAccountingDate { get; set; }        
        
        private string _remark = string.Empty;
        /// <summary>
        /// 备注说明
        /// </summary>
        [Display(Name="备注说明")]
        public string Remark {
            get { return _remark == null ? string.Empty : _remark.Trim(); }
            set{ _remark=value;}
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
        /// <summary>
        /// 是否可用
        /// </summary>
        [Display(Name="是否可用")]
        public sbyte? IsEnable { get; set; }
        /// <summary>
        /// 是否允许修改
        /// </summary>
        [Display(Name="是否允许修改")]
        public sbyte? IsModify { get; set; }
        
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
