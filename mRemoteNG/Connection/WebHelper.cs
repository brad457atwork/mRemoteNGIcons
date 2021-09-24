using mRemoteNG.Connection.Protocol;
using mRemoteNG.Resources;

namespace mRemoteNG.Connection
{
    public static class WebHelper
    {
        public static void GoToUrl(string url)
        {
            var connectionInfo = new ConnectionInfo();
            connectionInfo.CopyFrom(DefaultConnectionInfo.Instance);

            connectionInfo.Name = "";
            connectionInfo.Hostname = url;
            connectionInfo.Protocol = url.StartsWith("https:") ? ProtocolType.HTTPS : ProtocolType.HTTP;
            connectionInfo.SetDefaultPort();
            if (string.IsNullOrEmpty(connectionInfo.Panel))
                connectionInfo.Panel = Language.General;
            connectionInfo.IsQuickConnect = true;
            var connectionInitiator = new ConnectionInitiator();
            connectionInitiator.OpenConnection(connectionInfo, ConnectionInfo.Force.DoNotJump);
        }
    }
}