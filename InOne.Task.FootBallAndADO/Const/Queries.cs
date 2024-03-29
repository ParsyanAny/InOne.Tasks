﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOne.Task.FootBallAndADO
{
    public static class Queries
    {
        public const string SelectAll = "SELECT * FROM {0}";
        public const string SelectAllWhere = "SELECT * FROM {0} WHERE {1}";
        public const string SelectWhereId = "SELECT * FROM {0} WHERE Id = {1}";
        public const string SelectWhere = "SELECT * FROM {0} WHERE {1}";
        public const string FirstOrDefault = "SELECT * FROM {0}";
        public const string Insert = "INSERT INTO {0}({1}) VALUES({2})";
        public const string InsertScalar = "INSERT INTO {0}({1}) VALUES({2})" + "SELECT CAST(scope_identity() AS int)";
        public const string Update = "UPDATE {0} SET {1} WHERE Id = {2} " + "SELECT id FROM {3}";//"SELECT CAST(scope_identity() AS int)";
        public const string Delete = "DELETE FROM {0} WHERE Id={1}";
    }
}
