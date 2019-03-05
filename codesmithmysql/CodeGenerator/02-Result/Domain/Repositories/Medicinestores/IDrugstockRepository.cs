using Sand.Domain.Repositories;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Domain.Repositories.Medicinestores {
    /// <summary>
    /// 库存(均以销售单位为库存量)仓储
    /// </summary>
    public interface IDrugstockRepository : IRepository<Drugstock> {
    }
}
