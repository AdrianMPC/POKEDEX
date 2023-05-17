using POKEDEX.BL.BE;
using POKEDEX.DL.DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEDEX.BL.BC
{
    public class MOVESBC
    {
        public List<MOVESBE> MovimientosListar(int codigo, int codigo2)
        {
            try
            {
                MOVESDALC objMovesDALC = new MOVESDALC();
                return objMovesDALC.MovesListar(codigo, codigo2);
            }
            catch (Exception ex)
            {
                return new List<MOVESBE>();
            }

        }
    }
}
