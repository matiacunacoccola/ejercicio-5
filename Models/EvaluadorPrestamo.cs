public class EvaluadorPrestamo
{
    public static bool EsApto(SolicitudPrestamo s)
    {
        if (s.GetEdad() < 18)
        {
           return false;
        }
        

        if (!s.GetTrabaja())
        {
           return false;
        }
            

        if (s.GetIngreso() < 250000)
         {
            return false;
         }
        if (s.GetMonto() > s.GetIngreso() * 5)
        {
            return false;
        }
      

        if (s.GetTieneDeudas())
        {
            return false;
        }


        if (!s.GetAceptaTerminos())
        {
            return false;
        }
            

        return true;
    }
}