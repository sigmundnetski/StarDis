namespace BANANA
{
    using Elysium.Controls;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Markup;
    using System.Windows.Threading;

    public class UKSPQEFKGYNMSMONBZQOGI : Elysium.Controls.Window, IComponentConnector
    {
        internal System.Windows.Controls.Button add_death_btn;
        internal System.Windows.Controls.Button add_normal_btn;
        internal System.Windows.Controls.Button add_selling_btn;
        public static bool CSHMQQCTTBQOIWJWZUILYT;
        internal System.Windows.Controls.CheckBox death_respawn_1_cbx;
        internal System.Windows.Controls.CheckBox death_respawn_2_cbx;
        internal System.Windows.Controls.Menu death_spots_loading;
        internal System.Windows.Controls.Button delete_death_btn;
        internal System.Windows.Controls.Button delete_normal_btn;
        internal System.Windows.Controls.Button delete_selling_btn;
        private DispatcherTimer EQGAYWNCTPPSOAVONCKLVD = new DispatcherTimer();
        private List<SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY> EVYIHFPIGYCMEXNBWRTBJ = new List<SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY>();
        private ActorLocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new ActorLocalPlayer();
        private DispatcherTimer ICOMXKOFJWXZMNEJSKWZYB = new DispatcherTimer();
        private DispatcherTimer INKBOZSAVUDLTZHGWLYHSF = new DispatcherTimer();
        private DispatcherTimer LCLSCYCFMZUYSUSXLLCHWK = new DispatcherTimer();
        private bool NWLUATZPJLQLBXYIDKBFGB;
        private List<SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY> OYVXLDXCIELLCESUMPSKCP = new List<SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY>();
        internal System.Windows.Controls.Button save_btn;
        internal System.Windows.Controls.ListBox waypoint_death_list;
        internal System.Windows.Controls.ListBox waypoint_death_second_list;
        internal System.Windows.Controls.ListBox waypoint_normal_list;
        internal System.Windows.Controls.ListBox waypoint_selling_list;

        public UKSPQEFKGYNMSMONBZQOGI()
        {
            this.InitializeComponent();
            this.EQGAYWNCTPPSOAVONCKLVD.Tick += new EventHandler(this.WEXWTSIAGKEZOFZMPAFTD);
            this.EQGAYWNCTPPSOAVONCKLVD.Interval = new TimeSpan(0, 0, 0, 0, 0x3e8);
            this.ICOMXKOFJWXZMNEJSKWZYB.Tick += new EventHandler(this.FEKVWVHUARXHIXZYGYHKAN);
            this.ICOMXKOFJWXZMNEJSKWZYB.Interval = new TimeSpan(0, 0, 0, 0, 0x3e8);
            this.LCLSCYCFMZUYSUSXLLCHWK.Tick += new EventHandler(this.MJYWLUDOWYYJTHTTSBMAVU);
            this.LCLSCYCFMZUYSUSXLLCHWK.Interval = new TimeSpan(0, 0, 0, 0, 0x3e8);
            this.INKBOZSAVUDLTZHGWLYHSF.Tick += new EventHandler(this.GSNSXCXNEXHSIPDECNDEIS);
            this.INKBOZSAVUDLTZHGWLYHSF.Interval = new TimeSpan(0, 0, 0, 0, 100);
            this.INKBOZSAVUDLTZHGWLYHSF.Start();
            try
            {
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey in SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR)
                {
                    string str = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey.AQICOOHQONIPEAIZQBONX });
                    string newItem = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str;
                    this.waypoint_normal_list.Items.Add(newItem);
                }
            }
            catch
            {
            }
            try
            {
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey2 in SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE)
                {
                    string str4 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.AQICOOHQONIPEAIZQBONX });
                    string str6 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str4;
                    this.waypoint_death_list.Items.Add(str6);
                }
            }
            catch
            {
            }
            try
            {
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey3 in SLKKBFFDAKRGRBJQZVKHFF.AXRXVEDKKVVJNPJVSINZRX)
                {
                    string str7 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey3.AQICOOHQONIPEAIZQBONX });
                    string str9 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey3.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str7;
                    this.waypoint_death_second_list.Items.Add(str9);
                }
            }
            catch
            {
            }
            try
            {
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey4 in SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH)
                {
                    string str10 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey4.AQICOOHQONIPEAIZQBONX });
                    string str12 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey4.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str10;
                    this.waypoint_selling_list.Items.Add(str12);
                }
            }
            catch
            {
            }
        }

        private void AWLQFXMJPNXSNCFVSFNFBH(object sender, RoutedEventArgs e)
        {
            try
            {
                this.death_respawn_2_cbx.IsChecked = false;
            }
            catch
            {
            }
        }

        private void BPGFSSBIVDBEZRBLRIWYRW(object sender, RoutedEventArgs e)
        {
            SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH.Clear();
            SLKKBFFDAKRGRBJQZVKHFF.XBCQHTMOZWYKVCIDVHXXJL = 0;
            this.waypoint_selling_list.Items.Clear();
            OpenFileDialog dialog = new OpenFileDialog {
                FileName = "",
                DefaultExt = "sdp",
                AddExtension = true,
                RestoreDirectory = true,
                Filter = "Waypoint Files (*.snp)|*.snp"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(dialog.FileName);
                while (!reader.EndOfStream)
                {
                    string source = reader.ReadLine();
                    if (source.Contains<char>('|'))
                    {
                        string[] strArray = source.Split(new char[] { '|' });
                        SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY item = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                            AQICOOHQONIPEAIZQBONX = Convert.ToSingle(strArray[1], CultureInfo.InvariantCulture),
                            ODYHEMSITJPFSFDDEEYCXM = Convert.ToSingle(strArray[0], CultureInfo.InvariantCulture)
                        };
                        SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH.Add(item);
                    }
                }
                reader.Close();
            }
            try
            {
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey2 in SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH)
                {
                    string str2 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.AQICOOHQONIPEAIZQBONX });
                    string newItem = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str2;
                    this.waypoint_selling_list.Items.Add(newItem);
                }
            }
            catch
            {
            }
        }

        private void CXMMZEFBXHBCYMRFVANHVG(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog {
                Filter = "snp (*.snp)|*.snp",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dialog.FileName);
                for (int i = 0; i < this.waypoint_selling_list.Items.Count; i++)
                {
                    writer.WriteLine(this.waypoint_selling_list.Items[i].ToString());
                }
                writer.Close();
            }
        }

        private void FEKVWVHUARXHIXZYGYHKAN(object sender, EventArgs e)
        {
            if (this.death_respawn_1_cbx.IsChecked.Value)
            {
                SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE.Clear();
                SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY item = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                    AQICOOHQONIPEAIZQBONX = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(),
                    ODYHEMSITJPFSFDDEEYCXM = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related()
                };
                string str = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { item.AQICOOHQONIPEAIZQBONX });
                string newItem = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { item.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str;
                SLKKBFFDAKRGRBJQZVKHFF.TULVLIVEFGERTLDQXKJGID.Add(item);
                this.waypoint_death_list.Items.Add(newItem);
            }
            else if (this.death_respawn_2_cbx.IsChecked.Value)
            {
                SLKKBFFDAKRGRBJQZVKHFF.AXRXVEDKKVVJNPJVSINZRX.Clear();
                SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey2 = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                    AQICOOHQONIPEAIZQBONX = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(),
                    ODYHEMSITJPFSFDDEEYCXM = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related()
                };
                string str4 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.AQICOOHQONIPEAIZQBONX });
                string str6 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str4;
                SLKKBFFDAKRGRBJQZVKHFF.HTOJOTHUVZFFJTDSCYZVU.Add(vcllzoqzzprfqhxftliyey2);
                this.waypoint_death_second_list.Items.Add(str6);
            }
        }

        private void GFQXDTDILUWBVMVMWDLFNY(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog {
                Filter = "sp (*.sp)|*.sp",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dialog.FileName);
                for (int i = 0; i < this.waypoint_normal_list.Items.Count; i++)
                {
                    writer.WriteLine(this.waypoint_normal_list.Items[i].ToString());
                }
                writer.Close();
            }
        }

        private void GSNSXCXNEXHSIPDECNDEIS(object sender, EventArgs e)
        {
            if (this.death_respawn_1_cbx.IsChecked.Value)
            {
                this.waypoint_death_list.Visibility = Visibility.Visible;
                this.waypoint_death_second_list.Visibility = Visibility.Collapsed;
            }
            else if (this.death_respawn_2_cbx.IsChecked.Value)
            {
                this.waypoint_death_second_list.Visibility = Visibility.Visible;
                this.waypoint_death_list.Visibility = Visibility.Collapsed;
                this.death_respawn_1_cbx.IsChecked = false;
            }
        }

        private void HHBRTGSENTECUMESLRASDI(object sender, RoutedEventArgs e)
        {
            SLKKBFFDAKRGRBJQZVKHFF.WBXRBHUEJFJTFZYAMJFMXT.Clear();
            this.waypoint_selling_list.Items.Clear();
        }

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (!this.NWLUATZPJLQLBXYIDKBFGB)
            {
                this.NWLUATZPJLQLBXYIDKBFGB = true;
                Uri resourceLocator = new Uri("/StarSpot;component/spotswindow.xaml", UriKind.Relative);
                System.Windows.Application.LoadComponent(this, resourceLocator);
            }
        }

        private void IRMVFNJZDZKIIFKLCBGMJH(object sender, RoutedEventArgs e)
        {
            if (this.death_respawn_1_cbx.IsChecked.Value)
            {
                SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE.Clear();
                SLKKBFFDAKRGRBJQZVKHFF.KNCIKWEVSMLSIXYJRQASQQ = 0;
                this.waypoint_death_list.Items.Clear();
                OpenFileDialog dialog = new OpenFileDialog {
                    FileName = "",
                    DefaultExt = "sdp",
                    AddExtension = true,
                    RestoreDirectory = true,
                    Filter = "Waypoint Files (*.sdp)|*.sdp"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(dialog.FileName);
                    while (!reader.EndOfStream)
                    {
                        string source = reader.ReadLine();
                        if (source.Contains<char>('|'))
                        {
                            string[] strArray = source.Split(new char[] { '|' });
                            SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY item = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                                AQICOOHQONIPEAIZQBONX = Convert.ToSingle(strArray[1], CultureInfo.InvariantCulture),
                                ODYHEMSITJPFSFDDEEYCXM = Convert.ToSingle(strArray[0], CultureInfo.InvariantCulture)
                            };
                            SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE.Add(item);
                        }
                    }
                    reader.Close();
                }
                try
                {
                    foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey2 in SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE)
                    {
                        string str2 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.AQICOOHQONIPEAIZQBONX });
                        string newItem = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str2;
                        this.waypoint_death_list.Items.Add(newItem);
                    }
                }
                catch
                {
                }
            }
            else if (this.death_respawn_2_cbx.IsChecked.Value)
            {
                SLKKBFFDAKRGRBJQZVKHFF.AXRXVEDKKVVJNPJVSINZRX.Clear();
                SLKKBFFDAKRGRBJQZVKHFF.KNCIKWEVSMLSIXYJRQASQQ = 0;
                this.waypoint_death_second_list.Items.Clear();
                OpenFileDialog dialog2 = new OpenFileDialog {
                    FileName = "",
                    DefaultExt = "sdp",
                    AddExtension = true,
                    RestoreDirectory = true,
                    Filter = "Waypoint Files (*.sdp)|*.sdp"
                };
                if (dialog2.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader2 = new StreamReader(dialog2.FileName);
                    while (!reader2.EndOfStream)
                    {
                        string str5 = reader2.ReadLine();
                        if (str5.Contains<char>('|'))
                        {
                            string[] strArray2 = str5.Split(new char[] { '|' });
                            SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey3 = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                                AQICOOHQONIPEAIZQBONX = Convert.ToSingle(strArray2[1], CultureInfo.InvariantCulture),
                                ODYHEMSITJPFSFDDEEYCXM = Convert.ToSingle(strArray2[0], CultureInfo.InvariantCulture)
                            };
                            SLKKBFFDAKRGRBJQZVKHFF.AXRXVEDKKVVJNPJVSINZRX.Add(vcllzoqzzprfqhxftliyey3);
                        }
                    }
                    reader2.Close();
                }
                try
                {
                    foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey4 in SLKKBFFDAKRGRBJQZVKHFF.AXRXVEDKKVVJNPJVSINZRX)
                    {
                        string str6 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey4.AQICOOHQONIPEAIZQBONX });
                        string str8 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey4.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str6;
                        this.waypoint_death_second_list.Items.Add(str8);
                    }
                }
                catch
                {
                }
            }
        }

        private void JBNRDIFFYGAJZVYZEANXGE(object sender, RoutedEventArgs e)
        {
            try
            {
                this.death_respawn_1_cbx.IsChecked = false;
            }
            catch
            {
            }
        }

        private void KVNBCRLQQAXUKJXMPMUXOU(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR.Clear();
                SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE.Clear();
                SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH.Clear();
                SLKKBFFDAKRGRBJQZVKHFF.AXRXVEDKKVVJNPJVSINZRX.Clear();
            }
            foreach (string str in (IEnumerable) this.waypoint_normal_list.Items)
            {
                string[] strArray = str.Split(new char[] { '|' });
                SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY item = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                    AQICOOHQONIPEAIZQBONX = Convert.ToSingle(strArray[1], CultureInfo.InvariantCulture),
                    ODYHEMSITJPFSFDDEEYCXM = Convert.ToSingle(strArray[0], CultureInfo.InvariantCulture)
                };
                SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR.Add(item);
            }
            foreach (string str2 in (IEnumerable) this.waypoint_death_list.Items)
            {
                string[] strArray2 = str2.Split(new char[] { '|' });
                SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey2 = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                    AQICOOHQONIPEAIZQBONX = Convert.ToSingle(strArray2[1], CultureInfo.InvariantCulture),
                    ODYHEMSITJPFSFDDEEYCXM = Convert.ToSingle(strArray2[0], CultureInfo.InvariantCulture)
                };
                SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE.Add(vcllzoqzzprfqhxftliyey2);
            }
            foreach (string str3 in (IEnumerable) this.waypoint_death_second_list.Items)
            {
                string[] strArray3 = str3.Split(new char[] { '|' });
                SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey3 = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                    AQICOOHQONIPEAIZQBONX = Convert.ToSingle(strArray3[1], CultureInfo.InvariantCulture),
                    ODYHEMSITJPFSFDDEEYCXM = Convert.ToSingle(strArray3[0], CultureInfo.InvariantCulture)
                };
                SLKKBFFDAKRGRBJQZVKHFF.AXRXVEDKKVVJNPJVSINZRX.Add(vcllzoqzzprfqhxftliyey3);
            }
            foreach (string str4 in (IEnumerable) this.waypoint_selling_list.Items)
            {
                string[] strArray4 = str4.Split(new char[] { '|' });
                SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey4 = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                    AQICOOHQONIPEAIZQBONX = Convert.ToSingle(strArray4[1], CultureInfo.InvariantCulture),
                    ODYHEMSITJPFSFDDEEYCXM = Convert.ToSingle(strArray4[0], CultureInfo.InvariantCulture)
                };
                SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH.Add(vcllzoqzzprfqhxftliyey4);
            }
        }

        private void KXBIBDJKUWEDWPPUJDARKB(object sender, RoutedEventArgs e)
        {
            if (this.death_respawn_1_cbx.IsChecked.Value)
            {
                SaveFileDialog dialog = new SaveFileDialog {
                    Filter = "sdp (*.sdp)|*.sdp",
                    FilterIndex = 1,
                    RestoreDirectory = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(dialog.FileName);
                    for (int i = 0; i < this.waypoint_death_list.Items.Count; i++)
                    {
                        writer.WriteLine(this.waypoint_death_list.Items[i].ToString());
                    }
                    writer.Close();
                }
            }
            else if (this.death_respawn_2_cbx.IsChecked.Value)
            {
                SaveFileDialog dialog2 = new SaveFileDialog {
                    Filter = "sdp (*.sdp)|*.sdp",
                    FilterIndex = 1,
                    RestoreDirectory = true
                };
                if (dialog2.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer2 = new StreamWriter(dialog2.FileName);
                    for (int j = 0; j < this.waypoint_death_second_list.Items.Count; j++)
                    {
                        writer2.WriteLine(this.waypoint_death_second_list.Items[j].ToString());
                    }
                    writer2.Close();
                }
            }
        }

        private void MJYWLUDOWYYJTHTTSBMAVU(object sender, EventArgs e)
        {
            SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH.Clear();
            SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY item = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                AQICOOHQONIPEAIZQBONX = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(),
                ODYHEMSITJPFSFDDEEYCXM = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related()
            };
            string str = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { item.AQICOOHQONIPEAIZQBONX });
            string newItem = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { item.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str;
            SLKKBFFDAKRGRBJQZVKHFF.WBXRBHUEJFJTFZYAMJFMXT.Add(item);
            this.waypoint_selling_list.Items.Add(newItem);
        }

        private void NDCQVGEIDMHNDJGQPDSICR(object sender, RoutedEventArgs e)
        {
            SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR.Clear();
            SLKKBFFDAKRGRBJQZVKHFF.ZLISEWVYURKJXFHPRKHKMT = 0;
            this.waypoint_normal_list.Items.Clear();
            OpenFileDialog dialog = new OpenFileDialog {
                FileName = "",
                DefaultExt = "sp",
                AddExtension = true,
                RestoreDirectory = true,
                Filter = "Waypoint Files (*.sp)|*.sp"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(dialog.FileName);
                while (!reader.EndOfStream)
                {
                    string source = reader.ReadLine();
                    if (source.Contains<char>('|'))
                    {
                        string[] strArray = source.Split(new char[] { '|' });
                        SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY item = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                            AQICOOHQONIPEAIZQBONX = Convert.ToSingle(strArray[1], CultureInfo.InvariantCulture),
                            ODYHEMSITJPFSFDDEEYCXM = Convert.ToSingle(strArray[0], CultureInfo.InvariantCulture)
                        };
                        SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR.Add(item);
                    }
                }
                reader.Close();
            }
            try
            {
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey2 in SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR)
                {
                    string str2 = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.AQICOOHQONIPEAIZQBONX });
                    string newItem = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { vcllzoqzzprfqhxftliyey2.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str2;
                    this.waypoint_normal_list.Items.Add(newItem);
                }
            }
            catch
            {
            }
        }

        private void OZMNYHNRZMDFTNOVGMSAGM(object sender, RoutedEventArgs e)
        {
            if (this.death_respawn_1_cbx.IsChecked.Value)
            {
                SLKKBFFDAKRGRBJQZVKHFF.TULVLIVEFGERTLDQXKJGID.Clear();
                this.waypoint_death_list.Items.Clear();
            }
            else if (this.death_respawn_2_cbx.IsChecked.Value)
            {
                SLKKBFFDAKRGRBJQZVKHFF.HTOJOTHUVZFFJTDSCYZVU.Clear();
                this.waypoint_death_second_list.Items.Clear();
            }
        }

        private void PPMPDZPRFJHBFIZFHVUVTK(object sender, RoutedEventArgs e)
        {
            if (this.add_selling_btn.Content.ToString() == "Add")
            {
                this.add_selling_btn.Content = "Stop";
                this.LCLSCYCFMZUYSUSXLLCHWK.Start();
            }
            else
            {
                this.add_selling_btn.Content = "Add";
                this.LCLSCYCFMZUYSUSXLLCHWK.Stop();
            }
        }

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    ((UKSPQEFKGYNMSMONBZQOGI) target).Closing += new CancelEventHandler(this.XSQMBNMGFIFJQITQBIFYZS);
                    return;

                case 2:
                    ((System.Windows.Controls.MenuItem) target).Click += new RoutedEventHandler(this.GFQXDTDILUWBVMVMWDLFNY);
                    return;

                case 3:
                    ((System.Windows.Controls.MenuItem) target).Click += new RoutedEventHandler(this.NDCQVGEIDMHNDJGQPDSICR);
                    return;

                case 4:
                    this.waypoint_normal_list = (System.Windows.Controls.ListBox) target;
                    return;

                case 5:
                    this.add_normal_btn = (System.Windows.Controls.Button) target;
                    this.add_normal_btn.Click += new RoutedEventHandler(this.VFAECTPOANVJGXCMQSIUHR);
                    return;

                case 6:
                    this.delete_normal_btn = (System.Windows.Controls.Button) target;
                    this.delete_normal_btn.Click += new RoutedEventHandler(this.VEWQYDFEHEWZMQAZBXJYUP);
                    return;

                case 7:
                    this.death_spots_loading = (System.Windows.Controls.Menu) target;
                    return;

                case 8:
                    ((System.Windows.Controls.MenuItem) target).Click += new RoutedEventHandler(this.KXBIBDJKUWEDWPPUJDARKB);
                    return;

                case 9:
                    ((System.Windows.Controls.MenuItem) target).Click += new RoutedEventHandler(this.IRMVFNJZDZKIIFKLCBGMJH);
                    return;

                case 10:
                    this.waypoint_death_list = (System.Windows.Controls.ListBox) target;
                    return;

                case 11:
                    this.waypoint_death_second_list = (System.Windows.Controls.ListBox) target;
                    return;

                case 12:
                    this.add_death_btn = (System.Windows.Controls.Button) target;
                    this.add_death_btn.Click += new RoutedEventHandler(this.YZBJZBZZIVYVIZMUZRIDSB);
                    return;

                case 13:
                    this.delete_death_btn = (System.Windows.Controls.Button) target;
                    this.delete_death_btn.Click += new RoutedEventHandler(this.OZMNYHNRZMDFTNOVGMSAGM);
                    return;

                case 14:
                    this.death_respawn_1_cbx = (System.Windows.Controls.CheckBox) target;
                    this.death_respawn_1_cbx.Checked += new RoutedEventHandler(this.AWLQFXMJPNXSNCFVSFNFBH);
                    return;

                case 15:
                    this.death_respawn_2_cbx = (System.Windows.Controls.CheckBox) target;
                    this.death_respawn_2_cbx.Checked += new RoutedEventHandler(this.JBNRDIFFYGAJZVYZEANXGE);
                    return;

                case 0x10:
                    ((System.Windows.Controls.MenuItem) target).Click += new RoutedEventHandler(this.CXMMZEFBXHBCYMRFVANHVG);
                    return;

                case 0x11:
                    ((System.Windows.Controls.MenuItem) target).Click += new RoutedEventHandler(this.BPGFSSBIVDBEZRBLRIWYRW);
                    return;

                case 0x12:
                    this.waypoint_selling_list = (System.Windows.Controls.ListBox) target;
                    return;

                case 0x13:
                    this.add_selling_btn = (System.Windows.Controls.Button) target;
                    this.add_selling_btn.Click += new RoutedEventHandler(this.PPMPDZPRFJHBFIZFHVUVTK);
                    return;

                case 20:
                    this.delete_selling_btn = (System.Windows.Controls.Button) target;
                    this.delete_selling_btn.Click += new RoutedEventHandler(this.HHBRTGSENTECUMESLRASDI);
                    return;

                case 0x15:
                    this.save_btn = (System.Windows.Controls.Button) target;
                    this.save_btn.Click += new RoutedEventHandler(this.KVNBCRLQQAXUKJXMPMUXOU);
                    return;
            }
            this.NWLUATZPJLQLBXYIDKBFGB = true;
        }

        private void VEWQYDFEHEWZMQAZBXJYUP(object sender, RoutedEventArgs e)
        {
            SLKKBFFDAKRGRBJQZVKHFF.TZQHCKVNHRYPODOQAZKFKD.Clear();
            this.waypoint_normal_list.Items.Clear();
        }

        private void VFAECTPOANVJGXCMQSIUHR(object sender, RoutedEventArgs e)
        {
            if (this.add_normal_btn.Content.ToString() == "Add")
            {
                this.add_normal_btn.Content = "Stop";
                this.EQGAYWNCTPPSOAVONCKLVD.Start();
            }
            else
            {
                this.add_normal_btn.Content = "Add";
                this.EQGAYWNCTPPSOAVONCKLVD.Stop();
            }
        }

        private void WEXWTSIAGKEZOFZMPAFTD(object sender, EventArgs e)
        {
            SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR.Clear();
            SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY item = new SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY {
                AQICOOHQONIPEAIZQBONX = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(),
                ODYHEMSITJPFSFDDEEYCXM = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related()
            };
            string str = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { item.AQICOOHQONIPEAIZQBONX });
            string newItem = string.Format(CultureInfo.InvariantCulture, "{0:f2}", new object[] { item.ODYHEMSITJPFSFDDEEYCXM }) + " | " + str;
            SLKKBFFDAKRGRBJQZVKHFF.TZQHCKVNHRYPODOQAZKFKD.Add(item);
            this.waypoint_normal_list.Items.Add(newItem);
        }

        private void XSQMBNMGFIFJQITQBIFYZS(object sender, CancelEventArgs e)
        {
            CSHMQQCTTBQOIWJWZUILYT = false;
        }

        private void YZBJZBZZIVYVIZMUZRIDSB(object sender, RoutedEventArgs e)
        {
            if (this.add_death_btn.Content.ToString() == "Add")
            {
                this.add_death_btn.Content = "Stop";
                this.ICOMXKOFJWXZMNEJSKWZYB.Start();
            }
            else
            {
                this.add_death_btn.Content = "Add";
                this.ICOMXKOFJWXZMNEJSKWZYB.Stop();
            }
        }
    }
}

