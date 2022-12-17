namespace TDD.Treinamento.API.Services.DataAccess.SqlAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string data, U parameters, string connectionId = "Default");
    }
}