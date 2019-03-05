
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
    /// Activities-优惠卷消费记录服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class CouponlogController : BaseApiController {
         /// <summary>
        /// 优惠卷消费记录服务
        /// </summary>
        private readonly ICouponlogService _couponlogService;
        
        /// <summary>
        /// 初始化优惠卷消费记录控制器
        /// </summary>
        /// <param name="service">优惠卷消费记录服务</param>
        public CouponlogController( ICouponlogService service ){
            _couponlogService = service;
        }
        
        /// <summary>
        /// 查询优惠卷消费记录信息
        /// </summary>
        /// <param name="couponlogQuery">优惠卷消费记录查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(CouponlogQuery couponlogQuery)
        {
            return Success(await  _couponlogService.RetrieveAsync(couponlogQuery));
        }
        
        /// <summary>
        /// 根据编号查询优惠卷消费记录信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _couponlogService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求优惠卷消费记录分页信息
        /// </summary>
        /// <param name="couponlogQuery">优惠卷消费记录查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagecouponlog")]
        public async Task<IActionResult> Page(CouponlogQuery couponlogQuery)
        {
            return Success(await _couponlogService.PageAsync(couponlogQuery));
        }
        
        /// <summary>
        /// 更新优惠卷消费记录信息
        /// </summary>
        /// <param name="couponlog">优惠卷消费记录更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]CouponlogDto couponlog)
        {
           await _couponlogService.UpdateAsync(couponlog);
            return Success();
        }
        
         /// <summary>
        /// 新增优惠卷消费记录信息
        /// </summary>
        /// <param name="couponlog">优惠卷消费记录信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]CouponlogDto couponlog)
        {
            return Success(await _couponlogService.CreateAsync(couponlog));
        }
        
        /// <summary>
        /// 删除优惠卷消费记录信息
        /// </summary>
        /// <param name="couponlog">优惠卷消费记录信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<CouponlogDto> couponlog)
        {
            await _couponlogService.DeleteAsync(couponlog);
            return Success();
        }
        
        /// <summary>
        /// 停用优惠卷消费记录信息
        /// </summary>
        /// <param name="couponlog">优惠卷消费记录信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopcouponlog")]
        public async Task<IActionResult> Stop(List<CouponlogDto> couponlog, bool isEnable=false)
        {
            await _couponlogService.StopOrEnableAsync(couponlog, isEnable);
            return Success();
        }
    }
}