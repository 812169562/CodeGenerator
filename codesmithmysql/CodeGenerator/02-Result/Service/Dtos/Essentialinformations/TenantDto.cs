using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Essentialinformations {
    /// <summary>
    /// 医馆数据传输对象
    /// </summary>
    [DataContract]
    public class TenantDto : BaseDto {
        /// <summary>
        /// 医馆名
        /// </summary>
        [Required(ErrorMessage = "医馆名不能为空")]
        [StringLength( 640, ErrorMessage = "医馆名输入过长，不能超过640位" )]
        [Display( Name = "医馆名" )]
        [DataMember]
        public string TenantName { get; set; }
        
        /// <summary>
        /// 用户号
        /// </summary>
        [Required(ErrorMessage = "用户号不能为空")]
        [StringLength( 144, ErrorMessage = "用户号输入过长，不能超过144位" )]
        [Display( Name = "用户号" )]
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
        /// 坐标
        /// </summary>
        [StringLength( 320, ErrorMessage = "坐标输入过长，不能超过320位" )]
        [Display( Name = "坐标" )]
        [DataMember]
        public string Coordinate { get; set; }
        
        /// <summary>
        /// 营业证书
        /// </summary>
        [StringLength( 144, ErrorMessage = "营业证书输入过长，不能超过144位" )]
        [Display( Name = "营业证书" )]
        [DataMember]
        public string BusinessCertificate { get; set; }
        
        /// <summary>
        /// 最大门店数量
        /// </summary>
        [Display( Name = "最大门店数量" )]
        [DataMember]
        public int? MaxStore { get; set; }
        
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 144, ErrorMessage = "代码输入过长，不能超过144位" )]
        [Display( Name = "代码" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 结束日期
        /// </summary>
        [Display( Name = "结束日期" )]
        [DataMember]
        public DateTime? EndTime { get; set; }
        
        /// <summary>
        /// 简介
        /// </summary>
        [StringLength( 1600, ErrorMessage = "简介输入过长，不能超过1600位" )]
        [Display( Name = "简介" )]
        [DataMember]
        public string Description { get; set; }
        
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        [Display( Name = "类型" )]
        [DataMember]
        public int Type { get; set; }
        
    }
}
