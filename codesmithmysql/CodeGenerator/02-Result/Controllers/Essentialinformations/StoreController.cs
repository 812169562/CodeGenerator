
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
    /// Essentialinformations-门店服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class StoreController : BaseApiController {
         /// <summary>
        /// 门店服务
        /// </summary>
        private readonly IStoreService _storeService;
        
        /// <summary>
        /// 初始化门店控制器
        /// </summary>
        /// <param name="service">门店服务</param>
        public StoreController( IStoreService service ){
            _storeService = service;
        }
        
        /// <summary>
        /// 查询门店信息
        /// </summary>
        /// <param name="storeQuery">门店查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(StoreQuery storeQuery)
        {
            return Success(await  _storeService.RetrieveAsync(storeQuery));
        }
        
        /// <summary>
        /// 根据编号查询门店信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _storeService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求门店分页信息
        /// </summary>
        /// <param name="storeQuery">门店查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagestore")]
        public async Task<IActionResult> Page(StoreQuery storeQuery)
        {
            return Success(await _storeService.PageAsync(storeQuery));
        }
        
        /// <summary>
        /// 更新门店信息
        /// </summary>
        /// <param name="store">门店更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]StoreDto store)
        {
           await _storeService.UpdateAsync(store);
            return Success();
        }
        
         /// <summary>
        /// 新增门店信息
        /// </summary>
        /// <param name="store">门店信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]StoreDto store)
        {
            return Success(await _storeService.CreateAsync(store));
        }
        
        /// <summary>
        /// 删除门店信息
        /// </summary>
        /// <param name="store">门店信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<StoreDto> store)
        {
            await _storeService.DeleteAsync(store);
            return Success();
        }
        
        /// <summary>
        /// 停用门店信息
        /// </summary>
        /// <param name="store">门店信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopstore")]
        public async Task<IActionResult> Stop(List<StoreDto> store, bool isEnable=false)
        {
            await _storeService.StopOrEnableAsync(store, isEnable);
            return Success();
        }
    }
}