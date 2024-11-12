using EletrosDomesticos.Models;
using Microsoft.AspNetCore.Mvc;

namespace EletrosDomesticos.Controllers
{
    public class EletroDomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<EletroDomestico> eletros = new List<EletroDomestico>
            {
                new Televisor { Marca = "Samsung", Modelo = "NeoQLED", ConsumoEnergetico = 75, TamanhoTela = 22, EhSmart = true},
                new Televisor { Marca = "Samsung", Modelo = "MicroLED", ConsumoEnergetico = 50, TamanhoTela = 110, EhSmart = true },
                new Geladeira { Marca = "ElectroLux", Modelo = "Frost Free", CapacidadeLitros = 454, TemFreezer = true }
            };
            return View(eletros);
        }
    }
}
