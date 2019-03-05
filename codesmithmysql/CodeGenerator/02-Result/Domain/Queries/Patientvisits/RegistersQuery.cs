using System;
using System.ComponentModel.DataAnnotations;
using Sand.Domain.Query;
using Sand.Domain.Entities.Patientvisits;


namespace Sand.Domain.Queries.Patientvisits {
    /// <summary>
    /// 挂号信息查询实体
    /// </summary>
    public class RegistersQuery :  BaseQuery<Registers> {
        
        private string _id = string.Empty;
        /// <summary>
        /// 挂号编号
        /// </summary>
        [Display(Name="挂号编号")]
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
        /// <summary>
        /// 起始挂号日期
        /// </summary>
        [Display( Name = "起始挂号日期" )]
        public DateTime? BeginRegisterDate { get; set; }
        /// <summary>
        /// 结束挂号日期
        /// </summary>
        [Display( Name = "结束挂号日期" )]
        public DateTime? EndRegisterDate { get; set; }        
        /// <summary>
        /// 挂号顺序号
        /// </summary>
        [Display(Name="挂号顺序号")]
        public int? RegisterNumber { get; set; }
        /// <summary>
        /// 挂号时间段 (1.上午，2.下午.3.夜晚)
        /// </summary>
        [Display(Name="挂号时间段 (1.上午，2.下午.3.夜晚)")]
        public int? TimeSlot { get; set; }
        /// <summary>
        /// 患者类型
        /// </summary>
        [Display(Name="患者类型")]
        public int? PatType { get; set; }
        
        private string _userId = string.Empty;
        /// <summary>
        /// 患者编号
        /// </summary>
        [Display(Name="患者编号")]
        public string UserId {
            get { return _userId == null ? string.Empty : _userId.Trim(); }
            set{ _userId=value;}
        }        
        
        private string _userName = string.Empty;
        /// <summary>
        /// 患者姓名
        /// </summary>
        [Display(Name="患者姓名")]
        public string UserName {
            get { return _userName == null ? string.Empty : _userName.Trim(); }
            set{ _userName=value;}
        }        
        /// <summary>
        /// 起始患者生日
        /// </summary>
        [Display( Name = "起始患者生日" )]
        public DateTime? BeginUserBorn { get; set; }
        /// <summary>
        /// 结束患者生日
        /// </summary>
        [Display( Name = "结束患者生日" )]
        public DateTime? EndUserBorn { get; set; }        
        
        private string _userPhone = string.Empty;
        /// <summary>
        /// 患者电话号码
        /// </summary>
        [Display(Name="患者电话号码")]
        public string UserPhone {
            get { return _userPhone == null ? string.Empty : _userPhone.Trim(); }
            set{ _userPhone=value;}
        }        
        
        private string _userAddress = string.Empty;
        /// <summary>
        /// 患者地址
        /// </summary>
        [Display(Name="患者地址")]
        public string UserAddress {
            get { return _userAddress == null ? string.Empty : _userAddress.Trim(); }
            set{ _userAddress=value;}
        }        
        
        private string _userSex = string.Empty;
        /// <summary>
        /// 患者性别
        /// </summary>
        [Display(Name="患者性别")]
        public string UserSex {
            get { return _userSex == null ? string.Empty : _userSex.Trim(); }
            set{ _userSex=value;}
        }        
        
        private string _departmentId = string.Empty;
        /// <summary>
        /// 科室
        /// </summary>
        [Display(Name="科室")]
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
        
        private string _doctorId = string.Empty;
        /// <summary>
        /// 挂号医生
        /// </summary>
        [Display(Name="挂号医生")]
        public string DoctorId {
            get { return _doctorId == null ? string.Empty : _doctorId.Trim(); }
            set{ _doctorId=value;}
        }        
        
