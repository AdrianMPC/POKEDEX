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
        private string PokemonID = "@POKEMONID";
        private string Name = "@NAME";
        private string Type1_ID = "@TYPE1_ID";
        private string Type2_ID = "@TYPE2_ID";
        private string HP = "@HP";
        private string ATTACK = "@ATTACK";
        private string DEFENSE = "@DEFENSE";
        private string SPEED_ATTACK = "@SPEED_ATTACK";
        private string SPEED_DEFENSE = "@SPEED_DEFENSE";
        private string SPEED = "@SPEED";
        private string IMAGE_DIR = "@IMAGE_DIR";
        private string STATE = "@STATE";

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
              
                    objPokemonBE.TYPE2 = Convert.ToInt32(reader[3]);
                    objPokemonBE.TYPEs2 = typebe.TypeObtener(objPokemonBE.TYPE2.GetValueOrDefault()).TYPE_NAME;
                    
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
                    objPokemonBE.TYPEs2 = typebe.TypeObtener(objPokemonBE.TYPE2.GetValueOrDefault()).TYPE_NAME;
                    
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

        public bool PokemonInsertar(POKEMONBE objPokemonBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonInsertar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter[] arrSqlParameter = new SqlParameter[12];
                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = PokemonID;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objPokemonBE.POKEMONID;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = Name;
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 20;
                arrSqlParameter[1].Value = objPokemonBE.NAME;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = Type1_ID;
                arrSqlParameter[2].SqlDbType = SqlDbType.Int;
                arrSqlParameter[2].Value = objPokemonBE.TYPE1;

               
                arrSqlParameter[3] = new SqlParameter();
                arrSqlParameter[3].ParameterName = Type2_ID;
                arrSqlParameter[3].SqlDbType = SqlDbType.Int;
                arrSqlParameter[3].Value = objPokemonBE.TYPE2;
                

                arrSqlParameter[4] = new SqlParameter();
                arrSqlParameter[4].ParameterName = HP;
                arrSqlParameter[4].SqlDbType = SqlDbType.Int;
                arrSqlParameter[4].Value = objPokemonBE.HP;

                arrSqlParameter[5] = new SqlParameter();
                arrSqlParameter[5].ParameterName = ATTACK;
                arrSqlParameter[5].SqlDbType = SqlDbType.Int;
                arrSqlParameter[5].Value = objPokemonBE.ATTACK;

                arrSqlParameter[6] = new SqlParameter();
                arrSqlParameter[6].ParameterName = DEFENSE;
                arrSqlParameter[6].SqlDbType = SqlDbType.Int;
                arrSqlParameter[6].Value = objPokemonBE.DEFENSE;

                arrSqlParameter[7] = new SqlParameter();
                arrSqlParameter[7].ParameterName = SPEED_ATTACK;
                arrSqlParameter[7].SqlDbType = SqlDbType.Int;
                arrSqlParameter[7].Value = objPokemonBE.SPEED_ATTACK;

                arrSqlParameter[8] = new SqlParameter();
                arrSqlParameter[8].ParameterName = SPEED_DEFENSE;
                arrSqlParameter[8].SqlDbType = SqlDbType.Int;
                arrSqlParameter[8].Value = objPokemonBE.SPEED_DEFENSE;

                arrSqlParameter[9] = new SqlParameter();
                arrSqlParameter[9].ParameterName = SPEED;
                arrSqlParameter[9].SqlDbType = SqlDbType.Int;
                arrSqlParameter[9].Value = objPokemonBE.SPEED;

                arrSqlParameter[10] = new SqlParameter();
                arrSqlParameter[10].ParameterName = IMAGE_DIR;
                arrSqlParameter[10].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[10].Size = 200;
                arrSqlParameter[10].Value = objPokemonBE.IMAGE_DIR;

                arrSqlParameter[11] = new SqlParameter();
                arrSqlParameter[11].ParameterName = STATE;
                arrSqlParameter[11].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[11].Size = 3;
                arrSqlParameter[11].Value = objPokemonBE.STATE;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PokemonEditar(POKEMONBE objPokemonBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonEditar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] arrSqlParameter = new SqlParameter[12];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = PokemonID;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objPokemonBE.POKEMONID;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = Name;
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 20;
                arrSqlParameter[1].Value = objPokemonBE.NAME;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = Type1_ID;
                arrSqlParameter[2].SqlDbType = SqlDbType.Int;
                arrSqlParameter[2].Value = objPokemonBE.TYPE1;

              
                arrSqlParameter[3] = new SqlParameter();
                arrSqlParameter[3].ParameterName = Type2_ID;
                arrSqlParameter[3].SqlDbType = SqlDbType.Int;
                arrSqlParameter[3].Value = objPokemonBE.TYPE2;
               

                arrSqlParameter[4] = new SqlParameter();
                arrSqlParameter[4].ParameterName = HP;
                arrSqlParameter[4].SqlDbType = SqlDbType.Int;
                arrSqlParameter[4].Value = objPokemonBE.HP;

                arrSqlParameter[5] = new SqlParameter();
                arrSqlParameter[5].ParameterName = ATTACK;
                arrSqlParameter[5].SqlDbType = SqlDbType.Int;
                arrSqlParameter[5].Value = objPokemonBE.ATTACK;

                arrSqlParameter[6] = new SqlParameter();
                arrSqlParameter[6].ParameterName = DEFENSE;
                arrSqlParameter[6].SqlDbType = SqlDbType.Int;
                arrSqlParameter[6].Value = objPokemonBE.DEFENSE;

                arrSqlParameter[7] = new SqlParameter();
                arrSqlParameter[7].ParameterName = SPEED_ATTACK;
                arrSqlParameter[7].SqlDbType = SqlDbType.Int;
                arrSqlParameter[7].Value = objPokemonBE.SPEED_ATTACK;

                arrSqlParameter[8] = new SqlParameter();
                arrSqlParameter[8].ParameterName = SPEED_DEFENSE;
                arrSqlParameter[8].SqlDbType = SqlDbType.Int;
                arrSqlParameter[8].Value = objPokemonBE.SPEED_DEFENSE;

                arrSqlParameter[9] = new SqlParameter();
                arrSqlParameter[9].ParameterName = SPEED;
                arrSqlParameter[9].SqlDbType = SqlDbType.Int;
                arrSqlParameter[9].Value = objPokemonBE.SPEED;

                arrSqlParameter[10] = new SqlParameter();
                arrSqlParameter[10].ParameterName = IMAGE_DIR;
                arrSqlParameter[10].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[10].Size = 200;
                arrSqlParameter[10].Value = objPokemonBE.IMAGE_DIR;

                arrSqlParameter[11] = new SqlParameter();
                arrSqlParameter[11].ParameterName = STATE;
                arrSqlParameter[11].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[11].Size = 3;
                arrSqlParameter[11].Value = objPokemonBE.STATE;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PokemonEliminar(int codigo)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonEliminar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter arrSqlParameter = new SqlParameter();

                arrSqlParameter.ParameterName = PokemonID;
                arrSqlParameter.SqlDbType = SqlDbType.Int;
                arrSqlParameter.Value = codigo;

                Cmd.Parameters.Add(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PokemonReestablecer(int codigo)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonRestablecer";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter arrSqlParameter = new SqlParameter();

                arrSqlParameter.ParameterName = PokemonID;
                arrSqlParameter.SqlDbType = SqlDbType.Int;
                arrSqlParameter.Value = codigo;

                Cmd.Parameters.Add(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}