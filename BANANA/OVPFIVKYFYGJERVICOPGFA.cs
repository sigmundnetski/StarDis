namespace BANANA
{
    using Elysium.Controls;
    using SKGL;
    using StarSpot.Properties;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;
    using System.Windows.Media;
    using System.Windows.Threading;

    public class OVPFIVKYFYGJERVICOPGFA : Elysium.Controls.Window, IComponentConnector
    {
        private Generate EVUPDFEOOWADEPSFPIGLBI = new Generate();
        private BotMain FXETFZVNARHRNVMVIHHHTO = new BotMain();
        public static string KEIWIGGWHXOLPVMYNVLXKI;
        internal Button key_btn;
        internal Button login_btn;
        internal Label machine_id_lbl;
        private SGCDBRJMFPCMNUOSSHAQYE MDEMLFCLHAJXIEPJAANIVE = new SGCDBRJMFPCMNUOSSHAQYE();
        private bool NWLUATZPJLQLBXYIDKBFGB;
        internal Label premium_lbl;
        private DispatcherTimer QASVYDVQGMOFSFBRZGMZMT = new DispatcherTimer();
        private int YDDIEBLCCIVTLCBEJRCJDI;

        public OVPFIVKYFYGJERVICOPGFA()
        {
            this.InitializeComponent();
            this.MDEMLFCLHAJXIEPJAANIVE.ILSTOQQUTSSSBNZGVJSBND();
            this.machine_id_lbl.Content = Convert.ToString(this.EVUPDFEOOWADEPSFPIGLBI.MachineCode);
            this.YDDIEBLCCIVTLCBEJRCJDI = this.EVUPDFEOOWADEPSFPIGLBI.MachineCode;
            this.NWANLUUMPQRBNTIYJRFXOJ();
            this.QASVYDVQGMOFSFBRZGMZMT.Interval = new TimeSpan(0, 20, 0);
            this.QASVYDVQGMOFSFBRZGMZMT.Tick += new EventHandler(this.XUCQIGRISDRXMMIPURFRM);
        }

        private void CAHKWVEYWQCJXMOMPUYJCU(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.serial_key == "")
            {
                new CWPEQIBKIOHLDJXIBWOZTX().Show();
            }
            else
            {
                this.Visibility = Visibility.Collapsed;
                if (this.premium_lbl.Content == "Invalid")
                {
                    MessageBox.Show("You are using the demo version which works 20 minutes.", "Info", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    KEIWIGGWHXOLPVMYNVLXKI = "Invalid";
                    this.QASVYDVQGMOFSFBRZGMZMT.Start();
                }
                this.FXETFZVNARHRNVMVIHHHTO.Show();
            }
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this.NWLUATZPJLQLBXYIDKBFGB)
            {
                this.NWLUATZPJLQLBXYIDKBFGB = true;
                Uri resourceLocator = new Uri("/StarSpot;component/login.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        private void NWANLUUMPQRBNTIYJRFXOJ()
        {
            try
            {
                string str2 = new WebClient().DownloadString("http://star.gplays.co/licence_check/call.php?key=" + Settings.Default.serial_key + "&machine=" + this.YDDIEBLCCIVTLCBEJRCJDI.ToString()).ToLower();
                if (str2 != null)
                {
                    if (!(str2 == "valid"))
                    {
                        if (str2 == "invalid")
                        {
                            this.premium_lbl.Content = "Invalid";
                            KEIWIGGWHXOLPVMYNVLXKI = "Invalid";
                        }
                    }
                    else
                    {
                        this.premium_lbl.Content = "Valid";
                        this.premium_lbl.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                }
            }
            catch
            {
                this.premium_lbl.Content = "Invalid - Connection Error";
            }
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    ((OVPFIVKYFYGJERVICOPGFA) target).Closing += new CancelEventHandler(this.XSQMBNMGFIFJQITQBIFYZS);
                    return;

                case 2:
                    this.login_btn = (Button) target;
                    this.login_btn.Click += new RoutedEventHandler(this.CAHKWVEYWQCJXMOMPUYJCU);
                    return;

                case 3:
                    this.premium_lbl = (Label) target;
                    return;

                case 4:
                    this.machine_id_lbl = (Label) target;
                    return;

                case 5:
                    this.key_btn = (Button) target;
                    this.key_btn.Click += new RoutedEventHandler(this.WRNQIXWHXWRHSBBXMQLPZ);
                    return;
            }
            this.NWLUATZPJLQLBXYIDKBFGB = true;
        }

        private void WRNQIXWHXWRHSBBXMQLPZ(object sender, RoutedEventArgs e)
        {
            new CWPEQIBKIOHLDJXIBWOZTX().Show();
        }

        private void XSQMBNMGFIFJQITQBIFYZS(object sender, CancelEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void XUCQIGRISDRXMMIPURFRM(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}

