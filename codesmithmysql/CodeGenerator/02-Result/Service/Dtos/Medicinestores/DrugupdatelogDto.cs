using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Medicinestores {
    /// <summary>
    /// 药品更新日志数据传输对象
    /// </summary>
    [DataContract]
    public class DrugupdatelogDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 药品编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "药品编号输入过长，不能超过108位" )]
        [Display( Name = "药品编号" )]
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
