
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
    /// Essentialinformations-租户用户多对多关系表服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class TenantuserrelationController : BaseApiController {
         /// <summary>
        /// 租户用户多对多关系表服务
        /// </summary>
        private readonly ITenantuserrelationService _tenantuserrelationService;
        
        /// <summary>
        /// 初始化租户用户多对多关系表控制器
        /// </summary>
        /// <param name="service">租户用户多对多关系表服务</param>
        public TenantuserrelationController( ITenantuserrelationService service ){
            _tenantuserrelationService = service;
        }
        
        /// <summary>
        /// 查询租户用户多对多关系表信息
        /// </summary>
        /// <param name="tenantuserrelationQuery">租户用户多对多关系表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(TenantuserrelationQuery tenantuserrelationQuery)
        {
            return Success(await  _tenantuserrelationService.RetrieveAsync(tenantuserrelationQuery));
        }
        
        /// <summary>
        /// 根据编号查询租户用户多对多关系表信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Success(await _tenantuserrelationService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求租户用户多对多关系表分页信息
        /// </summary>
        /// <param name="tenantuserrelationQuery">租户用户多对多关系表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagetenantuserrelation")]
        public async Task<IActionResult> Page(TenantuserrelationQuery tenantuserrelationQuery)
        {
            return Success(await _tenantuserrelationService.PageAsync(tenantuserrelationQuery));
        }
        
        /// <summary>
        /// 更新租户用户多对多关系表信息
        /// </summary>
        /// <param name="tenantuserrelation">租户用户多对多关系表更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]TenantuserrelationDto tenantuserrelation)
        {
           await _tenantuserrelationService.UpdateAsync(tenantuserrelation);
            return Success();
        }
        
         /// <summary>
        /// 新增租户用户多对多关系表信息
        /// </summary>
        /// <param name="tenantuserrelation">租户用户多对多关系表信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]TenantuserrelationDto tenantuserrelation)
        {
            return Success(await _tenantuserrelationService.CreateAsync(tenantuserrelation));
        }
        
        /// <summary>
        /// 删除租户用户多对多关系表信息
        /// </summary>
        /// <param name="tenantuserrelation">租户用户多对多关系表信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<TenantuserrelationDto> tenantuserrelation)
        {
            await _tenantuserrelationService.DeleteAsync(tenantuserrelation);
            return Success();
        }
        
        /// <summary>
        /// 停用租户用户多对多关系表信息
        /// </summary>
        /// <param name="tenantuserrelation">租户用户多对多关系表信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stoptenantuserrelation")]
        public async Task<IActionResult> Stop(List<TenantuserrelationDto> tenantuserrelation, bool isEnable=false)
        {
            await _tenantuserrelationService.StopOrEnableAsync(tenantuserrelation, isEnable);
            return Success();
        }
    }
}