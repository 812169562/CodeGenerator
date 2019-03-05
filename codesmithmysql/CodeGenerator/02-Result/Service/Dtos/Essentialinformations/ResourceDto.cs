using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Essentialinformations {
    /// <summary>
    /// 资源数据传输对象
    /// </summary>
    [DataContract]
    public class ResourceDto : BaseDto {
        /// <summary>
        /// 资源名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "资源名称输入过长，不能超过400位" )]
        [Display( Name = "资源名称" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 门店编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店编号输入过长，不能超过144位" )]
        [Display( Name = "门店编号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 144, ErrorMessage = "代码输入过长，不能超过144位" )]
        [Display( Name = "代码" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 关系
        /// </summary>
        [StringLength( 1480, ErrorMessage = "关系输入过长，不能超过1480位" )]
        [Display( Name = "关系" )]
        [DataMember]
        public string RelationShip { get; set; }
        
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 144, ErrorMessage = "父级输入过长，不能超过144位" )]
        [Display( Name = "父级" )]
        [DataMember]
        public string Parent { get; set; }
        
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
        
        /// <summary>
        /// 地址
        /// </summary>
        [StringLength( 400, ErrorMessage = "地址输入过长，不能超过400位" )]
        [Display( Name = "地址" )]
        [DataMember]
        public string Url { get; set; }
        
        /// <summary>
        /// 路径
        /// </summary>
        [StringLength( 400, ErrorMessage = "路径输入过长，不能超过400位" )]
        [Display( Name = "路径" )]
        [DataMember]
        public string Path { get; set; }
        
        /// <summary>
        /// 参数
        /// </summary>
        [StringLength( 400, ErrorMessage = "参数输入过长，不能超过400位" )]
        [Display( Name = "参数" )]
        [DataMember]
        public string Para { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength( 144, ErrorMessage = "输入过长，不能超过144位" )]
        [Display( Name = "" )]
        [DataMember]
        public string ApplicationsId { get; set; }
        
    }
}
