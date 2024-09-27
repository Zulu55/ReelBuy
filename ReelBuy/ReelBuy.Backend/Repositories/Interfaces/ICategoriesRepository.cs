using ReelBuy.Shared.DTOs;
using ReelBuy.Shared.Entities;
using ReelBuy.Shared.Responses;

namespace ReelBuy.Backend.Repositories.Interfaces;

public interface ICategoriesRepository
{
    Task<ActionResponse<Categories>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<Categories>>> GetAsync();

    Task<IEnumerable<Categories>> GetComboAsync();

    Task<ActionResponse<IEnumerable<Categories>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}
