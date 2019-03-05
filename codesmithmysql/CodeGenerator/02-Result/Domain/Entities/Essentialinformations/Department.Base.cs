using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Essentialinformations {
    /// <summary>
    /// 部门信息
    /// </summary>
    [Description( "部门信息" )]
    public partial class Department : Entity,ISoftDelete {
        /// <summary>
        /// 初始化部门信息
        /// </summary>
        public Department(){
        }
        /// <summary>
        /// 类型
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 144, ErrorMessage = "代码输入过长，不能超过144位" )]
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength( 400, ErrorMessage = "名称输入过长，不能超过400位" )]
        public string Name { get; set; }
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
        /// 五笔
        /// </summary>
        [StringLength( 320, ErrorMessage = "五笔输入过长，不能超过320位" )]
        public string Wubi { get; set; }
        /// <summary>
        /// 关系
        /// </summary>
        [StringLength( 1480, ErrorMessage = "关系输入过长，不能超过1480位" )]
        public string RelationShip { get; set; }
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 144, ErrorMessage = "父级输入过长，不能超过144位" )]
        public string Parent { get; set; }
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
        /// 是否可共享科室患者
        /// </summary>
        public sbyte? IsSharePatient { get; set; }
        /// <summary>
        /// 是否为执行科室
        /// </summary>
        public sbyte? IsExecute { get; set; }
        /// <summary>
        /// 是否为药房
        /// </summary>
        public sbyte? IsPharmacy { get; set; }
        /// <summary>
        /// 是否为库房
        /// </summary>
        public sbyte? IsStorageRoom { get; set; }
        /// <summary>
        /// 科室挂号费
        /// </summary>
        public decimal? RegisterPrice { get; set; }
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