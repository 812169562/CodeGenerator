
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
    /// Activities-优惠券服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class CouponController : BaseApiController {
         /// <summary>
        /// 优惠券服务
        /// </summary>
        private readonly ICouponService _couponService;
        
        /// <summary>
        /// 初始化优惠券控制器
        /// </summary>
        /// <param name="service">优惠券服务</param>
        public CouponController( ICouponService service ){
            _couponService = service;
        }
        
        /// <summary>
        /// 查询优惠券信息
        /// </summary>
        /// <param name="couponQuery">优惠券查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(CouponQuery couponQuery)
        {
            return Success(await  _couponService.RetrieveAsync(couponQuery));
        }
        
        /// <summary>
        /// 根据编号查询优惠券信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _couponService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求优惠券分页信息
        /// </summary>
        /// <param name="couponQuery">优惠券查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagecoupon")]
        public async Task<IActionResult> Page(CouponQuery couponQuery)
        {
            return Success(await _couponService.PageAsync(couponQuery));
        }
        
        /// <summary>
        /// 更新优惠券信息
        /// </summary>
        /// <param name="coupon">优惠券更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]CouponDto coupon)
        {
           await _couponService.UpdateAsync(coupon);
            return Success();
        }
        
         /// <summary>
        /// 新增优惠券信息
        /// </summary>
        /// <param name="coupon">优惠券信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]CouponDto coupon)
        {
            return Success(await _couponService.CreateAsync(coupon));
        }
        
        /// <summary>
        /// 删除优惠券信息
        /// </summary>
        /// <param name="coupon">优惠券信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<CouponDto> coupon)
        {
            await _couponService.DeleteAsync(coupon);
            return Success();
        }
        
        /// <summary>
        /// 停用优惠券信息
        /// </summary>
        /// <param name="coupon">优惠券信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopcoupon")]
        public async Task<IActionResult> Stop(List<CouponDto> coupon, bool isEnable=false)
        {
            await _couponService.StopOrEnableAsync(coupon, isEnable);
            return Success();
        }
    }
}