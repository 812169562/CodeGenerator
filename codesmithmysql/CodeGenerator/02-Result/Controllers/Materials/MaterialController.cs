
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
    /// Materials-物资服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class MaterialController : BaseApiController {
         /// <summary>
        /// 物资服务
        /// </summary>
        private readonly IMaterialService _materialService;
        
        /// <summary>
        /// 初始化物资控制器
        /// </summary>
        /// <param name="service">物资服务</param>
        public MaterialController( IMaterialService service ){
            _materialService = service;
        }
        
        /// <summary>
        /// 查询物资信息
        /// </summary>
        /// <param name="materialQuery">物资查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(MaterialQuery materialQuery)
        {
            return Success(await  _materialService.RetrieveAsync(materialQuery));
        }
        
        /// <summary>
        /// 根据编号查询物资信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _materialService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求物资分页信息
        /// </summary>
        /// <param name="materialQuery">物资查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagematerial")]
        public async Task<IActionResult> Page(MaterialQuery materialQuery)
        {
            return Success(await _materialService.PageAsync(materialQuery));
        }
        
        /// <summary>
        /// 更新物资信息
        /// </summary>
        /// <param name="material">物资更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]MaterialDto material)
        {
           await _materialService.UpdateAsync(material);
            return Success();
        }
        
         /// <summary>
        /// 新增物资信息
        /// </summary>
        /// <param name="material">物资信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]MaterialDto material)
        {
            return Success(await _materialService.CreateAsync(material));
        }
        
        /// <summary>
        /// 删除物资信息
        /// </summary>
        /// <param name="material">物资信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<MaterialDto> material)
        {
            await _materialService.DeleteAsync(material);
            return Success();
        }
        
        /// <summary>
        /// 停用物资信息
        /// </summary>
        /// <param name="material">物资信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopmaterial")]
        public async Task<IActionResult> Stop(List<MaterialDto> material, bool isEnable=false)
        {
            await _materialService.StopOrEnableAsync(material, isEnable);
            return Success();
        }
    }
}