using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Essentialinformations {
    /// <summary>
    /// 门店数据传输对象
    /// </summary>
    [DataContract]
    public class StoreDto : BaseDto {
        /// <summary>
        /// 租户名
        /// </summary>
        [Required(ErrorMessage = "租户名不能为空")]
        [StringLength( 640, ErrorMessage = "租户名输入过长，不能超过640位" )]
        [Display( Name = "租户名" )]
        [DataMember]
        public string TenantName { get; set; }
        
        /// <summary>
        /// 店长编号
        /// </summary>
        [Required(ErrorMessage = "店长编号不能为空")]
        [StringLength( 144, ErrorMessage = "店长编号输入过长，不能超过144位" )]
        [Display( Name = "店长编号" )]
        [DataMember]
        public string UserId { get; set; }
        
        /// <summary>
        /// 联系人
        /// </summary>
        [StringLength( 160, ErrorMessage = "联系人输入过长，不能超过160位" )]
        [Display( Name = "联系人" )]
        [DataMember]
        public string TelName { get; set; }
        
        /// <summary>
        /// 联系地址
        /// </summary>
        [StringLength( 640, ErrorMessage = "联系地址输入过长，不能超过640位" )]
        [Display( Name = "联系地址" )]
        [DataMember]
        public string Address { get; set; }
        
        /// <summary>
        /// 联系电话
        /// </summary>
        [Required(ErrorMessage = "联系电话不能为空")]
        [StringLength( 44, ErrorMessage = "联系电话输入过长，不能超过44位" )]
        [Display( Name = "联系电话" )]
        [DataMember]
        public string TelPhone { get; set; }
        
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 坐标
        /// </summary>
        [StringLength( 320, ErrorMessage = "坐标输入过长，不能超过320位" )]
        [Display( Name = "坐标" )]
        [DataMember]
        public string Coordinate { get; set; }
        
    }
}
