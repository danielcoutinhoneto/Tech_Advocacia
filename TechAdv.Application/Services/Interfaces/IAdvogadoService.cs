using TechAdv.Application.InputModel;
using TechAdv.Application.ViewModels;

namespace TechAdv.Application.Services.Interfaces;

public interface IAdvogadoService
{
     public List<AdogadoViewModel> GetAll();
      public AdogadoViewModel? GetById(int id);
      public AdogadoViewModel? GetByCrm(string crm);
      public int Create(NewAdvogadoInputModel medico);
      public int CreateAtendimento(int medicoId,NewAdvogadoInputModel atendimento);
      public void Update(int id, NewAdvogadoInputModel medico);
      public void Delete(int id);
}

