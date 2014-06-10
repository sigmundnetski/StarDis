namespace BANANA
{
    using StarSpot.Properties;
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Threading;

    internal class PHATKIWNEJAHCPLGWTOZCA
    {
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
        private bool NRWGLEVGYVZVNABVMPJZBZ = true;
        private DispatcherTimer QZJMYRXJMIJXJOWVAFVPTI = new DispatcherTimer();
        private DispatcherTimer SMHSRXYGJCRREXQEFVURAR = new DispatcherTimer();
        private DispatcherTimer TPPBERNOQSBFQUZHMYQPRE = new DispatcherTimer();
        private bool TTPKKCIMGWENMDPTGCOXRT = true;
        private DispatcherTimer UAPGDIWCQCYZIAUCBICUOO = new DispatcherTimer();
        private BackgroundWorker UCBVJVGXAORHXVBWENTZNX = new BackgroundWorker();
        public static int UEABHWLKXUEHAKFSDTRKNX = 1;
        private DispatcherTimer UQBHXIPGYJLUXIUVLKKQPZ = new DispatcherTimer();
        private bool VMVYRGQPWOQYETBCUWTVC = true;
        private bool XGEUZYLYWVFWGRHUCKDLM = true;

        public PHATKIWNEJAHCPLGWTOZCA()
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
            this.UCBVJVGXAORHXVBWENTZNX.DoWork += new DoWorkEventHandler(this.IMBVXZKHKSQVWSAOGGIEJ);
        }

        private void ACLZRJHVIDSMFRHONFONWW(object sender, EventArgs e)
        {
            this.VMVYRGQPWOQYETBCUWTVC = true;
        }

        private void FNTNBHSRWGXVEBFVNMBSBK(object sender, EventArgs e)
        {
            this.MBJFNYSZHMEPVHCVGBDWGS = true;
        }

        public void IMBVXZKHKSQVWSAOGGIEJ(object sender, DoWorkEventArgs e)
        {
            if ((this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() == 0L) && (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 1L))
            {
                return;
            }
            if ((this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L) && (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
            {
                return;
            }
            if ((this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() == 0L) || (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() != 1L))
            {
                return;
            }
            if (Settings.Default.skill_1_enabled && (UEABHWLKXUEHAKFSDTRKNX == 1))
            {
                if ((((this.VMVYRGQPWOQYETBCUWTVC && (Settings.Default.skill_r_health_over_cdt == 0)) && ((Settings.Default.skill_r_shield_over_cdt == 0) && (Settings.Default.skill_r_target_health_over_cdt == 0))) && (((Settings.Default.skill_r_target_shield_over_cdt == 0) && (Settings.Default.skill_r_health_cdt == 0)) && ((Settings.Default.skill_r_shield_cdt == 0) && (Settings.Default.skill_r_target_health_cdt == 0)))) && (Settings.Default.skill_r_target_shield_cdt == 0))
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.R();
                    Thread.Sleep(500);
                    this.VMVYRGQPWOQYETBCUWTVC = false;
                }
                else if (this.VMVYRGQPWOQYETBCUWTVC && ((((((((Settings.Default.skill_r_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.skill_r_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.skill_r_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.skill_r_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.skill_r_health_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.skill_r_health_over_cdt != 0))) | ((Settings.Default.skill_r_shield_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.skill_r_shield_over_cdt != 0))) | ((Settings.Default.skill_r_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.skill_r_target_health_over_cdt != 0))) | ((Settings.Default.skill_r_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.skill_r_target_shield_over_cdt != 0))))
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.R();
                    Thread.Sleep(500);
                    this.VMVYRGQPWOQYETBCUWTVC = false;
                }
                else
                {
                    UEABHWLKXUEHAKFSDTRKNX = 2;
                }
            }
            else if (!Settings.Default.skill_1_enabled && (UEABHWLKXUEHAKFSDTRKNX == 1))
            {
                UEABHWLKXUEHAKFSDTRKNX = 2;
            }
            if (!Settings.Default.skill_2_enabled || (UEABHWLKXUEHAKFSDTRKNX != 2))
            {
                if (!Settings.Default.skill_2_enabled && (UEABHWLKXUEHAKFSDTRKNX == 2))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 3;
                }
            }
            else
            {
                if ((((this.NRWGLEVGYVZVNABVMPJZBZ && (Settings.Default.skill_1_health_over_cdt == 0)) && ((Settings.Default.skill_1_shield_over_cdt == 0) && (Settings.Default.skill_1_target_health_over_cdt == 0))) && (((Settings.Default.skill_1_target_shield_over_cdt == 0) && (Settings.Default.skill_1_health_cdt == 0)) && ((Settings.Default.skill_1_shield_cdt == 0) && (Settings.Default.skill_1_target_health_cdt == 0)))) && ((Settings.Default.skill_1_target_shield_cdt == 0) && !Settings.Default.skill_1_interrupt_enabled))
                {
                    if (!Settings.Default.skill_2_double_click)
                    {
                        if (Settings.Default.skill_1_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                            Thread.Sleep((int) (Settings.Default.skill_2_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.NRWGLEVGYVZVNABVMPJZBZ = false;
                            }
                        }
                        else
                        {
                            for (int i = 0; i != (Convert.ToInt32(Settings.Default.skill_1_repeat_cdt) + 2); i++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                                Thread.Sleep((int) (Settings.Default.skill_2_charge + 500));
                                if (i == ((Convert.ToInt32(Settings.Default.skill_1_repeat_cdt) + 2) - 1))
                                {
                                    this.NRWGLEVGYVZVNABVMPJZBZ = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (Settings.Default.skill_2_double_click)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                        Thread.Sleep((int) (Settings.Default.skill_2_charge + 800));
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                        if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                        {
                            this.NRWGLEVGYVZVNABVMPJZBZ = false;
                        }
                    }
                }
                if (!this.NRWGLEVGYVZVNABVMPJZBZ || !(((((((((Settings.Default.skill_1_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.skill_1_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.skill_1_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.skill_1_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.skill_1_health_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.skill_1_health_over_cdt != 0))) | ((Settings.Default.skill_1_shield_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.skill_1_shield_over_cdt != 0))) | ((Settings.Default.skill_1_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.skill_1_target_health_over_cdt != 0))) | ((Settings.Default.skill_1_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.skill_1_target_shield_over_cdt != 0))) | Settings.Default.skill_1_interrupt_enabled))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 3;
                }
                else
                {
                    if (!Settings.Default.skill_2_double_click)
                    {
                        if (Settings.Default.skill_1_interrupt_enabled)
                        {
                            if (GameUnit.VVQYFAUVMNSJCFLJEHLTC != 0L)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                                Thread.Sleep((int) (Settings.Default.skill_2_charge + 500));
                                if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                                {
                                    this.NRWGLEVGYVZVNABVMPJZBZ = false;
                                }
                            }
                            else
                            {
                                UEABHWLKXUEHAKFSDTRKNX = 3;
                            }
                        }
                        else if (Settings.Default.skill_1_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                            Thread.Sleep((int) (Settings.Default.skill_2_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.NRWGLEVGYVZVNABVMPJZBZ = false;
                            }
                        }
                        else
                        {
                            for (int j = 0; j != (Convert.ToInt32(Settings.Default.skill_1_repeat_cdt) + 2); j++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                                Thread.Sleep((int) (Settings.Default.skill_2_charge + 500));
                                if (j == ((Convert.ToInt32(Settings.Default.skill_1_repeat_cdt) + 2) - 1))
                                {
                                    this.NRWGLEVGYVZVNABVMPJZBZ = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (Settings.Default.skill_2_double_click)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                        Thread.Sleep((int) (Settings.Default.skill_2_charge + 800));
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(0);
                        if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                        {
                            this.NRWGLEVGYVZVNABVMPJZBZ = false;
                        }
                    }
                }
            }
            if (!Settings.Default.skill_3_enabled || (UEABHWLKXUEHAKFSDTRKNX != 3))
            {
                if (!Settings.Default.skill_3_enabled && (UEABHWLKXUEHAKFSDTRKNX == 3))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 4;
                }
            }
            else
            {
                if ((((!this.AIZBITLQYIFXAFQUYDCWW || (Settings.Default.skill_2_health_over_cdt != 0)) || ((Settings.Default.skill_2_shield_over_cdt != 0) || (Settings.Default.skill_2_target_health_over_cdt != 0))) || (((Settings.Default.skill_2_target_shield_over_cdt != 0) || (Settings.Default.skill_2_health_cdt != 0)) || ((Settings.Default.skill_2_shield_cdt != 0) || (Settings.Default.skill_2_target_health_cdt != 0)))) || ((Settings.Default.skill_2_target_shield_cdt != 0) || Settings.Default.skill_2_interrupt_enabled))
                {
                    if (!this.AIZBITLQYIFXAFQUYDCWW || !(((((((((Settings.Default.skill_2_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.skill_2_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.skill_2_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.skill_2_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.skill_2_health_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.skill_2_health_over_cdt != 0))) | ((Settings.Default.skill_2_shield_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.skill_2_shield_over_cdt != 0))) | ((Settings.Default.skill_2_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.skill_2_target_health_over_cdt != 0))) | ((Settings.Default.skill_2_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.skill_2_target_shield_over_cdt != 0))) | Settings.Default.skill_2_interrupt_enabled))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 4;
                        goto Label_0B3A;
                    }
                    if (!Settings.Default.skill_3_double_click)
                    {
                        if (Settings.Default.skill_2_interrupt_enabled)
                        {
                            if (GameUnit.VVQYFAUVMNSJCFLJEHLTC != 0L)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                                Thread.Sleep((int) (Settings.Default.skill_3_charge + 500));
                                if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                                {
                                    this.AIZBITLQYIFXAFQUYDCWW = false;
                                }
                            }
                            else
                            {
                                UEABHWLKXUEHAKFSDTRKNX = 4;
                            }
                        }
                        else if (Settings.Default.skill_2_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                            Thread.Sleep((int) (Settings.Default.skill_3_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.AIZBITLQYIFXAFQUYDCWW = false;
                            }
                        }
                        else
                        {
                            for (int k = 0; k != (Convert.ToInt32(Settings.Default.skill_2_repeat_cdt) + 2); k++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                                Thread.Sleep((int) (Settings.Default.skill_3_charge + 500));
                                if (k == ((Convert.ToInt32(Settings.Default.skill_2_repeat_cdt) + 2) - 1))
                                {
                                    this.AIZBITLQYIFXAFQUYDCWW = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (!Settings.Default.skill_3_double_click)
                    {
                        if (Settings.Default.skill_2_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                            Thread.Sleep((int) (Settings.Default.skill_3_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.AIZBITLQYIFXAFQUYDCWW = false;
                            }
                        }
                        else
                        {
                            for (int m = 0; m != (Convert.ToInt32(Settings.Default.skill_2_repeat_cdt) + 2); m++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                                Thread.Sleep((int) (Settings.Default.skill_3_charge + 500));
                                if (m == ((Convert.ToInt32(Settings.Default.skill_2_repeat_cdt) + 2) - 1))
                                {
                                    this.AIZBITLQYIFXAFQUYDCWW = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (Settings.Default.skill_3_double_click)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                        Thread.Sleep((int) (Settings.Default.skill_3_charge + 800));
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                        if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                        {
                            this.AIZBITLQYIFXAFQUYDCWW = false;
                        }
                    }
                    goto Label_0B3A;
                }
                if (Settings.Default.skill_3_double_click)
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                    Thread.Sleep((int) (Settings.Default.skill_3_charge + 800));
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(1);
                    if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                    {
                        this.AIZBITLQYIFXAFQUYDCWW = false;
                    }
                }
            }
        Label_0B3A:
            if (!Settings.Default.skill_4_enabled || (UEABHWLKXUEHAKFSDTRKNX != 4))
            {
                if (!Settings.Default.skill_4_enabled && (UEABHWLKXUEHAKFSDTRKNX == 4))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 5;
                }
            }
            else
            {
                if ((((!this.MLBKRTBHJBAIJVFIOMVVBJ || (Settings.Default.skill_3_health_over_cdt != 0)) || ((Settings.Default.skill_3_shield_over_cdt != 0) || (Settings.Default.skill_3_target_health_over_cdt != 0))) || (((Settings.Default.skill_3_target_shield_over_cdt != 0) || (Settings.Default.skill_3_health_cdt != 0)) || ((Settings.Default.skill_3_shield_cdt != 0) || (Settings.Default.skill_3_target_health_cdt != 0)))) || ((Settings.Default.skill_3_target_shield_cdt != 0) || Settings.Default.skill_3_interrupt_enabled))
                {
                    if (!this.MLBKRTBHJBAIJVFIOMVVBJ || !(((((((((Settings.Default.skill_3_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.skill_3_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.skill_3_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.skill_3_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.skill_3_health_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.skill_3_health_over_cdt != 0))) | ((Settings.Default.skill_3_shield_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.skill_3_shield_over_cdt != 0))) | ((Settings.Default.skill_3_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.skill_3_target_health_over_cdt != 0))) | ((Settings.Default.skill_3_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.skill_3_target_shield_over_cdt != 0))) | Settings.Default.skill_3_interrupt_enabled))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 5;
                        goto Label_0FC6;
                    }
                    if (!Settings.Default.skill_4_double_click)
                    {
                        if (Settings.Default.skill_3_interrupt_enabled)
                        {
                            if (GameUnit.VVQYFAUVMNSJCFLJEHLTC != 0L)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                                Thread.Sleep((int) (Settings.Default.skill_4_charge + 500));
                                if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                                {
                                    this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                                }
                            }
                            else
                            {
                                UEABHWLKXUEHAKFSDTRKNX = 5;
                            }
                        }
                        else if (Settings.Default.skill_3_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                            Thread.Sleep((int) (Settings.Default.skill_4_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                            }
                        }
                        else
                        {
                            for (int n = 0; n != (Convert.ToInt32(Settings.Default.skill_3_repeat_cdt) + 2); n++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                                Thread.Sleep((int) (Settings.Default.skill_4_charge + 500));
                                if (n == ((Convert.ToInt32(Settings.Default.skill_3_repeat_cdt) + 2) - 1))
                                {
                                    this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (!Settings.Default.skill_4_double_click)
                    {
                        if (Settings.Default.skill_3_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                            Thread.Sleep((int) (Settings.Default.skill_4_charge + 800));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                            }
                        }
                        else
                        {
                            for (int num5 = 0; num5 != (Convert.ToInt32(Settings.Default.skill_3_repeat_cdt) + 2); num5++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                                Thread.Sleep((int) (Settings.Default.skill_4_charge + 500));
                                if (num5 == ((Convert.ToInt32(Settings.Default.skill_3_repeat_cdt) + 2) - 1))
                                {
                                    this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (Settings.Default.skill_4_double_click)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                        Thread.Sleep((int) (Settings.Default.skill_4_charge + 800));
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                        if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                        {
                            this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                        }
                    }
                    goto Label_0FC6;
                }
                if (Settings.Default.skill_4_double_click)
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                    Thread.Sleep((int) (Settings.Default.skill_4_charge + 800));
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(2);
                    if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                    {
                        this.MLBKRTBHJBAIJVFIOMVVBJ = false;
                    }
                }
            }
        Label_0FC6:
            if (!Settings.Default.skill_5_enabled || (UEABHWLKXUEHAKFSDTRKNX != 5))
            {
                if (!Settings.Default.skill_5_enabled && (UEABHWLKXUEHAKFSDTRKNX == 5))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 6;
                }
            }
            else
            {
                if ((((!this.MBJFNYSZHMEPVHCVGBDWGS || (Settings.Default.skill_4_health_over_cdt != 0)) || ((Settings.Default.skill_4_shield_over_cdt != 0) || (Settings.Default.skill_4_target_health_over_cdt != 0))) || (((Settings.Default.skill_4_target_shield_over_cdt != 0) || (Settings.Default.skill_4_health_cdt != 0)) || ((Settings.Default.skill_4_shield_cdt != 0) || (Settings.Default.skill_4_target_health_cdt != 0)))) || ((Settings.Default.skill_4_target_shield_cdt != 0) || Settings.Default.skill_4_interrupt_enabled))
                {
                    if (!this.MBJFNYSZHMEPVHCVGBDWGS || !(((((((((Settings.Default.skill_4_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.skill_4_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.skill_4_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.skill_4_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.skill_4_health_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.skill_4_health_over_cdt != 0))) | ((Settings.Default.skill_4_shield_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.skill_4_shield_over_cdt != 0))) | ((Settings.Default.skill_4_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.skill_4_target_health_over_cdt != 0))) | ((Settings.Default.skill_4_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.skill_4_target_shield_over_cdt != 0))) | Settings.Default.skill_4_interrupt_enabled))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 6;
                        goto Label_1452;
                    }
                    if (!Settings.Default.skill_5_double_click)
                    {
                        if (Settings.Default.skill_4_interrupt_enabled)
                        {
                            if (GameUnit.VVQYFAUVMNSJCFLJEHLTC != 0L)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                                Thread.Sleep((int) (Settings.Default.skill_5_charge + 500));
                                if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                                {
                                    this.MBJFNYSZHMEPVHCVGBDWGS = false;
                                }
                            }
                            else
                            {
                                UEABHWLKXUEHAKFSDTRKNX = 6;
                            }
                        }
                        else if (Settings.Default.skill_4_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                            Thread.Sleep((int) (Settings.Default.skill_5_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.MBJFNYSZHMEPVHCVGBDWGS = false;
                            }
                        }
                        else
                        {
                            for (int num8 = 0; num8 != (Convert.ToInt32(Settings.Default.skill_4_repeat_cdt) + 2); num8++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                                Thread.Sleep((int) (Settings.Default.skill_5_charge + 500));
                                if (num8 == ((Convert.ToInt32(Settings.Default.skill_4_repeat_cdt) + 2) - 1))
                                {
                                    this.MBJFNYSZHMEPVHCVGBDWGS = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (!Settings.Default.skill_5_double_click)
                    {
                        if (Settings.Default.skill_4_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                            Thread.Sleep((int) (Settings.Default.skill_5_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.MBJFNYSZHMEPVHCVGBDWGS = false;
                            }
                        }
                        else
                        {
                            for (int num7 = 0; num7 != (Convert.ToInt32(Settings.Default.skill_4_repeat_cdt) + 2); num7++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                                Thread.Sleep((int) (Settings.Default.skill_5_charge + 500));
                                if (num7 == ((Convert.ToInt32(Settings.Default.skill_4_repeat_cdt) + 2) - 1))
                                {
                                    this.MBJFNYSZHMEPVHCVGBDWGS = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (Settings.Default.skill_5_double_click)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                        Thread.Sleep((int) (Settings.Default.skill_5_charge + 800));
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                        if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                        {
                            this.MBJFNYSZHMEPVHCVGBDWGS = false;
                        }
                    }
                    goto Label_1452;
                }
                if (Settings.Default.skill_5_double_click)
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                    Thread.Sleep((int) (Settings.Default.skill_5_charge + 800));
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(3);
                    if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                    {
                        this.MBJFNYSZHMEPVHCVGBDWGS = false;
                    }
                }
            }
        Label_1452:
            if (!Settings.Default.skill_6_enabled || (UEABHWLKXUEHAKFSDTRKNX != 6))
            {
                if (!Settings.Default.skill_6_enabled && (UEABHWLKXUEHAKFSDTRKNX == 6))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 7;
                }
            }
            else
            {
                if ((((!this.XGEUZYLYWVFWGRHUCKDLM || (Settings.Default.skill_5_health_over_cdt != 0)) || ((Settings.Default.skill_5_shield_over_cdt != 0) || (Settings.Default.skill_5_target_health_over_cdt != 0))) || (((Settings.Default.skill_5_target_shield_over_cdt != 0) || (Settings.Default.skill_5_health_cdt != 0)) || ((Settings.Default.skill_5_shield_cdt != 0) || (Settings.Default.skill_5_target_health_cdt != 0)))) || ((Settings.Default.skill_5_target_shield_cdt != 0) || Settings.Default.skill_5_interrupt_enabled))
                {
                    if (!this.XGEUZYLYWVFWGRHUCKDLM || !(((((((((Settings.Default.skill_5_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.skill_5_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.skill_5_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.skill_5_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.skill_5_health_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.skill_5_health_over_cdt != 0))) | ((Settings.Default.skill_5_shield_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.skill_5_shield_over_cdt != 0))) | ((Settings.Default.skill_5_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.skill_5_target_health_over_cdt != 0))) | ((Settings.Default.skill_5_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.skill_5_target_shield_over_cdt != 0))) | Settings.Default.skill_5_interrupt_enabled))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 7;
                        goto Label_18DE;
                    }
                    if (!Settings.Default.skill_6_double_click)
                    {
                        if (Settings.Default.skill_5_interrupt_enabled)
                        {
                            if (GameUnit.VVQYFAUVMNSJCFLJEHLTC != 0L)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                                Thread.Sleep((int) (Settings.Default.skill_6_charge + 500));
                                if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                                {
                                    this.XGEUZYLYWVFWGRHUCKDLM = false;
                                }
                            }
                            else
                            {
                                UEABHWLKXUEHAKFSDTRKNX = 7;
                            }
                        }
                        else if (Settings.Default.skill_5_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                            Thread.Sleep((int) (Settings.Default.skill_6_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.XGEUZYLYWVFWGRHUCKDLM = false;
                            }
                        }
                        else
                        {
                            for (int num10 = 0; num10 != (Convert.ToInt32(Settings.Default.skill_5_repeat_cdt) + 2); num10++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                                Thread.Sleep((int) (Settings.Default.skill_6_charge + 500));
                                if (num10 == ((Convert.ToInt32(Settings.Default.skill_5_repeat_cdt) + 2) - 1))
                                {
                                    this.XGEUZYLYWVFWGRHUCKDLM = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (!Settings.Default.skill_6_double_click)
                    {
                        if (Settings.Default.skill_5_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                            Thread.Sleep((int) (Settings.Default.skill_6_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.XGEUZYLYWVFWGRHUCKDLM = false;
                            }
                        }
                        else
                        {
                            for (int num9 = 0; num9 != (Convert.ToInt32(Settings.Default.skill_5_repeat_cdt) + 2); num9++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                                Thread.Sleep((int) (Settings.Default.skill_6_charge + 500));
                                if (num9 == ((Convert.ToInt32(Settings.Default.skill_5_repeat_cdt) + 2) - 1))
                                {
                                    this.XGEUZYLYWVFWGRHUCKDLM = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (Settings.Default.skill_6_double_click)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                        Thread.Sleep((int) (Settings.Default.skill_6_charge + 800));
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                        if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                        {
                            this.XGEUZYLYWVFWGRHUCKDLM = false;
                        }
                    }
                    goto Label_18DE;
                }
                if (Settings.Default.skill_6_double_click)
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                    Thread.Sleep((int) (Settings.Default.skill_6_charge + 800));
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(4);
                    if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                    {
                        this.XGEUZYLYWVFWGRHUCKDLM = false;
                    }
                }
            }
        Label_18DE:
            if (!Settings.Default.skill_7_enabled || (UEABHWLKXUEHAKFSDTRKNX != 7))
            {
                if (!Settings.Default.skill_7_enabled && (UEABHWLKXUEHAKFSDTRKNX == 7))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 8;
                }
            }
            else
            {
                if ((((!this.TTPKKCIMGWENMDPTGCOXRT || (Settings.Default.skill_6_health_over_cdt != 0)) || ((Settings.Default.skill_6_shield_over_cdt != 0) || (Settings.Default.skill_6_target_health_over_cdt != 0))) || (((Settings.Default.skill_6_target_shield_over_cdt != 0) || (Settings.Default.skill_6_health_cdt != 0)) || ((Settings.Default.skill_6_shield_cdt != 0) || (Settings.Default.skill_6_target_health_cdt != 0)))) || ((Settings.Default.skill_6_target_shield_cdt != 0) || Settings.Default.skill_6_interrupt_enabled))
                {
                    if (!this.TTPKKCIMGWENMDPTGCOXRT || !(((((((((Settings.Default.skill_6_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.skill_6_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.skill_6_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.skill_6_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.skill_6_health_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.skill_6_health_over_cdt != 0))) | ((Settings.Default.skill_6_shield_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.skill_6_shield_over_cdt != 0))) | ((Settings.Default.skill_6_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.skill_6_target_health_over_cdt != 0))) | ((Settings.Default.skill_6_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.skill_6_target_shield_over_cdt != 0))) | Settings.Default.skill_6_interrupt_enabled))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 8;
                        goto Label_1D6A;
                    }
                    if (!Settings.Default.skill_7_double_click)
                    {
                        if (Settings.Default.skill_6_interrupt_enabled)
                        {
                            if (GameUnit.VVQYFAUVMNSJCFLJEHLTC != 0L)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                                Thread.Sleep((int) (Settings.Default.skill_7_charge + 500));
                                if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                                {
                                    this.TTPKKCIMGWENMDPTGCOXRT = false;
                                }
                            }
                            else
                            {
                                UEABHWLKXUEHAKFSDTRKNX = 8;
                            }
                        }
                        else if (Settings.Default.skill_6_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                            Thread.Sleep((int) (Settings.Default.skill_7_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.TTPKKCIMGWENMDPTGCOXRT = false;
                            }
                        }
                        else
                        {
                            for (int num12 = 0; num12 != (Convert.ToInt32(Settings.Default.skill_6_repeat_cdt) + 2); num12++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                                Thread.Sleep((int) (Settings.Default.skill_7_charge + 500));
                                if (num12 == ((Convert.ToInt32(Settings.Default.skill_6_repeat_cdt) + 2) - 1))
                                {
                                    this.TTPKKCIMGWENMDPTGCOXRT = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (!Settings.Default.skill_7_double_click)
                    {
                        if (Settings.Default.skill_6_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                            Thread.Sleep((int) (Settings.Default.skill_7_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.TTPKKCIMGWENMDPTGCOXRT = false;
                            }
                        }
                        else
                        {
                            for (int num11 = 0; num11 != (Convert.ToInt32(Settings.Default.skill_6_repeat_cdt) + 2); num11++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                                Thread.Sleep((int) (Settings.Default.skill_7_charge + 500));
                                if (num11 == ((Convert.ToInt32(Settings.Default.skill_6_repeat_cdt) + 2) - 1))
                                {
                                    this.TTPKKCIMGWENMDPTGCOXRT = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (Settings.Default.skill_7_double_click)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                        Thread.Sleep((int) (Settings.Default.skill_7_charge + 800));
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                        if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                        {
                            this.TTPKKCIMGWENMDPTGCOXRT = false;
                        }
                    }
                    goto Label_1D6A;
                }
                if (Settings.Default.skill_7_double_click)
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                    Thread.Sleep((int) (Settings.Default.skill_7_charge + 800));
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(5);
                    if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                    {
                        this.TTPKKCIMGWENMDPTGCOXRT = false;
                    }
                }
            }
        Label_1D6A:
            if (!Settings.Default.skill_8_enabled || (UEABHWLKXUEHAKFSDTRKNX != 8))
            {
                if (!Settings.Default.skill_7_enabled && (UEABHWLKXUEHAKFSDTRKNX == 8))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 9;
                }
            }
            else
            {
                if ((((!this.NQAOXJQUALKPWRSOWJZVDX || (Settings.Default.skill_7_health_over_cdt != 0)) || ((Settings.Default.skill_7_shield_over_cdt != 0) || (Settings.Default.skill_7_target_health_over_cdt != 0))) || (((Settings.Default.skill_7_target_shield_over_cdt != 0) || (Settings.Default.skill_7_health_cdt != 0)) || ((Settings.Default.skill_7_shield_cdt != 0) || (Settings.Default.skill_7_target_health_cdt != 0)))) || ((Settings.Default.skill_7_target_shield_cdt != 0) || Settings.Default.skill_7_interrupt_enabled))
                {
                    if (!this.NQAOXJQUALKPWRSOWJZVDX || !(((((((((Settings.Default.skill_7_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.skill_7_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.skill_7_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.skill_7_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.skill_7_health_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.skill_7_health_over_cdt != 0))) | ((Settings.Default.skill_7_shield_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.skill_7_shield_over_cdt != 0))) | ((Settings.Default.skill_7_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.skill_7_target_health_over_cdt != 0))) | ((Settings.Default.skill_7_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.skill_7_target_shield_over_cdt != 0))) | Settings.Default.skill_7_interrupt_enabled))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 9;
                        goto Label_21F9;
                    }
                    if (!Settings.Default.skill_8_double_click)
                    {
                        if (Settings.Default.skill_7_interrupt_enabled)
                        {
                            if (GameUnit.VVQYFAUVMNSJCFLJEHLTC != 0L)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                                Thread.Sleep((int) (Settings.Default.skill_8_charge + 500));
                                if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                                {
                                    this.NQAOXJQUALKPWRSOWJZVDX = false;
                                }
                            }
                            else
                            {
                                UEABHWLKXUEHAKFSDTRKNX = 9;
                            }
                        }
                        else if (Settings.Default.skill_7_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                            Thread.Sleep((int) (Settings.Default.skill_8_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.NQAOXJQUALKPWRSOWJZVDX = false;
                            }
                        }
                        else
                        {
                            for (int num14 = 0; num14 != (Convert.ToInt32(Settings.Default.skill_7_repeat_cdt) + 2); num14++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                                Thread.Sleep((int) (Settings.Default.skill_8_charge + 500));
                                if (num14 == ((Convert.ToInt32(Settings.Default.skill_7_repeat_cdt) + 2) - 1))
                                {
                                    this.NQAOXJQUALKPWRSOWJZVDX = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (!Settings.Default.skill_8_double_click)
                    {
                        if (Settings.Default.skill_7_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                            Thread.Sleep((int) (Settings.Default.skill_8_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.NQAOXJQUALKPWRSOWJZVDX = false;
                            }
                        }
                        else
                        {
                            for (int num13 = 0; num13 != (Convert.ToInt32(Settings.Default.skill_7_repeat_cdt) + 2); num13++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                                Thread.Sleep((int) (Settings.Default.skill_8_charge + 500));
                                if (num13 == ((Convert.ToInt32(Settings.Default.skill_7_repeat_cdt) + 2) - 1))
                                {
                                    this.NQAOXJQUALKPWRSOWJZVDX = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (Settings.Default.skill_8_double_click)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                        Thread.Sleep((int) (Settings.Default.skill_8_charge + 800));
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                        if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                        {
                            this.NQAOXJQUALKPWRSOWJZVDX = false;
                        }
                    }
                    goto Label_21F9;
                }
                if (Settings.Default.skill_8_double_click)
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                    Thread.Sleep((int) (Settings.Default.skill_8_charge + 800));
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(6);
                    if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                    {
                        this.NQAOXJQUALKPWRSOWJZVDX = false;
                    }
                }
            }
        Label_21F9:
            if (!Settings.Default.skill_9_enabled || (UEABHWLKXUEHAKFSDTRKNX != 9))
            {
                if (!Settings.Default.skill_9_enabled && (UEABHWLKXUEHAKFSDTRKNX == 9))
                {
                    UEABHWLKXUEHAKFSDTRKNX = 10;
                }
            }
            else
            {
                if ((((!this.HJDBDGUKQLVSHYQHAQTHNY || (Settings.Default.skill_8_health_over_cdt != 0)) || ((Settings.Default.skill_8_shield_over_cdt != 0) || (Settings.Default.skill_8_target_health_over_cdt != 0))) || (((Settings.Default.skill_8_target_shield_over_cdt != 0) || (Settings.Default.skill_8_health_cdt != 0)) || ((Settings.Default.skill_8_shield_cdt != 0) || (Settings.Default.skill_8_target_health_cdt != 0)))) || ((Settings.Default.skill_8_target_shield_cdt != 0) || Settings.Default.skill_8_interrupt_enabled))
                {
                    if (!this.HJDBDGUKQLVSHYQHAQTHNY || !(((((((((Settings.Default.skill_8_health_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) | (Settings.Default.skill_8_shield_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB()))) | (Settings.Default.skill_8_target_health_cdt > ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR))) | (Settings.Default.skill_8_target_shield_cdt > ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN))) | ((Settings.Default.skill_8_health_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.JMNBEWDHGYSVIAIUTMVHJ())) && (Settings.Default.skill_8_health_over_cdt != 0))) | ((Settings.Default.skill_8_shield_over_cdt > ((int) this.GWXVZWVXVPSQFZFFLVLSIH.EFTTPQUKLHWFVRHUCOYHB())) && (Settings.Default.skill_8_shield_over_cdt != 0))) | ((Settings.Default.skill_8_target_health_over_cdt < ((int) GameUnit.EGYLZWCJOSIDBHYEALERVR)) && (Settings.Default.skill_8_target_health_over_cdt != 0))) | ((Settings.Default.skill_8_target_shield_over_cdt < ((int) GameUnit.LPQTRNPHGFQYFUIKNCTZVN)) && (Settings.Default.skill_8_target_shield_over_cdt != 0))) | Settings.Default.skill_8_interrupt_enabled))
                    {
                        UEABHWLKXUEHAKFSDTRKNX = 10;
                        goto Label_268A;
                    }
                    if (!Settings.Default.skill_9_double_click)
                    {
                        if (Settings.Default.skill_8_interrupt_enabled)
                        {
                            if (GameUnit.VVQYFAUVMNSJCFLJEHLTC != 0L)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                                Thread.Sleep((int) (Settings.Default.skill_9_charge + 500));
                                if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                                {
                                    this.HJDBDGUKQLVSHYQHAQTHNY = false;
                                }
                            }
                            else
                            {
                                UEABHWLKXUEHAKFSDTRKNX = 10;
                            }
                        }
                        else if (Settings.Default.skill_8_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                            Thread.Sleep((int) (Settings.Default.skill_9_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.HJDBDGUKQLVSHYQHAQTHNY = false;
                            }
                        }
                        else
                        {
                            for (int num16 = 0; num16 != (Convert.ToInt32(Settings.Default.skill_8_repeat_cdt) + 2); num16++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                                Thread.Sleep((int) (Settings.Default.skill_9_charge + 500));
                                if (num16 == ((Convert.ToInt32(Settings.Default.skill_8_repeat_cdt) + 2) - 1))
                                {
                                    this.HJDBDGUKQLVSHYQHAQTHNY = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (!Settings.Default.skill_9_double_click)
                    {
                        if (Settings.Default.skill_8_repeat_cdt == 0)
                        {
                            GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                            Thread.Sleep((int) (Settings.Default.skill_9_charge + 500));
                            if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                            {
                                this.HJDBDGUKQLVSHYQHAQTHNY = false;
                            }
                        }
                        else
                        {
                            for (int num15 = 0; num15 != (Convert.ToInt32(Settings.Default.skill_8_repeat_cdt) + 2); num15++)
                            {
                                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                                Thread.Sleep((int) (Settings.Default.skill_9_charge + 500));
                                if (num15 == ((Convert.ToInt32(Settings.Default.skill_8_repeat_cdt) + 2) - 1))
                                {
                                    this.HJDBDGUKQLVSHYQHAQTHNY = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (Settings.Default.skill_9_double_click)
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                        Thread.Sleep((int) (Settings.Default.skill_9_charge + 800));
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                        if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                        {
                            this.HJDBDGUKQLVSHYQHAQTHNY = false;
                        }
                    }
                    goto Label_268A;
                }
                if (Settings.Default.skill_9_double_click)
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                    Thread.Sleep((int) (Settings.Default.skill_9_charge + 800));
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(7);
                    if ((GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L) | (this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU() != 0L))
                    {
                        this.HJDBDGUKQLVSHYQHAQTHNY = false;
                    }
                }
            }
        Label_268A:
            if (UEABHWLKXUEHAKFSDTRKNX > 9)
            {
                UEABHWLKXUEHAKFSDTRKNX = 1;
            }
        }

        private void IMSLHYIHOVDWFFECNKOIUU(object sender, EventArgs e)
        {
            this.TTPKKCIMGWENMDPTGCOXRT = true;
        }

        public void MAMWQNQIFABHMLRRUKMCA()
        {
            if ((this.DHIODCVTHRZRSEUDDZTLWR.Interval.TotalSeconds != Settings.Default.skill_1_cooldown) && (Settings.Default.skill_1_cooldown != 0))
            {
                this.DHIODCVTHRZRSEUDDZTLWR.Interval = new TimeSpan(0, 0, Settings.Default.skill_1_cooldown);
            }
            if ((Settings.Default.skill_1_cooldown == 0) && (this.DHIODCVTHRZRSEUDDZTLWR.Interval.Milliseconds != 500))
            {
                this.DHIODCVTHRZRSEUDDZTLWR.Interval = new TimeSpan(0, 0, 0, 0, 500);
            }
            if (!this.VMVYRGQPWOQYETBCUWTVC && Settings.Default.skill_1_enabled)
            {
                this.DHIODCVTHRZRSEUDDZTLWR.Start();
            }
            else if (this.VMVYRGQPWOQYETBCUWTVC)
            {
                this.DHIODCVTHRZRSEUDDZTLWR.Stop();
            }
            if ((this.SMHSRXYGJCRREXQEFVURAR.Interval.TotalSeconds != Settings.Default.skill_2_cooldown) && (Settings.Default.skill_2_cooldown != 0))
            {
                this.SMHSRXYGJCRREXQEFVURAR.Interval = new TimeSpan(0, 0, Settings.Default.skill_2_cooldown);
            }
            if ((Settings.Default.skill_2_cooldown == 0) && (this.SMHSRXYGJCRREXQEFVURAR.Interval.Milliseconds != 500))
            {
                this.SMHSRXYGJCRREXQEFVURAR.Interval = new TimeSpan(0, 0, 0, 0, 500);
            }
            if (!this.NRWGLEVGYVZVNABVMPJZBZ && Settings.Default.skill_2_enabled)
            {
                this.SMHSRXYGJCRREXQEFVURAR.Start();
            }
            else if (this.NRWGLEVGYVZVNABVMPJZBZ)
            {
                this.SMHSRXYGJCRREXQEFVURAR.Stop();
            }
            if ((this.DKFYGTUSPSFUPBURNOTWFC.Interval.TotalSeconds != Settings.Default.skill_3_cooldown) && (Settings.Default.skill_3_cooldown != 0))
            {
                this.DKFYGTUSPSFUPBURNOTWFC.Interval = new TimeSpan(0, 0, Settings.Default.skill_3_cooldown);
            }
            if ((Settings.Default.skill_3_cooldown == 0) && (this.DKFYGTUSPSFUPBURNOTWFC.Interval.Milliseconds != 500))
            {
                this.DKFYGTUSPSFUPBURNOTWFC.Interval = new TimeSpan(0, 0, 0, 0, 500);
            }
            if (!this.AIZBITLQYIFXAFQUYDCWW && Settings.Default.skill_3_enabled)
            {
                this.DKFYGTUSPSFUPBURNOTWFC.Start();
            }
            else if (this.AIZBITLQYIFXAFQUYDCWW)
            {
                this.DKFYGTUSPSFUPBURNOTWFC.Stop();
            }
            if ((this.UQBHXIPGYJLUXIUVLKKQPZ.Interval.TotalSeconds != Settings.Default.skill_4_cooldown) && (Settings.Default.skill_4_cooldown != 0))
            {
                this.UQBHXIPGYJLUXIUVLKKQPZ.Interval = new TimeSpan(0, 0, Settings.Default.skill_4_cooldown);
            }
            if ((Settings.Default.skill_4_cooldown == 0) && (this.UQBHXIPGYJLUXIUVLKKQPZ.Interval.Milliseconds != 500))
            {
                this.UQBHXIPGYJLUXIUVLKKQPZ.Interval = new TimeSpan(0, 0, 0, 0, 500);
            }
            if (!this.MLBKRTBHJBAIJVFIOMVVBJ && Settings.Default.skill_4_enabled)
            {
                this.UQBHXIPGYJLUXIUVLKKQPZ.Start();
            }
            else if (this.MLBKRTBHJBAIJVFIOMVVBJ)
            {
                this.UQBHXIPGYJLUXIUVLKKQPZ.Stop();
            }
            if ((this.HUSKAMLTXRVMVQQLUPYXVG.Interval.TotalSeconds != Settings.Default.skill_5_cooldown) && (Settings.Default.skill_5_cooldown != 0))
            {
                this.HUSKAMLTXRVMVQQLUPYXVG.Interval = new TimeSpan(0, 0, Settings.Default.skill_5_cooldown);
            }
            if ((Settings.Default.skill_5_cooldown == 0) && (this.HUSKAMLTXRVMVQQLUPYXVG.Interval.Milliseconds != 500))
            {
                this.HUSKAMLTXRVMVQQLUPYXVG.Interval = new TimeSpan(0, 0, 0, 0, 500);
            }
            if (!this.MBJFNYSZHMEPVHCVGBDWGS && Settings.Default.skill_5_enabled)
            {
                this.HUSKAMLTXRVMVQQLUPYXVG.Start();
            }
            else if (this.MBJFNYSZHMEPVHCVGBDWGS)
            {
                this.HUSKAMLTXRVMVQQLUPYXVG.Stop();
            }
            if ((this.TPPBERNOQSBFQUZHMYQPRE.Interval.TotalSeconds != Settings.Default.skill_6_cooldown) && (Settings.Default.skill_6_cooldown != 0))
            {
                this.TPPBERNOQSBFQUZHMYQPRE.Interval = new TimeSpan(0, 0, Settings.Default.skill_6_cooldown);
            }
            if ((Settings.Default.skill_6_cooldown == 0) && (this.HUSKAMLTXRVMVQQLUPYXVG.Interval.Milliseconds != 500))
            {
                this.HUSKAMLTXRVMVQQLUPYXVG.Interval = new TimeSpan(0, 0, 0, 0, 500);
            }
            if (!this.XGEUZYLYWVFWGRHUCKDLM && Settings.Default.skill_6_enabled)
            {
                this.TPPBERNOQSBFQUZHMYQPRE.Start();
            }
            else if (this.XGEUZYLYWVFWGRHUCKDLM)
            {
                this.TPPBERNOQSBFQUZHMYQPRE.Stop();
            }
            if ((this.UAPGDIWCQCYZIAUCBICUOO.Interval.TotalSeconds != Settings.Default.skill_7_cooldown) && (Settings.Default.skill_7_cooldown != 0))
            {
                this.UAPGDIWCQCYZIAUCBICUOO.Interval = new TimeSpan(0, 0, Settings.Default.skill_7_cooldown);
            }
            if ((Settings.Default.skill_7_cooldown == 0) && (this.UAPGDIWCQCYZIAUCBICUOO.Interval.Milliseconds != 500))
            {
                this.UAPGDIWCQCYZIAUCBICUOO.Interval = new TimeSpan(0, 0, 0, 0, 500);
            }
            if (!this.TTPKKCIMGWENMDPTGCOXRT && Settings.Default.skill_7_enabled)
            {
                this.UAPGDIWCQCYZIAUCBICUOO.Start();
            }
            else if (this.TTPKKCIMGWENMDPTGCOXRT)
            {
                this.UAPGDIWCQCYZIAUCBICUOO.Stop();
            }
            if ((this.LULJSMFFWNWCEJNJFKWAOL.Interval.TotalSeconds != Settings.Default.skill_8_cooldown) && (Settings.Default.skill_8_cooldown != 0))
            {
                this.LULJSMFFWNWCEJNJFKWAOL.Interval = new TimeSpan(0, 0, Settings.Default.skill_8_cooldown);
            }
            if ((Settings.Default.skill_8_cooldown == 0) && (this.LULJSMFFWNWCEJNJFKWAOL.Interval.Milliseconds != 500))
            {
                this.LULJSMFFWNWCEJNJFKWAOL.Interval = new TimeSpan(0, 0, 0, 0, 500);
            }
            if (!this.TTPKKCIMGWENMDPTGCOXRT && Settings.Default.skill_8_enabled)
            {
                this.LULJSMFFWNWCEJNJFKWAOL.Start();
            }
            else if (this.NQAOXJQUALKPWRSOWJZVDX)
            {
                this.LULJSMFFWNWCEJNJFKWAOL.Stop();
            }
            if ((this.QZJMYRXJMIJXJOWVAFVPTI.Interval.TotalSeconds != Settings.Default.skill_9_cooldown) && (Settings.Default.skill_9_cooldown != 0))
            {
                this.QZJMYRXJMIJXJOWVAFVPTI.Interval = new TimeSpan(0, 0, Settings.Default.skill_9_cooldown);
            }
            if ((Settings.Default.skill_9_cooldown == 0) && (this.QZJMYRXJMIJXJOWVAFVPTI.Interval.Milliseconds != 500))
            {
                this.QZJMYRXJMIJXJOWVAFVPTI.Interval = new TimeSpan(0, 0, 0, 0, 500);
            }
            if (!this.HJDBDGUKQLVSHYQHAQTHNY && Settings.Default.skill_9_enabled)
            {
                this.QZJMYRXJMIJXJOWVAFVPTI.Start();
            }
            else if (this.HJDBDGUKQLVSHYQHAQTHNY)
            {
                this.QZJMYRXJMIJXJOWVAFVPTI.Stop();
            }
        }

        private void NLUCIUCSZOHXOFHVWDWLR(object sender, EventArgs e)
        {
            this.XGEUZYLYWVFWGRHUCKDLM = true;
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
            if (!this.UCBVJVGXAORHXVBWENTZNX.IsBusy)
            {
                this.UCBVJVGXAORHXVBWENTZNX.RunWorkerAsync();
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
            this.NRWGLEVGYVZVNABVMPJZBZ = true;
        }
    }
}

