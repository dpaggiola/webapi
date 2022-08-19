using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[Route("api/[controller]")]
public class CategoriaController: ControllerBase
{
  ICategoriaService categoriaService;
  
  public CategoriaController(ICategoriaService service)
  {
    categoriaService = service;
  }
}
