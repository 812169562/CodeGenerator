using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Datas.Mapping.Medicinestores {
    /// <summary>
    /// 调拨明细表映射配置
    /// </summary>
    public class DrugallotinfoMapping : BaseEntityMap<Drugallotinfo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Drugallotinfo> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Drugallotinfo> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Drugallotinfo> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Drugallotinfo> builder) {
        }
    }
}
