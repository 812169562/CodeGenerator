﻿using System;
using Sand.Domain.Queries.Patientvisits;
using Sand.Domain.Entities.Patientvisits;
using Sand.Service.Dtos.Patientvisits;

namespace Sand.Service.Contract.Patientvisits {
    /// <summary>
    /// 挂号信息服务
    /// </summary>
    public interface IRegistersService : IService<RegistersDto, RegistersQuery,Registers> {
    }
}