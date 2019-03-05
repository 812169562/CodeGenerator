using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Orders {
    /// <summary>
    /// 订单明细
    /// </summary>
    [Description( "订单明细" )]
    public partial class Prescriptionorderinfo : Entity,ISoftDelete {
        /// <summary>
        /// 初始化订单明细
        /// </summary>
        public Prescriptionorderinfo(){
        }
        /// <summary>
        /// 订单编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "订单编号输入过长，不能超过108位" )]
        public string OrderId { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目编号输入过长，不能超过108位" )]
        public string ItemId { get; set; }
        /// <summary>
        /// 项目批次编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目批次编号输入过长，不能超过108位" )]
        public string ItemBatchId { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目名称输入过长，不能超过900位" )]
        public string ItemName { get; set; }
        /// <summary>
        /// 项目规格
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目规格输入过长，不能超过900位" )]
        public string ItemFormat { get; set; }
        /// <summary>
        /// 使用方法
        /// </summary>
        [StringLength( 300, ErrorMessage = "使用方法输入过长，不能超过300位" )]
        public string UsageName { get; set; }
        /// <summary>
        /// 使用方法编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "使用方法编号输入过长，不能超过108位" )]
        public string UsageId { get; set; }
        /// <summary>
        /// 销售数量
        /// </summary>
        public decimal? SalesCount { get; set; }
        /// <summary>
        /// 销售单价
        /// </summary>
        public decimal? SalesPrice { get; set; }
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "销售单位输入过长，不能超过300位" )]
        public string SalesUnit { get; set; }
        /// <summary>
        /// 项目类型编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目类型编号输入过长，不能超过108位" )]
        public string ItemTypeId { get; set; }
        /// <summary>
        /// 项目类型
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目类型输入过长，不能超过900位" )]
        public string ItemType { get; set; }
        /// <summary>
        /// 项目类型关系编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目类型关系编号输入过长，不能超过108位" )]
        public string ItemTypeRelationId { get; set; }
        /// <summary>
        /// 项目备注
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目备注输入过长，不能超过900位" )]
        public string Remark { get; set; }
        /// <summary>
        /// 项目顺序
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 项目分组
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目分组输入过长，不能超过108位" )]
        public string GroupNo { get; set; }
        /// <summary>
        /// 项目社保编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目社保编号输入过长，不能超过108位" )]
        public string SbCode { get; set; }
        /// <summary>
        /// 标准编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "标准编号输入过长，不能超过108位" )]
        public string StandardCode { get; set; }
        /// <summary>
        /// 单次用量
        /// </summary>
        public decimal? UsageCount { get; set; }
        /// <summary>
        /// 单次用量单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "单次用量单位输入过长，不能超过300位" )]
        public string UsageUnit { get; set; }
        /// <summary>
        /// 用法比例
        /// </summary>
        public decimal? UsageRatio { get; set; }
        /// <summary>
        /// 频率编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "频率编号输入过长，不能超过108位" )]
        public string FrequencyId { get; set; }
        /// <summary>
        /// 频率
        /// </summary>
        [StringLength( 300, ErrorMessage = "频率输入过长，不能超过300位" )]
        public string Frequency { get; set; }
        /// <summary>
        /// 频率比例
        /// </summary>
        public decimal? FrequencyRatio { get; set; }
        /// <summary>
        /// 滴数
        /// </summary>
        [StringLength( 300, ErrorMessage = "滴数输入过长，不能超过300位" )]
        public string DropNumber { get; set; }
        /// <summary>
        /// 皮试标志
        /// </summary>
        public int? SkinTest { get; set; }
        /// <summary>
        /// 皮试结果
        /// </summary>
        [StringLength( 300, ErrorMessage = "皮试结果输入过长，不能超过300位" )]
        public string SkinTestResult { get; set; }
        /// <summary>
        /// 天数
        /// </summary>
        public int? Day { get; set; }
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