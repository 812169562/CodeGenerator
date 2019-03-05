using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Consults {
    /// <summary>
    /// 问卷表数据传输对象
    /// </summary>
    [DataContract]
    public class QuestionnaireDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        ///  标题
        /// </summary>
        [StringLength( 400, ErrorMessage = " 标题输入过长，不能超过400位" )]
        [Display( Name = " 标题" )]
        [DataMember]
        public string Title { get; set; }
        
        /// <summary>
        /// 内容
        /// </summary>
        [StringLength( 65535, ErrorMessage = "内容输入过长，不能超过65535位" )]
        [Display( Name = "内容" )]
        [DataMember]
        public string Context { get; set; }
        
        /// <summary>
        /// 回答类，问卷类）
        /// </summary>
        [Display( Name = "回答类，问卷类）" )]
        [DataMember]
        public int? Type { get; set; }
        
    }
}
