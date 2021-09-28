using System;
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

            // clear ListView listViewIcons of all Items
            listViewIcons.Items.Clear();

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

                // IconsRows Column Counter
                int fy = 0;

                IconRows[fx, fy] = fx.ToString();

                fy++;

                IconRows[fx, fy] = Path.GetFileNameWithoutExtension(file).Replace("-", "").Replace("_", "");

                fy++;

                IconRows[fx, fy] = file;

                fx++;
            }
            // debugging
            Print2DArray(IconRows);

            LoadData(IconRows);

        }

        /// <summary>This method loads/populates the ListView listViewIcons
        /// with a multidimensional string array generated
        /// from the icons in the Icons folder.
        /// <example>For example
        /// <code>
        /// string[,] IconRows = new string[x,3];
        ///   LoadData(IconRows);
        /// </code>
        /// </example>
        /// </summary>
        public void LoadData(string[,] source) {

            // Get directory program is running in
            string prefix =  Directory.GetCurrentDirectory();
            // Create ImageList IconList
            System.Windows.Forms.ImageList IconList = new ImageList();

            // Set IconList size to 16x16
            IconList.ImageSize = new Size(16, 16);

            // Create new string List IconNames to hold the names of the icons.
            List<string> IconNames = new List<string>();

            // Create string array item 3 long to be populated by the data for each icon.
            // Array #  Purpose
            //      0   ID (incremented int)
            //      1   Icon Name
            //      2   Relative Path
            string[] item = new string[3];

            // Loop through input variable source using for loop and populate string array item for each icon
            for (int i = 0; i < source.GetLength(0); i++)
            { // for loop - Icons - Open

                int x = 0;
                for (int j = 0; j < source.GetLength(1); j++)
                { // for loop - Icons - Icon properties - Open

                    // get current value in nested for loops and assign to string value
                    string value = source[i, j];
                    Debug.Write(value);
                    // assign value of string value to current item string array position
                    item[x] = value;
                    x++;

                }   // for loop - Icons - Icon properties - Closed

                // debugging
                Console.WriteLine(item[0] + " - " + item[1] + " - " + item[2]);

                // assign full path and filename for the icon to string iconfullfilename
                string iconfullfilename = @prefix + @"\" + item[2];
                // add the icon path and filename image assigned to iconfullfilename to the ImageList IconList
                IconList.Images.Add(Image.FromFile(iconfullfilename));

                // add the name of the icon to the string List IconNames.
                IconNames.Add(item[1]);

                // debugging
                Debug.WriteLine("");

            } // for loop - Icons - Closed
            // Set LargeImageList for ListView listViewIcons to ImageList IconList
            listViewIcons.LargeImageList = IconList;
            // Set SmallImageList for ListView listViewIcons to ImageList IconList
            listViewIcons.SmallImageList = IconList;

            // create int INx for using position in foreach loop
            int INx = 0;

            foreach (string IconName in IconNames) // Loop through List IconNames with foreach as IconName
            {
                //Add IconName to the ListView listViewIcons Collection incrementally using the loop number to match up
                listViewIcons.Items.Add(IconName, INx);
                INx++;
            }
            //foreach (string s in source)
            //{
            //    // debugging
            //    Debug.WriteLine("String - " + s);

            ////listIcons.Items.Add(s[x][0].ToString(), s[x][1].ToString(), s[x][2].ToString());

            //}
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