using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Datas.Mapping.Medicinestores {
    /// <summary>
    /// 药品调拨映射配置
    /// </summary>
    public class DrugallotMapping : BaseEntityMap<Drugallot> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Drugallot> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Drugallot> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Drugallot> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Drugallot> builder) {
        }
    }
}
