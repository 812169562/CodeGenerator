using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Medicinestores {
    /// <summary>
    /// 药品基本信息数据传输对象
    /// </summary>
    [DataContract]
    public class DrugsDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 108, ErrorMessage = "代码输入过长，不能超过108位" )]
        [Display( Name = "代码" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// （如：成药,精麻,等等）
        /// </summary>
        [Display( Name = "（如：成药,精麻,等等）" )]
        [DataMember]
        public int? Type { get; set; }
        
        /// <summary>
        /// 条码
        /// </summary>
        [StringLength( 108, ErrorMessage = "条码输入过长，不能超过108位" )]
        [Display( Name = "条码" )]
        [DataMember]
        public string Barcode { get; set; }
        
        /// <summary>
        /// 药品名称
        /// </summary>
        [StringLength( 450, ErrorMessage = "药品名称输入过长，不能超过450位" )]
        [Display( Name = "药品名称" )]
        [DataMember]
        public string DrugName { get; set; }
        
        /// <summary>
        /// 别名
        /// </summary>
        [StringLength( 450, ErrorMessage = "别名输入过长，不能超过450位" )]
        [Display( Name = "别名" )]
        [DataMember]
        public string Alias { get; set; }
        
        /// <summary>
        /// 药品分类
        /// </summary>
        [StringLength( 108, ErrorMessage = "药品分类输入过长，不能超过108位" )]
        [Display( Name = "药品分类" )]
        [DataMember]
        public string DrugTypeId { get; set; }
        
        /// <summary>
        /// 药品分类
        /// </summary>
        [StringLength( 150, ErrorMessage = "药品分类输入过长，不能超过150位" )]
        [Display( Name = "药品分类" )]
        [DataMember]
        public string DrugType { get; set; }
        
        /// <summary>
        /// 药品分类类型
        /// </summary>
        [StringLength( 1110, ErrorMessage = "药品分类类型输入过长，不能超过1110位" )]
        [Display( Name = "药品分类类型" )]
        [DataMember]
        public string DrugTypeRelationShip { get; set; }
        
        /// <summary>
        /// 英文名
        /// </summary>
        [StringLength( 360, ErrorMessage = "英文名输入过长，不能超过360位" )]
        [Display( Name = "英文名" )]
        [DataMember]
        public string EnglishName { get; set; }
        
        /// <summary>
        /// 库房单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "库房单位输入过长，不能超过108位" )]
        [Display( Name = "库房单位" )]
        [DataMember]
        public string StoreroomUnitId { get; set; }
        
        /// <summary>
        /// 库房单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "库房单位输入过长，不能超过300位" )]
        [Display( Name = "库房单位" )]
        [DataMember]
        public string StoreroomUnit { get; set; }
        
        /// <summary>
        /// 使用单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "使用单位输入过长，不能超过108位" )]
        [Display( Name = "使用单位" )]
        [DataMember]
        public string UseUnitId { get; set; }
        
        /// <summary>
        /// 使用单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "使用单位输入过长，不能超过300位" )]
        [Display( Name = "使用单位" )]
        [DataMember]
        public string UseUnit { get; set; }
        
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "销售单位输入过长，不能超过108位" )]
        [Display( Name = "销售单位" )]
        [DataMember]
        public string SalesUnitId { get; set; }
        
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "销售单位输入过长，不能超过300位" )]
        [Display( Name = "销售单位" )]
        [DataMember]
        public string SalesUnit { get; set; }
        
        /// <summary>
        /// 基本单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "基本单位输入过长，不能超过108位" )]
        [Display( Name = "基本单位" )]
        [DataMember]
        public string BasicUnitId { get; set; }
        
        /// <summary>
        /// 基本单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "基本单位输入过长，不能超过300位" )]
        [Display( Name = "基本单位" )]
        [DataMember]
        public string BasicUnit { get; set; }
        
        /// <summary>
        /// 是否按照实际库存卖
        /// </summary>
        [Display( Name = "是否按照实际库存卖" )]
        [DataMember]
        public sbyte? IsActualInventory { get; set; }
        
        /// <summary>
        /// 库房比例
        /// </summary>
        [Display( Name = "库房比例" )]
        [DataMember]
        public decimal? StoreroomRatio { get; set; }
        
        /// <summary>
        /// 销售比例
        /// </summary>
        [Display( Name = "销售比例" )]
        [DataMember]
        public decimal? SalesRatio { get; set; }
        
        /// <summary>
        /// 常用剂量
        /// </summary>
        [Display( Name = "常用剂量" )]
        [DataMember]
        public decimal? CommonDose { get; set; }
        
        /// <summary>
        /// 儿童常用剂量
        /// </summary>
        [Display( Name = "儿童常用剂量" )]
        [DataMember]
        public decimal? ChlidCommonDose { get; set; }
        
        /// <summary>
        /// 生产厂家
        /// </summary>
        [StringLength( 108, ErrorMessage = "生产厂家输入过长，不能超过108位" )]
        [Display( Name = "生产厂家" )]
        [DataMember]
        public string ManufacturerId { get; set; }
        
        /// <summary>
        /// 生产厂家
        /// </summary>
        [StringLength( 300, ErrorMessage = "生产厂家输入过长，不能超过300位" )]
        [Display( Name = "生产厂家" )]
        [DataMember]
        public string Manufacturer { get; set; }
        
        /// <summary>
        /// 规格
        /// </summary>
        [StringLength( 300, ErrorMessage = "规格输入过长，不能超过300位" )]
        [Display( Name = "规格" )]
        [DataMember]
        public string Format { get; set; }
        
        /// <summary>
        /// 产地
        /// </summary>
        [StringLength( 600, ErrorMessage = "产地输入过长，不能超过600位" )]
        [Display( Name = "产地" )]
        [DataMember]
        public string Place { get; set; }
        
        /// <summary>
        /// 下限提醒
        /// </summary>
        [Display( Name = "下限提醒" )]
        [DataMember]
        public int? LowerLimit { get; set; }
        
        /// <summary>
        /// 是否为处方药品
        /// </summary>
        [Display( Name = "是否为处方药品" )]
        [DataMember]
        public int? IsPrescription { get; set; }
        
        /// <summary>
        ///  药品通用码（869）
        /// </summary>
        [StringLength( 108, ErrorMessage = " 药品通用码（869）输入过长，不能超过108位" )]
        [Display( Name = " 药品通用码（869）" )]
        [DataMember]
        public string DrugCommCode { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 600, ErrorMessage = "备注输入过长，不能超过600位" )]
        [Display( Name = "备注" )]
        [DataMember]
        public string Remarks { get; set; }
        
        /// <summary>
        /// 使用说明书地址
        /// </summary>
        [StringLength( 600, ErrorMessage = "使用说明书地址输入过长，不能超过600位" )]
        [Display( Name = "使用说明书地址" )]
        [DataMember]
        public string UsePath { get; set; }
        
        /// <summary>
        /// 药品图片
        /// </summary>
        [StringLength( 450, ErrorMessage = "药品图片输入过长，不能超过450位" )]
        [Display( Name = "药品图片" )]
        [DataMember]
        public string Img { get; set; }
        
        /// <summary>
        /// DDD规格
        /// </summary>
        [Display( Name = "DDD规格" )]
        [DataMember]
        public decimal? DddFomat { get; set; }
        
        /// <summary>
        /// DDD值
        /// </summary>
        [Display( Name = "DDD值" )]
        [DataMember]
        public decimal? DddValue { get; set; }
        
        /// <summary>
        /// 拼音简拼
        /// </summary>
        [StringLength( 150, ErrorMessage = "拼音简拼输入过长，不能超过150位" )]
        [Display( Name = "拼音简拼" )]
        [DataMember]
        public string PinYin { get; set; }
        
        /// <summary>
        /// 全拼
        /// </summary>
        [StringLength( 450, ErrorMessage = "全拼输入过长，不能超过450位" )]
        [Display( Name = "全拼" )]
        [DataMember]
        public string FullPinYin { get; set; }
        
        /// <summary>
        /// 五笔
        /// </summary>
        [StringLength( 240, ErrorMessage = "五笔输入过长，不能超过240位" )]
        [Display( Name = "五笔" )]
        [DataMember]
        public string Wubi { get; set; }
        
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
