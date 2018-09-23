using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Util
{
    public sealed class RequestValidator
    {
        private const string ERR_CODE_PARAM_MISSING = "-10000";
        private const string ERR_MSG_PARAM_MISSING = "client-error:Missing required arguments:{0}";

        public static void ValidateRequired(string name, object value)
        {
            if (value == null)
            {
                throw new ArkException(ERR_CODE_PARAM_MISSING, string.Format(ERR_MSG_PARAM_MISSING, name));
            }
            else
            {
                if (value.GetType() == typeof(string))
                {
                    string strValue = value as string;
                    if (string.IsNullOrEmpty(strValue))
                    {
                        throw new ArkException(ERR_CODE_PARAM_MISSING, string.Format(ERR_MSG_PARAM_MISSING, name));
                    }
                }
            }
        }
    }
}
