using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using mRemoteNG.Tools;
using mRemoteNG.Resources.Language;

namespace mRemoteNG.Connection
{
    public class ConnectionInfoInheritance
    {
        private ConnectionInfoInheritance _tempInheritanceStorage;

        #region Public Properties

        #region General

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.General)),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.All)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionAll)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool EverythingInherited
        {
            get => EverythingIsInherited();
            set => SetAllValues(value);
        }

        #endregion

        #region Display

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Display), 2),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Description)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionDescription)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool Description { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Display), 2),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Icon)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionIcon)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool Icon { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Display), 2),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Panel)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionPanel)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool Panel { get; set; }

        #endregion

        #region Connection

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Connection), 3),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Username)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionUsername)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        [Browsable(true)]
        public bool Username { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Connection), 3),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.VmId)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionVmId)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        [Browsable(true)]
        public bool VmId { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Connection), 3),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Password)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionPassword)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        [Browsable(true)]
        public bool Password { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Connection), 3),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Domain)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionDomain)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        [Browsable(true)]
        public bool Domain { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Connection), 3),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Port)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionPort)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool Port { get; set; }
        
        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Connection), 3),
         LocalizedAttributes.LocalizedDisplayNameInheritAttribute(nameof(mRemoteNG.Resources.Language.SshTunnel)),
         LocalizedAttributes.LocalizedDescriptionInheritAttribute(nameof(mRemoteNG.Resources.Language.PropertyDescriptionSshTunnel)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        [Browsable(true)]
        public bool SSHTunnelConnectionName { get; set; }

        #endregion

        #region Protocol

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Protocol)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionProtocol)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool Protocol { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.RdpVersion)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRdpVersion)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RdpVersion { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.ExternalTool)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionExternalTool)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool ExtApp { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.PuttySession)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionPuttySession)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool PuttySession { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.SshOptions)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionSshOptions)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool SSHOptions { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.AuthenticationLevel)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionAuthenticationLevel)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RDPAuthenticationLevel { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.MinutesToIdleTimeout)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRDPMinutesToIdleTimeout)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RDPMinutesToIdleTimeout { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.MinutesToIdleTimeout)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRDPAlertIdleTimeout)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RDPAlertIdleTimeout { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.LoadBalanceInfo)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionLoadBalanceInfo)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool LoadBalanceInfo { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.RenderingEngine)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRenderingEngine)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RenderingEngine { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.UseConsoleSession)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionUseConsoleSession)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool UseConsoleSession { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.UseCredSsp)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionUseCredSsp)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool UseCredSsp { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.UseVmId)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionUseVmId)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool UseVmId { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Protocol), 4),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.UseEnhancedMode)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionUseEnhancedMode)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool UseEnhancedMode { get; set; }

        #endregion

        #region RD Gateway

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Gateway), 5),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.RdpGatewayUsageMethod)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRdpGatewayUsageMethod)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RDGatewayUsageMethod { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Gateway), 5),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.RdpGatewayHostname)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRDGatewayHostname)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RDGatewayHostname { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Gateway), 5),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.RdpGatewayUseConnectionCredentials)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRDGatewayUseConnectionCredentials)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RDGatewayUseConnectionCredentials { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Gateway), 5),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.RdpGatewayUsername)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRDGatewayUsername)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RDGatewayUsername { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Gateway), 5),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.RdpGatewayPassword)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRdpGatewayPassword)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RDGatewayPassword { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Gateway), 5),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.RdpGatewayDomain)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRDGatewayDomain)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RDGatewayDomain { get; set; }

        #endregion

        #region Appearance

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Resolution)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionResolution)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool Resolution { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.AutomaticResize)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionAutomaticResize)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool AutomaticResize { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Colors)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionColors)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool Colors { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.CacheBitmaps)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionCacheBitmaps)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool CacheBitmaps { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.DisplayWallpaper)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionDisplayWallpaper)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool DisplayWallpaper { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.DisplayThemes)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionDisplayThemes)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool DisplayThemes { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.FontSmoothing)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionEnableFontSmoothing)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool EnableFontSmoothing { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.EnableDesktopComposition)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionEnableDesktopComposition)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool EnableDesktopComposition { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.DisableFullWindowDrag)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionDisableFullWindowDrag)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool DisableFullWindowDrag { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.DisableMenuAnimations)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionDisableMenuAnimations)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool DisableMenuAnimations { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.DisableCursorShadow)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionDisableCursorShadow)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool DisableCursorShadow { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 6),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.DisableCursorBlinking)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionDisableCursorBlinking)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool DisableCursorBlinking { get; set; }

        #endregion

        #region Redirect

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Redirect), 7),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.RedirectKeys)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRedirectKeys)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RedirectKeys { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Redirect), 7),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.DiskDrives)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRedirectDrives)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RedirectDiskDrives { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Redirect), 7),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Printers)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRedirectPrinters)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RedirectPrinters { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Redirect), 7),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Clipboard)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRedirectClipboard)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RedirectClipboard { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Redirect), 7),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Redirect)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRedirectPorts)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RedirectPorts { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Redirect), 7),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Redirect)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRedirectSmartCards)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RedirectSmartCards { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Redirect), 7),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Sounds)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRedirectSounds)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RedirectSound { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Redirect), 7),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.SoundQuality)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionSoundQuality)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool SoundQuality { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Redirect), 7),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.AudioCapture)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionRedirectAudioCapture)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool RedirectAudioCapture { get; set; }

        #endregion

        #region Misc

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Miscellaneous), 8),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.ExternalToolBefore)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionExternalToolBefore)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool PreExtApp { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Miscellaneous), 8),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.ExternalToolAfter)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionExternalToolAfter)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool PostExtApp { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Miscellaneous), 8),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.MacAddress)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionMACAddress)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool MacAddress { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Miscellaneous), 8),
         LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.UserField)),
         LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionUser1)),
         TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool UserField { get; set; }

        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Miscellaneous), 8),
        LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Favorite)),
        LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionFavorite)),
        TypeConverter(typeof(MiscTools.YesNoTypeConverter))]
        public bool Favorite { get; set; }
        #endregion

        #region VNC
        [LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Compression)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionCompression)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCCompression {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Encoding)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionEncoding)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCEncoding {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Connection), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.AuthenticationMode)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionAuthenticationMode)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCAuthMode {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Proxy), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.ProxyType)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionVNCProxyType)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCProxyType {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Proxy), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.ProxyAddress)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionVNCProxyAddress)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCProxyIP {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Proxy), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.ProxyPort)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionVNCProxyPort)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCProxyPort {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Proxy), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.ProxyUsername)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionVNCProxyUsername)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCProxyUsername {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Proxy), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.ProxyPassword)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionVNCProxyPassword)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCProxyPassword {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.Colors)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionColors)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCColors {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.SmartSizeMode)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionSmartSizeMode)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCSmartSizeMode {get; set;}
				
		[LocalizedAttributes.LocalizedCategory(nameof(mRemoteNG.Resources.Language.Appearance), 9), 
		LocalizedAttributes.LocalizedDisplayNameInherit(nameof(mRemoteNG.Resources.Language.ViewOnly)), 
		LocalizedAttributes.LocalizedDescriptionInherit(nameof(mRemoteNG.Resources.Language.PropertyDescriptionViewOnly)), 
		TypeConverter(typeof(MiscTools.YesNoTypeConverter))]public bool VNCViewOnly {get; set;}
        #endregion

        [Browsable(false)] public ConnectionInfo Parent { get; private set; }

        #endregion


        public ConnectionInfoInheritance(ConnectionInfo parent, bool ignoreDefaultInheritance = false)
        {
            Parent = parent;
            if (!ignoreDefaultInheritance)
                SetAllValues(DefaultConnectionInheritance.Instance);
        }


        public ConnectionInfoInheritance Clone(ConnectionInfo parent)
        {
            var newInheritance = (ConnectionInfoInheritance)MemberwiseClone();
            newInheritance.Parent = parent;
            newInheritance._tempInheritanceStorage = null;
            return newInheritance;
        }

        public void EnableInheritance()
        {
            if (_tempInheritanceStorage != null)
                UnstashInheritanceData();
        }

        private void UnstashInheritanceData()
        {
            SetAllValues(_tempInheritanceStorage);
            _tempInheritanceStorage = null;
        }

        public void DisableInheritance()
        {
            StashInheritanceData();
            TurnOffInheritanceCompletely();
        }

        private void StashInheritanceData()
        {
            _tempInheritanceStorage = Clone(Parent);
        }

        public void TurnOnInheritanceCompletely()
        {
            SetAllValues(true);
        }

        public void TurnOffInheritanceCompletely()
        {
            SetAllValues(false);
        }

        private bool EverythingIsInherited()
        {
            var inheritanceProperties = GetProperties();
            var everythingInherited = inheritanceProperties.All((p) => (bool)p.GetValue(this, null));
            return everythingInherited;
        }

        public IEnumerable<PropertyInfo> GetProperties()
        {
            var properties = typeof(ConnectionInfoInheritance).GetProperties();
            var filteredProperties = properties.Where(FilterProperty);
            return filteredProperties;
        }

        /// <summary>
        /// Gets the name of all properties where inheritance is turned on
        /// (set to True).
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetEnabledInheritanceProperties()
        {
            return GetProperties()
                .Where(property => (bool)property.GetValue(this))
                .Select(property => property.Name)
                .ToList();
        }

        private bool FilterProperty(PropertyInfo propertyInfo)
        {
            var exclusions = new[] {"EverythingInherited", "Parent"};
            var valueShouldNotBeFiltered = !exclusions.Contains(propertyInfo.Name);
            return valueShouldNotBeFiltered;
        }

        private void SetAllValues(bool value)
        {
            var properties = GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType.Name == typeof(bool).Name)
                    property.SetValue(this, value, null);
            }
        }

        private void SetAllValues(ConnectionInfoInheritance otherInheritanceObject)
        {
            var properties = GetProperties();
            foreach (var property in properties)
            {
                var newPropertyValue = property.GetValue(otherInheritanceObject, null);
                property.SetValue(this, newPropertyValue, null);
            }
        }
    }
}