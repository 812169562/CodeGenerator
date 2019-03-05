using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Storages {
    /// <summary>
    /// 存储
    /// </summary>
    [Description( "存储" )]
    public partial class Storages : Entity,ISoftDelete {
        /// <summary>
        /// 初始化存储
        /// </summary>
        public Storages(){
        }
        /// <summary>
        /// 重新生成的名字
        /// </summary>
        [StringLength( 320, ErrorMessage = "重新生成的名字输入过长，不能超过320位" )]
        public string NewName { get; set; }
        /// <summary>
        /// 类型(用于区分压缩后文件比例等）
        /// </summary>
        [Required(ErrorMessage = "类型(用于区分压缩后文件比例等）不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 文件目录（上传的文件的分类）
        /// </summary>
        public int? Catalog { get; set; }
        /// <summary>
        /// 文件全名
        /// </summary>
        [StringLength( 4000, ErrorMessage = "文件全名输入过长，不能超过4000位" )]
        public string Name { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        [StringLength( 6400, ErrorMessage = "文件路径输入过长，不能超过6400位" )]
        public string Path { get; set; }
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