using TDD.Treinamento.API.Models;
using TDD.Treinamento.API.Models.Returns;
using TDD.Treinamento.API.Processors;
using TDD.Treinamento.API.Services.DataAccess.Data;
using Moq;

namespace TDD.Treinamento.Tests
{
    public class UnitTest1
    {
        //lista de objetos para ser testado, pode ser colocado uma lista [InlineData]
        /*[InlineData("12545459856")]*/

        [Fact(DisplayName = "Realizar validacao do usuario")]
        public async Task Test1(/*string cpf*/)
        {
            //===ARRANGE===
            // criar obj de entrada
            var clienteEntrada = new ClienteEntradaModel
            {
                Cpf = "03218623299"
            };

            var mockClienteData = new Moq.Mock<IClienteData>();

            // criar os processadores
            var processadorCliente = new ProcessadorCliente(mockClienteData.Object);

            //===ACT===
            // executar o processo
            //  request == sut (system under test)
            var sut = await processadorCliente.ValidarPessoaFisica(clienteEntrada);

            // mockando a entrada para ser qualquer tipo de cliente entrada
            //var sut = await processadorCliente.ValidarPessoaFisica(It.IsAny<ClienteEntradaModel>());

            //===ASSERTS===
            // validacoes
            // nao pode retornar nulo
            //Assert.NotNull(sut);
            // validar o retorno
            Assert.IsType<ValidarPessoaFisicaReturn>(sut);
                // comparar a entrada com o retorno
            Assert.Equal(clienteEntrada.Cpf, sut.Cpf);
        }
    }
}