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

    public class TWKLKVYOLHCNMSHTXVYSGO : Elysium.Controls.Window, IComponentConnector
    {
        internal TextBox health_over_tbx;
        internal TextBox health_under_tbx;
        private DispatcherTimer KEIRIQCDMBWWANLPKLRIZV = new DispatcherTimer();
        private bool NQTIQVUWWWZVWSKLBFMBNY;
        private bool NWLUATZPJLQLBXYIDKBFGB;
        public static bool QOTQSZQIZDELSOLYIJAMRZ;
        internal TextBox repeat_skill_tbx;
        internal TextBox shield_over_tbx;
        internal TextBox shield_under_tbx;
        internal CheckBox skill_charge;
        internal CheckBox skill_interrupt_cbx;
        internal TextBox target_health_over_tbx;
        internal TextBox target_health_under_tbx;
        internal TextBox target_shield_over_tbx;
        internal TextBox target_shield_under_tbx;
        internal CheckBox use_infight_cbx;
        public static int VZENROJZRTEWHHKSIDWPW;

        public TWKLKVYOLHCNMSHTXVYSGO()
        {
            this.InitializeComponent();
            this.KEIRIQCDMBWWANLPKLRIZV.Interval = new TimeSpan(0, 0, 0, 0, 1);
            this.KEIRIQCDMBWWANLPKLRIZV.Tick += new EventHandler(this.RPYDAYCXIJZDZQOHTANYPB);
            this.KEIRIQCDMBWWANLPKLRIZV.Start();
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this.NWLUATZPJLQLBXYIDKBFGB)
            {
                this.NWLUATZPJLQLBXYIDKBFGB = true;
                Uri resourceLocator = new Uri("/StarSpot;component/skillsmorewindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        public void JVOFNWTPNXUEKMUUETGARD()
        {
            if (VZENROJZRTEWHHKSIDWPW == -1)
            {
                this.health_over_tbx.Text = Settings.Default.skill_r_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.skill_r_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.skill_r_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.skill_r_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.skill_r_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.skill_r_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.skill_r_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.skill_r_target_shield_cdt.ToString();
                this.skill_charge.IsChecked = new bool?(Settings.Default.skill_2_double_click);
            }
            if (VZENROJZRTEWHHKSIDWPW == 0)
            {
                this.health_over_tbx.Text = Settings.Default.skill_1_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.skill_1_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.skill_1_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.skill_1_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.skill_1_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.skill_1_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.skill_1_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.skill_1_target_shield_cdt.ToString();
                this.skill_charge.IsChecked = new bool?(Settings.Default.skill_2_double_click);
                this.repeat_skill_tbx.Text = Settings.Default.skill_1_repeat_cdt.ToString();
                this.skill_interrupt_cbx.IsChecked = new bool?(Settings.Default.skill_1_interrupt_enabled);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 1)
            {
                this.health_over_tbx.Text = Settings.Default.skill_2_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.skill_2_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.skill_2_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.skill_2_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.skill_2_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.skill_2_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.skill_2_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.skill_2_target_shield_cdt.ToString();
                this.skill_charge.IsChecked = new bool?(Settings.Default.skill_3_double_click);
                this.repeat_skill_tbx.Text = Settings.Default.skill_2_repeat_cdt.ToString();
                this.skill_interrupt_cbx.IsChecked = new bool?(Settings.Default.skill_2_interrupt_enabled);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 2)
            {
                this.health_over_tbx.Text = Settings.Default.skill_3_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.skill_3_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.skill_3_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.skill_3_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.skill_3_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.skill_3_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.skill_3_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.skill_3_target_shield_cdt.ToString();
                this.skill_charge.IsChecked = new bool?(Settings.Default.skill_4_double_click);
                this.repeat_skill_tbx.Text = Settings.Default.skill_3_repeat_cdt.ToString();
                this.skill_interrupt_cbx.IsChecked = new bool?(Settings.Default.skill_3_interrupt_enabled);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 3)
            {
                this.health_over_tbx.Text = Settings.Default.skill_4_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.skill_4_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.skill_4_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.skill_4_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.skill_4_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.skill_4_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.skill_4_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.skill_4_target_shield_cdt.ToString();
                this.skill_charge.IsChecked = new bool?(Settings.Default.skill_5_double_click);
                this.repeat_skill_tbx.Text = Settings.Default.skill_4_repeat_cdt.ToString();
                this.skill_interrupt_cbx.IsChecked = new bool?(Settings.Default.skill_4_interrupt_enabled);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 4)
            {
                this.health_over_tbx.Text = Settings.Default.skill_5_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.skill_5_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.skill_5_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.skill_5_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.skill_5_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.skill_5_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.skill_5_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.skill_5_target_shield_cdt.ToString();
                this.skill_charge.IsChecked = new bool?(Settings.Default.skill_6_double_click);
                this.repeat_skill_tbx.Text = Settings.Default.skill_5_repeat_cdt.ToString();
                this.skill_interrupt_cbx.IsChecked = new bool?(Settings.Default.skill_5_interrupt_enabled);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 5)
            {
                this.health_over_tbx.Text = Settings.Default.skill_6_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.skill_6_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.skill_6_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.skill_6_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.skill_6_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.skill_6_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.skill_6_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.skill_6_target_shield_cdt.ToString();
                this.skill_charge.IsChecked = new bool?(Settings.Default.skill_7_double_click);
                this.repeat_skill_tbx.Text = Settings.Default.skill_6_repeat_cdt.ToString();
                this.skill_interrupt_cbx.IsChecked = new bool?(Settings.Default.skill_6_interrupt_enabled);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 6)
            {
                this.health_over_tbx.Text = Settings.Default.skill_7_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.skill_7_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.skill_7_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.skill_7_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.skill_7_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.skill_7_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.skill_7_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.skill_7_target_shield_cdt.ToString();
                this.skill_charge.IsChecked = new bool?(Settings.Default.skill_8_double_click);
                this.repeat_skill_tbx.Text = Settings.Default.skill_7_repeat_cdt.ToString();
                this.skill_interrupt_cbx.IsChecked = new bool?(Settings.Default.skill_7_interrupt_enabled);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 7)
            {
                this.health_over_tbx.Text = Settings.Default.skill_8_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.skill_8_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.skill_8_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.skill_8_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.skill_8_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.skill_8_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.skill_8_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.skill_8_target_shield_cdt.ToString();
                this.skill_charge.IsChecked = new bool?(Settings.Default.skill_9_double_click);
                this.repeat_skill_tbx.Text = Settings.Default.skill_8_repeat_cdt.ToString();
                this.skill_interrupt_cbx.IsChecked = new bool?(Settings.Default.skill_8_interrupt_enabled);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 8)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_1_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_1_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_1_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_1_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_1_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_1_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_1_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_1_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_1_infight);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 9)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_2_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_2_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_2_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_2_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_2_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_2_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_2_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_2_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_2_infight);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 10)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_3_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_3_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_3_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_3_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_3_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_3_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_3_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_3_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_3_infight);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 11)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_4_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_4_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_4_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_4_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_4_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_4_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_4_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_4_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_4_infight);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 12)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_5_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_5_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_5_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_5_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_5_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_5_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_5_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_5_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_5_infight);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 13)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_6_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_6_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_6_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_6_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_6_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_6_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_6_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_6_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_6_infight);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 14)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_7_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_7_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_7_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_7_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_7_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_7_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_7_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_7_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_7_infight);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 15)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_8_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_8_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_8_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_8_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_8_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_8_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_8_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_8_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_8_infight);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 0x10)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_9_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_9_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_9_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_9_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_9_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_9_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_9_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_9_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_9_infight);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 0x11)
            {
                this.health_over_tbx.Text = Settings.Default.key_using_10_health_over_cdt.ToString();
                this.shield_over_tbx.Text = Settings.Default.key_using_10_shield_over_cdt.ToString();
                this.target_health_over_tbx.Text = Settings.Default.key_using_10_target_health_over_cdt.ToString();
                this.target_shield_over_tbx.Text = Settings.Default.key_using_10_target_shield_over_cdt.ToString();
                this.health_under_tbx.Text = Settings.Default.key_using_10_health_cdt.ToString();
                this.shield_under_tbx.Text = Settings.Default.key_using_10_shield_cdt.ToString();
                this.target_health_under_tbx.Text = Settings.Default.key_using_10_target_health_cdt.ToString();
                this.target_shield_under_tbx.Text = Settings.Default.key_using_10_target_shield_cdt.ToString();
                this.use_infight_cbx.IsChecked = new bool?(Settings.Default.key_using_10_infight);
            }
        }

        private void RPYDAYCXIJZDZQOHTANYPB(object sender, EventArgs e)
        {
            while (!this.NQTIQVUWWWZVWSKLBFMBNY)
            {
                this.JVOFNWTPNXUEKMUUETGARD();
                this.NQTIQVUWWWZVWSKLBFMBNY = true;
            }
            if (VZENROJZRTEWHHKSIDWPW < 8)
            {
                if (VZENROJZRTEWHHKSIDWPW != -1)
                {
                    this.skill_charge.Visibility = Visibility.Visible;
                    this.skill_interrupt_cbx.Visibility = Visibility.Visible;
                    this.repeat_skill_tbx.IsEnabled = true;
                }
                else
                {
                    this.skill_charge.Visibility = Visibility.Collapsed;
                    this.skill_interrupt_cbx.Visibility = Visibility.Collapsed;
                    this.repeat_skill_tbx.IsEnabled = false;
                }
                this.use_infight_cbx.Visibility = Visibility.Collapsed;
            }
            else
            {
                this.skill_charge.Visibility = Visibility.Collapsed;
                this.use_infight_cbx.Visibility = Visibility.Visible;
            }
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    ((TWKLKVYOLHCNMSHTXVYSGO) target).Closing += new CancelEventHandler(this.XSQMBNMGFIFJQITQBIFYZS);
                    return;

                case 2:
                    this.use_infight_cbx = (CheckBox) target;
                    return;

                case 3:
                    this.skill_charge = (CheckBox) target;
                    return;

                case 4:
                    this.health_under_tbx = (TextBox) target;
                    return;

                case 5:
                    this.shield_under_tbx = (TextBox) target;
                    return;

                case 6:
                    this.target_health_under_tbx = (TextBox) target;
                    return;

                case 7:
                    this.target_shield_under_tbx = (TextBox) target;
                    return;

                case 8:
                    this.health_over_tbx = (TextBox) target;
                    return;

                case 9:
                    this.shield_over_tbx = (TextBox) target;
                    return;

                case 10:
                    this.target_health_over_tbx = (TextBox) target;
                    return;

                case 11:
                    this.target_shield_over_tbx = (TextBox) target;
                    return;

                case 12:
                    this.skill_interrupt_cbx = (CheckBox) target;
                    return;

                case 13:
                    this.repeat_skill_tbx = (TextBox) target;
                    return;
            }
            this.NWLUATZPJLQLBXYIDKBFGB = true;
        }

        private void XSQMBNMGFIFJQITQBIFYZS(object sender, CancelEventArgs e)
        {
            if (VZENROJZRTEWHHKSIDWPW == -1)
            {
                Settings.Default.skill_r_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.skill_r_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.skill_r_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.skill_r_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.skill_r_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.skill_r_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.skill_r_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.skill_r_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
            }
            else if (VZENROJZRTEWHHKSIDWPW == 0)
            {
                Settings.Default.skill_1_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.skill_1_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.skill_1_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.skill_1_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.skill_1_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.skill_1_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.skill_1_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.skill_1_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.skill_2_double_click = this.skill_charge.IsChecked.Value;
                Settings.Default.skill_1_repeat_cdt = Convert.ToInt32(this.repeat_skill_tbx.Text);
                Settings.Default.skill_1_interrupt_enabled = this.skill_interrupt_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 1)
            {
                Settings.Default.skill_2_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.skill_2_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.skill_2_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.skill_2_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.skill_2_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.skill_2_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.skill_2_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.skill_2_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.skill_3_double_click = this.skill_charge.IsChecked.Value;
                Settings.Default.skill_2_repeat_cdt = Convert.ToInt32(this.repeat_skill_tbx.Text);
                Settings.Default.skill_2_interrupt_enabled = this.skill_interrupt_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 2)
            {
                Settings.Default.skill_3_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.skill_3_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.skill_3_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.skill_3_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.skill_3_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.skill_3_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.skill_3_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.skill_3_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.skill_4_double_click = this.skill_charge.IsChecked.Value;
                Settings.Default.skill_3_repeat_cdt = Convert.ToInt32(this.repeat_skill_tbx.Text);
                Settings.Default.skill_3_interrupt_enabled = this.skill_interrupt_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 3)
            {
                Settings.Default.skill_4_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.skill_4_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.skill_4_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.skill_4_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.skill_4_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.skill_4_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.skill_4_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.skill_4_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.skill_5_double_click = this.skill_charge.IsChecked.Value;
                Settings.Default.skill_4_repeat_cdt = Convert.ToInt32(this.repeat_skill_tbx.Text);
                Settings.Default.skill_4_interrupt_enabled = this.skill_interrupt_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 4)
            {
                Settings.Default.skill_5_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.skill_5_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.skill_5_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.skill_5_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.skill_5_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.skill_5_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.skill_5_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.skill_5_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.skill_6_double_click = this.skill_charge.IsChecked.Value;
                Settings.Default.skill_5_repeat_cdt = Convert.ToInt32(this.repeat_skill_tbx.Text);
                Settings.Default.skill_5_interrupt_enabled = this.skill_interrupt_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 5)
            {
                Settings.Default.skill_6_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.skill_6_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.skill_6_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.skill_6_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.skill_6_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.skill_6_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.skill_6_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.skill_6_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.skill_7_double_click = this.skill_charge.IsChecked.Value;
                Settings.Default.skill_6_repeat_cdt = Convert.ToInt32(this.repeat_skill_tbx.Text);
                Settings.Default.skill_6_interrupt_enabled = this.skill_interrupt_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 6)
            {
                Settings.Default.skill_7_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.skill_7_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.skill_7_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.skill_7_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.skill_7_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.skill_7_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.skill_7_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.skill_7_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.skill_8_double_click = this.skill_charge.IsChecked.Value;
                Settings.Default.skill_7_repeat_cdt = Convert.ToInt32(this.repeat_skill_tbx.Text);
                Settings.Default.skill_7_interrupt_enabled = this.skill_interrupt_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 7)
            {
                Settings.Default.skill_8_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.skill_8_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.skill_8_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.skill_8_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.skill_8_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.skill_8_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.skill_8_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.skill_8_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.skill_9_double_click = this.skill_charge.IsChecked.Value;
                Settings.Default.skill_8_repeat_cdt = Convert.ToInt32(this.repeat_skill_tbx.Text);
                Settings.Default.skill_8_interrupt_enabled = this.skill_interrupt_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 8)
            {
                Settings.Default.key_using_1_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_1_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_1_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_1_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_1_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_1_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_1_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_1_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_1_infight = this.use_infight_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 9)
            {
                Settings.Default.key_using_2_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_2_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_2_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_2_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_2_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_2_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_2_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_2_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_2_infight = this.use_infight_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 10)
            {
                Settings.Default.key_using_3_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_3_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_3_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_3_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_3_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_3_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_3_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_3_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_3_infight = this.use_infight_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 11)
            {
                Settings.Default.key_using_4_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_4_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_4_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_4_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_4_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_4_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_4_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_4_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_4_infight = this.use_infight_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 12)
            {
                Settings.Default.key_using_5_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_5_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_5_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_5_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_5_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_5_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_5_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_5_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_5_infight = this.use_infight_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 13)
            {
                Settings.Default.key_using_6_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_6_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_6_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_6_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_6_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_6_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_6_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_6_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_6_infight = this.use_infight_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 14)
            {
                Settings.Default.key_using_7_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_7_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_7_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_7_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_7_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_7_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_7_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_7_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_7_infight = this.use_infight_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 15)
            {
                Settings.Default.key_using_8_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_8_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_8_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_8_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_8_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_8_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_8_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_8_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_8_infight = this.use_infight_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 0x10)
            {
                Settings.Default.key_using_9_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_9_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_9_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_9_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_9_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_9_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_9_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_9_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_9_infight = this.use_infight_cbx.IsChecked.Value;
            }
            else if (VZENROJZRTEWHHKSIDWPW == 0x11)
            {
                Settings.Default.key_using_10_health_over_cdt = Convert.ToInt32(this.health_over_tbx.Text);
                Settings.Default.key_using_10_shield_over_cdt = Convert.ToInt32(this.shield_over_tbx.Text);
                Settings.Default.key_using_10_target_health_over_cdt = Convert.ToInt32(this.target_health_over_tbx.Text);
                Settings.Default.key_using_10_target_shield_over_cdt = Convert.ToInt32(this.target_shield_over_tbx.Text);
                Settings.Default.key_using_10_health_cdt = Convert.ToInt32(this.health_under_tbx.Text);
                Settings.Default.key_using_10_shield_cdt = Convert.ToInt32(this.shield_under_tbx.Text);
                Settings.Default.key_using_10_target_health_cdt = Convert.ToInt32(this.target_health_under_tbx.Text);
                Settings.Default.key_using_10_target_shield_cdt = Convert.ToInt32(this.target_shield_under_tbx.Text);
                Settings.Default.key_using_10_infight = this.use_infight_cbx.IsChecked.Value;
            }
            QOTQSZQIZDELSOLYIJAMRZ = false;
            this.NQTIQVUWWWZVWSKLBFMBNY = false;
        }
    }
}

