using POKEDEX.BL.BE;
using System.Data;
using System.Data.SqlClient;

namespace POKEDEX.DL.DALC
{
    public class TYPESDALC
    {
        private string strCadenaConexion = "Data Source=DESKTOP-QCCGD0O\\SQLEXPRESS01;Initial Catalog=POKEDEX_USIL;Integrated Security=True";
        private string TYPE_ID = "@TYPE_ID";
        private string TYPE_NAME = "@TYPE_NAME";
        private string STATUS = "@STATUS";
     
        public List<TYPESBE> TYPESListar()
        {

            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTypeListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                List<TYPESBE> LstTYPESBE = new List<TYPESBE>();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    TYPESBE objTYPESBE = new TYPESBE();

                    objTYPESBE.TYPE_ID = Convert.ToInt32(reader[0]);
                    objTYPESBE.TYPE_NAME = reader[1].ToString();
                    objTYPESBE.TYPE_STATE = reader[2].ToString();

                    LstTYPESBE.Add(objTYPESBE);
                }
                reader.Close();
                Con.Close();

                return LstTYPESBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TYPESBE TypeObtener(int codigo)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTypeObtener";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter arrSqlParameter = new SqlParameter();

                arrSqlParameter.ParameterName = TYPE_ID;
                arrSqlParameter.SqlDbType = SqlDbType.Int;
                arrSqlParameter.Value = codigo;

                TYPESBE TYPESobj = new TYPESBE();
                Con.Open();
                Cmd.Parameters.Add(arrSqlParameter);
                Cmd.ExecuteNonQuery();

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    TYPESobj.TYPE_ID = Convert.ToInt32(reader[0]);
                    TYPESobj.TYPE_NAME = reader[1].ToString();
                    TYPESobj.TYPE_STATE = reader[2].ToString();
                }
                Con.Close();
                return TYPESobj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TypeEditar(TYPESBE objTYPESBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTypeEditar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] arrSqlParameter = new SqlParameter[3];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = TYPE_ID;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objTYPESBE.TYPE_ID;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = TYPE_NAME;
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 20;
                arrSqlParameter[1].Value = objTYPESBE.TYPE_NAME;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = STATUS;
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objTYPESBE.TYPE_STATE;

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

        public bool TypeInsertar(TYPESBE objTYPESBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "upsTypeInsertar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] arrSqlParameter = new SqlParameter[3];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = TYPE_ID;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objTYPESBE.TYPE_ID;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = TYPE_NAME;
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 20;
                arrSqlParameter[1].Value = objTYPESBE.TYPE_NAME;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = STATUS;
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objTYPESBE.TYPE_STATE;

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

        public bool TypeEliminar(int codigo)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTypeEliminar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter arrSqlParameter = new SqlParameter();

                arrSqlParameter.ParameterName = TYPE_ID;
                arrSqlParameter.SqlDbType = SqlDbType.Int;
                arrSqlParameter.Value = codigo;

                Cmd.Parameters.Add(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();

                return true;

            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
