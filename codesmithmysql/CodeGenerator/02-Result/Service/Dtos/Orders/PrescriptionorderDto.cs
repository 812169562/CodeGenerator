using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Orders {
    /// <summary>
    /// 订单处方数据传输对象
    /// </summary>
    [DataContract]
    public class PrescriptionorderDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 门店名
        /// </summary>
        [StringLength( 300, ErrorMessage = "门店名输入过长，不能超过300位" )]
        [Display( Name = "门店名" )]
        [DataMember]
        public string StroeName { get; set; }
        
        /// <summary>
        /// 处方编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "处方编号输入过长，不能超过108位" )]
        [Display( Name = "处方编号" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength( 300, ErrorMessage = "名称输入过长，不能超过300位" )]
        [Display( Name = "名称" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 申请单编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "申请单编号输入过长，不能超过108位" )]
        [Display( Name = "申请单编号" )]
        [DataMember]
        public string PrescriptionCode { get; set; }
        
        /// <summary>
        /// 申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)
        /// </summary>
        [Required(ErrorMessage = "申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)不能为空")]
        [Display( Name = "申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)" )]
        [DataMember]
        public int Type { get; set; }
        
        /// <summary>
        /// 处方类型(0.普通,1.精一.2.精二.3.中药饮片,4.中药免检.5.中药小包装)
        /// </summary>
        [Display( Name = "处方类型(0.普通,1.精一.2.精二.3.中药饮片,4.中药免检.5.中药小包装)" )]
        [DataMember]
        public int? PrescriptionType { get; set; }
        
        /// <summary>
        /// 来源类型(1门诊，2.住院.3. 购药)
        /// </summary>
        [Display( Name = "来源类型(1门诊，2.住院.3. 购药)" )]
        [DataMember]
        public int? SourceType { get; set; }
        
        /// <summary>
        /// 客户(患者)编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "客户(患者)编号输入过长，不能超过108位" )]
        [Display( Name = "客户(患者)编号" )]
        [DataMember]
        public string CustomertId { get; set; }
        
        /// <summary>
        /// 客户(患者)姓名
        /// </summary>
        [StringLength( 300, ErrorMessage = "客户(患者)姓名输入过长，不能超过300位" )]
        [Display( Name = "客户(患者)姓名" )]
        [DataMember]
        public string CustomerName { get; set; }
        
        /// <summary>
        /// 客户(患者)其他信息
        /// </summary>
        [StringLength( 65535, ErrorMessage = "客户(患者)其他信息输入过长，不能超过65535位" )]
        [Display( Name = "客户(患者)其他信息" )]
        [DataMember]
        public string CustomerOthterMessage { get; set; }
        
        /// <summary>
        /// 订单过期时间
        /// </summary>
        [Display( Name = "订单过期时间" )]
        [DataMember]
        public DateTime? ExpiryTime { get; set; }
        
        /// <summary>
        /// 项目条数
        /// </summary>
        [Display( Name = "项目条数" )]
        [DataMember]
        public decimal? Count { get; set; }
        
        /// <summary>
        /// 项目金额
        /// </summary>
        [Display( Name = "项目金额" )]
        [DataMember]
        public decimal? Money { get; set; }
        
        /// <summary>
        /// 抵扣金额
        /// </summary>
        [Display( Name = "抵扣金额" )]
        [DataMember]
        public decimal? ReductionMoeny { get; set; }
        
        /// <summary>
        /// 开单人编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "开单人编号输入过长，不能超过108位" )]
        [Display( Name = "开单人编号" )]
        [DataMember]
        public string UserId { get; set; }
        
        /// <summary>
        /// 开单人
        /// </summary>
        [StringLength( 300, ErrorMessage = "开单人输入过长，不能超过300位" )]
        [Display( Name = "开单人" )]
        [DataMember]
        public string UserName { get; set; }
        
        /// <summary>
        /// 开单时间
        /// </summary>
        [Display( Name = "开单时间" )]
        [DataMember]
        public DateTime? OrderDate { get; set; }
        
        /// <summary>
        /// 科室编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "科室编号输入过长，不能超过108位" )]
        [Display( Name = "科室编号" )]
        [DataMember]
        public string DepartmentId { get; set; }
        
        /// <summary>
        /// 科室
        /// </summary>
        [StringLength( 300, ErrorMessage = "科室输入过长，不能超过300位" )]
        [Display( Name = "科室" )]
        [DataMember]
        public string Department { get; set; }
        
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
        public DateTime? AccountingDate { get; set; }
        
        /// <summary>
        /// 备注说明
        /// </summary>
        [StringLength( 1800, ErrorMessage = "备注说明输入过长，不能超过1800位" )]
        [Display( Name = "备注说明" )]
        [DataMember]
        public string Remark { get; set; }
        
        /// <summary>
        /// 是否允许修改
        /// </summary>
        [Display( Name = "是否允许修改" )]
        [DataMember]
        public sbyte? IsModify { get; set; }
        
    }
}
