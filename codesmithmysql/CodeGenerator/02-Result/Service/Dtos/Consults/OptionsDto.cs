using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Consults {
    /// <summary>
    /// 选项表数据传输对象
    /// </summary>
    [DataContract]
    public class OptionsDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 选项值
        /// </summary>
        [Display( Name = "选项值" )]
        [DataMember]
        public int? Value { get; set; }
        
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 144, ErrorMessage = "父级输入过长，不能超过144位" )]
        [Display( Name = "父级" )]
        [DataMember]
        public string QuestionnaireId { get; set; }
        
        /// <summary>
        /// 问卷名称
        /// </summary>
        [StringLength( 400, ErrorMessage = "问卷名称输入过长，不能超过400位" )]
        [Display( Name = "问卷名称" )]
        [DataMember]
        public string Name { get; set; }
        
    }
}
