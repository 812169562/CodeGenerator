using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Materials {
    /// <summary>
    /// 入库记录数据传输对象
    /// </summary>
    [DataContract]
    public class InstockDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 类型
        /// </summary>
        [Display( Name = "类型" )]
        [DataMember]
        public int? Type { get; set; }
        
        /// <summary>
        /// 物资ID
        /// </summary>
        [StringLength( 144, ErrorMessage = "物资ID输入过长，不能超过144位" )]
        [Display( Name = "物资ID" )]
        [DataMember]
        public string MaterialsId { get; set; }
        
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "名称输入过长，不能超过400位" )]
        [Display( Name = "名称" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 规格
        /// </summary>
        [StringLength( 400, ErrorMessage = "规格输入过长，不能超过400位" )]
        [Display( Name = "规格" )]
        [DataMember]
        public string Specifications { get; set; }
        
        /// <summary>
        /// 采购价格
        /// </summary>
        [Display( Name = "采购价格" )]
        [DataMember]
        public decimal? Price { get; set; }
        
        /// <summary>
        /// 数量
        /// </summary>
        [Display( Name = "数量" )]
        [DataMember]
        public int? Count { get; set; }
        
        /// <summary>
        /// 单位
        /// </summary>
        [StringLength( 200, ErrorMessage = "单位输入过长，不能超过200位" )]
        [Display( Name = "单位" )]
        [DataMember]
        public string Unit { get; set; }
        
        /// <summary>
        /// 购买情况
        /// </summary>
        [StringLength( 144, ErrorMessage = "购买情况输入过长，不能超过144位" )]
        [Display( Name = "购买情况" )]
        [DataMember]
        public string PurchasesId { get; set; }
        
        /// <summary>
        /// 购买情况
        /// </summary>
        [StringLength( 200, ErrorMessage = "购买情况输入过长，不能超过200位" )]
        [Display( Name = "购买情况" )]
        [DataMember]
        public string Purchases { get; set; }
        
        /// <summary>
        /// 购买日期
        /// </summary>
        [Display( Name = "购买日期" )]
        [DataMember]
        public DateTime? PurchaseDate { get; set; }
        
        /// <summary>
        /// 库房
        /// </summary>
        [StringLength( 144, ErrorMessage = "库房输入过长，不能超过144位" )]
        [Display( Name = "库房" )]
        [DataMember]
        public string StorehouseId { get; set; }
        
        /// <summary>
        /// 库房
        /// </summary>
        [StringLength( 200, ErrorMessage = "库房输入过长，不能超过200位" )]
        [Display( Name = "库房" )]
        [DataMember]
        public string Storehouse { get; set; }
        
        /// <summary>
        /// 采购人
        /// </summary>
        [StringLength( 144, ErrorMessage = "采购人输入过长，不能超过144位" )]
        [Display( Name = "采购人" )]
        [DataMember]
        public string PurchaserId { get; set; }
        
        /// <summary>
        /// 采购人
        /// </summary>
        [StringLength( 200, ErrorMessage = "采购人输入过长，不能超过200位" )]
        [Display( Name = "采购人" )]
        [DataMember]
        public string Purchaser { get; set; }
        
        /// <summary>
        /// 产地
        /// </summary>
        [StringLength( 4000, ErrorMessage = "产地输入过长，不能超过4000位" )]
        [Display( Name = "产地" )]
        [DataMember]
        public string Remark { get; set; }
        
        /// <summary>
        /// 等级
        /// </summary>
        [Display( Name = "等级" )]
        [DataMember]
        public int? Level { get; set; }
        
        /// <summary>
        /// 排序
        /// </summary>
        [Required(ErrorMessage = "排序不能为空")]
        [Display( Name = "排序" )]
        [DataMember]
        public int Sort { get; set; }
        
    }
}
