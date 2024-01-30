using TechAdv.Application.InputModel;
using TechAdv.Application.ViewModels;

namespace TechAdv.Application.Services.Interfaces;

public interface ICliente
{
      public List<ClienteViewModel> GetAll();
      public ClienteViewModel? GetById(int id);
      public int Create(NewClienteInputModel medico);
      public void Update(int id, NewClienteInputModel medico);
      public void Delete(int id);
}
