namespace TechAdv.Core.Exceptions;

public class ClienteNotFoundExceptions : Exception
{   
    public ClienteNotFoundExceptions() :
      base("Cliente não encontrado.")
   {
   }
}