using POKEDEX.BL.BE;
using POKEDEX.DL.DALC;

namespace POKEDEX.BL.BC
{
    public class TYPESBC
    {
        public List<TYPESBE> PokemonListar()
        {
            try
            {
                TYPESDALC objTypeDALC = new TYPESDALC();
                return objTypeDALC.TYPESListar();
            }
            catch (Exception ex)
            {
                return new List<TYPESBE>();
            }

        }

        public TYPESBE TypeObtener(int codigo)
        {
            try
            {
                TYPESDALC objTypeDALC = new TYPESDALC();
                return objTypeDALC.TypeObtener(codigo);
            }
            catch (Exception ex)
            {
                return new TYPESBE();
            }

        }
    }
}
