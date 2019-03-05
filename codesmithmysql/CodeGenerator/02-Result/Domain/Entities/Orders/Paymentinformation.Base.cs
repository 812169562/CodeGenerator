using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Orders {
    /// <summary>
    /// 支付信息
    /// </summary>
    [Description( "支付信息" )]
    public partial class Paymentinformation : Entity,ISoftDelete {
        /// <summary>
        /// 初始化支付信息
        /// </summary>
        public Paymentinformation(){
        }
        /// <summary>
        /// 支付流水号
        /// </summary>
        [Required(ErrorMessage = "支付流水号不能为空")]
        [StringLength( 108, ErrorMessage = "支付流水号输入过长，不能超过108位" )]
        public string FlowNumber { get; set; }
        /// <summary>
        /// 第三方支付流水号
        /// </summary>
        [StringLength( 108, ErrorMessage = "第三方支付流水号输入过长，不能超过108位" )]
        public string PaySerialNumber { get; set; }
        /// <summary>
        /// 支付项目编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "支付项目编号输入过长，不能超过108位" )]
        public string PayItemCode { get; set; }
        /// <summary>
        /// 支付项目名称
        /// </summary>
        [StringLength( 450, ErrorMessage = "支付项目名称输入过长，不能超过450位" )]
        public string PayItemName { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [Required(ErrorMessage = "订单号不能为空")]
        [StringLength( 108, ErrorMessage = "订单号输入过长，不能超过108位" )]
        public string OrderId { get; set; }
        /// <summary>
        /// 发票编号
        /// </summary>
        [Required(ErrorMessage = "发票编号不能为空")]
        [StringLength( 75, ErrorMessage = "发票编号输入过长，不能超过75位" )]
        public string NoteCode { get; set; }
        /// <summary>
        /// 客户(患者)编号
        /// </summary>
        [Required(ErrorMessage = "客户(患者)编号不能为空")]
        [StringLength( 108, ErrorMessage = "客户(患者)编号输入过长，不能超过108位" )]
        public string CustomertId { get; set; }
        /// <summary>
        /// 客户(患者)姓名
        /// </summary>
        [Required(ErrorMessage = "客户(患者)姓名不能为空")]
        [StringLength( 300, ErrorMessage = "客户(患者)姓名输入过长，不能超过300位" )]
        public string CustomerName { get; set; }
        /// <summary>
        /// 客户(患者)其他信息
        /// </summary>
        [Required(ErrorMessage = "客户(患者)其他信息不能为空")]
        [StringLength( 65535, ErrorMessage = "客户(患者)其他信息输入过长，不能超过65535位" )]
        public string CustomerOthterMessage { get; set; }
        /// <summary>
        /// 支付总金额
        /// </summary>
        [Required(ErrorMessage = "支付总金额不能为空")]
        public decimal PayMoeny { get; set; }
        /// <summary>
        /// 缴费时间
        /// </summary>
        public DateTime? PayTime { get; set; }
        /// <summary>
        /// 申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)
        /// </summary>
        [Required(ErrorMessage = "申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 来源类型(1门诊，2.住院.3. 购药)
        /// </summary>
        public int? SourceType { get; set; }
        /// <summary>
        /// 支付总条数（单付金额需要除以此项）
        /// </summary>
        [Required(ErrorMessage = "支付总条数（单付金额需要除以此项）不能为空")]
        public int PayCount { get; set; }
        /// <summary>
        /// 现金支付金额
        /// </summary>
        [Required(ErrorMessage = "现金支付金额不能为空")]
        public decimal Cash { get; set; }
        /// <summary>
        /// 微信支付
        /// </summary>
        [Required(ErrorMessage = "微信支付不能为空")]
        public decimal Weixin { get; set; }
        /// <summary>
        /// 支付宝支付
        /// </summary>
        [Required(ErrorMessage = "支付宝支付不能为空")]
        public decimal Alipay { get; set; }
        /// <summary>
        /// 银行卡支付
        /// </summary>
        [Required(ErrorMessage = "银行卡支付不能为空")]
        public decimal BankCard { get; set; }
        /// <summary>
        /// 银行卡类型
        /// </summary>
        [Required(ErrorMessage = "银行卡类型不能为空")]
        public int CardType { get; set; }
        /// <summary>
        /// 医保支付
        /// </summary>
        [Required(ErrorMessage = "医保支付不能为空")]
        public decimal YbMoney { get; set; }
        /// <summary>
        /// 医保类型
        /// </summary>
        [Required(ErrorMessage = "医保类型不能为空")]
        public int YbType { get; set; }
        /// <summary>
        /// 抵扣金额
        /// </summary>
        [Required(ErrorMessage = "抵扣金额不能为空")]
        public decimal DeductiblePayment { get; set; }
        /// <summary>
        /// 大学生减免金额
        /// </summary>
        [Required(ErrorMessage = "大学生减免金额不能为空")]
        public decimal CollegeStudentPayment { get; set; }
        /// <summary>
        /// 收费员编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "收费员编号输入过长，不能超过108位" )]
        public string TollCollectorUserId { get; set; }
        /// <summary>
        /// 收费员
        /// </summary>
        [StringLength( 150, ErrorMessage = "收费员输入过长，不能超过150位" )]
        public string TollCollectorUserName { get; set; }
        /// <summary>
        /// 退费前收费员
        /// </summary>
        [StringLength( 108, ErrorMessage = "退费前收费员输入过长，不能超过108位" )]
        public string RefundUserId { get; set; }
        /// <summary>
        /// 退费前收费员
        /// </summary>
        [StringLength( 300, ErrorMessage = "退费前收费员输入过长，不能超过300位" )]
        public string RefundUserName { get; set; }
        /// <summary>
        /// 退费前收费时间
        /// </summary>
        public DateTime? OriginalDate { get; set; }
        /// <summary>
        /// 抹零差价
        /// </summary>
        public decimal? MoenyDifference { get; set; }
        /// <summary>
        /// 开单人编号
        /// </summary>
        [Required(ErrorMessage = "开单人编号不能为空")]
        [StringLength( 108, ErrorMessage = "开单人编号输入过长，不能超过108位" )]
        public string UserId { get; set; }
        /// <summary>
        /// 开单人
        /// </summary>
        [Required(ErrorMessage = "开单人不能为空")]
        [StringLength( 300, ErrorMessage = "开单人输入过长，不能超过300位" )]
        public string UserName { get; set; }
        /// <summary>
        /// 开单时间
        /// </summary>
        [Required(ErrorMessage = "开单时间不能为空")]
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// 科室编号
        /// </summary>
        [Required(ErrorMessage = "科室编号不能为空")]
        [StringLength( 108, ErrorMessage = "科室编号输入过长，不能超过108位" )]
        public string DepartmentId { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        [Required(ErrorMessage = "科室不能为空")]
        [StringLength( 300, ErrorMessage = "科室输入过长，不能超过300位" )]
        public string Department { get; set; }
        /// <summary>
        /// 开单时间
        /// </summary>
        public DateTime? OpenTime { get; set; }
        /// <summary>
        /// 核算科室编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "核算科室编号输入过长，不能超过108位" )]
        public string AccountingDepartmentId { get; set; }
        /// <summary>
        /// 核算科室
        /// </summary>
        [StringLength( 300, ErrorMessage = "核算科室输入过长，不能超过300位" )]
        public string AccountingDepartment { get; set; }
        /// <summary>
        /// 核算人
        /// </summary>
        [StringLength( 108, ErrorMessage = "核算人输入过长，不能超过108位" )]
        public string AccountingUserId { get; set; }
        /// <summary>
        /// 核算人
        /// </summary>
        [StringLength( 300, ErrorMessage = "核算人输入过长，不能超过300位" )]
        public string AccountingUserName { get; set; }
        /// <summary>
        /// 核算时间
        /// </summary>
        public DateTime? AccountingTime { get; set; }
        /// <summary>
        /// 结算时间
        /// </summary>
        public DateTime? SettlementTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 1800, ErrorMessage = "备注输入过长，不能超过1800位" )]
        public string Remark { get; set; }
         /// <summary>
        /// 删除标志
        /// </summary>
        [Required(ErrorMessage = "删除标志不能为空")]
        public bool IsDeleted { get; set; }
        
        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init()
        {
            this.Id = Uuid.Next();
            base.Init();
        }
 
        /// <summary>
        /// 加载
        /// </summary>
        public override void Load(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}