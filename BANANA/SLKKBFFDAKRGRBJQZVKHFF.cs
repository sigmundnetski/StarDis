namespace BANANA
{
    using StarSpot.Properties;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Threading;

    internal class SLKKBFFDAKRGRBJQZVKHFF
    {
        public static List<VCLLZOQZZPRFQHXFTLIYEY> AXRXVEDKKVVJNPJVSINZRX = new List<VCLLZOQZZPRFQHXFTLIYEY>();
        public static List<VCLLZOQZZPRFQHXFTLIYEY> BKNJDIDTZKZVAQUGUJKQDE = new List<VCLLZOQZZPRFQHXFTLIYEY>();
        public static VCLLZOQZZPRFQHXFTLIYEY DCMSTRDUGRYOYMZSFDRSU = new VCLLZOQZZPRFQHXFTLIYEY();
        public static bool DKQOMDXWTAEOEPKGOCNCBN = false;
        public static int DNWFHMUAFOWQLWZLQLXDMW;
        public static bool GSIMAEELGXXOPVXTROTLPI = false;
        private ActorLocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new ActorLocalPlayer();
        public static List<VCLLZOQZZPRFQHXFTLIYEY> HTOJOTHUVZFFJTDSCYZVU = new List<VCLLZOQZZPRFQHXFTLIYEY>();
        public static VCLLZOQZZPRFQHXFTLIYEY HVYZELUVDLIWVWHJCMMBA = new VCLLZOQZZPRFQHXFTLIYEY();
        public static VCLLZOQZZPRFQHXFTLIYEY KDMPKSEVQRRXMDWFLEKKKO = new VCLLZOQZZPRFQHXFTLIYEY();
        private bool KEHPYRMHERYSPJUXLJAUZK;
        public static int KNCIKWEVSMLSIXYJRQASQQ = 0;
        public static bool MVCSXPGFDQBHOQBXDMXFR = true;
        public bool PZYKWRSHOKRNIPDCBAIHDL;
        public static List<VCLLZOQZZPRFQHXFTLIYEY> QTJLYDMMZTKDGCSDMWKJFR = new List<VCLLZOQZZPRFQHXFTLIYEY>();
        public static List<VCLLZOQZZPRFQHXFTLIYEY> SQSQLICBVEKZQTKKDWYIH = new List<VCLLZOQZZPRFQHXFTLIYEY>();
        public static List<VCLLZOQZZPRFQHXFTLIYEY> TULVLIVEFGERTLDQXKJGID = new List<VCLLZOQZZPRFQHXFTLIYEY>();
        private Random TWOMTIPKIGWRTPWIMOAFWO = new Random();
        public static List<VCLLZOQZZPRFQHXFTLIYEY> TZQHCKVNHRYPODOQAZKFKD = new List<VCLLZOQZZPRFQHXFTLIYEY>();
        public bool UATKIFPAZKGZUCDULJTFNJ;
        public static List<VCLLZOQZZPRFQHXFTLIYEY> WBXRBHUEJFJTFZYAMJFMXT = new List<VCLLZOQZZPRFQHXFTLIYEY>();
        public static int XBCQHTMOZWYKVCIDVHXXJL = 0;
        public static DispatcherTimer ZCALHKDIEMJDKDOICKKUTS = new DispatcherTimer();
        public static int ZLISEWVYURKJXFHPRKHKMT = 0;
        public static bool ZYNCBDIDDYVTAKJKINNDEJ = true;

        public SLKKBFFDAKRGRBJQZVKHFF()
        {
            if (ZCALHKDIEMJDKDOICKKUTS.Interval.TotalSeconds != Settings.Default.unstucking_run_time)
            {
                ZCALHKDIEMJDKDOICKKUTS.Interval = new TimeSpan(0, 0, Settings.Default.unstucking_run_time);
            }
            ZCALHKDIEMJDKDOICKKUTS.Tick += new EventHandler(this.OCEWTBFKGMPBXWMTGCUUIZ);
        }

        public void BVGTUDXMSFLQFOZJAGVJDY()
        {
            if (ZCALHKDIEMJDKDOICKKUTS.Interval.TotalSeconds != Settings.Default.unstucking_run_time)
            {
                ZCALHKDIEMJDKDOICKKUTS.Interval = new TimeSpan(0, 0, Settings.Default.unstucking_run_time);
            }
        }

        public void GUSAVLPPDGIIHEIFIRRQLK()
        {
            this.BVGTUDXMSFLQFOZJAGVJDY();
            this.GWXVZWVXVPSQFZFFLVLSIH.GJQAQRZBQCAXVUZDFWJJFM(1.5f);
            if (!GSIMAEELGXXOPVXTROTLPI)
            {
                if (!this.KEHPYRMHERYSPJUXLJAUZK)
                {
                    try
                    {
                        if ((this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0) | (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L))
                        {
                            if (this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0)
                            {
                                BotMain.WBPDVOTSWETWJCQGKKDRNL = string.Concat(new object[] { "Walking to spot: ", ZLISEWVYURKJXFHPRKHKMT.ToString(), "\nX: ", HVYZELUVDLIWVWHJCMMBA.AQICOOHQONIPEAIZQBONX, " Y: ", HVYZELUVDLIWVWHJCMMBA.ODYHEMSITJPFSFDDEEYCXM });
                                ZLISEWVYURKJXFHPRKHKMT++;
                                HVYZELUVDLIWVWHJCMMBA = QTJLYDMMZTKDGCSDMWKJFR[ZLISEWVYURKJXFHPRKHKMT];
                                ZCALHKDIEMJDKDOICKKUTS.Stop();
                            }
                            DNWFHMUAFOWQLWZLQLXDMW = this.TWOMTIPKIGWRTPWIMOAFWO.Next(-2, 2);
                            this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ(HVYZELUVDLIWVWHJCMMBA.AQICOOHQONIPEAIZQBONX + DNWFHMUAFOWQLWZLQLXDMW);
                            this.GWXVZWVXVPSQFZFFLVLSIH.MQKILWWCATKXVNGAHQUZOS(HVYZELUVDLIWVWHJCMMBA.ODYHEMSITJPFSFDDEEYCXM + DNWFHMUAFOWQLWZLQLXDMW);
                            ZCALHKDIEMJDKDOICKKUTS.Start();
                            if (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L)
                            {
                                this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(0);
                            }
                        }
                    }
                    catch
                    {
                        this.KEHPYRMHERYSPJUXLJAUZK = true;
                        BotMain.WBPDVOTSWETWJCQGKKDRNL = "Reached the last spot. Looping on.";
                    }
                }
                else
                {
                    try
                    {
                        if ((this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0) | (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L))
                        {
                            if (this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0)
                            {
                                BotMain.WBPDVOTSWETWJCQGKKDRNL = string.Concat(new object[] { "Walking to spot: ", ZLISEWVYURKJXFHPRKHKMT.ToString(), "\nX: ", HVYZELUVDLIWVWHJCMMBA.AQICOOHQONIPEAIZQBONX, " Y: ", HVYZELUVDLIWVWHJCMMBA.ODYHEMSITJPFSFDDEEYCXM });
                                ZLISEWVYURKJXFHPRKHKMT--;
                                HVYZELUVDLIWVWHJCMMBA = QTJLYDMMZTKDGCSDMWKJFR[ZLISEWVYURKJXFHPRKHKMT];
                                ZCALHKDIEMJDKDOICKKUTS.Stop();
                            }
                            DNWFHMUAFOWQLWZLQLXDMW = this.TWOMTIPKIGWRTPWIMOAFWO.Next(-2, 2);
                            this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ(HVYZELUVDLIWVWHJCMMBA.AQICOOHQONIPEAIZQBONX + DNWFHMUAFOWQLWZLQLXDMW);
                            this.GWXVZWVXVPSQFZFFLVLSIH.MQKILWWCATKXVNGAHQUZOS(HVYZELUVDLIWVWHJCMMBA.ODYHEMSITJPFSFDDEEYCXM + DNWFHMUAFOWQLWZLQLXDMW);
                            ZCALHKDIEMJDKDOICKKUTS.Start();
                            if (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L)
                            {
                                this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(0);
                            }
                        }
                    }
                    catch
                    {
                        this.KEHPYRMHERYSPJUXLJAUZK = false;
                        BotMain.WBPDVOTSWETWJCQGKKDRNL = "Reached the last spot. Looping off.";
                    }
                }
            }
            else
            {
                this.VXUJYYLJUTPHCDEWCBJIW();
            }
        }

        public void KIMJMCIIIFLQNAWTKNIFEK()
        {
            this.GWXVZWVXVPSQFZFFLVLSIH.GJQAQRZBQCAXVUZDFWJJFM(1.5f);
            if (!this.PZYKWRSHOKRNIPDCBAIHDL)
            {
                try
                {
                    if ((this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0) | (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L))
                    {
                        if (this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0)
                        {
                            BotMain.WBPDVOTSWETWJCQGKKDRNL = string.Concat(new object[] { "Walking to selling spot: ", XBCQHTMOZWYKVCIDVHXXJL.ToString(), "\nX: ", KDMPKSEVQRRXMDWFLEKKKO.AQICOOHQONIPEAIZQBONX, " Y: ", KDMPKSEVQRRXMDWFLEKKKO.ODYHEMSITJPFSFDDEEYCXM });
                            XBCQHTMOZWYKVCIDVHXXJL++;
                            KDMPKSEVQRRXMDWFLEKKKO = SQSQLICBVEKZQTKKDWYIH[XBCQHTMOZWYKVCIDVHXXJL];
                            ZCALHKDIEMJDKDOICKKUTS.Stop();
                        }
                        this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ(KDMPKSEVQRRXMDWFLEKKKO.AQICOOHQONIPEAIZQBONX + DNWFHMUAFOWQLWZLQLXDMW);
                        this.GWXVZWVXVPSQFZFFLVLSIH.MQKILWWCATKXVNGAHQUZOS(KDMPKSEVQRRXMDWFLEKKKO.ODYHEMSITJPFSFDDEEYCXM + DNWFHMUAFOWQLWZLQLXDMW);
                        ZCALHKDIEMJDKDOICKKUTS.Start();
                        if (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L)
                        {
                            this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(0);
                        }
                    }
                }
                catch
                {
                    Thread.Sleep(0x3e8);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.AHMWMHWINRPJYDTSIOHLOY();
                    int num = new Random().Next(500, 0x3e8);
                    Thread.Sleep((int) (0xfa0 + num));
                    this.PZYKWRSHOKRNIPDCBAIHDL = true;
                }
            }
            else
            {
                try
                {
                    if ((this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0) | (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L))
                    {
                        if (this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0)
                        {
                            BotMain.WBPDVOTSWETWJCQGKKDRNL = string.Concat(new object[] { "Walking to selling spot: ", XBCQHTMOZWYKVCIDVHXXJL.ToString(), "\nX: ", KDMPKSEVQRRXMDWFLEKKKO.AQICOOHQONIPEAIZQBONX, " Y: ", KDMPKSEVQRRXMDWFLEKKKO.ODYHEMSITJPFSFDDEEYCXM });
                            XBCQHTMOZWYKVCIDVHXXJL--;
                            KDMPKSEVQRRXMDWFLEKKKO = SQSQLICBVEKZQTKKDWYIH[XBCQHTMOZWYKVCIDVHXXJL];
                            ZCALHKDIEMJDKDOICKKUTS.Stop();
                        }
                        this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ(KDMPKSEVQRRXMDWFLEKKKO.AQICOOHQONIPEAIZQBONX + DNWFHMUAFOWQLWZLQLXDMW);
                        this.GWXVZWVXVPSQFZFFLVLSIH.MQKILWWCATKXVNGAHQUZOS(KDMPKSEVQRRXMDWFLEKKKO.ODYHEMSITJPFSFDDEEYCXM + DNWFHMUAFOWQLWZLQLXDMW);
                        ZCALHKDIEMJDKDOICKKUTS.Start();
                        if (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L)
                        {
                            this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(0);
                        }
                    }
                }
                catch
                {
                    this.PZYKWRSHOKRNIPDCBAIHDL = false;
                    DKQOMDXWTAEOEPKGOCNCBN = true;
                }
            }
        }

        public double MLTDWHLEQVNFQHANPYHTXJ()
        {
            try
            {
                return Math.Sqrt(Math.Pow((double) Math.Abs((float) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ())), 2.0) + Math.Pow((double) Math.Abs((float) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ())), 2.0));
            }
            catch
            {
                return 0.0;
            }
        }

        private void OCEWTBFKGMPBXWMTGCUUIZ(object sender, EventArgs e)
        {
            if (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)
            {
                GSIMAEELGXXOPVXTROTLPI = true;
                ZCALHKDIEMJDKDOICKKUTS.Stop();
            }
        }

        public void OPUOYMJIVVANLNZRTPYXXB()
        {
            this.GWXVZWVXVPSQFZFFLVLSIH.GJQAQRZBQCAXVUZDFWJJFM(1.5f);
            if ((ZYNCBDIDDYVTAKJKINNDEJ && MVCSXPGFDQBHOQBXDMXFR) && ((AXRXVEDKKVVJNPJVSINZRX.Count != 0) && (BKNJDIDTZKZVAQUGUJKQDE.Count != 0)))
            {
                double num = this.VDPJNSYBKCLWFFCWCQYIUH(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPUNKNOWN_probably_position_y_relatedHHVWDGGDDDIOC(), BKNJDIDTZKZVAQUGUJKQDE[0].AQICOOHQONIPEAIZQBONX, BKNJDIDTZKZVAQUGUJKQDE[0].ODYHEMSITJPFSFDDEEYCXM);
                double num2 = this.VDPJNSYBKCLWFFCWCQYIUH(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPUNKNOWN_probably_position_y_relatedHHVWDGGDDDIOC(), AXRXVEDKKVVJNPJVSINZRX[0].AQICOOHQONIPEAIZQBONX, AXRXVEDKKVVJNPJVSINZRX[0].ODYHEMSITJPFSFDDEEYCXM);
                if (num <= num2)
                {
                    BotMain.WBPDVOTSWETWJCQGKKDRNL = "Chosen the first death spots list.";
                    DCMSTRDUGRYOYMZSFDRSU = BKNJDIDTZKZVAQUGUJKQDE[KNCIKWEVSMLSIXYJRQASQQ];
                    ZYNCBDIDDYVTAKJKINNDEJ = true;
                    MVCSXPGFDQBHOQBXDMXFR = false;
                }
                else
                {
                    BotMain.WBPDVOTSWETWJCQGKKDRNL = "Chosen the second death spots list.";
                    DCMSTRDUGRYOYMZSFDRSU = AXRXVEDKKVVJNPJVSINZRX[KNCIKWEVSMLSIXYJRQASQQ];
                    ZYNCBDIDDYVTAKJKINNDEJ = false;
                    MVCSXPGFDQBHOQBXDMXFR = true;
                }
            }
            else if ((ZYNCBDIDDYVTAKJKINNDEJ && MVCSXPGFDQBHOQBXDMXFR) && ((AXRXVEDKKVVJNPJVSINZRX.Count != 0) && (BKNJDIDTZKZVAQUGUJKQDE.Count == 0)))
            {
                BotMain.WBPDVOTSWETWJCQGKKDRNL = "Chosen the second death spots list.";
                DCMSTRDUGRYOYMZSFDRSU = AXRXVEDKKVVJNPJVSINZRX[KNCIKWEVSMLSIXYJRQASQQ];
                ZYNCBDIDDYVTAKJKINNDEJ = false;
                MVCSXPGFDQBHOQBXDMXFR = true;
            }
            else if ((ZYNCBDIDDYVTAKJKINNDEJ && MVCSXPGFDQBHOQBXDMXFR) && ((AXRXVEDKKVVJNPJVSINZRX.Count == 0) && (BKNJDIDTZKZVAQUGUJKQDE.Count != 0)))
            {
                BotMain.WBPDVOTSWETWJCQGKKDRNL = "Chosen the first death spots list.";
                DCMSTRDUGRYOYMZSFDRSU = BKNJDIDTZKZVAQUGUJKQDE[KNCIKWEVSMLSIXYJRQASQQ];
                ZYNCBDIDDYVTAKJKINNDEJ = true;
                MVCSXPGFDQBHOQBXDMXFR = false;
            }
            if (!this.UATKIFPAZKGZUCDULJTFNJ)
            {
                if (ZYNCBDIDDYVTAKJKINNDEJ && !MVCSXPGFDQBHOQBXDMXFR)
                {
                    try
                    {
                        if ((this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0) | (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L))
                        {
                            if (this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0)
                            {
                                BotMain.WBPDVOTSWETWJCQGKKDRNL = string.Concat(new object[] { "Walking to death spot: ", KNCIKWEVSMLSIXYJRQASQQ.ToString(), "\nX: ", DCMSTRDUGRYOYMZSFDRSU.AQICOOHQONIPEAIZQBONX, " Y: ", DCMSTRDUGRYOYMZSFDRSU.ODYHEMSITJPFSFDDEEYCXM });
                                KNCIKWEVSMLSIXYJRQASQQ++;
                                DCMSTRDUGRYOYMZSFDRSU = BKNJDIDTZKZVAQUGUJKQDE[KNCIKWEVSMLSIXYJRQASQQ];
                                ZCALHKDIEMJDKDOICKKUTS.Stop();
                            }
                            this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ(DCMSTRDUGRYOYMZSFDRSU.AQICOOHQONIPEAIZQBONX);
                            this.GWXVZWVXVPSQFZFFLVLSIH.MQKILWWCATKXVNGAHQUZOS(DCMSTRDUGRYOYMZSFDRSU.ODYHEMSITJPFSFDDEEYCXM);
                            ZCALHKDIEMJDKDOICKKUTS.Start();
                            if (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L)
                            {
                                this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(0);
                            }
                        }
                    }
                    catch
                    {
                        this.UATKIFPAZKGZUCDULJTFNJ = true;
                        KNCIKWEVSMLSIXYJRQASQQ = 0;
                        DEFMKWCASKDJTSTMDRZXZB.WNPWMLGYKHQHSHHHXNKUMP = false;
                    }
                }
                else if (!ZYNCBDIDDYVTAKJKINNDEJ && MVCSXPGFDQBHOQBXDMXFR)
                {
                    try
                    {
                        if ((this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0) | (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L))
                        {
                            if (this.MLTDWHLEQVNFQHANPYHTXJ() <= 5.0)
                            {
                                BotMain.WBPDVOTSWETWJCQGKKDRNL = string.Concat(new object[] { "Walking to death spot: ", KNCIKWEVSMLSIXYJRQASQQ.ToString(), "\nX: ", DCMSTRDUGRYOYMZSFDRSU.AQICOOHQONIPEAIZQBONX, " Y: ", DCMSTRDUGRYOYMZSFDRSU.ODYHEMSITJPFSFDDEEYCXM });
                                KNCIKWEVSMLSIXYJRQASQQ++;
                                DCMSTRDUGRYOYMZSFDRSU = AXRXVEDKKVVJNPJVSINZRX[KNCIKWEVSMLSIXYJRQASQQ];
                                ZCALHKDIEMJDKDOICKKUTS.Stop();
                            }
                            this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ(DCMSTRDUGRYOYMZSFDRSU.AQICOOHQONIPEAIZQBONX);
                            this.GWXVZWVXVPSQFZFFLVLSIH.MQKILWWCATKXVNGAHQUZOS(DCMSTRDUGRYOYMZSFDRSU.ODYHEMSITJPFSFDDEEYCXM);
                            ZCALHKDIEMJDKDOICKKUTS.Start();
                            if (this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ() != 0L)
                            {
                                this.GWXVZWVXVPSQFZFFLVLSIH.TKNUHDORYWIYUZRFPABJIZ(0);
                            }
                        }
                    }
                    catch
                    {
                        this.UATKIFPAZKGZUCDULJTFNJ = true;
                        KNCIKWEVSMLSIXYJRQASQQ = 0;
                        DEFMKWCASKDJTSTMDRZXZB.WNPWMLGYKHQHSHHHXNKUMP = false;
                    }
                }
            }
        }

        public void QGGEKJHLBKLILDXDSCKVXV()
        {
            try
            {
                if (ZLISEWVYURKJXFHPRKHKMT > 0)
                {
                    HVYZELUVDLIWVWHJCMMBA = QTJLYDMMZTKDGCSDMWKJFR[ZLISEWVYURKJXFHPRKHKMT - 1];
                    this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ(HVYZELUVDLIWVWHJCMMBA.AQICOOHQONIPEAIZQBONX);
                    this.GWXVZWVXVPSQFZFFLVLSIH.MQKILWWCATKXVNGAHQUZOS(HVYZELUVDLIWVWHJCMMBA.ODYHEMSITJPFSFDDEEYCXM);
                }
                else
                {
                    HVYZELUVDLIWVWHJCMMBA = QTJLYDMMZTKDGCSDMWKJFR[0];
                    this.GWXVZWVXVPSQFZFFLVLSIH.LPSIXUGIDZJJLTHYGIUYUJ(HVYZELUVDLIWVWHJCMMBA.AQICOOHQONIPEAIZQBONX);
                    this.GWXVZWVXVPSQFZFFLVLSIH.MQKILWWCATKXVNGAHQUZOS(HVYZELUVDLIWVWHJCMMBA.ODYHEMSITJPFSFDDEEYCXM);
                }
            }
            catch
            {
            }
        }

        public double VDPJNSYBKCLWFFCWCQYIUH(float EKGGWAGOFFBBACUALHXKNW, float PBPEDFXAFWBHRBOHPLHZIK, float EWSLCUROGGXFSVDDMHDMQM, float PAINLVMZHUMPENNFXLOEIN)
        {
            double num2 = Math.Pow((double) (EWSLCUROGGXFSVDDMHDMQM - EKGGWAGOFFBBACUALHXKNW), 2.0);
            double num3 = Math.Pow((double) (PAINLVMZHUMPENNFXLOEIN - PBPEDFXAFWBHRBOHPLHZIK), 2.0);
            double d = num2 + num3;
            return Math.Sqrt(d);
        }

        public void VXUJYYLJUTPHCDEWCBJIW()
        {
            int num = new Random().Next(0, 50);
            BotMain.WBPDVOTSWETWJCQGKKDRNL = "Stuck! Try to unstuck.";
            if (GSIMAEELGXXOPVXTROTLPI)
            {
                for (int i = 0; i < 50; i++)
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.IFZVQHOOIQSKQARADJMDL();
                    if ((num >= 0) && (num <= 0x19))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.ZCUQCWOYQVXOBWWATQJYAD();
                    }
                    if ((num >= 0x19) && (num <= 0x23))
                    {
                        GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.MMFGPDFOPGNAUJDIQXLKDJ();
                    }
                    if (i > 0x2d)
                    {
                        GSIMAEELGXXOPVXTROTLPI = false;
                        return;
                    }
                }
            }
        }

        public class VCLLZOQZZPRFQHXFTLIYEY
        {
            public float AQICOOHQONIPEAIZQBONX;
            public float ODYHEMSITJPFSFDDEEYCXM;

            public void KAVCNTBCZDRUUCNPTJQTAQ()
            {
                this.AQICOOHQONIPEAIZQBONX = 0f;
                this.ODYHEMSITJPFSFDDEEYCXM = 0f;
            }

            public void ULZUMOBHRDDPCZYSQWJIWO(float PUVQYIBKSLRUKNJSPVJCUW, float QYLNMMALKKURJVMMMBHNPY)
            {
                this.AQICOOHQONIPEAIZQBONX = PUVQYIBKSLRUKNJSPVJCUW;
                this.ODYHEMSITJPFSFDDEEYCXM = QYLNMMALKKURJVMMMBHNPY;
            }
        }
    }
}

