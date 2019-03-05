using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Datas.Mapping.Essentialinformations {
    /// <summary>
    /// 部门信息映射配置
    /// </summary>
    public class DepartmentMapping : BaseEntityMap<Department> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Department> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Department> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Department> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Department> builder) {
        }
    }
}
