using InOne.Task.FootBallAndADO.Const;
using InOne.Task.FootBallAndADO.Models;
using System.Data;

namespace InOne.Task.FootBallAndADO.ModelRepositories
{
    class PlayerRepository : BaseFunctionality<Player>
    {
        public PlayerRepository(DbContext dbContext) : base(dbContext) { }

        public override string TableName => DBName.Table_Players;

        protected override Player CreateEntity(IDataReader reader)
        {
            return new Player
            {
                Id = (int)reader[nameof(Player.Id)],
                Name = (string)reader[nameof(Player.Name)],
                SurName = (string)reader[nameof(Player.SurName)],
                Team_Id = (int)reader[nameof(Player.Team_Id)],
                FootSize = (int)reader[nameof(Player.FootSize)],
                Number = (byte)reader[nameof(Player.Number)],
            };
        }
    }
}
