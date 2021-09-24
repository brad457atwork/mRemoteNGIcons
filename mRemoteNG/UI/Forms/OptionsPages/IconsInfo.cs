using System;
using System.ComponentModel;
using System.Linq;
using WeifenLuo.WinFormsUI.Docking;

namespace mRemoteNG.UI
{
    public class IconsInfo : ICloneable
    {
        #region Private Variables

        private string _name;
        private string _path;

        #endregion

        #region Constructors

        public IconsInfo(string iconName,
                         string iconPath)
        {
            _name = iconName;
            _path = iconPath;

         //   setCustomExtenders();
        }

        //public IconsInfo(string iconName,
        //                 string iconPath)
        //{
        //    _name = iconName;
        //    _path = iconPath;
        //    // setCustomExtenders();
        //}

        #endregion

        #region Public Methods

        public object Clone()
        {
            //var extPalette = new ExtendedColorPalette
            //{
            //    ExtColorPalette =
            //        _extendedPalette.ExtColorPalette.ToDictionary(entry => entry.Key, entry => entry.Value),
            //    DefaultColorPalette = _extendedPalette.DefaultColorPalette
            //};
            var clonedObj = new IconsInfo(_name, _path)
            {
                IsExtendable = IsExtendable,
                IsThemeBase = IsThemeBase
            };

            return clonedObj;
        }

        #endregion


        #region Properties

        [Browsable(false)]
        public string Name
        {
            get => _name;
            set
            {
                if (string.Equals(_name, value, StringComparison.InvariantCulture))
                {
                    return;
                }

                _name = value;
            }
        }

        //public ThemeBase Theme
        //{
        //    get => _theme;
        //    set
        //    {
        //        if (value != null && _theme == value)
        //        {
        //            return;
        //        }

        //        _theme = value;
        //        setCustomExtenders();
        //    }
        //}

        //public string URI
        //{
        //    get => _URI;
        //    set
        //    {
        //        if (value != null && _URI == value)
        //        {
        //            return;
        //        }

        //        _URI = value;
        //    }
        //}

        //public VisualStudioToolStripExtender.VsVersion Version
        //{
        //    get => _version;
        //    set
        //    {
        //        if (Equals(_version, value))
        //        {
        //            return;
        //        }

        //        _version = value;
        //    }
        //}

        //public ExtendedColorPalette ExtendedPalette
        //{
        //    get => _extendedPalette;
        //    set
        //    {
        //        if (_extendedPalette != null && _extendedPalette == value)
        //        {
        //            return;
        //        }

        //        _extendedPalette = value;
        //    }
        //}

        public bool IsThemeBase { get; set; }

        public bool IsExtendable { get; set; }

        public bool IsExtended { get; private set; }

        #endregion
    }
}
