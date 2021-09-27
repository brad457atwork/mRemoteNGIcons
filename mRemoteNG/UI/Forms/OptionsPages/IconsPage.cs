﻿using System;
using System.IO;
using System.Linq;
using mRemoteNG.Properties;
using mRemoteNG.Resources;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

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
        public override void LoadSettings()
        {

            //string f = "";
            //foreach (string fileName f in Directory.GetFiles("SomeDirectory"))
            //    {
            //}
            string root = "Icons";

            // Get a list of all subdirectories
            var files = from file in
            Directory.EnumerateFiles(root)
                        select file;

            //Debugging
            //Console.WriteLine("Files: {0}", files.Count<string>().ToString());
            //Console.WriteLine("List of Files");
            //At first we cannot create or delete themes, depends later on the type of selected theme
            //btnThemeNew.Enabled = false;
            //btnThemeDelete.Enabled = false;
            //Load the list of themes
            //listIcons.Items.Clear();
            listViewIcons.Items.Clear();
            // ReSharper disable once CoVariantArrayConversion
            //listIcons.Items.AddRange
            //cboTheme.SelectedItem = _themeManager.ActiveTheme;
            //cboTheme_SelectionChangeCommitted(this, new EventArgs());
            //cboTheme.DisplayMember = "Name";

            //listPalette.FormatCell += ListPalette_FormatCell; //Color cell formatter


            int filecount = files.Count();
            string[,] IconRows = new string[filecount,3];

            // IconRows Row Counter
            int fx = 0;
            foreach (var file in files)
            {
                string[] IconRow = new string[3];

                IconRow[0] = fx.ToString();
                IconRow[1] = Path.GetFileNameWithoutExtension(file).Replace("-","").Replace("_","");
                IconRow[2] = file;

                //IconRows[x, 0] = Path.GetFileNameWithoutExtension(file).Replace("-", "").Replace("_", "");
                //IconRows[x, 1] = file;
                //IconRows[x, 2] = "Change";
                //IconRows[x, 3] = "Delete";


                //listIcons.
                //listIcons.Items.Add(IconRow[1]);
                //  listIcons.DataBindings.Add()
                //(Path.GetFileNameWithoutExtension(file).Replace("-", "").Replace("_", ""), file, "Change", "Delete");
                //listIcons

                //DataGridViewRow row = (DataGridViewRow)yourDataGridView.Rows[0].Clone();
                //row.Cells[0].Value = "XYZ";
                //row.Cells[1].Value = 50.2;
                //yourDataGridView.Rows.Add(row);

                // IconsRows Column Counter
                int fy = 0;

                IconRows[fx, fy] = fx.ToString();

                fy++;

                IconRows[fx, fy] = Path.GetFileNameWithoutExtension(file).Replace("-", "").Replace("_", "");

                fy++;

                IconRows[fx, fy] = file;

                fx++;
            }
            Print2DArray(IconRows);

            LoadData(IconRows);
            ////At first we cannot create or delete themes, depends later on the type of selected theme
            //btnThemeNew.Enabled = false;
            //btnThemeDelete.Enabled = false;
            ////Load the list of themes
            //cboTheme.Items.Clear();
            //// ReSharper disable once CoVariantArrayConversion
            //cboTheme.Items.AddRange(_themeManager.LoadThemes().OrderBy(x => x.Name).ToArray());
            //cboTheme.SelectedItem = _themeManager.ActiveTheme;
            //cboTheme_SelectionChangeCommitted(this, new EventArgs());
            //cboTheme.DisplayMember = "Name";

            //listPalette.FormatCell += ListPalette_FormatCell; //Color cell formatter
        }

        //public List<> LoadThemes()
        //{
        //    if (themes != null) return themes.Values.OfType<ThemeInfo>().ToList();
        //    themes = new Hashtable();

        //    if (themePath == null) return themes.Values.OfType<ThemeInfo>().ToList();
        //    try
        //    {
        //        //Check that theme folder exist before trying to load themes
        //        if (ThemeDirExists())
        //        {
        //            var themeFiles = Directory.GetFiles(themePath, "*.vstheme");

        //            //First we load the default base theme, its vs2015lightNG
        //            var defaultTheme = LoadDefaultTheme();
        //            themes.Add(defaultTheme.Name, defaultTheme);
        //            //Then the rest
        //            foreach (var themeFile in themeFiles)
        //            {
        //                // Skip the default theme here, since it will get loaded again without the *NG below...
        //                if (themeFile.Contains("vs2015light.vstheme")) continue;
        //                //filter default one
        //                var extTheme = ThemeSerializer.LoadFromXmlFile(themeFile, defaultTheme);
        //                if (extTheme.Theme == null || themes.ContainsKey(extTheme.Name)) continue;

        //                if (extTheme.Name.Equals("darcula") || extTheme.Name.Equals("vs2015blue") ||
        //                    extTheme.Name.Equals("vs2015dark"))
        //                    extTheme.Name = $"{extTheme.Name}NG";

        //                themes.Add(extTheme.Name, extTheme);
        //            }

        //            //Load the embedded themes, extended palettes are taken from the vs2015 themes, trying to match the color theme

        //            // 2012
        //            var vs2012Light = new ThemeInfo("vs2012Light", new VS2012LightTheme(), "",
        //                                            VisualStudioToolStripExtender.VsVersion.Vs2012,
        //                                            ((ThemeInfo)themes["vs2015lightNG"]).ExtendedPalette);
        //            themes.Add(vs2012Light.Name, vs2012Light);
        //            var vs2012Dark = new ThemeInfo("vs2012Dark", new VS2012DarkTheme(), "",
        //                                           VisualStudioToolStripExtender.VsVersion.Vs2012,
        //                                           ((ThemeInfo)themes["vs2015darkNG"]).ExtendedPalette);
        //            themes.Add(vs2012Dark.Name, vs2012Dark);
        //            var vs2012Blue = new ThemeInfo("vs2012Blue", new VS2012BlueTheme(), "",
        //                                           VisualStudioToolStripExtender.VsVersion.Vs2012,
        //                                           ((ThemeInfo)themes["vs2015blueNG"]).ExtendedPalette);
        //            themes.Add(vs2012Blue.Name, vs2012Blue);

        //            // 2013
        //            var vs2013Light = new ThemeInfo("vs2013Light", new VS2013LightTheme(), "",
        //                                            VisualStudioToolStripExtender.VsVersion.Vs2013,
        //                                            ((ThemeInfo)themes["vs2015lightNG"]).ExtendedPalette);
        //            themes.Add(vs2013Light.Name, vs2013Light);
        //            var vs2013Dark = new ThemeInfo("vs2013Dark", new VS2013DarkTheme(), "",
        //                                           VisualStudioToolStripExtender.VsVersion.Vs2013,
        //                                           ((ThemeInfo)themes["vs2015darkNG"]).ExtendedPalette);
        //            themes.Add(vs2013Dark.Name, vs2013Dark);
        //            var vs2013Blue = new ThemeInfo("vs2013Blue", new VS2013BlueTheme(), "",
        //                                           VisualStudioToolStripExtender.VsVersion.Vs2013,
        //                                           ((ThemeInfo)themes["vs2015blueNG"]).ExtendedPalette);
        //            themes.Add(vs2013Blue.Name, vs2013Blue);

        //            // 2015
        //            var vs2015Light = new ThemeInfo("vs2015Light", new VS2015LightTheme(), "",
        //                                            VisualStudioToolStripExtender.VsVersion.Vs2015,
        //                                            ((ThemeInfo)themes["vs2015lightNG"]).ExtendedPalette);
        //            themes.Add(vs2015Light.Name, vs2015Light);
        //            var vs2015Dark = new ThemeInfo("vs2015Dark", new VS2015DarkTheme(), "",
        //                                           VisualStudioToolStripExtender.VsVersion.Vs2015,
        //                                           ((ThemeInfo)themes["vs2015darkNG"]).ExtendedPalette);
        //            themes.Add(vs2015Dark.Name, vs2015Dark);
        //            var vs2015Blue = new ThemeInfo("vs2015Blue", new VS2015BlueTheme(), "",
        //                                           VisualStudioToolStripExtender.VsVersion.Vs2015,
        //                                           ((ThemeInfo)themes["vs2015blueNG"]).ExtendedPalette);
        //            themes.Add(vs2015Blue.Name, vs2015Blue);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Runtime.MessageCollector.AddExceptionStackTrace("Error loading themes", ex);
        //    }

        //    return themes.Values.OfType<ThemeInfo>().ToList();
        //}

        public void LoadData(string[,] source) {
            // ListViewItem
            //foreach(string[] s in source)
            //{
            //
            //}

            string prefix =  Directory.GetCurrentDirectory();
           // listViewIcons.View = View.SmallIcon;
            System.Windows.Forms.ImageList IconList = new ImageList();
            IconList.ImageSize = new Size(16, 16);
            //myImageList1.Images.Add(Image.FromFile(@"C:\Users\Indus_User\Desktop\Icons\W\01.PNG"));
            //this.listViewIcons.View = View.List;

            //ImageList il = new ImageList();
            //il.ImageSize = new Size(32, 32);
            List<string> IconNames = new List<string>();

            string[] item = new string[3];
            for (int i = 0; i < source.GetLength(0); i++)
            {
                int x = 0;
                for (int j = 0; j < source.GetLength(1); j++)
                {

                    string value = source[i, j];
                    Debug.Write(value);
                    item[x] = value;
                    x++;
                }


              //  IconList.Images.Add(Image.FromFile(@prefix + @"\"  + item[2]));

                Console.WriteLine(item[0] + " - " + item[1] + " - " + item[2]);

               // ListViewItem lvi = new ListViewItem();

                //lvi.Text = item[2];
                //lvi.Name = Path.GetFileNameWithoutExtension(item[1]).Replace("-", "").Replace("_", "");
                string iconfullfilename = @prefix + @"\" + item[2];
                IconList.Images.Add(Image.FromFile(iconfullfilename));
                IconNames.Add(item[1]);
                //listViewIcons.Items.Add(item[1], item[0]);

                //this.listViewIcons.LargeImageList = il;
                // lvi.= item[0];
                //listViewIcons.Items.Add(lvi);

                // Semi working code for populating LV - BEGIN
                //ListView.ListViewItemCollection coll = new ListView.ListViewItemCollection(new ListView());
                //// coll.Add("0", "test", "source");
                //ListViewItem lvitem = new ListViewItem();
                //lvitem.Name = item[1];
                //lvitem.ImageIndex = int.Parse(item[0]);
                //lvitem.Text = item[1];
                ////listIcons.Items.Add(item[1]);
                // Semi working code for populating LV - END
                //listIcons.SetObjects();

                // Assign item values to List object
                //var lstCalls = new List<Icons>()
                //      {
                //        new Icons() {
                //            Id = item[0],
                //            Icon_Name = item[1],
                //            Icon_Path = item[2]
                //                   }
                //      };

                // listIcons.SetObjects(lstCalls);
                //coll.Add(item[1], item[2]);
                //listIcons.Items.AddRange(coll);
                //                BrightIdeasSoftware.OLVListItem
                //  listIcons.Items.AddRange(coll);
                //List<ListViewItem> arrayitems = new List<ListViewItem>();
                //arrayitems.Add(new ListViewItem("one"));
                //arrayitems.Add(new ListViewItem("two"));
                //arrayitems.Add(new ListViewItem("three"));
                //ListView.ListViewItemCollection coll = new ListView.ListViewItemCollection(new ListView());
                //// coll.Add("0", "test", "source");
                //coll.Add(item[x], item[x], "source");
                //listIcons.Items.AddRange(coll);
                //    //arrayitems[0],arrayitems[1],arrayitems[3]);
                //item[0], item[1], item[2]);
                //listIcons.Items.Add(source[x][0].ToString(), source[x][1].ToString(), source[x][2].ToString());
                Debug.WriteLine("");

            }
            listViewIcons.LargeImageList = IconList;
            listViewIcons.SmallImageList = IconList;


            int INx = 0;
            foreach (string IconName in IconNames) // Loop through List with foreach
            {
                listViewIcons.Items.Add(IconName, INx);
                INx++;
            }
            foreach (string s in source)
            {
                Debug.WriteLine("String - " + s);

            //listIcons.Items.Add(s[x][0].ToString(), s[x][1].ToString(), s[x][2].ToString());

            }
        }

        public static void Print2DArray<T>(T[,] matrix)
        {
            int x = 0;
            string textitem = "";
            Debug.WriteLine("|" +   " Row | " + "Icon Name".PadRight(30) + " | Icon Path".PadRight(50) + "    |");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    textitem = matrix[i, j].ToString();
                    if (j == 0) {
                        Debug.Write("| " + textitem.PadRight(4));
                    } else if (j == 1) {
                        Debug.Write("| " + textitem.PadRight(30) + " | ");
                    } else {

                        Debug.Write(textitem.PadRight(50) + " |");

                    }

                }
                Debug.WriteLine("");
                x++;
            }
        }
        public class Icons
        {
            public string Id { get; set; }
            public string Icon_Name { get; set; }
            public string Icon_Path { get; set; }
        }

    }
}