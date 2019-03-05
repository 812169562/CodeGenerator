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
    /// 人员部门信息服务
    /// </summary>
    public class UserdepartmentService : BaseService<UserdepartmentDto, UserdepartmentQuery,Userdepartment>, IUserdepartmentService {
        /// <summary>
        /// 人员部门信息仓储
        /// </summary>
        private readonly IUserdepartmentRepository _userdepartmentRepository;
        
        /// <summary>
        /// 初始化人员部门信息服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="userdepartmentRepository">人员部门信息仓储</param>
        public UserdepartmentService( IUnitOfWork uow, IUserdepartmentRepository userdepartmentRepository)
            : base( uow, userdepartmentRepository ) {
           _userdepartmentRepository = userdepartmentRepository;
        }
        
         /// <summary>
        /// 创建人员部门信息条件表达式
        /// </summary>
        /// <param name="userdepartmentQuery">人员部门信息查询对象</param>
        /// <returns>人员部门信息查询表达式</returns>
        protected override Expression<Func<Userdepartment, bool>> CreateQuery(UserdepartmentQuery userdepartmentQuery)
        {
           return  base.CreateQuery(userdepartmentQuery);
        }
    }
}