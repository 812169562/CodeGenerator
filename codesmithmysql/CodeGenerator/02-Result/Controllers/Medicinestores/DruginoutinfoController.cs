
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
    /// Medicinestores-出入库明细表服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DruginoutinfoController : BaseApiController {
         /// <summary>
        /// 出入库明细表服务
        /// </summary>
        private readonly IDruginoutinfoService _druginoutinfoService;
        
        /// <summary>
        /// 初始化出入库明细表控制器
        /// </summary>
        /// <param name="service">出入库明细表服务</param>
        public DruginoutinfoController( IDruginoutinfoService service ){
            _druginoutinfoService = service;
        }
        
        /// <summary>
        /// 查询出入库明细表信息
        /// </summary>
        /// <param name="druginoutinfoQuery">出入库明细表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DruginoutinfoQuery druginoutinfoQuery)
        {
            return Success(await  _druginoutinfoService.RetrieveAsync(druginoutinfoQuery));
        }
        
        /// <summary>
        /// 根据编号查询出入库明细表信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _druginoutinfoService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求出入库明细表分页信息
        /// </summary>
        /// <param name="druginoutinfoQuery">出入库明细表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedruginoutinfo")]
        public async Task<IActionResult> Page(DruginoutinfoQuery druginoutinfoQuery)
        {
            return Success(await _druginoutinfoService.PageAsync(druginoutinfoQuery));
        }
        
        /// <summary>
        /// 更新出入库明细表信息
        /// </summary>
        /// <param name="druginoutinfo">出入库明细表更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DruginoutinfoDto druginoutinfo)
        {
           await _druginoutinfoService.UpdateAsync(druginoutinfo);
            return Success();
        }
        
         /// <summary>
        /// 新增出入库明细表信息
        /// </summary>
        /// <param name="druginoutinfo">出入库明细表信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DruginoutinfoDto druginoutinfo)
        {
            return Success(await _druginoutinfoService.CreateAsync(druginoutinfo));
        }
        
        /// <summary>
        /// 删除出入库明细表信息
        /// </summary>
        /// <param name="druginoutinfo">出入库明细表信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DruginoutinfoDto> druginoutinfo)
        {
            await _druginoutinfoService.DeleteAsync(druginoutinfo);
            return Success();
        }
        
        /// <summary>
        /// 停用出入库明细表信息
        /// </summary>
        /// <param name="druginoutinfo">出入库明细表信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdruginoutinfo")]
        public async Task<IActionResult> Stop(List<DruginoutinfoDto> druginoutinfo, bool isEnable=false)
        {
            await _druginoutinfoService.StopOrEnableAsync(druginoutinfo, isEnable);
            return Success();
        }
    }
}