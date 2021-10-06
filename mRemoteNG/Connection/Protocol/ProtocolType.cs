using mRemoteNG.Tools;
using mRemoteNG.Resources.Language;

namespace mRemoteNG.Connection.Protocol
{
    public enum ProtocolType
    {
        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Rdp))]
        RDP = 0,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Vnc))]
        VNC = 1,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.SshV1))]
        SSH1 = 2,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.SshV2))]
        SSH2 = 3,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Telnet))]
        Telnet = 4,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Rlogin))]
        Rlogin = 5,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Raw))]
        RAW = 6,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Http))]
        HTTP = 7,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Https))]
        HTTPS = 8,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.PowerShell))]
        PowerShell = 10,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.ExternalTool))]
        IntApp = 20
    }
}