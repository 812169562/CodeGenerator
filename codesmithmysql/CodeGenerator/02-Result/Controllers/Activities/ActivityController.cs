
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
    /// Activities-优惠活动 服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class ActivityController : BaseApiController {
         /// <summary>
        /// 优惠活动 服务
        /// </summary>
        private readonly IActivityService _activityService;
        
        /// <summary>
        /// 初始化优惠活动 控制器
        /// </summary>
        /// <param name="service">优惠活动 服务</param>
        public ActivityController( IActivityService service ){
            _activityService = service;
        }
        
        /// <summary>
        /// 查询优惠活动 信息
        /// </summary>
        /// <param name="activityQuery">优惠活动 查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(ActivityQuery activityQuery)
        {
            return Success(await  _activityService.RetrieveAsync(activityQuery));
        }
        
        /// <summary>
        /// 根据编号查询优惠活动 信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _activityService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求优惠活动 分页信息
        /// </summary>
        /// <param name="activityQuery">优惠活动 查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageactivity")]
        public async Task<IActionResult> Page(ActivityQuery activityQuery)
        {
            return Success(await _activityService.PageAsync(activityQuery));
        }
        
        /// <summary>
        /// 更新优惠活动 信息
        /// </summary>
        /// <param name="activity">优惠活动 更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]ActivityDto activity)
        {
           await _activityService.UpdateAsync(activity);
            return Success();
        }
        
         /// <summary>
        /// 新增优惠活动 信息
        /// </summary>
        /// <param name="activity">优惠活动 信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]ActivityDto activity)
        {
            return Success(await _activityService.CreateAsync(activity));
        }
        
        /// <summary>
        /// 删除优惠活动 信息
        /// </summary>
        /// <param name="activity">优惠活动 信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<ActivityDto> activity)
        {
            await _activityService.DeleteAsync(activity);
            return Success();
        }
        
        /// <summary>
        /// 停用优惠活动 信息
        /// </summary>
        /// <param name="activity">优惠活动 信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopactivity")]
        public async Task<IActionResult> Stop(List<ActivityDto> activity, bool isEnable=false)
        {
            await _activityService.StopOrEnableAsync(activity, isEnable);
            return Success();
        }
    }
}