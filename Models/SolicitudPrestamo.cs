public class SolicitudPrestamo
{
    private string nombre;
    private int edad;
    private int dni;
    private bool trabaja;
    private string tipoEmpleo;
    private double ingreso;
    private bool tieneDeudas;
    private double monto;
    private int plazo;
    private bool aceptaTerminos;

    public SolicitudPrestamo(string nombre, int edad, int dni, bool trabaja, string tipoEmpleo, double ingreso, bool tieneDeudas, double monto, int plazo, bool aceptaTerminos)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
        this.trabaja = trabaja;
        this.tipoEmpleo = tipoEmpleo;
        this.ingreso = ingreso;
        this.tieneDeudas = tieneDeudas;
        this.monto = monto;
        this.plazo = plazo;
        this.aceptaTerminos = aceptaTerminos;
    }

    public string GetNombre()
     {
         return nombre; 
    }
    public int GetEdad() 
    {
         return edad; 
    }
    public bool GetTrabaja()
     { 
        return trabaja; 
    }
    public double GetIngreso() 
    { 
        return ingreso; 
    }
    public bool GetTieneDeudas() 
    { 
        return tieneDeudas; 
    }
    public double GetMonto() 
    { 
        return monto;
    }
    public bool GetAceptaTerminos()
     { 
        return aceptaTerminos; 
     }
}