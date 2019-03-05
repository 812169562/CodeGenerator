
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
    /// Materials- 领用记录服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class AccessrecordController : BaseApiController {
         /// <summary>
        ///  领用记录服务
        /// </summary>
        private readonly IAccessrecordService _accessrecordService;
        
        /// <summary>
        /// 初始化 领用记录控制器
        /// </summary>
        /// <param name="service"> 领用记录服务</param>
        public AccessrecordController( IAccessrecordService service ){
            _accessrecordService = service;
        }
        
        /// <summary>
        /// 查询 领用记录信息
        /// </summary>
        /// <param name="accessrecordQuery"> 领用记录查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(AccessrecordQuery accessrecordQuery)
        {
            return Success(await  _accessrecordService.RetrieveAsync(accessrecordQuery));
        }
        
        /// <summary>
        /// 根据编号查询 领用记录信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _accessrecordService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求 领用记录分页信息
        /// </summary>
        /// <param name="accessrecordQuery"> 领用记录查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageaccessrecord")]
        public async Task<IActionResult> Page(AccessrecordQuery accessrecordQuery)
        {
            return Success(await _accessrecordService.PageAsync(accessrecordQuery));
        }
        
        /// <summary>
        /// 更新 领用记录信息
        /// </summary>
        /// <param name="accessrecord"> 领用记录更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]AccessrecordDto accessrecord)
        {
           await _accessrecordService.UpdateAsync(accessrecord);
            return Success();
        }
        
         /// <summary>
        /// 新增 领用记录信息
        /// </summary>
        /// <param name="accessrecord"> 领用记录信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]AccessrecordDto accessrecord)
        {
            return Success(await _accessrecordService.CreateAsync(accessrecord));
        }
        
        /// <summary>
        /// 删除 领用记录信息
        /// </summary>
        /// <param name="accessrecord"> 领用记录信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<AccessrecordDto> accessrecord)
        {
            await _accessrecordService.DeleteAsync(accessrecord);
            return Success();
        }
        
        /// <summary>
        /// 停用 领用记录信息
        /// </summary>
        /// <param name="accessrecord"> 领用记录信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopaccessrecord")]
        public async Task<IActionResult> Stop(List<AccessrecordDto> accessrecord, bool isEnable=false)
        {
            await _accessrecordService.StopOrEnableAsync(accessrecord, isEnable);
            return Success();
        }
    }
}