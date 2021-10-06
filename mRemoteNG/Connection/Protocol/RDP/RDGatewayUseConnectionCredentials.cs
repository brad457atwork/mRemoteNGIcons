using mRemoteNG.Tools;
using mRemoteNG.Resources.Language;

namespace mRemoteNG.Connection.Protocol.RDP
{
    public enum RDGatewayUseConnectionCredentials
    {
        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.UseDifferentUsernameAndPassword))]
        No = 0,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.UseSameUsernameAndPassword))]
        Yes = 1,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.UseSmartCard))]
        SmartCard = 2
    }
}