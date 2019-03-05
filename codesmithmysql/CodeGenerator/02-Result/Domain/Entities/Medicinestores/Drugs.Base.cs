using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Medicinestores {
    /// <summary>
    /// 药品基本信息
    /// </summary>
    [Description( "药品基本信息" )]
    public partial class Drugs : Entity,ISoftDelete {
        /// <summary>
        /// 初始化药品基本信息
        /// </summary>
        public Drugs(){
        }
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 108, ErrorMessage = "代码输入过长，不能超过108位" )]
        public string Code { get; set; }
        /// <summary>
        /// （如：成药,精麻,等等）
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 条码
        /// </summary>
        [StringLength( 108, ErrorMessage = "条码输入过长，不能超过108位" )]
        public string Barcode { get; set; }
        /// <summary>
        /// 药品名称
        /// </summary>
        [StringLength( 450, ErrorMessage = "药品名称输入过长，不能超过450位" )]
        public string DrugName { get; set; }
        /// <summary>
        /// 别名
        /// </summary>
        [StringLength( 450, ErrorMessage = "别名输入过长，不能超过450位" )]
        public string Alias { get; set; }
        /// <summary>
        /// 药品分类
        /// </summary>
        [StringLength( 108, ErrorMessage = "药品分类输入过长，不能超过108位" )]
        public string DrugTypeId { get; set; }
        /// <summary>
        /// 药品分类
        /// </summary>
        [StringLength( 150, ErrorMessage = "药品分类输入过长，不能超过150位" )]
        public string DrugType { get; set; }
        /// <summary>
        /// 药品分类类型
        /// </summary>
        [StringLength( 1110, ErrorMessage = "药品分类类型输入过长，不能超过1110位" )]
        public string DrugTypeRelationShip { get; set; }
        /// <summary>
        /// 英文名
        /// </summary>
        [StringLength( 360, ErrorMessage = "英文名输入过长，不能超过360位" )]
        public string EnglishName { get; set; }
        /// <summary>
        /// 库房单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "库房单位输入过长，不能超过108位" )]
        public string StoreroomUnitId { get; set; }
        /// <summary>
        /// 库房单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "库房单位输入过长，不能超过300位" )]
        public string StoreroomUnit { get; set; }
        /// <summary>
        /// 使用单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "使用单位输入过长，不能超过108位" )]
        public string UseUnitId { get; set; }
        /// <summary>
        /// 使用单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "使用单位输入过长，不能超过300位" )]
        public string UseUnit { get; set; }
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "销售单位输入过长，不能超过108位" )]
        public string SalesUnitId { get; set; }
        /// <summary>
        /// 销售单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "销售单位输入过长，不能超过300位" )]
        public string SalesUnit { get; set; }
        /// <summary>
        /// 基本单位
        /// </summary>
        [StringLength( 108, ErrorMessage = "基本单位输入过长，不能超过108位" )]
        public string BasicUnitId { get; set; }
        /// <summary>
        /// 基本单位
        /// </summary>
        [StringLength( 300, ErrorMessage = "基本单位输入过长，不能超过300位" )]
        public string BasicUnit { get; set; }
        /// <summary>
        /// 是否按照实际库存卖
        /// </summary>
        public sbyte? IsActualInventory { get; set; }
        /// <summary>
        /// 库房比例
        /// </summary>
        public decimal? StoreroomRatio { get; set; }
        /// <summary>
        /// 销售比例
        /// </summary>
        public decimal? SalesRatio { get; set; }
        /// <summary>
        /// 常用剂量
        /// </summary>
        public decimal? CommonDose { get; set; }
        /// <summary>
        /// 儿童常用剂量
        /// </summary>
        public decimal? ChlidCommonDose { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        [StringLength( 108, ErrorMessage = "生产厂家输入过长，不能超过108位" )]
        public string ManufacturerId { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        [StringLength( 300, ErrorMessage = "生产厂家输入过长，不能超过300位" )]
        public string Manufacturer { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        [StringLength( 300, ErrorMessage = "规格输入过长，不能超过300位" )]
        public string Format { get; set; }
        /// <summary>
        /// 产地
        /// </summary>
        [StringLength( 600, ErrorMessage = "产地输入过长，不能超过600位" )]
        public string Place { get; set; }
        /// <summary>
        /// 下限提醒
        /// </summary>
        public int? LowerLimit { get; set; }
        /// <summary>
        /// 是否为处方药品
        /// </summary>
        public int? IsPrescription { get; set; }
        /// <summary>
        ///  药品通用码（869）
        /// </summary>
        [StringLength( 108, ErrorMessage = " 药品通用码（869）输入过长，不能超过108位" )]
        public string DrugCommCode { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 600, ErrorMessage = "备注输入过长，不能超过600位" )]
        public string Remarks { get; set; }
        /// <summary>
        /// 使用说明书地址
        /// </summary>
        [StringLength( 600, ErrorMessage = "使用说明书地址输入过长，不能超过600位" )]
        public string UsePath { get; set; }
        /// <summary>
        /// 药品图片
        /// </summary>
        [StringLength( 450, ErrorMessage = "药品图片输入过长，不能超过450位" )]
        public string Img { get; set; }
        /// <summary>
        /// DDD规格
        /// </summary>
        public decimal? DddFomat { get; set; }
        /// <summary>
        /// DDD值
        /// </summary>
        public decimal? DddValue { get; set; }
        /// <summary>
        /// 拼音简拼
        /// </summary>
        [StringLength( 150, ErrorMessage = "拼音简拼输入过长，不能超过150位" )]
        public string PinYin { get; set; }
        /// <summary>
        /// 全拼
        /// </summary>
        [StringLength( 450, ErrorMessage = "全拼输入过长，不能超过450位" )]
        public string FullPinYin { get; set; }
        /// <summary>
        /// 五笔
        /// </summary>
        [StringLength( 240, ErrorMessage = "五笔输入过长，不能超过240位" )]
        public string Wubi { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Required(ErrorMessage = "排序不能为空")]
        public int Sort { get; set; }
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