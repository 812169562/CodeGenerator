using System;
using Sand.Helpers;
using Sand.Dependency;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Sand.Domain.Entities.Patientvisits {
    /// <summary>
    /// 四诊信息
    /// </summary>
    [Description( "四诊信息" )]
    public partial class Disease : Entity,ISoftDelete {
        /// <summary>
        /// 初始化四诊信息
        /// </summary>
        public Disease(){
        }
        /// <summary>
        /// 就诊编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "就诊编号输入过长，不能超过144位" )]
        public string VisitId { get; set; }
        /// <summary>
        /// 四诊数据编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "四诊数据编号输入过长，不能超过144位" )]
        public string DiseaseId { get; set; }
        /// <summary>
        /// 四诊信息说明
        /// </summary>
        [StringLength( 320, ErrorMessage = "四诊信息说明输入过长，不能超过320位" )]
        public string DiseaseName { get; set; }
        /// <summary>
        /// 轻重程度(-1代表无此症状,0轻微症状,1严重症状,2非常严重)
        /// </summary>
        public int? Degree { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Required(ErrorMessage = "排序不能为空")]
        public int Sort { get; set; }
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