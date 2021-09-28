using System;
using System.IO;
using System.Linq;
using mRemoteNG.Properties;
using mRemoteNG.Resources;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace mRemoteNG.UI.Forms.OptionsPages
{
    public sealed partial class IconsPage
    {
        Bitmap BMPIcon;
        string prefix = Directory.GetCurrentDirectory();
        System.Windows.Forms.ImageList IconList = new ImageList();
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
            IEnumerable<string> files = from file in
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

                // Fix Icon name being more readable by still removing these things, but then having the file loaded by a reference to the item.
                //IconRow[1] = Path.GetFileNameWithoutExtension(file).Replace("-","").Replace("_","");
                IconRow[1] = Path.GetFileNameWithoutExtension(file);
                IconRow[2] = file;

                // IconsRows Column Counter
                int fy = 0;

                IconRows[fx, fy] = fx.ToString();

                fy++;
                // Fix Icon name being more readable by still removing these things, but then having the file loaded by a reference to the item.
                //IconRows[fx, fy] = Path.GetFileNameWithoutExtension(file).Replace("-", "").Replace("_", "");
                IconRows[fx, fy] = Path.GetFileNameWithoutExtension(file);

                fy++;

                IconRows[fx, fy] = file;

                fx++;

            }

            // debugging
            //Print2DArray(IconRows);

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

                // Get icon from file
                Image img = Image.FromFile(iconfullfilename);

                // Convert Image img to byte array
                byte[] bArr = imgToByteArray(img);

                Image img1 = byteArrayToImage(bArr);
                // add the icon path and filename image assigned to iconfullfilename to the ImageList IconList
                IconList.Images.Add(img1);

                // add the name of the icon to the string List IconNames.
                IconNames.Add(item[1]);

                // debugging
                Debug.WriteLine("");

            } // for loop - Icons - Closed
            // Set LargeImageList for ListView listViewIcons to ImageList IconList
          //  listViewIcons.LargeImageList = IconList;
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

           // IconList.Dispose();
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

        private void listViewIcons_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewIcons.SelectedItems.Count > 0)
            {
                ListView.SelectedListViewItemCollection selected;
                selected = null;
                selected = listViewIcons.SelectedItems;
                Console.WriteLine("Text: " + selected[0].Text + " | Name: " + selected[0].Name + " | Index: " + selected[0].Index.ToString());
                Console.WriteLine("Image Path: " + @prefix + @"\" + @"Icons\" + selected[0].Text + ".ico");
                //BMPIcon = new Bitmap(@prefix + @"\" + @"Icons\" + selected[0].Text + ".ico");

                //MemoryStream mStream = new MemoryStream();
                //BMPIcon.Save(mStream, ImageFormat.bmp);

                //mrngPictureBox1.Image = BMPIcon;

               txtIconName.Text = selected[0].Text;
                mrngBtnIconDelete.Enabled = true;
                mrngBtnIconImageChange.Enabled = true;
                mrngBtnIconSave.Enabled = true;

                //panelRight.Visible = true;
                tableLayoutPanelIconEdit.Visible = true;
            } else
            {
                mrngBtnIconDelete.Enabled = false;
                mrngBtnIconImageChange.Enabled = false;
                mrngBtnIconSave.Enabled = true;

                txtIconName.Text = "";
                //panelRight.Visible = false;
                tableLayoutPanelIconEdit.Visible = false;
            }

        }

        private void mrngBtnIconSave_Click(object sender, EventArgs e)
        {

        }

        private void mrngBtnIconImageChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = prefix,
                Title = "Select new Icon",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "ico",
                Filter = "icon files (*.ico)|*.ico",
                FilterIndex = 1,
                RestoreDirectory = true,

                // Needs to be set to false or file will be locked by OpenFileDialog
                ReadOnlyChecked = false,
                ValidateNames = false,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ListView.SelectedListViewItemCollection selected;
                selected = null;
                selected = listViewIcons.SelectedItems;

                string Filesrc = openFileDialog1.FileName;
                string Filedst = prefix + @"\Icons\" + selected[0].Text + ".ico";

                string message = "Confirm updating icon " + Filedst + " with icon " + Filesrc;
                string title = "Confirm icon update";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    listViewIcons.Items.Clear();

                    //listViewIcons.Dispose();
                   // Bitmap b = (Bitmap)BMPIcon.Clone();
                  //  BMPIcon.Dispose(); // now temp is released
                  //  BMPIcon = null;
                  //  b.Dispose();

                  //  mrngPictureBox1.Image.Dispose();

                  //  File.Move(Filedst, Filedst + ".del");
                  //  File.Delete(Filedst + ".del");
                    File.Copy(Filesrc, Filedst,true);
                }
                else
                {

                }

                //mrngPictureBox1.Image = BMPIcon;

                Console.WriteLine("Destination Full Path: " + Filedst);

                // debuging
                Console.Write("Source: " + Filesrc + " | " + "Destination: " + Filedst);


                LoadSettings();
                //mrngPictureBox1.Image = new Bitmap(Filesrc);
                //File.Copy(Filesrc, Filedst);
                //textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void mrngBtnIconDelete_Click(object sender, EventArgs e)
        {

        }

        private void mrngBtnIconSave_Click_1(object sender, EventArgs e)
        {

        }

        private void IconsPage_Load(object sender, EventArgs e)
        {
            mrngBtnIconAdd.Visible = false;
            mrngBtnIconDelete.Visible = false;
            mrngBtnIconSave.Visible = false;
        }
        ///// <summary>
        ///// Returns a Bitmap from the cache which is identified by an id
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public static Bitmap GetBitmap(int id)
        //{
        //    MemoryStream ms = null;
        //    if (images.TryGetValue(id, out ms))
        //    {
        //        return (Bitmap)Image.FromStream(ms);
        //    }
        //    return null;
        //}
        ///// <summary>
        ///// Adds an Bitmap to the cache
        ///// </summary>
        ///// <param name="bitmap"></param>
        ///// <returns>0 if the Bitmap is null, otherwise a uique id</returns>
        //public static int Add(Bitmap bitmap)
        //{
        //    if (bitmap == null)
        //    {
        //        return 0;
        //    }

        //    recycleLocker.EnterReadLock();

        //    try
        //    {
        //        var ms = new MemoryStream();
        //        bitmap.Save(ms, ImageFormat.Tiff);

        //        // Recycle Id or make new one
        //        int id;
        //        if (!recycle.TryDequeue(out id))
        //        {
        //            id = Interlocked.Increment(ref currentId);
        //        }

        //        // this should never be possible to fail
        //        images.TryAdd(id, ms);

        //        return id;
        //    }
        //    finally
        //    {
        //        recycleLocker.ExitReadLock();
        //    }
        //}
        //convert image to bytearray
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream,ImageFormat.Bmp);
                return mStream.ToArray();
            }
        }
        //convert bytearray to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
    }
}