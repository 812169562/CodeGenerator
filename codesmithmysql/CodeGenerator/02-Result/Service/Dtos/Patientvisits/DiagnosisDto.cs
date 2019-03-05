using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Patientvisits {
    /// <summary>
    /// 诊断信息数据传输对象
    /// </summary>
    [DataContract]
    public class DiagnosisDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 患者编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "患者编号输入过长，不能超过144位" )]
        [Display( Name = "患者编号" )]
        [DataMember]
        public string PatId { get; set; }
        
        /// <summary>
        /// 就诊编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "就诊编号输入过长，不能超过144位" )]
        [Display( Name = "就诊编号" )]
        [DataMember]
        public string VisitId { get; set; }
        
        /// <summary>
        /// 诊断类型(1.中医,2.西医)
        /// </summary>
        [Display( Name = "诊断类型(1.中医,2.西医)" )]
        [DataMember]
        public int? Type { get; set; }
        
        /// <summary>
        /// 诊断编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "诊断编号输入过长，不能超过144位" )]
        [Display( Name = "诊断编号" )]
        [DataMember]
        public string DiagnosisId { get; set; }
        
        /// <summary>
        /// 诊断名
        /// </summary>
        [StringLength( 400, ErrorMessage = "诊断名输入过长，不能超过400位" )]
        [Display( Name = "诊断名" )]
        [DataMember]
        public string DiagnosisName { get; set; }
        
        /// <summary>
        /// 附加诊断编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "附加诊断编号输入过长，不能超过144位" )]
        [Display( Name = "附加诊断编号" )]
        [DataMember]
        public string AttachDiagnosisId { get; set; }
        
        /// <summary>
        /// 附加诊断名称(部分诊断Icd只能作为附加诊断)
        /// </summary>
        [StringLength( 400, ErrorMessage = "附加诊断名称(部分诊断Icd只能作为附加诊断)输入过长，不能超过400位" )]
        [Display( Name = "附加诊断名称(部分诊断Icd只能作为附加诊断)" )]
        [DataMember]
        public string AttachDiagnosisName { get; set; }
        
        /// <summary>
        /// 证型编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "证型编号输入过长，不能超过144位" )]
        [Display( Name = "证型编号" )]
        [DataMember]
        public string SyndromeId { get; set; }
        
        /// <summary>
        /// 证型
        /// </summary>
        [StringLength( 400, ErrorMessage = "证型输入过长，不能超过400位" )]
        [Display( Name = "证型" )]
        [DataMember]
        public string SyndromeName { get; set; }
        
        /// <summary>
        /// 证型编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "证型编号输入过长，不能超过144位" )]
        [Display( Name = "证型编号" )]
        [DataMember]
        public string SyndromeId2 { get; set; }
        
        /// <summary>
        /// 证型
        /// </summary>
        [StringLength( 400, ErrorMessage = "证型输入过长，不能超过400位" )]
        [Display( Name = "证型" )]
        [DataMember]
        public string SyndromeName2 { get; set; }
        
        /// <summary>
        /// 证型编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "证型编号输入过长，不能超过144位" )]
        [Display( Name = "证型编号" )]
        [DataMember]
        public string SyndromeId3 { get; set; }
        
        /// <summary>
        /// 证型
        /// </summary>
        [StringLength( 400, ErrorMessage = "证型输入过长，不能超过400位" )]
        [Display( Name = "证型" )]
        [DataMember]
        public string SyndromeName3 { get; set; }
        
    }
}
