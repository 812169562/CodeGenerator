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
    /// 药品调拨服务
    /// </summary>
    public class DrugallotService : BaseService<DrugallotDto, DrugallotQuery,Drugallot>, IDrugallotService {
        /// <summary>
        /// 药品调拨仓储
        /// </summary>
        private readonly IDrugallotRepository _drugallotRepository;
        
        /// <summary>
        /// 初始化药品调拨服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="drugallotRepository">药品调拨仓储</param>
        public DrugallotService( IUnitOfWork uow, IDrugallotRepository drugallotRepository)
            : base( uow, drugallotRepository ) {
           _drugallotRepository = drugallotRepository;
        }
        
         /// <summary>
        /// 创建药品调拨条件表达式
        /// </summary>
        /// <param name="drugallotQuery">药品调拨查询对象</param>
        /// <returns>药品调拨查询表达式</returns>
        protected override Expression<Func<Drugallot, bool>> CreateQuery(DrugallotQuery drugallotQuery)
        {
           return  base.CreateQuery(drugallotQuery);
        }
    }
}