using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Consults {
    /// <summary>
    /// 咨询数据传输对象
    /// </summary>
    [DataContract]
    public class ConsultDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 咨询内容
        /// </summary>
        [StringLength( 300, ErrorMessage = "咨询内容输入过长，不能超过300位" )]
        [Display( Name = "咨询内容" )]
        [DataMember]
        public string Content { get; set; }
        
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 108, ErrorMessage = "父级输入过长，不能超过108位" )]
        [Display( Name = "父级" )]
        [DataMember]
        public string Initial { get; set; }
        
        /// <summary>
        /// 结果
        /// </summary>
        [Display( Name = "结果" )]
        [DataMember]
        public int? Result { get; set; }
        
        /// <summary>
        /// 评价
        /// </summary>
        [StringLength( 300, ErrorMessage = "评价输入过长，不能超过300位" )]
        [Display( Name = "评价" )]
        [DataMember]
        public string Evaluate { get; set; }
        
    }
}
