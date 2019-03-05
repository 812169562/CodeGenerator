using Sand.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Datas.Mapping.Essentialinformations {
    /// <summary>
    /// 用户表映射配置
    /// </summary>
    public class UsersMapping : BaseEntityMap<Users> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable(EntityTypeBuilder<Users> builder) {
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties(EntityTypeBuilder<Users> builder) {
        }
        
        /// <summary>
        /// 拦截器
        /// </summary>
         protected override void MapSoftDelete(EntityTypeBuilder<Users> builder)
        {
            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
        
        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected override void MapAssociations(EntityTypeBuilder<Users> builder) {
        }
    }
}
