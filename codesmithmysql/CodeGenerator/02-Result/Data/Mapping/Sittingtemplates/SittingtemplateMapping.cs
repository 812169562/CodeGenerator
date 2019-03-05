using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Sittingtemplates;

namespace Sand.Datas.Mapping.Sittingtemplates {
    /// <summary>
    ///  坐诊模板映射配置
    /// </summary>
    public class SittingtemplateMapping : BaseEntityMap<Sittingtemplate> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Sittingtemplate> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Sittingtemplate> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Sittingtemplate> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Sittingtemplate> builder) {
        }
    }
}
