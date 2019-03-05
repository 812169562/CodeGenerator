
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
    /// Activities-优惠券领用服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class CouponcollarController : BaseApiController {
         /// <summary>
        /// 优惠券领用服务
        /// </summary>
        private readonly ICouponcollarService _couponcollarService;
        
        /// <summary>
        /// 初始化优惠券领用控制器
        /// </summary>
        /// <param name="service">优惠券领用服务</param>
        public CouponcollarController( ICouponcollarService service ){
            _couponcollarService = service;
        }
        
        /// <summary>
        /// 查询优惠券领用信息
        /// </summary>
        /// <param name="couponcollarQuery">优惠券领用查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(CouponcollarQuery couponcollarQuery)
        {
            return Success(await  _couponcollarService.RetrieveAsync(couponcollarQuery));
        }
        
        /// <summary>
        /// 根据编号查询优惠券领用信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _couponcollarService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求优惠券领用分页信息
        /// </summary>
        /// <param name="couponcollarQuery">优惠券领用查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagecouponcollar")]
        public async Task<IActionResult> Page(CouponcollarQuery couponcollarQuery)
        {
            return Success(await _couponcollarService.PageAsync(couponcollarQuery));
        }
        
        /// <summary>
        /// 更新优惠券领用信息
        /// </summary>
        /// <param name="couponcollar">优惠券领用更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]CouponcollarDto couponcollar)
        {
           await _couponcollarService.UpdateAsync(couponcollar);
            return Success();
        }
        
         /// <summary>
        /// 新增优惠券领用信息
        /// </summary>
        /// <param name="couponcollar">优惠券领用信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]CouponcollarDto couponcollar)
        {
            return Success(await _couponcollarService.CreateAsync(couponcollar));
        }
        
        /// <summary>
        /// 删除优惠券领用信息
        /// </summary>
        /// <param name="couponcollar">优惠券领用信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<CouponcollarDto> couponcollar)
        {
            await _couponcollarService.DeleteAsync(couponcollar);
            return Success();
        }
        
        /// <summary>
        /// 停用优惠券领用信息
        /// </summary>
        /// <param name="couponcollar">优惠券领用信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopcouponcollar")]
        public async Task<IActionResult> Stop(List<CouponcollarDto> couponcollar, bool isEnable=false)
        {
            await _couponcollarService.StopOrEnableAsync(couponcollar, isEnable);
            return Success();
        }
    }
}