using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Materials {
    /// <summary>
    /// 物资库存数据传输对象
    /// </summary>
    [DataContract]
    public class MaterialinventoryDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
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
