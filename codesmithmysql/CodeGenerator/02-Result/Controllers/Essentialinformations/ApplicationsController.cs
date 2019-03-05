
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
    /// Essentialinformations-应用程序服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class ApplicationsController : BaseApiController {
         /// <summary>
        /// 应用程序服务
        /// </summary>
        private readonly IApplicationsService _applicationsService;
        
        /// <summary>
        /// 初始化应用程序控制器
        /// </summary>
        /// <param name="service">应用程序服务</param>
        public ApplicationsController( IApplicationsService service ){
            _applicationsService = service;
        }
        
        /// <summary>
        /// 查询应用程序信息
        /// </summary>
        /// <param name="applicationsQuery">应用程序查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(ApplicationsQuery applicationsQuery)
        {
            return Success(await  _applicationsService.RetrieveAsync(applicationsQuery));
        }
        
        /// <summary>
        /// 根据编号查询应用程序信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _applicationsService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求应用程序分页信息
        /// </summary>
        /// <param name="applicationsQuery">应用程序查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageapplications")]
        public async Task<IActionResult> Page(ApplicationsQuery applicationsQuery)
        {
            return Success(await _applicationsService.PageAsync(applicationsQuery));
        }
        
        /// <summary>
        /// 更新应用程序信息
        /// </summary>
        /// <param name="applications">应用程序更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]ApplicationsDto applications)
        {
           await _applicationsService.UpdateAsync(applications);
            return Success();
        }
        
         /// <summary>
        /// 新增应用程序信息
        /// </summary>
        /// <param name="applications">应用程序信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]ApplicationsDto applications)
        {
            return Success(await _applicationsService.CreateAsync(applications));
        }
        
        /// <summary>
        /// 删除应用程序信息
        /// </summary>
        /// <param name="applications">应用程序信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<ApplicationsDto> applications)
        {
            await _applicationsService.DeleteAsync(applications);
            return Success();
        }
        
        /// <summary>
        /// 停用应用程序信息
        /// </summary>
        /// <param name="applications">应用程序信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopapplications")]
        public async Task<IActionResult> Stop(List<ApplicationsDto> applications, bool isEnable=false)
        {
            await _applicationsService.StopOrEnableAsync(applications, isEnable);
            return Success();
        }
    }
}