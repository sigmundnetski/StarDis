namespace BANANA
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class LZSIIQDBXDTGHSONUMUKMH : Form
    {
        private PictureBox AJDEFPDSZXEULKIVPEAELQ;
        public const int BCZFODSKDFQDZTMCXJWHEI = 2;
        private IContainer BVBMQOSXDEITDBDBZHIUBY;
        private const int CYIZQUAJZRYKCXYMVTWSYG = 0x11f;
        private Label EYSUEMPAQIWOEBWYHQTHT;
        private UNKNOWN_maybe_LocalPlayer GWXVZWVXVPSQFZFFLVLSIH = new UNKNOWN_maybe_LocalPlayer();
        private static int LPRBGJOTPEVZBJNZBTKDYI = 0x11f;
        private int MHCHBCUIULJZPJMQEQJNEL;
        private ArrayList NYMKJRUYFOFOIFULTJRARO = new ArrayList();
        private Timer OMPPKSVYMXWCASPZKRJCHI;
        private static int OVLPSEQWIBOLJRWJPVGNOT = 0x146;
        public const int QKUUEFAVRAJXBRGUWRREH = 0xa1;
        private Label RHCBNZGUHTLFRSNZWQIYG;
        private BackgroundWorker UCBVJVGXAORHXVBWENTZNX = new BackgroundWorker();
        private Bitmap VMNXQBOLMMWQNJXUVJHZRK = new Bitmap(LPRBGJOTPEVZBJNZBTKDYI, OVLPSEQWIBOLJRWJPVGNOT);
        private Random WDHNVMFYOLGHUAEJNENZD = new Random();
        private float XCXHLTUDDWSTFGKRSERRMB = 5f;
        private Color YSOXQTTWIBTDXUMTESDXHJ = Color.Blue;
        private const float YXGIRKTNZHWQGSUPVYLYBT = 531.5f;
        private ActorList ZZQKNJJCSBGCBDSBXXHPSN = new ActorList();

        public LZSIIQDBXDTGHSONUMUKMH()
        {
            this.HWODEJLMLOOLACIADGKJLV();
            this.UCBVJVGXAORHXVBWENTZNX.DoWork += new DoWorkEventHandler(this.IMBVXZKHKSQVWSAOGGIEJ);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.BVBMQOSXDEITDBDBZHIUBY != null))
            {
                this.BVBMQOSXDEITDBDBZHIUBY.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FNHDCEGFESZNLDWXJTLTMG(object sender, EventArgs e)
        {
            if (!this.UCBVJVGXAORHXVBWENTZNX.IsBusy)
            {
                this.UCBVJVGXAORHXVBWENTZNX.RunWorkerAsync();
            }
        }

        private Bitmap GYCIZQIFPBHWADJESQXKLN(Bitmap IXDRUXMEMDMYEVPOCNSTDR, Color WCQAEKCGZKQDHXRLBBTJZA, float RLDQQERNXSODUEXIVRGFVU, float XEWPFRLVKCZEDUCOSVZSQC, string PBJHBRBDXOZXNCNNOFLTAL)
        {
            Graphics graphics = Graphics.FromImage(IXDRUXMEMDMYEVPOCNSTDR);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            SolidBrush brush = new SolidBrush(WCQAEKCGZKQDHXRLBBTJZA);
            Pen pen = new Pen(WCQAEKCGZKQDHXRLBBTJZA, 2f);
            graphics.ResetTransform();
            graphics.TranslateTransform(-RLDQQERNXSODUEXIVRGFVU, -XEWPFRLVKCZEDUCOSVZSQC, MatrixOrder.Append);
            graphics.TranslateTransform(RLDQQERNXSODUEXIVRGFVU, XEWPFRLVKCZEDUCOSVZSQC, MatrixOrder.Append);
            try
            {
                graphics.FillEllipse(brush, (float) (RLDQQERNXSODUEXIVRGFVU - 2f), (float) (XEWPFRLVKCZEDUCOSVZSQC - 2f), (float) 5f, (float) 5f);
                this.OSYBTSKEDBTELYGMQZJCZI(IXDRUXMEMDMYEVPOCNSTDR, PBJHBRBDXOZXNCNNOFLTAL, Convert.ToInt32(RLDQQERNXSODUEXIVRGFVU) - Convert.ToInt32((double) (PBJHBRBDXOZXNCNNOFLTAL.Length * 2.5)), Convert.ToInt32(XEWPFRLVKCZEDUCOSVZSQC) + 8);
            }
            catch (Exception)
            {
            }
            graphics.Dispose();
            brush.Dispose();
            pen.Dispose();
            return IXDRUXMEMDMYEVPOCNSTDR;
        }

        private void HWODEJLMLOOLACIADGKJLV()
        {
            this.BVBMQOSXDEITDBDBZHIUBY = new Container();
            this.AJDEFPDSZXEULKIVPEAELQ = new PictureBox();
            this.OMPPKSVYMXWCASPZKRJCHI = new Timer(this.BVBMQOSXDEITDBDBZHIUBY);
            this.EYSUEMPAQIWOEBWYHQTHT = new Label();
            this.RHCBNZGUHTLFRSNZWQIYG = new Label();
            ((ISupportInitialize) this.AJDEFPDSZXEULKIVPEAELQ).BeginInit();
            this.SuspendLayout();
            this.AJDEFPDSZXEULKIVPEAELQ.BackColor = Color.FromArgb(14, 14, 14);
            this.AJDEFPDSZXEULKIVPEAELQ.Location = new Point(12, 0x2d);
            this.AJDEFPDSZXEULKIVPEAELQ.Name = "RadarBox";
            this.AJDEFPDSZXEULKIVPEAELQ.Size = new Size(0x146, 0x11f);
            this.AJDEFPDSZXEULKIVPEAELQ.TabIndex = 0;
            this.AJDEFPDSZXEULKIVPEAELQ.TabStop = false;
            this.OMPPKSVYMXWCASPZKRJCHI.Enabled = true;
            this.OMPPKSVYMXWCASPZKRJCHI.Interval = 350;
            this.OMPPKSVYMXWCASPZKRJCHI.Tick += new EventHandler(this.FNHDCEGFESZNLDWXJTLTMG);
            this.EYSUEMPAQIWOEBWYHQTHT.AutoSize = true;
            this.EYSUEMPAQIWOEBWYHQTHT.BackColor = Color.Transparent;
            this.EYSUEMPAQIWOEBWYHQTHT.Font = new Font("Segoe UI", 15f);
            this.EYSUEMPAQIWOEBWYHQTHT.ForeColor = Color.FromArgb(0, 0x74, 0xdd);
            this.EYSUEMPAQIWOEBWYHQTHT.Location = new Point(12, 9);
            this.EYSUEMPAQIWOEBWYHQTHT.Name = "radar_label";
            this.EYSUEMPAQIWOEBWYHQTHT.Size = new Size(0x3f, 0x1c);
            this.EYSUEMPAQIWOEBWYHQTHT.TabIndex = 2;
            this.EYSUEMPAQIWOEBWYHQTHT.Text = "Radar";
            this.RHCBNZGUHTLFRSNZWQIYG.AutoSize = true;
            this.RHCBNZGUHTLFRSNZWQIYG.BackColor = Color.Transparent;
            this.RHCBNZGUHTLFRSNZWQIYG.Font = new Font("Arial Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.RHCBNZGUHTLFRSNZWQIYG.ForeColor = Color.White;
            this.RHCBNZGUHTLFRSNZWQIYG.Location = new Point(0x13e, 0x10);
            this.RHCBNZGUHTLFRSNZWQIYG.Name = "radar_close_btn";
            this.RHCBNZGUHTLFRSNZWQIYG.Size = new Size(0x11, 0x11);
            this.RHCBNZGUHTLFRSNZWQIYG.TabIndex = 3;
            this.RHCBNZGUHTLFRSNZWQIYG.Text = "X";
            this.RHCBNZGUHTLFRSNZWQIYG.Click += new EventHandler(this.UPJOIKWCWZKYCIWYVHGJMW);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(20, 20, 20);
            this.ClientSize = new Size(0x15f, 0x158);
            this.Controls.Add(this.RHCBNZGUHTLFRSNZWQIYG);
            this.Controls.Add(this.EYSUEMPAQIWOEBWYHQTHT);
            this.Controls.Add(this.AJDEFPDSZXEULKIVPEAELQ);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Radar";
            this.Opacity = 0.95;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Radar";
            this.TopMost = true;
            this.MouseDown += new MouseEventHandler(this.KQYOLPCNRKIAHCYWMXRSPU);
            ((ISupportInitialize) this.AJDEFPDSZXEULKIVPEAELQ).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void IMBVXZKHKSQVWSAOGGIEJ(object sender, DoWorkEventArgs e)
        {
            if (this.Visible)
            {
                this.MHCHBCUIULJZPJMQEQJNEL = (int) (287f * (this.XCXHLTUDDWSTFGKRSERRMB / 0.5f));
                this.POMDAEUPYHOCDFRMFAEQDP(ref this.VMNXQBOLMMWQNJXUVJHZRK);
                try
                {
                    this.ZZQKNJJCSBGCBDSBXXHPSN.MDEMLFCLHAJXIEPJAANIVE();
                    try
                    {
                        this.QPESGLISTQQSPQMISHVJFE();
                    }
                    catch
                    {
                    }
                    foreach (Actor actor in this.ZZQKNJJCSBGCBDSBXXHPSN)
                    {
                        if (actor.JZQQWHJHNNZUWCKXLVIEXK > 0L)
                        {
                            this.VMNXQBOLMMWQNJXUVJHZRK = this.GYCIZQIFPBHWADJESQXKLN(this.VMNXQBOLMMWQNJXUVJHZRK, this.YSOXQTTWIBTDXUMTESDXHJ, ((this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related()) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2), ((this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related()) * this.XCXHLTUDDWSTFGKRSERRMB) + (LPRBGJOTPEVZBJNZBTKDYI / 2), "Player");
                        }
                        if (((actor.JZQQWHJHNNZUWCKXLVIEXK > 0L) && (actor.name != this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_name_related())) && ((actor.pos_x != this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related()) && (actor.pos_y != this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related())))
                        {
                            this.VMNXQBOLMMWQNJXUVJHZRK = this.GYCIZQIFPBHWADJESQXKLN(this.VMNXQBOLMMWQNJXUVJHZRK, Color.Khaki, ((this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - actor.pos_x) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2), ((this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - actor.pos_y) * this.XCXHLTUDDWSTFGKRSERRMB) + (LPRBGJOTPEVZBJNZBTKDYI / 2), actor.name);
                        }
                    }
                    this.AJDEFPDSZXEULKIVPEAELQ.Image = this.VMNXQBOLMMWQNJXUVJHZRK;
                    this.AJDEFPDSZXEULKIVPEAELQ.Update();
                }
                catch
                {
                }
            }
        }

        private void KQYOLPCNRKIAHCYWMXRSPU(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xa1, 2, 0);
            }
        }

        private Bitmap OSYBTSKEDBTELYGMQZJCZI(Bitmap IXDRUXMEMDMYEVPOCNSTDR, string IMQYFPCTUBXWWJCJTEXMA, int RLDQQERNXSODUEXIVRGFVU, int XEWPFRLVKCZEDUCOSVZSQC)
        {
            Graphics graphics = Graphics.FromImage(IXDRUXMEMDMYEVPOCNSTDR);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            Font font = new Font("Arial", 8f);
            graphics.DrawString(IMQYFPCTUBXWWJCJTEXMA, font, Brushes.LightGray, (PointF) new Point(RLDQQERNXSODUEXIVRGFVU, XEWPFRLVKCZEDUCOSVZSQC));
            graphics.Dispose();
            font.Dispose();
            return IXDRUXMEMDMYEVPOCNSTDR;
        }

        private void POMDAEUPYHOCDFRMFAEQDP(ref Bitmap IXDRUXMEMDMYEVPOCNSTDR)
        {
            Graphics graphics = Graphics.FromImage(IXDRUXMEMDMYEVPOCNSTDR);
            graphics.Clear(this.AJDEFPDSZXEULKIVPEAELQ.BackColor);
            graphics.Dispose();
        }

        private void QPESGLISTQQSPQMISHVJFE()
        {
            Graphics graphics = Graphics.FromImage(this.VMNXQBOLMMWQNJXUVJHZRK);
            if (SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR.Count != 0)
            {
                int num = 0;
                PointF tf = new PointF(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related());
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey in SLKKBFFDAKRGRBJQZVKHFF.QTJLYDMMZTKDGCSDMWKJFR)
                {
                    if (SLKKBFFDAKRGRBJQZVKHFF.HVYZELUVDLIWVWHJCMMBA == vcllzoqzzprfqhxftliyey)
                    {
                        graphics.DrawEllipse(new Pen(new SolidBrush(Color.DeepSkyBlue)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                        num++;
                        if (((num > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey.AQICOOHQONIPEAIZQBONX - tf.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey.ODYHEMSITJPFSFDDEEYCXM - tf.Y)) <= 100f))
                        {
                            graphics.DrawLine(new Pen(new SolidBrush(Color.DeepSkyBlue)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                        }
                        tf = new PointF(vcllzoqzzprfqhxftliyey.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey.ODYHEMSITJPFSFDDEEYCXM);
                    }
                    else
                    {
                        graphics.DrawEllipse(new Pen(new SolidBrush(Color.SkyBlue)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                        num++;
                        if (((num > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey.AQICOOHQONIPEAIZQBONX - tf.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey.ODYHEMSITJPFSFDDEEYCXM - tf.Y)) <= 100f))
                        {
                            graphics.DrawLine(new Pen(new SolidBrush(Color.SkyBlue)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                        }
                        tf = new PointF(vcllzoqzzprfqhxftliyey.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey.ODYHEMSITJPFSFDDEEYCXM);
                    }
                }
            }
            else
            {
                int num2 = 0;
                PointF tf2 = new PointF(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related());
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey2 in SLKKBFFDAKRGRBJQZVKHFF.TZQHCKVNHRYPODOQAZKFKD)
                {
                    graphics.DrawEllipse(new Pen(new SolidBrush(Color.DeepSkyBlue)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey2.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey2.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                    num2++;
                    if (((num2 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey2.AQICOOHQONIPEAIZQBONX - tf2.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey2.ODYHEMSITJPFSFDDEEYCXM - tf2.Y)) <= 100f))
                    {
                        graphics.DrawLine(new Pen(new SolidBrush(Color.DeepSkyBlue)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf2.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf2.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey2.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey2.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                    }
                    tf2 = new PointF(vcllzoqzzprfqhxftliyey2.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey2.ODYHEMSITJPFSFDDEEYCXM);
                }
            }
            if (SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE.Count != 0)
            {
                int num3 = 0;
                PointF tf3 = new PointF(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related());
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey3 in SLKKBFFDAKRGRBJQZVKHFF.BKNJDIDTZKZVAQUGUJKQDE)
                {
                    if (SLKKBFFDAKRGRBJQZVKHFF.DCMSTRDUGRYOYMZSFDRSU == vcllzoqzzprfqhxftliyey3)
                    {
                        graphics.DrawEllipse(new Pen(new SolidBrush(Color.Crimson)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey3.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey3.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                        num3++;
                        if (((num3 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey3.AQICOOHQONIPEAIZQBONX - tf3.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey3.ODYHEMSITJPFSFDDEEYCXM - tf3.Y)) <= 100f))
                        {
                            graphics.DrawLine(new Pen(new SolidBrush(Color.Crimson)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf3.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf3.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey3.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey3.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                        }
                        tf3 = new PointF(vcllzoqzzprfqhxftliyey3.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey3.ODYHEMSITJPFSFDDEEYCXM);
                    }
                    else
                    {
                        graphics.DrawEllipse(new Pen(new SolidBrush(Color.DeepPink)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey3.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey3.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                        num3++;
                        if (((num3 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey3.AQICOOHQONIPEAIZQBONX - tf3.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey3.ODYHEMSITJPFSFDDEEYCXM - tf3.Y)) <= 100f))
                        {
                            graphics.DrawLine(new Pen(new SolidBrush(Color.DeepPink)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf3.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf3.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey3.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey3.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                        }
                        tf3 = new PointF(vcllzoqzzprfqhxftliyey3.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey3.ODYHEMSITJPFSFDDEEYCXM);
                    }
                }
            }
            else
            {
                int num4 = 0;
                PointF tf4 = new PointF(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related());
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey4 in SLKKBFFDAKRGRBJQZVKHFF.TULVLIVEFGERTLDQXKJGID)
                {
                    graphics.DrawEllipse(new Pen(new SolidBrush(Color.Crimson)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey4.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey4.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                    num4++;
                    if (((num4 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey4.AQICOOHQONIPEAIZQBONX - tf4.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey4.ODYHEMSITJPFSFDDEEYCXM - tf4.Y)) <= 100f))
                    {
                        graphics.DrawLine(new Pen(new SolidBrush(Color.Crimson)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf4.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf4.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey4.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey4.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                    }
                    tf4 = new PointF(vcllzoqzzprfqhxftliyey4.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey4.ODYHEMSITJPFSFDDEEYCXM);
                }
            }
            if (SLKKBFFDAKRGRBJQZVKHFF.AXRXVEDKKVVJNPJVSINZRX.Count != 0)
            {
                int num5 = 0;
                PointF tf5 = new PointF(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related());
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey5 in SLKKBFFDAKRGRBJQZVKHFF.AXRXVEDKKVVJNPJVSINZRX)
                {
                    if (SLKKBFFDAKRGRBJQZVKHFF.DCMSTRDUGRYOYMZSFDRSU == vcllzoqzzprfqhxftliyey5)
                    {
                        graphics.DrawEllipse(new Pen(new SolidBrush(Color.Crimson)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey5.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey5.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                        num5++;
                        if (((num5 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey5.AQICOOHQONIPEAIZQBONX - tf5.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey5.ODYHEMSITJPFSFDDEEYCXM - tf5.Y)) <= 100f))
                        {
                            graphics.DrawLine(new Pen(new SolidBrush(Color.Crimson)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf5.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf5.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey5.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey5.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                        }
                        tf5 = new PointF(vcllzoqzzprfqhxftliyey5.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey5.ODYHEMSITJPFSFDDEEYCXM);
                    }
                    else
                    {
                        graphics.DrawEllipse(new Pen(new SolidBrush(Color.OrangeRed)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey5.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey5.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                        num5++;
                        if (((num5 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey5.AQICOOHQONIPEAIZQBONX - tf5.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey5.ODYHEMSITJPFSFDDEEYCXM - tf5.Y)) <= 100f))
                        {
                            graphics.DrawLine(new Pen(new SolidBrush(Color.DeepPink)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf5.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf5.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey5.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey5.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                        }
                        tf5 = new PointF(vcllzoqzzprfqhxftliyey5.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey5.ODYHEMSITJPFSFDDEEYCXM);
                    }
                }
            }
            else
            {
                int num6 = 0;
                PointF tf6 = new PointF(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related());
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey6 in SLKKBFFDAKRGRBJQZVKHFF.HTOJOTHUVZFFJTDSCYZVU)
                {
                    graphics.DrawEllipse(new Pen(new SolidBrush(Color.Crimson)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey6.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey6.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                    num6++;
                    if (((num6 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey6.AQICOOHQONIPEAIZQBONX - tf6.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey6.ODYHEMSITJPFSFDDEEYCXM - tf6.Y)) <= 100f))
                    {
                        graphics.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf6.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf6.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey6.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey6.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                    }
                    tf6 = new PointF(vcllzoqzzprfqhxftliyey6.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey6.ODYHEMSITJPFSFDDEEYCXM);
                }
            }
            if (SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH.Count != 0)
            {
                int num7 = 0;
                PointF tf7 = new PointF(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related());
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey7 in SLKKBFFDAKRGRBJQZVKHFF.SQSQLICBVEKZQTKKDWYIH)
                {
                    if (SLKKBFFDAKRGRBJQZVKHFF.KDMPKSEVQRRXMDWFLEKKKO == vcllzoqzzprfqhxftliyey7)
                    {
                        graphics.DrawEllipse(new Pen(new SolidBrush(Color.Yellow)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey7.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey7.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                        num7++;
                        if (((num7 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey7.AQICOOHQONIPEAIZQBONX - tf7.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey7.ODYHEMSITJPFSFDDEEYCXM - tf7.Y)) <= 100f))
                        {
                            graphics.DrawLine(new Pen(new SolidBrush(Color.Yellow)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf7.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf7.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey7.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey7.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                        }
                        tf7 = new PointF(vcllzoqzzprfqhxftliyey7.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey7.ODYHEMSITJPFSFDDEEYCXM);
                    }
                    else
                    {
                        graphics.DrawEllipse(new Pen(new SolidBrush(Color.Gold)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey7.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey7.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                        num7++;
                        if (((num7 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey7.AQICOOHQONIPEAIZQBONX - tf7.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey7.ODYHEMSITJPFSFDDEEYCXM - tf7.Y)) <= 100f))
                        {
                            graphics.DrawLine(new Pen(new SolidBrush(Color.Gold)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf7.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf7.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey7.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey7.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                        }
                        tf7 = new PointF(vcllzoqzzprfqhxftliyey7.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey7.ODYHEMSITJPFSFDDEEYCXM);
                    }
                }
            }
            else
            {
                int num8 = 0;
                PointF tf8 = new PointF(this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related(), this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related());
                foreach (SLKKBFFDAKRGRBJQZVKHFF.VCLLZOQZZPRFQHXFTLIYEY vcllzoqzzprfqhxftliyey8 in SLKKBFFDAKRGRBJQZVKHFF.WBXRBHUEJFJTFZYAMJFMXT)
                {
                    graphics.DrawEllipse(new Pen(new SolidBrush(Color.Yellow)), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey8.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey8.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (float) 2f, (float) 2f);
                    num8++;
                    if (((num8 > 1) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey8.AQICOOHQONIPEAIZQBONX - tf8.X)) <= 100f)) && (Math.Abs((float) (vcllzoqzzprfqhxftliyey8.ODYHEMSITJPFSFDDEEYCXM - tf8.Y)) <= 100f))
                    {
                        graphics.DrawLine(new Pen(new SolidBrush(Color.Yellow)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - tf8.X)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - tf8.Y)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)), new Point((int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_x_related() - vcllzoqzzprfqhxftliyey8.AQICOOHQONIPEAIZQBONX)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f), (int) (((((int) (this.GWXVZWVXVPSQFZFFLVLSIH.UNKNOWN_probably_position_y_related() - vcllzoqzzprfqhxftliyey8.ODYHEMSITJPFSFDDEEYCXM)) * this.XCXHLTUDDWSTFGKRSERRMB) + (OVLPSEQWIBOLJRWJPVGNOT / 2)) - 3f)));
                    }
                    tf8 = new PointF(vcllzoqzzprfqhxftliyey8.AQICOOHQONIPEAIZQBONX, vcllzoqzzprfqhxftliyey8.ODYHEMSITJPFSFDDEEYCXM);
                }
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr DMSIZKJOXVTPBMLWXABFQW, int PIMRZGSTKYTBMZUIPJDWCI, int TAHKQSBMRZNJPIYVAIXTOZ, int LSXXVOVJNPNYKCBJKUCKE);
        private void UPJOIKWCWZKYCIWYVHGJMW(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

