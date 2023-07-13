using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.DataAccess.Repositories
{
    public  class BaseRepository
    {
        protected readonly NpgsqlConnection _connection;
        public BaseRepository()
        {
            this._connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=AgileShop;User Id=postgres;Password=1234;");
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }
    }
}
