
using Sand.Domain.Queries.Medicinestores;
using Sand.Service.Dtos.Medicinestores;
using Sand.Service.Contract.Medicinestores;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Medicinestores {
    /// <summary>
    /// Medicinestores-药品更新日志服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DrugupdatelogController : BaseApiController {
         /// <summary>
        /// 药品更新日志服务
        /// </summary>
        private readonly IDrugupdatelogService _drugupdatelogService;
        
        /// <summary>
        /// 初始化药品更新日志控制器
        /// </summary>
        /// <param name="service">药品更新日志服务</param>
        public DrugupdatelogController( IDrugupdatelogService service ){
            _drugupdatelogService = service;
        }
        
        /// <summary>
        /// 查询药品更新日志信息
        /// </summary>
        /// <param name="drugupdatelogQuery">药品更新日志查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DrugupdatelogQuery drugupdatelogQuery)
        {
            return Success(await  _drugupdatelogService.RetrieveAsync(drugupdatelogQuery));
        }
        
        /// <summary>
        /// 根据编号查询药品更新日志信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _drugupdatelogService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求药品更新日志分页信息
        /// </summary>
        /// <param name="drugupdatelogQuery">药品更新日志查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedrugupdatelog")]
        public async Task<IActionResult> Page(DrugupdatelogQuery drugupdatelogQuery)
        {
            return Success(await _drugupdatelogService.PageAsync(drugupdatelogQuery));
        }
        
        /// <summary>
        /// 更新药品更新日志信息
        /// </summary>
        /// <param name="drugupdatelog">药品更新日志更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DrugupdatelogDto drugupdatelog)
        {
           await _drugupdatelogService.UpdateAsync(drugupdatelog);
            return Success();
        }
        
         /// <summary>
        /// 新增药品更新日志信息
        /// </summary>
        /// <param name="drugupdatelog">药品更新日志信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DrugupdatelogDto drugupdatelog)
        {
            return Success(await _drugupdatelogService.CreateAsync(drugupdatelog));
        }
        
        /// <summary>
        /// 删除药品更新日志信息
        /// </summary>
        /// <param name="drugupdatelog">药品更新日志信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DrugupdatelogDto> drugupdatelog)
        {
            await _drugupdatelogService.DeleteAsync(drugupdatelog);
            return Success();
        }
        
        /// <summary>
        /// 停用药品更新日志信息
        /// </summary>
        /// <param name="drugupdatelog">药品更新日志信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdrugupdatelog")]
        public async Task<IActionResult> Stop(List<DrugupdatelogDto> drugupdatelog, bool isEnable=false)
        {
            await _drugupdatelogService.StopOrEnableAsync(drugupdatelog, isEnable);
            return Success();
        }
    }
}