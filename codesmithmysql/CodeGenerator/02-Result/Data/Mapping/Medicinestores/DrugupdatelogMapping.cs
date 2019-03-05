using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Datas.Mapping.Medicinestores {
    /// <summary>
    /// 药品更新日志映射配置
    /// </summary>
    public class DrugupdatelogMapping : BaseEntityMap<Drugupdatelog> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Drugupdatelog> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Drugupdatelog> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Drugupdatelog> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Drugupdatelog> builder) {
        }
    }
}
