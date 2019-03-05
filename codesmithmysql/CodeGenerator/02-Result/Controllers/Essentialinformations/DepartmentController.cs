
using Sand.Domain.Queries.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;
using Sand.Service.Contract.Essentialinformations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Essentialinformations {
    /// <summary>
    /// Essentialinformations-部门信息服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DepartmentController : BaseApiController {
         /// <summary>
        /// 部门信息服务
        /// </summary>
        private readonly IDepartmentService _departmentService;
        
        /// <summary>
        /// 初始化部门信息控制器
        /// </summary>
        /// <param name="service">部门信息服务</param>
        public DepartmentController( IDepartmentService service ){
            _departmentService = service;
        }
        
        /// <summary>
        /// 查询部门信息信息
        /// </summary>
        /// <param name="departmentQuery">部门信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DepartmentQuery departmentQuery)
        {
            return Success(await  _departmentService.RetrieveAsync(departmentQuery));
        }
        
        /// <summary>
        /// 根据编号查询部门信息信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _departmentService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求部门信息分页信息
        /// </summary>
        /// <param name="departmentQuery">部门信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedepartment")]
        public async Task<IActionResult> Page(DepartmentQuery departmentQuery)
        {
            return Success(await _departmentService.PageAsync(departmentQuery));
        }
        
        /// <summary>
        /// 更新部门信息信息
        /// </summary>
        /// <param name="department">部门信息更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DepartmentDto department)
        {
           await _departmentService.UpdateAsync(department);
            return Success();
        }
        
         /// <summary>
        /// 新增部门信息信息
        /// </summary>
        /// <param name="department">部门信息信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DepartmentDto department)
        {
            return Success(await _departmentService.CreateAsync(department));
        }
        
        /// <summary>
        /// 删除部门信息信息
        /// </summary>
        /// <param name="department">部门信息信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DepartmentDto> department)
        {
            await _departmentService.DeleteAsync(department);
            return Success();
        }
        
        /// <summary>
        /// 停用部门信息信息
        /// </summary>
        /// <param name="department">部门信息信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdepartment")]
        public async Task<IActionResult> Stop(List<DepartmentDto> department, bool isEnable=false)
        {
            await _departmentService.StopOrEnableAsync(department, isEnable);
            return Success();
        }
    }
}