        private string _doctorName = string.Empty;
        /// <summary>
        /// 挂号姓名
        /// </summary>
        [Display(Name="挂号姓名")]
        public string DoctorName {
            get { return _doctorName == null ? string.Empty : _doctorName.Trim(); }
            set{ _doctorName=value;}
        }        
        /// <summary>
        /// 患者来源 (0.正常挂号，1.预约挂号)
        /// </summary>
        [Display(Name="患者来源 (0.正常挂号，1.预约挂号)")]
        public int? UserFrom { get; set; }
        /// <summary>
        /// 起始接诊日期
        /// </summary>
        [Display( Name = "起始接诊日期" )]
        public DateTime? BeginReceiveDate { get; set; }
        /// <summary>
        /// 结束接诊日期
        /// </summary>
        [Display( Name = "结束接诊日期" )]
        public DateTime? EndReceiveDate { get; set; }        
        
        private string _receiveDoctorId = string.Empty;
        /// <summary>
        /// 接诊医生
        /// </summary>
        [Display(Name="接诊医生")]
        public string ReceiveDoctorId {
            get { return _receiveDoctorId == null ? string.Empty : _receiveDoctorId.Trim(); }
            set{ _receiveDoctorId=value;}
        }        
        
        private string _receiveDoctorName = string.Empty;
        /// <summary>
        /// 接诊医生
        /// </summary>
        [Display(Name="接诊医生")]
        public string ReceiveDoctorName {
            get { return _receiveDoctorName == null ? string.Empty : _receiveDoctorName.Trim(); }
            set{ _receiveDoctorName=value;}
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
        /// 状态(-1已退号,0.未就诊，1.已就诊，2.就诊完成)
        /// </summary>
        [Display(Name="状态(-1已退号,0.未就诊，1.已就诊，2.就诊完成)")]
        public int? Status { get; set; }
        /// <summary>
        /// 挂号类型(0,普通挂号，1.急诊挂号，2.便民门诊)
        /// </summary>
        [Display(Name="挂号类型(0,普通挂号，1.急诊挂号，2.便民门诊)")]
        public int? RegisterType { get; set; }
        /// <summary>
        /// 诊疗类型(0.初诊,1复诊)
        /// </summary>
        [Display(Name="诊疗类型(0.初诊,1复诊)")]
        public int? TreatmentType { get; set; }
        /// <summary>
        /// 起始支付时间
        /// </summary>
        [Display( Name = "起始支付时间" )]
        public DateTime? BeginPayDate { get; set; }
        /// <summary>
        /// 结束支付时间
        /// </summary>
        [Display( Name = "结束支付时间" )]
        public DateTime? EndPayDate { get; set; }        
        /// <summary>
        /// 挂号金额=检查费+就诊费=社保支付+现金支付+会员卡支付+银行卡支付+支付宝+微信
        /// </summary>
        [Display(Name="挂号金额=检查费+就诊费=社保支付+现金支付+会员卡支付+银行卡支付+支付宝+微信")]
        public decimal? Money { get; set; }
        /// <summary>
        /// 检查费金额
        /// </summary>
        [Display(Name="检查费金额")]
        public decimal? CheckMoney { get; set; }
        /// <summary>
        /// 挂号费金额
        /// </summary>
        [Display(Name="挂号费金额")]
        public decimal? RegisterMoney { get; set; }
        /// <summary>
        /// 社保支付金额
        /// </summary>
        [Display(Name="社保支付金额")]
        public decimal? SbMoney { get; set; }
        /// <summary>
        /// 现金支付金额
        /// </summary>
        [Display(Name="现金支付金额")]
        public decimal? CashMoney { get; set; }
        /// <summary>
        /// 会员卡支付金额
        /// </summary>
        [Display(Name="会员卡支付金额")]
        public decimal? CardMoney { get; set; }
        /// <summary>
        /// 银行支付金额
        /// </summary>
        [Display(Name="银行支付金额")]
        public decimal? BankMoney { get; set; }
        /// <summary>
        /// 微信支付金额
        /// </summary>
        [Display(Name="微信支付金额")]
        public decimal? WeiXinMoeny { get; set; }
        /// <summary>
        /// 支付宝支付金额
        /// </summary>
        [Display(Name="支付宝支付金额")]
        public decimal? AlipayMoeny { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        [Display(Name="支付状态")]
        public int? PaymentStatus { get; set; }
        
    }
}
