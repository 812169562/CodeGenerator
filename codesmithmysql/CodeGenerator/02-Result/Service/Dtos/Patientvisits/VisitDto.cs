using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Patientvisits {
    /// <summary>
    /// 就诊信息数据传输对象
    /// </summary>
    [DataContract]
    public class VisitDto : BaseDto {
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
        /// 挂号编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "挂号编号输入过长，不能超过144位" )]
        [Display( Name = "挂号编号" )]
        [DataMember]
        public string RegisterId { get; set; }
        
        /// <summary>
        /// 发病日期
        /// </summary>
        [Display( Name = "发病日期" )]
        [DataMember]
        public DateTime? DiseaseDate { get; set; }
        
        /// <summary>
        /// 舒张压
        /// </summary>
        [StringLength( 40, ErrorMessage = "舒张压输入过长，不能超过40位" )]
        [Display( Name = "舒张压" )]
        [DataMember]
        public string DiastolicPressure { get; set; }
        
        /// <summary>
        /// 收缩压
        /// </summary>
        [StringLength( 40, ErrorMessage = "收缩压输入过长，不能超过40位" )]
        [Display( Name = "收缩压" )]
        [DataMember]
        public string SystolicPressure { get; set; }
        
        /// <summary>
        /// 主诉
        /// </summary>
        [StringLength( 800, ErrorMessage = "主诉输入过长，不能超过800位" )]
        [Display( Name = "主诉" )]
        [DataMember]
        public string ChiefComplaint { get; set; }
        
        /// <summary>
        /// 现病史
        /// </summary>
        [StringLength( 4000, ErrorMessage = "现病史输入过长，不能超过4000位" )]
        [Display( Name = "现病史" )]
        [DataMember]
        public string PresentIllness { get; set; }
        
        /// <summary>
        /// 既往史
        /// </summary>
        [StringLength( 4000, ErrorMessage = "既往史输入过长，不能超过4000位" )]
        [Display( Name = "既往史" )]
        [DataMember]
        public string PastIllness { get; set; }
        
        /// <summary>
        /// 个人史
        /// </summary>
        [StringLength( 2400, ErrorMessage = "个人史输入过长，不能超过2400位" )]
        [Display( Name = "个人史" )]
        [DataMember]
        public string SelefHistory { get; set; }
        
        /// <summary>
        /// 家族史
        /// </summary>
        [StringLength( 2400, ErrorMessage = "家族史输入过长，不能超过2400位" )]
        [Display( Name = "家族史" )]
        [DataMember]
        public string FamilyHistory { get; set; }
        
        /// <summary>
        /// 月经史
        /// </summary>
        [StringLength( 2400, ErrorMessage = "月经史输入过长，不能超过2400位" )]
        [Display( Name = "月经史" )]
        [DataMember]
        public string MenstrualHistory { get; set; }
        
        /// <summary>
        /// 辅助检查
        /// </summary>
        [StringLength( 4000, ErrorMessage = "辅助检查输入过长，不能超过4000位" )]
        [Display( Name = "辅助检查" )]
        [DataMember]
        public string SupplementaryExamination { get; set; }
        
        /// <summary>
        /// 体格检查
        /// </summary>
        [StringLength( 4000, ErrorMessage = "体格检查输入过长，不能超过4000位" )]
        [Display( Name = "体格检查" )]
        [DataMember]
        public string Physicalexamination { get; set; }
        
        /// <summary>
        /// 治疗意见
        /// </summary>
        [StringLength( 4000, ErrorMessage = "治疗意见输入过长，不能超过4000位" )]
        [Display( Name = "治疗意见" )]
        [DataMember]
        public string TreatmentOpinion { get; set; }
        
        /// <summary>
        /// 图片
        /// </summary>
        [StringLength( 2400, ErrorMessage = "图片输入过长，不能超过2400位" )]
        [Display( Name = "图片" )]
        [DataMember]
        public string ImgPath { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 4000, ErrorMessage = "备注输入过长，不能超过4000位" )]
        [Display( Name = "备注" )]
        [DataMember]
        public string Remark { get; set; }
        
    }
}
