using POKEDEX.BL.BE;
using System.Data;
using System.Data.SqlClient;

namespace POKEDEX.DL.DALC
{
    public class TYPESDALC
    {
        private string strCadenaConexion = "Data Source=DESKTOP-QCCGD0O\\SQLEXPRESS01;Initial Catalog=POKEDEX_USIL;Integrated Security=True";
     
        public List<TYPESBE> TYPESListar()
        {

            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTypesListar";
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

                arrSqlParameter.ParameterName = "@TYPE_ID";
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
                }
                Con.Close();
                return TYPESobj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
