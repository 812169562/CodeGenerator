using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Datas.Mapping.Essentialinformations {
    /// <summary>
    /// 租户用户多对多关系表映射配置
    /// </summary>
    public class TenantuserrelationMapping : BaseEntityMap<Tenantuserrelation> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Tenantuserrelation> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Tenantuserrelation> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Tenantuserrelation> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Tenantuserrelation> builder) {
        }
    }
}
