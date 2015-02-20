
namespace FacebookNet.Internals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal static class FX
    {
        internal static FacebookApiException ApiException(string name, params object[] args)
        {
            return ApiException(name, null, args);
        }

        internal static FacebookApiException ApiException(string name, Exception innerException, params object[] args)
        {
            const string prefix = "ApiException_";
            FacebookApiException ex;
            if (args == null || args.Length == 0)
            {
                var message = Strings.ResourceManager.GetString(prefix + name);
                ex = new FacebookApiException(message, innerException);
            }
            else
            {
                var message = string.Format(Strings.ResourceManager.GetString(prefix + name), args);
                ex = new FacebookApiException(message, innerException);
            }

            ex.Data["Key"] = name;

            return ex;
        }

        internal static FacebookNetException InternalException(string name, params object[] args)
        {
            return InternalException(name, null, args);
        }

        internal static FacebookNetException InternalException(string name, Exception innerException, params object[] args)
        {
            const string prefix = "InternalException_";
            FacebookNetException ex;
            if (args == null || args.Length == 0)
            {
                var message = Strings.ResourceManager.GetString(prefix + name);
                ex = new FacebookNetException(message, innerException);
            }
            else
            {
                var message = string.Format(Strings.ResourceManager.GetString(prefix + name), args);
                ex = new FacebookNetException(message, innerException);
            }

            ex.Data["Key"] = name;

            return ex;
        }
    }
}
