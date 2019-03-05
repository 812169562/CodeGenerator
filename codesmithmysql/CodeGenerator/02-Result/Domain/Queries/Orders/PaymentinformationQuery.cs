using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Orders;


namespace Sand.Domain.Queries.Orders {
    /// <summary>
    /// 支付信息查询实体
    /// </summary>
    public class PaymentinformationQuery :  BaseQuery<Paymentinformation> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 支付编号
        /// </summary>
        [Display(Name="支付编号")]
        public string Id {
            get { return _id == null ? string.Empty : _id.Trim(); }
            set{ _id=value;}
        }        
        
        private string _flowNumber = string.Empty;
        /// <summary>
        /// 支付流水号
        /// </summary>
        [Display(Name="支付流水号")]
        public string FlowNumber {
            get { return _flowNumber == null ? string.Empty : _flowNumber.Trim(); }
            set{ _flowNumber=value;}
        }        
        
        private string _paySerialNumber = string.Empty;
        /// <summary>
        /// 第三方支付流水号
        /// </summary>
        [Display(Name="第三方支付流水号")]
        public string PaySerialNumber {
            get { return _paySerialNumber == null ? string.Empty : _paySerialNumber.Trim(); }
            set{ _paySerialNumber=value;}
        }        
        
        private string _payItemCode = string.Empty;
        /// <summary>
        /// 支付项目编号
        /// </summary>
        [Display(Name="支付项目编号")]
        public string PayItemCode {
            get { return _payItemCode == null ? string.Empty : _payItemCode.Trim(); }
            set{ _payItemCode=value;}
        }        
        
        private string _payItemName = string.Empty;
        /// <summary>
        /// 支付项目名称
        /// </summary>
        [Display(Name="支付项目名称")]
        public string PayItemName {
            get { return _payItemName == null ? string.Empty : _payItemName.Trim(); }
            set{ _payItemName=value;}
        }        
        
        private string _orderId = string.Empty;
        /// <summary>
        /// 订单号
        /// </summary>
        [Display(Name="订单号")]
        public string OrderId {
            get { return _orderId == null ? string.Empty : _orderId.Trim(); }
            set{ _orderId=value;}
        }        
        
