using mRemoteNG.Tools;
using mRemoteNG.Resources.Language;

namespace mRemoteNG.Connection.Protocol.RDP
{
    public enum AuthenticationLevel
    {
        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.AlwaysConnectEvenIfAuthFails))]
        NoAuth = 0,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.DontConnectWhenAuthFails))]
        AuthRequired = 1,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.WarnIfAuthFails))]
        WarnOnFailedAuth = 2
    }
}