using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Materials {
    /// <summary>
    /// 物资
    /// </summary>
    [Description( "物资" )]
    public partial class Material : Entity,ISoftDelete {
        /// <summary>
        /// 初始化物资
        /// </summary>
        public Material(){
        }
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "名称输入过长，不能超过400位" )]
        public string Name { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        [StringLength( 200, ErrorMessage = "编号输入过长，不能超过200位" )]
        public string Code { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        [StringLength( 200, ErrorMessage = "单位输入过长，不能超过200位" )]
        public string Unit { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        [StringLength( 400, ErrorMessage = "规格输入过长，不能超过400位" )]
        public string Specifications { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        [StringLength( 400, ErrorMessage = "品牌输入过长，不能超过400位" )]
        public string Trademark { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        [StringLength( 400, ErrorMessage = "型号输入过长，不能超过400位" )]
        public string Type { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        [StringLength( 144, ErrorMessage = "生产厂家输入过长，不能超过144位" )]
        public string ManufacturerId { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        [StringLength( 400, ErrorMessage = "生产厂家输入过长，不能超过400位" )]
        public string Manufacturer { get; set; }
        /// <summary>
        /// 采购时间
        /// </summary>
        public DateTime? PurchasingTime { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime? PeriodTime { get; set; }
        /// <summary>
        /// 产地
        /// </summary>
        [StringLength( 800, ErrorMessage = "产地输入过长，不能超过800位" )]
        public string Place { get; set; }
        /// <summary>
        /// 产地
        /// </summary>
        [StringLength( 4000, ErrorMessage = "产地输入过长，不能超过4000位" )]
        public string Remark { get; set; }
        /// <summary>
        /// 五笔
        /// </summary>
        [StringLength( 320, ErrorMessage = "五笔输入过长，不能超过320位" )]
        public string Wubi { get; set; }
        /// <summary>
        /// 拼音简拼
        /// </summary>
        [StringLength( 200, ErrorMessage = "拼音简拼输入过长，不能超过200位" )]
        public string PinYin { get; set; }
        /// <summary>
        /// 全拼
        /// </summary>
        [StringLength( 600, ErrorMessage = "全拼输入过长，不能超过600位" )]
        public string FullPinYin { get; set; }
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