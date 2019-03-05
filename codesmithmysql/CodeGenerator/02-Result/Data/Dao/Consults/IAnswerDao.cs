using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Consults;

namespace Sand.Data.Dao.Consults {
    /// <summary>
    /// 答案表Dao
    /// </summary>
    [SqlMap(Scope = "answer")]
    public interface IAnswerDao :IRepository<Answer,string> {
    }
}
