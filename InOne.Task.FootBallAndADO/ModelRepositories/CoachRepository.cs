﻿using InOne.Task.FootBallAndADO.Const;
using InOne.Task.FootBallAndADO.Models;
using System;
using System.Data;

namespace InOne.Task.FootBallAndADO.ModelRepositories
{
    class CoachRepository : BaseFunctionality<Coach>
    {
        public CoachRepository(DbContext dbContext) : base(dbContext) { }

        public override string TableName => DBName.Table_Coachs;

        protected override Coach CreateEntity(IDataReader reader)
        {
            return new Coach
            {
                Id = (int)reader[nameof(Coach.Id)],
                FullName = (string)reader[nameof(Coach.FullName)],
                Age = Convert.ToString(reader[nameof(Coach.Age)])
            };
        }
    }
}
