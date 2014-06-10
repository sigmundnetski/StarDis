namespace BANANA
{
    using StarSpot.Properties;
    using System;

    internal class FMAMWYDCMCNGWDQJBXTDGZ
    {
        private ActorLocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new ActorLocalPlayer();
        private int RBPGRLHOJOYHXNNHGILBBF;
        public ulong RTHVVSJJZDRKYAZEIYZNWH;

        public void QFYYIPFSSERDWPIITSLDVC()
        {
            this.XLKSJCQLNGKLSAMSITTUUJ();
            if (this.GWXVZWVXVPSQFZFFLVLSIH.RTHVVSJJZDRKYAZEIYZNWH() != this.RTHVVSJJZDRKYAZEIYZNWH)
            {
                if ((Settings.Default.bot_1_key != "") && (this.RBPGRLHOJOYHXNNHGILBBF == 0))
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(Convert.ToInt32(Settings.Default.bot_1_key) - 1);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(Convert.ToInt32(Settings.Default.bot_1_key) - 1);
                    this.RBPGRLHOJOYHXNNHGILBBF = 1;
                }
                else if ((this.RBPGRLHOJOYHXNNHGILBBF == 0) && !Settings.Default.bot_1_use)
                {
                    this.RBPGRLHOJOYHXNNHGILBBF = 1;
                }
                if ((Settings.Default.bot_2_key != "") && (this.RBPGRLHOJOYHXNNHGILBBF == 1))
                {
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(Convert.ToInt32(Settings.Default.bot_2_key) - 1);
                    GPUFTZODSXGQIZOXSUHRFG.XHWMBOFIPJZRIBATENNNKF.WTRZRHUNGBXMXOXEDMBFMW(Convert.ToInt32(Settings.Default.bot_2_key) - 1);
                    this.RBPGRLHOJOYHXNNHGILBBF = 0;
                }
                else if ((this.RBPGRLHOJOYHXNNHGILBBF == 1) && !Settings.Default.bot_2_use)
                {
                    this.RBPGRLHOJOYHXNNHGILBBF = 0;
                }
            }
        }

        public void XLKSJCQLNGKLSAMSITTUUJ()
        {
            if ((Settings.Default.bot_1_use && !Settings.Default.bot_2_use) | (!Settings.Default.bot_1_use && Settings.Default.bot_2_use))
            {
                this.RTHVVSJJZDRKYAZEIYZNWH = 1L;
            }
            else if (Settings.Default.bot_1_use && Settings.Default.bot_2_use)
            {
                this.RTHVVSJJZDRKYAZEIYZNWH = 2L;
            }
            else if (!Settings.Default.bot_1_use && !Settings.Default.bot_2_use)
            {
                this.RTHVVSJJZDRKYAZEIYZNWH = 0L;
            }
        }
    }
}

