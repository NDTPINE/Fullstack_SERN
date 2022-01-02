using CoreBusiness;

namespace UseCases
{
    public interface IGetCategoryByIdUseCase
    {
        Category Excute(int categoryId);
    }
}