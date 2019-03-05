using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Patientvisits {
    /// <summary>
    /// 挂号信息数据传输对象
    /// </summary>
    [DataContract]
    public class RegistersDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 挂号日期
        /// </summary>
        [Display( Name = "挂号日期" )]
        [DataMember]
        public DateTime? RegisterDate { get; set; }
        
        /// <summary>
        /// 挂号顺序号
        /// </summary>
        [Display( Name = "挂号顺序号" )]
        [DataMember]
        public int? RegisterNumber { get; set; }
        
        /// <summary>
        /// 挂号时间段 (1.上午，2.下午.3.夜晚)
        /// </summary>
        [Display( Name = "挂号时间段 (1.上午，2.下午.3.夜晚)" )]
        [DataMember]
        public int? TimeSlot { get; set; }
        
        /// <summary>
        /// 患者类型
        /// </summary>
        [Display( Name = "患者类型" )]
        [DataMember]
        public int? PatType { get; set; }
        
        /// <summary>
        /// 患者编号
        /// </summary>
        [StringLength( 120, ErrorMessage = "患者编号输入过长，不能超过120位" )]
        [Display( Name = "患者编号" )]
        [DataMember]
        public string UserId { get; set; }
        
        /// <summary>
        /// 患者姓名
        /// </summary>
        [StringLength( 400, ErrorMessage = "患者姓名输入过长，不能超过400位" )]
        [Display( Name = "患者姓名" )]
        [DataMember]
        public string UserName { get; set; }
        
        /// <summary>
        /// 患者生日
        /// </summary>
        [Display( Name = "患者生日" )]
        [DataMember]
        public DateTime? UserBorn { get; set; }
        
        /// <summary>
        /// 患者电话号码
        /// </summary>
        [StringLength( 72, ErrorMessage = "患者电话号码输入过长，不能超过72位" )]
        [Display( Name = "患者电话号码" )]
        [DataMember]
        public string UserPhone { get; set; }
        
        /// <summary>
        /// 患者地址
        /// </summary>
        [StringLength( 1200, ErrorMessage = "患者地址输入过长，不能超过1200位" )]
        [Display( Name = "患者地址" )]
        [DataMember]
        public string UserAddress { get; set; }
        
        /// <summary>
        /// 患者性别
        /// </summary>
        [StringLength( 20, ErrorMessage = "患者性别输入过长，不能超过20位" )]
        [Display( Name = "患者性别" )]
        [DataMember]
        public string UserSex { get; set; }
        
        /// <summary>
        /// 科室
        /// </summary>
        [StringLength( 144, ErrorMessage = "科室输入过长，不能超过144位" )]
        [Display( Name = "科室" )]
        [DataMember]
        public string DepartmentId { get; set; }
        
        /// <summary>
        /// 科室
        /// </summary>
        [StringLength( 400, ErrorMessage = "科室输入过长，不能超过400位" )]
        [Display( Name = "科室" )]
        [DataMember]
        public string Department { get; set; }
        
        /// <summary>
        /// 挂号医生
        /// </summary>
        [StringLength( 144, ErrorMessage = "挂号医生输入过长，不能超过144位" )]
        [Display( Name = "挂号医生" )]
        [DataMember]
        public string DoctorId { get; set; }
        
        /// <summary>
        /// 挂号姓名
        /// </summary>
        [StringLength( 400, ErrorMessage = "挂号姓名输入过长，不能超过400位" )]
        [Display( Name = "挂号姓名" )]
        [DataMember]
        public string DoctorName { get; set; }
        
        /// <summary>
        /// 患者来源 (0.正常挂号，1.预约挂号)
        /// </summary>
        [Display( Name = "患者来源 (0.正常挂号，1.预约挂号)" )]
        [DataMember]
        public int? UserFrom { get; set; }
        
        /// <summary>
        /// 接诊日期
        /// </summary>
        [Display( Name = "接诊日期" )]
        [DataMember]
        public DateTime? ReceiveDate { get; set; }
        
        /// <summary>
        /// 接诊医生
        /// </summary>
        [StringLength( 144, ErrorMessage = "接诊医生输入过长，不能超过144位" )]
        [Display( Name = "接诊医生" )]
        [DataMember]
        public string ReceiveDoctorId { get; set; }
        
        /// <summary>
        /// 接诊医生
        /// </summary>
        [StringLength( 200, ErrorMessage = "接诊医生输入过长，不能超过200位" )]
        [Display( Name = "接诊医生" )]
        [DataMember]
        public string ReceiveDoctorName { get; set; }
        
        /// <summary>
        /// 挂号类型(0,普通挂号，1.急诊挂号，2.便民门诊)
        /// </summary>
        [Display( Name = "挂号类型(0,普通挂号，1.急诊挂号，2.便民门诊)" )]
        [DataMember]
        public int? RegisterType { get; set; }
        
        /// <summary>
        /// 诊疗类型(0.初诊,1复诊)
        /// </summary>
        [Display( Name = "诊疗类型(0.初诊,1复诊)" )]
        [DataMember]
        public int? TreatmentType { get; set; }
        
        /// <summary>
        /// 支付时间
        /// </summary>
        [Display( Name = "支付时间" )]
        [DataMember]
        public DateTime? PayDate { get; set; }
        
        /// <summary>
        /// 挂号金额=检查费+就诊费=社保支付+现金支付+会员卡支付+银行卡支付+支付宝+微信
        /// </summary>
        [Display( Name = "挂号金额=检查费+就诊费=社保支付+现金支付+会员卡支付+银行卡支付+支付宝+微信" )]
        [DataMember]
        public decimal? Money { get; set; }
        
        /// <summary>
        /// 检查费金额
        /// </summary>
        [Display( Name = "检查费金额" )]
        [DataMember]
        public decimal? CheckMoney { get; set; }
        
        /// <summary>
        /// 挂号费金额
        /// </summary>
        [Display( Name = "挂号费金额" )]
        [DataMember]
        public decimal? RegisterMoney { get; set; }
        
        /// <summary>
        /// 社保支付金额
        /// </summary>
        [Display( Name = "社保支付金额" )]
        [DataMember]
        public decimal? SbMoney { get; set; }
        
        /// <summary>
        /// 现金支付金额
        /// </summary>
        [Display( Name = "现金支付金额" )]
        [DataMember]
        public decimal? CashMoney { get; set; }
        
        /// <summary>
        /// 会员卡支付金额
        /// </summary>
        [Display( Name = "会员卡支付金额" )]
        [DataMember]
        public decimal? CardMoney { get; set; }
        
        /// <summary>
        /// 银行支付金额
        /// </summary>
        [Display( Name = "银行支付金额" )]
        [DataMember]
        public decimal? BankMoney { get; set; }
        
        /// <summary>
        /// 微信支付金额
        /// </summary>
        [Display( Name = "微信支付金额" )]
        [DataMember]
        public decimal? WeiXinMoeny { get; set; }
        
        /// <summary>
        /// 支付宝支付金额
        /// </summary>
        [Display( Name = "支付宝支付金额" )]
        [DataMember]
        public decimal? AlipayMoeny { get; set; }
        
        /// <summary>
        /// 支付状态
        /// </summary>
        [Required(ErrorMessage = "支付状态不能为空")]
        [Display( Name = "支付状态" )]
        [DataMember]
        public int PaymentStatus { get; set; }
        
    }
}
