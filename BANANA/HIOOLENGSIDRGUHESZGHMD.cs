namespace BANANA
{
    using Elysium.Controls;
    using StarSpot.Properties;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;
    using System.Windows.Threading;

    public class BotMain : Elysium.Controls.Window, IComponentConnector
    {
        private int[] BEBUULFCUIBDSWAMOKEREV = new int[10];
        private Memory BVMCVTHRWWAXBWQASWNEFN = new Memory();
        internal Elysium.Controls.ProgressBar character_health_pgb;
        internal System.Windows.Controls.ProgressBar character_health_pgbx;
        internal Elysium.Controls.ProgressBar character_shield_pgb;
        internal System.Windows.Controls.ProgressBar character_shield_pgbx;
        internal ComboBox charactername_tbx;
        internal ComboBox client_version_tbx;
        private IntPtr[] DRQABBHOVOIJNORUSCZMKY = new IntPtr[10];
        public static bool DRXRHEKXFLYMYDNVRSXPZM = false;
        private PHATKIWNEJAHCPLGWTOZCA EMGADYOHEYMHGXCKXWUKUB = new PHATKIWNEJAHCPLGWTOZCA();
        private JUOKUMIRAYZBFSPPNVCVOW GCXJFGOTOKVILEMJKESXEH = new JUOKUMIRAYZBFSPPNVCVOW();
        private string[] GVYXUBEPDFRINQRMFGHDRL = new string[10];
        private UNKNOWN_maybe_LocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new UNKNOWN_maybe_LocalPlayer();
        public static Process HTVBRHTRKVJRLZGENLYQYE = Process.GetCurrentProcess();
        private DispatcherTimer HURNTHXHJECPHBQARLPUOE = new DispatcherTimer();
        public static Process[] JPBXUOGPDEICSURVPBDBLH = Process.GetProcessesByName("WildStar32");
        private string KFVMPEWTORNDQNKCCCUZFZ;
        private bool KTWBFUTDKQGSOITZBOFNJK;
        internal TextBox log_tbx;
        public static uint LVJMYDBFMFJXQAXRGDRTIO;
        private DispatcherTimer MXHABNXVFBMWLODRQFBVJN = new DispatcherTimer();
        private Actor NEEPXQIUMRXFHJVSPVMGH = new Actor();
        private bool NWLUATZPJLQLBXYIDKBFGB;
        internal Button Options_btn;
        private LZSIIQDBXDTGHSONUMUKMH QGDRHAUKWYSYXQXVGRCHRY = new LZSIIQDBXDTGHSONUMUKMH();
        private DispatcherTimer SHGLALOSSNOBTYALWRDBAP = new DispatcherTimer();
        internal Button spots_btn;
        internal Button start_btn;
        private KMOSFDLBVXXDWCUTSQZTMN TDQFKKBLFSGUBGJJWAKCS = new KMOSFDLBVXXDWCUTSQZTMN();
        internal Label test_lbl;
        private DEFMKWCASKDJTSTMDRZXZB THSTJQTWXHJQYVPXPEFDHR = new DEFMKWCASKDJTSTMDRZXZB();
        public static IntPtr TSWEEVFKDSMQSUAPCQQPUP;
        private BackgroundWorker UCBVJVGXAORHXVBWENTZNX = new BackgroundWorker();
        private DispatcherTimer UREKOLUKZRPCWCYMUJEAEF = new DispatcherTimer();
        private LNPAERUPWRFPRBNXPEJUC VAKRHFSDXJMLLBSTZDQEBX = new LNPAERUPWRFPRBNXPEJUC();
        public static Process[] VYXJVVKSADKODTGFNNBQJM = Process.GetProcessesByName("WildStar64");
        public static string log_msg;
        public static string WNIGNVYTLOXDHCOZMJCOIG;
        private DispatcherTimer XDHMIMBGARKTTRVGCNGQKH = new DispatcherTimer();
        public static string bits;
        private ActorList actorList = new ActorList();

        public BotMain()
        {
            this.InitializeComponent();
            this.client_version_tbx.Items.Add("x64");
            this.client_version_tbx.Items.Add("x86");
            this.JBHZLIBRWUFVOVEHIUTDMZ();
            this.log_tbx.IsReadOnly = true;
        }

        private void HFDCTHPGWTGACRMQSROJLN(object sender, EventArgs e)
        {
            if (!this.UCBVJVGXAORHXVBWENTZNX.IsBusy)
            {
                this.UCBVJVGXAORHXVBWENTZNX.RunWorkerAsync();
            }
        }

        private void HTETMSRGUDFAGSEOBBQBOA(object sender, EventArgs e)
        {
            if (!this.log_tbx.Text.Contains("The bot stopped (Stop after function)."))
            {
                log_msg = "The bot stopped (Stop after function) after " + Settings.Default.stop_after_min + " min.";
            }
            DRXRHEKXFLYMYDNVRSXPZM = false;
            this.start_btn.Content = "Start";
        }

        private void IMBVXZKHKSQVWSAOGGIEJ(object sender, DoWorkEventArgs e)
        {
            if (DRXRHEKXFLYMYDNVRSXPZM && (Settings.Default.mods == "Grinding"))
            {
                if (!this.KTWBFUTDKQGSOITZBOFNJK)
                {
                    if (Settings.Default.player_detection_radius == 0)
                    {
                        this.THSTJQTWXHJQYVPXPEFDHR.BDYICLRVCROPYECNTKRSDH();
                    }
                    else if (!JUOKUMIRAYZBFSPPNVCVOW.WHWLSCJEYGBHLTTYPFVUTL | (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 1L))
                    {
                        this.THSTJQTWXHJQYVPXPEFDHR.BDYICLRVCROPYECNTKRSDH();
                    }
                }
                if (Settings.Default.random_jumping)
                {
                    this.VAKRHFSDXJMLLBSTZDQEBX.TDZIHHCODZICDXEMBPWPKG();
                }
            }
            else if (DRXRHEKXFLYMYDNVRSXPZM && (Settings.Default.mods == "Combat"))
            {
                this.EMGADYOHEYMHGXCKXWUKUB.QPPYJVFTILCISPPDDXDFXA();
                this.EMGADYOHEYMHGXCKXWUKUB.MAMWQNQIFABHMLRRUKMCA();
            }
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this.NWLUATZPJLQLBXYIDKBFGB)
            {
                this.NWLUATZPJLQLBXYIDKBFGB = true;
                Uri resourceLocator = new Uri("/StarSpot;component/mainwindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        private void JBHZLIBRWUFVOVEHIUTDMZ()
        {
            this.XDHMIMBGARKTTRVGCNGQKH.Tick += new EventHandler(this.YJXEYBBOAWUPWYETSJLDQT);
            this.XDHMIMBGARKTTRVGCNGQKH.Interval = new TimeSpan(0, 0, 0, 0, 100);
            this.HURNTHXHJECPHBQARLPUOE.Tick += new EventHandler(this.HTETMSRGUDFAGSEOBBQBOA);
            this.HURNTHXHJECPHBQARLPUOE.Interval = new TimeSpan(0, 5, 0);
            this.SHGLALOSSNOBTYALWRDBAP.Tick += new EventHandler(this.SMIKKYGLWOPYYXDXCYHMTD);
            this.SHGLALOSSNOBTYALWRDBAP.Interval = new TimeSpan(0, 5, 0);
            this.UREKOLUKZRPCWCYMUJEAEF.Tick += new EventHandler(this.HFDCTHPGWTGACRMQSROJLN);
            this.UREKOLUKZRPCWCYMUJEAEF.Interval = new TimeSpan(0, 0, 0, 0, 100);
            this.UCBVJVGXAORHXVBWENTZNX.DoWork += new DoWorkEventHandler(this.IMBVXZKHKSQVWSAOGGIEJ);
            this.UREKOLUKZRPCWCYMUJEAEF.Start();
            if (OVPFIVKYFYGJERVICOPGFA.KEIWIGGWHXOLPVMYNVLXKI == "Invalid")
            {
                this.MXHABNXVFBMWLODRQFBVJN.Interval = new TimeSpan(0, 0x15, 0);
                this.MXHABNXVFBMWLODRQFBVJN.Tick += new EventHandler(this.NPMNFCOFQZTOPHEJWMZRVY);
                this.MXHABNXVFBMWLODRQFBVJN.Start();
            }
        }

        private void JIDSDWXAZZRHXPNJHFCKUL(object sender, SelectionChangedEventArgs e)
        {
            bits = this.client_version_tbx.SelectedItem.ToString();
            this.KINYLMCYQOZYDWAGUGCLCK();
            this.client_version_tbx.Visibility = Visibility.Collapsed;
        }

        private void KINYLMCYQOZYDWAGUGCLCK()
        {
            if (this.client_version_tbx.SelectedItem != "x64")
            {
                if (this.client_version_tbx.SelectedItem != "x86")
                {
                    return;
                }
                for (int j = 0; j < VYXJVVKSADKODTGFNNBQJM.Length; j++)
                {
                    Memory.QYNUEAWVBSYTIBOIJPMZOG(JPBXUOGPDEICSURVPBDBLH[j].Id);
                    Memory.NUJISHIRHOECKHOTHOYGEQ = JPBXUOGPDEICSURVPBDBLH[j].MainModule.BaseAddress.ToInt32();
                    try
                    {
                        this.KFVMPEWTORNDQNKCCCUZFZ = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_name_related();
                        if ((this.KFVMPEWTORNDQNKCCCUZFZ.Length < 20) && (this.KFVMPEWTORNDQNKCCCUZFZ.Length > 0))
                        {
                            this.GVYXUBEPDFRINQRMFGHDRL[j] = this.KFVMPEWTORNDQNKCCCUZFZ;
                            this.DRQABBHOVOIJNORUSCZMKY[j] = JPBXUOGPDEICSURVPBDBLH[j].MainWindowHandle;
                            this.BEBUULFCUIBDSWAMOKEREV[j] = JPBXUOGPDEICSURVPBDBLH[j].Id;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                int index = 0;
                while (true)
                {
                    if (index >= VYXJVVKSADKODTGFNNBQJM.Length)
                    {
                        break;
                    }
                    Memory.QYNUEAWVBSYTIBOIJPMZOG(VYXJVVKSADKODTGFNNBQJM[index].Id);
                    Memory.PYHKTUBUVKULYYDMTKRMRB = VYXJVVKSADKODTGFNNBQJM[index].MainModule.BaseAddress.ToInt64();
                    try
                    {
                        this.KFVMPEWTORNDQNKCCCUZFZ = this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_name_related();
                        if ((this.KFVMPEWTORNDQNKCCCUZFZ.Length < 20) && (this.KFVMPEWTORNDQNKCCCUZFZ.Length > 0))
                        {
                            this.GVYXUBEPDFRINQRMFGHDRL[index] = this.KFVMPEWTORNDQNKCCCUZFZ;
                            this.DRQABBHOVOIJNORUSCZMKY[index] = VYXJVVKSADKODTGFNNBQJM[index].MainWindowHandle;
                            this.BEBUULFCUIBDSWAMOKEREV[index] = VYXJVVKSADKODTGFNNBQJM[index].Id;
                        }
                    }
                    catch
                    {
                    }
                    index++;
                }
                for (int k = 0; k < this.DRQABBHOVOIJNORUSCZMKY.Length; k++)
                {
                    if (this.GVYXUBEPDFRINQRMFGHDRL[k] != null)
                    {
                        this.charactername_tbx.Items.Add(this.GVYXUBEPDFRINQRMFGHDRL[k]);
                    }
                }
                return;
            }
            for (int i = 0; i < this.DRQABBHOVOIJNORUSCZMKY.Length; i++)
            {
                if (this.GVYXUBEPDFRINQRMFGHDRL[i] != null)
                {
                    this.charactername_tbx.Items.Add(this.GVYXUBEPDFRINQRMFGHDRL[i]);
                }
            }
        }

        public void LSXHKKUIOUPUCNOAYVSPZH()
        {
            try
            {
                SLKKBFFDAKRGRBJQZVKHFF.HVYZELUVDLIWVWHJCMMBA = SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR[SLKKBFFDAKRGRBJQZVKHFF.ZLISEWVYURKJXFHPRKHKMT];
            }
            catch
            {
            }
            try
            {
                SLKKBFFDAKRGRBJQZVKHFF.DCMSTRDUGRYOYMZSFDRSU = SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE[SLKKBFFDAKRGRBJQZVKHFF.KNCIKWEVSMLSIXYJRQASQQ];
            }
            catch
            {
            }
            try
            {
                SLKKBFFDAKRGRBJQZVKHFF.KDMPKSEVQRRXMDWFLEKKKO = SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH[SLKKBFFDAKRGRBJQZVKHFF.XBCQHTMOZWYKVCIDVHXXJL];
            }
            catch
            {
            }
        }

        private void NPMNFCOFQZTOPHEJWMZRVY(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void PPQVRHPCSMQAPRKJMFWUVW(object sender, RoutedEventArgs e)
        {
            if (!UKSPQEFKGYNMSMONBZQOGI.CSHMQQCTTBQOIWJWZUILYT)
            {
                UKSPQEFKGYNMSMONBZQOGI ukspqefkgynmsmonbzqogi = new UKSPQEFKGYNMSMONBZQOGI();
                UKSPQEFKGYNMSMONBZQOGI.CSHMQQCTTBQOIWJWZUILYT = true;
                ukspqefkgynmsmonbzqogi.Show();
            }
        }

        private void RPKSPZFVJEJECGXIKWGZYL(object sender, SelectionChangedEventArgs e)
        {
            if (this.charactername_tbx.SelectedIndex != -1)
            {
                if (this.client_version_tbx.SelectedItem == "x64")
                {
                    Memory.QYNUEAWVBSYTIBOIJPMZOG(VYXJVVKSADKODTGFNNBQJM[this.charactername_tbx.SelectedIndex].Id);
                    Memory.PYHKTUBUVKULYYDMTKRMRB = VYXJVVKSADKODTGFNNBQJM[this.charactername_tbx.SelectedIndex].MainModule.BaseAddress.ToInt64();
                    TSWEEVFKDSMQSUAPCQQPUP = VYXJVVKSADKODTGFNNBQJM[this.charactername_tbx.SelectedIndex].MainWindowHandle;
                }
                else if (this.client_version_tbx.SelectedItem == "x86")
                {
                    Memory.QYNUEAWVBSYTIBOIJPMZOG(JPBXUOGPDEICSURVPBDBLH[this.charactername_tbx.SelectedIndex].Id);
                    Memory.NUJISHIRHOECKHOTHOYGEQ = JPBXUOGPDEICSURVPBDBLH[this.charactername_tbx.SelectedIndex].MainModule.BaseAddress.ToInt32();
                    TSWEEVFKDSMQSUAPCQQPUP = JPBXUOGPDEICSURVPBDBLH[this.charactername_tbx.SelectedIndex].MainWindowHandle;
                }
                this.charactername_tbx.IsEnabled = false;
                this.XDHMIMBGARKTTRVGCNGQKH.Start();
            }
        }

        private void SMIKKYGLWOPYYXDXCYHMTD(object sender, EventArgs e)
        {
            this.KTWBFUTDKQGSOITZBOFNJK = false;
        }

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    ((BotMain) target).Closing += new CancelEventHandler(this.XSQMBNMGFIFJQITQBIFYZS);
                    return;

                case 2:
                    this.character_shield_pgbx = (System.Windows.Controls.ProgressBar) target;
                    return;

                case 3:
                    this.character_health_pgbx = (System.Windows.Controls.ProgressBar) target;
                    return;

                case 4:
                    this.charactername_tbx = (ComboBox) target;
                    this.charactername_tbx.SelectionChanged += new SelectionChangedEventHandler(this.RPKSPZFVJEJECGXIKWGZYL);
                    return;

                case 5:
                    this.test_lbl = (Label) target;
                    return;

                case 6:
                    this.character_health_pgb = (Elysium.Controls.ProgressBar) target;
                    return;

                case 7:
                    this.character_shield_pgb = (Elysium.Controls.ProgressBar) target;
                    return;

                case 8:
                    this.start_btn = (Button) target;
                    this.start_btn.Click += new RoutedEventHandler(this.ZPPGDKYOVNIWSYWRUVORT);
                    return;

                case 9:
                    this.spots_btn = (Button) target;
                    this.spots_btn.Click += new RoutedEventHandler(this.PPQVRHPCSMQAPRKJMFWUVW);
                    return;

                case 10:
                    this.Options_btn = (Button) target;
                    this.Options_btn.Click += new RoutedEventHandler(this.TWWJTKNUJNJMWGDLBNHPFF);
                    return;

                case 11:
                    ((Button) target).Click += new RoutedEventHandler(this.SZIFUSUPOMZZMCUOJALAWU);
                    return;

                case 12:
                    this.log_tbx = (TextBox) target;
                    return;

                case 13:
                    this.client_version_tbx = (ComboBox) target;
                    this.client_version_tbx.SelectionChanged += new SelectionChangedEventHandler(this.JIDSDWXAZZRHXPNJHFCKUL);
                    return;
            }
            this.NWLUATZPJLQLBXYIDKBFGB = true;
        }

        private void SZIFUSUPOMZZMCUOJALAWU(object sender, RoutedEventArgs e)
        {
            if (!this.QGDRHAUKWYSYXQXVGRCHRY.Visible)
            {
                try
                {
                    this.QGDRHAUKWYSYXQXVGRCHRY.Show();
                }
                catch
                {
                }
            }
        }

        private void TWWJTKNUJNJMWGDLBNHPFF(object sender, RoutedEventArgs e)
        {
            if (!FRSKNCKDUTXBQVSAINYDDC.YBSUCJMYSLDAJCBXNWPPZA)
            {
                FRSKNCKDUTXBQVSAINYDDC frsknckdutxbqvsainyddc = new FRSKNCKDUTXBQVSAINYDDC();
                FRSKNCKDUTXBQVSAINYDDC.YBSUCJMYSLDAJCBXNWPPZA = true;
                frsknckdutxbqvsainyddc.Show();
            }
        }

        private void XSQMBNMGFIFJQITQBIFYZS(object sender, CancelEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void YJXEYBBOAWUPWYETSJLDQT(object sender, EventArgs e)
        {
            this.GCXJFGOTOKVILEMJKESXEH.JGFNMNYWCGWHYZKOAKETVN();
            this.NEEPXQIUMRXFHJVSPVMGH.FWOAIGZWASLDSBOJHBQAAM();
            this.NEEPXQIUMRXFHJVSPVMGH.IJBBMMXADCNQFTGDDLSNTV();
            this.ZBKKNPGFBHSAFALMFMFHMS();
            if (!DRXRHEKXFLYMYDNVRSXPZM)
            {
                if (Settings.Default.enable_start_after)
                {
                    this.SHGLALOSSNOBTYALWRDBAP.Stop();
                }
                this.KTWBFUTDKQGSOITZBOFNJK = false;
                if (Settings.Default.enable_stop_after)
                {
                    this.HURNTHXHJECPHBQARLPUOE.Stop();
                }
            }
            if ((Settings.Default.stop_after_min > 0) && (this.HURNTHXHJECPHBQARLPUOE.Interval.Minutes != Settings.Default.stop_after_min))
            {
                this.HURNTHXHJECPHBQARLPUOE.Interval = new TimeSpan(0, Settings.Default.stop_after_min, 0);
            }
            if ((Settings.Default.start_after_min > 0) && (this.SHGLALOSSNOBTYALWRDBAP.Interval.Minutes != Settings.Default.start_after_min))
            {
                this.SHGLALOSSNOBTYALWRDBAP.Interval = new TimeSpan(0, Settings.Default.start_after_min, 0);
            }
        }

        private void ZBKKNPGFBHSAFALMFMFHMS()
        {
            try
            {
                this.character_health_pgb.Value = this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ();
            }
            catch
            {
                this.character_health_pgb.Value = 0.0;
            }
            try
            {
                this.character_shield_pgb.Value = this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB();
            }
            catch
            {
                this.character_shield_pgb.Value = 0.0;
            }
            if (log_msg != "")
            {
                if (this.log_tbx.Text == "")
                {
                    this.log_tbx.Text = this.log_tbx.Text + log_msg;
                }
                else
                {
                    this.log_tbx.Text = this.log_tbx.Text + "\n" + log_msg;
                }
                if (this.log_tbx.LineCount == 100)
                {
                    this.log_tbx.Text.Remove(0, 50);
                }
                log_msg = "";
            }
            if (DRXRHEKXFLYMYDNVRSXPZM)
            {
                this.log_tbx.CaretIndex = this.log_tbx.Text.Length;
                Rect rectFromCharacterIndex = this.log_tbx.GetRectFromCharacterIndex(this.log_tbx.CaretIndex);
                this.log_tbx.ScrollToHorizontalOffset(rectFromCharacterIndex.Right);
                this.log_tbx.ScrollToEnd();
            }
        }

        private void ZPPGDKYOVNIWSYWRUVORT(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.mods == "Grinding")
            {
                if ((SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR.Count == 0) || (this.start_btn.Content != "Start"))
                {
                    if (SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR.Count == 0)
                    {
                        MessageBox.Show("Create more spots!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }
                    else if (this.start_btn.Content != "Start")
                    {
                        DRXRHEKXFLYMYDNVRSXPZM = false;
                        this.start_btn.Content = "Start";
                    }
                }
                else if (Settings.Default.autoselling_enabled && (SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH.Count != 0))
                {
                    DRXRHEKXFLYMYDNVRSXPZM = true;
                    this.LSXHKKUIOUPUCNOAYVSPZH();
                    if (Settings.Default.enable_start_after)
                    {
                        log_msg = "The bot will start in " + Settings.Default.start_after_min.ToString() + " min.";
                        this.SHGLALOSSNOBTYALWRDBAP.Start();
                        this.KTWBFUTDKQGSOITZBOFNJK = true;
                    }
                    if (Settings.Default.enable_stop_after)
                    {
                        this.HURNTHXHJECPHBQARLPUOE.Start();
                    }
                    this.start_btn.Content = "Stop";
                }
                else if (Settings.Default.autoselling_enabled && (SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH.Count == 0))
                {
                    MessageBox.Show("Create more selling spots or disable auto selling!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else if (!Settings.Default.autoselling_enabled)
                {
                    DRXRHEKXFLYMYDNVRSXPZM = true;
                    this.LSXHKKUIOUPUCNOAYVSPZH();
                    if (Settings.Default.enable_start_after)
                    {
                        log_msg = "The bot will start in " + Settings.Default.start_after_min.ToString() + " min.";
                        this.SHGLALOSSNOBTYALWRDBAP.Start();
                        this.KTWBFUTDKQGSOITZBOFNJK = true;
                    }
                    if (Settings.Default.enable_stop_after)
                    {
                        this.HURNTHXHJECPHBQARLPUOE.Start();
                    }
                    this.start_btn.Content = "Stop";
                }
            }
            else if (Settings.Default.mods == "Combat")
            {
                DRXRHEKXFLYMYDNVRSXPZM = true;
                this.LSXHKKUIOUPUCNOAYVSPZH();
                if (Settings.Default.enable_start_after)
                {
                    log_msg = "The bot will start in " + Settings.Default.start_after_min.ToString() + " min.";
                    this.SHGLALOSSNOBTYALWRDBAP.Start();
                    this.KTWBFUTDKQGSOITZBOFNJK = true;
                }
                if (Settings.Default.enable_stop_after)
                {
                    this.HURNTHXHJECPHBQARLPUOE.Start();
                }
                this.start_btn.Content = "Stop";
            }
        }
    }
}

