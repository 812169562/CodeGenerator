using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Orders;

namespace Sand.Datas.Mapping.Orders {
    /// <summary>
    ///  支付信息明细映射配置
    /// </summary>
    public class PaymentinformationdetailMapping : BaseEntityMap<Paymentinformationdetail> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Paymentinformationdetail> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Paymentinformationdetail> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Paymentinformationdetail> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Paymentinformationdetail> builder) {
        }
    }
}
