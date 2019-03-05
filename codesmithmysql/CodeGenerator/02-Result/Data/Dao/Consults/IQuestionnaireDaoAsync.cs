using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Consults;

namespace Sand.Data.Dao.Consults {
    /// <summary>
    /// 问卷表Dao
    /// </summary>
    [SqlMap(Scope = "questionnaire")]
    public interface IQuestionnaireDaoAsync : IRepositoryAsync<Questionnaire,string> {
    }
}
