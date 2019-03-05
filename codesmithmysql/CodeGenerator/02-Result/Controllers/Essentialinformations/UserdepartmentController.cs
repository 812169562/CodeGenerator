
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
    /// Essentialinformations-人员部门信息服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class UserdepartmentController : BaseApiController {
         /// <summary>
        /// 人员部门信息服务
        /// </summary>
        private readonly IUserdepartmentService _userdepartmentService;
        
        /// <summary>
        /// 初始化人员部门信息控制器
        /// </summary>
        /// <param name="service">人员部门信息服务</param>
        public UserdepartmentController( IUserdepartmentService service ){
            _userdepartmentService = service;
        }
        
        /// <summary>
        /// 查询人员部门信息信息
        /// </summary>
        /// <param name="userdepartmentQuery">人员部门信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(UserdepartmentQuery userdepartmentQuery)
        {
            return Success(await  _userdepartmentService.RetrieveAsync(userdepartmentQuery));
        }
        
        /// <summary>
        /// 根据编号查询人员部门信息信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _userdepartmentService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求人员部门信息分页信息
        /// </summary>
        /// <param name="userdepartmentQuery">人员部门信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageuserdepartment")]
        public async Task<IActionResult> Page(UserdepartmentQuery userdepartmentQuery)
        {
            return Success(await _userdepartmentService.PageAsync(userdepartmentQuery));
        }
        
        /// <summary>
        /// 更新人员部门信息信息
        /// </summary>
        /// <param name="userdepartment">人员部门信息更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]UserdepartmentDto userdepartment)
        {
           await _userdepartmentService.UpdateAsync(userdepartment);
            return Success();
        }
        
         /// <summary>
        /// 新增人员部门信息信息
        /// </summary>
        /// <param name="userdepartment">人员部门信息信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]UserdepartmentDto userdepartment)
        {
            return Success(await _userdepartmentService.CreateAsync(userdepartment));
        }
        
        /// <summary>
        /// 删除人员部门信息信息
        /// </summary>
        /// <param name="userdepartment">人员部门信息信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<UserdepartmentDto> userdepartment)
        {
            await _userdepartmentService.DeleteAsync(userdepartment);
            return Success();
        }
        
        /// <summary>
        /// 停用人员部门信息信息
        /// </summary>
        /// <param name="userdepartment">人员部门信息信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopuserdepartment")]
        public async Task<IActionResult> Stop(List<UserdepartmentDto> userdepartment, bool isEnable=false)
        {
            await _userdepartmentService.StopOrEnableAsync(userdepartment, isEnable);
            return Success();
        }
    }
}