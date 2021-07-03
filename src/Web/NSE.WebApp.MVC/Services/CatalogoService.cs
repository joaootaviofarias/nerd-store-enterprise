using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using NSE.WebApp.MVC.Extensions;
using NSE.WebApp.MVC.Models;
using NSE.WebApp.MVC.Services;

public class CatalogoService : Service, ICatalogoService
{
    private readonly HttpClient _client;

    public CatalogoService(HttpClient client, IOptions<AppSettings> settings)
    {
        client.BaseAddress = new Uri(settings.Value.CatalogoUrl);
        _client = client;
    }

    public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
    {
        var response = await _client.GetAsync("/catalogo/produtos");

        TratarErroResponse(response);

        return await DeserializarObjetoResponse<IEnumerable<ProdutoViewModel>>(response);
    }

    public async Task<ProdutoViewModel> ObterPorId(Guid id)
    {
        var response = await _client.GetAsync($"/catalogo/produtos/{id}");

        TratarErroResponse(response);

        return await DeserializarObjetoResponse<ProdutoViewModel>(response);
    }
}