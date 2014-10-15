using System;
using System.Data;
using System.IO;
using System.Xml;
namespace AppleRobot
{
    internal class XmlControl
    {
        protected string strXmlFile;
        protected XmlDocument objXmlDoc;
        public XmlControl(string XmlFile)
        {
            Class2.e1eQOijzrvtg6();
            this.objXmlDoc = new XmlDocument();
            try
            {
                this.objXmlDoc.Load(XmlFile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            this.strXmlFile = XmlFile;
        }
        public XmlControl()
        {
            Class2.e1eQOijzrvtg6();
            this.objXmlDoc = new XmlDocument();
        }
        public void XmlLoadXml(string xmlstr)
        {
            try
            {
                this.objXmlDoc.LoadXml(xmlstr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataView GetData(string XmlPathNode)
        {
            DataSet dataSet = new DataSet();
            DataView result = null;
            XmlNode xmlNode = this.objXmlDoc.SelectSingleNode(XmlPathNode);
            if (xmlNode != null)
            {
                StringReader reader = new StringReader(this.objXmlDoc.SelectSingleNode(XmlPathNode).OuterXml);
                dataSet.ReadXml(reader);
                if (dataSet.Tables.Count > 0)
                {
                    result = dataSet.Tables[0].DefaultView;
                }
            }
            return result;
        }
        public void Replace(string XmlPathNode, string Content)
        {
            this.objXmlDoc.SelectSingleNode(XmlPathNode).InnerText = Content;
        }
        public void Delete(string Node)
        {
            string xpath = Node.Substring(0, Node.LastIndexOf("/"));
            this.objXmlDoc.SelectSingleNode(xpath).RemoveChild(this.objXmlDoc.SelectSingleNode(Node));
        }
        public void InsertNode(string MainNode, string ChildNode)
        {
            XmlNode xmlNode = this.objXmlDoc.SelectSingleNode(MainNode);
            XmlElement newChild = this.objXmlDoc.CreateElement(ChildNode);
            xmlNode.AppendChild(newChild);
        }
        public void InsertNode(string MainNode, string ChildNode, string Element, string Content)
        {
            XmlNode xmlNode = this.objXmlDoc.SelectSingleNode(MainNode);
            XmlElement xmlElement = this.objXmlDoc.CreateElement(ChildNode);
            xmlNode.AppendChild(xmlElement);
            XmlElement xmlElement2 = this.objXmlDoc.CreateElement(Element);
            xmlElement2.InnerText = Content;
            xmlElement.AppendChild(xmlElement2);
        }
        public void InsertElement(string MainNode, string Element, string[] Attrib, string[] AttribContent, string Content)
        {
            XmlNode xmlNode = this.objXmlDoc.SelectSingleNode(MainNode);
            XmlElement xmlElement = this.objXmlDoc.CreateElement(Element);
            int num = 0;
            for (int i = 0; i < Attrib.Length; i++)
            {
                string name = Attrib[i];
                xmlElement.SetAttribute(name, AttribContent[num]);
                num++;
            }
            xmlElement.InnerText = Content;
            xmlNode.AppendChild(xmlElement);
        }
        public void InsertElement(string MainNode, string Element, string Content)
        {
            XmlNode xmlNode = this.objXmlDoc.SelectSingleNode(MainNode);
            XmlElement xmlElement = this.objXmlDoc.CreateElement(Element);
            xmlElement.InnerText = Content;
            xmlNode.AppendChild(xmlElement);
        }
        public void Save()
        {
            try
            {
                this.objXmlDoc.Save(this.strXmlFile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            this.objXmlDoc = null;
        }
    }
}
