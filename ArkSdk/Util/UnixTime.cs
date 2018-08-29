using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Util
{
    class UnixTime
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private long unixTime;

        public UnixTime(long unixTime)
        {
            this.unixTime = unixTime;
        }

        public static UnixTime FromDateTime(DateTime dateTime)
        {
            long unixTime = Convert.ToInt64((dateTime.ToUniversalTime() - epoch).TotalSeconds);
            return new UnixTime(unixTime);
        }

        public override string ToString()
        {
            return unixTime.ToString();
        }
    }
}
