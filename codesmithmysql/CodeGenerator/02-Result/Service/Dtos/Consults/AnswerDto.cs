using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Consults {
    /// <summary>
    /// 答案表数据传输对象
    /// </summary>
    [DataContract]
    public class AnswerDto : BaseDto {
        /// <summary>
        /// 选项值
        /// </summary>
        [StringLength( 108, ErrorMessage = "选项值输入过长，不能超过108位" )]
        [Display( Name = "选项值" )]
        [DataMember]
        public string OptionsId { get; set; }
        
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 答案内容
        /// </summary>
        [StringLength( 300, ErrorMessage = "答案内容输入过长，不能超过300位" )]
        [Display( Name = "答案内容" )]
        [DataMember]
        public string Content { get; set; }
        
        /// <summary>
        /// 类型 （回答类，问卷类）
        /// </summary>
        [Display( Name = "类型 （回答类，问卷类）" )]
        [DataMember]
        public int? Type { get; set; }
        
        /// <summary>
        /// 选项值
        /// </summary>
        [Display( Name = "选项值" )]
        [DataMember]
        public int? Value { get; set; }
        
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 300, ErrorMessage = "父级输入过长，不能超过300位" )]
        [Display( Name = "父级" )]
        [DataMember]
        public string Suggestion { get; set; }
        
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 108, ErrorMessage = "父级输入过长，不能超过108位" )]
        [Display( Name = "父级" )]
        [DataMember]
        public string QuestionnaireId { get; set; }
        
    }
}
