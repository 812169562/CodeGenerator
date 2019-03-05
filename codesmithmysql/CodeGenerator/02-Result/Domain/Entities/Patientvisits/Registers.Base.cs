using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Patientvisits {
    /// <summary>
    /// 挂号信息
    /// </summary>
    [Description( "挂号信息" )]
    public partial class Registers : Entity,ISoftDelete {
        /// <summary>
        /// 初始化挂号信息
        /// </summary>
        public Registers(){
        }
        /// <summary>
        /// 挂号日期
        /// </summary>
        public DateTime? RegisterDate { get; set; }
        /// <summary>
        /// 挂号顺序号
        /// </summary>
        public int? RegisterNumber { get; set; }
        /// <summary>
        /// 挂号时间段 (1.上午，2.下午.3.夜晚)
        /// </summary>
        public int? TimeSlot { get; set; }
        /// <summary>
        /// 患者类型
        /// </summary>
        public int? PatType { get; set; }
        /// <summary>
        /// 患者编号
        /// </summary>
        [StringLength( 120, ErrorMessage = "患者编号输入过长，不能超过120位" )]
        public string UserId { get; set; }
        /// <summary>
        /// 患者姓名
        /// </summary>
        [StringLength( 400, ErrorMessage = "患者姓名输入过长，不能超过400位" )]
        public string UserName { get; set; }
        /// <summary>
        /// 患者生日
        /// </summary>
        public DateTime? UserBorn { get; set; }
        /// <summary>
        /// 患者电话号码
        /// </summary>
        [StringLength( 72, ErrorMessage = "患者电话号码输入过长，不能超过72位" )]
        public string UserPhone { get; set; }
        /// <summary>
        /// 患者地址
        /// </summary>
        [StringLength( 1200, ErrorMessage = "患者地址输入过长，不能超过1200位" )]
        public string UserAddress { get; set; }
        /// <summary>
        /// 患者性别
        /// </summary>
        [StringLength( 20, ErrorMessage = "患者性别输入过长，不能超过20位" )]
        public string UserSex { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        [StringLength( 144, ErrorMessage = "科室输入过长，不能超过144位" )]
        public string DepartmentId { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        [StringLength( 400, ErrorMessage = "科室输入过长，不能超过400位" )]
        public string Department { get; set; }
        /// <summary>
        /// 挂号医生
        /// </summary>
        [StringLength( 144, ErrorMessage = "挂号医生输入过长，不能超过144位" )]
        public string DoctorId { get; set; }
        /// <summary>
        /// 挂号姓名
        /// </summary>
        [StringLength( 400, ErrorMessage = "挂号姓名输入过长，不能超过400位" )]
        public string DoctorName { get; set; }
        /// <summary>
        /// 患者来源 (0.正常挂号，1.预约挂号)
        /// </summary>
        public int? UserFrom { get; set; }
        /// <summary>
        /// 接诊日期
        /// </summary>
        public DateTime? ReceiveDate { get; set; }
        /// <summary>
        /// 接诊医生
        /// </summary>
        [StringLength( 144, ErrorMessage = "接诊医生输入过长，不能超过144位" )]
        public string ReceiveDoctorId { get; set; }
        /// <summary>
        /// 接诊医生
        /// </summary>
        [StringLength( 200, ErrorMessage = "接诊医生输入过长，不能超过200位" )]
        public string ReceiveDoctorName { get; set; }
        /// <summary>
        /// 挂号类型(0,普通挂号，1.急诊挂号，2.便民门诊)
        /// </summary>
        public int? RegisterType { get; set; }
        /// <summary>
        /// 诊疗类型(0.初诊,1复诊)
        /// </summary>
        public int? TreatmentType { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime? PayDate { get; set; }
        /// <summary>
        /// 挂号金额=检查费+就诊费=社保支付+现金支付+会员卡支付+银行卡支付+支付宝+微信
        /// </summary>
        public decimal? Money { get; set; }
        /// <summary>
        /// 检查费金额
        /// </summary>
        public decimal? CheckMoney { get; set; }
        /// <summary>
        /// 挂号费金额
        /// </summary>
        public decimal? RegisterMoney { get; set; }
        /// <summary>
        /// 社保支付金额
        /// </summary>
        public decimal? SbMoney { get; set; }
        /// <summary>
        /// 现金支付金额
        /// </summary>
        public decimal? CashMoney { get; set; }
        /// <summary>
        /// 会员卡支付金额
        /// </summary>
        public decimal? CardMoney { get; set; }
        /// <summary>
        /// 银行支付金额
        /// </summary>
        public decimal? BankMoney { get; set; }
        /// <summary>
        /// 微信支付金额
        /// </summary>
        public decimal? WeiXinMoeny { get; set; }
        /// <summary>
        /// 支付宝支付金额
        /// </summary>
        public decimal? AlipayMoeny { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        [Required(ErrorMessage = "支付状态不能为空")]
        public int PaymentStatus { get; set; }
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