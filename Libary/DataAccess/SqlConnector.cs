using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Libary.DataAccess
{
    //private const string db = "aeroporto";
    public class SqlConnector : IDataConnection
    {
        public void CreateClient(ClientModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("aeroporto")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Nome", model.FirstName);
                p.Add("@Sobrenome", model.LastName);
                p.Add("@Endereco", model.Address);
                p.Add("@Email", model.Email);
                p.Add("@Telefone", model.Phone);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPassageiro_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }
    }
}
