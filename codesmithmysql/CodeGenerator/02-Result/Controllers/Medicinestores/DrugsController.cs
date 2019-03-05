
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
    /// Medicinestores-药品基本信息服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DrugsController : BaseApiController {
         /// <summary>
        /// 药品基本信息服务
        /// </summary>
        private readonly IDrugsService _drugsService;
        
        /// <summary>
        /// 初始化药品基本信息控制器
        /// </summary>
        /// <param name="service">药品基本信息服务</param>
        public DrugsController( IDrugsService service ){
            _drugsService = service;
        }
        
        /// <summary>
        /// 查询药品基本信息信息
        /// </summary>
        /// <param name="drugsQuery">药品基本信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DrugsQuery drugsQuery)
        {
            return Success(await  _drugsService.RetrieveAsync(drugsQuery));
        }
        
        /// <summary>
        /// 根据编号查询药品基本信息信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _drugsService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求药品基本信息分页信息
        /// </summary>
        /// <param name="drugsQuery">药品基本信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedrugs")]
        public async Task<IActionResult> Page(DrugsQuery drugsQuery)
        {
            return Success(await _drugsService.PageAsync(drugsQuery));
        }
        
        /// <summary>
        /// 更新药品基本信息信息
        /// </summary>
        /// <param name="drugs">药品基本信息更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DrugsDto drugs)
        {
           await _drugsService.UpdateAsync(drugs);
            return Success();
        }
        
         /// <summary>
        /// 新增药品基本信息信息
        /// </summary>
        /// <param name="drugs">药品基本信息信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DrugsDto drugs)
        {
            return Success(await _drugsService.CreateAsync(drugs));
        }
        
        /// <summary>
        /// 删除药品基本信息信息
        /// </summary>
        /// <param name="drugs">药品基本信息信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DrugsDto> drugs)
        {
            await _drugsService.DeleteAsync(drugs);
            return Success();
        }
        
        /// <summary>
        /// 停用药品基本信息信息
        /// </summary>
        /// <param name="drugs">药品基本信息信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdrugs")]
        public async Task<IActionResult> Stop(List<DrugsDto> drugs, bool isEnable=false)
        {
            await _drugsService.StopOrEnableAsync(drugs, isEnable);
            return Success();
        }
    }
}