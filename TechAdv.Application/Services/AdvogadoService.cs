using TechAdv.Application.InputModel;
using TechAdv.Application.ViewModels;

namespace TechAdv.Application.Services.Interfaces;

public class AdvogadoService
{
      public List<AdogadoViewModel> GetAll();
      public AdogadoViewModel? GetById(int id);
      public AdogadoViewModel? GetByCrm(string CNA);
      public int Create(NewAdvogadoInputModel advogado);
     // public int Create(int advogadoId, NewAdvogadoInputModel atendimento);
      public void Update(int id, NewAdvogadoInputModel advogado);
      public void Delete(int id);
}
