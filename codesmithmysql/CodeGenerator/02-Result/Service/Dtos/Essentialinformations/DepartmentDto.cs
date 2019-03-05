using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sand.Service.Dtos.Essentialinformations {
    /// <summary>
    /// 部门信息数据传输对象
    /// </summary>
    [DataContract]
    public class DepartmentDto : BaseDto {
        /// <summary>
        /// 门店号
        /// </summary>
        [StringLength( 144, ErrorMessage = "门店号输入过长，不能超过144位" )]
        [Display( Name = "门店号" )]
        [DataMember]
        public string StroeId { get; set; }
        
        /// <summary>
        /// 类型
        /// </summary>
        [Display( Name = "类型" )]
        [DataMember]
        public int? Type { get; set; }
        
        /// <summary>
        /// 代码
        /// </summary>
        [StringLength( 144, ErrorMessage = "代码输入过长，不能超过144位" )]
        [Display( Name = "代码" )]
        [DataMember]
        public string Code { get; set; }
        
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength( 400, ErrorMessage = "名称输入过长，不能超过400位" )]
        [Display( Name = "名称" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 拼音简拼
        /// </summary>
        [StringLength( 200, ErrorMessage = "拼音简拼输入过长，不能超过200位" )]
        [Display( Name = "拼音简拼" )]
        [DataMember]
        public string PinYin { get; set; }
        
        /// <summary>
        /// 全拼
        /// </summary>
        [StringLength( 600, ErrorMessage = "全拼输入过长，不能超过600位" )]
        [Display( Name = "全拼" )]
        [DataMember]
        public string FullPinYin { get; set; }
        
        /// <summary>
        /// 五笔
        /// </summary>
        [StringLength( 320, ErrorMessage = "五笔输入过长，不能超过320位" )]
        [Display( Name = "五笔" )]
        [DataMember]
        public string Wubi { get; set; }
        
        /// <summary>
        /// 关系
        /// </summary>
        [StringLength( 1480, ErrorMessage = "关系输入过长，不能超过1480位" )]
        [Display( Name = "关系" )]
        [DataMember]
        public string RelationShip { get; set; }
        
        /// <summary>
        /// 父级
        /// </summary>
        [StringLength( 144, ErrorMessage = "父级输入过长，不能超过144位" )]
        [Display( Name = "父级" )]
        [DataMember]
        public string Parent { get; set; }
        
        /// <summary>
        /// 等级
        /// </summary>
        [Display( Name = "等级" )]
        [DataMember]
        public int? Level { get; set; }
        
        /// <summary>
        /// 排序
        /// </summary>
        [Required(ErrorMessage = "排序不能为空")]
        [Display( Name = "排序" )]
        [DataMember]
        public int Sort { get; set; }
        
        /// <summary>
        /// 是否可共享科室患者
        /// </summary>
        [Display( Name = "是否可共享科室患者" )]
        [DataMember]
        public sbyte? IsSharePatient { get; set; }
        
        /// <summary>
        /// 是否为执行科室
        /// </summary>
        [Display( Name = "是否为执行科室" )]
        [DataMember]
        public sbyte? IsExecute { get; set; }
        
        /// <summary>
        /// 是否为药房
        /// </summary>
        [Display( Name = "是否为药房" )]
        [DataMember]
        public sbyte? IsPharmacy { get; set; }
        
        /// <summary>
        /// 是否为库房
        /// </summary>
        [Display( Name = "是否为库房" )]
        [DataMember]
        public sbyte? IsStorageRoom { get; set; }
        
        /// <summary>
        /// 科室挂号费
        /// </summary>
        [Display( Name = "科室挂号费" )]
        [DataMember]
        public decimal? RegisterPrice { get; set; }
        
    }
}
