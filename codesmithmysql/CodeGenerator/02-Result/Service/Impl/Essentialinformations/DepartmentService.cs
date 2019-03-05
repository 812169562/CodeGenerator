using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;
using Sand.Service.Contract.Essentialinformations;
using Sand.Data.Repositories.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Service.Impl.Essentialinformations {
    /// <summary>
    /// 部门信息服务
    /// </summary>
    public class DepartmentService : BaseService<DepartmentDto, DepartmentQuery,Department>, IDepartmentService {
        /// <summary>
        /// 部门信息仓储
        /// </summary>
        private readonly IDepartmentRepository _departmentRepository;
        
        /// <summary>
        /// 初始化部门信息服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="departmentRepository">部门信息仓储</param>
        public DepartmentService( IUnitOfWork uow, IDepartmentRepository departmentRepository)
            : base( uow, departmentRepository ) {
           _departmentRepository = departmentRepository;
        }
        
         /// <summary>
        /// 创建部门信息条件表达式
        /// </summary>
        /// <param name="departmentQuery">部门信息查询对象</param>
        /// <returns>部门信息查询表达式</returns>
        protected override Expression<Func<Department, bool>> CreateQuery(DepartmentQuery departmentQuery)
        {
           return  base.CreateQuery(departmentQuery);
        }
    }
}