
using Sand.Domain.Queries.Activities;
using Sand.Service.Dtos.Activities;
using Sand.Service.Contract.Activities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Activities {
    /// <summary>
    /// Activities-优惠卷库存新增记录服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class CouponaddlogController : BaseApiController {
         /// <summary>
        /// 优惠卷库存新增记录服务
        /// </summary>
        private readonly ICouponaddlogService _couponaddlogService;
        
        /// <summary>
        /// 初始化优惠卷库存新增记录控制器
        /// </summary>
        /// <param name="service">优惠卷库存新增记录服务</param>
        public CouponaddlogController( ICouponaddlogService service ){
            _couponaddlogService = service;
        }
        
        /// <summary>
        /// 查询优惠卷库存新增记录信息
        /// </summary>
        /// <param name="couponaddlogQuery">优惠卷库存新增记录查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(CouponaddlogQuery couponaddlogQuery)
        {
            return Success(await  _couponaddlogService.RetrieveAsync(couponaddlogQuery));
        }
        
        /// <summary>
        /// 根据编号查询优惠卷库存新增记录信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _couponaddlogService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求优惠卷库存新增记录分页信息
        /// </summary>
        /// <param name="couponaddlogQuery">优惠卷库存新增记录查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagecouponaddlog")]
        public async Task<IActionResult> Page(CouponaddlogQuery couponaddlogQuery)
        {
            return Success(await _couponaddlogService.PageAsync(couponaddlogQuery));
        }
        
        /// <summary>
        /// 更新优惠卷库存新增记录信息
        /// </summary>
        /// <param name="couponaddlog">优惠卷库存新增记录更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]CouponaddlogDto couponaddlog)
        {
           await _couponaddlogService.UpdateAsync(couponaddlog);
            return Success();
        }
        
         /// <summary>
        /// 新增优惠卷库存新增记录信息
        /// </summary>
        /// <param name="couponaddlog">优惠卷库存新增记录信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]CouponaddlogDto couponaddlog)
        {
            return Success(await _couponaddlogService.CreateAsync(couponaddlog));
        }
        
        /// <summary>
        /// 删除优惠卷库存新增记录信息
        /// </summary>
        /// <param name="couponaddlog">优惠卷库存新增记录信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<CouponaddlogDto> couponaddlog)
        {
            await _couponaddlogService.DeleteAsync(couponaddlog);
            return Success();
        }
        
        /// <summary>
        /// 停用优惠卷库存新增记录信息
        /// </summary>
        /// <param name="couponaddlog">优惠卷库存新增记录信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopcouponaddlog")]
        public async Task<IActionResult> Stop(List<CouponaddlogDto> couponaddlog, bool isEnable=false)
        {
            await _couponaddlogService.StopOrEnableAsync(couponaddlog, isEnable);
            return Success();
        }
    }
}