using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Storages {
    /// <summary>
    /// 存储数据传输对象
    /// </summary>
    [DataContract]
    public class StoragesDto : BaseDto {
        /// <summary>
        /// 重新生成的名字
        /// </summary>
        [StringLength( 320, ErrorMessage = "重新生成的名字输入过长，不能超过320位" )]
        [Display( Name = "重新生成的名字" )]
        [DataMember]
        public string NewName { get; set; }
        
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 类型(用于区分压缩后文件比例等）
        /// </summary>
        [Required(ErrorMessage = "类型(用于区分压缩后文件比例等）不能为空")]
        [Display( Name = "类型(用于区分压缩后文件比例等）" )]
        [DataMember]
        public int Type { get; set; }
        
        /// <summary>
        /// 文件目录（上传的文件的分类）
        /// </summary>
        [Display( Name = "文件目录（上传的文件的分类）" )]
        [DataMember]
        public int? Catalog { get; set; }
        
        /// <summary>
        /// 文件全名
        /// </summary>
        [StringLength( 4000, ErrorMessage = "文件全名输入过长，不能超过4000位" )]
        [Display( Name = "文件全名" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 文件路径
        /// </summary>
        [StringLength( 6400, ErrorMessage = "文件路径输入过长，不能超过6400位" )]
        [Display( Name = "文件路径" )]
        [DataMember]
        public string Path { get; set; }
        
        /// <summary>
        /// 排序
        /// </summary>
        [Required(ErrorMessage = "排序不能为空")]
        [Display( Name = "排序" )]
        [DataMember]
        public int Sort { get; set; }
        
    }
}
