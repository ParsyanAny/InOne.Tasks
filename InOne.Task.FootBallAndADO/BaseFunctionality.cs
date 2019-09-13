using InOne.Task.FootBallAndADO.Const;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOne.Task.FootBallAndADO
{
    public  abstract class BaseFunctionality
    {
        private readonly DbContext _dbContext;

        protected BaseFunctionality(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public abstract string TableName { get; }
        protected virtual string PrimaryKey => DBName.Col_Id;
        protected int OnExecuteScalar(string query, IEnumerable<SqlParameter> pars)
        {
            using (var cmd = _dbContext.CreateCommand())
            {
                cmd.CommandText = query;
                foreach (var item in pars)
                {
                    cmd.Parameters.Add(item);
                }
                return (int)cmd.ExecuteScalar();
            }
        }
        protected IEnumerable<IDataReader> OnExecute(string query)
        {
            using (var cmd = _dbContext.CreateCommand())
            {
                cmd.CommandText = query;
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.FieldCount > 0)
                    {
                        while (reader.Read())
                        {
                            yield return reader;
                        }
                    }
                }
            }
        }
        protected void OnExecuteNonQuery(string query)
        {
            using (var cmd = _dbContext.CreateCommand())
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
