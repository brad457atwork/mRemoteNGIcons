using System;
using mRemoteNG.Properties;
using mRemoteNG.Resources;

namespace mRemoteNG.UI.Forms.OptionsPages
{
    public sealed partial class IconsPage
    {
        public IconsPage()
        {
            InitializeComponent();
            ApplyTheme();
            PageIcon = Resources.ImageConverter.GetImageAsIcon(Properties.Resources.SearchAndApps_16x);
        }

        public override string PageName
        {
            get => Language.Icons;
            set { }
        }

    }
}