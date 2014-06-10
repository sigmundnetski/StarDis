namespace BANANA
{
    using StarSpot.Properties;
    using System;
    using System.Windows.Threading;

    internal class LNPAERUPWRFPRBNXPEJUC
    {
        private ActorLocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new ActorLocalPlayer();
        private DispatcherTimer NWNBSJIEDNSJYXFUDUZDWO = new DispatcherTimer();

        public LNPAERUPWRFPRBNXPEJUC()
        {
            this.NWNBSJIEDNSJYXFUDUZDWO.Interval = new TimeSpan(0, 0, Settings.Default.random_jumping_timer);
            this.NWNBSJIEDNSJYXFUDUZDWO.Tick += new EventHandler(this.JMQWCMRGYALLHYPRAKGRTY);
        }

        private void JMQWCMRGYALLHYPRAKGRTY(object sender, EventArgs e)
        {
            for (int i = 0; i < 0x19; i++)
            {
                GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.IFZVQHOOIQSKQARADJMDL();
            }
            int num2 = new Random().Next(0, 5);
            this.NWNBSJIEDNSJYXFUDUZDWO.Interval = new TimeSpan(0, 0, Settings.Default.random_jumping_timer + num2);
            this.NWNBSJIEDNSJYXFUDUZDWO.Stop();
        }

        public void TDZIHHCODZICDXEMBPWPKG()
        {
            if (this.GWXVZWVXVPSQFZFFLVLSIH.UTHABDUUQVRDYRWUBGOAGV() == 0L)
            {
                this.NWNBSJIEDNSJYXFUDUZDWO.Start();
            }
            else
            {
                this.NWNBSJIEDNSJYXFUDUZDWO.Stop();
            }
        }
    }
}

