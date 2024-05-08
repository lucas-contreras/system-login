using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Login.Entity;
using System.Text;
using System.Threading.Tasks;

namespace System.Login.DAL
{
    public class GlobalConfigDAL
    {
        public bool UpdateGlobalConfig(GlobalConfig config)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@AttemptsToLogin", config.AttemptsToLogin),
                new SqlParameter("@CheckMinCharacters", config.CheckMinCharacters),
                new SqlParameter("@RequireMayusAndMin", config.RequireMayusAndMin),
                new SqlParameter("@RequireNumberAndChars", config.RequireNumberAndChars),
                new SqlParameter("@RequireAtLeastOneSpecialChar", config.RequireAtLeastOneSpecialChar),
                new SqlParameter("@Require2FAAuth", config.Require2FAAuth),
                new SqlParameter("@RequireSecurtyQuestions", config.RequireSecurtyQuestions),
                new SqlParameter("@AllowOldPassCombination", config.AllowOldPassCombination),
                new SqlParameter("@AllowAutoUnlockUser", config.AllowAutoUnlockUser),
                new SqlParameter("@UnlockLapseTime", config.UnlockLapseTime)
            };

            var result = Connection.ExecuteNonQuery("sp_GlobalConfig_Update", parameters);
            return result;
        }
    }
}
