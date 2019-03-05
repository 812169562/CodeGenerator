using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Orders;

namespace Sand.Datas.Mapping.Orders {
    /// <summary>
    /// 订单明细映射配置
    /// </summary>
    public class PrescriptionorderinfoMapping : BaseEntityMap<Prescriptionorderinfo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Prescriptionorderinfo> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Prescriptionorderinfo> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Prescriptionorderinfo> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Prescriptionorderinfo> builder) {
        }
    }
}
