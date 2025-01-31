using RestauranteService.Dtos;

namespace RestauranteService.HttpClient;

public interface IItemServiceHttpClient
{
    public void EnviarRestauranteParaItemService(RestauranteReadDto readDto);
}
