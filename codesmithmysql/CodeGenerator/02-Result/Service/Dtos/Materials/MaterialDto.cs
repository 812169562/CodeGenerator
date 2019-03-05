using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Materials {
    /// <summary>
    /// 物资数据传输对象
    /// </summary>
    [DataContract]
    public class MaterialDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "名称输入过长，不能超过400位" )]
        [Display( Name = "名称" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 编号
        /// </summary>
        [StringLength( 200, ErrorMessage = "编号输入过长，不能超过200位" )]
        [Display( Name = "编号" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 单位
        /// </summary>
        [StringLength( 200, ErrorMessage = "单位输入过长，不能超过200位" )]
        [Display( Name = "单位" )]
        [DataMember]
        public string Unit { get; set; }
        
        /// <summary>
        /// 规格
        /// </summary>
        [StringLength( 400, ErrorMessage = "规格输入过长，不能超过400位" )]
        [Display( Name = "规格" )]
        [DataMember]
        public string Specifications { get; set; }
        
        /// <summary>
        /// 品牌
        /// </summary>
        [StringLength( 400, ErrorMessage = "品牌输入过长，不能超过400位" )]
        [Display( Name = "品牌" )]
        [DataMember]
        public string Trademark { get; set; }
        
        /// <summary>
        /// 型号
        /// </summary>
        [StringLength( 400, ErrorMessage = "型号输入过长，不能超过400位" )]
        [Display( Name = "型号" )]
        [DataMember]
        public string Type { get; set; }
        
        /// <summary>
        /// 生产厂家
        /// </summary>
        [StringLength( 144, ErrorMessage = "生产厂家输入过长，不能超过144位" )]
        [Display( Name = "生产厂家" )]
        [DataMember]
        public string ManufacturerId { get; set; }
        
        /// <summary>
        /// 生产厂家
        /// </summary>
        [StringLength( 400, ErrorMessage = "生产厂家输入过长，不能超过400位" )]
        [Display( Name = "生产厂家" )]
        [DataMember]
        public string Manufacturer { get; set; }
        
        /// <summary>
        /// 采购时间
        /// </summary>
        [Display( Name = "采购时间" )]
        [DataMember]
        public DateTime? PurchasingTime { get; set; }
        
        /// <summary>
        /// 有效期
        /// </summary>
        [Display( Name = "有效期" )]
        [DataMember]
        public DateTime? PeriodTime { get; set; }
        
        /// <summary>
        /// 产地
        /// </summary>
        [StringLength( 800, ErrorMessage = "产地输入过长，不能超过800位" )]
        [Display( Name = "产地" )]
        [DataMember]
        public string Place { get; set; }
        
        /// <summary>
        /// 产地
        /// </summary>
        [StringLength( 4000, ErrorMessage = "产地输入过长，不能超过4000位" )]
        [Display( Name = "产地" )]
        [DataMember]
        public string Remark { get; set; }
        
        /// <summary>
        /// 五笔
        /// </summary>
        [StringLength( 320, ErrorMessage = "五笔输入过长，不能超过320位" )]
        [Display( Name = "五笔" )]
        [DataMember]
        public string Wubi { get; set; }
        
        /// <summary>
        /// 拼音简拼
        /// </summary>
        [StringLength( 200, ErrorMessage = "拼音简拼输入过长，不能超过200位" )]
        [Display( Name = "拼音简拼" )]
        [DataMember]
        public string PinYin { get; set; }
        
        /// <summary>
        /// 全拼
        /// </summary>
        [StringLength( 600, ErrorMessage = "全拼输入过长，不能超过600位" )]
        [Display( Name = "全拼" )]
        [DataMember]
        public string FullPinYin { get; set; }
        
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
