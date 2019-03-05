using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Medicinestores {
    /// <summary>
    /// 药品出入库
    /// </summary>
    [Description( "药品出入库" )]
    public partial class Druginout : Entity,ISoftDelete {
        /// <summary>
        /// 初始化药品出入库
        /// </summary>
        public Druginout(){
        }
        /// <summary>
        /// 出入库单号
        /// </summary>
        [StringLength( 300, ErrorMessage = "出入库单号输入过长，不能超过300位" )]
        public string Code { get; set; }
        /// <summary>
        /// 出入库类型
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 出入库类型（来自字典表）
        /// </summary>
        [StringLength( 108, ErrorMessage = "出入库类型（来自字典表）输入过长，不能超过108位" )]
        public string InOutTypeId { get; set; }
        /// <summary>
        /// 出入库类型（来自字典表）
        /// </summary>
        [StringLength( 300, ErrorMessage = "出入库类型（来自字典表）输入过长，不能超过300位" )]
        public string InOutTypeName { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        [StringLength( 108, ErrorMessage = "供应商输入过长，不能超过108位" )]
        public string SupplierId { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        [StringLength( 300, ErrorMessage = "供应商输入过长，不能超过300位" )]
        public string Supplier { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        [StringLength( 108, ErrorMessage = "申请人输入过长，不能超过108位" )]
        public string ApplyId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        [StringLength( 300, ErrorMessage = "申请人输入过长，不能超过300位" )]
        public string ApplyName { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime? ApplyDate { get; set; }
        /// <summary>
        /// 申请备注
        /// </summary>
        [StringLength( 1200, ErrorMessage = "申请备注输入过长，不能超过1200位" )]
        public string ApplyRemark { get; set; }
        /// <summary>
        /// 出入库房
        /// </summary>
        [StringLength( 108, ErrorMessage = "出入库房输入过长，不能超过108位" )]
        public string StoreId { get; set; }
        /// <summary>
        /// 出入库房
        /// </summary>
        [StringLength( 300, ErrorMessage = "出入库房输入过长，不能超过300位" )]
        public string StoreName { get; set; }
        /// <summary>
        /// 审核编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "审核编号输入过长，不能超过108位" )]
        public string AuditId { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        [StringLength( 300, ErrorMessage = "审核人输入过长，不能超过300位" )]
        public string AuditName { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? AuditDate { get; set; }
        /// <summary>
        /// 审核意见
        /// </summary>
        [StringLength( 1200, ErrorMessage = "审核意见输入过长，不能超过1200位" )]
        public string AuditOpinion { get; set; }
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