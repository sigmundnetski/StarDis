namespace BANANA
{
    using StarSpot.Properties;
    using System;
    using System.Threading;
    using System.Windows.Threading;

    internal class DEFMKWCASKDJTSTMDRZXZB
    {
        private DispatcherTimer BZJGBWLEJBZFAPJKMPASVZ = new DispatcherTimer();
        private GameUnit DDZZDONDCEDTIUBTDNWCHC = new GameUnit();
        public bool DSNDQZYYNUGZDPTXYKZZDI;
        private PHATKIWNEJAHCPLGWTOZCA EMGADYOHEYMHGXCKXWUKUB = new PHATKIWNEJAHCPLGWTOZCA();
        private DispatcherTimer FFNLLGDAJOFZOFLLVJFQTB = new DispatcherTimer();
        private ActorLocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new ActorLocalPlayer();
        private DispatcherTimer HLPUFJUBGBHPBNNJNEXJM = new DispatcherTimer();
        private DispatcherTimer JYOLBQGFVRJIGZBJOLMKYB = new DispatcherTimer();
        public static bool KXUQYOSXPFMYHZBJATVSBF = false;
        public static bool LWLSOEMVDKKELAEJZPPQFY = false;
        public static bool NUAQGVWGHLWNAXMITNRMPF = false;
        public bool ODRCPXSYKESSGNUDJFQAGM = true;
        public static bool PKIGHZIIJGLTBSZZWLHTCV = true;
        public static bool QFPMCOGRFREENNPJEVEFPO = false;
        private KMOSFDLBVXXDWCUTSQZTMN TDQFKKBLFSGUBGJJWAKCS = new KMOSFDLBVXXDWCUTSQZTMN();
        public static bool VKLACWJIUAVBQWDHBFTVUF = false;
        private OZEBCAKAWEASMSMTVJRPN WHOPLJOEEBJCLECKLBHGT = new OZEBCAKAWEASMSMTVJRPN();
        public static bool WNPWMLGYKHQHSHHHXNKUMP = false;
        private SLKKBFFDAKRGRBJQZVKHFF XSMIBJYHZEOOAKWIMDGPRA = new SLKKBFFDAKRGRBJQZVKHFF();
        private FMAMWYDCMCNGWDQJBXTDGZ YCXQNGZCSISSPZKPYRFYDZ = new FMAMWYDCMCNGWDQJBXTDGZ();
        private DispatcherTimer ZCALHKDIEMJDKDOICKKUTS = new DispatcherTimer();

        public void BDYICLRVCROPYECNTKRSDH()
        {
            if (this.ODRCPXSYKESSGNUDJFQAGM != Settings.Default.looting_option)
            {
                this.ODRCPXSYKESSGNUDJFQAGM = Settings.Default.looting_option;
            }
            this.JWVNPBUOBALDQMBNDJYIYJ();
            this.TURKHVIIELRVBIQAPELRME();
            this.HLPUFJUBGBHPBNNJNEXJM.Start();
            this.NPEDCWFDHTIZZQQXKUJSO();
        }

        public void DOLZTHMIGJLLRCAQXUXTF()
        {
            if ((this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L) && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L))
            {
                if (!this.DSNDQZYYNUGZDPTXYKZZDI)
                {
                    this.GWXVZWVXVPSQFZFFLVLSIH.GJQAQRZBQCAXVUZDFWJJFM((float) Settings.Default.attack_range);
                    this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ(GameUnit.ONPZXRHWXETUZXBQNIAQCL);
                    this.GWXVZWVXVPSQFZFFLVLSIH.MQKILWWCATKXVNGAHQUZOS(GameUnit.DLVQAUAAVHTGLNOOYRBMFB);
                    this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(2);
                    if (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)
                    {
                        this.GWXVZWVXVPSQFZFFLVLSIH.KILMFPGRIXVDEFXLYFTLRS(1);
                    }
                }
                if (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() == 2L)
                {
                    this.BZJGBWLEJBZFAPJKMPASVZ.Start();
                    this.JYOLBQGFVRJIGZBJOLMKYB.Start();
                }
            }
            this.WHOPLJOEEBJCLECKLBHGT.QPPYJVFTILCISPPDDXDFXA();
            this.EMGADYOHEYMHGXCKXWUKUB.QPPYJVFTILCISPPDDXDFXA();
            this.WHOPLJOEEBJCLECKLBHGT.QPPYJVFTILCISPPDDXDFXA();
        }

        private void DTFXVPJJKNHUHJFXOERMBQ(object sender, EventArgs e)
        {
            if ((GameUnit.ZHUTBUVBCLTXWBKMULGBOF != 0L) && (GameUnit.EGYLZWCJOSIDBHYEALERVR == 100L))
            {
                this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(uint.MaxValue);
                this.DSNDQZYYNUGZDPTXYKZZDI = true;
                this.ZCALHKDIEMJDKDOICKKUTS.Start();
                this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU(0);
                this.BZJGBWLEJBZFAPJKMPASVZ.Stop();
            }
            else
            {
                this.BZJGBWLEJBZFAPJKMPASVZ.Stop();
            }
        }

        private void GOEWDJCNUVRXYJRABUMDH(object sender, EventArgs e)
        {
            if (GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L)
            {
                if (GameUnit.BIZEEBSLGRCERWXUDAQYSL == 0L)
                {
                    this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU(0);
                }
                if (((GameUnit.ZHUTBUVBCLTXWBKMULGBOF != this.GWXVZWVXVPSQFZFFLVLSIH.RYKXCVKVYDQOMLEQTEFMHL()) && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)) && (GameUnit.YZVLPMFXZDWUSQJSRIAGWW == 20L))
                {
                    this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU(0);
                    this.DSNDQZYYNUGZDPTXYKZZDI = true;
                    this.ZCALHKDIEMJDKDOICKKUTS.Start();
                }
            }
        }

        public void GUSAVLPPDGIIHEIFIRRQLK()
        {
            if (this.GWXVZWVXVPSQFZFFLVLSIH.OHGHQFLLRZACAKIJGEHAUU() != 0L)
            {
                if (!WNPWMLGYKHQHSHHHXNKUMP && !LWLSOEMVDKKELAEJZPPQFY)
                {
                    if (((GameUnit.ZHUTBUVBCLTXWBKMULGBOF == 0L) && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)) | (KMOSFDLBVXXDWCUTSQZTMN.FDUUXKIXHIHSDNFZVTASCE && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)))
                    {
                        this.XSMIBJYHZEOOAKWIMDGPRA.GUSAVLPPDGIIHEIFIRRQLK();
                        if (!this.DSNDQZYYNUGZDPTXYKZZDI)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.APXSOQVWZDYUCXYRFPKD();
                        }
                    }
                    OZEBCAKAWEASMSMTVJRPN.UEABHWLKXUEHAKFSDTRKNX = 1;
                    PHATKIWNEJAHCPLGWTOZCA.UEABHWLKXUEHAKFSDTRKNX = 1;
                }
                else if (WNPWMLGYKHQHSHHHXNKUMP && !LWLSOEMVDKKELAEJZPPQFY)
                {
                    if (Settings.Default.enable_defending_after_death | Settings.Default.enable_tabbing_after_death)
                    {
                        if ((GameUnit.ZHUTBUVBCLTXWBKMULGBOF == 0L) && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L))
                        {
                            this.XSMIBJYHZEOOAKWIMDGPRA.OPUOYMJIVVANLNZRTPYXXB();
                            if (!this.DSNDQZYYNUGZDPTXYKZZDI && Settings.Default.enable_tabbing_after_death)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.APXSOQVWZDYUCXYRFPKD();
                            }
                        }
                    }
                    else
                    {
                        this.XSMIBJYHZEOOAKWIMDGPRA.OPUOYMJIVVANLNZRTPYXXB();
                    }
                    OZEBCAKAWEASMSMTVJRPN.UEABHWLKXUEHAKFSDTRKNX = 1;
                    PHATKIWNEJAHCPLGWTOZCA.UEABHWLKXUEHAKFSDTRKNX = 1;
                }
                else if ((LWLSOEMVDKKELAEJZPPQFY && !WNPWMLGYKHQHSHHHXNKUMP) && (((GameUnit.ZHUTBUVBCLTXWBKMULGBOF == 0L) && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)) | (KMOSFDLBVXXDWCUTSQZTMN.FDUUXKIXHIHSDNFZVTASCE && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L))))
                {
                    this.ZXBOSWVEDHKQCGRMKDSKIL();
                }
            }
        }

        public void healing()
        {
            if (Settings.Default.heal_until_100_enabled)
            {
                if (((this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ() < 0x62L) | (this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB() < 0x62L)) && Settings.Default.heal_until_100_key_using_enabled)
                {
                    this.WHOPLJOEEBJCLECKLBHGT.QPPYJVFTILCISPPDDXDFXA();
                }
                if ((this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ() >= 0x62L) && (this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB() >= 0x62L))
                {
                    PKIGHZIIJGLTBSZZWLHTCV = true;
                    NUAQGVWGHLWNAXMITNRMPF = false;
                    QFPMCOGRFREENNPJEVEFPO = false;
                    VKLACWJIUAVBQWDHBFTVUF = false;
                    KXUQYOSXPFMYHZBJATVSBF = false;
                }
                if (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 1L)
                {
                    PKIGHZIIJGLTBSZZWLHTCV = true;
                    NUAQGVWGHLWNAXMITNRMPF = false;
                    QFPMCOGRFREENNPJEVEFPO = false;
                    VKLACWJIUAVBQWDHBFTVUF = false;
                    KXUQYOSXPFMYHZBJATVSBF = false;
                }
            }
            else
            {
                PKIGHZIIJGLTBSZZWLHTCV = true;
                NUAQGVWGHLWNAXMITNRMPF = false;
                QFPMCOGRFREENNPJEVEFPO = false;
                VKLACWJIUAVBQWDHBFTVUF = false;
                KXUQYOSXPFMYHZBJATVSBF = false;
            }
        }

        private void IAQTUGNMQORCPNVDQPEYTU(object sender, EventArgs e)
        {
            LWLSOEMVDKKELAEJZPPQFY = true;
        }

        public void JWVNPBUOBALDQMBNDJYIYJ()
        {
            if (((this.GWXVZWVXVPSQFZFFLVLSIH.LWMTIHLOFFHPJIZSFWBKUT() != 2L) && !NUAQGVWGHLWNAXMITNRMPF) && !this.DSNDQZYYNUGZDPTXYKZZDI)
            {
                if (GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L)
                {
                    if (!KMOSFDLBVXXDWCUTSQZTMN.FDUUXKIXHIHSDNFZVTASCE && (((this.DDZZDONDCEDTIUBTDNWCHC.AQKYUPTNOSBCOSRWJVDVGR == 0L) | (this.DDZZDONDCEDTIUBTDNWCHC.AQKYUPTNOSBCOSRWJVDVGR == this.GWXVZWVXVPSQFZFFLVLSIH.RYKXCVKVYDQOMLEQTEFMHL())) | (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() != 0L)))
                    {
                        BotMain.WBPDVOTSWETWJCQGKKDRNL = "Attacking: " + Offsets.VALBRDGGameUnitVRRXOCN.ToString() + " " + Offsets.QZBOLIKGameUnitBPCAFVSH + ".";
                        if (!NUAQGVWGHLWNAXMITNRMPF)
                        {
                            this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(uint.MaxValue);
                        }
                        NUAQGVWGHLWNAXMITNRMPF = true;
                        QFPMCOGRFREENNPJEVEFPO = false;
                        KXUQYOSXPFMYHZBJATVSBF = false;
                        PKIGHZIIJGLTBSZZWLHTCV = false;
                        SLKKBFFDAKRGRBJQZVKHFF.ZCALHKDIEMJDKDOICKKUTS.Stop();
                        SLKKBFFDAKRGRBJQZVKHFF.GSIMAEELGXXOPVXTROTLPI = false;
                    }
                    else
                    {
                        this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU(0);
                        KXUQYOSXPFMYHZBJATVSBF = true;
                        QFPMCOGRFREENNPJEVEFPO = false;
                        NUAQGVWGHLWNAXMITNRMPF = false;
                        PKIGHZIIJGLTBSZZWLHTCV = false;
                    }
                }
            }
            else if ((this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L) && NUAQGVWGHLWNAXMITNRMPF)
            {
                if (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() == 0L)
                {
                    BotMain.WBPDVOTSWETWJCQGKKDRNL = "Target is dead or lost. \nLooting if enabled.";
                    KXUQYOSXPFMYHZBJATVSBF = true;
                    QFPMCOGRFREENNPJEVEFPO = false;
                    NUAQGVWGHLWNAXMITNRMPF = false;
                    PKIGHZIIJGLTBSZZWLHTCV = false;
                }
            }
            else if (QFPMCOGRFREENNPJEVEFPO && !NUAQGVWGHLWNAXMITNRMPF)
            {
                KXUQYOSXPFMYHZBJATVSBF = false;
                NUAQGVWGHLWNAXMITNRMPF = false;
                PKIGHZIIJGLTBSZZWLHTCV = false;
            }
            else if (PKIGHZIIJGLTBSZZWLHTCV | this.DSNDQZYYNUGZDPTXYKZZDI)
            {
                PHATKIWNEJAHCPLGWTOZCA.UEABHWLKXUEHAKFSDTRKNX = 1;
                NUAQGVWGHLWNAXMITNRMPF = false;
                QFPMCOGRFREENNPJEVEFPO = false;
                KXUQYOSXPFMYHZBJATVSBF = false;
                PKIGHZIIJGLTBSZZWLHTCV = true;
            }
            if (QFPMCOGRFREENNPJEVEFPO)
            {
                this.NLMFDQTLGBAEUAUROAZNJG();
            }
            if (VKLACWJIUAVBQWDHBFTVUF)
            {
                this.healing();
            }
            if (NUAQGVWGHLWNAXMITNRMPF)
            {
                this.DOLZTHMIGJLLRCAQXUXTF();
            }
            if (KXUQYOSXPFMYHZBJATVSBF)
            {
                this.looting();
            }
            if (PKIGHZIIJGLTBSZZWLHTCV)
            {
                this.YCXQNGZCSISSPZKPYRFYDZ.QFYYIPFSSERDWPIITSLDVC();
                this.NYBDWKSNOHZGQJLFJQOINP();
                if ((((this.GWXVZWVXVPSQFZFFLVLSIH.RTHVVSJJZDRKYAZEIYZNWH() == this.YCXQNGZCSISSPZKPYRFYDZ.RTHVVSJJZDRKYAZEIYZNWH) && Settings.Default.bot_1_use) | ((this.GWXVZWVXVPSQFZFFLVLSIH.RTHVVSJJZDRKYAZEIYZNWH() == this.YCXQNGZCSISSPZKPYRFYDZ.RTHVVSJJZDRKYAZEIYZNWH) && Settings.Default.bot_2_use)) | (!Settings.Default.bot_1_use && !Settings.Default.bot_2_use))
                {
                    this.GUSAVLPPDGIIHEIFIRRQLK();
                }
            }
        }

        public void looting()
        {
            if (Settings.Default.looting_option)
            {
                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WSSIRONEHRSOGRVFLQXAV();
                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WSSIRONEHRSOGRVFLQXAV();
                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WSSIRONEHRSOGRVFLQXAV();
            }
            this.XSMIBJYHZEOOAKWIMDGPRA.QGGEKJHLBKLILDXDSCKVXV();
            QFPMCOGRFREENNPJEVEFPO = true;
        }

        public void NLMFDQTLGBAEUAUROAZNJG()
        {
            this.WHOPLJOEEBJCLECKLBHGT.QPPYJVFTILCISPPDDXDFXA();
            VKLACWJIUAVBQWDHBFTVUF = true;
            NUAQGVWGHLWNAXMITNRMPF = false;
            QFPMCOGRFREENNPJEVEFPO = false;
            KXUQYOSXPFMYHZBJATVSBF = false;
            PKIGHZIIJGLTBSZZWLHTCV = false;
        }

        public void NPEDCWFDHTIZZQQXKUJSO()
        {
            if (this.GWXVZWVXVPSQFZFFLVLSIH.OHGHQFLLRZACAKIJGEHAUU() == 0L)
            {
                this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU(0);
                PKIGHZIIJGLTBSZZWLHTCV = true;
                NUAQGVWGHLWNAXMITNRMPF = false;
                QFPMCOGRFREENNPJEVEFPO = false;
                KXUQYOSXPFMYHZBJATVSBF = false;
                LWLSOEMVDKKELAEJZPPQFY = false;
                WNPWMLGYKHQHSHHHXNKUMP = true;
                Thread.Sleep(0x1b58);
                for (int i = 0; i < 5; i++)
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.HXXZOYIOZDECXYIIEDJKIP();
                    if ((i > 4) && (this.GWXVZWVXVPSQFZFFLVLSIH.OHGHQFLLRZACAKIJGEHAUU() != 0L))
                    {
                        break;
                    }
                    if ((i > 4) && (this.GWXVZWVXVPSQFZFFLVLSIH.OHGHQFLLRZACAKIJGEHAUU() == 0L))
                    {
                        i = 0;
                    }
                }
                try
                {
                    SLKKBFFDAKRGRBJQZVKHFF.KNCIKWEVSMLSIXYJRQASQQ = 0;
                    this.XSMIBJYHZEOOAKWIMDGPRA.UATKIFPAZKGZUCDULJTFNJ = false;
                    SLKKBFFDAKRGRBJQZVKHFF.MVCSXPGFDQBHOQBXDMXFR = true;
                    SLKKBFFDAKRGRBJQZVKHFF.ZYNCBDIDDYVTAKJKINNDEJ = true;
                    SLKKBFFDAKRGRBJQZVKHFF.ZLISEWVYURKJXFHPRKHKMT = 0;
                    SLKKBFFDAKRGRBJQZVKHFF.HVYZELUVDLIWVWHJCMMBA = SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR[0];
                }
                catch
                {
                    BotMain.WBPDVOTSWETWJCQGKKDRNL = "No death spots available. Stop bot.";
                    BotMain.DRXRHEKXFLYMYDNVRSXPZM = false;
                }
            }
        }

        public void NYBDWKSNOHZGQJLFJQOINP()
        {
            if (this.JYOLBQGFVRJIGZBJOLMKYB.Interval.Seconds != Settings.Default.unstucking_attack_time)
            {
                this.JYOLBQGFVRJIGZBJOLMKYB.Interval = new TimeSpan(0, 0, Settings.Default.unstucking_attack_time);
            }
            if (this.BZJGBWLEJBZFAPJKMPASVZ.Interval.Seconds != 0x12)
            {
                this.BZJGBWLEJBZFAPJKMPASVZ.Interval = new TimeSpan(0, 0, 0x12);
            }
            this.JYOLBQGFVRJIGZBJOLMKYB.Stop();
            this.BZJGBWLEJBZFAPJKMPASVZ.Stop();
        }

        private void OCEWTBFKGMPBXWMTGCUUIZ(object sender, EventArgs e)
        {
            this.DSNDQZYYNUGZDPTXYKZZDI = false;
        }

        public void TURKHVIIELRVBIQAPELRME()
        {
            this.ZCALHKDIEMJDKDOICKKUTS.Tick += new EventHandler(this.OCEWTBFKGMPBXWMTGCUUIZ);
            if (this.ZCALHKDIEMJDKDOICKKUTS.Interval.TotalSeconds != Settings.Default.unstucking_attack_duration)
            {
                this.ZCALHKDIEMJDKDOICKKUTS.Interval = new TimeSpan(0, 0, Settings.Default.unstucking_attack_duration);
            }
            this.BZJGBWLEJBZFAPJKMPASVZ.Tick += new EventHandler(this.DTFXVPJJKNHUHJFXOERMBQ);
            if (this.BZJGBWLEJBZFAPJKMPASVZ.Interval.TotalSeconds != 18.0)
            {
                this.BZJGBWLEJBZFAPJKMPASVZ.Interval = new TimeSpan(0, 0, 0x12);
            }
            this.JYOLBQGFVRJIGZBJOLMKYB.Tick += new EventHandler(this.VXJDWBFKEWWVZIYVWSMWAD);
            if (this.JYOLBQGFVRJIGZBJOLMKYB.Interval.TotalSeconds != Settings.Default.unstucking_attack_time)
            {
                this.JYOLBQGFVRJIGZBJOLMKYB.Interval = new TimeSpan(0, 0, Settings.Default.unstucking_attack_time);
            }
            if (!this.DSNDQZYYNUGZDPTXYKZZDI)
            {
                this.ZCALHKDIEMJDKDOICKKUTS.Stop();
            }
            this.EMGADYOHEYMHGXCKXWUKUB.MAMWQNQIFABHMLRRUKMCA();
            if (this.HLPUFJUBGBHPBNNJNEXJM.Interval.Milliseconds != 100)
            {
                this.HLPUFJUBGBHPBNNJNEXJM.Interval = new TimeSpan(0, 0, 0, 0, 100);
            }
            this.HLPUFJUBGBHPBNNJNEXJM.Tick += new EventHandler(this.GOEWDJCNUVRXYJRABUMDH);
            this.WHOPLJOEEBJCLECKLBHGT.MAMWQNQIFABHMLRRUKMCA();
            this.FFNLLGDAJOFZOFLLVJFQTB.Tick += new EventHandler(this.IAQTUGNMQORCPNVDQPEYTU);
            if (Settings.Default.autoselling_enabled)
            {
                if (this.FFNLLGDAJOFZOFLLVJFQTB.Interval.Minutes != Settings.Default.autoselling_timer)
                {
                    this.FFNLLGDAJOFZOFLLVJFQTB.Interval = new TimeSpan(0, Settings.Default.autoselling_timer, 0);
                }
                this.FFNLLGDAJOFZOFLLVJFQTB.Start();
            }
        }

        private void VXJDWBFKEWWVZIYVWSMWAD(object sender, EventArgs e)
        {
            if (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)
            {
                this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(uint.MaxValue);
                this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU(0);
                this.DSNDQZYYNUGZDPTXYKZZDI = true;
                this.ZCALHKDIEMJDKDOICKKUTS.Start();
                this.JYOLBQGFVRJIGZBJOLMKYB.Stop();
            }
            else
            {
                this.JYOLBQGFVRJIGZBJOLMKYB.Stop();
            }
        }

        public void ZXBOSWVEDHKQCGRMKDSKIL()
        {
            if (SLKKBFFDAKRGRBJQZVKHFF.ZLISEWVYURKJXFHPRKHKMT != 0)
            {
                if (((GameUnit.ZHUTBUVBCLTXWBKMULGBOF == 0L) && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)) | (KMOSFDLBVXXDWCUTSQZTMN.FDUUXKIXHIHSDNFZVTASCE && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)))
                {
                    this.XSMIBJYHZEOOAKWIMDGPRA.GUSAVLPPDGIIHEIFIRRQLK();
                    if (!this.DSNDQZYYNUGZDPTXYKZZDI)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.APXSOQVWZDYUCXYRFPKD();
                    }
                }
                OZEBCAKAWEASMSMTVJRPN.UEABHWLKXUEHAKFSDTRKNX = 1;
                PHATKIWNEJAHCPLGWTOZCA.UEABHWLKXUEHAKFSDTRKNX = 1;
            }
            else if (SLKKBFFDAKRGRBJQZVKHFF.ZLISEWVYURKJXFHPRKHKMT == 0)
            {
                this.XSMIBJYHZEOOAKWIMDGPRA.KIMJMCIIIFLQNAWTKNIFEK();
            }
            if (SLKKBFFDAKRGRBJQZVKHFF.DKQOMDXWTAEOEPKGOCNCBN)
            {
                LWLSOEMVDKKELAEJZPPQFY = false;
                try
                {
                    SLKKBFFDAKRGRBJQZVKHFF.DKQOMDXWTAEOEPKGOCNCBN = false;
                    SLKKBFFDAKRGRBJQZVKHFF.XBCQHTMOZWYKVCIDVHXXJL = 0;
                    SLKKBFFDAKRGRBJQZVKHFF.KDMPKSEVQRRXMDWFLEKKKO = SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH[0];
                }
                catch
                {
                }
            }
        }
    }
}

