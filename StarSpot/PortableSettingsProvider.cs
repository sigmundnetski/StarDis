namespace StarSpot
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml;

    public sealed class PortableSettingsProvider : SettingsProvider, IApplicationSettingsProvider
    {
        private const string BGECSLCWCAGPOMGNJEDZLT = "localSettings";
        private const string BSUMVSMDYARMTLEMAILJAA = "PortableSettingsProvider";
        private const string BUVDKJNXKUNIGOJSQGOSSB = "settings";
        private const string JREZNLVDMQZOGGECOAVCG = "globalSettings";
        private XmlDocument ZEKWNCEICUTKTXDOBSKFW;

        private XmlNode BCCAUDPZHGCRGTWZIBMXON(string PKHXXEZZNBUAKJCJCLEYOU)
        {
            XmlNode newChild = this.IIQKUXVRWKBDKCZPXKPVZN.SelectSingleNode(PKHXXEZZNBUAKJCJCLEYOU);
            if (newChild == null)
            {
                newChild = this.OZHKCRYZOWFBYCPHFTOHYF.CreateElement(PKHXXEZZNBUAKJCJCLEYOU);
                this.IIQKUXVRWKBDKCZPXKPVZN.AppendChild(newChild);
            }
            return newChild;
        }

        private bool BHRYQEUODFDBMBJWKPZARA(SettingsProperty PZPJVIYWYVTVUTWNLFEKT)
        {
            bool flag;
            using (IDictionaryEnumerator enumerator = PZPJVIYWYVTVUTWNLFEKT.Attributes.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DictionaryEntry current = (DictionaryEntry) enumerator.Current;
                    if (((Attribute) current.Value) is SettingsManageabilityAttribute)
                    {
                        goto Label_0038;
                    }
                }
                return false;
            Label_0038:
                flag = true;
            }
            return flag;
        }

        public XmlDocument EWLGBRQXJLSDIRNAGDKGZM()
        {
            XmlDocument document = new XmlDocument();
            document.AppendChild(document.CreateXmlDeclaration("1.0", "utf-8", string.Empty));
            document.AppendChild(document.CreateElement("settings"));
            return document;
        }

        public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property)
        {
            return new SettingsPropertyValue(property);
        }

        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection)
        {
            SettingsPropertyValueCollection values = new SettingsPropertyValueCollection();
            foreach (SettingsProperty property in collection)
            {
                SettingsPropertyValue value2 = new SettingsPropertyValue(property) {
                    SerializedValue = this.ORQDXIXSVMHEUQKWSBBRZO(property)
                };
                values.Add(value2);
            }
            return values;
        }

        private void HXCAZBDTWCIEHXVLLEVOC(SettingsPropertyValue NBBWXCLXCMCUJDCEDPPGT)
        {
            XmlNode node = this.BHRYQEUODFDBMBJWKPZARA(NBBWXCLXCMCUJDCEDPPGT.Property) ? this.QJWGRCEADNYNTGSJDTEOUA : this.CRHQAUZLDIISKVBBXKEPQY;
            XmlNode newChild = node.SelectSingleNode(string.Format("setting[@name='{0}']", NBBWXCLXCMCUJDCEDPPGT.Name));
            if (newChild != null)
            {
                newChild.InnerText = NBBWXCLXCMCUJDCEDPPGT.SerializedValue.ToString();
            }
            else
            {
                newChild = this.OZHKCRYZOWFBYCPHFTOHYF.CreateElement("setting");
                XmlAttribute attribute = this.OZHKCRYZOWFBYCPHFTOHYF.CreateAttribute("name");
                attribute.Value = NBBWXCLXCMCUJDCEDPPGT.Name;
                newChild.Attributes.Append(attribute);
                newChild.InnerText = NBBWXCLXCMCUJDCEDPPGT.SerializedValue.ToString();
                node.AppendChild(newChild);
            }
        }

        public override void Initialize(string name, NameValueCollection config)
        {
            this.Initialize(base.Name, config);
        }

        private string ORQDXIXSVMHEUQKWSBBRZO(SettingsProperty PZPJVIYWYVTVUTWNLFEKT)
        {
            XmlNode node2 = (this.BHRYQEUODFDBMBJWKPZARA(PZPJVIYWYVTVUTWNLFEKT) ? this.QJWGRCEADNYNTGSJDTEOUA : this.CRHQAUZLDIISKVBBXKEPQY).SelectSingleNode(string.Format("setting[@name='{0}']", PZPJVIYWYVTVUTWNLFEKT.Name));
            if (node2 != null)
            {
                return node2.InnerText;
            }
            if (PZPJVIYWYVTVUTWNLFEKT.DefaultValue == null)
            {
                return string.Empty;
            }
            return PZPJVIYWYVTVUTWNLFEKT.DefaultValue.ToString();
        }

        public void Reset(SettingsContext context)
        {
            this.CRHQAUZLDIISKVBBXKEPQY.RemoveAll();
            this.QJWGRCEADNYNTGSJDTEOUA.RemoveAll();
            this.ZEKWNCEICUTKTXDOBSKFW.Save(this.JWLZRBASVRTNDZPBXDMGZN);
        }

        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection)
        {
            foreach (SettingsPropertyValue value2 in collection)
            {
                this.HXCAZBDTWCIEHXVLLEVOC(value2);
            }
            try
            {
                this.OZHKCRYZOWFBYCPHFTOHYF.Save(this.JWLZRBASVRTNDZPBXDMGZN);
            }
            catch (Exception)
            {
            }
        }

        public void Upgrade(SettingsContext context, SettingsPropertyCollection properties)
        {
        }

        public override string ApplicationName
        {
            get
            {
                return Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            }
            set
            {
            }
        }

        private XmlNode CRHQAUZLDIISKVBBXKEPQY
        {
            get
            {
                XmlNode node = this.BCCAUDPZHGCRGTWZIBMXON("localSettings");
                XmlNode newChild = node.SelectSingleNode(Environment.MachineName.ToLowerInvariant());
                if (newChild == null)
                {
                    newChild = this.OZHKCRYZOWFBYCPHFTOHYF.CreateElement(Environment.MachineName.ToLowerInvariant());
                    node.AppendChild(newChild);
                }
                return newChild;
            }
        }

        private XmlNode IIQKUXVRWKBDKCZPXKPVZN
        {
            get
            {
                return this.OZHKCRYZOWFBYCPHFTOHYF.SelectSingleNode("settings");
            }
        }

        private string JWLZRBASVRTNDZPBXDMGZN
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), string.Format("{0}.settings", this.ApplicationName));
            }
        }

        public override string Name
        {
            get
            {
                return "PortableSettingsProvider";
            }
        }

        private XmlDocument OZHKCRYZOWFBYCPHFTOHYF
        {
            get
            {
                if (this.ZEKWNCEICUTKTXDOBSKFW == null)
                {
                    try
                    {
                        this.ZEKWNCEICUTKTXDOBSKFW = new XmlDocument();
                        this.ZEKWNCEICUTKTXDOBSKFW.Load(this.JWLZRBASVRTNDZPBXDMGZN);
                    }
                    catch (Exception)
                    {
                    }
                    if (this.ZEKWNCEICUTKTXDOBSKFW.SelectSingleNode("settings") != null)
                    {
                        return this.ZEKWNCEICUTKTXDOBSKFW;
                    }
                    this.ZEKWNCEICUTKTXDOBSKFW = this.EWLGBRQXJLSDIRNAGDKGZM();
                }
                return this.ZEKWNCEICUTKTXDOBSKFW;
            }
        }

        private XmlNode QJWGRCEADNYNTGSJDTEOUA
        {
            get
            {
                return this.BCCAUDPZHGCRGTWZIBMXON("globalSettings");
            }
        }
    }
}

