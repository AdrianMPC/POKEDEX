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

        public bool PokemonEliminar(int Codigo)
        {
            try
            {
                POKEMONDALC objPokemonDALC = new POKEMONDALC();
                return objPokemonDALC.PokemonEliminar(Codigo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool PokemonReestablecer(int Codigo)
        {
            try
            {
                POKEMONDALC objPokemonDALC = new POKEMONDALC();
                return objPokemonDALC.PokemonReestablecer(Codigo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool PokemonEditar(POKEMONBE objPokemonBE)
        {
            try
            {
                POKEMONDALC objPokemonDALC = new POKEMONDALC();
                return objPokemonDALC.PokemonEditar(objPokemonBE);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool PokemonInsertar(POKEMONBE objPokemonBE)
        {
            try
            {
                POKEMONDALC objPokemonDALC = new POKEMONDALC();
                return objPokemonDALC.PokemonInsertar(objPokemonBE);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}