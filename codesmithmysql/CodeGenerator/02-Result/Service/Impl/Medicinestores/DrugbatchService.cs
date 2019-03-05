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
    /// 药品批次信息服务
    /// </summary>
    public class DrugbatchService : BaseService<DrugbatchDto, DrugbatchQuery,Drugbatch>, IDrugbatchService {
        /// <summary>
        /// 药品批次信息仓储
        /// </summary>
        private readonly IDrugbatchRepository _drugbatchRepository;
        
        /// <summary>
        /// 初始化药品批次信息服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="drugbatchRepository">药品批次信息仓储</param>
        public DrugbatchService( IUnitOfWork uow, IDrugbatchRepository drugbatchRepository)
            : base( uow, drugbatchRepository ) {
           _drugbatchRepository = drugbatchRepository;
        }
        
         /// <summary>
        /// 创建药品批次信息条件表达式
        /// </summary>
        /// <param name="drugbatchQuery">药品批次信息查询对象</param>
        /// <returns>药品批次信息查询表达式</returns>
        protected override Expression<Func<Drugbatch, bool>> CreateQuery(DrugbatchQuery drugbatchQuery)
        {
           return  base.CreateQuery(drugbatchQuery);
        }
    }
}