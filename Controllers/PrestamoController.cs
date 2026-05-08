using Microsoft.AspNetCore.Mvc;

public class PrestamoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
   [HttpPost]
public IActionResult Evaluar(string nombre,string apellido,int edad,int dni,string trabaja,string tipoEmpleo,double ingreso,string deudas,double monto,int plazo,string terminos)
    {
        bool trabajaBool = false;
        bool deudasBool = false;
        bool aceptaTerminos = false;
        

        if (trabaja == "si")
        {
            trabajaBool = true;
        }

        if (deudas == "si")
        {
            deudasBool = true;
        }

        if (terminos == "ok")
        {
            aceptaTerminos = true;
        }

        SolicitudPrestamo s = new SolicitudPrestamo(nombre,apellido,edad,dni,trabajaBool,tipoEmpleo,ingreso,deudasBool,monto,plazo, aceptaTerminos);

        bool resultado = EvaluadorPrestamo.EsApto(s);

        ViewBag.Nombre = nombre;
        ViewBag.Apellido = apellido;
        ViewBag.Resultado = resultado;

        return View("Resultado");
        
    }
}