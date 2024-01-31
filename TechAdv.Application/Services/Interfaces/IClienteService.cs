using TechAdv.Application.InputModel;
using TechAdv.Application.ViewModels;

namespace TechAdv.Application.Services.Interfaces;

public interface IClienteService
{
      public List<ClienteViewModel> GetAll();
      public ClienteViewModel? GetById(int id);
      public int Create(NewClienteInputModel advogado);
      public void Update(int id, NewClienteInputModel advogado);
      public void Delete(int id);
}
