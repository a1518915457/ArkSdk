using System;

namespace ArkSdk
{
    public interface IArkClient
    {
        T Execute<T>(IArkRequest<T> request) where T : ArkResponse;

        T Execute<T>(IArkRequest<T> request, DateTime timestamp) where T : ArkResponse;
    }
}
