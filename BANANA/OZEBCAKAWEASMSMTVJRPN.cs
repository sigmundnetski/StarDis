namespace BANANA
{
    using StarSpot.Properties;
    using System;
    using System.Threading;
    using System.Windows.Threading;

    internal class OZEBCAKAWEASMSMTVJRPN
    {
        private bool AIAYIUCANLMNKGKFCHUXHA = true;
        private bool AIZBITLQYIFXAFQUYDCWW = true;
        private DispatcherTimer DHIODCVTHRZRSEUDDZTLWR = new DispatcherTimer();
        private DispatcherTimer DKFYGTUSPSFUPBURNOTWFC = new DispatcherTimer();
        private ActorLocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new ActorLocalPlayer();
        private bool HJDBDGUKQLVSHYQHAQTHNY = true;
        private DispatcherTimer HUSKAMLTXRVMVQQLUPYXVG = new DispatcherTimer();
        private DispatcherTimer LULJSMFFWNWCEJNJFKWAOL = new DispatcherTimer();
        private bool MBJFNYSZHMEPVHCVGBDWGS = true;
        private bool MLBKRTBHJBAIJVFIOMVVBJ = true;
        private bool NQAOXJQUALKPWRSOWJZVDX = true;
        public static bool NRWGLEVGYVZVNABVMPJZBZ = true;
        private DispatcherTimer PSXCBCEEGAUKSOEZTUJHK = new DispatcherTimer();
        private DispatcherTimer QZJMYRXJMIJXJOWVAFVPTI = new DispatcherTimer();
        private DispatcherTimer SMHSRXYGJCRREXQEFVURAR = new DispatcherTimer();
        private DispatcherTimer TPPBERNOQSBFQUZHMYQPRE = new DispatcherTimer();
        private bool TTPKKCIMGWENMDPTGCOXRT = true;
        private DispatcherTimer UAPGDIWCQCYZIAUCBICUOO = new DispatcherTimer();
        public static int UEABHWLKXUEHAKFSDTRKNX = 1;
        private DispatcherTimer UQBHXIPGYJLUXIUVLKKQPZ = new DispatcherTimer();
        public static bool VMVYRGQPWOQYETBCUWTVC = true;
        private bool XGEUZYLYWVFWGRHUCKDLM = true;

        public OZEBCAKAWEASMSMTVJRPN()
        {
            this.DHIODCVTHRZRSEUDDZTLWR.Tick += new EventHandler(this.ACLZRJHVIDSMFRHONFONWW);
            this.SMHSRXYGJCRREXQEFVURAR.Tick += new EventHandler(this.XLKLGWJCNSEMFJIHAKNAN);
            this.DKFYGTUSPSFUPBURNOTWFC.Tick += new EventHandler(this.OTJVWKRRMGVRVKKJMFBEOO);
            this.UQBHXIPGYJLUXIUVLKKQPZ.Tick += new EventHandler(this.NXFQEWRHCAOUUJNIQWSPPI);
            this.HUSKAMLTXRVMVQQLUPYXVG.Tick += new EventHandler(this.FNTNBHSRWGXVEBFVNMBSBK);
            this.TPPBERNOQSBFQUZHMYQPRE.Tick += new EventHandler(this.NLUCIUCSZOHXOFHVWDWLR);
            this.UAPGDIWCQCYZIAUCBICUOO.Tick += new EventHandler(this.IMSLHYIHOVDWFFECNKOIUU);
            this.LULJSMFFWNWCEJNJFKWAOL.Tick += new EventHandler(this.RVDUAUPUZWBXPPJYDBUVOW);
            this.QZJMYRXJMIJXJOWVAFVPTI.Tick += new EventHandler(this.UZRWQFVYJDNAYKVRWKARW);
            this.PSXCBCEEGAUKSOEZTUJHK.Tick += new EventHandler(this.NMKSGXHZYWJXJIIALLVJIP);
        }

        private void ACLZRJHVIDSMFRHONFONWW(object sender, EventArgs e)
        {
            VMVYRGQPWOQYETBCUWTVC = true;
        }

        private void FNTNBHSRWGXVEBFVNMBSBK(object sender, EventArgs e)
        {
            this.MBJFNYSZHMEPVHCVGBDWGS = true;
        }

        private void IMSLHYIHOVDWFFECNKOIUU(object sender, EventArgs e)
        {
            this.TTPKKCIMGWENMDPTGCOXRT = true;
        }

        public void MAMWQNQIFABHMLRRUKMCA()
        {
            if (this.DHIODCVTHRZRSEUDDZTLWR.Interval.TotalSeconds != Settings.Default.key_using_1_cooldown)
            {
                this.DHIODCVTHRZRSEUDDZTLWR.Interval = new TimeSpan(0, 0, Settings.Default.key_using_1_cooldown);
            }
            else if (Settings.Default.key_using_1_cooldown == 0)
            {
                Settings.Default.key_using_1_cooldown = 1;
            }
            if (!VMVYRGQPWOQYETBCUWTVC && (Settings.Default.key_using_1_key != ""))
            {
                this.DHIODCVTHRZRSEUDDZTLWR.Start();
            }
            else if (VMVYRGQPWOQYETBCUWTVC)
            {
                this.DHIODCVTHRZRSEUDDZTLWR.Stop();
            }
            if ((this.SMHSRXYGJCRREXQEFVURAR.Interval.TotalSeconds != Settings.Default.key_using_2_cooldown) && (Settings.Default.key_using_2_cooldown != 0))
            {
                this.SMHSRXYGJCRREXQEFVURAR.Interval = new TimeSpan(0, 0, Settings.Default.key_using_2_cooldown);
            }
            else if (Settings.Default.key_using_2_cooldown == 0)
            {
                Settings.Default.key_using_2_cooldown = 1;
            }
            if (!NRWGLEVGYVZVNABVMPJZBZ && (Settings.Default.key_using_2_key != ""))
            {
                this.SMHSRXYGJCRREXQEFVURAR.Start();
            }
            else if (NRWGLEVGYVZVNABVMPJZBZ)
            {
                this.SMHSRXYGJCRREXQEFVURAR.Stop();
            }
            if (this.DKFYGTUSPSFUPBURNOTWFC.Interval.TotalSeconds != Settings.Default.key_using_3_cooldown)
            {
                this.DKFYGTUSPSFUPBURNOTWFC.Interval = new TimeSpan(0, 0, Settings.Default.key_using_3_cooldown);
            }
            else if (Settings.Default.key_using_3_cooldown == 0)
            {
                Settings.Default.key_using_3_cooldown = 1;
            }
            if (!this.AIZBITLQYIFXAFQUYDCWW && (Settings.Default.key_using_3_key != ""))
            {
                this.DKFYGTUSPSFUPBURNOTWFC.Start();
            }
            else if (this.AIZBITLQYIFXAFQUYDCWW)
            {
                this.DKFYGTUSPSFUPBURNOTWFC.Stop();
            }
            if (this.UQBHXIPGYJLUXIUVLKKQPZ.Interval.TotalSeconds != Settings.Default.key_using_4_cooldown)
            {
                this.UQBHXIPGYJLUXIUVLKKQPZ.Interval = new TimeSpan(0, 0, Settings.Default.key_using_4_cooldown);
            }
            else if (Settings.Default.key_using_4_cooldown == 0)
            {
                Settings.Default.key_using_4_cooldown = 1;
            }
            if (!this.MLBKRTBHJBAIJVFIOMVVBJ && (Settings.Default.key_using_4_key != ""))
            {
                this.UQBHXIPGYJLUXIUVLKKQPZ.Start();
            }
            else if (this.MLBKRTBHJBAIJVFIOMVVBJ)
            {
                this.UQBHXIPGYJLUXIUVLKKQPZ.Stop();
            }
            if (this.HUSKAMLTXRVMVQQLUPYXVG.Interval.TotalSeconds != Settings.Default.key_using_5_cooldown)
            {
                this.HUSKAMLTXRVMVQQLUPYXVG.Interval = new TimeSpan(0, 0, Settings.Default.key_using_5_cooldown);
            }
            else if (Settings.Default.key_using_5_cooldown == 0)
            {
                Settings.Default.key_using_5_cooldown = 1;
            }
            if (!this.MBJFNYSZHMEPVHCVGBDWGS && (Settings.Default.key_using_5_key != ""))
            {
                this.HUSKAMLTXRVMVQQLUPYXVG.Start();
            }
            else if (this.MBJFNYSZHMEPVHCVGBDWGS)
            {
                this.HUSKAMLTXRVMVQQLUPYXVG.Stop();
            }
            if (this.TPPBERNOQSBFQUZHMYQPRE.Interval.TotalSeconds != Settings.Default.key_using_6_cooldown)
            {
                this.TPPBERNOQSBFQUZHMYQPRE.Interval = new TimeSpan(0, 0, Settings.Default.key_using_6_cooldown);
            }
            else if (Settings.Default.key_using_6_cooldown == 0)
            {
                Settings.Default.key_using_6_cooldown = 1;
            }
            if (!this.XGEUZYLYWVFWGRHUCKDLM && (Settings.Default.key_using_6_key != ""))
            {
                this.TPPBERNOQSBFQUZHMYQPRE.Start();
            }
            else if (this.XGEUZYLYWVFWGRHUCKDLM)
            {
                this.TPPBERNOQSBFQUZHMYQPRE.Stop();
            }
            if (this.UAPGDIWCQCYZIAUCBICUOO.Interval.TotalSeconds != Settings.Default.key_using_7_cooldown)
            {
                this.UAPGDIWCQCYZIAUCBICUOO.Interval = new TimeSpan(0, 0, Settings.Default.key_using_7_cooldown);
            }
            else if (Settings.Default.key_using_7_cooldown == 0)
            {
                Settings.Default.key_using_7_cooldown = 1;
            }
            if (!this.TTPKKCIMGWENMDPTGCOXRT && (Settings.Default.key_using_7_key != ""))
            {
                this.UAPGDIWCQCYZIAUCBICUOO.Start();
            }
            else if (this.TTPKKCIMGWENMDPTGCOXRT)
            {
                this.UAPGDIWCQCYZIAUCBICUOO.Stop();
            }
            if (this.LULJSMFFWNWCEJNJFKWAOL.Interval.TotalSeconds != Settings.Default.key_using_8_cooldown)
            {
                this.LULJSMFFWNWCEJNJFKWAOL.Interval = new TimeSpan(0, 0, Settings.Default.key_using_8_cooldown);
            }
            else if (Settings.Default.key_using_8_cooldown == 0)
            {
                Settings.Default.key_using_8_cooldown = 1;
            }
            if (!this.NQAOXJQUALKPWRSOWJZVDX && (Settings.Default.key_using_8_key != ""))
            {
                this.LULJSMFFWNWCEJNJFKWAOL.Start();
            }
            else if (this.NQAOXJQUALKPWRSOWJZVDX)
            {
                this.LULJSMFFWNWCEJNJFKWAOL.Stop();
            }
            if (this.QZJMYRXJMIJXJOWVAFVPTI.Interval.TotalSeconds != Settings.Default.key_using_9_cooldown)
            {
                this.QZJMYRXJMIJXJOWVAFVPTI.Interval = new TimeSpan(0, 0, Settings.Default.key_using_9_cooldown);
            }
            else if (Settings.Default.key_using_9_cooldown == 0)
            {
                Settings.Default.key_using_9_cooldown = 1;
            }
            if (!this.HJDBDGUKQLVSHYQHAQTHNY && (Settings.Default.key_using_9_key != ""))
            {
                this.QZJMYRXJMIJXJOWVAFVPTI.Start();
            }
            else if (this.HJDBDGUKQLVSHYQHAQTHNY)
            {
                this.QZJMYRXJMIJXJOWVAFVPTI.Stop();
            }
            if (this.PSXCBCEEGAUKSOEZTUJHK.Interval.TotalSeconds != Settings.Default.key_using_10_cooldown)
            {
                this.PSXCBCEEGAUKSOEZTUJHK.Interval = new TimeSpan(0, 0, Settings.Default.key_using_10_cooldown);
            }
            else if (Settings.Default.key_using_10_cooldown == 0)
            {
                Settings.Default.key_using_10_cooldown = 1;
            }
            if (!this.AIAYIUCANLMNKGKFCHUXHA && (Settings.Default.key_using_10_key != ""))
            {
                this.PSXCBCEEGAUKSOEZTUJHK.Start();
            }
            else if (this.AIAYIUCANLMNKGKFCHUXHA)
            {
                this.PSXCBCEEGAUKSOEZTUJHK.Stop();
            }
        }

        private void NLUCIUCSZOHXOFHVWDWLR(object sender, EventArgs e)
        {
            this.XGEUZYLYWVFWGRHUCKDLM = true;
        }

        private void NMKSGXHZYWJXJIIALLVJIP(object sender, EventArgs e)
        {
            this.AIAYIUCANLMNKGKFCHUXHA = true;
        }

        private void NXFQEWRHCAOUUJNIQWSPPI(object sender, EventArgs e)
        {
            this.MLBKRTBHJBAIJVFIOMVVBJ = true;
        }

        private void OTJVWKRRMGVRVKKJMFBEOO(object sender, EventArgs e)
        {
            this.AIZBITLQYIFXAFQUYDCWW = true;
        }

        public void QPPYJVFTILCISPPDDXDFXA()
        {
            if (DEFMKWCASKDJTSTMDRZXZB.NUAQGVWGHLWNAXMITNRMPF && (((((((((Settings.Default.key_using_1_infight | Settings.Default.key_using_2_infight) | Settings.Default.key_using_3_infight) | Settings.Default.key_using_4_infight) | Settings.Default.key_using_5_infight) | Settings.Default.key_using_6_infight) | Settings.Default.key_using_7_infight) | Settings.Default.key_using_8_infight) | Settings.Default.key_using_9_infight) | Settings.Default.key_using_10_infight))
            {
                if ((this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L) && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 1L))
                {
                    if (((Settings.Default.key_using_1_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 1)) && Settings.Default.key_using_1_infight)
                    {
                        if ((((VMVYRGQPWOQYETBCUWTVC && (Settings.Default.key_using_1_health_cdt == 0)) && ((Settings.Default.key_using_1_shield_cdt == 0) && (Settings.Default.key_using_1_target_health_cdt == 0))) && (((Settings.Default.key_using_1_target_shield_cdt == 0) && (Settings.Default.key_using_1_health_over_cdt == 0)) && ((Settings.Default.key_using_1_shield_over_cdt == 0) && (Settings.Default.key_using_1_target_health_over_cdt == 0)))) && (Settings.Default.key_using_1_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_1_key);
                            Thread.Sleep((int) (Settings.Default.key_using_1_ct + 500));
                            VMVYRGQPWOQYETBCUWTVC = false;
                        }
                        else if (VMVYRGQPWOQYETBCUWTVC && ((((((((Settings.Default.key_using_1_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_1_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_1_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_1_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_1_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_1_health_over_cdt != 0))) | ((Settings.Default.key_using_1_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_1_shield_over_cdt != 0))) | ((Settings.Default.key_using_1_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.key_using_1_target_health_over_cdt != 0))) | ((Settings.Default.key_using_1_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_1_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_1_key);
                            Thread.Sleep((int) (Settings.Default.key_using_1_ct + 500));
                            VMVYRGQPWOQYETBCUWTVC = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 2;
                        }
                    }
                    else if (((Settings.Default.key_using_1_key == "") | !Settings.Default.key_using_1_infight) && (UEABHWLKXUEHAKFSDTRKNX == 1))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 2;
                    }
                    if (((Settings.Default.key_using_2_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 2)) && Settings.Default.key_using_2_infight)
                    {
                        if ((((NRWGLEVGYVZVNABVMPJZBZ && (Settings.Default.key_using_2_health_cdt == 0)) && ((Settings.Default.key_using_2_shield_cdt == 0) && (Settings.Default.key_using_2_target_health_cdt == 0))) && (((Settings.Default.key_using_2_target_shield_cdt == 0) && (Settings.Default.key_using_2_health_over_cdt == 0)) && ((Settings.Default.key_using_2_shield_over_cdt == 0) && (Settings.Default.key_using_2_target_health_over_cdt == 0)))) && (Settings.Default.key_using_2_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_2_key);
                            Thread.Sleep((int) (Settings.Default.key_using_2_ct + 500));
                            NRWGLEVGYVZVNABVMPJZBZ = false;
                        }
                        else if (NRWGLEVGYVZVNABVMPJZBZ && ((((((((Settings.Default.key_using_2_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_2_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_2_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_2_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_2_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_2_health_over_cdt != 0))) | ((Settings.Default.key_using_2_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_2_shield_over_cdt != 0))) | ((Settings.Default.key_using_2_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.key_using_2_target_health_over_cdt != 0))) | ((Settings.Default.key_using_2_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_2_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_2_key);
                            Thread.Sleep((int) (Settings.Default.key_using_2_ct + 500));
                            NRWGLEVGYVZVNABVMPJZBZ = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 3;
                        }
                    }
                    else if (((Settings.Default.key_using_2_key == "") | !Settings.Default.key_using_2_infight) && (UEABHWLKXUEHAKFSDTRKNX == 2))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 3;
                    }
                    if (((Settings.Default.key_using_3_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 3)) && Settings.Default.key_using_3_infight)
                    {
                        if ((((this.AIZBITLQYIFXAFQUYDCWW && (Settings.Default.key_using_3_health_cdt == 0)) && ((Settings.Default.key_using_3_shield_cdt == 0) && (Settings.Default.key_using_3_target_health_cdt == 0))) && (((Settings.Default.key_using_3_target_shield_cdt == 0) && (Settings.Default.key_using_3_health_over_cdt == 0)) && ((Settings.Default.key_using_3_shield_over_cdt == 0) && (Settings.Default.key_using_3_target_health_over_cdt == 0f)))) && (Settings.Default.key_using_3_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_3_key);
                            Thread.Sleep((int) (Settings.Default.key_using_3_ct + 500));
                            this.AIZBITLQYIFXAFQUYDCWW = false;
                        }
                        else if (this.AIZBITLQYIFXAFQUYDCWW && ((((((((Settings.Default.key_using_3_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_3_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_3_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_3_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_3_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_3_health_over_cdt != 0))) | ((Settings.Default.key_using_3_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_3_shield_over_cdt != 0))) | ((Settings.Default.key_using_3_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && !(Settings.Default.key_using_3_target_health_over_cdt == 0f))) | ((Settings.Default.key_using_3_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_3_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_3_key);
                            Thread.Sleep((int) (Settings.Default.key_using_3_ct + 500));
                            this.AIZBITLQYIFXAFQUYDCWW = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 4;
                        }
                    }
                    else if (((Settings.Default.key_using_3_key == "") | !Settings.Default.key_using_3_infight) && (UEABHWLKXUEHAKFSDTRKNX == 3))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 4;
                    }
                    if (((Settings.Default.key_using_4_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 4)) && Settings.Default.key_using_4_infight)
                    {
                        if ((((this.MLBKRTBHJBAIJVFIOMVVBJ && (Settings.Default.key_using_4_health_cdt == 0)) && ((Settings.Default.key_using_4_shield_cdt == 0) && (Settings.Default.key_using_4_target_health_cdt == 0))) && (((Settings.Default.key_using_4_target_shield_cdt == 0) && (Settings.Default.key_using_4_health_over_cdt == 0)) && ((Settings.Default.key_using_4_shield_over_cdt == 0) && (Settings.Default.key_using_4_target_health_over_cdt == 0)))) && (Settings.Default.key_using_4_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_4_key);
                            Thread.Sleep((int) (Settings.Default.key_using_4_ct + 500));
                            this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                        }
                        else if (this.MLBKRTBHJBAIJVFIOMVVBJ && ((((((((Settings.Default.key_using_4_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_4_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_4_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_4_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_4_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_4_health_over_cdt != 0))) | ((Settings.Default.key_using_4_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_4_shield_over_cdt != 0))) | ((Settings.Default.key_using_4_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.key_using_4_target_health_over_cdt != 0))) | ((Settings.Default.key_using_4_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_4_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_4_key);
                            Thread.Sleep((int) (Settings.Default.key_using_4_ct + 500));
                            this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 5;
                        }
                    }
                    else if (((Settings.Default.key_using_4_key == "") | !Settings.Default.key_using_4_infight) && (UEABHWLKXUEHAKFSDTRKNX == 4))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 5;
                    }
                    if (((Settings.Default.key_using_5_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 5)) && Settings.Default.key_using_5_infight)
                    {
                        if ((((this.MBJFNYSZHMEPVHCVGBDWGS && (Settings.Default.key_using_5_health_cdt == 0)) && ((Settings.Default.key_using_5_shield_cdt == 0) && (Settings.Default.key_using_5_target_health_cdt == 0))) && (((Settings.Default.key_using_5_target_shield_cdt == 0) && (Settings.Default.key_using_5_health_over_cdt == 0)) && ((Settings.Default.key_using_5_shield_over_cdt == 0) && (Settings.Default.key_using_5_target_health_over_cdt == 0)))) && (Settings.Default.key_using_5_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_5_key);
                            Thread.Sleep((int) (Settings.Default.key_using_5_ct + 500));
                            this.MBJFNYSZHMEPVHCVGBDWGS = false;
                        }
                        else if (this.MBJFNYSZHMEPVHCVGBDWGS && ((((((((Settings.Default.key_using_5_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_5_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_5_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_5_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_5_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_5_health_over_cdt != 0))) | ((Settings.Default.key_using_5_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_5_shield_over_cdt != 0))) | ((Settings.Default.key_using_5_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.key_using_5_target_health_over_cdt != 0))) | ((Settings.Default.key_using_5_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_5_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_5_key);
                            Thread.Sleep((int) (Settings.Default.key_using_5_ct + 500));
                            this.MBJFNYSZHMEPVHCVGBDWGS = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 6;
                        }
                    }
                    else if (((Settings.Default.key_using_5_key == "") | !Settings.Default.key_using_5_infight) && (UEABHWLKXUEHAKFSDTRKNX == 5))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 6;
                    }
                    if (((Settings.Default.key_using_6_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 6)) && Settings.Default.key_using_6_infight)
                    {
                        if ((((this.XGEUZYLYWVFWGRHUCKDLM && (Settings.Default.key_using_6_health_cdt == 0)) && ((Settings.Default.key_using_6_shield_cdt == 0) && (Settings.Default.key_using_6_target_health_cdt == 0))) && (((Settings.Default.key_using_6_target_shield_cdt == 0) && (Settings.Default.key_using_6_health_over_cdt == 0)) && ((Settings.Default.key_using_6_shield_over_cdt == 0) && (Settings.Default.key_using_6_target_health_over_cdt == 0)))) && (Settings.Default.key_using_6_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_6_key);
                            Thread.Sleep((int) (Settings.Default.key_using_6_ct + 500));
                            this.XGEUZYLYWVFWGRHUCKDLM = false;
                        }
                        else if (this.XGEUZYLYWVFWGRHUCKDLM && ((((((((Settings.Default.key_using_6_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_6_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_6_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_6_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_6_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_6_health_over_cdt != 0))) | ((Settings.Default.key_using_6_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_6_shield_over_cdt != 0))) | ((Settings.Default.key_using_6_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.key_using_6_target_health_over_cdt != 0))) | ((Settings.Default.key_using_6_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_6_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_6_key);
                            Thread.Sleep((int) (Settings.Default.key_using_6_ct + 500));
                            this.XGEUZYLYWVFWGRHUCKDLM = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 7;
                        }
                    }
                    else if (((Settings.Default.key_using_6_key == "") | !Settings.Default.key_using_6_infight) && (UEABHWLKXUEHAKFSDTRKNX == 6))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 7;
                    }
                    if (((Settings.Default.key_using_7_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 7)) && Settings.Default.key_using_7_infight)
                    {
                        if ((((this.TTPKKCIMGWENMDPTGCOXRT && (Settings.Default.key_using_7_health_cdt == 0)) && ((Settings.Default.key_using_7_shield_cdt == 0) && (Settings.Default.key_using_7_target_health_cdt == 0))) && (((Settings.Default.key_using_7_target_shield_cdt == 0) && (Settings.Default.key_using_7_health_over_cdt == 0)) && ((Settings.Default.key_using_7_shield_over_cdt == 0) && (Settings.Default.key_using_7_target_health_over_cdt == 0)))) && (Settings.Default.key_using_7_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_7_key);
                            Thread.Sleep((int) (Settings.Default.key_using_7_ct + 500));
                            this.TTPKKCIMGWENMDPTGCOXRT = false;
                        }
                        else if (this.TTPKKCIMGWENMDPTGCOXRT && ((((((((Settings.Default.key_using_7_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_7_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_7_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_7_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_7_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_7_health_over_cdt != 0))) | ((Settings.Default.key_using_7_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_7_shield_over_cdt != 0))) | ((Settings.Default.key_using_7_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.key_using_7_target_health_over_cdt != 0))) | ((Settings.Default.key_using_7_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_7_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_7_key);
                            Thread.Sleep((int) (Settings.Default.key_using_7_ct + 500));
                            this.TTPKKCIMGWENMDPTGCOXRT = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 8;
                        }
                    }
                    else if (((Settings.Default.key_using_7_key == "") | !Settings.Default.key_using_7_infight) && (UEABHWLKXUEHAKFSDTRKNX == 7))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 8;
                    }
                    if (((Settings.Default.key_using_8_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 8)) && Settings.Default.key_using_8_infight)
                    {
                        if ((((this.NQAOXJQUALKPWRSOWJZVDX && (Settings.Default.key_using_8_health_cdt == 0)) && ((Settings.Default.key_using_8_shield_cdt == 0) && (Settings.Default.key_using_8_target_health_cdt == 0))) && (((Settings.Default.key_using_8_target_shield_cdt == 0) && (Settings.Default.key_using_8_health_over_cdt == 0)) && ((Settings.Default.key_using_8_shield_over_cdt == 0) && (Settings.Default.key_using_8_target_health_over_cdt == 0)))) && (Settings.Default.key_using_8_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_8_key);
                            Thread.Sleep((int) (Settings.Default.key_using_8_ct + 500));
                            this.NQAOXJQUALKPWRSOWJZVDX = false;
                        }
                        else if (this.NQAOXJQUALKPWRSOWJZVDX && ((((((((Settings.Default.key_using_8_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_8_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_8_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_8_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_8_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_8_health_over_cdt != 0))) | ((Settings.Default.key_using_8_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_8_shield_over_cdt != 0))) | ((Settings.Default.key_using_8_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.key_using_8_target_health_over_cdt != 0))) | ((Settings.Default.key_using_8_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_8_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_8_key);
                            Thread.Sleep((int) (Settings.Default.key_using_8_ct + 500));
                            this.NQAOXJQUALKPWRSOWJZVDX = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 9;
                        }
                    }
                    else if (((Settings.Default.key_using_8_key == "") | !Settings.Default.key_using_8_infight) && (UEABHWLKXUEHAKFSDTRKNX == 8))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 9;
                    }
                    if (((Settings.Default.key_using_9_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 9)) && Settings.Default.key_using_9_infight)
                    {
                        if ((((this.HJDBDGUKQLVSHYQHAQTHNY && (Settings.Default.key_using_9_health_cdt == 0)) && ((Settings.Default.key_using_9_shield_cdt == 0) && (Settings.Default.key_using_9_target_health_cdt == 0))) && (((Settings.Default.key_using_9_target_shield_cdt == 0) && (Settings.Default.key_using_9_health_over_cdt == 0)) && ((Settings.Default.key_using_9_shield_over_cdt == 0) && (Settings.Default.key_using_9_target_health_over_cdt == 0)))) && (Settings.Default.key_using_9_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_9_key);
                            Thread.Sleep((int) (Settings.Default.key_using_9_ct + 500));
                            this.HJDBDGUKQLVSHYQHAQTHNY = false;
                        }
                        else if (this.HJDBDGUKQLVSHYQHAQTHNY && ((((((((Settings.Default.key_using_9_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_9_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_9_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_9_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_9_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_9_health_over_cdt != 0))) | ((Settings.Default.key_using_9_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_9_shield_over_cdt != 0))) | ((Settings.Default.key_using_9_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.key_using_9_target_health_over_cdt != 0))) | ((Settings.Default.key_using_9_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_9_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_9_key);
                            Thread.Sleep((int) (Settings.Default.key_using_9_ct + 500));
                            this.HJDBDGUKQLVSHYQHAQTHNY = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 10;
                        }
                    }
                    else if (((Settings.Default.key_using_9_key == "") | !Settings.Default.key_using_9_infight) && (UEABHWLKXUEHAKFSDTRKNX == 9))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 10;
                    }
                    if (((Settings.Default.key_using_10_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 10)) && Settings.Default.key_using_10_infight)
                    {
                        if ((((this.AIAYIUCANLMNKGKFCHUXHA && (Settings.Default.key_using_10_health_cdt == 0)) && ((Settings.Default.key_using_10_shield_cdt == 0) && (Settings.Default.key_using_10_target_health_cdt == 0))) && (((Settings.Default.key_using_10_target_shield_cdt == 0) && (Settings.Default.key_using_10_health_over_cdt == 0)) && ((Settings.Default.key_using_10_shield_over_cdt == 0) && (Settings.Default.key_using_10_target_health_over_cdt == 0)))) && (Settings.Default.key_using_10_target_shield_over_cdt == 0))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_10_key);
                            Thread.Sleep((int) (Settings.Default.key_using_10_ct + 500));
                            this.AIAYIUCANLMNKGKFCHUXHA = false;
                        }
                        else if (this.HJDBDGUKQLVSHYQHAQTHNY && ((((((((Settings.Default.key_using_10_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.key_using_10_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.key_using_10_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.key_using_10_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.key_using_10_health_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.key_using_10_health_over_cdt != 0))) | ((Settings.Default.key_using_10_shield_over_cdt < ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.key_using_10_shield_over_cdt != 0))) | ((Settings.Default.key_using_10_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.key_using_10_target_health_over_cdt != 0))) | ((Settings.Default.key_using_10_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.key_using_10_target_shield_over_cdt != 0))))
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_10_key);
                            Thread.Sleep((int) (Settings.Default.key_using_10_ct + 500));
                            this.AIAYIUCANLMNKGKFCHUXHA = false;
                        }
                        else
                        {
                            UEABHWLKXUEHAKFSDTRKNX = 11;
                        }
                    }
                    else if (((Settings.Default.key_using_10_key == "") | !Settings.Default.key_using_10_infight) && (UEABHWLKXUEHAKFSDTRKNX == 10))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 11;
                    }
                    if (UEABHWLKXUEHAKFSDTRKNX > 10)
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 1;
                    }
                }
            }
            else if (DEFMKWCASKDJTSTMDRZXZB.QFPMCOGRFREENNPJEVEFPO && !DEFMKWCASKDJTSTMDRZXZB.NUAQGVWGHLWNAXMITNRMPF)
            {
                if ((Settings.Default.key_using_1_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 1))
                {
                    if (VMVYRGQPWOQYETBCUWTVC && (Settings.Default.key_using_1_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_1_key);
                        Thread.Sleep((int) (Settings.Default.key_using_1_ct + 500));
                        VMVYRGQPWOQYETBCUWTVC = false;
                    }
                    else if (VMVYRGQPWOQYETBCUWTVC && (Settings.Default.key_using_1_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_1_key);
                        Thread.Sleep((int) (Settings.Default.key_using_1_ct + 500));
                        VMVYRGQPWOQYETBCUWTVC = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 2;
                    }
                }
                else if ((Settings.Default.key_using_1_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 1))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 2;
                }
                if ((Settings.Default.key_using_2_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 2))
                {
                    if (NRWGLEVGYVZVNABVMPJZBZ && (Settings.Default.key_using_2_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_2_key);
                        Thread.Sleep((int) (Settings.Default.key_using_2_ct + 500));
                        NRWGLEVGYVZVNABVMPJZBZ = false;
                    }
                    else if (NRWGLEVGYVZVNABVMPJZBZ && (Settings.Default.key_using_2_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_2_key);
                        Thread.Sleep((int) (Settings.Default.key_using_2_ct + 500));
                        NRWGLEVGYVZVNABVMPJZBZ = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 3;
                    }
                }
                else if ((Settings.Default.key_using_2_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 2))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 3;
                }
                if ((Settings.Default.key_using_3_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 3))
                {
                    if (this.AIZBITLQYIFXAFQUYDCWW && (Settings.Default.key_using_3_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_3_key);
                        Thread.Sleep((int) (Settings.Default.key_using_3_ct + 500));
                        this.AIZBITLQYIFXAFQUYDCWW = false;
                    }
                    else if (this.AIZBITLQYIFXAFQUYDCWW && (Settings.Default.key_using_3_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_3_key);
                        Thread.Sleep((int) (Settings.Default.key_using_3_ct + 500));
                        this.AIZBITLQYIFXAFQUYDCWW = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 4;
                    }
                }
                else if ((Settings.Default.key_using_3_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 3))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 4;
                }
                if ((Settings.Default.key_using_4_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 4))
                {
                    if (this.MLBKRTBHJBAIJVFIOMVVBJ && (Settings.Default.key_using_4_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_4_key);
                        Thread.Sleep((int) (Settings.Default.key_using_4_ct + 500));
                        this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                    }
                    else if (this.MLBKRTBHJBAIJVFIOMVVBJ && (Settings.Default.key_using_4_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_4_key);
                        Thread.Sleep((int) (Settings.Default.key_using_4_ct + 500));
                        this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 5;
                    }
                }
                else if ((Settings.Default.key_using_4_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 4))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 5;
                }
                if ((Settings.Default.key_using_5_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 5))
                {
                    if (this.MBJFNYSZHMEPVHCVGBDWGS && (Settings.Default.key_using_5_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_5_key);
                        Thread.Sleep((int) (Settings.Default.key_using_5_ct + 500));
                        this.MBJFNYSZHMEPVHCVGBDWGS = false;
                    }
                    else if (this.MBJFNYSZHMEPVHCVGBDWGS && (Settings.Default.key_using_5_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_5_key);
                        Thread.Sleep((int) (Settings.Default.key_using_5_ct + 500));
                        this.MBJFNYSZHMEPVHCVGBDWGS = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 6;
                    }
                }
                else if ((Settings.Default.key_using_5_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 5))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 6;
                }
                if ((Settings.Default.key_using_6_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 6))
                {
                    if (this.XGEUZYLYWVFWGRHUCKDLM && (Settings.Default.key_using_6_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_6_key);
                        Thread.Sleep((int) (Settings.Default.key_using_6_ct + 500));
                        this.XGEUZYLYWVFWGRHUCKDLM = false;
                    }
                    if (this.XGEUZYLYWVFWGRHUCKDLM && (Settings.Default.key_using_6_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_6_key);
                        Thread.Sleep((int) (Settings.Default.key_using_6_ct + 500));
                        this.XGEUZYLYWVFWGRHUCKDLM = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 7;
                    }
                }
                else if ((Settings.Default.key_using_6_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 6))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 7;
                }
                if ((Settings.Default.key_using_7_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 7))
                {
                    if (this.TTPKKCIMGWENMDPTGCOXRT && (Settings.Default.key_using_7_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_7_key);
                        Thread.Sleep((int) (Settings.Default.key_using_7_ct + 500));
                        this.TTPKKCIMGWENMDPTGCOXRT = false;
                    }
                    else if (this.TTPKKCIMGWENMDPTGCOXRT && (Settings.Default.key_using_7_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_7_key);
                        Thread.Sleep((int) (Settings.Default.key_using_7_ct + 500));
                        this.TTPKKCIMGWENMDPTGCOXRT = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 8;
                    }
                }
                else if ((Settings.Default.key_using_7_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 7))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 8;
                }
                if ((Settings.Default.key_using_8_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 8))
                {
                    if (this.NQAOXJQUALKPWRSOWJZVDX && (Settings.Default.key_using_8_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_8_key);
                        Thread.Sleep((int) (Settings.Default.key_using_8_ct + 500));
                        this.NQAOXJQUALKPWRSOWJZVDX = false;
                    }
                    else if (this.NQAOXJQUALKPWRSOWJZVDX && (Settings.Default.key_using_8_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_8_key);
                        Thread.Sleep((int) (Settings.Default.key_using_8_ct + 500));
                        this.NQAOXJQUALKPWRSOWJZVDX = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 9;
                    }
                }
                else if ((Settings.Default.key_using_8_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 8))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 9;
                }
                if ((Settings.Default.key_using_9_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 9))
                {
                    if (this.HJDBDGUKQLVSHYQHAQTHNY && (Settings.Default.key_using_9_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_9_key);
                        Thread.Sleep((int) (Settings.Default.key_using_9_ct + 500));
                        this.HJDBDGUKQLVSHYQHAQTHNY = false;
                    }
                    else if (this.HJDBDGUKQLVSHYQHAQTHNY && (Settings.Default.key_using_9_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_9_key);
                        Thread.Sleep((int) (Settings.Default.key_using_9_ct + 500));
                        this.HJDBDGUKQLVSHYQHAQTHNY = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 10;
                    }
                }
                else if ((Settings.Default.key_using_9_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 9))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 10;
                }
                if ((Settings.Default.key_using_10_key != "") && (UEABHWLKXUEHAKFSDTRKNX == 10))
                {
                    if (this.AIAYIUCANLMNKGKFCHUXHA && (Settings.Default.key_using_10_health_cdt == 0))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_10_key);
                        Thread.Sleep((int) (Settings.Default.key_using_10_ct + 500));
                        this.AIAYIUCANLMNKGKFCHUXHA = false;
                    }
                    else if (this.HJDBDGUKQLVSHYQHAQTHNY && (Settings.Default.key_using_10_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.GFNTBCWAHDUHBWCXTJNOVS(Settings.Default.key_using_10_key);
                        Thread.Sleep((int) (Settings.Default.key_using_10_ct + 500));
                        this.AIAYIUCANLMNKGKFCHUXHA = false;
                    }
                    else
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 11;
                    }
                }
                else if ((Settings.Default.key_using_10_key == "") && (UEABHWLKXUEHAKFSDTRKNX == 10))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 11;
                }
                if (UEABHWLKXUEHAKFSDTRKNX > 10)
                {
                    UEABHWLKXUEHAKFSDTRKNX = 1;
                }
            }
        }

        private void RVDUAUPUZWBXPPJYDBUVOW(object sender, EventArgs e)
        {
            this.NQAOXJQUALKPWRSOWJZVDX = true;
        }

        private void UZRWQFVYJDNAYKVRWKARW(object sender, EventArgs e)
        {
            this.HJDBDGUKQLVSHYQHAQTHNY = true;
        }

        private void XLKLGWJCNSEMFJIHAKNAN(object sender, EventArgs e)
        {
            NRWGLEVGYVZVNABVMPJZBZ = true;
        }
    }
}

