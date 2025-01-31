using RestauranteService.Dtos;
using RestauranteService.HttpClient;
using System.Text;
using System.Text.Json;

public class ItemServiceHttpClient : IItemServiceHttpClient
{
    private readonly HttpClient _client;
    private readonly IConfiguration _configuration;
    public ItemServiceHttpClient(HttpClient client, IConfiguration configuration)
    {
        _client = client;
        _configuration = configuration;
    }
    public async void EnviarRestauranteParaItemService(RestauranteReadDto readDto)
    {
        //Serealização dos dados para o enviar 
        var conteudoHttp = new StringContent(
            JsonSerializer.Serialize(readDto),
            Encoding.UTF8,
            "application/json"
        );

        //Envio do conteudo para o RestauranteControler do servico ItemService
        await _client.PostAsync(_configuration["ItemService"], conteudoHttp);
    }
}
