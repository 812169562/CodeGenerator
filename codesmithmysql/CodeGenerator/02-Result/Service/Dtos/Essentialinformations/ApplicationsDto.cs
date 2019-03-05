using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Essentialinformations {
    /// <summary>
    /// 应用程序数据传输对象
    /// </summary>
    [DataContract]
    public class ApplicationsDto : BaseDto {
        /// <summary>
        /// 应用程序名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "应用程序名称输入过长，不能超过400位" )]
        [Display( Name = "应用程序名称" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 144, ErrorMessage = "代码输入过长，不能超过144位" )]
        [Display( Name = "代码" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 主机
        /// </summary>
        [StringLength( 800, ErrorMessage = "主机输入过长，不能超过800位" )]
        [Display( Name = "主机" )]
        [DataMember]
        public string LocalHost { get; set; }
        
    }
}
