namespace BANANA
{
    using StarSpot.Properties;
    using System;
    using System.Windows.Threading;

    internal class JUOKUMIRAYZBFSPPNVCVOW
    {
        private UNKNOWN_maybe_LocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new UNKNOWN_maybe_LocalPlayer();
        private ulong MFVJPXZVHJJPMGJRQKTVGE;
        public static bool WHWLSCJEYGBHLTTYPFVUTL;
        private double unknown_distance_related;
        private DispatcherTimer YENKJXKHSNKIHUDGHIXANT = new DispatcherTimer();
        private ActorList ZZQKNJJCSBGCBDSBXXHPSN = new ActorList();

        public JUOKUMIRAYZBFSPPNVCVOW()
        {
            this.YENKJXKHSNKIHUDGHIXANT.Tick += new EventHandler(this.DBNIZTMOMTUVQDGIQAVDXK);
        }

        public void DBNIZTMOMTUVQDGIQAVDXK(object sender, EventArgs e)
        {
            WHWLSCJEYGBHLTTYPFVUTL = true;
        }

        public void JGFNMNYWCGWHYZKOAKETVN()
        {
            this.TXIHJHGQPZMXPJCOOQLXHS();
            if (Settings.Default.player_detection_radius != 0)
            {
                this.ZZQKNJJCSBGCBDSBXXHPSN.MDEMLFCLHAJXIEPJAANIVE();
                try
                {
                    foreach (Actor UNKNOWN_offset_related in this.ZZQKNJJCSBGCBDSBXXHPSN)
                    {
                        if (((UNKNOWN_offset_related.AZZPCHUBUBGWBDHTTLNXMK == 20L) && (UNKNOWN_offset_related.NRDATCBUHVRNPGZBGHSODP != this.GWXVZWVXVPSQFZFFLVLSIH.RYKXCVKVYDQOMLEQTEFMHL())) && (this.MFVJPXZVHJJPMGJRQKTVGE == 0L))
                        {
                            this.unknown_distance_related = this.distance(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related(), UNKNOWN_offset_related.pos_x, UNKNOWN_offset_related.pos_y);
                        }
                        if (((UNKNOWN_offset_related.AZZPCHUBUBGWBDHTTLNXMK == 20L) && (this.unknown_distance_related <= Settings.Default.player_detection_radius)) && ((this.MFVJPXZVHJJPMGJRQKTVGE == 0L) && (this.unknown_distance_related <= Settings.Default.player_detection_radius)))
                        {
                            BotMain.log_msg = "Player detected! Name: " + UNKNOWN_offset_related.name + " Level: " + UNKNOWN_offset_related.level.ToString() + ".";
                            this.YENKJXKHSNKIHUDGHIXANT.Start();
                            this.MFVJPXZVHJJPMGJRQKTVGE = UNKNOWN_offset_related.NRDATCBUHVRNPGZBGHSODP;
                        }
                        if ((UNKNOWN_offset_related.NRDATCBUHVRNPGZBGHSODP == this.MFVJPXZVHJJPMGJRQKTVGE) && (this.MFVJPXZVHJJPMGJRQKTVGE != 0L))
                        {
                            this.unknown_distance_related = this.distance(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related(), UNKNOWN_offset_related.pos_x, UNKNOWN_offset_related.pos_y);
                            if (this.unknown_distance_related > Settings.Default.player_detection_radius)
                            {
                                BotMain.log_msg = "Player out of range! Name: " + UNKNOWN_offset_related.name + " Level: " + UNKNOWN_offset_related.level.ToString() + ".";
                                this.YENKJXKHSNKIHUDGHIXANT.Stop();
                                WHWLSCJEYGBHLTTYPFVUTL = false;
                                this.MFVJPXZVHJJPMGJRQKTVGE = 0L;
                            }
                        }
                    }
                }
                catch
                {
                }
            }
        }

        public void TXIHJHGQPZMXPJCOOQLXHS()
        {
            this.YENKJXKHSNKIHUDGHIXANT.Tick += new EventHandler(this.DBNIZTMOMTUVQDGIQAVDXK);
            if (Settings.Default.player_detection_min == 0)
            {
                if (this.YENKJXKHSNKIHUDGHIXANT.Interval.TotalSeconds != 1.0)
                {
                    this.YENKJXKHSNKIHUDGHIXANT.Interval = new TimeSpan(0, 0, 1);
                }
            }
            else if (this.YENKJXKHSNKIHUDGHIXANT.Interval.TotalSeconds != Settings.Default.player_detection_min)
            {
                this.YENKJXKHSNKIHUDGHIXANT.Interval = new TimeSpan(0, 0, Settings.Default.player_detection_min);
            }
        }

        public double distance(float x1, float y1, float x2, float y2)
        {
            double num2 = Math.Pow((double) (x2 - x1), 2.0);
            double num3 = Math.Pow((double) (y2 - y1), 2.0);
            double d = num2 + num3;
            return Math.Sqrt(d);
        }
    }
}