        private string _noteCode = string.Empty;
        /// <summary>
        /// 发票编号
        /// </summary>
        [Display(Name="发票编号")]
        public string NoteCode {
            get { return _noteCode == null ? string.Empty : _noteCode.Trim(); }
            set{ _noteCode=value;}
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
        /// 支付总金额
        /// </summary>
        [Display(Name="支付总金额")]
        public decimal? PayMoeny { get; set; }
        /// <summary>
        /// 起始缴费时间
        /// </summary>
        [Display( Name = "起始缴费时间" )]
        public DateTime? BeginPayTime { get; set; }
        /// <summary>
        /// 结束缴费时间
        /// </summary>
        [Display( Name = "结束缴费时间" )]
        public DateTime? EndPayTime { get; set; }        
        /// <summary>
        /// 申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)
        /// </summary>
        [Display(Name="申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)")]
        public int? Type { get; set; }
        /// <summary>
        /// 来源类型(1门诊，2.住院.3. 购药)
        /// </summary>
        [Display(Name="来源类型(1门诊，2.住院.3. 购药)")]
        public int? SourceType { get; set; }
        /// <summary>
        /// 状态(-1退费，-2被退费,1.待缴费，2.已缴费，3.已核对)
        /// </summary>
        [Display(Name="状态(-1退费，-2被退费,1.待缴费，2.已缴费，3.已核对)")]
        public int? Status { get; set; }
        /// <summary>
        /// 支付总条数（单付金额需要除以此项）
        /// </summary>
        [Display(Name="支付总条数（单付金额需要除以此项）")]
        public int? PayCount { get; set; }
        /// <summary>
        /// 现金支付金额
        /// </summary>
        [Display(Name="现金支付金额")]
        public decimal? Cash { get; set; }
        /// <summary>
        /// 微信支付
        /// </summary>
        [Display(Name="微信支付")]
        public decimal? Weixin { get; set; }
        /// <summary>
        /// 支付宝支付
        /// </summary>
        [Display(Name="支付宝支付")]
        public decimal? Alipay { get; set; }
        /// <summary>
        /// 银行卡支付
        /// </summary>
        [Display(Name="银行卡支付")]
        public decimal? BankCard { get; set; }
        /// <summary>
        /// 银行卡类型
        /// </summary>
        [Display(Name="银行卡类型")]
        public int? CardType { get; set; }
        /// <summary>
        /// 医保支付
        /// </summary>
        [Display(Name="医保支付")]
        public decimal? YbMoney { get; set; }
        /// <summary>
        /// 医保类型
        /// </summary>
        [Display(Name="医保类型")]
        public int? YbType { get; set; }
        /// <summary>
        /// 抵扣金额
        /// </summary>
        [Display(Name="抵扣金额")]
        public decimal? DeductiblePayment { get; set; }
        /// <summary>
        /// 大学生减免金额
        /// </summary>
        [Display(Name="大学生减免金额")]
        public decimal? CollegeStudentPayment { get; set; }
        
        private string _tollCollectorUserId = string.Empty;
        /// <summary>
        /// 收费员编号
        /// </summary>
        [Display(Name="收费员编号")]
        public string TollCollectorUserId {
            get { return _tollCollectorUserId == null ? string.Empty : _tollCollectorUserId.Trim(); }
            set{ _tollCollectorUserId=value;}
        }        
        
        private string _tollCollectorUserName = string.Empty;
        /// <summary>
        /// 收费员
        /// </summary>
        [Display(Name="收费员")]
        public string TollCollectorUserName {
            get { return _tollCollectorUserName == null ? string.Empty : _tollCollectorUserName.Trim(); }
            set{ _tollCollectorUserName=value;}
        }        
        
        private string _refundUserId = string.Empty;
        /// <summary>
        /// 退费前收费员
        /// </summary>
        [Display(Name="退费前收费员")]
        public string RefundUserId {
            get { return _refundUserId == null ? string.Empty : _refundUserId.Trim(); }
            set{ _refundUserId=value;}
        }        
        
        private string _refundUserName = string.Empty;
        /// <summary>
        /// 退费前收费员
        /// </summary>
        [Display(Name="退费前收费员")]
        public string RefundUserName {
            get { return _refundUserName == null ? string.Empty : _refundUserName.Trim(); }
            set{ _refundUserName=value;}
        }        
        /// <summary>
        /// 起始退费前收费时间
        /// </summary>
        [Display( Name = "起始退费前收费时间" )]
        public DateTime? BeginOriginalDate { get; set; }
        /// <summary>
        /// 结束退费前收费时间
        /// </summary>
        [Display( Name = "结束退费前收费时间" )]
        public DateTime? EndOriginalDate { get; set; }        
        /// <summary>
        /// 抹零差价
        /// </summary>
        [Display(Name="抹零差价")]
        public decimal? MoenyDifference { get; set; }
        
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
        /// <summary>
        /// 起始开单时间
        /// </summary>
        [Display( Name = "起始开单时间" )]
        public DateTime? BeginOpenTime { get; set; }
        /// <summary>
        /// 结束开单时间
        /// </summary>
        [Display( Name = "结束开单时间" )]
        public DateTime? EndOpenTime { get; set; }        
        
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
        public DateTime? BeginAccountingTime { get; set; }
        /// <summary>
        /// 结束核算时间
        /// </summary>
        [Display( Name = "结束核算时间" )]
        public DateTime? EndAccountingTime { get; set; }        
        /// <summary>
        /// 起始结算时间
        /// </summary>
        [Display( Name = "起始结算时间" )]
        public DateTime? BeginSettlementTime { get; set; }
        /// <summary>
        /// 结束结算时间
        /// </summary>
        [Display( Name = "结束结算时间" )]
        public DateTime? EndSettlementTime { get; set; }        
        
        private string _remark = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name="备注")]
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
