
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
    /// Essentialinformations-资源服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class ResourceController : BaseApiController {
         /// <summary>
        /// 资源服务
        /// </summary>
        private readonly IResourceService _resourceService;
        
        /// <summary>
        /// 初始化资源控制器
        /// </summary>
        /// <param name="service">资源服务</param>
        public ResourceController( IResourceService service ){
            _resourceService = service;
        }
        
        /// <summary>
        /// 查询资源信息
        /// </summary>
        /// <param name="resourceQuery">资源查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(ResourceQuery resourceQuery)
        {
            return Success(await  _resourceService.RetrieveAsync(resourceQuery));
        }
        
        /// <summary>
        /// 根据编号查询资源信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _resourceService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求资源分页信息
        /// </summary>
        /// <param name="resourceQuery">资源查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageresource")]
        public async Task<IActionResult> Page(ResourceQuery resourceQuery)
        {
            return Success(await _resourceService.PageAsync(resourceQuery));
        }
        
        /// <summary>
        /// 更新资源信息
        /// </summary>
        /// <param name="resource">资源更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]ResourceDto resource)
        {
           await _resourceService.UpdateAsync(resource);
            return Success();
        }
        
         /// <summary>
        /// 新增资源信息
        /// </summary>
        /// <param name="resource">资源信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]ResourceDto resource)
        {
            return Success(await _resourceService.CreateAsync(resource));
        }
        
        /// <summary>
        /// 删除资源信息
        /// </summary>
        /// <param name="resource">资源信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<ResourceDto> resource)
        {
            await _resourceService.DeleteAsync(resource);
            return Success();
        }
        
        /// <summary>
        /// 停用资源信息
        /// </summary>
        /// <param name="resource">资源信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopresource")]
        public async Task<IActionResult> Stop(List<ResourceDto> resource, bool isEnable=false)
        {
            await _resourceService.StopOrEnableAsync(resource, isEnable);
            return Success();
        }
    }
}