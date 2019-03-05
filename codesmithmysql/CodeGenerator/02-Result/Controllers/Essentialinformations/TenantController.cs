
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
    /// Essentialinformations-医馆服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class TenantController : BaseApiController {
         /// <summary>
        /// 医馆服务
        /// </summary>
        private readonly ITenantService _tenantService;
        
        /// <summary>
        /// 初始化医馆控制器
        /// </summary>
        /// <param name="service">医馆服务</param>
        public TenantController( ITenantService service ){
            _tenantService = service;
        }
        
        /// <summary>
        /// 查询医馆信息
        /// </summary>
        /// <param name="tenantQuery">医馆查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(TenantQuery tenantQuery)
        {
            return Success(await  _tenantService.RetrieveAsync(tenantQuery));
        }
        
        /// <summary>
        /// 根据编号查询医馆信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Success(await _tenantService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求医馆分页信息
        /// </summary>
        /// <param name="tenantQuery">医馆查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagetenant")]
        public async Task<IActionResult> Page(TenantQuery tenantQuery)
        {
            return Success(await _tenantService.PageAsync(tenantQuery));
        }
        
        /// <summary>
        /// 更新医馆信息
        /// </summary>
        /// <param name="tenant">医馆更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]TenantDto tenant)
        {
           await _tenantService.UpdateAsync(tenant);
            return Success();
        }
        
         /// <summary>
        /// 新增医馆信息
        /// </summary>
        /// <param name="tenant">医馆信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]TenantDto tenant)
        {
            return Success(await _tenantService.CreateAsync(tenant));
        }
        
        /// <summary>
        /// 删除医馆信息
        /// </summary>
        /// <param name="tenant">医馆信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<TenantDto> tenant)
        {
            await _tenantService.DeleteAsync(tenant);
            return Success();
        }
        
        /// <summary>
        /// 停用医馆信息
        /// </summary>
        /// <param name="tenant">医馆信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stoptenant")]
        public async Task<IActionResult> Stop(List<TenantDto> tenant, bool isEnable=false)
        {
            await _tenantService.StopOrEnableAsync(tenant, isEnable);
            return Success();
        }
    }
}