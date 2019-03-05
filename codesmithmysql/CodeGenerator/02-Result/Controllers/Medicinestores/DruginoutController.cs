
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
    /// Medicinestores-药品出入库服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DruginoutController : BaseApiController {
         /// <summary>
        /// 药品出入库服务
        /// </summary>
        private readonly IDruginoutService _druginoutService;
        
        /// <summary>
        /// 初始化药品出入库控制器
        /// </summary>
        /// <param name="service">药品出入库服务</param>
        public DruginoutController( IDruginoutService service ){
            _druginoutService = service;
        }
        
        /// <summary>
        /// 查询药品出入库信息
        /// </summary>
        /// <param name="druginoutQuery">药品出入库查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DruginoutQuery druginoutQuery)
        {
            return Success(await  _druginoutService.RetrieveAsync(druginoutQuery));
        }
        
        /// <summary>
        /// 根据编号查询药品出入库信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _druginoutService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求药品出入库分页信息
        /// </summary>
        /// <param name="druginoutQuery">药品出入库查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedruginout")]
        public async Task<IActionResult> Page(DruginoutQuery druginoutQuery)
        {
            return Success(await _druginoutService.PageAsync(druginoutQuery));
        }
        
        /// <summary>
        /// 更新药品出入库信息
        /// </summary>
        /// <param name="druginout">药品出入库更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DruginoutDto druginout)
        {
           await _druginoutService.UpdateAsync(druginout);
            return Success();
        }
        
         /// <summary>
        /// 新增药品出入库信息
        /// </summary>
        /// <param name="druginout">药品出入库信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DruginoutDto druginout)
        {
            return Success(await _druginoutService.CreateAsync(druginout));
        }
        
        /// <summary>
        /// 删除药品出入库信息
        /// </summary>
        /// <param name="druginout">药品出入库信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DruginoutDto> druginout)
        {
            await _druginoutService.DeleteAsync(druginout);
            return Success();
        }
        
        /// <summary>
        /// 停用药品出入库信息
        /// </summary>
        /// <param name="druginout">药品出入库信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdruginout")]
        public async Task<IActionResult> Stop(List<DruginoutDto> druginout, bool isEnable=false)
        {
            await _druginoutService.StopOrEnableAsync(druginout, isEnable);
            return Success();
        }
    }
}