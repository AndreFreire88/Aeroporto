using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using static Dapper.SqlMapper;

namespace Libary.DataAccess
{

    public class SqlConnector : IDataConnection
    {
        private const string db = "Companhia_Aerea";

        public void BookFlight(FlightModel flightModel, ClientModel clientModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@IdVoo", flightModel.ID_Voo);
                p.Add("@IdClient", clientModel.ID_Passageiro);
                connection.Execute("spReserva_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateBag(BaggageModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@IdClient", model.ID_Passageiro);
                p.Add("@Peso", model.Peso);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spBagagem_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID_Bagagem = p.Get<int>("@id");
            }
        }

        public void CreateClient(ClientModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Nome", model.Nome);
                p.Add("@Sobrenome", model.Sobrenome);
                p.Add("@Endereco", model.Endereco);
                p.Add("@Email", model.Email);
                p.Add("@Telefone", model.Telefone);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPassageiro_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID_Passageiro = p.Get<int>("@id");
            }
        }

        public void CreateFlight(FlightModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@numero", model.NumeroVoo);
                p.Add("@Companhia", model.CompanhiaAerea);
                p.Add("@Origem", model.Origem);
                p.Add("@Destino", model.Destino);
                p.Add("@DataHoraPartida", model.DataHoraPartida);
                p.Add("@DataHoraChegada", model.DataHoraChegada);
                p.Add("@Capacidade", model.Capacidade);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("spVoo_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID_Voo = p.Get<int>("@id");

            }
        }

        public void DeleteBag(BaggageModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@BagId", model.ID_Bagagem);
                connection.Execute("spBagagem_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteReservation(FlightModel flightModel, ClientModel clientModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@ClientId", clientModel.ID_Passageiro);
                p.Add("@FlightId", flightModel.ID_Voo);
                connection.Execute("spReserva_Delete", p, commandType: CommandType.StoredProcedure);
            }

        }

        public List<ClientModel> GetClients_All()
        {
            List<ClientModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClientModel>("dbo.spPassageiros_GetAll").ToList();
                DynamicParameters p = new DynamicParameters();

                foreach (ClientModel client in output)
                {
                    p = new DynamicParameters();
                    p.Add("@ClientId", client.ID_Passageiro);

                    client.Baggages = connection.Query<BaggageModel>("dbo.spBags_GetByClient", p, commandType: CommandType.StoredProcedure).ToList();
                }

            }

            return output;
        }

        public List<FlightModel> GetFlights_All()
        {
            List<FlightModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<FlightModel>("spVoo_GetAll").ToList();
                DynamicParameters p = new DynamicParameters(); 
                foreach (FlightModel flight in output)
                {
                    p = new DynamicParameters();
                    p.Add("@VooId", flight.ID_Voo);

                    flight.Passengers = connection.Query<ClientModel>("spClient_GetByFlight", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public void UpdateClient(ClientModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Address", model.Endereco);
                p.Add("@Email", model.Email);
                p.Add("@Cellphone", model.Telefone);
                p.Add("@ID", model.ID_Passageiro);
                connection.Execute("spPassageiro_UpdateRow", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void UpdateFlights(FlightModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@DataHoraPartida", model.DataHoraPartida);
                p.Add("@DataHoraChegada", model.DataHoraChegada);
                p.Add("@id", model.ID_Voo);
                connection.Execute("spVoo_UpdateRow", p, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
