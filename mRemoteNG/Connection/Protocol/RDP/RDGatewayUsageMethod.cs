using mRemoteNG.Tools;
using mRemoteNG.Resources.Language;

namespace mRemoteNG.Connection.Protocol.RDP
{
    public enum RDGatewayUsageMethod
    {
        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Never))]
        Never = 0, // TSC_PROXY_MODE_NONE_DIRECT

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Always))]
        Always = 1, // TSC_PROXY_MODE_DIRECT

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Detect))]
        Detect = 2 // TSC_PROXY_MODE_DETECT
    }
}