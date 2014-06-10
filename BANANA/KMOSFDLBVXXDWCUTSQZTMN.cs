namespace BANANA
{
    using StarSpot.Properties;
    using System;
    using System.Linq;
    using System.Windows.Threading;

    internal class KMOSFDLBVXXDWCUTSQZTMN
    {
        public static bool FDUUXKIXHIHSDNFZVTASCE;
        private ActorLocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new ActorLocalPlayer();
        private DispatcherTimer QASVYDVQGMOFSFBRZGMZMT = new DispatcherTimer();
        private string[] TOOMVDUDARVUZZVHEVRKGZ = new string[20];
        private ActorList ZZQKNJJCSBGCBDSBXXHPSN = new ActorList();

        public KMOSFDLBVXXDWCUTSQZTMN()
        {
            this.QASVYDVQGMOFSFBRZGMZMT.Interval = new TimeSpan(0, 0, 0, 0, 100);
            this.QASVYDVQGMOFSFBRZGMZMT.Tick += new EventHandler(this.XUCQIGRISDRXMMIPURFRM);
            this.QASVYDVQGMOFSFBRZGMZMT.Start();
        }

        public void XUCQIGRISDRXMMIPURFRM(object sender, EventArgs e)
        {
            if (GameUnit.VALBRDGHJCUIJZVRRXOCN != 0L)
            {
                if (this.TOOMVDUDARVUZZVHEVRKGZ.Contains<string>(GameUnit.QZBOLIKIOINMCFBPCAFVSH) | (GameUnit.MTQFREQWTAJUBVZSJUQPNG <= Convert.ToUInt64(Settings.Default.level_range)))
                {
                    FDUUXKIXHIHSDNFZVTASCE = true;
                }
                else
                {
                    FDUUXKIXHIHSDNFZVTASCE = false;
                }
            }
            try
            {
                this.TOOMVDUDARVUZZVHEVRKGZ = Settings.Default.blacklist_npcs.Split(new char[] { ',' });
            }
            catch
            {
            }
        }
    }
}

