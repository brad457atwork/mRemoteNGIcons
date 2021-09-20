using System;
using mRemoteNG.Properties;
using mRemoteNG.Resources.Language;

namespace mRemoteNG.UI.Forms.OptionsPages
{
    public sealed partial class IconsPage
    {
        public IconsPage()
        {
            InitializeComponent();
            ApplyTheme();
            PageIcon = Resources.ImageConverter.GetImageAsIcon(Properties.Resources.StartupProject_16x);
        }

        public override string PageName
        {
            get => Language.Icons;
            set { }
        }

    }
}