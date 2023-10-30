using DosNumeros.Servicios;

namespace DosNumeros
{
    class program
    {
        static void Main(String[] args)
        {
            MenuInterfaz menu = new MenuImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();
            {
                bool cerrarMenu = false;
                int opcionIntroducida;
                while (!cerrarMenu)
                {
                    opcionIntroducida = menu.mostrarMenuYSeleccion();
                    switch (opcionIntroducida)
                    {
                        case 0:
                            cerrarMenu = true;
                            break;
                            case 1:
                            int guardar1 = menu.datoInt();
                            double guardar2 = menu.datoDouble();
                            oi.metodo(guardar2, guardar1);
                            break;

                    }

                }
            }
        }
    }
}