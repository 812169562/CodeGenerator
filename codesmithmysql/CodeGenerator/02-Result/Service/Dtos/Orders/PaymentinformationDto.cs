using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Orders {
    /// <summary>
    /// 支付信息数据传输对象
    /// </summary>
    [DataContract]
    public class PaymentinformationDto : BaseDto {
        /// <summary>
        /// 支付流水号
        /// </summary>
        [Required(ErrorMessage = "支付流水号不能为空")]
        [StringLength( 108, ErrorMessage = "支付流水号输入过长，不能超过108位" )]
        [Display( Name = "支付流水号" )]
        [DataMember]
        public string FlowNumber { get; set; }
        
        /// <summary>
        /// 第三方支付流水号
        /// </summary>
        [StringLength( 108, ErrorMessage = "第三方支付流水号输入过长，不能超过108位" )]
        [Display( Name = "第三方支付流水号" )]
        [DataMember]
        public string PaySerialNumber { get; set; }
        
        /// <summary>
        /// 支付项目编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "支付项目编号输入过长，不能超过108位" )]
        [Display( Name = "支付项目编号" )]
        [DataMember]
        public string PayItemCode { get; set; }
        
        /// <summary>
        /// 支付项目名称
        /// </summary>
        [StringLength( 450, ErrorMessage = "支付项目名称输入过长，不能超过450位" )]
        [Display( Name = "支付项目名称" )]
        [DataMember]
        public string PayItemName { get; set; }
        
        /// <summary>
        /// 订单号
        /// </summary>
        [Required(ErrorMessage = "订单号不能为空")]
        [StringLength( 108, ErrorMessage = "订单号输入过长，不能超过108位" )]
        [Display( Name = "订单号" )]
        [DataMember]
        public string OrderId { get; set; }
        
        /// <summary>
        /// 发票编号
        /// </summary>
        [Required(ErrorMessage = "发票编号不能为空")]
        [StringLength( 75, ErrorMessage = "发票编号输入过长，不能超过75位" )]
        [Display( Name = "发票编号" )]
        [DataMember]
        public string NoteCode { get; set; }
        
        /// <summary>
        /// 客户(患者)编号
        /// </summary>
        [Required(ErrorMessage = "客户(患者)编号不能为空")]
        [StringLength( 108, ErrorMessage = "客户(患者)编号输入过长，不能超过108位" )]
        [Display( Name = "客户(患者)编号" )]
        [DataMember]
        public string CustomertId { get; set; }
        
        /// <summary>
        /// 客户(患者)姓名
        /// </summary>
        [Required(ErrorMessage = "客户(患者)姓名不能为空")]
        [StringLength( 300, ErrorMessage = "客户(患者)姓名输入过长，不能超过300位" )]
        [Display( Name = "客户(患者)姓名" )]
        [DataMember]
        public string CustomerName { get; set; }
        
        /// <summary>
        /// 客户(患者)其他信息
        /// </summary>
        [Required(ErrorMessage = "客户(患者)其他信息不能为空")]
        [StringLength( 65535, ErrorMessage = "客户(患者)其他信息输入过长，不能超过65535位" )]
        [Display( Name = "客户(患者)其他信息" )]
        [DataMember]
        public string CustomerOthterMessage { get; set; }
        
        /// <summary>
        /// 支付总金额
        /// </summary>
        [Required(ErrorMessage = "支付总金额不能为空")]
        [Display( Name = "支付总金额" )]
        [DataMember]
        public decimal PayMoeny { get; set; }
        
        /// <summary>
        /// 缴费时间
        /// </summary>
        [Display( Name = "缴费时间" )]
        [DataMember]
        public DateTime? PayTime { get; set; }
        
        /// <summary>
        /// 申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)
        /// </summary>
        [Required(ErrorMessage = "申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)不能为空")]
        [Display( Name = "申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)" )]
        [DataMember]
        public int Type { get; set; }
        
        /// <summary>
        /// 来源类型(1门诊，2.住院.3. 购药)
        /// </summary>
        [Display( Name = "来源类型(1门诊，2.住院.3. 购药)" )]
        [DataMember]
        public int? SourceType { get; set; }
        
        /// <summary>
        /// 支付总条数（单付金额需要除以此项）
        /// </summary>
        [Required(ErrorMessage = "支付总条数（单付金额需要除以此项）不能为空")]
        [Display( Name = "支付总条数（单付金额需要除以此项）" )]
        [DataMember]
        public int PayCount { get; set; }
        
        /// <summary>
        /// 现金支付金额
        /// </summary>
        [Required(ErrorMessage = "现金支付金额不能为空")]
        [Display( Name = "现金支付金额" )]
        [DataMember]
        public decimal Cash { get; set; }
        
        /// <summary>
        /// 微信支付
        /// </summary>
        [Required(ErrorMessage = "微信支付不能为空")]
        [Display( Name = "微信支付" )]
        [DataMember]
        public decimal Weixin { get; set; }
        
        /// <summary>
        /// 支付宝支付
        /// </summary>
        [Required(ErrorMessage = "支付宝支付不能为空")]
        [Display( Name = "支付宝支付" )]
        [DataMember]
        public decimal Alipay { get; set; }
        
        /// <summary>
        /// 银行卡支付
        /// </summary>
        [Required(ErrorMessage = "银行卡支付不能为空")]
        [Display( Name = "银行卡支付" )]
        [DataMember]
        public decimal BankCard { get; set; }
        
        /// <summary>
        /// 银行卡类型
        /// </summary>
        [Required(ErrorMessage = "银行卡类型不能为空")]
        [Display( Name = "银行卡类型" )]
        [DataMember]
        public int CardType { get; set; }
        
        /// <summary>
        /// 医保支付
        /// </summary>
        [Required(ErrorMessage = "医保支付不能为空")]
        [Display( Name = "医保支付" )]
        [DataMember]
        public decimal YbMoney { get; set; }
        
        /// <summary>
        /// 医保类型
        /// </summary>
        [Required(ErrorMessage = "医保类型不能为空")]
        [Display( Name = "医保类型" )]
        [DataMember]
        public int YbType { get; set; }
        
        /// <summary>
        /// 抵扣金额
        /// </summary>
        [Required(ErrorMessage = "抵扣金额不能为空")]
        [Display( Name = "抵扣金额" )]
        [DataMember]
        public decimal DeductiblePayment { get; set; }
        
        /// <summary>
        /// 大学生减免金额
        /// </summary>
        [Required(ErrorMessage = "大学生减免金额不能为空")]
        [Display( Name = "大学生减免金额" )]
        [DataMember]
        public decimal CollegeStudentPayment { get; set; }
        
        /// <summary>
        /// 收费员编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "收费员编号输入过长，不能超过108位" )]
        [Display( Name = "收费员编号" )]
        [DataMember]
        public string TollCollectorUserId { get; set; }
        
        /// <summary>
        /// 收费员
        /// </summary>
        [StringLength( 150, ErrorMessage = "收费员输入过长，不能超过150位" )]
        [Display( Name = "收费员" )]
        [DataMember]
        public string TollCollectorUserName { get; set; }
        
        /// <summary>
        /// 退费前收费员
        /// </summary>
        [StringLength( 108, ErrorMessage = "退费前收费员输入过长，不能超过108位" )]
        [Display( Name = "退费前收费员" )]
        [DataMember]
        public string RefundUserId { get; set; }
        
        /// <summary>
        /// 退费前收费员
        /// </summary>
        [StringLength( 300, ErrorMessage = "退费前收费员输入过长，不能超过300位" )]
        [Display( Name = "退费前收费员" )]
        [DataMember]
        public string RefundUserName { get; set; }
        
        /// <summary>
        /// 退费前收费时间
        /// </summary>
        [Display( Name = "退费前收费时间" )]
        [DataMember]
        public DateTime? OriginalDate { get; set; }
        
        /// <summary>
        /// 抹零差价
        /// </summary>
        [Display( Name = "抹零差价" )]
        [DataMember]
        public decimal? MoenyDifference { get; set; }
        
        /// <summary>
        /// 开单人编号
        /// </summary>
        [Required(ErrorMessage = "开单人编号不能为空")]
        [StringLength( 108, ErrorMessage = "开单人编号输入过长，不能超过108位" )]
        [Display( Name = "开单人编号" )]
        [DataMember]
        public string UserId { get; set; }
        
        /// <summary>
        /// 开单人
        /// </summary>
        [Required(ErrorMessage = "开单人不能为空")]
        [StringLength( 300, ErrorMessage = "开单人输入过长，不能超过300位" )]
        [Display( Name = "开单人" )]
        [DataMember]
        public string UserName { get; set; }
        
        /// <summary>
        /// 开单时间
        /// </summary>
        [Required(ErrorMessage = "开单时间不能为空")]
        [Display( Name = "开单时间" )]
        [DataMember]
        public DateTime OrderDate { get; set; }
        
        /// <summary>
        /// 科室编号
        /// </summary>
        [Required(ErrorMessage = "科室编号不能为空")]
        [StringLength( 108, ErrorMessage = "科室编号输入过长，不能超过108位" )]
        [Display( Name = "科室编号" )]
        [DataMember]
        public string DepartmentId { get; set; }
        
        /// <summary>
        /// 科室
        /// </summary>
        [Required(ErrorMessage = "科室不能为空")]
        [StringLength( 300, ErrorMessage = "科室输入过长，不能超过300位" )]
        [Display( Name = "科室" )]
        [DataMember]
        public string Department { get; set; }
        
        /// <summary>
        /// 开单时间
        /// </summary>
        [Display( Name = "开单时间" )]
        [DataMember]
        public DateTime? OpenTime { get; set; }
        
        /// <summary>
        /// 核算科室编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "核算科室编号输入过长，不能超过108位" )]
        [Display( Name = "核算科室编号" )]
        [DataMember]
        public string AccountingDepartmentId { get; set; }
        
        /// <summary>
        /// 核算科室
        /// </summary>
        [StringLength( 300, ErrorMessage = "核算科室输入过长，不能超过300位" )]
        [Display( Name = "核算科室" )]
        [DataMember]
        public string AccountingDepartment { get; set; }
        
        /// <summary>
        /// 核算人
        /// </summary>
        [StringLength( 108, ErrorMessage = "核算人输入过长，不能超过108位" )]
        [Display( Name = "核算人" )]
        [DataMember]
        public string AccountingUserId { get; set; }
        
        /// <summary>
        /// 核算人
        /// </summary>
        [StringLength( 300, ErrorMessage = "核算人输入过长，不能超过300位" )]
        [Display( Name = "核算人" )]
        [DataMember]
        public string AccountingUserName { get; set; }
        
        /// <summary>
        /// 核算时间
        /// </summary>
        [Display( Name = "核算时间" )]
        [DataMember]
        public DateTime? AccountingTime { get; set; }
        
        /// <summary>
        /// 结算时间
        /// </summary>
        [Display( Name = "结算时间" )]
        [DataMember]
        public DateTime? SettlementTime { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 1800, ErrorMessage = "备注输入过长，不能超过1800位" )]
        [Display( Name = "备注" )]
        [DataMember]
        public string Remark { get; set; }
        
    }
}
