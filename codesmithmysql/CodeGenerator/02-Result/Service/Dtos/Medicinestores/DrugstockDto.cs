using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Medicinestores {
    /// <summary>
    /// 库存(均以销售单位为库存量)数据传输对象
    /// </summary>
    [DataContract]
    public class DrugstockDto : BaseDto {
        /// <summary>
        ///  门店
        /// </summary>
        [StringLength( 108, ErrorMessage = " 门店输入过长，不能超过108位" )]
        [Display( Name = " 门店" )]
        [DataMember]
        public string StroeName { get; set; }
        
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 108, ErrorMessage = "门店号输入过长，不能超过108位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 批次编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "批次编号输入过长，不能超过108位" )]
        [Display( Name = "批次编号" )]
        [DataMember]
        public string BatchId { get; set; }
        
        /// <summary>
        /// 药品编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "药品编号输入过长，不能超过108位" )]
        [Display( Name = "药品编号" )]
        [DataMember]
        public string DrugId { get; set; }
        
        /// <summary>
        /// 药房编号
        /// </summary>
        [StringLength( 108, ErrorMessage = "药房编号输入过长，不能超过108位" )]
        [Display( Name = "药房编号" )]
        [DataMember]
        public string DrugstoreId { get; set; }
        
        /// <summary>
        /// 药房
        /// </summary>
        [StringLength( 300, ErrorMessage = "药房输入过长，不能超过300位" )]
        [Display( Name = "药房" )]
        [DataMember]
        public string DrugstoreName { get; set; }
        
        /// <summary>
        /// 库存量(销售单位)
        /// </summary>
        [Display( Name = "库存量(销售单位)" )]
        [DataMember]
        public decimal? InventoryCount { get; set; }
        
        /// <summary>
        /// 锁定量
        /// </summary>
        [Display( Name = "锁定量" )]
        [DataMember]
        public decimal? LockCount { get; set; }
        
        /// <summary>
        /// 盘点顺序表
        /// </summary>
        [StringLength( 24, ErrorMessage = "盘点顺序表输入过长，不能超过24位" )]
        [Display( Name = "盘点顺序表" )]
        [DataMember]
        public string CheckNumber { get; set; }
        
    }
}
