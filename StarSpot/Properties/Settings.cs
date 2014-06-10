namespace StarSpot.Properties
{
    using StarSpot;
    using System;
    using System.CodeDom.Compiler;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance = ((Settings) SettingsBase.Synchronized(new Settings()));

        [DefaultSettingValue("6"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public long attack_range
        {
            get
            {
                return (long) this["attack_range"];
            }
            set
            {
                this["attack_range"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider))]
        public bool autoselling_enabled
        {
            get
            {
                return (bool) this["autoselling_enabled"];
            }
            set
            {
                this["autoselling_enabled"] = value;
            }
        }

        [DefaultSettingValue("10"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int autoselling_timer
        {
            get
            {
                return (int) this["autoselling_timer"];
            }
            set
            {
                this["autoselling_timer"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public string blacklist_npcs
        {
            get
            {
                return (string) this["blacklist_npcs"];
            }
            set
            {
                this["blacklist_npcs"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue(""), DebuggerNonUserCode]
        public string bot_1_key
        {
            get
            {
                return (string) this["bot_1_key"];
            }
            set
            {
                this["bot_1_key"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("False")]
        public bool bot_1_use
        {
            get
            {
                return (bool) this["bot_1_use"];
            }
            set
            {
                this["bot_1_use"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue(""), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public string bot_2_key
        {
            get
            {
                return (string) this["bot_2_key"];
            }
            set
            {
                this["bot_2_key"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting]
        public bool bot_2_use
        {
            get
            {
                return (bool) this["bot_2_use"];
            }
            set
            {
                this["bot_2_use"] = value;
            }
        }

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("False")]
        public bool enable_defending_after_death
        {
            get
            {
                return (bool) this["enable_defending_after_death"];
            }
            set
            {
                this["enable_defending_after_death"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("False")]
        public bool enable_start_after
        {
            get
            {
                return (bool) this["enable_start_after"];
            }
            set
            {
                this["enable_start_after"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider))]
        public bool enable_stop_after
        {
            get
            {
                return (bool) this["enable_stop_after"];
            }
            set
            {
                this["enable_stop_after"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider))]
        public bool enable_tabbing_after_death
        {
            get
            {
                return (bool) this["enable_tabbing_after_death"];
            }
            set
            {
                this["enable_tabbing_after_death"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("False"), DebuggerNonUserCode]
        public bool heal_until_100_enabled
        {
            get
            {
                return (bool) this["heal_until_100_enabled"];
            }
            set
            {
                this["heal_until_100_enabled"] = value;
            }
        }

        [DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public bool heal_until_100_key_using_enabled
        {
            get
            {
                return (bool) this["heal_until_100_key_using_enabled"];
            }
            set
            {
                this["heal_until_100_key_using_enabled"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("1")]
        public int key_using_1_cooldown
        {
            get
            {
                return (int) this["key_using_1_cooldown"];
            }
            set
            {
                this["key_using_1_cooldown"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int key_using_1_ct
        {
            get
            {
                return (int) this["key_using_1_ct"];
            }
            set
            {
                this["key_using_1_ct"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_1_health_cdt
        {
            get
            {
                return (int) this["key_using_1_health_cdt"];
            }
            set
            {
                this["key_using_1_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int key_using_1_health_over_cdt
        {
            get
            {
                return (int) this["key_using_1_health_over_cdt"];
            }
            set
            {
                this["key_using_1_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("False"), DebuggerNonUserCode]
        public bool key_using_1_infight
        {
            get
            {
                return (bool) this["key_using_1_infight"];
            }
            set
            {
                this["key_using_1_infight"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue(""), SettingsProvider(typeof(PortableSettingsProvider))]
        public string key_using_1_key
        {
            get
            {
                return (string) this["key_using_1_key"];
            }
            set
            {
                this["key_using_1_key"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0")]
        public int key_using_1_shield_cdt
        {
            get
            {
                return (int) this["key_using_1_shield_cdt"];
            }
            set
            {
                this["key_using_1_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_1_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_1_shield_over_cdt"];
            }
            set
            {
                this["key_using_1_shield_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_1_target_health_cdt
        {
            get
            {
                return (int) this["key_using_1_target_health_cdt"];
            }
            set
            {
                this["key_using_1_target_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_1_target_health_over_cdt
        {
            get
            {
                return (int) this["key_using_1_target_health_over_cdt"];
            }
            set
            {
                this["key_using_1_target_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode]
        public int key_using_1_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_1_target_shield_cdt"];
            }
            set
            {
                this["key_using_1_target_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_1_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_1_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_1_target_shield_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("1")]
        public int key_using_10_cooldown
        {
            get
            {
                return (int) this["key_using_10_cooldown"];
            }
            set
            {
                this["key_using_10_cooldown"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_10_ct
        {
            get
            {
                return (int) this["key_using_10_ct"];
            }
            set
            {
                this["key_using_10_ct"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int key_using_10_health_cdt
        {
            get
            {
                return (int) this["key_using_10_health_cdt"];
            }
            set
            {
                this["key_using_10_health_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_10_health_over_cdt
        {
            get
            {
                return (int) this["key_using_10_health_over_cdt"];
            }
            set
            {
                this["key_using_10_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("False"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public bool key_using_10_infight
        {
            get
            {
                return (bool) this["key_using_10_infight"];
            }
            set
            {
                this["key_using_10_infight"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue(""), UserScopedSetting]
        public string key_using_10_key
        {
            get
            {
                return (string) this["key_using_10_key"];
            }
            set
            {
                this["key_using_10_key"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_10_shield_cdt
        {
            get
            {
                return (int) this["key_using_10_shield_cdt"];
            }
            set
            {
                this["key_using_10_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_10_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_10_shield_over_cdt"];
            }
            set
            {
                this["key_using_10_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode]
        public int key_using_10_target_health_cdt
        {
            get
            {
                return (int) this["key_using_10_target_health_cdt"];
            }
            set
            {
                this["key_using_10_target_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_10_target_health_over_cdt
        {
            get
            {
                return (int) this["key_using_10_target_health_over_cdt"];
            }
            set
            {
                this["key_using_10_target_health_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int key_using_10_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_10_target_shield_cdt"];
            }
            set
            {
                this["key_using_10_target_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int key_using_10_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_10_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_10_target_shield_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("1"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_2_cooldown
        {
            get
            {
                return (int) this["key_using_2_cooldown"];
            }
            set
            {
                this["key_using_2_cooldown"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_2_ct
        {
            get
            {
                return (int) this["key_using_2_ct"];
            }
            set
            {
                this["key_using_2_ct"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_2_health_cdt
        {
            get
            {
                return (int) this["key_using_2_health_cdt"];
            }
            set
            {
                this["key_using_2_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_2_health_over_cdt
        {
            get
            {
                return (int) this["key_using_2_health_over_cdt"];
            }
            set
            {
                this["key_using_2_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("False")]
        public bool key_using_2_infight
        {
            get
            {
                return (bool) this["key_using_2_infight"];
            }
            set
            {
                this["key_using_2_infight"] = value;
            }
        }

        [DefaultSettingValue(""), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public string key_using_2_key
        {
            get
            {
                return (string) this["key_using_2_key"];
            }
            set
            {
                this["key_using_2_key"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int key_using_2_shield_cdt
        {
            get
            {
                return (int) this["key_using_2_shield_cdt"];
            }
            set
            {
                this["key_using_2_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_2_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_2_shield_over_cdt"];
            }
            set
            {
                this["key_using_2_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_2_target_health_cdt
        {
            get
            {
                return (int) this["key_using_2_target_health_cdt"];
            }
            set
            {
                this["key_using_2_target_health_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0")]
        public int key_using_2_target_health_over_cdt
        {
            get
            {
                return (int) this["key_using_2_target_health_over_cdt"];
            }
            set
            {
                this["key_using_2_target_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting]
        public int key_using_2_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_2_target_shield_cdt"];
            }
            set
            {
                this["key_using_2_target_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int key_using_2_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_2_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_2_target_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("1"), DebuggerNonUserCode]
        public int key_using_3_cooldown
        {
            get
            {
                return (int) this["key_using_3_cooldown"];
            }
            set
            {
                this["key_using_3_cooldown"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_3_ct
        {
            get
            {
                return (int) this["key_using_3_ct"];
            }
            set
            {
                this["key_using_3_ct"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_3_health_cdt
        {
            get
            {
                return (int) this["key_using_3_health_cdt"];
            }
            set
            {
                this["key_using_3_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int key_using_3_health_over_cdt
        {
            get
            {
                return (int) this["key_using_3_health_over_cdt"];
            }
            set
            {
                this["key_using_3_health_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool key_using_3_infight
        {
            get
            {
                return (bool) this["key_using_3_infight"];
            }
            set
            {
                this["key_using_3_infight"] = value;
            }
        }

        [DefaultSettingValue(""), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public string key_using_3_key
        {
            get
            {
                return (string) this["key_using_3_key"];
            }
            set
            {
                this["key_using_3_key"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_3_shield_cdt
        {
            get
            {
                return (int) this["key_using_3_shield_cdt"];
            }
            set
            {
                this["key_using_3_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_3_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_3_shield_over_cdt"];
            }
            set
            {
                this["key_using_3_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_3_target_health_cdt
        {
            get
            {
                return (int) this["key_using_3_target_health_cdt"];
            }
            set
            {
                this["key_using_3_target_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public float key_using_3_target_health_over_cdt
        {
            get
            {
                return (float) this["key_using_3_target_health_over_cdt"];
            }
            set
            {
                this["key_using_3_target_health_over_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int key_using_3_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_3_target_shield_cdt"];
            }
            set
            {
                this["key_using_3_target_shield_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int key_using_3_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_3_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_3_target_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("1"), DebuggerNonUserCode]
        public int key_using_4_cooldown
        {
            get
            {
                return (int) this["key_using_4_cooldown"];
            }
            set
            {
                this["key_using_4_cooldown"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_4_ct
        {
            get
            {
                return (int) this["key_using_4_ct"];
            }
            set
            {
                this["key_using_4_ct"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int key_using_4_health_cdt
        {
            get
            {
                return (int) this["key_using_4_health_cdt"];
            }
            set
            {
                this["key_using_4_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_4_health_over_cdt
        {
            get
            {
                return (int) this["key_using_4_health_over_cdt"];
            }
            set
            {
                this["key_using_4_health_over_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("False"), DebuggerNonUserCode]
        public bool key_using_4_infight
        {
            get
            {
                return (bool) this["key_using_4_infight"];
            }
            set
            {
                this["key_using_4_infight"] = value;
            }
        }

        [DefaultSettingValue(""), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public string key_using_4_key
        {
            get
            {
                return (string) this["key_using_4_key"];
            }
            set
            {
                this["key_using_4_key"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_4_shield_cdt
        {
            get
            {
                return (int) this["key_using_4_shield_cdt"];
            }
            set
            {
                this["key_using_4_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_4_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_4_shield_over_cdt"];
            }
            set
            {
                this["key_using_4_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_4_target_health_cdt
        {
            get
            {
                return (int) this["key_using_4_target_health_cdt"];
            }
            set
            {
                this["key_using_4_target_health_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int key_using_4_target_health_over_cdt
        {
            get
            {
                return (int) this["key_using_4_target_health_over_cdt"];
            }
            set
            {
                this["key_using_4_target_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting]
        public int key_using_4_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_4_target_shield_cdt"];
            }
            set
            {
                this["key_using_4_target_shield_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int key_using_4_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_4_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_4_target_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("1")]
        public int key_using_5_cooldown
        {
            get
            {
                return (int) this["key_using_5_cooldown"];
            }
            set
            {
                this["key_using_5_cooldown"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_5_ct
        {
            get
            {
                return (int) this["key_using_5_ct"];
            }
            set
            {
                this["key_using_5_ct"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int key_using_5_health_cdt
        {
            get
            {
                return (int) this["key_using_5_health_cdt"];
            }
            set
            {
                this["key_using_5_health_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_5_health_over_cdt
        {
            get
            {
                return (int) this["key_using_5_health_over_cdt"];
            }
            set
            {
                this["key_using_5_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public bool key_using_5_infight
        {
            get
            {
                return (bool) this["key_using_5_infight"];
            }
            set
            {
                this["key_using_5_infight"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("")]
        public string key_using_5_key
        {
            get
            {
                return (string) this["key_using_5_key"];
            }
            set
            {
                this["key_using_5_key"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_5_shield_cdt
        {
            get
            {
                return (int) this["key_using_5_shield_cdt"];
            }
            set
            {
                this["key_using_5_shield_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0")]
        public int key_using_5_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_5_shield_over_cdt"];
            }
            set
            {
                this["key_using_5_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_5_target_health_cdt
        {
            get
            {
                return (int) this["key_using_5_target_health_cdt"];
            }
            set
            {
                this["key_using_5_target_health_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int key_using_5_target_health_over_cdt
        {
            get
            {
                return (int) this["key_using_5_target_health_over_cdt"];
            }
            set
            {
                this["key_using_5_target_health_over_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int key_using_5_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_5_target_shield_cdt"];
            }
            set
            {
                this["key_using_5_target_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_5_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_5_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_5_target_shield_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("1"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_6_cooldown
        {
            get
            {
                return (int) this["key_using_6_cooldown"];
            }
            set
            {
                this["key_using_6_cooldown"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_6_ct
        {
            get
            {
                return (int) this["key_using_6_ct"];
            }
            set
            {
                this["key_using_6_ct"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_6_health_cdt
        {
            get
            {
                return (int) this["key_using_6_health_cdt"];
            }
            set
            {
                this["key_using_6_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int key_using_6_health_over_cdt
        {
            get
            {
                return (int) this["key_using_6_health_over_cdt"];
            }
            set
            {
                this["key_using_6_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool key_using_6_infight
        {
            get
            {
                return (bool) this["key_using_6_infight"];
            }
            set
            {
                this["key_using_6_infight"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue(""), SettingsProvider(typeof(PortableSettingsProvider))]
        public string key_using_6_key
        {
            get
            {
                return (string) this["key_using_6_key"];
            }
            set
            {
                this["key_using_6_key"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_6_shield_cdt
        {
            get
            {
                return (int) this["key_using_6_shield_cdt"];
            }
            set
            {
                this["key_using_6_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_6_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_6_shield_over_cdt"];
            }
            set
            {
                this["key_using_6_shield_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_6_target_health_cdt
        {
            get
            {
                return (int) this["key_using_6_target_health_cdt"];
            }
            set
            {
                this["key_using_6_target_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_6_target_health_over_cdt
        {
            get
            {
                return (int) this["key_using_6_target_health_over_cdt"];
            }
            set
            {
                this["key_using_6_target_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting]
        public int key_using_6_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_6_target_shield_cdt"];
            }
            set
            {
                this["key_using_6_target_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_6_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_6_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_6_target_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("1"), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_7_cooldown
        {
            get
            {
                return (int) this["key_using_7_cooldown"];
            }
            set
            {
                this["key_using_7_cooldown"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int key_using_7_ct
        {
            get
            {
                return (int) this["key_using_7_ct"];
            }
            set
            {
                this["key_using_7_ct"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_7_health_cdt
        {
            get
            {
                return (int) this["key_using_7_health_cdt"];
            }
            set
            {
                this["key_using_7_health_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int key_using_7_health_over_cdt
        {
            get
            {
                return (int) this["key_using_7_health_over_cdt"];
            }
            set
            {
                this["key_using_7_health_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public bool key_using_7_infight
        {
            get
            {
                return (bool) this["key_using_7_infight"];
            }
            set
            {
                this["key_using_7_infight"] = value;
            }
        }

        [DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public string key_using_7_key
        {
            get
            {
                return (string) this["key_using_7_key"];
            }
            set
            {
                this["key_using_7_key"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_7_shield_cdt
        {
            get
            {
                return (int) this["key_using_7_shield_cdt"];
            }
            set
            {
                this["key_using_7_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int key_using_7_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_7_shield_over_cdt"];
            }
            set
            {
                this["key_using_7_shield_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_7_target_health_cdt
        {
            get
            {
                return (int) this["key_using_7_target_health_cdt"];
            }
            set
            {
                this["key_using_7_target_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_7_target_health_over_cdt
        {
            get
            {
                return (int) this["key_using_7_target_health_over_cdt"];
            }
            set
            {
                this["key_using_7_target_health_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int key_using_7_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_7_target_shield_cdt"];
            }
            set
            {
                this["key_using_7_target_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_7_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_7_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_7_target_shield_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("1")]
        public int key_using_8_cooldown
        {
            get
            {
                return (int) this["key_using_8_cooldown"];
            }
            set
            {
                this["key_using_8_cooldown"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_8_ct
        {
            get
            {
                return (int) this["key_using_8_ct"];
            }
            set
            {
                this["key_using_8_ct"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_8_health_cdt
        {
            get
            {
                return (int) this["key_using_8_health_cdt"];
            }
            set
            {
                this["key_using_8_health_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_8_health_over_cdt
        {
            get
            {
                return (int) this["key_using_8_health_over_cdt"];
            }
            set
            {
                this["key_using_8_health_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public bool key_using_8_infight
        {
            get
            {
                return (bool) this["key_using_8_infight"];
            }
            set
            {
                this["key_using_8_infight"] = value;
            }
        }

        [DefaultSettingValue(""), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public string key_using_8_key
        {
            get
            {
                return (string) this["key_using_8_key"];
            }
            set
            {
                this["key_using_8_key"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int key_using_8_shield_cdt
        {
            get
            {
                return (int) this["key_using_8_shield_cdt"];
            }
            set
            {
                this["key_using_8_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_8_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_8_shield_over_cdt"];
            }
            set
            {
                this["key_using_8_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0")]
        public int key_using_8_target_health_cdt
        {
            get
            {
                return (int) this["key_using_8_target_health_cdt"];
            }
            set
            {
                this["key_using_8_target_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting]
        public int key_using_8_target_health_over_cdt
        {
            get
            {
                return (int) this["key_using_8_target_health_over_cdt"];
            }
            set
            {
                this["key_using_8_target_health_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_8_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_8_target_shield_cdt"];
            }
            set
            {
                this["key_using_8_target_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int key_using_8_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_8_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_8_target_shield_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("1"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int key_using_9_cooldown
        {
            get
            {
                return (int) this["key_using_9_cooldown"];
            }
            set
            {
                this["key_using_9_cooldown"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_9_ct
        {
            get
            {
                return (int) this["key_using_9_ct"];
            }
            set
            {
                this["key_using_9_ct"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_9_health_cdt
        {
            get
            {
                return (int) this["key_using_9_health_cdt"];
            }
            set
            {
                this["key_using_9_health_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int key_using_9_health_over_cdt
        {
            get
            {
                return (int) this["key_using_9_health_over_cdt"];
            }
            set
            {
                this["key_using_9_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("False")]
        public bool key_using_9_infight
        {
            get
            {
                return (bool) this["key_using_9_infight"];
            }
            set
            {
                this["key_using_9_infight"] = value;
            }
        }

        [DefaultSettingValue(""), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public string key_using_9_key
        {
            get
            {
                return (string) this["key_using_9_key"];
            }
            set
            {
                this["key_using_9_key"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_9_shield_cdt
        {
            get
            {
                return (int) this["key_using_9_shield_cdt"];
            }
            set
            {
                this["key_using_9_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode]
        public int key_using_9_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_9_shield_over_cdt"];
            }
            set
            {
                this["key_using_9_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
        public int key_using_9_target_health_cdt
        {
            get
            {
                return (int) this["key_using_9_target_health_cdt"];
            }
            set
            {
                this["key_using_9_target_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_9_target_health_over_cdt
        {
            get
            {
                return (int) this["key_using_9_target_health_over_cdt"];
            }
            set
            {
                this["key_using_9_target_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int key_using_9_target_shield_cdt
        {
            get
            {
                return (int) this["key_using_9_target_shield_cdt"];
            }
            set
            {
                this["key_using_9_target_shield_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int key_using_9_target_shield_over_cdt
        {
            get
            {
                return (int) this["key_using_9_target_shield_over_cdt"];
            }
            set
            {
                this["key_using_9_target_shield_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int level_range
        {
            get
            {
                return (int) this["level_range"];
            }
            set
            {
                this["level_range"] = value;
            }
        }

        [DefaultSettingValue("True"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool looting_option
        {
            get
            {
                return (bool) this["looting_option"];
            }
            set
            {
                this["looting_option"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("Grinding"), DebuggerNonUserCode]
        public string mods
        {
            get
            {
                return (string) this["mods"];
            }
            set
            {
                this["mods"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int player_detection_min
        {
            get
            {
                return (int) this["player_detection_min"];
            }
            set
            {
                this["player_detection_min"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int player_detection_radius
        {
            get
            {
                return (int) this["player_detection_radius"];
            }
            set
            {
                this["player_detection_radius"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider))]
        public bool random_jumping
        {
            get
            {
                return (bool) this["random_jumping"];
            }
            set
            {
                this["random_jumping"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("10"), DebuggerNonUserCode]
        public int random_jumping_timer
        {
            get
            {
                return (int) this["random_jumping_timer"];
            }
            set
            {
                this["random_jumping_timer"] = value;
            }
        }

        [DefaultSettingValue("50"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int search_range
        {
            get
            {
                return (int) this["search_range"];
            }
            set
            {
                this["search_range"] = value;
            }
        }

        [DefaultSettingValue(""), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public string serial_key
        {
            get
            {
                return (string) this["serial_key"];
            }
            set
            {
                this["serial_key"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0")]
        public int skill_1_cooldown
        {
            get
            {
                return (int) this["skill_1_cooldown"];
            }
            set
            {
                this["skill_1_cooldown"] = value;
            }
        }

        [DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public bool skill_1_enabled
        {
            get
            {
                return (bool) this["skill_1_enabled"];
            }
            set
            {
                this["skill_1_enabled"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int skill_1_health_cdt
        {
            get
            {
                return (int) this["skill_1_health_cdt"];
            }
            set
            {
                this["skill_1_health_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
        public int skill_1_health_over_cdt
        {
            get
            {
                return (int) this["skill_1_health_over_cdt"];
            }
            set
            {
                this["skill_1_health_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("False"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool skill_1_interrupt_enabled
        {
            get
            {
                return (bool) this["skill_1_interrupt_enabled"];
            }
            set
            {
                this["skill_1_interrupt_enabled"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int skill_1_repeat_cdt
        {
            get
            {
                return (int) this["skill_1_repeat_cdt"];
            }
            set
            {
                this["skill_1_repeat_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_1_shield_cdt
        {
            get
            {
                return (int) this["skill_1_shield_cdt"];
            }
            set
            {
                this["skill_1_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_1_shield_over_cdt
        {
            get
            {
                return (int) this["skill_1_shield_over_cdt"];
            }
            set
            {
                this["skill_1_shield_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_1_target_health_cdt
        {
            get
            {
                return (int) this["skill_1_target_health_cdt"];
            }
            set
            {
                this["skill_1_target_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int skill_1_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_1_target_health_over_cdt"];
            }
            set
            {
                this["skill_1_target_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0")]
        public int skill_1_target_shield_cdt
        {
            get
            {
                return (int) this["skill_1_target_shield_cdt"];
            }
            set
            {
                this["skill_1_target_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int skill_1_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_1_target_shield_over_cdt"];
            }
            set
            {
                this["skill_1_target_shield_over_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0")]
        public int skill_2_charge
        {
            get
            {
                return (int) this["skill_2_charge"];
            }
            set
            {
                this["skill_2_charge"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_2_cooldown
        {
            get
            {
                return (int) this["skill_2_cooldown"];
            }
            set
            {
                this["skill_2_cooldown"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("False")]
        public bool skill_2_double_click
        {
            get
            {
                return (bool) this["skill_2_double_click"];
            }
            set
            {
                this["skill_2_double_click"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public bool skill_2_enabled
        {
            get
            {
                return (bool) this["skill_2_enabled"];
            }
            set
            {
                this["skill_2_enabled"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0")]
        public int skill_2_health_cdt
        {
            get
            {
                return (int) this["skill_2_health_cdt"];
            }
            set
            {
                this["skill_2_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_2_health_over_cdt
        {
            get
            {
                return (int) this["skill_2_health_over_cdt"];
            }
            set
            {
                this["skill_2_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
        public bool skill_2_interrupt_enabled
        {
            get
            {
                return (bool) this["skill_2_interrupt_enabled"];
            }
            set
            {
                this["skill_2_interrupt_enabled"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting]
        public int skill_2_repeat_cdt
        {
            get
            {
                return (int) this["skill_2_repeat_cdt"];
            }
            set
            {
                this["skill_2_repeat_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_2_shield_cdt
        {
            get
            {
                return (int) this["skill_2_shield_cdt"];
            }
            set
            {
                this["skill_2_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting]
        public int skill_2_shield_over_cdt
        {
            get
            {
                return (int) this["skill_2_shield_over_cdt"];
            }
            set
            {
                this["skill_2_shield_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_2_target_health_cdt
        {
            get
            {
                return (int) this["skill_2_target_health_cdt"];
            }
            set
            {
                this["skill_2_target_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int skill_2_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_2_target_health_over_cdt"];
            }
            set
            {
                this["skill_2_target_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting]
        public int skill_2_target_shield_cdt
        {
            get
            {
                return (int) this["skill_2_target_shield_cdt"];
            }
            set
            {
                this["skill_2_target_shield_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("0")]
        public int skill_2_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_2_target_shield_over_cdt"];
            }
            set
            {
                this["skill_2_target_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_3_charge
        {
            get
            {
                return (int) this["skill_3_charge"];
            }
            set
            {
                this["skill_3_charge"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int skill_3_cooldown
        {
            get
            {
                return (int) this["skill_3_cooldown"];
            }
            set
            {
                this["skill_3_cooldown"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public bool skill_3_double_click
        {
            get
            {
                return (bool) this["skill_3_double_click"];
            }
            set
            {
                this["skill_3_double_click"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("False")]
        public bool skill_3_enabled
        {
            get
            {
                return (bool) this["skill_3_enabled"];
            }
            set
            {
                this["skill_3_enabled"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting]
        public int skill_3_health_cdt
        {
            get
            {
                return (int) this["skill_3_health_cdt"];
            }
            set
            {
                this["skill_3_health_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int skill_3_health_over_cdt
        {
            get
            {
                return (int) this["skill_3_health_over_cdt"];
            }
            set
            {
                this["skill_3_health_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider))]
        public bool skill_3_interrupt_enabled
        {
            get
            {
                return (bool) this["skill_3_interrupt_enabled"];
            }
            set
            {
                this["skill_3_interrupt_enabled"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting]
        public int skill_3_repeat_cdt
        {
            get
            {
                return (int) this["skill_3_repeat_cdt"];
            }
            set
            {
                this["skill_3_repeat_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_3_shield_cdt
        {
            get
            {
                return (int) this["skill_3_shield_cdt"];
            }
            set
            {
                this["skill_3_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_3_shield_over_cdt
        {
            get
            {
                return (int) this["skill_3_shield_over_cdt"];
            }
            set
            {
                this["skill_3_shield_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_3_target_health_cdt
        {
            get
            {
                return (int) this["skill_3_target_health_cdt"];
            }
            set
            {
                this["skill_3_target_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_3_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_3_target_health_over_cdt"];
            }
            set
            {
                this["skill_3_target_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public int skill_3_target_shield_cdt
        {
            get
            {
                return (int) this["skill_3_target_shield_cdt"];
            }
            set
            {
                this["skill_3_target_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_3_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_3_target_shield_over_cdt"];
            }
            set
            {
                this["skill_3_target_shield_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int skill_4_charge
        {
            get
            {
                return (int) this["skill_4_charge"];
            }
            set
            {
                this["skill_4_charge"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_4_cooldown
        {
            get
            {
                return (int) this["skill_4_cooldown"];
            }
            set
            {
                this["skill_4_cooldown"] = value;
            }
        }

        [DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool skill_4_double_click
        {
            get
            {
                return (bool) this["skill_4_double_click"];
            }
            set
            {
                this["skill_4_double_click"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("False"), DebuggerNonUserCode]
        public bool skill_4_enabled
        {
            get
            {
                return (bool) this["skill_4_enabled"];
            }
            set
            {
                this["skill_4_enabled"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_4_health_cdt
        {
            get
            {
                return (int) this["skill_4_health_cdt"];
            }
            set
            {
                this["skill_4_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_4_health_over_cdt
        {
            get
            {
                return (int) this["skill_4_health_over_cdt"];
            }
            set
            {
                this["skill_4_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("False")]
        public bool skill_4_interrupt_enabled
        {
            get
            {
                return (bool) this["skill_4_interrupt_enabled"];
            }
            set
            {
                this["skill_4_interrupt_enabled"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_4_repeat_cdt
        {
            get
            {
                return (int) this["skill_4_repeat_cdt"];
            }
            set
            {
                this["skill_4_repeat_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int skill_4_shield_cdt
        {
            get
            {
                return (int) this["skill_4_shield_cdt"];
            }
            set
            {
                this["skill_4_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int skill_4_shield_over_cdt
        {
            get
            {
                return (int) this["skill_4_shield_over_cdt"];
            }
            set
            {
                this["skill_4_shield_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_4_target_health_cdt
        {
            get
            {
                return (int) this["skill_4_target_health_cdt"];
            }
            set
            {
                this["skill_4_target_health_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_4_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_4_target_health_over_cdt"];
            }
            set
            {
                this["skill_4_target_health_over_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_4_target_shield_cdt
        {
            get
            {
                return (int) this["skill_4_target_shield_cdt"];
            }
            set
            {
                this["skill_4_target_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
        public int skill_4_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_4_target_shield_over_cdt"];
            }
            set
            {
                this["skill_4_target_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
        public int skill_5_charge
        {
            get
            {
                return (int) this["skill_5_charge"];
            }
            set
            {
                this["skill_5_charge"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_5_cooldown
        {
            get
            {
                return (int) this["skill_5_cooldown"];
            }
            set
            {
                this["skill_5_cooldown"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("False")]
        public bool skill_5_double_click
        {
            get
            {
                return (bool) this["skill_5_double_click"];
            }
            set
            {
                this["skill_5_double_click"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("False")]
        public bool skill_5_enabled
        {
            get
            {
                return (bool) this["skill_5_enabled"];
            }
            set
            {
                this["skill_5_enabled"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_5_health_cdt
        {
            get
            {
                return (int) this["skill_5_health_cdt"];
            }
            set
            {
                this["skill_5_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_5_health_over_cdt
        {
            get
            {
                return (int) this["skill_5_health_over_cdt"];
            }
            set
            {
                this["skill_5_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting]
        public bool skill_5_interrupt_enabled
        {
            get
            {
                return (bool) this["skill_5_interrupt_enabled"];
            }
            set
            {
                this["skill_5_interrupt_enabled"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_5_repeat_cdt
        {
            get
            {
                return (int) this["skill_5_repeat_cdt"];
            }
            set
            {
                this["skill_5_repeat_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_5_shield_cdt
        {
            get
            {
                return (int) this["skill_5_shield_cdt"];
            }
            set
            {
                this["skill_5_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0")]
        public int skill_5_shield_over_cdt
        {
            get
            {
                return (int) this["skill_5_shield_over_cdt"];
            }
            set
            {
                this["skill_5_shield_over_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_5_target_health_cdt
        {
            get
            {
                return (int) this["skill_5_target_health_cdt"];
            }
            set
            {
                this["skill_5_target_health_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0")]
        public int skill_5_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_5_target_health_over_cdt"];
            }
            set
            {
                this["skill_5_target_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode]
        public int skill_5_target_shield_cdt
        {
            get
            {
                return (int) this["skill_5_target_shield_cdt"];
            }
            set
            {
                this["skill_5_target_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0")]
        public int skill_5_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_5_target_shield_over_cdt"];
            }
            set
            {
                this["skill_5_target_shield_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int skill_6_charge
        {
            get
            {
                return (int) this["skill_6_charge"];
            }
            set
            {
                this["skill_6_charge"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_6_cooldown
        {
            get
            {
                return (int) this["skill_6_cooldown"];
            }
            set
            {
                this["skill_6_cooldown"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool skill_6_double_click
        {
            get
            {
                return (bool) this["skill_6_double_click"];
            }
            set
            {
                this["skill_6_double_click"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
        public bool skill_6_enabled
        {
            get
            {
                return (bool) this["skill_6_enabled"];
            }
            set
            {
                this["skill_6_enabled"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_6_health_cdt
        {
            get
            {
                return (int) this["skill_6_health_cdt"];
            }
            set
            {
                this["skill_6_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int skill_6_health_over_cdt
        {
            get
            {
                return (int) this["skill_6_health_over_cdt"];
            }
            set
            {
                this["skill_6_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public bool skill_6_interrupt_enabled
        {
            get
            {
                return (bool) this["skill_6_interrupt_enabled"];
            }
            set
            {
                this["skill_6_interrupt_enabled"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_6_repeat_cdt
        {
            get
            {
                return (int) this["skill_6_repeat_cdt"];
            }
            set
            {
                this["skill_6_repeat_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int skill_6_shield_cdt
        {
            get
            {
                return (int) this["skill_6_shield_cdt"];
            }
            set
            {
                this["skill_6_shield_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_6_shield_over_cdt
        {
            get
            {
                return (int) this["skill_6_shield_over_cdt"];
            }
            set
            {
                this["skill_6_shield_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_6_target_health_cdt
        {
            get
            {
                return (int) this["skill_6_target_health_cdt"];
            }
            set
            {
                this["skill_6_target_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_6_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_6_target_health_over_cdt"];
            }
            set
            {
                this["skill_6_target_health_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int skill_6_target_shield_cdt
        {
            get
            {
                return (int) this["skill_6_target_shield_cdt"];
            }
            set
            {
                this["skill_6_target_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_6_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_6_target_shield_over_cdt"];
            }
            set
            {
                this["skill_6_target_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0")]
        public int skill_7_charge
        {
            get
            {
                return (int) this["skill_7_charge"];
            }
            set
            {
                this["skill_7_charge"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_7_cooldown
        {
            get
            {
                return (int) this["skill_7_cooldown"];
            }
            set
            {
                this["skill_7_cooldown"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public bool skill_7_double_click
        {
            get
            {
                return (bool) this["skill_7_double_click"];
            }
            set
            {
                this["skill_7_double_click"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool skill_7_enabled
        {
            get
            {
                return (bool) this["skill_7_enabled"];
            }
            set
            {
                this["skill_7_enabled"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int skill_7_health_cdt
        {
            get
            {
                return (int) this["skill_7_health_cdt"];
            }
            set
            {
                this["skill_7_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting]
        public int skill_7_health_over_cdt
        {
            get
            {
                return (int) this["skill_7_health_over_cdt"];
            }
            set
            {
                this["skill_7_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("False"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public bool skill_7_interrupt_enabled
        {
            get
            {
                return (bool) this["skill_7_interrupt_enabled"];
            }
            set
            {
                this["skill_7_interrupt_enabled"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting]
        public int skill_7_repeat_cdt
        {
            get
            {
                return (int) this["skill_7_repeat_cdt"];
            }
            set
            {
                this["skill_7_repeat_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_7_shield_cdt
        {
            get
            {
                return (int) this["skill_7_shield_cdt"];
            }
            set
            {
                this["skill_7_shield_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting]
        public int skill_7_shield_over_cdt
        {
            get
            {
                return (int) this["skill_7_shield_over_cdt"];
            }
            set
            {
                this["skill_7_shield_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_7_target_health_cdt
        {
            get
            {
                return (int) this["skill_7_target_health_cdt"];
            }
            set
            {
                this["skill_7_target_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int skill_7_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_7_target_health_over_cdt"];
            }
            set
            {
                this["skill_7_target_health_over_cdt"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int skill_7_target_shield_cdt
        {
            get
            {
                return (int) this["skill_7_target_shield_cdt"];
            }
            set
            {
                this["skill_7_target_shield_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_7_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_7_target_shield_over_cdt"];
            }
            set
            {
                this["skill_7_target_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_8_charge
        {
            get
            {
                return (int) this["skill_8_charge"];
            }
            set
            {
                this["skill_8_charge"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_8_cooldown
        {
            get
            {
                return (int) this["skill_8_cooldown"];
            }
            set
            {
                this["skill_8_cooldown"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("False")]
        public bool skill_8_double_click
        {
            get
            {
                return (bool) this["skill_8_double_click"];
            }
            set
            {
                this["skill_8_double_click"] = value;
            }
        }

        [DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool skill_8_enabled
        {
            get
            {
                return (bool) this["skill_8_enabled"];
            }
            set
            {
                this["skill_8_enabled"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_8_health_cdt
        {
            get
            {
                return (int) this["skill_8_health_cdt"];
            }
            set
            {
                this["skill_8_health_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_8_health_over_cdt
        {
            get
            {
                return (int) this["skill_8_health_over_cdt"];
            }
            set
            {
                this["skill_8_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool skill_8_interrupt_enabled
        {
            get
            {
                return (bool) this["skill_8_interrupt_enabled"];
            }
            set
            {
                this["skill_8_interrupt_enabled"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int skill_8_repeat_cdt
        {
            get
            {
                return (int) this["skill_8_repeat_cdt"];
            }
            set
            {
                this["skill_8_repeat_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting]
        public int skill_8_shield_cdt
        {
            get
            {
                return (int) this["skill_8_shield_cdt"];
            }
            set
            {
                this["skill_8_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_8_shield_over_cdt
        {
            get
            {
                return (int) this["skill_8_shield_over_cdt"];
            }
            set
            {
                this["skill_8_shield_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_8_target_health_cdt
        {
            get
            {
                return (int) this["skill_8_target_health_cdt"];
            }
            set
            {
                this["skill_8_target_health_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int skill_8_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_8_target_health_over_cdt"];
            }
            set
            {
                this["skill_8_target_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int skill_8_target_shield_cdt
        {
            get
            {
                return (int) this["skill_8_target_shield_cdt"];
            }
            set
            {
                this["skill_8_target_shield_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_8_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_8_target_shield_over_cdt"];
            }
            set
            {
                this["skill_8_target_shield_over_cdt"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_9_charge
        {
            get
            {
                return (int) this["skill_9_charge"];
            }
            set
            {
                this["skill_9_charge"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0")]
        public int skill_9_cooldown
        {
            get
            {
                return (int) this["skill_9_cooldown"];
            }
            set
            {
                this["skill_9_cooldown"] = value;
            }
        }

        [DefaultSettingValue("False"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public bool skill_9_double_click
        {
            get
            {
                return (bool) this["skill_9_double_click"];
            }
            set
            {
                this["skill_9_double_click"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("False"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public bool skill_9_enabled
        {
            get
            {
                return (bool) this["skill_9_enabled"];
            }
            set
            {
                this["skill_9_enabled"] = value;
            }
        }

        [DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0"), UserScopedSetting]
        public int skill_9_health_over_cdt
        {
            get
            {
                return (int) this["skill_9_health_over_cdt"];
            }
            set
            {
                this["skill_9_health_over_cdt"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_9_shield_over_cdt
        {
            get
            {
                return (int) this["skill_9_shield_over_cdt"];
            }
            set
            {
                this["skill_9_shield_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_9_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_9_target_health_over_cdt"];
            }
            set
            {
                this["skill_9_target_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("0")]
        public int skill_9_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_9_target_shield_over_cdt"];
            }
            set
            {
                this["skill_9_target_shield_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int skill_r_health_cdt
        {
            get
            {
                return (int) this["skill_r_health_cdt"];
            }
            set
            {
                this["skill_r_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_r_health_over_cdt
        {
            get
            {
                return (int) this["skill_r_health_over_cdt"];
            }
            set
            {
                this["skill_r_health_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int skill_r_shield_cdt
        {
            get
            {
                return (int) this["skill_r_shield_cdt"];
            }
            set
            {
                this["skill_r_shield_cdt"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), DefaultSettingValue("0")]
        public int skill_r_shield_over_cdt
        {
            get
            {
                return (int) this["skill_r_shield_over_cdt"];
            }
            set
            {
                this["skill_r_shield_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_r_target_health_cdt
        {
            get
            {
                return (int) this["skill_r_target_health_cdt"];
            }
            set
            {
                this["skill_r_target_health_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), DebuggerNonUserCode, UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider))]
        public int skill_r_target_health_over_cdt
        {
            get
            {
                return (int) this["skill_r_target_health_over_cdt"];
            }
            set
            {
                this["skill_r_target_health_over_cdt"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode]
        public int skill_r_target_shield_cdt
        {
            get
            {
                return (int) this["skill_r_target_shield_cdt"];
            }
            set
            {
                this["skill_r_target_shield_cdt"] = value;
            }
        }

        [DefaultSettingValue("0"), UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode]
        public int skill_r_target_shield_over_cdt
        {
            get
            {
                return (int) this["skill_r_target_shield_over_cdt"];
            }
            set
            {
                this["skill_r_target_shield_over_cdt"] = value;
            }
        }

        [DefaultSettingValue("5"), DebuggerNonUserCode, SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int start_after_min
        {
            get
            {
                return (int) this["start_after_min"];
            }
            set
            {
                this["start_after_min"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("5"), SettingsProvider(typeof(PortableSettingsProvider)), UserScopedSetting]
        public int stop_after_min
        {
            get
            {
                return (int) this["stop_after_min"];
            }
            set
            {
                this["stop_after_min"] = value;
            }
        }

        [UserScopedSetting, SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("6")]
        public int unstucking_attack_duration
        {
            get
            {
                return (int) this["unstucking_attack_duration"];
            }
            set
            {
                this["unstucking_attack_duration"] = value;
            }
        }

        [SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, DefaultSettingValue("4"), UserScopedSetting]
        public int unstucking_attack_time
        {
            get
            {
                return (int) this["unstucking_attack_time"];
            }
            set
            {
                this["unstucking_attack_time"] = value;
            }
        }

        [DefaultSettingValue("8"), SettingsProvider(typeof(PortableSettingsProvider)), DebuggerNonUserCode, UserScopedSetting]
        public int unstucking_run_time
        {
            get
            {
                return (int) this["unstucking_run_time"];
            }
            set
            {
                this["unstucking_run_time"] = value;
            }
        }
    }
}

