using System;
namespace AppleRobot
{
    [Serializable]
    public class StoreInfo : IComparable
    {
        public string m_Name;
        public string m_sName;
        public string m_Code;
        public int m_level;
        public DateTime m_LastTime;
        public APtimeslots[] timeslots;
        public int CompareTo(object right)
        {
            if (!(right is StoreInfo))
            {
                throw new ArgumentException("参数必须为StoreInfo类型");
            }
            return this.m_level.CompareTo(((StoreInfo)right).m_level);
        }
        public StoreInfo()
        {
            Class2.e1eQOijzrvtg6();
        }
    }
}
