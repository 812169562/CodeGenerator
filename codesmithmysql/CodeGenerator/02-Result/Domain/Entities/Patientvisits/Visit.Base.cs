using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Patientvisits {
    /// <summary>
    /// 就诊信息
    /// </summary>
    [Description( "就诊信息" )]
    public partial class Visit : Entity,ISoftDelete {
        /// <summary>
        /// 初始化就诊信息
        /// </summary>
        public Visit(){
        }
        /// <summary>
        /// 患者编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "患者编号输入过长，不能超过144位" )]
        public string PatId { get; set; }
        /// <summary>
        /// 挂号编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "挂号编号输入过长，不能超过144位" )]
        public string RegisterId { get; set; }
        /// <summary>
        /// 发病日期
        /// </summary>
        public DateTime? DiseaseDate { get; set; }
        /// <summary>
        /// 舒张压
        /// </summary>
        [StringLength( 40, ErrorMessage = "舒张压输入过长，不能超过40位" )]
        public string DiastolicPressure { get; set; }
        /// <summary>
        /// 收缩压
        /// </summary>
        [StringLength( 40, ErrorMessage = "收缩压输入过长，不能超过40位" )]
        public string SystolicPressure { get; set; }
        /// <summary>
        /// 主诉
        /// </summary>
        [StringLength( 800, ErrorMessage = "主诉输入过长，不能超过800位" )]
        public string ChiefComplaint { get; set; }
        /// <summary>
        /// 现病史
        /// </summary>
        [StringLength( 4000, ErrorMessage = "现病史输入过长，不能超过4000位" )]
        public string PresentIllness { get; set; }
        /// <summary>
        /// 既往史
        /// </summary>
        [StringLength( 4000, ErrorMessage = "既往史输入过长，不能超过4000位" )]
        public string PastIllness { get; set; }
        /// <summary>
        /// 个人史
        /// </summary>
        [StringLength( 2400, ErrorMessage = "个人史输入过长，不能超过2400位" )]
        public string SelefHistory { get; set; }
        /// <summary>
        /// 家族史
        /// </summary>
        [StringLength( 2400, ErrorMessage = "家族史输入过长，不能超过2400位" )]
        public string FamilyHistory { get; set; }
        /// <summary>
        /// 月经史
        /// </summary>
        [StringLength( 2400, ErrorMessage = "月经史输入过长，不能超过2400位" )]
        public string MenstrualHistory { get; set; }
        /// <summary>
        /// 辅助检查
        /// </summary>
        [StringLength( 4000, ErrorMessage = "辅助检查输入过长，不能超过4000位" )]
        public string SupplementaryExamination { get; set; }
        /// <summary>
        /// 体格检查
        /// </summary>
        [StringLength( 4000, ErrorMessage = "体格检查输入过长，不能超过4000位" )]
        public string Physicalexamination { get; set; }
        /// <summary>
        /// 治疗意见
        /// </summary>
        [StringLength( 4000, ErrorMessage = "治疗意见输入过长，不能超过4000位" )]
        public string TreatmentOpinion { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        [StringLength( 2400, ErrorMessage = "图片输入过长，不能超过2400位" )]
        public string ImgPath { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 4000, ErrorMessage = "备注输入过长，不能超过4000位" )]
        public string Remark { get; set; }
         /// <summary>
        /// 删除标志
        /// </summary>
        [Required(ErrorMessage = "删除标志不能为空")]
        public bool IsDeleted { get; set; }
        
        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init()
        {
            this.Id = Uuid.Next();
            base.Init();
        }
 
        /// <summary>
        /// 加载
        /// </summary>
        public override void Load(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}