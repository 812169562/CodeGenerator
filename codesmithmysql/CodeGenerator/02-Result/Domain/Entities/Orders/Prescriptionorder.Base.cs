using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Orders {
    /// <summary>
    /// 订单处方
    /// </summary>
    [Description( "订单处方" )]
    public partial class Prescriptionorder : Entity,ISoftDelete {
        /// <summary>
        /// 初始化订单处方
        /// </summary>
        public Prescriptionorder(){
        }
        /// <summary>
        /// 门店名
        /// </summary>
        [StringLength( 300, ErrorMessage = "门店名输入过长，不能超过300位" )]
        public string StroeName { get; set; }
        /// <summary>
        /// 处方编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "处方编号输入过长，不能超过108位" )]
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength( 300, ErrorMessage = "名称输入过长，不能超过300位" )]
        public string Name { get; set; }
        /// <summary>
        /// 申请单编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "申请单编号输入过长，不能超过108位" )]
        public string PrescriptionCode { get; set; }
        /// <summary>
        /// 申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)
        /// </summary>
        [Required(ErrorMessage = "申请单类型(1,检验，2检查，3治疗,4.手术.5西药处方,6输液雾化处方,7中药处方,8收费项目,9挂号)不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 处方类型(0.普通,1.精一.2.精二.3.中药饮片,4.中药免检.5.中药小包装)
        /// </summary>
        public int? PrescriptionType { get; set; }
        /// <summary>
        /// 来源类型(1门诊，2.住院.3. 购药)
        /// </summary>
        public int? SourceType { get; set; }
        /// <summary>
        /// 客户(患者)编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "客户(患者)编号输入过长，不能超过108位" )]
        public string CustomertId { get; set; }
        /// <summary>
        /// 客户(患者)姓名
        /// </summary>
        [StringLength( 300, ErrorMessage = "客户(患者)姓名输入过长，不能超过300位" )]
        public string CustomerName { get; set; }
        /// <summary>
        /// 客户(患者)其他信息
        /// </summary>
        [StringLength( 65535, ErrorMessage = "客户(患者)其他信息输入过长，不能超过65535位" )]
        public string CustomerOthterMessage { get; set; }
        /// <summary>
        /// 订单过期时间
        /// </summary>
        public DateTime? ExpiryTime { get; set; }
        /// <summary>
        /// 项目条数
        /// </summary>
        public decimal? Count { get; set; }
        /// <summary>
        /// 项目金额
        /// </summary>
        public decimal? Money { get; set; }
        /// <summary>
        /// 抵扣金额
        /// </summary>
        public decimal? ReductionMoeny { get; set; }
        /// <summary>
        /// 开单人编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "开单人编号输入过长，不能超过108位" )]
        public string UserId { get; set; }
        /// <summary>
        /// 开单人
        /// </summary>
        [StringLength( 300, ErrorMessage = "开单人输入过长，不能超过300位" )]
        public string UserName { get; set; }
        /// <summary>
        /// 开单时间
        /// </summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>
        /// 科室编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "科室编号输入过长，不能超过108位" )]
        public string DepartmentId { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        [StringLength( 300, ErrorMessage = "科室输入过长，不能超过300位" )]
        public string Department { get; set; }
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
        public DateTime? AccountingDate { get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
        [StringLength( 1800, ErrorMessage = "备注说明输入过长，不能超过1800位" )]
        public string Remark { get; set; }
        /// <summary>
        /// 是否允许修改
        /// </summary>
        public sbyte? IsModify { get; set; }
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