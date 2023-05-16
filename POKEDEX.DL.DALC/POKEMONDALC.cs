using Microsoft.Identity.Client;
using POKEDEX.BL.BE;
using POKEDEX.DL.DALC;
using System.Data;
using System.Data.SqlClient;

namespace POKEDEX.DL.DALC
{
    public class POKEMONDALC
    {
        private string strCadenaConexion = "Data Source=DESKTOP-QCCGD0O\\SQLEXPRESS01;Initial Catalog=POKEDEX_USIL;Integrated Security=True";

        public List<POKEMONBE> PokemonListar()
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                List<POKEMONBE> LstPokemonBE = new List<POKEMONBE>();
                TYPESDALC typebe = new TYPESDALC();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    POKEMONBE objPokemonBE      = new POKEMONBE();
                    objPokemonBE.POKEMONID      = Convert.ToInt32(reader[0]);
                    objPokemonBE.NAME           = reader[1].ToString();
                    objPokemonBE.TYPE1          = Convert.ToInt32(reader[2]);
                    objPokemonBE.TYPEs1         = typebe.TypeObtener(objPokemonBE.TYPE1).TYPE_NAME;
                    objPokemonBE.TYPE2          = Convert.ToInt32(reader[3]);
                    objPokemonBE.TYPEs2         = typebe.TypeObtener(objPokemonBE.TYPE2).TYPE_NAME;
                    objPokemonBE.HP             = Convert.ToInt32(reader[4]);
                    objPokemonBE.ATTACK         = Convert.ToInt32(reader[5]);
                    objPokemonBE.DEFENSE        = Convert.ToInt32(reader[6]);
                    objPokemonBE.SPEED_ATTACK   = Convert.ToInt32(reader[7]);
                    objPokemonBE.SPEED_DEFENSE  = Convert.ToInt32(reader[8]);
                    objPokemonBE.SPEED          = Convert.ToInt32(reader[9]);
                    objPokemonBE.IMAGE_DIR      = reader[10].ToString();
                    objPokemonBE.STATE          = reader[11].ToString();
                    LstPokemonBE.Add(objPokemonBE);
                }
                reader.Close();
                Con.Close();

                return LstPokemonBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public POKEMONBE PokemonObtener(int id)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonObtener";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                TYPESDALC typebe = new TYPESDALC();

                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter arrSqlParameter = new SqlParameter();

                arrSqlParameter.ParameterName = "@TYPE_ID";
                arrSqlParameter.SqlDbType = SqlDbType.Int;
                arrSqlParameter.Value = id;

                POKEMONBE objPokemonBE = new POKEMONBE();
                Con.Open();
                Cmd.Parameters.Add(arrSqlParameter);
                Cmd.ExecuteNonQuery();

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    objPokemonBE.POKEMONID = Convert.ToInt32(reader[0]);
                    objPokemonBE.NAME = reader[1].ToString();
                    objPokemonBE.TYPE1 = Convert.ToInt32(reader[2]);
                    objPokemonBE.TYPEs1 = typebe.TypeObtener(objPokemonBE.TYPE1).TYPE_NAME;
                    objPokemonBE.TYPE2 = Convert.ToInt32(reader[3]);
                    objPokemonBE.TYPEs2 = typebe.TypeObtener(objPokemonBE.TYPE2).TYPE_NAME;
                    objPokemonBE.HP = Convert.ToInt32(reader[4]);
                    objPokemonBE.ATTACK = Convert.ToInt32(reader[5]);
                    objPokemonBE.DEFENSE = Convert.ToInt32(reader[6]);
                    objPokemonBE.SPEED_ATTACK = Convert.ToInt32(reader[7]);
                    objPokemonBE.SPEED_DEFENSE = Convert.ToInt32(reader[8]);
                    objPokemonBE.SPEED = Convert.ToInt32(reader[9]);
                    objPokemonBE.IMAGE_DIR = reader[10].ToString();
                    objPokemonBE.STATE = reader[11].ToString();
                }
                Con.Close();

                return objPokemonBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}