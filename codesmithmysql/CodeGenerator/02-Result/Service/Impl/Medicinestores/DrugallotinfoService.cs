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
    /// 调拨明细表服务
    /// </summary>
    public class DrugallotinfoService : BaseService<DrugallotinfoDto, DrugallotinfoQuery,Drugallotinfo>, IDrugallotinfoService {
        /// <summary>
        /// 调拨明细表仓储
        /// </summary>
        private readonly IDrugallotinfoRepository _drugallotinfoRepository;
        
        /// <summary>
        /// 初始化调拨明细表服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="drugallotinfoRepository">调拨明细表仓储</param>
        public DrugallotinfoService( IUnitOfWork uow, IDrugallotinfoRepository drugallotinfoRepository)
            : base( uow, drugallotinfoRepository ) {
           _drugallotinfoRepository = drugallotinfoRepository;
        }
        
         /// <summary>
        /// 创建调拨明细表条件表达式
        /// </summary>
        /// <param name="drugallotinfoQuery">调拨明细表查询对象</param>
        /// <returns>调拨明细表查询表达式</returns>
        protected override Expression<Func<Drugallotinfo, bool>> CreateQuery(DrugallotinfoQuery drugallotinfoQuery)
        {
           return  base.CreateQuery(drugallotinfoQuery);
        }
    }
}