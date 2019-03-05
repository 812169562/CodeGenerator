using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Essentialinformations {
    /// <summary>
    /// 人员部门信息数据传输对象
    /// </summary>
    [DataContract]
    public class UserdepartmentDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 用户编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "用户编号输入过长，不能超过144位" )]
        [Display( Name = "用户编号" )]
        [DataMember]
        public string UserId { get; set; }
        
        /// <summary>
        /// 部门编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "部门编号输入过长，不能超过144位" )]
        [Display( Name = "部门编号" )]
        [DataMember]
        public string DepartmentId { get; set; }
        
    }
}
