
using Sand.Domain.Queries.Materials;
using Sand.Service.Dtos.Materials;
using Sand.Service.Contract.Materials;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Materials {
    /// <summary>
    /// Materials-入库记录服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class InstockController : BaseApiController {
         /// <summary>
        /// 入库记录服务
        /// </summary>
        private readonly IInstockService _instockService;
        
        /// <summary>
        /// 初始化入库记录控制器
        /// </summary>
        /// <param name="service">入库记录服务</param>
        public InstockController( IInstockService service ){
            _instockService = service;
        }
        
        /// <summary>
        /// 查询入库记录信息
        /// </summary>
        /// <param name="instockQuery">入库记录查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(InstockQuery instockQuery)
        {
            return Success(await  _instockService.RetrieveAsync(instockQuery));
        }
        
        /// <summary>
        /// 根据编号查询入库记录信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _instockService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求入库记录分页信息
        /// </summary>
        /// <param name="instockQuery">入库记录查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageinstock")]
        public async Task<IActionResult> Page(InstockQuery instockQuery)
        {
            return Success(await _instockService.PageAsync(instockQuery));
        }
        
        /// <summary>
        /// 更新入库记录信息
        /// </summary>
        /// <param name="instock">入库记录更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]InstockDto instock)
        {
           await _instockService.UpdateAsync(instock);
            return Success();
        }
        
         /// <summary>
        /// 新增入库记录信息
        /// </summary>
        /// <param name="instock">入库记录信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]InstockDto instock)
        {
            return Success(await _instockService.CreateAsync(instock));
        }
        
        /// <summary>
        /// 删除入库记录信息
        /// </summary>
        /// <param name="instock">入库记录信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<InstockDto> instock)
        {
            await _instockService.DeleteAsync(instock);
            return Success();
        }
        
        /// <summary>
        /// 停用入库记录信息
        /// </summary>
        /// <param name="instock">入库记录信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopinstock")]
        public async Task<IActionResult> Stop(List<InstockDto> instock, bool isEnable=false)
        {
            await _instockService.StopOrEnableAsync(instock, isEnable);
            return Success();
        }
    }
}