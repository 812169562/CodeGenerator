using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Essentialinformations {
    /// <summary>
    /// 租户用户多对多关系表数据传输对象
    /// </summary>
    [DataContract]
    public class TenantuserrelationDto : BaseDto {
        /// <summary>
        /// 用户编号
        /// </summary>
        [Required(ErrorMessage = "用户编号不能为空")]
        [StringLength( 144, ErrorMessage = "用户编号输入过长，不能超过144位" )]
        [Display( Name = "用户编号" )]
        [DataMember]
        public string UserId { get; set; }
        
    }
}
