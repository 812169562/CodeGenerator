﻿using System;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;

namespace Sand.Service.Contract.Essentialinformations {
    /// <summary>
    /// 医馆服务
    /// </summary>
    public interface ITenantService : IService<TenantDto, TenantQuery,Tenant,int> {
    }
}