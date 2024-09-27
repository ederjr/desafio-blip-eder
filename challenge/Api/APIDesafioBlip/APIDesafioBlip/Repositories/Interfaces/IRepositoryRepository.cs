using APIDesafioBlip.Models;

namespace APIDesafioBlip.Repositories.Interfaces

{
    public interface IRepositoryRepository
    {
        Task<List<Repository>> FindRepository();
    }
}
