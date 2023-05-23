using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        public bool TypeEditar(TYPESBE objtype)
        {
            try
            {
                TYPESDALC typedalc = new TYPESDALC();
                return typedalc.TypeEditar(objtype);
            } 
            catch (Exception e)
            {
                return false;
            }
        }

        public bool TypeEliminar(int codigo)
        {
            try
            {
                TYPESDALC typedalc = new TYPESDALC();
                return typedalc.TypeEliminar(codigo);
            } catch (Exception e)
            {
                return false;
            }
        }

        public bool TypeInsertar(TYPESBE objtypebe)
        {
            try
            {
                TYPESDALC typedalc = new TYPESDALC();
                return typedalc.TypeInsertar(objtypebe);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
