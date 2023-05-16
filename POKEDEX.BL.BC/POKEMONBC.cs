using POKEDEX.BL.BE;
using POKEDEX.DL.DALC;
namespace POKEDEX.BL.BC
{
    public class POKEMONBC
    {
        public List<POKEMONBE> PokemonListar()
        {
            try
            {
                POKEMONDALC objPokemonDALC = new POKEMONDALC();
                return objPokemonDALC.PokemonListar();
            }
            catch (Exception ex)
            {
                return new List<POKEMONBE>();
            }

        }
        public POKEMONBE PokemonObtener(int codigo)
        {
            try
            {
                POKEMONDALC objPokemonDALC = new POKEMONDALC();
                return objPokemonDALC.PokemonObtener(codigo);
            }
            catch (Exception ex)
            {
                return new POKEMONBE();
            }

        }
    }
}