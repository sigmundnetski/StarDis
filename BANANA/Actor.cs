namespace BANANA
{
    using System;
    using System.Windows.Threading;

    internal class Actor : IDisposable
    {
        public static ulong AIBTAETADSVMJQCOQORGNQ;
        public ulong AQKYUPTNOSBCOSRWJVDVGR;
        public ulong AZZPCHUBUBGWBDHTTLNXMK;
        public static ulong BGKLDRJXNHNOZTMKMOCXJM;
        public static ulong BIZEEBSLGRCERWXUDAQYSL;
        private DispatcherTimer CLRBYBPYJRHPXRPIXLMRWZ;
        public static ulong CSAPWUHXZZCUMKYOORAOXH;
        public static float DLVQAUAAVHTGLNOOYRBMFB;
        public float pos_x;
        public static ulong EGYLZWCJOSIDBHYEALERVR;
        public static ulong FTVUAPLECNRMPWSMSBKKQF;
        public static ulong GBNDMZTPHJYQLIXXHOIHYT;
        private UNKNOWN_maybe_LocalPlayer GWXVZWVXVPSQFZFFLVLSIH;
        public ulong GXBLDKEVDOCKUNFRLVLEFY;
        public ulong level;
        public ulong HUEBWDXESMYPDTGTUDKJIN;
        public static ulong IVJTQKQCZVGEJHLOCVJDCN;
        public ulong unitBaseAddress;
        public static ulong JXDVHDCJKCFGKZZKTIDFL;
        public ulong JZQQWHJHNNZUWCKXLVIEXK;
        public static ulong LPQTRNPHGFQYFUIKNCTZVN;
        public static ulong MTQFREQWTAJUBVZSJUQPNG;
        public ulong NRDATCBUHVRNPGZBGHSODP;
        public static float ONPZXRHWXETUZXBQNIAQCL;
        public string name;
        public ulong PQJOPFQPULKQGWMGTKAOFE;
        public static float QWSRRWNELMJLUQZAICUDPU;
        public static string QZBOLIKIOINMCFBPCAFVSH;
        public static ulong RHWULWDOSBMYRWLQALXXNX;
        public static float RYTVNETHXMNOPHAOEGYBSQ;
        public ulong SWWKCMTSFOJQDXIZAGRDLM;
        public static string UELOJGSFURQKSWSAJRMJVB;
        public static ulong VALBRDGHJCUIJZVRRXOCN;
        public static ulong VVQYFAUVMNSJCFLJEHLTC;
        public ulong WVEWPSPDRIITSTKMDOARJ;
        public static ulong YFQGFJWWXDWRYEMBWFUPDQ;
        public static ulong YZVLPMFXZDWUSQJSRIAGWW;
        public static ulong ZHUTBUVBCLTXWBKMULGBOF;
        public ulong ZIYQIPXRCILVBIMIFPIHMW;
        public float pos_y;
        private ActorList actorList;

        public Actor()
        {
            this.GWXVZWVXVPSQFZFFLVLSIH = new UNKNOWN_maybe_LocalPlayer();
            this.CLRBYBPYJRHPXRPIXLMRWZ = new DispatcherTimer();
            this.actorList = new ActorList();
            this.CLRBYBPYJRHPXRPIXLMRWZ.Interval = new TimeSpan(0, 0, 0, 0, 130);
            this.CLRBYBPYJRHPXRPIXLMRWZ.Tick += new EventHandler(this.RXOMSCTHCKMYZDEYDBVRGQ);
        }

        public Actor(ulong ptr)
        {
            this.GWXVZWVXVPSQFZFFLVLSIH = new UNKNOWN_maybe_LocalPlayer();
            this.CLRBYBPYJRHPXRPIXLMRWZ = new DispatcherTimer();
            this.actorList = new ActorList();
            this.unitBaseAddress = ptr;
            this.DHHQMKRFPNGCGEIQOIFAYX();
            this.MDEMLFCLHAJXIEPJAANIVE();
        }

        private string getActorName()
        {
            string str = "";
            try
            {
                if (BotMain.bits == "x64")
                {
                    return Memory.readString((long) Memory.readUInt64(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x10L));
                }
                if (BotMain.bits == "x86")
                {
                    str = Memory.readString((long) Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 8)));
                }
            }
            catch
            {
            }
            return str;
        }

        private float getPositionX()
        {
            float num = 0f;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return Memory.readFloat(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0xf10L);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readFloat((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0xf10));
                }
            }
            catch
            {
            }
            return num;
        }

        private ulong BNMDJHMCDQBJCALJDSNLK()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return (ulong) Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x10cL);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 180));
                }
            }
            catch
            {
            }
            return num;
        }

        private void DHHQMKRFPNGCGEIQOIFAYX()
        {
            this.HUEBWDXESMYPDTGTUDKJIN = 0L;
            this.name = "";
            this.NRDATCBUHVRNPGZBGHSODP = 0L;
            this.JZQQWHJHNNZUWCKXLVIEXK = 0L;
            this.WVEWPSPDRIITSTKMDOARJ = 0L;
            this.AZZPCHUBUBGWBDHTTLNXMK = 0L;
            this.AQKYUPTNOSBCOSRWJVDVGR = 0L;
            this.pos_x = 0f;
            this.pos_y = 0f;
        }

        public void FWOAIGZWASLDSBOJHBQAAM()
        {
            this.CLRBYBPYJRHPXRPIXLMRWZ.Start();
            this.actorList.MDEMLFCLHAJXIEPJAANIVE();
            foreach (Actor actor in this.actorList)
            {
                if (actor.NRDATCBUHVRNPGZBGHSODP == this.GWXVZWVXVPSQFZFFLVLSIH.XOMGMBEIWCEMFCOQBTWARU())
                {
                    BotMain.WNIGNVYTLOXDHCOZMJCOIG = actor.GXBLDKEVDOCKUNFRLVLEFY.ToString();
                    VALBRDGHJCUIJZVRRXOCN = actor.NRDATCBUHVRNPGZBGHSODP;
                    QZBOLIKIOINMCFBPCAFVSH = actor.name;
                    MTQFREQWTAJUBVZSJUQPNG = actor.level;
                    RHWULWDOSBMYRWLQALXXNX = actor.AZZPCHUBUBGWBDHTTLNXMK;
                    BIZEEBSLGRCERWXUDAQYSL = actor.JZQQWHJHNNZUWCKXLVIEXK;
                    EGYLZWCJOSIDBHYEALERVR = actor.GXBLDKEVDOCKUNFRLVLEFY;
                    YFQGFJWWXDWRYEMBWFUPDQ = actor.WVEWPSPDRIITSTKMDOARJ;
                    LPQTRNPHGFQYFUIKNCTZVN = actor.SWWKCMTSFOJQDXIZAGRDLM;
                    ZHUTBUVBCLTXWBKMULGBOF = actor.AQKYUPTNOSBCOSRWJVDVGR;
                    VVQYFAUVMNSJCFLJEHLTC = actor.ZIYQIPXRCILVBIMIFPIHMW;
                    IVJTQKQCZVGEJHLOCVJDCN = actor.PQJOPFQPULKQGWMGTKAOFE;
                    ONPZXRHWXETUZXBQNIAQCL = actor.pos_x;
                    DLVQAUAAVHTGLNOOYRBMFB = actor.pos_y;
                }
                this.GWXVZWVXVPSQFZFFLVLSIH.RYKXCVKVYDQOMLEQTEFMHL();
            }
        }

        private void HETFZNLEBAKRUFJYNPEINE(bool ZRPMHSFLXKSBCUIEPOECKV)
        {
            this.name = null;
            this.NRDATCBUHVRNPGZBGHSODP = 0L;
            this.JZQQWHJHNNZUWCKXLVIEXK = 0L;
            this.WVEWPSPDRIITSTKMDOARJ = 0L;
            this.AZZPCHUBUBGWBDHTTLNXMK = 0L;
            this.AQKYUPTNOSBCOSRWJVDVGR = 0L;
            this.pos_x = 0f;
            this.pos_y = 0f;
            GC.Collect();
        }

        private ulong IDPIOITEQATIAEDLWZGHFY()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return (ulong) Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x40L);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0x30));
                }
            }
            catch
            {
            }
            return num;
        }

        public void IJBBMMXADCNQFTGDDLSNTV()
        {
            foreach (Actor actor in this.actorList)
            {
                if (actor.NRDATCBUHVRNPGZBGHSODP == ZHUTBUVBCLTXWBKMULGBOF)
                {
                    FTVUAPLECNRMPWSMSBKKQF = actor.NRDATCBUHVRNPGZBGHSODP;
                    UELOJGSFURQKSWSAJRMJVB = actor.name;
                    JXDVHDCJKCFGKZZKTIDFL = actor.level;
                    YZVLPMFXZDWUSQJSRIAGWW = actor.AZZPCHUBUBGWBDHTTLNXMK;
                    AIBTAETADSVMJQCOQORGNQ = actor.JZQQWHJHNNZUWCKXLVIEXK;
                    CSAPWUHXZZCUMKYOORAOXH = actor.WVEWPSPDRIITSTKMDOARJ;
                    GBNDMZTPHJYQLIXXHOIHYT = actor.AQKYUPTNOSBCOSRWJVDVGR;
                    BGKLDRJXNHNOZTMKMOCXJM = actor.PQJOPFQPULKQGWMGTKAOFE;
                    RYTVNETHXMNOPHAOEGYBSQ = actor.pos_x;
                    QWSRRWNELMJLUQZAICUDPU = actor.pos_y;
                }
            }
        }

        private ulong LQIITOCKYROZLHSJFHEKWY()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    ulong num2 = this.QSYDHJWQXKJBRMOXDRJOTV();
                    float num3 = Memory.readFloat(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x6f4L);
                    if (num3 != 0f)
                    {
                        num = (num2 * ((ulong) 100L)) / Convert.ToUInt64(num3);
                    }
                    return num;
                }
                if (BotMain.bits == "x86")
                {
                    ulong num4 = this.IDPIOITEQATIAEDLWZGHFY();
                    float num5 = Memory.readFloat((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0x514));
                    if (num5 != 0f)
                    {
                        num = (num4 * ((ulong) 100L)) / Convert.ToUInt64(num5);
                    }
                }
            }
            catch
            {
            }
            return num;
        }

        public void MDEMLFCLHAJXIEPJAANIVE()
        {
            this.NRDATCBUHVRNPGZBGHSODP = this.UKYFERYZGTSEOKSKLEPUVN();
            this.name = this.getActorName();
            this.level = this.getActorLevel();
            this.AZZPCHUBUBGWBDHTTLNXMK = this.QPCQMYVALCHMWFRAZNIEJJ();
            this.JZQQWHJHNNZUWCKXLVIEXK = this.IDPIOITEQATIAEDLWZGHFY();
            this.GXBLDKEVDOCKUNFRLVLEFY = this.MKUBFLQGGMGLSIJJRQCIPH();
            this.WVEWPSPDRIITSTKMDOARJ = this.QSYDHJWQXKJBRMOXDRJOTV();
            this.SWWKCMTSFOJQDXIZAGRDLM = this.LQIITOCKYROZLHSJFHEKWY();
            this.ZIYQIPXRCILVBIMIFPIHMW = this.PGCADFURILJZJKHTSWWZKA();
            this.PQJOPFQPULKQGWMGTKAOFE = this.ZWOSJKZCGOHADCQMOABCJB();
            this.AQKYUPTNOSBCOSRWJVDVGR = this.ZXHDHXOSEGSQXBZJTPJSM();
            this.pos_x = this.getPositionX();
            this.pos_y = this.getPositionY();
        }

        private ulong MKUBFLQGGMGLSIJJRQCIPH()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    ulong num2 = Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x40L);
                    float num3 = Memory.readFloat(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x5e0L);
                    if (num3 != 0f)
                    {
                        num = (num2 * ((ulong) 100L)) / Convert.ToUInt64(num3);
                    }
                    return num;
                }
                if (BotMain.bits == "x86")
                {
                    ulong num4 = this.IDPIOITEQATIAEDLWZGHFY();
                    float num5 = Memory.readFloat((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0x400));
                    if (num5 != 0f)
                    {
                        num = (num4 * ((ulong) 100L)) / Convert.ToUInt64(num5);
                    }
                }
            }
            catch
            {
            }
            return num;
        }

        private ulong PGCADFURILJZJKHTSWWZKA()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return (ulong) Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x1628L);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0x126c));
                }
            }
            catch
            {
            }
            return num;
        }

        private ulong QPCQMYVALCHMWFRAZNIEJJ()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return (ulong) Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x80L);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0x58));
                }
            }
            catch
            {
            }
            return num;
        }

        private ulong QSYDHJWQXKJBRMOXDRJOTV()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return (ulong) Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x48L);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0x38));
                }
            }
            catch
            {
            }
            return num;
        }

        public void RXOMSCTHCKMYZDEYDBVRGQ(object sender, EventArgs e)
        {
            this.actorList.MDEMLFCLHAJXIEPJAANIVE();
        }

        private ulong getActorLevel()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return (ulong) Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x38L);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 40));
                }
            }
            catch
            {
            }
            return num;
        }

        void IDisposable.Dispose()
        {
            this.HETFZNLEBAKRUFJYNPEINE(false);
            GC.SuppressFinalize(this);
        }

        private float getPositionY()
        {
            float num = 0f;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return Memory.readFloat(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0xf18L);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readFloat((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0xf18));
                }
            }
            catch
            {
            }
            return num;
        }

        private ulong UKYFERYZGTSEOKSKLEPUVN()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return (ulong) Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 8L);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 4));
                }
            }
            catch
            {
            }
            return num;
        }

        public double VDPJNSYBKCLWFFCWCQYIUH(float x1, float y1, float x2, float y2)
        {
            double num2 = Math.Pow((double) (x2 - x1), 2.0);
            double num3 = Math.Pow((double) (y2 - y1), 2.0);
            double d = num2 + num3;
            return Math.Sqrt(d);
        }

        private ulong ZWOSJKZCGOHADCQMOABCJB()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return (ulong) Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x29cL);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0x1ec));
                }
            }
            catch
            {
            }
            return num;
        }

        private ulong ZXHDHXOSEGSQXBZJTPJSM()
        {
            ulong num = 0L;
            try
            {
                if (BotMain.bits == "x64")
                {
                    return (ulong) Memory.readUInt32(((long) Memory.readUInt64(((long) this.unitBaseAddress) + 0x60L)) + 0x108L);
                }
                if (BotMain.bits == "x86")
                {
                    num = Memory.readUInt32((long) (Memory.readUInt32(((long) this.unitBaseAddress) + 0x48L) + 0xb0));
                }
            }
            catch
            {
            }
            return num;
        }
    }
}

