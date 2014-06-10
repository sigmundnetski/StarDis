namespace BANANA
{
    using Elysium.Controls;
    using StarSpot.Properties;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class FRSKNCKDUTXBQVSAINYDDC : Elysium.Controls.Window, IComponentConnector
    {
        internal Button add_npc_btn;
        internal TextBox attack_range_tbx;
        internal TextBox attack_unstucking_duration_tbx;
        internal TextBox attack_unstucking_tbx;
        internal TextBox auto_selling_duration_tbx;
        internal ListBox blacklist_lbx;
        internal ComboBox bot_1_key_cbx;
        internal ToggleSwitch bot_1_use;
        internal ComboBox bot_2_key_cbx;
        internal ToggleSwitch bot_2_use;
        internal Button delete_npc_btn;
        internal CheckBox enable_autoselling_cbx;
        internal CheckBox enable_defending_after_death;
        internal CheckBox enable_looting_cbx;
        internal CheckBox enable_random_jumping_cbx;
        internal CheckBox enable_start_after_cbx;
        internal CheckBox enable_stop_after_cbx;
        internal CheckBox enable_tabbing_after_death;
        internal CheckBox healing_to_100_cbx;
        internal CheckBox healing_to_100_usekeys_cbx;
        internal TextBox hunting_level_range_tbx;
        internal ComboBox key_using_1_cbx;
        internal TextBox key_using_1_cooldown;
        internal TextBox key_using_1_ct_tbx;
        internal Button key_using_1_more;
        internal ComboBox key_using_10_cbx;
        internal TextBox key_using_10_cooldown;
        internal TextBox key_using_10_ct_tbx;
        internal Button key_using_10_more;
        internal ComboBox key_using_2_cbx;
        internal TextBox key_using_2_cooldown;
        internal TextBox key_using_2_ct_tbx;
        internal Button key_using_2_more;
        internal ComboBox key_using_3_cbx;
        internal TextBox key_using_3_cooldown;
        internal TextBox key_using_3_ct_tbx;
        internal Button key_using_3_more;
        internal ComboBox key_using_4_cbx;
        internal TextBox key_using_4_cooldown;
        internal TextBox key_using_4_ct_tbx;
        internal Button key_using_4_more;
        internal ComboBox key_using_5_cbx;
        internal TextBox key_using_5_cooldown;
        internal TextBox key_using_5_ct_tbx;
        internal Button key_using_5_more;
        internal ComboBox key_using_6_cbx;
        internal TextBox key_using_6_cooldown;
        internal TextBox key_using_6_ct_tbx;
        internal Button key_using_6_more;
        internal ComboBox key_using_7_cbx;
        internal TextBox key_using_7_cooldown;
        internal TextBox key_using_7_ct_tbx;
        internal Button key_using_7_more;
        internal ComboBox key_using_8_cbx;
        internal TextBox key_using_8_cooldown;
        internal TextBox key_using_8_ct_tbx;
        internal Button key_using_8_more;
        internal ComboBox key_using_9_cbx;
        internal TextBox key_using_9_cooldown;
        internal TextBox key_using_9_ct_tbx;
        internal Button key_using_9_more;
        internal ComboBox mods_cbx;
        private bool NWLUATZPJLQLBXYIDKBFGB;
        internal TextBox player_detection_radius_tbx;
        internal TextBox player_detection_stop_tbx;
        internal TextBox random_jumping_timer_tbx;
        internal TextBox run_unstucking_time_tbx;
        internal Button skill_0_more;
        internal Button skill_1_more;
        internal Button skill_2_more;
        internal Button skill_3_more;
        internal Button skill_4_more;
        internal Button skill_5_more;
        internal Button skill_6_more;
        internal Button skill_7_more;
        internal Button skill_8_more;
        internal TextBox skills_1_cooldown_tbx;
        internal ToggleSwitch skills_1_tgw;
        internal TextBox skills_2_charge_tbx;
        internal TextBox skills_2_cooldown_tbx;
        internal ToggleSwitch skills_2_tgw;
        internal TextBox skills_3_charge_tbx;
        internal TextBox skills_3_cooldown_tbx;
        internal ToggleSwitch skills_3_tgw;
        internal TextBox skills_4_charge_tbx;
        internal TextBox skills_4_cooldown_tbx;
        internal ToggleSwitch skills_4_tgw;
        internal TextBox skills_5_charge_tbx;
        internal TextBox skills_5_cooldown_tbx;
        internal ToggleSwitch skills_5_tgw;
        internal TextBox skills_6_charge_tbx;
        internal TextBox skills_6_cooldown_tbx;
        internal ToggleSwitch skills_6_tgw;
        internal TextBox skills_7_charge_tbx;
        internal TextBox skills_7_cooldown_tbx;
        internal ToggleSwitch skills_7_tgw;
        internal TextBox skills_8_charge_tbx;
        internal TextBox skills_8_cooldown_tbx;
        internal ToggleSwitch skills_8_tgw;
        internal TextBox skills_9_charge_tbx;
        internal TextBox skills_9_cooldown_tbx;
        internal ToggleSwitch skills_9_tgw;
        internal TextBox start_after_tbx;
        internal TextBox stop_after_min_tbx;
        private List<string> TOOMVDUDARVUZZVHEVRKGZ = new List<string>();
        public static bool YBSUCJMYSLDAJCBXNWPPZA;

        public FRSKNCKDUTXBQVSAINYDDC()
        {
            this.InitializeComponent();
            this.TOOMVDUDARVUZZVHEVRKGZ = Settings.Default.blacklist_npcs.Split(new char[] { ',' }).ToList<string>();
            for (int i = 0; i < 20; i++)
            {
                if (this.TOOMVDUDARVUZZVHEVRKGZ[i] != "0")
                {
                    this.blacklist_lbx.Items.Add(this.TOOMVDUDARVUZZVHEVRKGZ[i]);
                }
            }
            this.WYJZFNBMIZQZYWQPJRLPF();
            this.JVOFNWTPNXUEKMUUETGARD();
        }

        private void CBMBFNOROENFJCKCXWQHRB(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 4;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private static string CHKSPIRVUXUWPTRIUGHGHR(string[] HQVZAHOVGUCQKATQUKZKHW)
        {
            return string.Join(",", HQVZAHOVGUCQKATQUKZKHW);
        }

        private void DTTAENDOLEGYARGIHYLTRD()
        {
            Settings.Default.skill_1_enabled = this.skills_1_tgw.IsChecked;
            Settings.Default.skill_1_cooldown = Convert.ToInt32(this.skills_1_cooldown_tbx.Text);
            Settings.Default.skill_2_enabled = this.skills_2_tgw.IsChecked;
            Settings.Default.skill_2_cooldown = Convert.ToInt32(this.skills_2_cooldown_tbx.Text);
            Settings.Default.skill_2_charge = Convert.ToInt32(this.skills_2_charge_tbx.Text);
            Settings.Default.skill_3_enabled = this.skills_3_tgw.IsChecked;
            Settings.Default.skill_3_cooldown = Convert.ToInt32(this.skills_3_cooldown_tbx.Text);
            Settings.Default.skill_3_charge = Convert.ToInt32(this.skills_3_charge_tbx.Text);
            Settings.Default.skill_4_enabled = this.skills_4_tgw.IsChecked;
            Settings.Default.skill_4_cooldown = Convert.ToInt32(this.skills_4_cooldown_tbx.Text);
            Settings.Default.skill_4_charge = Convert.ToInt32(this.skills_4_charge_tbx.Text);
            Settings.Default.skill_5_enabled = this.skills_5_tgw.IsChecked;
            Settings.Default.skill_5_cooldown = Convert.ToInt32(this.skills_5_cooldown_tbx.Text);
            Settings.Default.skill_5_charge = Convert.ToInt32(this.skills_5_charge_tbx.Text);
            Settings.Default.skill_6_enabled = this.skills_6_tgw.IsChecked;
            Settings.Default.skill_6_cooldown = Convert.ToInt32(this.skills_6_cooldown_tbx.Text);
            Settings.Default.skill_6_charge = Convert.ToInt32(this.skills_6_charge_tbx.Text);
            Settings.Default.skill_7_enabled = this.skills_7_tgw.IsChecked;
            Settings.Default.skill_7_cooldown = Convert.ToInt32(this.skills_7_cooldown_tbx.Text);
            Settings.Default.skill_7_charge = Convert.ToInt32(this.skills_7_charge_tbx.Text);
            Settings.Default.skill_8_enabled = this.skills_8_tgw.IsChecked;
            Settings.Default.skill_8_cooldown = Convert.ToInt32(this.skills_8_cooldown_tbx.Text);
            Settings.Default.skill_8_charge = Convert.ToInt32(this.skills_8_charge_tbx.Text);
            Settings.Default.skill_9_enabled = this.skills_9_tgw.IsChecked;
            Settings.Default.skill_9_cooldown = Convert.ToInt32(this.skills_9_cooldown_tbx.Text);
            Settings.Default.skill_9_charge = Convert.ToInt32(this.skills_9_charge_tbx.Text);
            Settings.Default.looting_option = this.enable_looting_cbx.IsChecked.Value;
            Settings.Default.random_jumping = this.enable_random_jumping_cbx.IsChecked.Value;
            Settings.Default.random_jumping_timer = Convert.ToInt32(this.random_jumping_timer_tbx.Text);
            Settings.Default.key_using_1_key = this.key_using_1_cbx.Text;
            Settings.Default.key_using_1_cooldown = Convert.ToInt32(this.key_using_1_cooldown.Text);
            Settings.Default.key_using_1_ct = Convert.ToInt32(this.key_using_1_ct_tbx.Text);
            Settings.Default.key_using_2_key = this.key_using_2_cbx.Text;
            Settings.Default.key_using_2_cooldown = Convert.ToInt32(this.key_using_2_cooldown.Text);
            Settings.Default.key_using_2_ct = Convert.ToInt32(this.key_using_2_ct_tbx.Text);
            Settings.Default.key_using_3_key = this.key_using_3_cbx.Text;
            Settings.Default.key_using_3_cooldown = Convert.ToInt32(this.key_using_3_cooldown.Text);
            Settings.Default.key_using_3_ct = Convert.ToInt32(this.key_using_3_ct_tbx.Text);
            Settings.Default.key_using_4_key = this.key_using_4_cbx.Text;
            Settings.Default.key_using_4_cooldown = Convert.ToInt32(this.key_using_4_cooldown.Text);
            Settings.Default.key_using_4_ct = Convert.ToInt32(this.key_using_4_ct_tbx.Text);
            Settings.Default.key_using_5_key = this.key_using_5_cbx.Text;
            Settings.Default.key_using_5_cooldown = Convert.ToInt32(this.key_using_5_cooldown.Text);
            Settings.Default.key_using_5_ct = Convert.ToInt32(this.key_using_5_ct_tbx.Text);
            Settings.Default.key_using_6_key = this.key_using_6_cbx.Text;
            Settings.Default.key_using_6_cooldown = Convert.ToInt32(this.key_using_6_cooldown.Text);
            Settings.Default.key_using_6_ct = Convert.ToInt32(this.key_using_6_ct_tbx.Text);
            Settings.Default.key_using_7_key = this.key_using_7_cbx.Text;
            Settings.Default.key_using_7_cooldown = Convert.ToInt32(this.key_using_7_cooldown.Text);
            Settings.Default.key_using_7_ct = Convert.ToInt32(this.key_using_7_ct_tbx.Text);
            Settings.Default.key_using_8_key = this.key_using_8_cbx.Text;
            Settings.Default.key_using_8_cooldown = Convert.ToInt32(this.key_using_8_cooldown.Text);
            Settings.Default.key_using_8_ct = Convert.ToInt32(this.key_using_8_ct_tbx.Text);
            Settings.Default.key_using_9_key = this.key_using_9_cbx.Text;
            Settings.Default.key_using_9_cooldown = Convert.ToInt32(this.key_using_9_cooldown.Text);
            Settings.Default.key_using_9_ct = Convert.ToInt32(this.key_using_9_ct_tbx.Text);
            Settings.Default.key_using_10_key = this.key_using_10_cbx.Text;
            Settings.Default.key_using_10_cooldown = Convert.ToInt32(this.key_using_10_cooldown.Text);
            Settings.Default.key_using_10_ct = Convert.ToInt32(this.key_using_10_ct_tbx.Text);
            Settings.Default.enable_defending_after_death = this.enable_defending_after_death.IsChecked.Value;
            Settings.Default.enable_tabbing_after_death = this.enable_tabbing_after_death.IsChecked.Value;
            Settings.Default.enable_stop_after = this.enable_stop_after_cbx.IsChecked.Value;
            Settings.Default.stop_after_min = Convert.ToInt32(this.stop_after_min_tbx.Text);
            Settings.Default.enable_start_after = this.enable_start_after_cbx.IsChecked.Value;
            Settings.Default.start_after_min = Convert.ToInt32(this.start_after_tbx.Text);
            if ((this.hunting_level_range_tbx.Text != " ") && (this.hunting_level_range_tbx.Text != ""))
            {
                Settings.Default.level_range = Convert.ToInt32(this.hunting_level_range_tbx.Text);
            }
            Settings.Default.player_detection_min = Convert.ToInt32(this.player_detection_stop_tbx.Text);
            Settings.Default.player_detection_radius = Convert.ToInt32(this.player_detection_radius_tbx.Text);
            Settings.Default.blacklist_npcs = CHKSPIRVUXUWPTRIUGHGHR(this.TOOMVDUDARVUZZVHEVRKGZ.ToArray());
            Settings.Default.bot_1_key = this.bot_1_key_cbx.Text;
            Settings.Default.bot_1_use = this.bot_1_use.IsChecked;
            Settings.Default.bot_2_key = this.bot_2_key_cbx.Text;
            Settings.Default.bot_2_use = this.bot_2_use.IsChecked;
            Settings.Default.attack_range = Convert.ToUInt32(this.attack_range_tbx.Text);
            Settings.Default.unstucking_run_time = Convert.ToInt32(this.run_unstucking_time_tbx.Text);
            Settings.Default.unstucking_attack_time = Convert.ToInt32(this.attack_unstucking_tbx.Text);
            Settings.Default.unstucking_attack_duration = Convert.ToInt32(this.attack_unstucking_duration_tbx.Text);
            Settings.Default.autoselling_timer = Convert.ToInt32(this.auto_selling_duration_tbx.Text);
            Settings.Default.autoselling_enabled = this.enable_autoselling_cbx.IsChecked.Value;
            Settings.Default.heal_until_100_enabled = this.healing_to_100_cbx.IsChecked.Value;
            Settings.Default.heal_until_100_key_using_enabled = this.healing_to_100_usekeys_cbx.IsChecked.Value;
            Settings.Default.mods = this.mods_cbx.Text;
            Settings.Default.Save();
        }

        private void EQIRJCADTGSYTWHFWAIXGH(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 10;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void FWWMBSTDVKLJLIMVWQXSM(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 5;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void GHXQZZVHOKFKSBEBQUOUZK(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = -1;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void IBWWEKBCJJRDCXHMWFTCEC(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 13;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this.NWLUATZPJLQLBXYIDKBFGB)
            {
                this.NWLUATZPJLQLBXYIDKBFGB = true;
                Uri resourceLocator = new Uri("/StarSpot;component/optionswindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        private void JGRGPSGTGNAWRUZFAGCZH(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!this.TOOMVDUDARVUZZVHEVRKGZ.Contains(GameUnit.QZBOLIKIOINMCFBPCAFVSH))
                {
                    this.blacklist_lbx.Items.Add(GameUnit.QZBOLIKIOINMCFBPCAFVSH);
                    this.TOOMVDUDARVUZZVHEVRKGZ[this.blacklist_lbx.Items.Count] = GameUnit.QZBOLIKIOINMCFBPCAFVSH;
                }
            }
            catch
            {
            }
        }

        public void JVOFNWTPNXUEKMUUETGARD()
        {
            this.mods_cbx.Items.Add("Grinding");
            this.mods_cbx.Items.Add("Combat");
            this.skills_1_cooldown_tbx.Text = Convert.ToString(Settings.Default.skill_1_cooldown);
            this.skills_1_tgw.IsChecked = Settings.Default.skill_1_enabled;
            this.skills_2_cooldown_tbx.Text = Convert.ToString(Settings.Default.skill_2_cooldown);
            this.skills_2_tgw.IsChecked = Settings.Default.skill_2_enabled;
            this.skills_2_charge_tbx.Text = Convert.ToString(Settings.Default.skill_2_charge);
            this.skills_3_cooldown_tbx.Text = Convert.ToString(Settings.Default.skill_3_cooldown);
            this.skills_3_tgw.IsChecked = Settings.Default.skill_3_enabled;
            this.skills_3_charge_tbx.Text = Convert.ToString(Settings.Default.skill_3_charge);
            this.skills_4_cooldown_tbx.Text = Convert.ToString(Settings.Default.skill_4_cooldown);
            this.skills_4_tgw.IsChecked = Settings.Default.skill_4_enabled;
            this.skills_4_charge_tbx.Text = Convert.ToString(Settings.Default.skill_4_charge);
            this.skills_5_cooldown_tbx.Text = Convert.ToString(Settings.Default.skill_5_cooldown);
            this.skills_5_tgw.IsChecked = Settings.Default.skill_5_enabled;
            this.skills_5_charge_tbx.Text = Convert.ToString(Settings.Default.skill_5_charge);
            this.skills_6_cooldown_tbx.Text = Convert.ToString(Settings.Default.skill_6_cooldown);
            this.skills_6_tgw.IsChecked = Settings.Default.skill_6_enabled;
            this.skills_6_charge_tbx.Text = Convert.ToString(Settings.Default.skill_6_charge);
            this.skills_7_cooldown_tbx.Text = Convert.ToString(Settings.Default.skill_7_cooldown);
            this.skills_7_tgw.IsChecked = Settings.Default.skill_7_enabled;
            this.skills_7_charge_tbx.Text = Convert.ToString(Settings.Default.skill_7_charge);
            this.skills_8_cooldown_tbx.Text = Convert.ToString(Settings.Default.skill_8_cooldown);
            this.skills_8_tgw.IsChecked = Settings.Default.skill_8_enabled;
            this.skills_8_charge_tbx.Text = Convert.ToString(Settings.Default.skill_8_charge);
            this.skills_9_cooldown_tbx.Text = Convert.ToString(Settings.Default.skill_9_cooldown);
            this.skills_9_tgw.IsChecked = Settings.Default.skill_9_enabled;
            this.skills_9_charge_tbx.Text = Convert.ToString(Settings.Default.skill_9_charge);
            this.enable_looting_cbx.IsChecked = new bool?(Settings.Default.looting_option);
            this.enable_random_jumping_cbx.IsChecked = new bool?(Settings.Default.random_jumping);
            this.random_jumping_timer_tbx.Text = Settings.Default.random_jumping_timer.ToString();
            this.key_using_1_cbx.Text = Settings.Default.key_using_1_key;
            this.key_using_1_cooldown.Text = Settings.Default.key_using_1_cooldown.ToString();
            this.key_using_1_ct_tbx.Text = Settings.Default.key_using_1_ct.ToString();
            this.key_using_2_cbx.Text = Settings.Default.key_using_2_key;
            this.key_using_2_cooldown.Text = Settings.Default.key_using_2_cooldown.ToString();
            this.key_using_2_ct_tbx.Text = Settings.Default.key_using_2_ct.ToString();
            this.key_using_3_cbx.Text = Settings.Default.key_using_3_key;
            this.key_using_3_cooldown.Text = Settings.Default.key_using_3_cooldown.ToString();
            this.key_using_3_ct_tbx.Text = Settings.Default.key_using_3_ct.ToString();
            this.key_using_4_cbx.Text = Settings.Default.key_using_4_key;
            this.key_using_4_cooldown.Text = Settings.Default.key_using_4_cooldown.ToString();
            this.key_using_4_ct_tbx.Text = Settings.Default.key_using_4_ct.ToString();
            this.key_using_5_cbx.Text = Settings.Default.key_using_5_key;
            this.key_using_5_cooldown.Text = Settings.Default.key_using_5_cooldown.ToString();
            this.key_using_5_ct_tbx.Text = Settings.Default.key_using_5_ct.ToString();
            this.key_using_6_cbx.Text = Settings.Default.key_using_6_key;
            this.key_using_6_cooldown.Text = Settings.Default.key_using_6_cooldown.ToString();
            this.key_using_6_ct_tbx.Text = Settings.Default.key_using_6_ct.ToString();
            this.key_using_7_cbx.Text = Settings.Default.key_using_7_key;
            this.key_using_7_cooldown.Text = Settings.Default.key_using_7_cooldown.ToString();
            this.key_using_7_ct_tbx.Text = Settings.Default.key_using_7_ct.ToString();
            this.key_using_8_cbx.Text = Settings.Default.key_using_8_key;
            this.key_using_8_cooldown.Text = Settings.Default.key_using_8_cooldown.ToString();
            this.key_using_8_ct_tbx.Text = Settings.Default.key_using_8_ct.ToString();
            this.key_using_9_cbx.Text = Settings.Default.key_using_9_key;
            this.key_using_9_cooldown.Text = Settings.Default.key_using_9_cooldown.ToString();
            this.key_using_9_ct_tbx.Text = Settings.Default.key_using_9_ct.ToString();
            this.key_using_10_cbx.Text = Settings.Default.key_using_10_key;
            this.key_using_10_cooldown.Text = Settings.Default.key_using_10_cooldown.ToString();
            this.key_using_10_ct_tbx.Text = Settings.Default.key_using_10_ct.ToString();
            this.enable_defending_after_death.IsChecked = new bool?(Settings.Default.enable_defending_after_death);
            this.enable_tabbing_after_death.IsChecked = new bool?(Settings.Default.enable_tabbing_after_death);
            this.enable_stop_after_cbx.IsChecked = new bool?(Settings.Default.enable_stop_after);
            this.stop_after_min_tbx.Text = Settings.Default.stop_after_min.ToString();
            this.enable_start_after_cbx.IsChecked = new bool?(Settings.Default.enable_start_after);
            this.start_after_tbx.Text = Settings.Default.start_after_min.ToString();
            this.hunting_level_range_tbx.Text = Convert.ToString(Settings.Default.level_range);
            this.player_detection_stop_tbx.Text = Settings.Default.player_detection_min.ToString();
            this.player_detection_radius_tbx.Text = Settings.Default.player_detection_radius.ToString();
            for (int i = 1; i < 9; i++)
            {
                this.bot_1_key_cbx.Items.Add(i.ToString());
                this.bot_2_key_cbx.Items.Add(i.ToString());
            }
            this.bot_1_key_cbx.Text = Settings.Default.bot_1_key;
            this.bot_2_key_cbx.Text = Settings.Default.bot_2_key;
            this.bot_1_use.IsChecked = Settings.Default.bot_1_use;
            this.bot_2_use.IsChecked = Settings.Default.bot_2_use;
            this.attack_range_tbx.Text = Settings.Default.attack_range.ToString();
            this.attack_unstucking_duration_tbx.Text = Settings.Default.unstucking_attack_duration.ToString();
            this.attack_unstucking_tbx.Text = Settings.Default.unstucking_attack_time.ToString();
            this.run_unstucking_time_tbx.Text = Settings.Default.unstucking_run_time.ToString();
            this.auto_selling_duration_tbx.Text = Settings.Default.autoselling_timer.ToString();
            this.enable_autoselling_cbx.IsChecked = new bool?(Settings.Default.autoselling_enabled);
            this.healing_to_100_cbx.IsChecked = new bool?(Settings.Default.heal_until_100_enabled);
            this.healing_to_100_usekeys_cbx.IsChecked = new bool?(Settings.Default.heal_until_100_key_using_enabled);
            this.mods_cbx.Text = Settings.Default.mods;
        }

        private void JXDKECAGMJMHOXINBTMMUG(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 12;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void KVIVNKJVUFRLQVIZGOSDZP(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 14;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void LMJCGJUPIUGRFYGQETGLLL(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 7;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void MWHYFVEWAEIPEWIRGKVISO(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 0x10;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void NBJPXDVFTMGCIMFJVYFBJK(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 11;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void NDWPGUCKIIUOOAIZFTULCU(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 8;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void NJFLOUNOHOLNROKESTVBM(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 0x11;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void OQDKFRNYMKJBBMMRFUPJXC(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 6;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void OZVWNRARAKWUBAEMIAJNSO(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 3;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void QQFMMELANVEJQOCINHVDCF(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 9;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void QXDVHDEJOTVGPBCHTRGZFN(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 0;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    ((FRSKNCKDUTXBQVSAINYDDC) target).Closing += new CancelEventHandler(this.XSQMBNMGFIFJQITQBIFYZS);
                    return;

                case 2:
                    this.skills_1_tgw = (ToggleSwitch) target;
                    return;

                case 3:
                    this.skills_2_cooldown_tbx = (TextBox) target;
                    return;

                case 4:
                    this.skills_2_tgw = (ToggleSwitch) target;
                    return;

                case 5:
                    this.skills_2_charge_tbx = (TextBox) target;
                    return;

                case 6:
                    this.skill_1_more = (Button) target;
                    this.skill_1_more.Click += new RoutedEventHandler(this.QXDVHDEJOTVGPBCHTRGZFN);
                    return;

                case 7:
                    this.skills_3_cooldown_tbx = (TextBox) target;
                    return;

                case 8:
                    this.skills_3_tgw = (ToggleSwitch) target;
                    return;

                case 9:
                    this.skills_3_charge_tbx = (TextBox) target;
                    return;

                case 10:
                    this.skill_2_more = (Button) target;
                    this.skill_2_more.Click += new RoutedEventHandler(this.ZNPOHABVVVMJXTUTQODOOG);
                    return;

                case 11:
                    this.skills_4_cooldown_tbx = (TextBox) target;
                    return;

                case 12:
                    this.skills_4_tgw = (ToggleSwitch) target;
                    return;

                case 13:
                    this.skills_4_charge_tbx = (TextBox) target;
                    return;

                case 14:
                    this.skill_3_more = (Button) target;
                    this.skill_3_more.Click += new RoutedEventHandler(this.YCLVXIKTFCXEQTOQTMIIH);
                    return;

                case 15:
                    this.skills_5_cooldown_tbx = (TextBox) target;
                    return;

                case 0x10:
                    this.skills_5_tgw = (ToggleSwitch) target;
                    return;

                case 0x11:
                    this.skills_5_charge_tbx = (TextBox) target;
                    return;

                case 0x12:
                    this.skill_4_more = (Button) target;
                    this.skill_4_more.Click += new RoutedEventHandler(this.OZVWNRARAKWUBAEMIAJNSO);
                    return;

                case 0x13:
                    this.skills_6_cooldown_tbx = (TextBox) target;
                    return;

                case 20:
                    this.skills_6_tgw = (ToggleSwitch) target;
                    return;

                case 0x15:
                    this.skills_6_charge_tbx = (TextBox) target;
                    return;

                case 0x16:
                    this.skill_5_more = (Button) target;
                    this.skill_5_more.Click += new RoutedEventHandler(this.CBMBFNOROENFJCKCXWQHRB);
                    return;

                case 0x17:
                    this.skills_7_cooldown_tbx = (TextBox) target;
                    return;

                case 0x18:
                    this.skills_7_tgw = (ToggleSwitch) target;
                    return;

                case 0x19:
                    this.skills_7_charge_tbx = (TextBox) target;
                    return;

                case 0x1a:
                    this.skill_6_more = (Button) target;
                    this.skill_6_more.Click += new RoutedEventHandler(this.FWWMBSTDVKLJLIMVWQXSM);
                    return;

                case 0x1b:
                    this.skills_8_cooldown_tbx = (TextBox) target;
                    return;

                case 0x1c:
                    this.skills_8_tgw = (ToggleSwitch) target;
                    return;

                case 0x1d:
                    this.skills_8_charge_tbx = (TextBox) target;
                    return;

                case 30:
                    this.skill_7_more = (Button) target;
                    this.skill_7_more.Click += new RoutedEventHandler(this.OQDKFRNYMKJBBMMRFUPJXC);
                    return;

                case 0x1f:
                    this.skills_9_cooldown_tbx = (TextBox) target;
                    return;

                case 0x20:
                    this.skills_9_tgw = (ToggleSwitch) target;
                    return;

                case 0x21:
                    this.skills_9_charge_tbx = (TextBox) target;
                    return;

                case 0x22:
                    this.skill_8_more = (Button) target;
                    this.skill_8_more.Click += new RoutedEventHandler(this.LMJCGJUPIUGRFYGQETGLLL);
                    return;

                case 0x23:
                    this.skills_1_cooldown_tbx = (TextBox) target;
                    return;

                case 0x24:
                    this.skill_0_more = (Button) target;
                    this.skill_0_more.Click += new RoutedEventHandler(this.GHXQZZVHOKFKSBEBQUOUZK);
                    return;

                case 0x25:
                    this.key_using_1_cbx = (ComboBox) target;
                    return;

                case 0x26:
                    this.key_using_1_cooldown = (TextBox) target;
                    return;

                case 0x27:
                    this.key_using_2_cbx = (ComboBox) target;
                    return;

                case 40:
                    this.key_using_2_cooldown = (TextBox) target;
                    return;

                case 0x29:
                    this.key_using_3_cbx = (ComboBox) target;
                    return;

                case 0x2a:
                    this.key_using_3_cooldown = (TextBox) target;
                    return;

                case 0x2b:
                    this.key_using_4_cbx = (ComboBox) target;
                    return;

                case 0x2c:
                    this.key_using_4_cooldown = (TextBox) target;
                    return;

                case 0x2d:
                    this.key_using_5_cbx = (ComboBox) target;
                    return;

                case 0x2e:
                    this.key_using_5_cooldown = (TextBox) target;
                    return;

                case 0x2f:
                    this.key_using_6_cbx = (ComboBox) target;
                    return;

                case 0x30:
                    this.key_using_6_cooldown = (TextBox) target;
                    return;

                case 0x31:
                    this.key_using_7_cbx = (ComboBox) target;
                    return;

                case 50:
                    this.key_using_7_cooldown = (TextBox) target;
                    return;

                case 0x33:
                    this.key_using_8_cbx = (ComboBox) target;
                    return;

                case 0x34:
                    this.key_using_8_cooldown = (TextBox) target;
                    return;

                case 0x35:
                    this.key_using_9_cbx = (ComboBox) target;
                    return;

                case 0x36:
                    this.key_using_9_cooldown = (TextBox) target;
                    return;

                case 0x37:
                    this.key_using_10_cbx = (ComboBox) target;
                    return;

                case 0x38:
                    this.key_using_10_cooldown = (TextBox) target;
                    return;

                case 0x39:
                    this.key_using_1_more = (Button) target;
                    this.key_using_1_more.Click += new RoutedEventHandler(this.NDWPGUCKIIUOOAIZFTULCU);
                    return;

                case 0x3a:
                    this.key_using_2_more = (Button) target;
                    this.key_using_2_more.Click += new RoutedEventHandler(this.QQFMMELANVEJQOCINHVDCF);
                    return;

                case 0x3b:
                    this.key_using_3_more = (Button) target;
                    this.key_using_3_more.Click += new RoutedEventHandler(this.EQIRJCADTGSYTWHFWAIXGH);
                    return;

                case 60:
                    this.key_using_4_more = (Button) target;
                    this.key_using_4_more.Click += new RoutedEventHandler(this.NBJPXDVFTMGCIMFJVYFBJK);
                    return;

                case 0x3d:
                    this.key_using_5_more = (Button) target;
                    this.key_using_5_more.Click += new RoutedEventHandler(this.JXDKECAGMJMHOXINBTMMUG);
                    return;

                case 0x3e:
                    this.key_using_6_more = (Button) target;
                    this.key_using_6_more.Click += new RoutedEventHandler(this.IBWWEKBCJJRDCXHMWFTCEC);
                    return;

                case 0x3f:
                    this.key_using_7_more = (Button) target;
                    this.key_using_7_more.Click += new RoutedEventHandler(this.KVIVNKJVUFRLQVIZGOSDZP);
                    return;

                case 0x40:
                    this.key_using_8_more = (Button) target;
                    this.key_using_8_more.Click += new RoutedEventHandler(this.TKSPAWPDNBXFDWADGEJENX);
                    return;

                case 0x41:
                    this.key_using_9_more = (Button) target;
                    this.key_using_9_more.Click += new RoutedEventHandler(this.MWHYFVEWAEIPEWIRGKVISO);
                    return;

                case 0x42:
                    this.key_using_10_more = (Button) target;
                    this.key_using_10_more.Click += new RoutedEventHandler(this.NJFLOUNOHOLNROKESTVBM);
                    return;

                case 0x43:
                    this.key_using_1_ct_tbx = (TextBox) target;
                    return;

                case 0x44:
                    this.key_using_2_ct_tbx = (TextBox) target;
                    return;

                case 0x45:
                    this.key_using_3_ct_tbx = (TextBox) target;
                    return;

                case 70:
                    this.key_using_4_ct_tbx = (TextBox) target;
                    return;

                case 0x47:
                    this.key_using_5_ct_tbx = (TextBox) target;
                    return;

                case 0x48:
                    this.key_using_6_ct_tbx = (TextBox) target;
                    return;

                case 0x49:
                    this.key_using_7_ct_tbx = (TextBox) target;
                    return;

                case 0x4a:
                    this.key_using_8_ct_tbx = (TextBox) target;
                    return;

                case 0x4b:
                    this.key_using_9_ct_tbx = (TextBox) target;
                    return;

                case 0x4c:
                    this.key_using_10_ct_tbx = (TextBox) target;
                    return;

                case 0x4d:
                    this.enable_looting_cbx = (CheckBox) target;
                    return;

                case 0x4e:
                    this.enable_random_jumping_cbx = (CheckBox) target;
                    return;

                case 0x4f:
                    this.random_jumping_timer_tbx = (TextBox) target;
                    return;

                case 80:
                    this.enable_tabbing_after_death = (CheckBox) target;
                    return;

                case 0x51:
                    this.enable_defending_after_death = (CheckBox) target;
                    return;

                case 0x52:
                    this.enable_stop_after_cbx = (CheckBox) target;
                    return;

                case 0x53:
                    this.stop_after_min_tbx = (TextBox) target;
                    return;

                case 0x54:
                    this.enable_start_after_cbx = (CheckBox) target;
                    return;

                case 0x55:
                    this.start_after_tbx = (TextBox) target;
                    return;

                case 0x56:
                    this.hunting_level_range_tbx = (TextBox) target;
                    return;

                case 0x57:
                    this.player_detection_stop_tbx = (TextBox) target;
                    return;

                case 0x58:
                    this.player_detection_radius_tbx = (TextBox) target;
                    return;

                case 0x59:
                    this.attack_range_tbx = (TextBox) target;
                    return;

                case 90:
                    this.attack_unstucking_tbx = (TextBox) target;
                    return;

                case 0x5b:
                    this.attack_unstucking_duration_tbx = (TextBox) target;
                    return;

                case 0x5c:
                    this.run_unstucking_time_tbx = (TextBox) target;
                    return;

                case 0x5d:
                    this.enable_autoselling_cbx = (CheckBox) target;
                    return;

                case 0x5e:
                    this.auto_selling_duration_tbx = (TextBox) target;
                    return;

                case 0x5f:
                    this.healing_to_100_cbx = (CheckBox) target;
                    return;

                case 0x60:
                    this.healing_to_100_usekeys_cbx = (CheckBox) target;
                    return;

                case 0x61:
                    this.mods_cbx = (ComboBox) target;
                    return;

                case 0x62:
                    this.blacklist_lbx = (ListBox) target;
                    return;

                case 0x63:
                    this.add_npc_btn = (Button) target;
                    this.add_npc_btn.Click += new RoutedEventHandler(this.JGRGPSGTGNAWRUZFAGCZH);
                    return;

                case 100:
                    this.delete_npc_btn = (Button) target;
                    this.delete_npc_btn.Click += new RoutedEventHandler(this.UTIMIUEQXURFKHUSWQNAGA);
                    return;

                case 0x65:
                    this.bot_1_use = (ToggleSwitch) target;
                    return;

                case 0x66:
                    this.bot_1_key_cbx = (ComboBox) target;
                    return;

                case 0x67:
                    this.bot_2_use = (ToggleSwitch) target;
                    return;

                case 0x68:
                    this.bot_2_key_cbx = (ComboBox) target;
                    return;
            }
            this.NWLUATZPJLQLBXYIDKBFGB = true;
        }

        private void TKSPAWPDNBXFDWADGEJENX(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 15;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void UTIMIUEQXURFKHUSWQNAGA(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.TOOMVDUDARVUZZVHEVRKGZ.Contains(this.blacklist_lbx.SelectedItem.ToString()))
                {
                    int index = this.TOOMVDUDARVUZZVHEVRKGZ.IndexOf(this.blacklist_lbx.SelectedItem.ToString());
                    this.TOOMVDUDARVUZZVHEVRKGZ[index] = "0";
                }
                this.blacklist_lbx.Items.Remove(this.blacklist_lbx.SelectedItem);
            }
            catch
            {
            }
        }

        public void WYJZFNBMIZQZYWQPJRLPF()
        {
            this.key_using_1_cbx.Items.Add("");
            this.key_using_1_cbx.Items.Add("Y");
            this.key_using_1_cbx.Items.Add("X");
            this.key_using_1_cbx.Items.Add("C");
            this.key_using_1_cbx.Items.Add("V");
            this.key_using_1_cbx.Items.Add("B");
            this.key_using_1_cbx.Items.Add("N");
            this.key_using_1_cbx.Items.Add("M");
            this.key_using_1_cbx.Items.Add(",");
            this.key_using_1_cbx.Items.Add(".");
            this.key_using_1_cbx.Items.Add("-");
            this.key_using_2_cbx.Items.Add("");
            this.key_using_2_cbx.Items.Add("Y");
            this.key_using_2_cbx.Items.Add("X");
            this.key_using_2_cbx.Items.Add("C");
            this.key_using_2_cbx.Items.Add("V");
            this.key_using_2_cbx.Items.Add("B");
            this.key_using_2_cbx.Items.Add("N");
            this.key_using_2_cbx.Items.Add("M");
            this.key_using_2_cbx.Items.Add(",");
            this.key_using_2_cbx.Items.Add(".");
            this.key_using_2_cbx.Items.Add("-");
            this.key_using_3_cbx.Items.Add("");
            this.key_using_3_cbx.Items.Add("Y");
            this.key_using_3_cbx.Items.Add("X");
            this.key_using_3_cbx.Items.Add("C");
            this.key_using_3_cbx.Items.Add("V");
            this.key_using_3_cbx.Items.Add("B");
            this.key_using_3_cbx.Items.Add("N");
            this.key_using_3_cbx.Items.Add("M");
            this.key_using_3_cbx.Items.Add(",");
            this.key_using_3_cbx.Items.Add(".");
            this.key_using_3_cbx.Items.Add("-");
            this.key_using_4_cbx.Items.Add("");
            this.key_using_4_cbx.Items.Add("Y");
            this.key_using_4_cbx.Items.Add("X");
            this.key_using_4_cbx.Items.Add("C");
            this.key_using_4_cbx.Items.Add("V");
            this.key_using_4_cbx.Items.Add("B");
            this.key_using_4_cbx.Items.Add("N");
            this.key_using_4_cbx.Items.Add("M");
            this.key_using_4_cbx.Items.Add(",");
            this.key_using_4_cbx.Items.Add(".");
            this.key_using_4_cbx.Items.Add("-");
            this.key_using_5_cbx.Items.Add("");
            this.key_using_5_cbx.Items.Add("Y");
            this.key_using_5_cbx.Items.Add("X");
            this.key_using_5_cbx.Items.Add("C");
            this.key_using_5_cbx.Items.Add("V");
            this.key_using_5_cbx.Items.Add("B");
            this.key_using_5_cbx.Items.Add("N");
            this.key_using_5_cbx.Items.Add("M");
            this.key_using_5_cbx.Items.Add(",");
            this.key_using_5_cbx.Items.Add(".");
            this.key_using_5_cbx.Items.Add("-");
            this.key_using_6_cbx.Items.Add("");
            this.key_using_6_cbx.Items.Add("Y");
            this.key_using_6_cbx.Items.Add("X");
            this.key_using_6_cbx.Items.Add("C");
            this.key_using_6_cbx.Items.Add("V");
            this.key_using_6_cbx.Items.Add("B");
            this.key_using_6_cbx.Items.Add("N");
            this.key_using_6_cbx.Items.Add("M");
            this.key_using_6_cbx.Items.Add(",");
            this.key_using_6_cbx.Items.Add(".");
            this.key_using_6_cbx.Items.Add("-");
            this.key_using_7_cbx.Items.Add("");
            this.key_using_7_cbx.Items.Add("Y");
            this.key_using_7_cbx.Items.Add("X");
            this.key_using_7_cbx.Items.Add("C");
            this.key_using_7_cbx.Items.Add("V");
            this.key_using_7_cbx.Items.Add("B");
            this.key_using_7_cbx.Items.Add("N");
            this.key_using_7_cbx.Items.Add("M");
            this.key_using_7_cbx.Items.Add(",");
            this.key_using_7_cbx.Items.Add(".");
            this.key_using_7_cbx.Items.Add("-");
            this.key_using_8_cbx.Items.Add("");
            this.key_using_8_cbx.Items.Add("Y");
            this.key_using_8_cbx.Items.Add("X");
            this.key_using_8_cbx.Items.Add("C");
            this.key_using_8_cbx.Items.Add("V");
            this.key_using_8_cbx.Items.Add("B");
            this.key_using_8_cbx.Items.Add("N");
            this.key_using_8_cbx.Items.Add("M");
            this.key_using_8_cbx.Items.Add(",");
            this.key_using_8_cbx.Items.Add(".");
            this.key_using_8_cbx.Items.Add("-");
            this.key_using_9_cbx.Items.Add("");
            this.key_using_9_cbx.Items.Add("Y");
            this.key_using_9_cbx.Items.Add("X");
            this.key_using_9_cbx.Items.Add("C");
            this.key_using_9_cbx.Items.Add("V");
            this.key_using_9_cbx.Items.Add("B");
            this.key_using_9_cbx.Items.Add("N");
            this.key_using_9_cbx.Items.Add("M");
            this.key_using_9_cbx.Items.Add(",");
            this.key_using_9_cbx.Items.Add(".");
            this.key_using_9_cbx.Items.Add("-");
            this.key_using_10_cbx.Items.Add("");
            this.key_using_10_cbx.Items.Add("Y");
            this.key_using_10_cbx.Items.Add("X");
            this.key_using_10_cbx.Items.Add("C");
            this.key_using_10_cbx.Items.Add("V");
            this.key_using_10_cbx.Items.Add("B");
            this.key_using_10_cbx.Items.Add("N");
            this.key_using_10_cbx.Items.Add("M");
            this.key_using_10_cbx.Items.Add(",");
            this.key_using_10_cbx.Items.Add(".");
            this.key_using_10_cbx.Items.Add("-");
            for (int i = 1; i < 9; i++)
            {
                this.key_using_1_cbx.Items.Add(i.ToString());
                this.key_using_2_cbx.Items.Add(i.ToString());
                this.key_using_3_cbx.Items.Add(i.ToString());
                this.key_using_4_cbx.Items.Add(i.ToString());
                this.key_using_5_cbx.Items.Add(i.ToString());
                this.key_using_6_cbx.Items.Add(i.ToString());
                this.key_using_7_cbx.Items.Add(i.ToString());
                this.key_using_8_cbx.Items.Add(i.ToString());
                this.key_using_9_cbx.Items.Add(i.ToString());
                this.key_using_10_cbx.Items.Add(i.ToString());
            }
        }

        private void XSQMBNMGFIFJQITQBIFYZS(object sender, CancelEventArgs e)
        {
            this.DTTAENDOLEGYARGIHYLTRD();
            YBSUCJMYSLDAJCBXNWPPZA = false;
        }

        private void YCLVXIKTFCXEQTOQTMIIH(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 2;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }

        private void ZNPOHABVVVMJXTUTQODOOG(object sender, RoutedEventArgs e)
        {
            TWKLKVYOLHCNMSHTXVYSGO twklkvyolhcnmshtxvysgo = new TWKLKVYOLHCNMSHTXVYSGO();
            TWKLKVYOLHCNMSHTXVYSGO.VZENROJZRTEWHHKSIDWPW = 1;
            try
            {
                if (!TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ)
                {
                    twklkvyolhcnmshtxvysgo.Show();
                    TWKLKVYOLHCNMSHTXVYSGO.QOTQSZQIZDELSOLYIJAMRZ = true;
                }
            }
            catch
            {
            }
        }
    }
}

