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
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                SurName = (string)reader["SurName"],
                Team_Id = (int)reader["Team_Id"],
                Number = (byte)reader["Number"],
            };
        }
    }
}
