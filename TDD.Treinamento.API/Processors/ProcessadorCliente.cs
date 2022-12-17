using TDD.Treinamento.API.Models;
using TDD.Treinamento.API.Models.Returns;
using TDD.Treinamento.API.Services.DataAccess.Data;

namespace TDD.Treinamento.API.Processors
{
    public class ProcessadorCliente
    {
        private IClienteData _clienteData;

        public ProcessadorCliente(IClienteData clienteData)
        {
            _clienteData = clienteData;
        }

        public async Task<ValidarPessoaFisicaReturn> ValidarPessoaFisica(ClienteEntradaModel clienteEntradaModel)
        {
            var request = await _clienteData.ConsultaCliente(clienteEntradaModel);

            //return request.FirstOrDefault();

            return new ValidarPessoaFisicaReturn
            {
                Cpf = clienteEntradaModel.Cpf
            };
        }
    }
}
