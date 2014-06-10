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

    public class CWPEQIBKIOHLDJXIBWOZTX : Elysium.Controls.Window, IComponentConnector
    {
        internal Button demo_btn;
        internal TextBox key_lbl;
        private bool NWLUATZPJLQLBXYIDKBFGB;
        internal Button validate_btn;

        public CWPEQIBKIOHLDJXIBWOZTX()
        {
            this.InitializeComponent();
            this.key_lbl.Text = Settings.Default.serial_key;
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this.NWLUATZPJLQLBXYIDKBFGB)
            {
                this.NWLUATZPJLQLBXYIDKBFGB = true;
                Uri resourceLocator = new Uri("/StarSpot;component/enterkey.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        private void KUIQTULMICEJLHTCCCOEQJ(object sender, RoutedEventArgs e)
        {
            Settings.Default.serial_key = "Demo";
            Settings.Default.Save();
            MessageBox.Show("Please restart StarSpot to activate the demo.", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            Process.GetCurrentProcess().Kill();
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.key_lbl = (TextBox) target;
                    return;

                case 2:
                    this.validate_btn = (Button) target;
                    this.validate_btn.Click += new RoutedEventHandler(this.VOATXOELHIBRZIEDSXICFT);
                    return;

                case 3:
                    this.demo_btn = (Button) target;
                    this.demo_btn.Click += new RoutedEventHandler(this.KUIQTULMICEJLHTCCCOEQJ);
                    return;
            }
            this.NWLUATZPJLQLBXYIDKBFGB = true;
        }

        private void VOATXOELHIBRZIEDSXICFT(object sender, RoutedEventArgs e)
        {
            if (this.key_lbl.Text != "")
            {
                Settings.Default.serial_key = this.key_lbl.Text;
                Settings.Default.Save();
                MessageBox.Show("Please restart StarSpot to validate the key.", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                MessageBox.Show("Please enter a key.", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}

