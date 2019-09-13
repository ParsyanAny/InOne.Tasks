using InOne.Task.FootBallAndADO.Const;
using InOne.Task.FootBallAndADO.Models;
using System;
using System.Data;

namespace InOne.Task.FootBallAndADO.ModelRepositories
{
    class BrandNamesRepository : BaseFunctionality<BrandName>
    {
        public BrandNamesRepository(DbContext dbContext) : base(dbContext) { }

        public override string TableName => DBName.Table_BrandNames;

        protected override BrandName CreateEntity(IDataReader reader)
        {
            return new BrandName
            {
                Id = (int)reader[nameof(BrandName.Id)],
                Name = Convert.ToString(reader[nameof(BrandName.Name)])
            };
        }
    }
}
