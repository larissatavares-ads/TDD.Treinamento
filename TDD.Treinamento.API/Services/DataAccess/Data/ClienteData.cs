using TDD.Treinamento.API.Models;
using TDD.Treinamento.API.Models.Returns;
using TDD.Treinamento.API.Services.DataAccess.SqlAccess;

namespace TDD.Treinamento.API.Services.DataAccess.Data
{
    public class ClienteData : IClienteData
    {
        private readonly ISqlDataAccess _sql;

        public ClienteData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        // adaptador generico para consultar a tabela generica cliente
        public async Task<IEnumerable<ValidarPessoaFisicaReturn>> ConsultaCliente(ClienteEntradaModel cliente)
        {
            var sql = $"SELECT * FROM CLIENTE WHERE Cpf = {cliente.Cpf}";
            var request = await _sql.LoadData<ValidarPessoaFisicaReturn, dynamic>(sql, cliente);
            return request;
        }
    }
}
