using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Medicinestores {
    /// <summary>
    /// 药品调拨
    /// </summary>
    [Description( "药品调拨" )]
    public partial class Drugallot : Entity,ISoftDelete {
        /// <summary>
        /// 初始化药品调拨
        /// </summary>
        public Drugallot(){
        }
        /// <summary>
        /// 调拨类型
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 调拨单号
        /// </summary>
        [StringLength( 150, ErrorMessage = "调拨单号输入过长，不能超过150位" )]
        public string Code { get; set; }
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
        /// 备注
        /// </summary>
        [StringLength( 1200, ErrorMessage = "备注输入过长，不能超过1200位" )]
        public string ApplyRemark { get; set; }
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
        /// 入库编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "入库编号输入过长，不能超过108位" )]
        public string InId { get; set; }
        /// <summary>
        /// 调拨入库库房编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "调拨入库库房编号输入过长，不能超过108位" )]
        public string InStroeId { get; set; }
        /// <summary>
        /// 调拨入库库房
        /// </summary>
        [StringLength( 300, ErrorMessage = "调拨入库库房输入过长，不能超过300位" )]
        public string InStroeName { get; set; }
        /// <summary>
        /// 入库单据号
        /// </summary>
        [StringLength( 75, ErrorMessage = "入库单据号输入过长，不能超过75位" )]
        public string InCode { get; set; }
        /// <summary>
        /// 出库编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "出库编号输入过长，不能超过108位" )]
        public string OutId { get; set; }
        /// <summary>
        /// 调拨出库库房编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "调拨出库库房编号输入过长，不能超过108位" )]
        public string OutStroeId { get; set; }
        /// <summary>
        /// 调拨出库库房
        /// </summary>
        [StringLength( 300, ErrorMessage = "调拨出库库房输入过长，不能超过300位" )]
        public string OutStroeName { get; set; }
        /// <summary>
        /// 出库库单据号
        /// </summary>
        [StringLength( 75, ErrorMessage = "出库库单据号输入过长，不能超过75位" )]
        public string OutCode { get; set; }
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