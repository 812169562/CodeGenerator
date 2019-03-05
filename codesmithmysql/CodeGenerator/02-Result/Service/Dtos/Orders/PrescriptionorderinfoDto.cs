using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Orders {
    /// <summary>
    /// 订单明细数据传输对象
    /// </summary>
    [DataContract]
    public class PrescriptionorderinfoDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 订单编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "订单编号输入过长，不能超过108位" )]
        [Display( Name = "订单编号" )]
        [DataMember]
        public string OrderId { get; set; }
        
        /// <summary>
        /// 项目编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目编号输入过长，不能超过108位" )]
        [Display( Name = "项目编号" )]
        [DataMember]
        public string ItemId { get; set; }
        
        /// <summary>
        /// 项目批次编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目批次编号输入过长，不能超过108位" )]
        [Display( Name = "项目批次编号" )]
        [DataMember]
        public string ItemBatchId { get; set; }
        
        /// <summary>
        /// 项目名称
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目名称输入过长，不能超过900位" )]
        [Display( Name = "项目名称" )]
        [DataMember]
        public string ItemName { get; set; }
        
        /// <summary>
        /// 项目规格
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目规格输入过长，不能超过900位" )]
        [Display( Name = "项目规格" )]
        [DataMember]
        public string ItemFormat { get; set; }
        
        /// <summary>
        /// 使用方法
        /// </summary>
        [StringLength( 300, ErrorMessage = "使用方法输入过长，不能超过300位" )]
        [Display( Name = "使用方法" )]
        [DataMember]
        public string UsageName { get; set; }
        
        /// <summary>
        /// 使用方法编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "使用方法编号输入过长，不能超过108位" )]
        [Display( Name = "使用方法编号" )]
        [DataMember]
        public string UsageId { get; set; }
        
        /// <summary>
        /// 销售数量
        /// </summary>
        [Display( Name = "销售数量" )]
        [DataMember]
        public decimal? SalesCount { get; set; }
        
        /// <summary>
        /// 销售单价
        /// </summary>
        [Display( Name = "销售单价" )]
        [DataMember]
        public decimal? SalesPrice { get; set; }
        
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "销售单位输入过长，不能超过300位" )]
        [Display( Name = "销售单位" )]
        [DataMember]
        public string SalesUnit { get; set; }
        
        /// <summary>
        /// 项目类型编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目类型编号输入过长，不能超过108位" )]
        [Display( Name = "项目类型编号" )]
        [DataMember]
        public string ItemTypeId { get; set; }
        
        /// <summary>
        /// 项目类型
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目类型输入过长，不能超过900位" )]
        [Display( Name = "项目类型" )]
        [DataMember]
        public string ItemType { get; set; }
        
        /// <summary>
        /// 项目类型关系编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目类型关系编号输入过长，不能超过108位" )]
        [Display( Name = "项目类型关系编号" )]
        [DataMember]
        public string ItemTypeRelationId { get; set; }
        
        /// <summary>
        /// 项目备注
        /// </summary>
        [StringLength( 900, ErrorMessage = "项目备注输入过长，不能超过900位" )]
        [Display( Name = "项目备注" )]
        [DataMember]
        public string Remark { get; set; }
        
        /// <summary>
        /// 项目顺序
        /// </summary>
        [Display( Name = "项目顺序" )]
        [DataMember]
        public int? Sort { get; set; }
        
        /// <summary>
        /// 项目分组
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目分组输入过长，不能超过108位" )]
        [Display( Name = "项目分组" )]
        [DataMember]
        public string GroupNo { get; set; }
        
        /// <summary>
        /// 项目社保编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "项目社保编号输入过长，不能超过108位" )]
        [Display( Name = "项目社保编号" )]
        [DataMember]
        public string SbCode { get; set; }
        
        /// <summary>
        /// 标准编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "标准编号输入过长，不能超过108位" )]
        [Display( Name = "标准编号" )]
        [DataMember]
        public string StandardCode { get; set; }
        
        /// <summary>
        /// 单次用量
        /// </summary>
        [Display( Name = "单次用量" )]
        [DataMember]
        public decimal? UsageCount { get; set; }
        
        /// <summary>
        /// 单次用量单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "单次用量单位输入过长，不能超过300位" )]
        [Display( Name = "单次用量单位" )]
        [DataMember]
        public string UsageUnit { get; set; }
        
        /// <summary>
        /// 用法比例
        /// </summary>
        [Display( Name = "用法比例" )]
        [DataMember]
        public decimal? UsageRatio { get; set; }
        
        /// <summary>
        /// 频率编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "频率编号输入过长，不能超过108位" )]
        [Display( Name = "频率编号" )]
        [DataMember]
        public string FrequencyId { get; set; }
        
        /// <summary>
        /// 频率
        /// </summary>
        [StringLength( 300, ErrorMessage = "频率输入过长，不能超过300位" )]
        [Display( Name = "频率" )]
        [DataMember]
        public string Frequency { get; set; }
        
        /// <summary>
        /// 频率比例
        /// </summary>
        [Display( Name = "频率比例" )]
        [DataMember]
        public decimal? FrequencyRatio { get; set; }
        
        /// <summary>
        /// 滴数
        /// </summary>
        [StringLength( 300, ErrorMessage = "滴数输入过长，不能超过300位" )]
        [Display( Name = "滴数" )]
        [DataMember]
        public string DropNumber { get; set; }
        
        /// <summary>
        /// 皮试标志
        /// </summary>
        [Display( Name = "皮试标志" )]
        [DataMember]
        public int? SkinTest { get; set; }
        
        /// <summary>
        /// 皮试结果
        /// </summary>
        [StringLength( 300, ErrorMessage = "皮试结果输入过长，不能超过300位" )]
        [Display( Name = "皮试结果" )]
        [DataMember]
        public string SkinTestResult { get; set; }
        
        /// <summary>
        /// 天数
        /// </summary>
        [Display( Name = "天数" )]
        [DataMember]
        public int? Day { get; set; }
        
    }
}
