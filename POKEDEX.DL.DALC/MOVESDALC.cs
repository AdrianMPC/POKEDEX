using POKEDEX.BL.BE;
using System.Data;
using System.Data.SqlClient;

namespace POKEDEX.DL.DALC
{
    public class MOVESDALC
    {
        private string strCadenaConexion = "Data Source=DESKTOP-QCCGD0O\\SQLEXPRESS01;Initial Catalog=POKEDEX_USIL;Integrated Security=True";
        public List<MOVESBE> MovesListar(int codigo1, int codigo2)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspMovesListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                List<MOVESBE> LstTYPESBE = new List<MOVESBE>();
                TYPESDALC typeobj = new TYPESDALC();
                SqlParameter[] arrSqlParameter = new SqlParameter[2];
                
                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@TYPE_ID";
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = codigo1;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = "@TYPE_ID2";
                arrSqlParameter[1].SqlDbType = SqlDbType.Int;
                arrSqlParameter[1].Value = codigo2;

                Con.Open();
                Cmd.Parameters.AddRange(arrSqlParameter);
                Cmd.ExecuteNonQuery();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    MOVESBE objMovesBE = new MOVESBE();
                    objMovesBE.MOVES_ID = Convert.ToInt32(reader[0]);
                    objMovesBE.MOVES_NAME = reader[1].ToString();
                    objMovesBE.MOVES_DESC = reader[2].ToString();
                    objMovesBE.TYPES_ID = Convert.ToInt32(reader[3]);
                    objMovesBE.TYPES_NAME = typeobj.TypeObtener(objMovesBE.TYPES_ID).TYPE_NAME;

                    LstTYPESBE.Add(objMovesBE);
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
    }
}
