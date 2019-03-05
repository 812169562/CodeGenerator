using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Data.Repositories.Essentialinformations {
    /// <summary>
    /// 资源仓储
    /// </summary>
    public class ResourceRepository : EfRepository<Resource>, IResourceRepository {
        /// <summary>
        /// 初始化资源仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public ResourceRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
