using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk
{
    public class ArkException : Exception
    {
        private string errorCode;
        private string errorMsg;

        public ArkException() : base()
        {
        }

        public ArkException(string message) : base(message)
        {
        }

        protected ArkException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ArkException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ArkException(string errorCode, string errorMsg) : base(errorCode + ":" + errorMsg)
        {
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        public string ErrorMsg
        {
            get { return this.errorMsg; }
        }
    }
}
