using InOne.Task.FootBallAndADO.Const;
using InOne.Task.FootBallAndADO.Models;
using System.Data;

namespace InOne.Task.FootBallAndADO.ModelRepositories
{
    class TeamRepository : BaseFunctionality<Team>
    {
        public TeamRepository(DbContext dbContext) : base(dbContext) { }

        public override string TableName => DBName.Table_Teams;

        protected override Team CreateEntity(IDataReader reader)
        {
            return new Team
            {
                Id = (int)reader[nameof(Team.Id)],
                Name = (string)reader[nameof(Team.Name)],
                Coach_Id = (int)reader[nameof(Team.Coach_Id)]
            };
        }
    }
}
