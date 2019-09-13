using InOne.Task.FootBallAndADO.Const;
using InOne.Task.FootBallAndADO.Models;
using System;
using System.Data;

namespace InOne.Task.FootBallAndADO.ModelRepositories
{
    class ShoesRepository : BaseFunctionality<Shoes>
    {
        public ShoesRepository(DbContext dbContext) : base(dbContext) { }

        public override string TableName => DBName.Table_Shoes;

        protected override Shoes CreateEntity(IDataReader reader)
        {
            return new Shoes
            {
                Id = (int)reader[nameof(Shoes.Id)],
                Size = (int)reader[nameof(Shoes.Size)],
                Price = Convert.ToDouble(reader[nameof(Shoes.Price)]),
                DateOfCreation = (DateTime)reader[nameof(Shoes.DateOfCreation)],
                BrandName_Id = (int)reader[nameof(Shoes.BrandName_Id)],
                Player_Id = (int)reader[nameof(Shoes.Player_Id)]
            };
        }
    }
}
