
using Sand.Domain.Queries.Storages;
using Sand.Service.Dtos.Storages;
using Sand.Service.Contract.Storages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Storages {
    /// <summary>
    /// Storages-存储服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class StoragesController : BaseApiController {
         /// <summary>
        /// 存储服务
        /// </summary>
        private readonly IStoragesService _storagesService;
        
        /// <summary>
        /// 初始化存储控制器
        /// </summary>
        /// <param name="service">存储服务</param>
        public StoragesController( IStoragesService service ){
            _storagesService = service;
        }
        
        /// <summary>
        /// 查询存储信息
        /// </summary>
        /// <param name="storagesQuery">存储查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(StoragesQuery storagesQuery)
        {
            return Success(await  _storagesService.RetrieveAsync(storagesQuery));
        }
        
        /// <summary>
        /// 根据编号查询存储信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _storagesService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求存储分页信息
        /// </summary>
        /// <param name="storagesQuery">存储查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagestorages")]
        public async Task<IActionResult> Page(StoragesQuery storagesQuery)
        {
            return Success(await _storagesService.PageAsync(storagesQuery));
        }
        
        /// <summary>
        /// 更新存储信息
        /// </summary>
        /// <param name="storages">存储更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]StoragesDto storages)
        {
           await _storagesService.UpdateAsync(storages);
            return Success();
        }
        
         /// <summary>
        /// 新增存储信息
        /// </summary>
        /// <param name="storages">存储信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]StoragesDto storages)
        {
            return Success(await _storagesService.CreateAsync(storages));
        }
        
        /// <summary>
        /// 删除存储信息
        /// </summary>
        /// <param name="storages">存储信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<StoragesDto> storages)
        {
            await _storagesService.DeleteAsync(storages);
            return Success();
        }
        
        /// <summary>
        /// 停用存储信息
        /// </summary>
        /// <param name="storages">存储信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopstorages")]
        public async Task<IActionResult> Stop(List<StoragesDto> storages, bool isEnable=false)
        {
            await _storagesService.StopOrEnableAsync(storages, isEnable);
            return Success();
        }
    }
}