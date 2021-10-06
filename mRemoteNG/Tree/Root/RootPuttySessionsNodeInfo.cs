using mRemoteNG.Properties;
using mRemoteNG.Tools;
using mRemoteNG.Resources.Language;

namespace mRemoteNG.Tree.Root
{
    public class RootPuttySessionsNodeInfo : RootNodeInfo
    {
        private string _name;
        private string _panel;


        public RootPuttySessionsNodeInfo() : base(RootNodeType.PuttySessions)
        {
            _name = mRemoteNG.Resources.Language.PuttySavedSessionsRootName;
            _panel =
                string.IsNullOrEmpty(Settings.Default.PuttySavedSessionsPanel)
                    ? mRemoteNG.Resources.Language.General
                    : Settings.Default.PuttySavedSessionsPanel;
        }

        #region Public Properties

        [LocalizedAttributes.LocalizedDefaultValue("strPuttySavedSessionsRootName")]
        public override string Name
        {
            get => _name;
            set => _name = value;
            //Settings.Default.PuttySavedSessionsName = value;
        }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Display)),
         LocalizedAttributes.LocalizedDisplayName(nameof(mRemoteNG.Resources.Language.Panel)),
         LocalizedAttributes.LocalizedDescription(nameof(mRemoteNG.Resources.Language.PropertyDescriptionPanel))]
        public override string Panel
        {
            get => _panel;
            set
            {
                _panel = value;
                Settings.Default.PuttySavedSessionsPanel = value;
            }
        }

        public override TreeNodeType GetTreeNodeType()
        {
            return TreeNodeType.PuttyRoot;
        }

        #endregion
    }
}