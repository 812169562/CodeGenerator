
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
    /// Materials-物资库存服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class MaterialinventoryController : BaseApiController {
         /// <summary>
        /// 物资库存服务
        /// </summary>
        private readonly IMaterialinventoryService _materialinventoryService;
        
        /// <summary>
        /// 初始化物资库存控制器
        /// </summary>
        /// <param name="service">物资库存服务</param>
        public MaterialinventoryController( IMaterialinventoryService service ){
            _materialinventoryService = service;
        }
        
        /// <summary>
        /// 查询物资库存信息
        /// </summary>
        /// <param name="materialinventoryQuery">物资库存查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(MaterialinventoryQuery materialinventoryQuery)
        {
            return Success(await  _materialinventoryService.RetrieveAsync(materialinventoryQuery));
        }
        
        /// <summary>
        /// 根据编号查询物资库存信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _materialinventoryService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求物资库存分页信息
        /// </summary>
        /// <param name="materialinventoryQuery">物资库存查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagematerialinventory")]
        public async Task<IActionResult> Page(MaterialinventoryQuery materialinventoryQuery)
        {
            return Success(await _materialinventoryService.PageAsync(materialinventoryQuery));
        }
        
        /// <summary>
        /// 更新物资库存信息
        /// </summary>
        /// <param name="materialinventory">物资库存更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]MaterialinventoryDto materialinventory)
        {
           await _materialinventoryService.UpdateAsync(materialinventory);
            return Success();
        }
        
         /// <summary>
        /// 新增物资库存信息
        /// </summary>
        /// <param name="materialinventory">物资库存信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]MaterialinventoryDto materialinventory)
        {
            return Success(await _materialinventoryService.CreateAsync(materialinventory));
        }
        
        /// <summary>
        /// 删除物资库存信息
        /// </summary>
        /// <param name="materialinventory">物资库存信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<MaterialinventoryDto> materialinventory)
        {
            await _materialinventoryService.DeleteAsync(materialinventory);
            return Success();
        }
        
        /// <summary>
        /// 停用物资库存信息
        /// </summary>
        /// <param name="materialinventory">物资库存信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopmaterialinventory")]
        public async Task<IActionResult> Stop(List<MaterialinventoryDto> materialinventory, bool isEnable=false)
        {
            await _materialinventoryService.StopOrEnableAsync(materialinventory, isEnable);
            return Success();
        }
    }
}