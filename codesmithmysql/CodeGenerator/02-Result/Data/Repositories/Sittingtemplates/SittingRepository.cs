using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Sittingtemplates;
using Sand.Domain.Repositories.Sittingtemplates;

namespace Sand.Data.Repositories.Sittingtemplates {
    /// <summary>
    ///  医生坐诊表仓储
    /// </summary>
    public class SittingRepository : EfRepository<Sitting>, ISittingRepository {
        /// <summary>
        /// 初始化 医生坐诊表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public SittingRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
