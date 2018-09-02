using System.Collections.Generic;

namespace ArkSdk
{
    public interface IArkRequest<out T> where T : ArkResponse
    {
        string GetBody();

        string GetMethod();

        IDictionary<string, string> GetParameters();

        string GetUrl();
    }
}
