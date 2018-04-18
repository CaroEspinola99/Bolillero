using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBolillero
{
    public class Simulacion
    {
        public static bool Acierta(Bolillero unBolillero, List<Byte> listita)
        {
            return listita.All(numero => numero == unBolillero.sacarBolillaAlAzar());
        }

        public static ulong VecesQueAcierta(Bolillero unBolillero, List<Byte> listita, ulong cantidadSimulacion)
        {
            ulong contador = 0;
            for (ulong i = 0; i < cantidadSimulacion; i++)
            {
                unBolillero.volverAColocarBolillas();
                if (Acierta(unBolillero, listita))
                {
                    contador++;
                }
            }
            return contador;

        }
        public static ulong VecesQueAciertaConHilos(Bolillero unBolillero, List<Byte> listita, ulong cantidadSimulacion, Byte CantHilos)
        {

        }
    }
}
