using CasgemMicroservice.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicrosrvice.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<Response<List<ResultCategoryDto>>> GetAllCategoryAsync();
        Task<Response<ResultCategoryDto>> GetByIdCategoryAsync(string id);
        Task<Response<NoContent>> CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task<Response<NoContent>> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task<Response<NoContent>> DeleteCategoryAsync(string id);
    }
}
