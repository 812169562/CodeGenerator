using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Patientvisits {
    /// <summary>
    /// 诊断信息
    /// </summary>
    [Description( "诊断信息" )]
    public partial class Diagnosis : Entity,ISoftDelete {
        /// <summary>
        /// 初始化诊断信息
        /// </summary>
        public Diagnosis(){
        }
        /// <summary>
        /// 患者编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "患者编号输入过长，不能超过144位" )]
        public string PatId { get; set; }
        /// <summary>
        /// 就诊编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "就诊编号输入过长，不能超过144位" )]
        public string VisitId { get; set; }
        /// <summary>
        /// 诊断类型(1.中医,2.西医)
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 诊断编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "诊断编号输入过长，不能超过144位" )]
        public string DiagnosisId { get; set; }
        /// <summary>
        /// 诊断名
        /// </summary>
        [StringLength( 400, ErrorMessage = "诊断名输入过长，不能超过400位" )]
        public string DiagnosisName { get; set; }
        /// <summary>
        /// 附加诊断编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "附加诊断编号输入过长，不能超过144位" )]
        public string AttachDiagnosisId { get; set; }
        /// <summary>
        /// 附加诊断名称(部分诊断Icd只能作为附加诊断)
        /// </summary>
        [StringLength( 400, ErrorMessage = "附加诊断名称(部分诊断Icd只能作为附加诊断)输入过长，不能超过400位" )]
        public string AttachDiagnosisName { get; set; }
        /// <summary>
        /// 证型编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "证型编号输入过长，不能超过144位" )]
        public string SyndromeId { get; set; }
        /// <summary>
        /// 证型
        /// </summary>
        [StringLength( 400, ErrorMessage = "证型输入过长，不能超过400位" )]
        public string SyndromeName { get; set; }
        /// <summary>
        /// 证型编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "证型编号输入过长，不能超过144位" )]
        public string SyndromeId2 { get; set; }
        /// <summary>
        /// 证型
        /// </summary>
        [StringLength( 400, ErrorMessage = "证型输入过长，不能超过400位" )]
        public string SyndromeName2 { get; set; }
        /// <summary>
        /// 证型编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "证型编号输入过长，不能超过144位" )]
        public string SyndromeId3 { get; set; }
        /// <summary>
        /// 证型
        /// </summary>
        [StringLength( 400, ErrorMessage = "证型输入过长，不能超过400位" )]
        public string SyndromeName3 { get; set; }
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