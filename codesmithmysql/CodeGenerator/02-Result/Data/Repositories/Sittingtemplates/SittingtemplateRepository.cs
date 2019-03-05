using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Sittingtemplates;
using Sand.Domain.Repositories.Sittingtemplates;

namespace Sand.Data.Repositories.Sittingtemplates {
    /// <summary>
    ///  坐诊模板仓储
    /// </summary>
    public class SittingtemplateRepository : EfRepository<Sittingtemplate>, ISittingtemplateRepository {
        /// <summary>
        /// 初始化 坐诊模板仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public SittingtemplateRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
