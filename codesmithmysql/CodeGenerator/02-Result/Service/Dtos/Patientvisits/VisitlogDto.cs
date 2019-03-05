using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Patientvisits {
    /// <summary>
    /// 就诊记录修改记录表数据传输对象
    /// </summary>
    [DataContract]
    public class VisitlogDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 就诊记录编号
        /// </summary>
        [StringLength( 144, ErrorMessage = "就诊记录编号输入过长，不能超过144位" )]
        [Display( Name = "就诊记录编号" )]
        [DataMember]
        public string DrugId { get; set; }
        
        /// <summary>
        /// 更新前数据
        /// </summary>
        [StringLength( 65535, ErrorMessage = "更新前数据输入过长，不能超过65535位" )]
        [Display( Name = "更新前数据" )]
        [DataMember]
        public string BeforeData { get; set; }
        
        /// <summary>
        /// 更新后数据
        /// </summary>
        [StringLength( 65535, ErrorMessage = "更新后数据输入过长，不能超过65535位" )]
        [Display( Name = "更新后数据" )]
        [DataMember]
        public string AfterData { get; set; }
        
    }
}
