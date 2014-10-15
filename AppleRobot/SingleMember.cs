using System;
using System.Net;
using System.Threading;
namespace AppleRobot
{
    public class SingleMember
    {
        public enum Step_TYPE_
        {
            Step_TYPE_None,
            Step_TYPE_SStarted,
            Step_TYPE_Logined,
            Step_TYPE_PhoneCodeIned,
            Step_TYPE_Fault,
            Step_TYPE_Succes
        }
        public string m_AppleID;
        public string m_ApplePass;
        public string m_cookies;
        public string m_sHeader;
        public string m_sServer;
        public string m_Action;
        public string m_appIdKey;
        public string m_token;
        public string m_url;
        public string m_Lasturl;
        public string m_UrlStepWait;
        public string m_UrlStepLogin;
        public string m_UrlStepPhoneCode;
        public string m_UrlStepSelect;
        public string m_PCode;
        public string m_sms;
        public string m_smsRe;
        public string openiForgotInNewWindow;
        public string fdcBrowserData;
        public string captchaAudioInput;
        public string language;
        public string path;
        public string rv;
        public string sslEnabled;
        public string Env;
        public string errors;
        public string lastErrors;
        public string m_JSESSIONID;
        public bool m_bPCodeOk;
        public InfoTable m_SelectInfo;
        public ReservInfo m_ReservInfo;
        public string _flowExecutionKey;
        public string p_ie;
        public AutoResetEvent m_AutoEvent;
        public Mutex m_CheckMutex;
        public DateTime m_RobModeLastTime;
        public WebHeaderCollection m_cHeaders;
        public CookieContainer m_CookieCon;
        public StoreInfo m_SelectedStore;
        public SingleMember.Step_TYPE_ m_Steps;
        public bool m_LastTimeCheck;
        public string m_LoginPageStr;
        public bool m_bPCodeSetOk;
        public SingleMember()
        {
            Class2.e1eQOijzrvtg6();
            this.m_LoginPageStr = "";
            this.m_AppleID = "";
            this.m_ApplePass = "";
            this.m_cookies = "";
            this.m_sHeader = "";
            this.m_sServer = "";
            this.m_Action = "";
            this.m_appIdKey = "";
            this.m_token = "";
            this.m_url = "";
            this.m_Lasturl = "";
            this.p_ie = "";
            this.lastErrors = "";
            this.errors = "";
            this.m_bPCodeSetOk = false;
            this.m_LastTimeCheck = false;
            this.m_bPCodeOk = false;
            this.m_cHeaders = null;
            this.m_CookieCon = null;
            this.m_SelectInfo = null;
            this.m_ReservInfo.m_ServerRTime = 0;
            this.m_ReservInfo.m_ServerRTimeMax = 0;
            this.m_ReservInfo.m_LeastTime = 60;
            this.m_ReservInfo.m_FirstName = "";
            this.m_ReservInfo.m_LastName = "";
            this.m_SelectedStore = null;
            this._flowExecutionKey = "";
            this.m_AutoEvent = new AutoResetEvent(false);
            this.m_CheckMutex = new Mutex();
            this.m_Steps = SingleMember.Step_TYPE_.Step_TYPE_None;
        }
        public bool CheckValidTime()
        {
            bool flag = false;
            StoreInfo storeInfo = null;
            if (this.m_SelectInfo.iRobIndex > -1)
            {
                storeInfo = this.m_SelectInfo.m_Prodects[this.m_SelectInfo.iRobIndex].m_Store;
            }
            if (storeInfo != null && storeInfo.timeslots != null)
            {
                int num = 0;
                APtimeslots aPtimeslots = null;
                APtimeslots aPtimeslots2 = null;
                APtimeslots[] timeslots = storeInfo.timeslots;
                for (int i = 0; i < timeslots.Length; i++)
                {
                    APtimeslots aPtimeslots3 = timeslots[i];
                    int num2 = aPtimeslots3.m_RTime;
                    if (num2 == 24)
                    {
                        num2 = 23;
                    }
                    DateTime d = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, num2, 0, 0);
                    d = d.AddHours(1.0);
                    TimeSpan timeSpan = d - DateTime.Now;
                    if (this.m_ReservInfo.m_RTime <= aPtimeslots3.m_RTime && this.m_ReservInfo.m_RTimeMax >= aPtimeslots3.m_RTime)
                    {
                        if (this.m_ReservInfo.m_LeastTime > 0)
                        {
                            if (timeSpan.TotalMinutes > (double)this.m_ReservInfo.m_LeastTime)
                            {
                                aPtimeslots2 = aPtimeslots3;
                            }
                        }
                        else
                        {
                            aPtimeslots2 = aPtimeslots3;
                        }
                    }
                    if (num == 0)
                    {
                        this.m_ReservInfo.m_ServerRTime = aPtimeslots3.m_RTime;
                        this.m_ReservInfo.m_ServerRTimeMax = aPtimeslots3.m_RTime + 1;
                    }
                    else
                    {
                        this.m_ReservInfo.m_ServerRTimeMax = aPtimeslots3.m_RTime;
                    }
                    num++;
                    if (!this.m_LastTimeCheck || !aPtimeslots3.m_used)
                    {
                        if (aPtimeslots2 != null)
                        {
                            break;
                        }
                        aPtimeslots = aPtimeslots3;
                    }
                }
                flag = true;
                if (aPtimeslots2 == null)
                {
                    aPtimeslots2 = aPtimeslots;
                }
                this.m_SelectInfo.RobtimeLots = aPtimeslots2;
                this.m_SelectInfo.RobtimeLots.m_used = true;
            }
            if (!flag)
            {
                this.m_SelectInfo.RobtimeLots = null;
            }
            return flag;
        }
        public int GetNextValidIndex()
        {
            int num = -1;
            int num2 = this.m_SelectInfo.iRobIndex + 1;
            while ((long)num2 < (long)((ulong)this.m_SelectInfo.m_Count))
            {
                if (this.m_SelectInfo.m_Prodects[num2].m_level != 0 && this.m_SelectInfo.m_Prodects[num2].m_iState == 1)
                {
                    num = num2;
                    this.m_SelectInfo.m_Prodects[num2].m_iState = 2;
                    this.m_SelectInfo.iRobIndex = num;
                    return num;
                }
                num2++;
            }
            return num;
        }
        public ProductInfo GetRobProduct()
        {
            ProductInfo result = null;
            if (this.m_SelectInfo != null && this.m_SelectInfo.iRobIndex > -1)
            {
                result = this.m_SelectInfo.m_Prodects[this.m_SelectInfo.iRobIndex];
            }
            return result;
        }
        public void method_0(string sAppleID, string sApplePass)
        {
        }
        public string GetPartNumbers(string storecode)
        {
            string text = "";
            if (this.m_SelectInfo != null)
            {
                int num = 0;
                ProductInfo[] prodects = this.m_SelectInfo.m_Prodects;
                for (int i = 0; i < prodects.Length; i++)
                {
                    ProductInfo productInfo = prodects[i];
                    if (productInfo.m_level > 0 && productInfo.m_Store.m_Code == storecode)
                    {
                        if (num == 0)
                        {
                            text = productInfo.m_Code;
                        }
                        else
                        {
                            text = text + "," + productInfo.m_Code;
                        }
                        num++;
                    }
                }
            }
            return text;
        }
    }
}
