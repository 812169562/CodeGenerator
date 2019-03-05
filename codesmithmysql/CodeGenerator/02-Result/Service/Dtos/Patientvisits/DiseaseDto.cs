using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Patientvisits {
    /// <summary>
    /// 四诊信息数据传输对象
    /// </summary>
    [DataContract]
    public class DiseaseDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 就诊编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "就诊编号输入过长，不能超过144位" )]
        [Display( Name = "就诊编号" )]
        [DataMember]
        public string VisitId { get; set; }
        
        /// <summary>
        /// 四诊数据编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "四诊数据编号输入过长，不能超过144位" )]
        [Display( Name = "四诊数据编号" )]
        [DataMember]
        public string DiseaseId { get; set; }
        
        /// <summary>
        /// 四诊信息说明
        /// </summary>
        [StringLength( 320, ErrorMessage = "四诊信息说明输入过长，不能超过320位" )]
        [Display( Name = "四诊信息说明" )]
        [DataMember]
        public string DiseaseName { get; set; }
        
        /// <summary>
        /// 轻重程度(-1代表无此症状,0轻微症状,1严重症状,2非常严重)
        /// </summary>
        [Display( Name = "轻重程度(-1代表无此症状,0轻微症状,1严重症状,2非常严重)" )]
        [DataMember]
        public int? Degree { get; set; }
        
        /// <summary>
        /// 排序
        /// </summary>
        [Required(ErrorMessage = "排序不能为空")]
        [Display( Name = "排序" )]
        [DataMember]
        public int Sort { get; set; }
        
    }
}
