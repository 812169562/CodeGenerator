using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Sittingtemplates;

namespace Sand.Datas.Mapping.Sittingtemplates {
    /// <summary>
    ///  医生坐诊表映射配置
    /// </summary>
    public class SittingMapping : BaseEntityMap<Sitting> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Sitting> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Sitting> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Sitting> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Sitting> builder) {
        }
    }
}
