using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
{
    // Instancias do tipo CLIENTE
    Cliente cliente1 = new Cliente(01, "Chrislayne Godoy", "857.032.950-41", "chris@gmail.com", "Kurt");
    Cliente cliente2 = new Cliente(02, "João Silva", "123.456.789-00", "joao@gmail.com", "Bug");
    Cliente cliente3 = new Cliente(03, "Ana Souza", "987.654.321-00", "ana@gmail.com", "Byron");
    Cliente cliente4 = new Cliente(04, "Pedro Santos", "456.789.123-00", "pedro@gmail.com", "Pinguim");
    Cliente cliente5 = new Cliente(05, "Maria Oliveira", "789.123.456-00", "maria@gmail.com", "Loboc");

    //Lista de CLIENTES e atribui os Clientes
    List<Cliente> listaClientes = new List<Cliente>();
    listaClientes.Add(cliente1)
    listaClientes.Add(cliente2)
    listaClientes.Add(cliente3)
    listaClientes.Add(cliente4)
    listaClientes.Add(cliente5)

    ViewBag.listaClientes = listaClientes;


    // Instancia do tipo FORNECEDOR
    Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
    Fornecedor fornecedor2 = new Fornecedor(02, "FornecTech Ltda.", "22.345.678/0001-90", "fornec@tech.com.br");
    Fornecedor fornecedor3 = new Fornecedor(03, "Suprimentos Rápidos", "33.456.789/0001-70", "supri@rapidos.com.us");
    Fornecedor fornecedor4 = new Fornecedor(04, "Materiais Essenciais", "44.567.890/0001-60", "mat@essenciais.com.uk");
    Fornecedor fornecedor5 = new Fornecedor(05, "Tecnologia Avançada", "55.678.901/0001-50", "tec@avancada.com.us");

    //Lista de FORNECEDORES e atribui os Fornecedores
    List<Fornecedor> listaFornecedores = new List<Fornecedor>();
    listaFornecedores.Add(fornecedor1)
    listaFornecedores.Add(fornecedor2)
    listaFornecedores.Add(fornecedor3)
    listaFornecedores.Add(fornecedor4)
    listaFornecedores.Add(fornecedor5)

    ViewBag.listaFornecedores = listaFornecedores;

    return View();
}


  public IActionResult Privacy()
  {
    return View();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}