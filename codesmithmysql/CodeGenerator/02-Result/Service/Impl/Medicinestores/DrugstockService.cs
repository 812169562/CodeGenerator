using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Queries.Medicinestores;
using Sand.Service.Dtos.Medicinestores;
using Sand.Service.Contract.Medicinestores;
using Sand.Data.Repositories.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Service.Impl.Medicinestores {
    /// <summary>
    /// 库存(均以销售单位为库存量)服务
    /// </summary>
    public class DrugstockService : BaseService<DrugstockDto, DrugstockQuery,Drugstock>, IDrugstockService {
        /// <summary>
        /// 库存(均以销售单位为库存量)仓储
        /// </summary>
        private readonly IDrugstockRepository _drugstockRepository;
        
        /// <summary>
        /// 初始化库存(均以销售单位为库存量)服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="drugstockRepository">库存(均以销售单位为库存量)仓储</param>
        public DrugstockService( IUnitOfWork uow, IDrugstockRepository drugstockRepository)
            : base( uow, drugstockRepository ) {
           _drugstockRepository = drugstockRepository;
        }
        
         /// <summary>
        /// 创建库存(均以销售单位为库存量)条件表达式
        /// </summary>
        /// <param name="drugstockQuery">库存(均以销售单位为库存量)查询对象</param>
        /// <returns>库存(均以销售单位为库存量)查询表达式</returns>
        protected override Expression<Func<Drugstock, bool>> CreateQuery(DrugstockQuery drugstockQuery)
        {
           return  base.CreateQuery(drugstockQuery);
        }
    }
}