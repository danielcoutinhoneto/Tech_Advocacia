using TechAdv.Application.InputModel;
using TechAdv.Application.Services.Interfaces;
using TechAdv.Application.ViewModels;
using TechAdv.Core.Entities;
using TechAdv.Core.Exceptions;
using TechAdv.Infrastructure.Persistence;

namespace TechAdv.Application.Services;

public class ClienteService : IClienteService
{
    private readonly TechAdvDbContext _context;
    public ClienteService(TechAdvDbContext context)
    {
        _context = context;
    }

    public int Create(NewClienteInputModel advogado)
    {
        var _cliente = new Cliente{
            Nome = advogado.Nome
        };
        _context.Clientes.Add(_cliente);
        return _cliente.ClienteId;
    }

    private Cliente GetByDbId(int id)
    {
        var cliente = _context.Clientes.Find(id);
        if (cliente is null)
            throw new AdvogadoNotFoundException();

        return cliente;
    }

    public void Delete(int id)
    {
       _context.Clientes.Remove(GetByDbId(id));
    }

    public List<ClienteViewModel> GetAll()
    {
       var _clientes = _context.Clientes.Select(m => new ClienteViewModel
       {
            ClienteId = m.ClienteId,
            Nome = m.Nome
       }).ToList();

       return _clientes;
    }

    public ClienteViewModel? GetById(int id)
    {
        var _cliente = GetById(id);

        var ClienteViewModel = new ClienteViewModel
        {
        ClienteId = _cliente.ClienteId,
        Nome = _cliente.Nome
        };
        return ClienteViewModel;
        }

    public void Update(int id, NewClienteInputModel advogado)
    {
        var cliente = GetByDbId(id);
    }
}
