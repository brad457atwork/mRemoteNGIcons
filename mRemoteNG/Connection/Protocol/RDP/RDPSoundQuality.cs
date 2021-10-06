using mRemoteNG.Tools;
using mRemoteNG.Resources.Language;

namespace mRemoteNG.Connection.Protocol.RDP
{
    public enum RDPSoundQuality
    {
        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Dynamic))]
        Dynamic = 0,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.Medium))]
        Medium = 1,

        [LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.High))]
        High = 2
    }
}