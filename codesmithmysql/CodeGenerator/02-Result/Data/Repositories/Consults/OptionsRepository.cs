using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Consults;
using Sand.Domain.Repositories.Consults;

namespace Sand.Data.Repositories.Consults {
    /// <summary>
    /// 选项表仓储
    /// </summary>
    public class OptionsRepository : EfRepository<Options>, IOptionsRepository {
        /// <summary>
        /// 初始化选项表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public OptionsRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
