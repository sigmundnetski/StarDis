namespace BANANA
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml;

    internal class SGCDBRJMFPCMNUOSSHAQYE
    {
        private Version DBZYXWAIGHIPKJYKDINUAU;
        private string JJGCSJZEGLVITRKXUORCDJ;
        private Version OAZOGIWSUKLBEAEUQMOIAO;
        private XmlTextReader XCFBFVTZBWKRPWOSVPOXKU;

        public void ILSTOQQUTSSSBNZGVJSBND()
        {
            try
            {
                string url = "http://star.gplays.co/last_version.xml";
                this.XCFBFVTZBWKRPWOSVPOXKU = new XmlTextReader(url);
                this.XCFBFVTZBWKRPWOSVPOXKU.MoveToContent();
                string name = "";
                if ((this.XCFBFVTZBWKRPWOSVPOXKU.NodeType == XmlNodeType.Element) && (this.XCFBFVTZBWKRPWOSVPOXKU.Name == "ourfancyapp"))
                {
                    while (this.XCFBFVTZBWKRPWOSVPOXKU.Read())
                    {
                        if (this.XCFBFVTZBWKRPWOSVPOXKU.NodeType == XmlNodeType.Element)
                        {
                            name = this.XCFBFVTZBWKRPWOSVPOXKU.Name;
                        }
                        else
                        {
                            string str5;
                            if (((this.XCFBFVTZBWKRPWOSVPOXKU.NodeType == XmlNodeType.Text) && this.XCFBFVTZBWKRPWOSVPOXKU.HasValue) && ((str5 = name) != null))
                            {
                                if (!(str5 == "version"))
                                {
                                    if (str5 == "url")
                                    {
                                        this.JJGCSJZEGLVITRKXUORCDJ = this.XCFBFVTZBWKRPWOSVPOXKU.Value;
                                    }
                                    continue;
                                }
                                this.DBZYXWAIGHIPKJYKDINUAU = new Version(this.XCFBFVTZBWKRPWOSVPOXKU.Value);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            this.OAZOGIWSUKLBEAEUQMOIAO = Assembly.GetExecutingAssembly().GetName().Version;
            if (this.OAZOGIWSUKLBEAEUQMOIAO.CompareTo(this.DBZYXWAIGHIPKJYKDINUAU) < 0)
            {
                string caption = "Update";
                string text = "Download the new version?";
                if (DialogResult.Yes == MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Process.Start(this.JJGCSJZEGLVITRKXUORCDJ);
                    Process.GetCurrentProcess().Kill();
                }
            }
        }
    }
}

