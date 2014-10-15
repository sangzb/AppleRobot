using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace AppleRobot
{
    [Serializable]
    public class ProductInfo : IComparable, ICloneable
    {
        public string m_Name;
        public string m_Code;
        public string m_Type;
        public string m_Size;
        public string m_Color;
        public string m_Product;
        public int m_level;
        public DateTime m_LastTime;
        public string m_State;
        public int m_iState;
        public StoreInfo m_Store;
        public ListViewItem m_lsItem;
        public int m_iCount;
        public object Clone()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, this);
            memoryStream.Seek(0L, SeekOrigin.Begin);
            object result = binaryFormatter.Deserialize(memoryStream);
            memoryStream.Close();
            return result;
        }
        public int CompareTo(object right)
        {
            if (!(right is ProductInfo))
            {
                throw new ArgumentException("参数必须为ProductInfo类型");
            }
            return this.m_level.CompareTo(((ProductInfo)right).m_level);
        }
        public ProductInfo()
        {
            Class2.e1eQOijzrvtg6();
        }
    }
}
