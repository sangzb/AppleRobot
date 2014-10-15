using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Web.Script.Serialization;
namespace AppleRobot
{
    public class MainForm : Form
    {

        public enum LOG_TYPE
        {
            LOG_TYPE_No,
            LOG_TYPE_Step,
            LOG_TYPE_Suc,
            LOG_TYPE_Warning,
            LOG_TYPE_Err
        }
        public class ThreadStore
        {
            public SingleMember m_Member;
            public StoreInfo[] m_Store;
            public Thread m_Thread;
            public ThreadStore()
            {
                Class2.e1eQOijzrvtg6();
            }
        }
        public delegate void DelegateOnTextChange(TextBox textBox, string str);
        public delegate void GDelegate0(Stream streamPic);
        public delegate void DelegateOnLog(string str, MainForm.LOG_TYPE iLevel);
        public delegate void DelegateOnEnableButton(Button button, bool enable);
        public delegate void DelegateOnChangeButtonText(Button button, string strText);
        public delegate void DelegateOnCheckChange(CheckBox checkBox, bool bChecked);
        public delegate void DelegateOnRadio(RadioButton radioButton, bool bChecked);
        public delegate void DelegateOnString(string str);
        public delegate void DelegateOnUpdate();
        public delegate string DelegateGetString();
        public delegate void DelegateListvieItemTextChange(ListViewItem item, int itemKey, string itemValue, Color itemColor);
        public delegate void DelegateOnFormStr(SingleMember mMember, string strState);
        public const int m_SoftWareType = 1;
        public const string m_CopyRight = "Cracked By Jameshero";
        public int m_Country;
        public int m_ARCountry;
        public int m_SoftMode;
        public static string m_p;
        public static string m_sConfigPath;
        public static string m_ssPath;
        public static string m_sUserConfigPath;
        public static string m_sNodeReserve;
        public static string m_sUserMainNode;
        public static string m_sNodeReserveAll;
        public int m_MutexWait;
        public bool m_bServerOK;
        public volatile int m_DelayFresh;
        public static string[] m_UserConfigKeys;
        public static string[] m_URLSteps;
        public static string[] m_URLStepsPublic;
        public static string[] m_URLLanguageJP;
        public static string[] m_URLLanguageCA;
        public static string[] m_URLLanguageAU;
        public static string[] m_URLLanguageGB;
        public static string[] m_URLLanguageHK;
        public static string[] m_URLLanguageCN;
        public static string[] m_URLLanguageDE;
        public static string fdbstr;
        public static string m_APPID;
        public SingleMember m_MemberA;
        public static string m_s;
        public static string m_i;
        public StoreInfo[] m_Stores;
        public ProductInfo[] m_Products;
        public string m_StoreText;
        public string[,] ErrorConvert;
        public int iErrorCount;
        public int m_voiceType;
        public static string[] m_sIDTypes;
        public static string[] m_sIDTypesStr;
        private string newurl = "";
        private Thread m_ThreadFW;
        private Thread m_ThreadPCode;
        private Thread m_ThreadLogin;
        private Thread m_ThreadPhoneCode;
        private Thread m_ThreadSound;
        private Thread m_ThreadSelectPost;
        private MainForm.ThreadStore[] m_ThreadCheckStore;
        private bool m_bPCodeOk;
        private bool m_bPCodeSetOk;
        private InfoTable m_InfoTable;
        private IContainer components;
        private ListView listView_Appleid;
        private ColumnHeader AppleID;
        private ColumnHeader Password;
        private ListView listView_ReserveData;
        private ColumnHeader Phone;
        private ColumnHeader LastName;
        private ColumnHeader FirstName;
        private ColumnHeader columnHeader_0;
        private ColumnHeader IDNum;
        private TextBox textBox_AppleID;
        private TextBox textBox_ApplePass;
        private TextBox textBox_PhoneNum;
        private GroupBox groupBox1;
        private Button button_AID_Up;
        private Button button_AID_Del;
        private Button button_AID_Add;
        private ComboBox comboBox_IDType;
        private TextBox textBox_IDNum;
        private TextBox textBox_FName;
        private TextBox textBox_LName;
        private Button button_Data_Up;
        private Button button_Data_Del;
        private Button button_Data_Add;
        private ColumnHeader rtime;
        private PictureBox pictureBox_Code;
        private PictureBox pictureBox_PhoneCode;
        private TextBox textBox_pCode;
        private Button button_Refresh;
        private Button button_Login;
        private Label label_TextSend;
        private TextBox textBox_PhoneCode;
        private Button button_Copy;
        private TextBox textBox_PhoneR;
        private Label label_TextR;
        private Button button_Paste;
        private Label label3;
        private CheckBox checkBox_FreshWait;
        private Button button_Start_FW;
        private Label label4;
        private TextBox textBox_Delay_FW;
        private Button button_StartPost;
        private GroupBox groupBox3;
        private ListView listView_Select;
        private ColumnHeader cName;
        private ColumnHeader cStore;
        private ColumnHeader cState;
        private ColumnHeader cLevel;
        private CheckBox checkBox_AutoCopy;
        private Button button_PhoneVerify;
        private CheckBox checkBox_AutoVerify;
        private ColumnHeader RTimeMax;
        private ColumnHeader email;
        private TextBox textBox_RTimeMax;
        private TextBox textBox_RTime;
        private TextBox textBox_EMail;
        private Label label6;
        private TextBox textBox_StoreReDelay;
        private Button button_Stop;
        private ComboBox comboBox_Stores;
        private Label label7;
        private ColumnHeader tMin;
        private TextBox textBox_TimeLeast;
        private RichTextBox richTextBox_Log;
        private CheckBox checkBox_AutoStart;
        private Label label_Log;
        private GroupBox groupBox2;
        private RadioButton radioButton_ModeScan;
        private RadioButton radioButton_ModeRob;
        private ColumnHeader count;
        private TextBox textBox_Count;
        private Label label8;
        private Label label_AppleID;
        private ColumnHeader cCount;
        private CheckBox checkBox_Voice;
        private Ocr ocr;
        public MainForm()
        {
            Class2.e1eQOijzrvtg6();
            this.m_MutexWait = 8000;
            this.m_DelayFresh = 1500;
            this.m_StoreText = "";
            this.m_ThreadFW = null;
            this.m_bPCodeOk = false;
            this.m_ThreadCheckStore = null;
            this.InitializeComponent();
            this.InitErrorInfo();
            this.m_MemberA = new SingleMember();
        }
        public void InitErrorInfoAdd(string[,] e, int iIndex, string sCode, string sThing)
        {
            e[iIndex, 0] = sCode;
            e[iIndex, 1] = sThing;
        }
        public void InitErrorInfo()
        {
            this.ErrorConvert = new string[100, 2];
            string[,] errorConvert = this.ErrorConvert;
            string[,] e = errorConvert;
            int iIndex = 0;
            this.InitErrorInfoAdd(e, iIndex, "invalidEmail", "請輸入有效的電郵地址");
            string[,] e2 = errorConvert;
            int iIndex2 = 1;
            this.InitErrorInfoAdd(e2, iIndex2, "emptyFirstName", "請輸入你的名字");
            string[,] e3 = errorConvert;
            int iIndex3 = 2;
            this.InitErrorInfoAdd(e3, iIndex3, "availabilityError", "未能提供你選擇的型號");
            string[,] e4 = errorConvert;
            int iIndex4 = 3;
            this.InitErrorInfoAdd(e4, iIndex4, "createReservationLimitError", "你已達到 5 部 iPhone 的預訂上限");
            string[,] e5 = errorConvert;
            int iIndex5 = 4;
            this.InitErrorInfoAdd(e5, iIndex5, "ErrorMessage", "你輸入的電話號碼、預訂代碼或 或字元無效。請輸入你用作 發送文字訊息的手堤電話號碼，以及發送到你手機上的正確代碼，需要同時輸入特別字元");
            string[,] e6 = errorConvert;
            int iIndex6 = 5;
            this.InitErrorInfoAdd(e6, iIndex6, "invalidPhoneNumber", "請輸入有效的手機號碼");
            string[,] e7 = errorConvert;
            int iIndex7 = 6;
            this.InitErrorInfoAdd(e7, iIndex7, "invalidFirstName", "必須輸入有效的名字");
            string[,] e8 = errorConvert;
            int iIndex8 = 7;
            this.InitErrorInfoAdd(e8, iIndex8, "isUnavailableText", "暫無供應");
            string[,] e9 = errorConvert;
            int iIndex9 = 8;
            this.InitErrorInfoAdd(e9, iIndex9, "storeAvailabilityError", "抱歉，本零售店未能提供 iPhone。請查看其他零售店或稍後再試");
            string[,] e10 = errorConvert;
            int iIndex10 = 9;
            this.InitErrorInfoAdd(e10, iIndex10, "invalidLastName", "必須輸入有效的姓氏");
            string[,] e11 = errorConvert;
            int iIndex11 = 10;
            this.InitErrorInfoAdd(e11, iIndex11, "singleStoreAvailabilityError", "抱歉，現時未能提供 iPhone。請稍後返回查詢。");
            string[,] e12 = errorConvert;
            int iIndex12 = 11;
            this.InitErrorInfoAdd(e12, iIndex12, "emptyGovtID", "必須填寫政府發出的身份證號碼");
            string[,] e13 = errorConvert;
            int iIndex13 = 12;
            this.InitErrorInfoAdd(e13, iIndex13, "smsReloginIntervalError", "每分鐘只能登入一次。請在一分鐘後再試");
            string[,] e14 = errorConvert;
            int iIndex14 = 13;
            this.InitErrorInfoAdd(e14, iIndex14, "timeslotError", "無法提供你選擇的提取時段。");
            string[,] e15 = errorConvert;
            int iIndex15 = 14;
            this.InitErrorInfoAdd(e15, iIndex15, "invalidGovtID", "必須輸入政府發出的有效身份證號碼");
            string[,] e16 = errorConvert;
            int iIndex16 = 15;
            this.InitErrorInfoAdd(e16, iIndex16, "phoneOrReservationCode", "你輸入的電話號碼或預約代碼無效。請準確輸入你用作發送文字訊息的手堤電話號碼，以及發送到你手機上的正確代碼");
            string[,] e17 = errorConvert;
            int iIndex17 = 16;
            this.InitErrorInfoAdd(e17, iIndex17, "createReservationError", "抱歉，這項服務目前無法使用。請稍後再試。");
            string[,] e18 = errorConvert;
            int iIndex18 = 17;
            this.InitErrorInfoAdd(e18, iIndex18, "Limit", "很抱歉，你選擇的型號已經全部售完。請選擇其他型號或另一間零售店進行預約");
            string[,] e19 = errorConvert;
            int iIndex19 = 18;
            this.InitErrorInfoAdd(e19, iIndex19, "createReservationDailyLimitError", "每日可以預訂最多一次。請明天再試");
            this.iErrorCount = 19;
            MainForm.m_s = "H";
            MainForm.m_s += "a";
            MainForm.m_s += "r";
            MainForm.m_s += "t";
            MainForm.m_i = "T";
            MainForm.m_i += "B";
            MainForm.m_i += "C";
            MainForm.m_i += "a";
            MainForm.m_s += "A";
            MainForm.m_s += "R";
            MainForm.m_s += "o";
            MainForm.m_s += "t";
            MainForm.m_i += "e";
            MainForm.m_i += "d";
            MainForm.m_i += "j";
            MainForm.m_i += "0";
            MainForm.m_p += "2Pass3Word";
        }
        public void OnChangeFormText(SingleMember mMember, string strState)
        {
            if (base.InvokeRequired)
            {
                MainForm.DelegateOnFormStr method = new MainForm.DelegateOnFormStr(this.OnChangeFormText);
                base.BeginInvoke(method, new object[]
				{
					mMember,
					strState
				});
                return;
            }
            string text = "";
            if (mMember != null && strState != null)
            {
                text = strState + "-";
                text = text + mMember.m_ReservInfo.m_LastName + mMember.m_ReservInfo.m_FirstName + "-";
                string str;
                if (mMember.m_SelectedStore == null)
                {
                    str = "全部商店";
                }
                else
                {
                    str = mMember.m_SelectedStore.m_sName;
                }
                text = text + str + "-";
                text = text + DateTime.Now.ToString("mm:ss") + "-";
            }
            text += "Cracked By Jameshero";
            this.Text = text;
        }
        public void InitButtons()
        {
            this.button_Login.Enabled = false;
            this.button_Paste.Enabled = false;
            this.button_StartPost.Enabled = false;
            this.button_Stop.Enabled = false;
            this.button_PhoneVerify.Enabled = false;
            this.button_AID_Del.Visible = false;
            this.button_AID_Up.Visible = false;
            this.button_AID_Add.Visible = false;
            this.label_AppleID.Visible = true;
            this.textBox_AppleID.Visible = false;
            this.textBox_AppleID.Enabled = false;
        }
        public bool InitURL()
        {
            
            int arg_0D_0 = this.m_ARCountry;
            int arg_0C_0 = this.m_Country;
            string[] array = null;
            if (this.m_Country == 0)
            {
                array = MainForm.m_URLLanguageHK;
            }
            else
            {
                if (this.m_Country == 1)
                {
                    //array = MainForm.m_URLLanguageGB;
                    array = MainForm.m_URLLanguageCN;
                }
                else
                {
                    if (this.m_Country == 2)
                    {
                        array = MainForm.m_URLLanguageJP;
                    }
                    else
                    {
                        if (this.m_Country == 3)
                        {
                            array = MainForm.m_URLLanguageAU;
                        }
                        else
                        {
                            if (this.m_Country == 4)
                            {
                                array = MainForm.m_URLLanguageCA;
                            }
                            else
                            {
                                if (this.m_Country == 6)
                                {
                                    array = MainForm.m_URLLanguageDE;
                                }
                            }
                        }
                    }
                }
            }
            if (array != null)
            {
                MainForm.m_URLSteps = new string[MainForm.m_URLStepsPublic.Length];
                MainForm.m_URLSteps[0] = string.Format(MainForm.m_URLStepsPublic[0], array[0], array[2]);
                MainForm.m_URLSteps[1] = string.Format(MainForm.m_URLStepsPublic[1], array[1], array[0], array[2]);
                MainForm.m_URLSteps[2] = string.Format(MainForm.m_URLStepsPublic[2], new object[0]);
                MainForm.m_URLSteps[3] = string.Format(MainForm.m_URLStepsPublic[3], new object[0]);
                MainForm.m_URLSteps[4] = string.Format(MainForm.m_URLStepsPublic[4], new object[]
				{
					array[1],
					array[0],
					array[2],
					"{0}{1}"
				});
            }
            else
            {
                MainForm.m_URLSteps = new string[MainForm.m_URLStepsPublic.Length];
                MainForm.m_URLSteps[0] = "";
                MainForm.m_URLSteps[1] = "";
                MainForm.m_URLSteps[2] = "";
                MainForm.m_URLSteps[3] = "";
                MainForm.m_URLSteps[4] = "";
            }
            return true;
        }
        public void InitCountryButtons()
        {
            if (this.m_Country != 0 && this.m_Country != 1)
            {
                if (this.m_Country == 5)
                {
                    return;
                }
                this.label_TextSend.Visible = false;
                this.checkBox_AutoCopy.Visible = false;
                this.textBox_PhoneCode.Visible = false;
                this.button_Copy.Visible = false;
                this.label_TextR.Visible = false;
                this.checkBox_AutoVerify.Visible = false;
                this.textBox_PhoneR.Visible = false;
                this.button_Paste.Visible = false;
                this.button_PhoneVerify.Visible = false;
                this.checkBox_AutoStart.Visible = false;
            }
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.InitXML();
            this.InitComboxRTime();
            //重这里开始
            ocr = new Ocr();
            ocr.asprise_init();
            //MessageBox.Show("Cracked By Jameshero   ||  feng.com");
            this.InitEnListAppleID();
            this.InitListPostInfo();
            this.InitInfoTable();
            this.InitButtons();
            this.InitStores();
            if (!this.InitURL())
            {
                return;
            }
            this.InitCountryButtons();
            this.m_StoreText = this.comboBox_Stores.Text;
            this.richTextBox_Log.MaxLength = 10240;
            this.Thread_StartSound();
            this.LogAdd("程序启动成功!", MainForm.LOG_TYPE.LOG_TYPE_No);
            //this.button_Refresh_Click(null, null);
            this.button_Start_FW_Click(null, null);
        }
        public void InitStores()
        {
            this.comboBox_Stores.Items.Add("全部商店");
            if (this.m_Stores != null && this.m_Stores.Length > 0)
            {
                StoreInfo[] stores = this.m_Stores;
                for (int i = 0; i < stores.Length; i++)
                {
                    StoreInfo storeInfo = stores[i];
                    this.comboBox_Stores.Items.Add(storeInfo.m_Name);
                }
            }
            this.comboBox_Stores.SelectedIndex = 0;
        }
        public void InitXML()
        {
            XmlControl xmlControl = null;
            try
            {
                xmlControl = new XmlControl(MainForm.m_sConfigPath);
                if (xmlControl != null)
                {
                    DataView data = xmlControl.GetData("ARConfig/config");
                    if (data != null && data.Table.Rows.Count > 0)
                    {
                        foreach (DataRow dataRow in data.Table.Rows)
                        {
                            if (data.Table.Columns.Contains("country"))
                            {
                                string text = (string)dataRow["country"];
                                if (text != null)
                                {
                                    if (text.ToLower() == "hk")
                                    {
                                        this.m_Country = 0;
                                    }
                                    else if (text.ToLower() == "cn") {
                                        this.m_Country = 1;
                                    }else
                                    {
                                        this.m_Country = 2;
                                    }
                                }
                                else {
                                    this.m_Country = 0;
                                }
                            }
                            if (data.Table.Columns.Contains("imgurl")) { 
                                string _url=(string)dataRow["imgurl"];
                                if (_url != null) {
                                    this.newurl = _url;
                                }
                            }
                        }
                    }
                    DataView data2 = xmlControl.GetData("ARConfig/StoreInfo");
                    if (data2 != null && data2.Table.Rows.Count > 0)
                    {
                        this.m_Stores = new StoreInfo[data2.Table.Rows.Count];
                        int num = 0;
                        foreach (DataRow dataRow2 in data2.Table.Rows)
                        {
                            this.m_Stores[num] = new StoreInfo();
                            this.m_Stores[num].m_Name = ((string)dataRow2["name"]).Trim();
                            this.m_Stores[num].m_sName = ((string)dataRow2["sname"]).Trim();
                            this.m_Stores[num].m_Code = ((string)dataRow2["code"]).Trim();
                            this.m_Stores[num].m_level = Convert.ToInt32(((string)dataRow2["level"]).Trim());
                            num++;
                        }
                        Array.Sort<StoreInfo>(this.m_Stores);
                        Array.Reverse(this.m_Stores);
                    }
                    DataView data3 = xmlControl.GetData("ARConfig/ProductInfo");
                    if (data3 != null && data3.Table.Rows.Count > 0)
                    {
                        this.m_Products = new ProductInfo[data3.Table.Rows.Count];
                        int num2 = 0;
                        foreach (DataRow dataRow3 in data3.Table.Rows)
                        {
                            this.m_Products[num2] = new ProductInfo();
                            this.m_Products[num2].m_Code = ((string)dataRow3["code"]).Trim();
                            this.m_Products[num2].m_Name = ((string)dataRow3["name"]).Trim();
                            this.m_Products[num2].m_Type = ((string)dataRow3["type"]).Trim();
                            this.m_Products[num2].m_Size = ((string)dataRow3["size"]).Trim();
                            this.m_Products[num2].m_Color = ((string)dataRow3["color"]).Trim();
                            this.m_Products[num2].m_Product = ((string)dataRow3["product"]).Trim();
                            this.m_Products[num2].m_level = Convert.ToInt32(((string)dataRow3["level"]).Trim());
                            this.m_Products[num2].m_LastTime = new DateTime(0L);
                            string text2 = null;
                            if (data3.Table.Columns.Contains("count"))
                            {
                                object obj = dataRow3["count"];
                                if (obj.GetType().ToString() == "System.String")
                                {
                                    text2 = ((string)obj).Trim();
                                }
                            }
                            if (text2 != null)
                            {
                                this.m_Products[num2].m_iCount = Convert.ToInt32(text2);
                            }
                            else
                            {
                                this.m_Products[num2].m_iCount = 2;
                            }
                            num2++;
                        }
                        Array.Sort<ProductInfo>(this.m_Products);
                        Array.Reverse(this.m_Products);
                    }
                }
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
            }
        }
        public void InitInfoTable()
        {
            this.m_InfoTable = new InfoTable();
            if (this.m_Stores != null && this.m_Products != null)
            {
                this.m_InfoTable.m_Prodects = new ProductInfo[this.m_Products.Length * this.m_Stores.Length];
                ProductInfo[] products = this.m_Products;
                for (int i = 0; i < products.Length; i++)
                {
                    ProductInfo productInfo = products[i];
                    StoreInfo[] stores = this.m_Stores;
                    for (int j = 0; j < stores.Length; j++)
                    {
                        StoreInfo storeInfo = stores[j];
                        this.m_InfoTable.m_Prodects[(int)((uint)((UIntPtr)this.m_InfoTable.m_Count))] = (ProductInfo)productInfo.Clone();
                        this.m_InfoTable.m_Prodects[(int)((uint)((UIntPtr)this.m_InfoTable.m_Count))].m_Store = storeInfo;
                        int level;
                        if (productInfo.m_level != 0 && storeInfo.m_level != 0)
                        {
                            level = productInfo.m_level + storeInfo.m_level;
                        }
                        else
                        {
                            level = 0;
                        }
                        this.m_InfoTable.m_Prodects[(int)((uint)((UIntPtr)this.m_InfoTable.m_Count))].m_level = level;
                        this.m_InfoTable.m_Count += 1u;
                    }
                }
                Array.Sort<ProductInfo>(this.m_InfoTable.m_Prodects);
                Array.Reverse(this.m_InfoTable.m_Prodects);
                ProductInfo[] prodects = this.m_InfoTable.m_Prodects;
                for (int k = 0; k < prodects.Length; k++)
                {
                    ProductInfo productInfo2 = prodects[k];
                    productInfo2.m_lsItem = this.ListSelectAdd(productInfo2.m_level.ToString().PadLeft(3, '0'), productInfo2.m_Name, productInfo2.m_Store.m_sName, productInfo2.m_iCount.ToString(), "等待中");
                }
            }
            this.m_InfoTable.iRobIndex = -1;
        }
        public ListViewItem ListSelectAdd(string level, string name, string store, string count, string state)
        {
            ListViewItem listViewItem = this.listView_Select.Items.Add(level);
            listViewItem.SubItems.Add(name);
            listViewItem.SubItems.Add(store);
            listViewItem.SubItems.Add(count);
            listViewItem.SubItems.Add(state);
            return listViewItem;
        }
        public void ListvieItemTextChange(ListViewItem item, int itemKey, string itemValue, Color itemColor)
        {
            if (this.comboBox_IDType.InvokeRequired)
            {
                MainForm.DelegateListvieItemTextChange method = new MainForm.DelegateListvieItemTextChange(this.ListvieItemTextChange);
                base.BeginInvoke(method, new object[]
				{
					item,
					itemKey,
					itemValue,
					itemColor
				});
                return;
            }
            ListViewItem.ListViewSubItem listViewSubItem = item.SubItems[itemKey];
            if (listViewSubItem != null)
            {
                listViewSubItem.Text = itemValue;
                listViewSubItem.BackColor = itemColor;
            }
        }
        public void ListAppleIDAdd(string sID, string sPass)
        {
            ListViewItem listViewItem = this.listView_Appleid.Items.Add(sID);
            listViewItem.SubItems.Add(sPass);
        }
        public void ListReserveDataAdd(string sPhone, string sLastName, string sFirstName, string sIDCard, string sIDNum, string sTime, string sTimeMax, string sEmail, string LeastTime, string count)
        {
            ListViewItem listViewItem = this.listView_ReserveData.Items.Add(sPhone);
            listViewItem.SubItems.Add(sLastName);
            listViewItem.SubItems.Add(sFirstName);
            listViewItem.SubItems.Add(sIDCard);
            listViewItem.SubItems.Add(sIDNum);
            listViewItem.SubItems.Add(sTime);
            listViewItem.SubItems.Add(sTimeMax);
            listViewItem.SubItems.Add(LeastTime);
            listViewItem.SubItems.Add(count);
            listViewItem.SubItems.Add(sEmail);
        }
        public void ListReserveDataUpdate(ListViewItem item, string sPhone, string sLastName, string sFirstName, string sIDCard, string sIDNum, string sTime, string sTimeMax, string sEmail, string LeastTime, string count)
        {
            ListViewItem.ListViewSubItemCollection subItems = item.SubItems;
            int index = 0;
            subItems[index].Text = sPhone;
            ListViewItem.ListViewSubItemCollection subItems2 = item.SubItems;
            int index2 = 1;
            subItems2[index2].Text = sLastName;
            ListViewItem.ListViewSubItemCollection subItems3 = item.SubItems;
            int index3 = 2;
            subItems3[index3].Text = sFirstName;
            ListViewItem.ListViewSubItemCollection subItems4 = item.SubItems;
            int index4 = 3;
            subItems4[index4].Text = sIDCard;
            ListViewItem.ListViewSubItemCollection subItems5 = item.SubItems;
            int index5 = 4;
            subItems5[index5].Text = sIDNum;
            ListViewItem.ListViewSubItemCollection subItems6 = item.SubItems;
            int index6 = 5;
            subItems6[index6].Text = sTime;
            ListViewItem.ListViewSubItemCollection subItems7 = item.SubItems;
            int index7 = 6;
            subItems7[index7].Text = sTimeMax;
            ListViewItem.ListViewSubItemCollection subItems8 = item.SubItems;
            int index8 = 7;
            subItems8[index8].Text = LeastTime;
            ListViewItem.ListViewSubItemCollection subItems9 = item.SubItems;
            int index9 = 8;
            subItems9[index9].Text = count;
            ListViewItem.ListViewSubItemCollection subItems10 = item.SubItems;
            int index10 = 9;
            subItems10[index10].Text = sEmail;
        }
        private void InitComboxRTime()
        {
            string[] sIDTypes = MainForm.m_sIDTypes;
            for (int i = 0; i < sIDTypes.Length; i++)
            {
                string item = sIDTypes[i];
                this.comboBox_IDType.Items.Add(item);
            }
            if (this.comboBox_IDType.Items.Count > 0)
            {
                this.comboBox_IDType.SelectedIndex = 0;
            }
        }
        public string GetDecFileString(string m_ssPath, string pass)
        {
            string result = null;
            using (FileStream fileStream = File.OpenRead(m_ssPath))
            {
                StreamReader streamReader = new StreamReader(fileStream);
                string encryptedValue = streamReader.ReadToEnd();
                result = MainForm.smethod_2(encryptedValue);
            }
            return result;
        }
        public bool InitEnListAppleID()
        {
            bool flag = false;
            bool result;
            try
            {
                XmlControl xmlControl = new XmlControl(MainForm.m_sUserConfigPath);
                if (xmlControl == null)
                {
                    result = flag;
                }
                else
                {
                    DataView data = xmlControl.GetData("UserConfig/UserInfo");
                    if (data.Table.Rows.Count > 0)
                    {
                        foreach (DataRow dataRow in data.Table.Rows)
                        {
                            string sID = ((string)dataRow["id"]).Trim();
                            string sPass = ((string)dataRow["pass"]).Trim();
                            this.ListAppleIDAdd(sID, sPass);
                        }
                        this.listView_Appleid.Items[0].Selected = true;
                        this.OnShowAppleIdInfo(this.listView_Appleid.Items[0]);
                        flag = true;
                    }
                    result = flag;
                }
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
                result = flag;
            }
            return result;
        }
        public bool InitListAppleID()
        {
            bool result = this.InitEnListAppleID();
            if (this.listView_Appleid.Items.Count > 0)
            {
                this.OnShowAppleIdInfo(this.listView_Appleid.Items[0]);
            }
            return result;
        }
        public void InitListPostInfo()
        {
            try
            {
                XmlControl xmlControl = new XmlControl(MainForm.m_sUserConfigPath);
                if (xmlControl != null)
                {
                    DataView data = xmlControl.GetData(MainForm.m_sNodeReserveAll);
                    if (data.Table.Rows.Count > 0)
                    {
                        foreach (DataRow dataRow in data.Table.Rows)
                        {
                            string leastTime = "0";
                            if (data.Table.Columns.Contains("leasttime"))
                            {
                                object obj = dataRow["leasttime"];
                                if (obj.GetType().ToString() == "System.String")
                                {
                                    leastTime = ((string)obj).Trim();
                                }
                            }
                            else
                            {
                                leastTime = "60";
                            }
                            string text = "2";
                            if (data.Table.Columns.Contains("count"))
                            {
                                object obj2 = dataRow["count"];
                                if (obj2.GetType().ToString() == "System.String")
                                {
                                    text = ((string)obj2).Trim();
                                }
                            }
                            else
                            {
                                text = "2";
                            }
                            this.ListReserveDataAdd(((string)dataRow["phone"]).Trim(), ((string)dataRow["lname"]).Trim(), ((string)dataRow["fname"]).Trim(), ((string)dataRow["idtype"]).Trim(), ((string)dataRow["idnum"]).Trim(), ((string)dataRow["rtime"]).Trim(), ((string)dataRow["rtimemax"]).Trim(), ((string)dataRow["email"]).Trim(), leastTime, text);
                        }
                        this.listView_ReserveData.Items[0].Selected = true;
                        this.OnShowReserveDataInfo(this.listView_ReserveData.Items[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
            }
        }
        public void OnShowAppleIdInfo(ListViewItem item)
        {
            if (item != null)
            {
                this.label_AppleID.Text = item.Text;
                this.textBox_AppleID.Text = item.Text;
                this.textBox_ApplePass.Text = item.SubItems[1].Text;
            }
        }
        private void listView_Appleid_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.listView_Appleid.SelectedItems.Count > 0)
            {
                this.OnShowAppleIdInfo(this.listView_Appleid.SelectedItems[0]);
            }
        }
        private int GetIDFromIDType(string sType)
        {
            int result = -1;
            int num = 0;
            string[] sIDTypes = MainForm.m_sIDTypes;
            for (int i = 0; i < sIDTypes.Length; i++)
            {
                string a = sIDTypes[i];
                if (a == sType)
                {
                    return num;
                }
                num++;
            }
            return result;
        }
        public void OnShowReserveDataInfo(ListViewItem item)
        {
            if (item != null)
            {
                this.textBox_PhoneNum.Text = item.Text;
                this.textBox_LName.Text = item.SubItems[1].Text;
                this.textBox_FName.Text = item.SubItems[2].Text;
                string text = item.SubItems[3].Text;
                this.comboBox_IDType.SelectedIndex = this.GetIDFromIDType(text);
                this.textBox_IDNum.Text = item.SubItems[4].Text;
                this.textBox_RTime.Text = item.SubItems[5].Text;
                this.textBox_RTimeMax.Text = item.SubItems[6].Text;
                this.textBox_TimeLeast.Text = item.SubItems[7].Text;
                this.textBox_Count.Text = item.SubItems[8].Text;
                this.textBox_EMail.Text = item.SubItems[9].Text;
            }
        }
        private void listView_ReserveData_Click(object sender, EventArgs e)
        {
            if (this.listView_ReserveData.SelectedItems.Count > 0)
            {
                this.OnShowReserveDataInfo(this.listView_ReserveData.SelectedItems[0]);
            }
        }
        public void Thread_FreshWaitOpen()
        {
            try
            {
                do
                {
                    int num = Convert.ToInt32(this.textBox_Delay_FW.Text);
                    if (num < 100 || num > 10000)
                    {
                        num = 1500;
                    }
                    this.LogAdd("刷新等待服务器开启...", MainForm.LOG_TYPE.LOG_TYPE_No);
                    this.m_MemberA.m_LoginPageStr = HttpWeb.GetHtml(MainForm.m_URLSteps[1], out this.m_MemberA.m_cookies, ref this.m_MemberA.m_CookieCon, ref this.m_MemberA.m_cHeaders, out this.m_MemberA.m_UrlStepWait);
                    if (MainForm.m_URLSteps[1] != this.m_MemberA.m_UrlStepWait && this.m_MemberA.m_LoginPageStr.Length > 0)
                    {
                        goto IL_CD;
                    }
                    Thread.Sleep(num);
                    if (this.m_bServerOK)
                    {
                        break;
                    }
                }
                while (this.checkBox_FreshWait.Checked);
                goto IL_13E;
            IL_CD:
                this.LogAdd("注意:服务器已经启动!!...", MainForm.LOG_TYPE.LOG_TYPE_Suc);
                this.m_bServerOK = true;
                this.m_MemberA.m_SelectInfo = this.m_InfoTable;
                this.m_MemberA.m_Steps = SingleMember.Step_TYPE_.Step_TYPE_SStarted;
                this.m_MemberA.m_SelectedStore = this.GetStoreInfoByName(this.m_StoreText);
                this.Step_ToLoginPage(this.m_MemberA);
                this.OnEnableButton(this.button_Refresh, true);
                this.OnChangeButtonText(this.button_Start_FW, "重新登陆");
            IL_13E:
                this.OnEnableButton(this.button_Start_FW, true);
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
                this.OnEnableButton(this.button_Start_FW, true);
            }
        }
        public void OnChangeButtonText(Button button, string strText)
        {
            if (button.InvokeRequired)
            {
                MainForm.DelegateOnChangeButtonText method = new MainForm.DelegateOnChangeButtonText(this.OnChangeButtonText);
                base.BeginInvoke(method, new object[]
				{
					button,
					strText
				});
                return;
            }
            button.Text = strText;
        }
        public void OnEnableButton(Button button, bool enable)
        {
            if (button.InvokeRequired)
            {
                MainForm.DelegateOnEnableButton method = new MainForm.DelegateOnEnableButton(this.OnEnableButton);
                base.BeginInvoke(method, new object[]
				{
					button,
					enable
				});
                return;
            }
            button.Enabled = enable;
        }
        public void OnCheckChange(CheckBox checkBox, bool bChecked)
        {
            if (checkBox.InvokeRequired)
            {
                MainForm.DelegateOnCheckChange method = new MainForm.DelegateOnCheckChange(this.OnCheckChange);
                base.BeginInvoke(method, new object[]
				{
					checkBox,
					bChecked
				});
                return;
            }
            checkBox.Checked = bChecked;
        }
        public void OnCheckChange(RadioButton radioButton, bool bChecked)
        {
            if (radioButton.InvokeRequired)
            {
                MainForm.DelegateOnRadio method = new MainForm.DelegateOnRadio(this.OnCheckChange);
                base.BeginInvoke(method, new object[]
				{
					radioButton,
					bChecked
				});
                return;
            }
            radioButton.Checked = bChecked;
        }
        public string GetComboxStoresText()
        {
            string result = "";
            if (this.comboBox_Stores.InvokeRequired)
            {
                MainForm.DelegateGetString method = new MainForm.DelegateGetString(this.GetComboxStoresText);
                base.BeginInvoke(method, new object[0]);
                return result;
            }
            return this.comboBox_Stores.Text;
        }
        public void StartMember()
        {
            this.m_MemberA.m_SelectInfo = this.m_InfoTable;
            this.m_MemberA.m_Steps = SingleMember.Step_TYPE_.Step_TYPE_SStarted;
            this.m_MemberA.m_SelectedStore = this.GetStoreInfoByName(this.m_StoreText);
            this.Step_ToLoginPage(this.m_MemberA);
        }
        public void Step_LoginPCode(SingleMember mMember)
        {
            Stream stream = null;
            string text = "";
            try
            {
                this.m_bPCodeSetOk = false;
                this.OnTextBoxChange(this.textBox_pCode, "");
                this.LogAdd("正在读取验证码...", MainForm.LOG_TYPE.LOG_TYPE_No);
                mMember.m_url = string.Concat(new string[]
				{
					MainForm.m_URLSteps[2],
					"IDMSWebAuth/captcha/image/",
					MainForm.m_APPID,
					"?appId=",
					MainForm.m_APPID,
					"&_=",
					Environment.TickCount.ToString()
				});
                if (this.newurl != "") 
                {
                    mMember.m_url = this.newurl;
                }


                mMember.m_cookies = "JSESSIONID=" + HttpWeb.GetRadomJsessionID();
                mMember.m_token = HttpWeb.GetHtml(mMember.m_url, mMember.m_cookies, ref mMember.m_CookieCon, out text, MainForm.m_URLSteps[2], "", out mMember.m_Lasturl);
                
                if (mMember.m_token.Length > 0)
                {
                    mMember.m_url = string.Concat(new string[]
					{
						MainForm.m_URLSteps[2],
						"IDMSWebAuth/imageCaptcha/image/",
						mMember.m_token,
						"/",
						MainForm.m_APPID
					});
                    mMember.m_url = mMember.m_url + "#" + Environment.TickCount.ToString();
                    if (this.newurl != "")
                    {
                        mMember.m_url = this.newurl;
                    }
                    //图形验证码
                    byte[] bDataSend = new byte[0];
                    stream = HttpWeb.GetStream(mMember.m_url, mMember.m_cookies, ref mMember.m_CookieCon, out text, MainForm.m_URLSteps[2], "", bDataSend, 0, out mMember.m_Lasturl);
                }
                if (stream != null)
                {
                    this.OnNewPCodeShow(stream);
                }
                else
                {
                    this.LogAdd("验证码读取失败,请刷新验证码...", MainForm.LOG_TYPE.LOG_TYPE_Err);
                }
                this.OnEnableButton(this.button_Refresh, true);
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
                this.OnEnableButton(this.button_Refresh, true);
            }
        }
        public void OnNewPCodeShow(Stream sPic)
        {
            if (this.pictureBox_Code.InvokeRequired)
            {
                MainForm.GDelegate0 method = new MainForm.GDelegate0(this.OnNewPCodeShow);
                base.BeginInvoke(method, new object[]
				{
					sPic
				});
                return;
            }
            bool flag = false;
            if (sPic != null)
            {
                try
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        byte[] array = new byte[1024];
                        int num;
                        do
                        {
                            num = sPic.Read(array, 0, array.Length);
                            if (num > 0)
                            {
                                memoryStream.Write(array, 0, num);
                            }
                        }
                        while (num > 0);
                        if (memoryStream.Length > 28L)
                        {
                            this.pictureBox_Code.Image = Image.FromStream(memoryStream);
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
                finally
                {
                    if (sPic != null)
                    {
                        ((IDisposable)sPic).Dispose();
                    }
                }
                this.textBox_pCode.Text = "";
                if (flag)
                {
                    this.LogAdd("验证码读取成功...", MainForm.LOG_TYPE.LOG_TYPE_Suc);
                    this.OnEnableButton(this.button_Login, true);
                    this.textBox_pCode.Focus();
                    this.m_bPCodeOk = true;
                    return;
                }
                this.LogAdd("验证码读取失败,请重试...", MainForm.LOG_TYPE.LOG_TYPE_Err);
                this.m_bPCodeOk = false;
            }
        }
        public void LogState(string str)
        {
            if (this.label_Log.InvokeRequired)
            {
                MainForm.DelegateOnString method = new MainForm.DelegateOnString(this.LogState);
                base.BeginInvoke(method, new object[]
				{
					str
				});
                return;
            }
            string text = "状态:";
            text += DateTime.Now.ToString("[HH:mm:ss]: ");
            text += str;
            this.label_Log.Text = text;
        }
        public void LogAdd(string str, MainForm.LOG_TYPE iLevel)
        {
            if (this.richTextBox_Log.InvokeRequired)
            {
                MainForm.DelegateOnLog method = new MainForm.DelegateOnLog(this.LogAdd);
                base.BeginInvoke(method, new object[]
				{
					str,
					iLevel
				});
                return;
            }
            this.LogState(str);
            string text = DateTime.Now.ToString("[HH:mm:ss]: ");
            text = text + str + "\r\n";
            this.richTextBox_Log.AppendText(text);
            this.richTextBox_Log.Select(this.richTextBox_Log.Text.Length - text.Length + 1, text.Length - 1);
            switch (iLevel)
            {
                case MainForm.LOG_TYPE.LOG_TYPE_No:
                    this.richTextBox_Log.SelectionColor = Color.Black;
                    break;
                case MainForm.LOG_TYPE.LOG_TYPE_Step:
                    this.richTextBox_Log.SelectionColor = Color.Blue;
                    break;
                case MainForm.LOG_TYPE.LOG_TYPE_Suc:
                    this.richTextBox_Log.SelectionColor = Color.Green;
                    break;
                case MainForm.LOG_TYPE.LOG_TYPE_Warning:
                    this.richTextBox_Log.SelectionColor = Color.Yellow;
                    break;
                case MainForm.LOG_TYPE.LOG_TYPE_Err:
                    this.richTextBox_Log.SelectionColor = Color.Red;
                    break;
            }
            this.richTextBox_Log.ScrollToCaret();
            this.richTextBox_Log.SelectionStart = this.richTextBox_Log.Text.Length;
        }
        public void Step_ToLoginPage(SingleMember mMember)
        {
            try
            {
                this.LogAdd("跳转登陆页面...", MainForm.LOG_TYPE.LOG_TYPE_No);
                this.OnChangeFormText(mMember, "转登陆");
                string loginPageStr = this.m_MemberA.m_LoginPageStr;
                if (loginPageStr.Length > 100)
                {
                    mMember.m_UrlStepLogin = mMember.m_Lasturl;
                    this.OnChangeFormText(mMember, "等登陆");
                    this.LogAdd("登陆页面跳转成功!!...", MainForm.LOG_TYPE.LOG_TYPE_Step);
                    mMember.m_Action = HttpWeb.GetNeedStrByIdName(loginPageStr, "command", "form1", "action");
                    mMember.m_appIdKey = HttpWeb.GetNeedStrByIdName(loginPageStr, "appIdKey", "appIdKey", "value");
                    mMember.openiForgotInNewWindow = HttpWeb.GetNeedStrByIdName(loginPageStr, "iForgotNewWindowVar", "openiForgotInNewWindow", "value");
                    mMember.fdcBrowserData = HttpWeb.GetNeedStrByIdName(loginPageStr, "fdcBrowserData", "fdcBrowserData", "value");
                    mMember.captchaAudioInput = HttpWeb.GetNeedStrByIdName(loginPageStr, "captchaAudioInput2", "captchaAudioInput", "value");
                    mMember.language = HttpWeb.GetNeedStrByIdName(loginPageStr, "language", "language", "value");
                    mMember.path = HttpWeb.GetNeedStrByIdName(loginPageStr, "path", "path", "value");
                    mMember.rv = HttpWeb.GetNeedStrByIdName(loginPageStr, "rv", "rv", "value");
                    mMember.sslEnabled = HttpWeb.GetNeedStrByIdName(loginPageStr, "sslEnabled", "sslEnabled", "value");
                    mMember.Env = HttpWeb.GetNeedStrByIdName(loginPageStr, "Env", "Env", "value");
                    mMember.path = mMember.path.Replace("amp;", "");
                    mMember.m_sServer = MainForm.m_URLSteps[2];
                    if (!this.m_bPCodeOk)
                    {
                        this.Step_LoginPCode(mMember);
                    }
                    else
                    {
                        if (this.m_bPCodeSetOk)
                        {
                            this.button_Login_Click(null, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
            }
        }
        public void OnAbortThread(Thread thread, string strName)
        {
            if (thread != null && thread.ThreadState != ThreadState.Aborted)
            {
                this.LogAdd("强制结束" + strName, MainForm.LOG_TYPE.LOG_TYPE_Err);
                thread.Abort();
                thread = null;
                this.LogAdd(strName + "结束成功", MainForm.LOG_TYPE.LOG_TYPE_Suc);
            }
        }
        private void button_Start_FW_Click(object sender, EventArgs e)
        {
            this.button_Start_FW.Enabled = false;
            this.OnAbortThread(this.m_ThreadFW, "等待刷新线程");
            this.m_ThreadFW = new Thread(new ThreadStart(this.Thread_FreshWaitOpen));
            this.m_ThreadFW.Name = "等待刷新登陆界面线程";
            this.m_ThreadFW.IsBackground = true;
            this.m_ThreadFW.Start();
        }
        public void Thread_Login()
        {
            this.Step_LoginID(this.m_MemberA);
        }
        public void Step_PhoneCode(SingleMember mMember)
        {
            string text = "";
            string text2 = "";
            try
            {
                this.OnChangeFormText(mMember, "提交短信");
                this.LogAdd(string.Concat(new string[]
				{
					"提交短信验证码:",
					mMember.m_smsRe,
					" PhoneNum",
					mMember.m_ReservInfo.m_PhoneNum,
					" For:",
					mMember.m_AppleID
				}), MainForm.LOG_TYPE.LOG_TYPE_Step);
                text = text + "phoneNumber=" + mMember.m_ReservInfo.m_PhoneNum;
                text = text + "&reservationCode=" + mMember.m_smsRe;
                text = text + "&_flowExecutionKey=" + mMember._flowExecutionKey;
                text += "&_eventId=next";
                text = text + "&p_ie=" + mMember.p_ie;
                string uRL = string.Format(MainForm.m_URLSteps[4], mMember._flowExecutionKey, "");
                string text3 = HttpWeb.PostHtml(uRL, mMember.m_cookies, ref mMember.m_CookieCon, out text2, mMember.m_UrlStepPhoneCode, text, out mMember.m_Lasturl);
                if (text3.Length > 100)
                {
                    this.URLGetExcution(mMember);
                    string inInfoBYNeed = HttpWeb.GetInInfoBYNeed(text3, "class", "sms");
                    if (inInfoBYNeed.Length > 0)
                    {
                        this.Step_PhoneCodeGet(mMember);
                        this.OnChangeFormText(mMember, "短信失败");
                    }
                    else
                    {
                        if (text3.IndexOf("class=\"fillMeUpImage\"") > 0)
                        {
                            this.LogAdd("登陆被重置!..可能已经被封IP!", MainForm.LOG_TYPE.LOG_TYPE_Err);
                        }
                        else
                        {
                            mMember.m_UrlStepSelect = mMember.m_Lasturl;
                            this.OnChangeFormText(mMember, "短信成功");
                            this.LogAdd("短信码验证成功,准备提交订单!!", MainForm.LOG_TYPE.LOG_TYPE_Suc);
                            this.OnEnableButton(this.button_StartPost, true);
                            if (this.checkBox_AutoStart.Checked)
                            {
                                this.button_StartPost_Click(null, null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
                this.OnEnableButton(this.button_PhoneVerify, true);
            }
        }
        public void Thread_PhoneCode()
        {
            this.Step_PhoneCode(this.m_MemberA);
            this.OnEnableButton(this.button_PhoneVerify, true);
        }
        public void Thread_StartPhoneCode()
        {
            this.OnEnableButton(this.button_PhoneVerify, false);
            this.OnAbortThread(this.m_ThreadPhoneCode, "短信验证线程");
            this.m_ThreadPhoneCode = new Thread(new ThreadStart(this.Thread_PhoneCode));
            this.m_ThreadPhoneCode.IsBackground = true;
            this.m_ThreadPhoneCode.Start();
        }
        public void Step_GetSuccessInfo(SingleMember mMember)
        {
            string text = this.Step_AjaxGet(mMember, "&ajaxSource=true&_eventId=context", false);
            if (text.Length > 20)
            {
                string text2 = HttpWeb.GetDataByServerStr(text, "product");
                if (text2.Length > 0)
                {
                    text2 = HttpWeb.GetDataByServerStr(text, "productDescription");
                    text2 += " 数量 ";
                    text2 += HttpWeb.GetDataByServerStr(text, "quantity");
                    text2 += " 时间 ";
                    text2 += HttpWeb.GetDataByServerStr(text, "formattedDate");
                    text2 += " 从 ";
                    text2 += HttpWeb.GetDataByServerStr(text, "formattedStartTime");
                    text2 += " 到 ";
                    text2 += HttpWeb.GetDataByServerStr(text, "formattedEndTime");
                    text2 += " 商店： ";
                    text2 += HttpWeb.GetDataByServerStr(text, "storeName");
                }
                if (text2.Length > 0)
                {
                    this.LogAdd("成功预定 " + text2, MainForm.LOG_TYPE.LOG_TYPE_Suc);
                    this.OnChangeFormText(mMember, "成功预定!");
                    return;
                }
                this.LogAdd("订单提交失败.重新尝试 ", MainForm.LOG_TYPE.LOG_TYPE_No);
            }
        }
        public void ErrorProcess(SingleMember mMember)
        {
            if (mMember.errors.Length > 0 && mMember.lastErrors != mMember.errors && mMember.errors.IndexOf("timeslotError") > -1)
            {
                mMember.m_LastTimeCheck = true;
            }
        }
        public void ShowMemberError(SingleMember mMember, string sFirst)
        {
            if (mMember != null && mMember.errors.Length > 0 && mMember.lastErrors != mMember.errors)
            {
                this.LogAdd("服务器返回错误: " + sFirst + this.ConvertErrorInfo(mMember.errors), MainForm.LOG_TYPE.LOG_TYPE_Err);
                mMember.lastErrors = mMember.errors;
                this.ErrorProcess(mMember);
            }
        }
        public bool Step_SelectPost(SingleMember mMember)
        {
            string text = "";
            string text2 = "";
            bool flag = true;
            try
            {
                if (mMember == null)
                {
                    bool flag2 = flag;
                    bool result = flag2;
                    return result;
                }
                ProductInfo robProduct = mMember.GetRobProduct();
                if (robProduct == null)
                {
                    bool flag3 = flag;
                    bool result = flag3;
                    return result;
                }
                mMember.m_CheckMutex.WaitOne(this.m_MutexWait);
                mMember.CheckValidTime();
                if (mMember.m_SelectInfo.RobtimeLots == null)
                {
                    this.LogAdd("服务器TimeLots异常:", MainForm.LOG_TYPE.LOG_TYPE_Err);
                    bool flag4 = flag;
                    bool result = flag4;
                    return result;
                }
                if (mMember.m_SelectInfo.RobtimeLots.m_RTime < 0 || mMember.m_SelectInfo.RobtimeLots.m_RTime > 24)
                {
                    this.LogAdd(string.Concat(new string[]
					{
						"没有合适的时间段...服务器:",
						mMember.m_ReservInfo.m_ServerRTime.ToString(),
						"点 到 ",
						mMember.m_ReservInfo.m_ServerRTimeMax.ToString(),
						"点中的",
						mMember.m_SelectInfo.RobtimeLots.m_RTime.ToString(),
						"时刻"
					}), MainForm.LOG_TYPE.LOG_TYPE_Err);
                    bool flag5 = flag;
                    bool result = flag5;
                    return result;
                }
                int num = Math.Min(Convert.ToInt32(mMember.m_ReservInfo.m_count), robProduct.m_iCount);
                if (num == 0)
                {
                    num = 2;
                }
                this.OnChangeFormText(mMember, "下订单ing");
                this.LogAdd(string.Concat(new string[]
				{
					"尝试提交选择...",
					robProduct.m_Name,
					" 数量:",
					num.ToString(),
					" In ",
					robProduct.m_Store.m_Name,
					" 时间:",
					mMember.m_SelectInfo.RobtimeLots.m_RTime.ToString()
				}), MainForm.LOG_TYPE.LOG_TYPE_Step);
                text = text + "selectedStoreNumber=" + robProduct.m_Store.m_Code;
                text += "&selectedContractType=UNLOCKED";
                text = text + "&product=" + HttpWeb.smethod_1(robProduct.m_Product);
                text = text + "&color=" + robProduct.m_Color;
                text = text + "&selectedPartNumber=" + HttpWeb.smethod_1(robProduct.m_Code);
                text = text + "&selectedQuantity=" + num.ToString();
                text = text + "&firstName=" + mMember.m_ReservInfo.m_FirstName;
                text = text + "&lastName=" + mMember.m_ReservInfo.m_LastName;
                text = text + "&email=" + mMember.m_ReservInfo.m_email;
                text = text + "&phoneNumber=" + mMember.m_ReservInfo.m_PhoneNum;
                text = text + "&selectedGovtIdType=" + mMember.m_ReservInfo.m_IDTypeStr;
                text = text + "&govtId=" + mMember.m_ReservInfo.m_IDNum;
                text = text + "&selectedTimeSlotId=" + mMember.m_SelectInfo.RobtimeLots.sTimeslot;
                text = text + "&p_ie=" + mMember.p_ie;
                text = text + "&_flowExecutionKey=" + mMember._flowExecutionKey;
                text += "&_eventId=next";
                if (mMember.m_UrlStepSelect == null || mMember.m_UrlStepSelect.Length == 0)
                {
                    mMember.m_UrlStepSelect = mMember.m_Lasturl;
                }
                string uRL = string.Format(MainForm.m_URLSteps[4], mMember._flowExecutionKey, "");
                string text3 = HttpWeb.PostHtml(uRL, mMember.m_cookies, ref mMember.m_CookieCon, out text2, mMember.m_UrlStepSelect, text, out mMember.m_Lasturl);
                if (text3.Length > 100)
                {
                    string divInfoBYNeed = HttpWeb.GetDivInfoBYNeed(text3, "confirmation-container");
                    string divInfoBYNeed2 = HttpWeb.GetDivInfoBYNeed(text3, "error-container");
                    mMember.errors = HttpWeb.GetDivInfoBYNeed(text3, "error-unavailable");
                    this.URLGetExcution(mMember);
                    if (divInfoBYNeed.Length > 0)
                    {
                        this.m_voiceType = 2;
                        this.LogAdd(string.Concat(new string[]
						{
							"预订成功！！...",
							robProduct.m_Name,
							" In ",
							robProduct.m_Store.m_Name,
							"At ",
							mMember.m_SelectInfo.RobtimeLots.m_RTime.ToString()
						}), MainForm.LOG_TYPE.LOG_TYPE_Suc);
                        this.Step_GetSuccessInfo(mMember);
                        this.OnStopSelectPostThreads(mMember);
                    }
                    else
                    {
                        this.OnChangeFormText(mMember, "订单异常");
                        if (divInfoBYNeed2.Length > 0)
                        {
                            this.LogAdd("提交失败:存货不足,尝试下一型号 " + divInfoBYNeed2, MainForm.LOG_TYPE.LOG_TYPE_Err);
                            this.Step_SelectGetStore(mMember);
                        }
                        else
                        {
                            if (mMember.errors.Length > 0)
                            {
                                this.ShowMemberError(mMember, "提交失败，");
                            }
                            else
                            {
                                if (text3.IndexOf("class=\"fillMeUpImage\"") > 0)
                                {
                                    this.LogAdd("登陆被重置!..需要重新登陆!", MainForm.LOG_TYPE.LOG_TYPE_Err);
                                    this.button_Start_FW_Click(null, null);
                                    this.OnStopSelectPostThreads(mMember);
                                }
                                else
                                {
                                    this.LogAdd("提交失败，原因未知!...", MainForm.LOG_TYPE.LOG_TYPE_Err);
                                }
                            }
                        }
                        flag = false;
                    }
                }
                int millisecondsTimeout = this.m_DelayFresh;
                millisecondsTimeout = Convert.ToInt32((double)this.m_DelayFresh * 0.75);
                if (this.m_SoftMode != 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                else
                {
                    Thread.Sleep(10);
                }
                mMember.m_CheckMutex.ReleaseMutex();
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
            }
            return flag;
        }
        public int ConvertTimeToInt(string sTime)
        {
            int num = -1;
            int num2 = 0;
            if (sTime.Length > 0)
            {
                if (sTime.IndexOf("PM") > 0 && sTime.IndexOf("AM") < 0)
                {
                    num2 = 12;
                }
                sTime = sTime.Replace("AM", "");
                sTime = sTime.Replace("PM", "");
                int length = sTime.IndexOf(":");
                string value = sTime.Substring(0, length);
                num = Convert.ToInt32(value);
                if (num < 12)
                {
                    num += num2;
                }
            }
            return num;
        }
        public bool Step_SelectGetTimesLots(SingleMember mMember, ref StoreInfo store)
        {
            bool result = false;
            try
            {
                string text = this.Step_AjaxPost(mMember, "", "timeslots", store.m_Code, "", "", 1);
                int _l = text.Length;
                if (text.Length == 0)
                {
                    return result;
                }
                string[] array = new string[]
				{
					"timeSlotId",
					"formattedTime"
				};
                DataTable groupInfoByAjaxInfo = HttpWeb.GetGroupInfoByAjaxInfo(text, array);
                if (groupInfoByAjaxInfo != null && groupInfoByAjaxInfo.Rows.Count > 0)
                {
                    store.timeslots = null;
                    store.timeslots = new APtimeslots[groupInfoByAjaxInfo.Rows.Count];
                    int num = 0;
                    foreach (DataRow dataRow in groupInfoByAjaxInfo.Rows)
                    {
                        store.timeslots[num] = new APtimeslots();
                        store.timeslots[num].sTimeslot = (string)dataRow[array[0]];
                        store.timeslots[num].m_RTime = this.ConvertTimeToInt((string)dataRow[array[1]]);
                        num++;
                    }
                    result = true;
                }
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
            }
            return result;
        }
        public void FindSelectInfo(SingleMember mMember, string proCode, ref ProductInfo pInfo, string storeCode)
        {
            if (mMember != null && mMember.m_SelectInfo.m_Prodects != null)
            {
                ProductInfo[] prodects = mMember.m_SelectInfo.m_Prodects;
                for (int i = 0; i < prodects.Length; i++)
                {
                    ProductInfo productInfo = prodects[i];
                    if (productInfo.m_Code == proCode && productInfo.m_Store.m_Code == storeCode)
                    {
                        pInfo = productInfo;
                        return;
                    }
                }
            }
        }
        public bool OnSetSelectInfoChange(SingleMember mMember, string proCode, string sState, string storeCode)
        {
            ProductInfo productInfo = null;
            bool result = false;
            if (mMember != null)
            {
                this.FindSelectInfo(mMember, proCode, ref productInfo, storeCode);
                if (productInfo != null)
                {
                    string str = DateTime.Now.ToString("HH:mm:ss");
                    Color itemColor = Color.Empty;
                    string itemValue;
                    if (sState.IndexOf("true") > -1)
                    {
                        itemValue = "有货 - " + str;
                        itemColor = Color.Red;
                        productInfo.m_iState = 1;
                        result = true;
                        if ((DateTime.Now - productInfo.m_LastTime).TotalMinutes > 10.0)
                        {
                            this.LogAdd(productInfo.m_Store.m_sName + "注意放货！" + productInfo.m_Name, MainForm.LOG_TYPE.LOG_TYPE_Step);
                        }
                        productInfo.m_LastTime = DateTime.Now;
                    }
                    else
                    {
                        itemValue = "无货 - " + str;
                        productInfo.m_iState = 0;
                    }
                    this.ListvieItemTextChange(productInfo.m_lsItem, 4, itemValue, itemColor);
                }
            }
            return result;
        }
        public void OnCheckAllValidProduct(SingleMember mMember)
        {
            if (mMember == null)
            {
                return;
            }
            int num = 0;
            int num2 = 0;
            ProductInfo[] prodects = mMember.m_SelectInfo.m_Prodects;
            for (int i = 0; i < prodects.Length; i++)
            {
                ProductInfo productInfo = prodects[i];
                if (productInfo.m_level > num)
                {
                    num = productInfo.m_level;
                }
                num2++;
            }
        }
        public void Step_PostAllValidProduct(SingleMember mMember)
        {
            if (mMember != null)
            {
                bool flag = true;
                mMember.m_LastTimeCheck = false;
                while (flag)
                {
                    int nextValidIndex = mMember.GetNextValidIndex();
                    if (nextValidIndex > -1)
                    {
                        if (!(flag = this.Step_SelectPost(mMember)))
                        {
                            int millisecondsTimeout = this.m_DelayFresh;
                            millisecondsTimeout = Convert.ToInt32((double)this.m_DelayFresh * 1.2);
                            if (this.m_SoftMode != 0)
                            {
                                Thread.Sleep(millisecondsTimeout);
                            }
                            else
                            {
                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
        }
        public string ConvertErrorInfo(string errs)
        {
            string text = "";
            if (errs != null)
            {
                int i = 0;
                while (i < this.iErrorCount)
                {
                    if (errs.IndexOf(this.ErrorConvert[i, 0]) <= -1)
                    {
                        i++;
                    }
                    else
                    {
                        text = this.ErrorConvert[i, 1];
                        if (text.Length == 0)
                        {
                            return errs;
                        }
                        return text;
                    }
                }
            }
            return text;
        }
        public bool Step_SelectGetAvailability(SingleMember mMember, ref StoreInfo store)
        {
            bool flag = false;
            try
            {
                string text = this.Step_AjaxPost(mMember, "", "availability", store.m_Code, mMember.GetPartNumbers(store.m_Code), "UNLOCKED", 1);
                if (text.Length == 0)
                {
                    return flag;
                }
                string[] array = new string[]
				{
					"partNumber",
					"available"
				};
                DataTable groupInfoByAjaxInfo = HttpWeb.GetGroupInfoByAjaxInfo(text, array);
                if (groupInfoByAjaxInfo != null && groupInfoByAjaxInfo.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in groupInfoByAjaxInfo.Rows)
                    {
                        flag |= this.OnSetSelectInfoChange(mMember, (string)dataRow[array[0]], (string)dataRow[array[1]], store.m_Code);
                    }
                }
                if (flag)
                {
                    this.Step_PostAllValidProduct(mMember);
                }
                this.OnChangeFormText(mMember, "刷ing");
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
                flag = false;
            }
            return flag;
        }
        public void Step_CheckOneStores(SingleMember mMember, ref StoreInfo store)
        {
            this.LogState("读取商店时间信息" + store.m_Name);

            bool flag;
            if ((DateTime.Now - store.m_LastTime).TotalMinutes > 2.0)
            {
                flag = this.Step_SelectGetTimesLots(mMember, ref store);
                if (this.m_SoftMode != 0)
                {
                    Thread.Sleep(200);
                }
                if (flag)
                {
                    store.m_LastTime = DateTime.Now;
                }
            }
            else
            {
                flag = true;
            }
            if (flag)
            {
                this.LogState("读取iphone存货信息" + store.m_Name);
                flag = this.Step_SelectGetAvailability(mMember, ref store);
                int millisecondsTimeout = this.m_DelayFresh;
                millisecondsTimeout = Convert.ToInt32((double)this.m_DelayFresh * 0.5);
                if (this.m_SoftMode != 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                    return;
                }
                Thread.Sleep(1);
            }
        }
        public void Thread_CheckStore(object obj)
        {
            MainForm.ThreadStore threadStore = (MainForm.ThreadStore)obj;
            while (true)
            {
                for (int i = 0; i < threadStore.m_Store.Length; i++)
                {
                    if ((threadStore.m_Member.m_SelectedStore == null || threadStore.m_Member.m_SelectedStore == threadStore.m_Store[i]) && threadStore.m_Store[i].m_level > 0)
                    {
                        this.Step_CheckOneStores(threadStore.m_Member, ref threadStore.m_Store[i]);
                        if (this.m_SoftMode != 0)
                        {
                            Thread.Sleep(this.m_DelayFresh);
                        }
                        else
                        {
                            Thread.Sleep(1);
                        }
                    }
                }
                Thread.Sleep(1);
            }
        }
        public void Thread_StartCheckStore(MainForm.ThreadStore mThreadStore)
        {
            mThreadStore.m_Thread = new Thread(new ParameterizedThreadStart(this.Thread_CheckStore));
            mThreadStore.m_Thread.IsBackground = true;
            mThreadStore.m_Thread.Start(mThreadStore);
            string text = "";
            StoreInfo[] stores = this.m_Stores;
            for (int i = 0; i < stores.Length; i++)
            {
                StoreInfo storeInfo = stores[i];
                if (storeInfo.m_level > 0)
                {
                    text = text + storeInfo.m_Name + " ";
                }
            }
            mThreadStore.m_Thread.Name = "查询" + text + "线程";
            this.LogAdd("启动商店剩余查询线程.." + text, MainForm.LOG_TYPE.LOG_TYPE_Step);
        }
        public void Thread_SelectPost(object obj)
        {
            bool flag;
            do
            {
                flag = this.Step_SelectGetStore((SingleMember)obj);
                int millisecondsTimeout = this.m_DelayFresh;
                millisecondsTimeout = Convert.ToInt32((double)this.m_DelayFresh * 0.8);
                if (this.m_SoftMode != 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                else
                {
                    Thread.Sleep(10);
                }
            }
            while (!flag);
            SingleMember singleMember = (SingleMember)obj;
            if (!flag)
            {
                return;
            }
            this.m_ThreadCheckStore = new MainForm.ThreadStore[this.m_Stores.Length];
            this.m_ThreadCheckStore[0] = new MainForm.ThreadStore();
            this.m_ThreadCheckStore[0].m_Member = singleMember;
            this.m_ThreadCheckStore[0].m_Store = new StoreInfo[this.m_Stores.Length];
            this.m_ThreadCheckStore[0].m_Store = this.m_Stores;
            this.Thread_StartCheckStore(this.m_ThreadCheckStore[0]);
            singleMember.m_RobModeLastTime = DateTime.Now;
            TimeSpan t = new TimeSpan(0, 0, 45);
            while (true)
            {
                if (this.m_SoftMode == 1)
                {
                    singleMember.m_RobModeLastTime = DateTime.Now;
                }
                else
                {
                    TimeSpan t2 = DateTime.Now - singleMember.m_RobModeLastTime;
                    if (t2 > t)
                    {
                        this.OnCheckChange(this.radioButton_ModeScan, true);
                        this.m_SoftMode = 1;
                        this.LogAdd("自动切换回挂机模式", MainForm.LOG_TYPE.LOG_TYPE_No);
                    }
                }
                singleMember.m_AutoEvent.WaitOne(5000);
            }
        }
        public void OnStopSelectPostThreads(SingleMember mMember)
        {
            this.LogAdd("用户停止刷机线程", MainForm.LOG_TYPE.LOG_TYPE_Err);
            this.OnStopThread(this.m_ThreadSelectPost);
            if (this.m_ThreadCheckStore != null)
            {
                MainForm.ThreadStore[] threadCheckStore = this.m_ThreadCheckStore;
                for (int i = 0; i < threadCheckStore.Length; i++)
                {
                    MainForm.ThreadStore threadStore = threadCheckStore[i];
                    if (threadStore != null)
                    {
                        this.OnStopThread(threadStore.m_Thread);
                    }
                }
                this.m_ThreadCheckStore = null;
            }
            this.LogAdd("线程结束成功！", MainForm.LOG_TYPE.LOG_TYPE_Step);
        }
        public void Thread_StartSelectPost(SingleMember mMember)
        {
            if (this.m_ThreadSelectPost != null)
            {
                this.OnStopSelectPostThreads(mMember);
            }
            this.m_ThreadSelectPost = new Thread(new ParameterizedThreadStart(this.Thread_SelectPost));
            this.m_ThreadSelectPost.Name = "提交预定线程";
            this.m_ThreadSelectPost.IsBackground = true;
            this.m_ThreadSelectPost.Start(mMember);
            this.LogAdd("启动刷机线程...", MainForm.LOG_TYPE.LOG_TYPE_Step);
        }
        private void Step_LoginID(SingleMember mMember)
        {
            string text = "";
            string text2 = "";
            try
            {
                this.LogAdd("尝试登陆服务器...", MainForm.LOG_TYPE.LOG_TYPE_Step);
                this.OnChangeFormText(mMember, "登陆中");
                text = text + "openiForgotInNewWindow=" + mMember.openiForgotInNewWindow;
                text = text + "&fdcBrowserData=" + HttpWeb.smethod_1(MainForm.fdbstr);
                text = text + "&appleId=" + HttpWeb.smethod_1(mMember.m_AppleID);
                text = text + "&accountPassword=" + HttpWeb.smethod_1(mMember.m_ApplePass);
                text = text + "&captchaInput=" + mMember.m_PCode;
                text = text + "&captchaAudioInput=" + mMember.captchaAudioInput;
                text = text + "&appIdKey=" + mMember.m_appIdKey;
                text = text + "&language=" + mMember.language;
                text = text + "&path=" + HttpWeb.smethod_1(mMember.path);
                text = text + "&rv=" + mMember.rv;
                text = text + "&sslEnabled=" + mMember.sslEnabled;
                text = text + "&Env=" + mMember.Env;
                text += "&captchaType=image";
                text = text + "&captchaToken=" + mMember.m_token;
                string uRL = MainForm.m_URLSteps[2] + "IDMSWebAuth/authenticate";
                string text3 = HttpWeb.PostHtml(uRL, mMember.m_cookies, ref mMember.m_CookieCon, out text2, mMember.m_UrlStepLogin, text, out mMember.m_Lasturl);
                this.m_bPCodeOk = false;
                if (text3.Length > 100)
                {
                    string divInfoBYNeed = HttpWeb.GetDivInfoBYNeed(text3, "error-msg");
                    mMember.errors = HttpWeb.GetDivInfoBYNeed(text3, "error-unavailable");
                    if (divInfoBYNeed.Length > 0)
                    {
                        this.Step_LoginPCode(mMember);
                        this.LogAdd(divInfoBYNeed, MainForm.LOG_TYPE.LOG_TYPE_Err);
                        this.OnChangeFormText(mMember, "登陆异常");
                    }
                    else
                    {
                        if (mMember.errors.Length > 0)
                        {
                            this.Step_LoginPCode(mMember);
                            this.LogAdd(mMember.errors, MainForm.LOG_TYPE.LOG_TYPE_Err);
                            this.OnChangeFormText(mMember, "登陆异常");
                        }
                        else
                        {
                            if (text3.IndexOf("class=\"fillMeUpImage\"") > 0)
                            {
                                this.LogAdd("登陆被重置!..可能已经被封IP!", MainForm.LOG_TYPE.LOG_TYPE_Err);
                                this.OnChangeFormText(mMember, "登陆异常");
                            }
                            else
                            {
                                mMember.m_UrlStepPhoneCode = mMember.m_Lasturl;
                                this.LogAdd("登陆成功!!", MainForm.LOG_TYPE.LOG_TYPE_Suc);
                                this.OnChangeFormText(mMember, "登陆成功");
                                this.URLGetExcution(mMember);
                                if (this.m_Country == 0 || this.m_Country == 1)
                                {
                                    this.LogAdd("正在获取手机短信发送代码...", MainForm.LOG_TYPE.LOG_TYPE_No);
                                    this.Step_PhoneCodeGet(mMember);
                                    this.OnEnableButton(this.button_Paste, true);
                                    this.OnEnableButton(this.button_PhoneVerify, true);
                                }
                                else
                                {
                                    this.button_StartPost_Click(null, null);
                                }
                            }
                        }
                    }
                }
                else
                {
                    this.Step_LoginPCode(mMember);
                    this.OnChangeFormText(mMember, "登录失败,请重试");
                }
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
            }
        }
        public void URLGetExcution(SingleMember mMember)
        {
            if (mMember.m_Lasturl.Length > 0)
            {
                string text = HttpWeb.smethod_0(mMember.m_Lasturl, "execution");
                if (text.Length > 0)
                {
                    mMember._flowExecutionKey = text;
                }
            }
        }
        public void FreshFlowExcutionPIE(string contents, SingleMember mMember)
        {
        }
        public string Step_AjaxGet(SingleMember mMember, string urlParam2)
        {
            return this.Step_AjaxPost(mMember, urlParam2, "", "", "", "", 0);
        }
        public string Step_AjaxGet(SingleMember mMember, string urlParam2, bool Checkerror)
        {
            return this.Step_AjaxPost(mMember, urlParam2, "", "", "", "", 0, Checkerror);
        }
        public string Step_AjaxPost(SingleMember mMember, string strParam2, string sEventid, string storeNumber, string partNumbers, string selectedContractType, int iType)
        {
            return this.Step_AjaxPost(mMember, strParam2, sEventid, storeNumber, partNumbers, selectedContractType, iType, true);
        }
        public string Step_AjaxPost(SingleMember mMember, string strParam2, string sEventid, string storeNumber, string partNumbers, string selectedContractType, int iType, bool bCheckError)
        {
            string text = "";
            string uRL = "";
            string result = "";
            string text2 = "";
            string text3 = "";
            try
            {
                if (iType == 1)
                {
                    text2 += "ajaxSource=true";
                    text2 = text2 + "&_eventId=" + sEventid;
                    text2 = text2 + "&storeNumber=" + storeNumber;
                    text2 = text2 + "&p_ie=" + mMember.p_ie;
                }
                if (partNumbers.Length != 0)
                {
                    text2 = text2 + "&partNumbers=" + HttpWeb.smethod_1(partNumbers);
                    text2 = text2 + "&selectedContractType=" + selectedContractType;
                }
                try
                {
                    uRL = string.Format(MainForm.m_URLSteps[4], mMember._flowExecutionKey, strParam2);
                    mMember.m_CheckMutex.WaitOne(this.m_MutexWait);
                    if (iType == 0)
                    {
                        text = HttpWeb.GetHtml(uRL, out mMember.m_cookies, ref mMember.m_CookieCon, ref mMember.m_cHeaders, out uRL);
                    }
                    else
                    {
                        text = HttpWeb.PostHtml(uRL, mMember.m_cookies, ref mMember.m_CookieCon, out text3, mMember.m_Lasturl, text2, out uRL);
                    }
                    int millisecondsTimeout = this.m_DelayFresh;
                    millisecondsTimeout = Convert.ToInt32((double)this.m_DelayFresh * 0.15);
                    if (this.m_SoftMode != 0)
                    {
                        Thread.Sleep(millisecondsTimeout);
                    }
                    else
                    {
                        Thread.Sleep(1);
                    }
                    mMember.m_CheckMutex.ReleaseMutex();
                }
                catch (WebException ex)
                {
                    ex.StackTrace.ToString();
                    this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
                    if (ex.Message.IndexOf("503") > 0)
                    {
                        this.m_voiceType = 1;
                    }
                    mMember.m_CheckMutex.ReleaseMutex();
                }
                int num = 0;
                mMember.errors = "";
                if (text.Length > 20)
                {
                    mMember.errors = HttpWeb.GetDivInfoBYNeed(text, "error-unavailable");
                    if (mMember.errors.Length == 0)
                    {
                        num = 0;
                        mMember._flowExecutionKey = HttpWeb.GetDataByServerStr(text, "_flowExecutionKey", ref num);
                        num = 0;
                        mMember.p_ie = HttpWeb.GetDataByServerStr(text, "p_ie", ref num);
                        num = 0;
                        if (bCheckError)
                        {
                            mMember.errors = HttpWeb.GetDataByServerStr(text, "errors", ref num);
                        }
                    }
                    result = text;
                    if (mMember.errors.Length != 0)
                    {
                        this.ShowMemberError(mMember, "");
                    }
                }
            }
            catch (Exception ex2)
            {
                this.LogAdd(ex2.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
                this.OnChangeFormText(mMember, ex2.Message);
            }
            return result;
        }
        public string GetDifferPhoneHead(string oldPhone, string newPhone)
        {
            string result = "";
            if (newPhone != null)
            {
                int num = newPhone.IndexOf(oldPhone);
                if (num > -1)
                {
                    result = newPhone.Substring(0, num);
                }
            }
            return result;
        }
        public bool Step_SelectGetStore(SingleMember mMember)
        {
            bool result = true;
            string text = this.Step_AjaxGet(mMember, "&ajaxSource=true&_eventId=context", false);
            int num = 0;
            if (text.Length > 20)
            {
                num = 0;
                string dataByServerStr = HttpWeb.GetDataByServerStr(text, "phoneNumber", ref num);
                mMember.m_ReservInfo.m_PhoneHead = this.GetDifferPhoneHead(mMember.m_ReservInfo.m_PhoneNum, dataByServerStr);
                if (dataByServerStr.Length > 0)
                {
                    mMember.m_ReservInfo.m_PhoneNum = dataByServerStr;
                }
                num = 0;
                if (mMember.m_ReservInfo.m_PhoneNum.Length > 0)
                {
                    this.LogAdd("商店信息获取成功...", MainForm.LOG_TYPE.LOG_TYPE_Suc);
                }
                else
                {
                    this.LogAdd("商店信息获取失败,请重试...", MainForm.LOG_TYPE.LOG_TYPE_Suc);
                    result = false;
                }
            }
            return result;
        }
        public void Step_PhoneCodeGet(SingleMember mMember)
        {
            this.OnChangeFormText(mMember, "读短信码");
            string text = this.Step_AjaxGet(mMember, "&ajaxSource=true&_eventId=context");
            int num = 0;
            if (text.Length > 20)
            {
                mMember.m_sms = HttpWeb.GetDataByServerStr(text, "keyword", ref num);

                string[] res = text.Split('"');
                string base64string = "";
                for (int i = 0; i < res.Length; i++) {
                    if (res[i].Length > 500) {
                        base64string = res[i];
                        break;
                    }
                }
                base64string = base64string.Substring(22);
                    try
                    {
                        byte[] imageBytes = Convert.FromBase64String(base64string);
                        MemoryStream ms = new MemoryStream(imageBytes);
                        this.pictureBox_PhoneCode.Image = Image.FromStream(ms);
                        
                        //this.pictureBox_PhoneCode.Image.Save("checkcode.png", System.Drawing.Imaging.ImageFormat.Png);

                        Bitmap bm = (Bitmap)Image.FromStream(ms);
                        ms.Close();
                        Bitmap newbitmap = new Bitmap(bm.Width-42, bm.Height);
                        Graphics g = Graphics.FromImage(newbitmap);
                        g.DrawImage(bm, -42, 0);
                        g.Dispose();

                        newbitmap.Save("checkcode.png", System.Drawing.Imaging.ImageFormat.Png);
                        newbitmap.Dispose();
                        bm.Dispose(); 
                        Thread.Sleep(500);
                        ocr.buttonOcr_Click();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                num = 0;
                if (mMember.errors.Length == 0)
                {
                    this.LogAdd("代码读取成功,尽快输入手机验证码!!...", MainForm.LOG_TYPE.LOG_TYPE_Step);
                    if (this.checkBox_AutoCopy.Checked)
                    {
                        this.button_Copy_Click(null, null);
                    }
                }
            }
        }
        public void OnTextBoxChange(TextBox textBox, string str)
        {
            if (textBox.InvokeRequired)
            {
                MainForm.DelegateOnTextChange method = new MainForm.DelegateOnTextChange(this.OnTextBoxChange);
                base.BeginInvoke(method, new object[]
				{
					textBox,
					str
				});
                return;
            }
            textBox.Text = str;
            textBox.SelectAll();
        }
        public void Thread_StartLogin()
        {
            this.OnEnableButton(this.button_Login, false);
            this.OnAbortThread(this.m_ThreadLogin, "登陆线程");
            this.m_ThreadLogin = new Thread(new ThreadStart(this.Thread_Login));
            this.m_ThreadLogin.IsBackground = true;
            this.m_ThreadLogin.Start();
        }
        public void OnLoginCheck()
        {
            string text = this.textBox_AppleID.Text;
            string text2 = this.textBox_ApplePass.Text;
            if (text.Length != 0 && text2.Length != 0)
            {
                this.m_MemberA.m_AppleID = text;
                this.m_MemberA.m_ApplePass = text2;
                this.Thread_StartLogin();
                return;
            }
            MessageBox.Show("用户名密码不能为空");
            this.OnEnableButton(this.button_Login, true);
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            if (this.textBox_pCode.Text.Length == 0)
            {
                this.LogAdd("请输入验证码!", MainForm.LOG_TYPE.LOG_TYPE_Err);
                return;
            }
            if (!this.m_bPCodeSetOk)
            {
                this.m_MemberA.m_PCode = this.textBox_pCode.Text;
                this.m_bPCodeSetOk = true;
                this.OnEnableButton(this.button_Login, false);
                this.LogAdd("验证码已经保存", MainForm.LOG_TYPE.LOG_TYPE_Step);
            }
            if (this.m_bServerOK)
            {
                this.OnLoginCheck();
            }
        }
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            this.Thread_StartReadPCode();
        }
        public void Thread_ReadPCode()
        {
            if (this.m_MemberA != null)
            {
                this.Step_LoginPCode(this.m_MemberA);
            }
            else
            {
                this.LogAdd("请先刷新服务器页面", MainForm.LOG_TYPE.LOG_TYPE_Err);
            }
            this.OnEnableButton(this.button_Refresh, true);
        }
        public void Thread_StartReadPCode()
        {
            this.OnEnableButton(this.button_Refresh, false);
            this.OnEnableButton(this.button_Login, false);
            this.OnAbortThread(this.m_ThreadPCode, "验证码刷新线程");
            this.m_ThreadPCode = new Thread(new ThreadStart(this.Thread_ReadPCode));
            this.m_ThreadPCode.IsBackground = true;
            this.m_ThreadPCode.Start();
        }
        public void Thread_SoundPlay()
        {
            while (true)
            {
                if (this.checkBox_Voice.Checked)
                {
                    SoundPlayer soundPlayer = null;
                    if (this.m_voiceType != 0)
                    {
                        if (this.m_voiceType == 1)
                        {
                            //soundPlayer = new SoundPlayer(Resource1.warning2);
                        }
                        else
                        {
                            if (this.m_voiceType == 2)
                            {
                                //soundPlayer = new SoundPlayer(Resource1.money);
                            }
                        }
                    }
                    if (soundPlayer != null)
                    {
                        soundPlayer.Play();
                    }
                }
                Thread.Sleep(5000);
            }
        }
        public void Thread_StartSound()
        {
            this.OnAbortThread(this.m_ThreadSound, "声音线程");
            this.m_ThreadSound = new Thread(new ThreadStart(this.Thread_SoundPlay));
            this.m_ThreadSound.IsBackground = true;
            this.m_ThreadSound.Start();
        }
        private void textBox_pCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.button_Login.Enabled)
            {
                this.button_Login_Click(sender, null);
            }
        }
        private void button_Paste_Click(object sender, EventArgs e)
        {
            string text = Clipboard.GetText();
            if (text.Length > 0)
            {
                text = text.Trim();
                this.OnTextBoxChange(this.textBox_PhoneR, text);
                if (this.checkBox_AutoVerify.Checked)
                {
                    this.button_PhoneVerify_Click(null, null);
                }
            }
        }
        private void button_StartPost_Click(object sender, EventArgs e)
        {
            this.OnFreshFormInfoToMemA();
            this.OnEnableButton(this.button_Stop, true);
            this.OnEnableButton(this.button_StartPost, false);
            this.Thread_StartSelectPost(this.m_MemberA);
        }
        public void OnClipboardSet(string str)
        {
            if (this.textBox_PhoneR.InvokeRequired)
            {
                MainForm.DelegateOnString method = new MainForm.DelegateOnString(this.OnClipboardSet);
                base.BeginInvoke(method, new object[]
				{
					str
				});
                return;
            }
            Clipboard.SetText(str);
        }
        private void button_Copy_Click(object sender, EventArgs e)
        {
            ocr.buttonOcr_Click();
            string text = this.textBox_PhoneCode.Text;
            if (text.Length > 0)
            {
                text = text.Trim();
                this.OnClipboardSet(text);
            }
        }
        public void OnFreshFormInfoToMemA()
        {
            if (this.comboBox_IDType.InvokeRequired)
            {
                MainForm.DelegateOnUpdate method = new MainForm.DelegateOnUpdate(this.OnFreshFormInfoToMemA);
                base.BeginInvoke(method, new object[0]);
                return;
            }
            if (this.m_MemberA == null)
            {
                this.LogAdd("进入刷机后才会更新提交信息", MainForm.LOG_TYPE.LOG_TYPE_Err);
                return;
            }
            this.m_MemberA.m_smsRe = this.textBox_PhoneR.Text;
            if (this.m_MemberA.m_ReservInfo.m_PhoneHead != null)
            {
                this.m_MemberA.m_ReservInfo.m_PhoneNum = this.m_MemberA.m_ReservInfo.m_PhoneHead + this.textBox_PhoneNum.Text;
            }
            else
            {
                this.m_MemberA.m_ReservInfo.m_PhoneNum = this.textBox_PhoneNum.Text;
            }
            this.m_MemberA.m_ReservInfo.m_LastName = this.textBox_LName.Text;
            this.m_MemberA.m_ReservInfo.m_FirstName = this.textBox_FName.Text;
            this.m_MemberA.m_ReservInfo.m_IDType = this.comboBox_IDType.SelectedIndex;
            this.m_MemberA.m_ReservInfo.m_IDNum = this.textBox_IDNum.Text;
            if (this.m_MemberA.m_ReservInfo.m_IDType > -1 && this.m_MemberA.m_ReservInfo.m_IDType < 6)
            {
                this.m_MemberA.m_ReservInfo.m_IDTypeStr = MainForm.m_sIDTypesStr[this.m_MemberA.m_ReservInfo.m_IDType];
            }
            else
            {
                this.m_MemberA.m_ReservInfo.m_IDTypeStr = MainForm.m_sIDTypesStr[0];
            }
            this.m_MemberA.m_ReservInfo.m_email = this.textBox_EMail.Text;
            this.m_MemberA.m_ReservInfo.m_LeastTime = Convert.ToInt32(this.textBox_TimeLeast.Text);
            if (this.m_MemberA.m_ReservInfo.m_LeastTime < 20)
            {
                this.m_MemberA.m_ReservInfo.m_LeastTime = 20;
            }
            this.m_MemberA.m_ReservInfo.m_count = this.textBox_Count.Text;
            this.m_MemberA.m_ReservInfo.m_RTime = Convert.ToInt32(this.textBox_RTime.Text);
            this.m_MemberA.m_ReservInfo.m_RTimeMax = Convert.ToInt32(this.textBox_RTimeMax.Text);
            this.LogAdd("更新用户提交信息成功！", MainForm.LOG_TYPE.LOG_TYPE_Step);
        }
        private void button_PhoneVerify_Click(object sender, EventArgs e)
        {
            this.OnFreshFormInfoToMemA();
            this.Thread_StartPhoneCode();
        }
        public void OnStopThread(Thread thread)
        {
            if (thread != null)
            {
                this.LogAdd("正在停止线程" + thread.Name, MainForm.LOG_TYPE.LOG_TYPE_No);
                thread.Abort();
                thread = null;
            }
        }
        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.OnEnableButton(this.button_Stop, false);
            this.OnStopSelectPostThreads(this.m_MemberA);
            this.OnEnableButton(this.button_StartPost, true);
        }
        private void pictureBox_Code_Click(object sender, EventArgs e)
        {
            this.button_Refresh_Click(sender, e);
        }
        private void comboBox_Stores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.m_StoreText = this.comboBox_Stores.Text;
            if (this.m_MemberA != null)
            {
                this.m_MemberA.m_SelectedStore = this.GetStoreInfoByName(this.comboBox_Stores.Text);
            }
        }
        public StoreInfo GetStoreInfoByName(string sName)
        {
            StoreInfo result = null;
            if (sName == "全部商店")
            {
                result = null;
            }
            else
            {
                StoreInfo[] stores = this.m_Stores;
                for (int i = 0; i < stores.Length; i++)
                {
                    StoreInfo storeInfo = stores[i];
                    if (sName == storeInfo.m_Name)
                    {
                        result = storeInfo;
                    }
                }
            }
            return result;
        }
        private void textBox_PhoneR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button_PhoneVerify_Click(sender, null);
            }
        }
        public bool DataValidCheck()
        {
            bool result = true;
            if (this.textBox_PhoneNum.Text.Length == 0)
            {
                MessageBox.Show("电话号码不能为空");
                result = false;
            }
            if (this.textBox_LName.Text.Length == 0)
            {
                MessageBox.Show("姓 不能为空");
                result = false;
            }
            if (this.textBox_FName.Text.Length == 0)
            {
                MessageBox.Show("名 不能为空");
                result = false;
            }
            if (this.textBox_IDNum.Text.Length == 0)
            {
                MessageBox.Show("证件号码 不能为空");
                result = false;
            }
            if (this.textBox_RTime.Text.Length == 0)
            {
                MessageBox.Show("取货时间起点 不能为空");
                result = false;
            }
            Convert.ToUInt32(this.textBox_RTime.Text);
            if (Convert.ToUInt32(this.textBox_RTime.Text) > 23u)
            {
                MessageBox.Show("取货时间起点 的有效范围是 0   - 23");
                result = false;
            }
            if (this.textBox_RTimeMax.Text.Length == 0)
            {
                MessageBox.Show("取货时间最晚点 不能为空");
                result = false;
            }
            Convert.ToUInt32(this.textBox_RTimeMax.Text);
            if (Convert.ToUInt32(this.textBox_RTimeMax.Text) > 23u)
            {
                MessageBox.Show("取货时间最晚点 的有效范围是 0   - 23");
                result = false;
            }
            if (this.textBox_TimeLeast.Text.Length == 0)
            {
                MessageBox.Show("最短时间 不能为空");
                result = false;
            }
            if (this.textBox_Count.Text.Length == 0)
            {
                MessageBox.Show("取货数量 不能为空");
                result = false;
            }
            if (Convert.ToUInt32(this.textBox_Count.Text) < 1u || Convert.ToUInt32(this.textBox_Count.Text) > 2u)
            {
                MessageBox.Show("取货数量 的有效范围是 1   2");
                result = false;
            }
            if (this.textBox_EMail.Text.Length == 0)
            {
                MessageBox.Show("Email  不能为空");
                result = false;
            }
            return result;
        }
        private void button_Data_Add_Click(object sender, EventArgs e)
        {
            if (!this.DataValidCheck())
            {
                return;
            }
            this.ListReserveDataAdd(this.textBox_PhoneNum.Text, this.textBox_LName.Text, this.textBox_FName.Text, this.comboBox_IDType.Text, this.textBox_IDNum.Text, this.textBox_RTime.Text, this.textBox_RTimeMax.Text, this.textBox_EMail.Text, this.textBox_TimeLeast.Text, this.textBox_Count.Text);
            this.SaveUserConfig();
        }
        public void SaveUserConfig()
        {
            try
            {
                XmlControl xmlControl = new XmlControl(MainForm.m_sUserConfigPath);
                xmlControl.Delete(MainForm.m_sNodeReserveAll);
                if (this.listView_ReserveData.Items.Count > 0)
                {
                    xmlControl.InsertNode(MainForm.m_sUserMainNode, MainForm.m_sNodeReserve);
                    foreach (ListViewItem listViewItem in this.listView_ReserveData.Items)
                    {
                        string[] array = new string[MainForm.m_UserConfigKeys.Length];
                        for (int i = 0; i < MainForm.m_UserConfigKeys.Length; i++)
                        {
                            array[i] = listViewItem.SubItems[i].Text;
                        }
                        xmlControl.InsertElement(MainForm.m_sNodeReserveAll, "Reserve", MainForm.m_UserConfigKeys, array, "");
                    }
                }
                xmlControl.Save();
            }
            catch (Exception ex)
            {
                this.LogAdd(ex.Message, MainForm.LOG_TYPE.LOG_TYPE_Err);
            }
        }
        private void button_Data_Up_Click(object sender, EventArgs e)
        {
            if (!this.DataValidCheck())
            {
                return;
            }
            if (this.listView_ReserveData.SelectedItems.Count > 0)
            {
                this.ListReserveDataUpdate(this.listView_ReserveData.SelectedItems[0], this.textBox_PhoneNum.Text, this.textBox_LName.Text, this.textBox_FName.Text, this.comboBox_IDType.Text, this.textBox_IDNum.Text, this.textBox_RTime.Text, this.textBox_RTimeMax.Text, this.textBox_EMail.Text, this.textBox_TimeLeast.Text, this.textBox_Count.Text);
                this.SaveUserConfig();
                this.OnFreshFormInfoToMemA();
            }
        }
        public static string smethod_0(string encryptStr)
        {
            return MainForm.smethod_1(encryptStr, MainForm.m_s, MainForm.m_i);
        }
        public static string smethod_1(string encryptStr, string key, string IV)
        {
            key += "12345678";
            IV += "12345678";
            key = key.Substring(0, 8);
            IV = IV.Substring(0, 8);
            ICryptoTransform transform = new DESCryptoServiceProvider
            {
                Key = Encoding.UTF8.GetBytes(key),
                IV = Encoding.UTF8.GetBytes(IV)
            }.CreateEncryptor();
            byte[] bytes = Encoding.UTF8.GetBytes(encryptStr);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            cryptoStream.Close();
            string text = Convert.ToBase64String(memoryStream.ToArray());
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                int num = random.Next(36);
                char c = Convert.ToChar(num + 65);
                text = text.Substring(0, 2 * i + 1) + c.ToString() + text.Substring(2 * i + 1);
            }
            return text;
        }
        public static string smethod_2(string encryptedValue)
        {
            return MainForm.smethod_3(encryptedValue, MainForm.m_s, MainForm.m_i);
        }
        public static string smethod_3(string encryptedValue, string key, string IV)
        {
            string text = encryptedValue;
            if (text.Length < 16)
            {
                return "";
            }
            for (int i = 0; i < 8; i++)
            {
                text = text.Substring(0, i + 1) + text.Substring(i + 2);
            }
            encryptedValue = text;
            key += "12345678";
            IV += "12345678";
            key = key.Substring(0, 8);
            IV = IV.Substring(0, 8);
            string result;
            try
            {
                ICryptoTransform transform = new DESCryptoServiceProvider
                {
                    Key = Encoding.UTF8.GetBytes(key),
                    IV = Encoding.UTF8.GetBytes(IV)
                }.CreateDecryptor();
                byte[] array = Convert.FromBase64String(encryptedValue);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.FlushFinalBlock();
                cryptoStream.Close();
                string @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                result = @string;
            }
            catch (Exception)
            {
                result = "";
            }
            return result;
        }
        public void radioButtonChangeMode()
        {
            if (this.m_SoftMode == 0)
            {
                this.LogAdd("切换抢购模式...", MainForm.LOG_TYPE.LOG_TYPE_Step);
                return;
            }
            this.LogAdd("切换挂机模式...", MainForm.LOG_TYPE.LOG_TYPE_Step);
        }
        private void radioButton_ModeRob_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_ModeRob.Checked)
            {
                this.m_SoftMode = 0;
                this.radioButtonChangeMode();
            }
        }
        private void radioButton_ModeScan_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_ModeScan.Checked)
            {
                this.m_SoftMode = 1;
                this.radioButtonChangeMode();
            }
        }
        private void button_Data_Del_Click(object sender, EventArgs e)
        {
            if (this.listView_ReserveData.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("确认删除该行?", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    this.listView_ReserveData.SelectedItems[0].Remove();
                    this.SaveUserConfig();
                }
            }
        }
        private void textBox_ApplePass_TextChanged(object sender, EventArgs e)
        {
            if (this.listView_Appleid.SelectedItems.Count > 0)
            {
                this.listView_Appleid.SelectedItems[0].SubItems[1].Text = this.textBox_ApplePass.Text;
            }
        }
        private void textBox_StoreReDelay_TextChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.textBox_StoreReDelay.Text);
            if (num > 10000 || num < 300)
            {
                num = 1500;
            }
            this.m_DelayFresh = num;
        }
        private void checkBox_Voice_CheckedChanged(object sender, EventArgs e)
        {
            this.m_voiceType = 0;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.listView_Appleid = new ListView();
            this.AppleID = new ColumnHeader();
            this.Password = new ColumnHeader();
            this.listView_ReserveData = new ListView();
            this.Phone = new ColumnHeader();
            this.LastName = new ColumnHeader();
            this.FirstName = new ColumnHeader();
            this.columnHeader_0 = new ColumnHeader();
            this.IDNum = new ColumnHeader();
            this.rtime = new ColumnHeader();
            this.RTimeMax = new ColumnHeader();
            this.tMin = new ColumnHeader();
            this.count = new ColumnHeader();
            this.email = new ColumnHeader();
            this.textBox_AppleID = new TextBox();
            this.textBox_ApplePass = new TextBox();
            this.textBox_PhoneNum = new TextBox();
            this.groupBox1 = new GroupBox();
            this.label_AppleID = new Label();
            this.label8 = new Label();
            this.textBox_Count = new TextBox();
            this.textBox_TimeLeast = new TextBox();
            this.textBox_EMail = new TextBox();
            this.textBox_RTimeMax = new TextBox();
            this.textBox_RTime = new TextBox();
            this.button_Data_Up = new Button();
            this.button_AID_Del = new Button();
            this.button_Data_Del = new Button();
            this.button_Data_Add = new Button();
            this.button_AID_Up = new Button();
            this.button_AID_Add = new Button();
            this.comboBox_IDType = new ComboBox();
            this.textBox_IDNum = new TextBox();
            this.textBox_FName = new TextBox();
            this.textBox_LName = new TextBox();
            this.textBox_pCode = new TextBox();
            this.button_Refresh = new Button();
            this.button_Login = new Button();
            this.label_TextSend = new Label();
            this.textBox_PhoneCode = new TextBox();
            this.button_Copy = new Button();
            this.textBox_PhoneR = new TextBox();
            this.label_TextR = new Label();
            this.button_Paste = new Button();
            this.label3 = new Label();
            this.checkBox_FreshWait = new CheckBox();
            this.button_Start_FW = new Button();
            this.label4 = new Label();
            this.textBox_Delay_FW = new TextBox();
            this.button_StartPost = new Button();
            this.groupBox3 = new GroupBox();
            this.radioButton_ModeScan = new RadioButton();
            this.radioButton_ModeRob = new RadioButton();
            this.button_Stop = new Button();
            this.label6 = new Label();
            this.textBox_StoreReDelay = new TextBox();
            this.listView_Select = new ListView();
            this.cLevel = new ColumnHeader();
            this.cName = new ColumnHeader();
            this.cStore = new ColumnHeader();
            this.cCount = new ColumnHeader();
            this.cState = new ColumnHeader();
            this.checkBox_AutoCopy = new CheckBox();
            this.button_PhoneVerify = new Button();
            this.checkBox_AutoVerify = new CheckBox();
            this.comboBox_Stores = new ComboBox();
            this.label7 = new Label();
            this.richTextBox_Log = new RichTextBox();
            this.checkBox_AutoStart = new CheckBox();
            this.label_Log = new Label();
            this.groupBox2 = new GroupBox();
            this.checkBox_Voice = new CheckBox();
            this.pictureBox_Code = new PictureBox();
            this.pictureBox_PhoneCode = new PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((ISupportInitialize)this.pictureBox_Code).BeginInit();
            base.SuspendLayout();
            this.listView_Appleid.Columns.AddRange(new ColumnHeader[]
			{
				this.AppleID,
				this.Password
			});
            this.listView_Appleid.FullRowSelect = true;
            this.listView_Appleid.GridLines = true;
            this.listView_Appleid.HideSelection = false;
            this.listView_Appleid.Location = new Point(7, 18);
            this.listView_Appleid.MultiSelect = false;
            this.listView_Appleid.Name = "listView_Appleid";
            this.listView_Appleid.Size = new Size(297, 99);
            this.listView_Appleid.TabIndex = 0;
            this.listView_Appleid.UseCompatibleStateImageBehavior = false;
            this.listView_Appleid.View = View.Details;
            this.listView_Appleid.MouseClick += new MouseEventHandler(this.listView_Appleid_MouseClick);
            this.AppleID.Text = "AppleID";
            this.AppleID.Width = 135;
            this.Password.Text = "Password";
            this.Password.Width = 135;
            this.listView_ReserveData.Columns.AddRange(new ColumnHeader[]
			{
				this.Phone,
				this.LastName,
				this.FirstName,
				this.columnHeader_0,
				this.IDNum,
				this.rtime,
				this.RTimeMax,
				this.tMin,
				this.count,
				this.email
			});
            this.listView_ReserveData.FullRowSelect = true;
            this.listView_ReserveData.GridLines = true;
            this.listView_ReserveData.HideSelection = false;
            this.listView_ReserveData.Location = new Point(310, 18);
            this.listView_ReserveData.MultiSelect = false;
            this.listView_ReserveData.Name = "listView_ReserveData";
            this.listView_ReserveData.Size = new Size(472, 97);
            this.listView_ReserveData.TabIndex = 1;
            this.listView_ReserveData.UseCompatibleStateImageBehavior = false;
            this.listView_ReserveData.View = View.Details;
            this.listView_ReserveData.Click += new EventHandler(this.listView_ReserveData_Click);
            this.Phone.Text = "电话";
            this.Phone.Width = 70;
            this.LastName.Text = "姓";
            this.LastName.TextAlign = HorizontalAlignment.Center;
            this.LastName.Width = 35;
            this.FirstName.Text = "名";
            this.FirstName.TextAlign = HorizontalAlignment.Center;
            this.FirstName.Width = 50;
            this.columnHeader_0.Text = "证件类型";
            this.columnHeader_0.Width = 72;
            this.IDNum.Text = "证件号";
            this.IDNum.Width = 90;
            this.rtime.Text = "时";
            this.rtime.Width = 25;
            this.RTimeMax.Text = "段";
            this.RTimeMax.Width = 25;
            this.tMin.Text = "最少";
            this.tMin.Width = 40;
            this.count.Text = "量";
            this.count.Width = 25;
            this.email.Text = "mail";
            this.textBox_AppleID.Location = new Point(7, 123);
            this.textBox_AppleID.Name = "textBox_AppleID";
            this.textBox_AppleID.Size = new Size(113, 21);
            this.textBox_AppleID.TabIndex = 2;
            this.textBox_AppleID.Visible = false;
            this.textBox_ApplePass.Location = new Point(165, 124);
            this.textBox_ApplePass.Name = "textBox_ApplePass";
            this.textBox_ApplePass.Size = new Size(126, 21);
            this.textBox_ApplePass.TabIndex = 3;
            this.textBox_ApplePass.TextChanged += new EventHandler(this.textBox_ApplePass_TextChanged);
            this.textBox_PhoneNum.Location = new Point(311, 124);
            this.textBox_PhoneNum.Name = "textBox_PhoneNum";
            this.textBox_PhoneNum.Size = new Size(65, 21);
            this.textBox_PhoneNum.TabIndex = 4;
            this.groupBox1.Controls.Add(this.label_AppleID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_Count);
            this.groupBox1.Controls.Add(this.textBox_TimeLeast);
            this.groupBox1.Controls.Add(this.textBox_EMail);
            this.groupBox1.Controls.Add(this.textBox_RTimeMax);
            this.groupBox1.Controls.Add(this.textBox_RTime);
            this.groupBox1.Controls.Add(this.button_Data_Up);
            this.groupBox1.Controls.Add(this.button_AID_Del);
            this.groupBox1.Controls.Add(this.button_Data_Del);
            this.groupBox1.Controls.Add(this.button_Data_Add);
            this.groupBox1.Controls.Add(this.button_AID_Up);
            this.groupBox1.Controls.Add(this.button_AID_Add);
            this.groupBox1.Controls.Add(this.comboBox_IDType);
            this.groupBox1.Controls.Add(this.textBox_IDNum);
            this.groupBox1.Controls.Add(this.textBox_FName);
            this.groupBox1.Controls.Add(this.textBox_LName);
            this.groupBox1.Controls.Add(this.textBox_PhoneNum);
            this.groupBox1.Controls.Add(this.textBox_ApplePass);
            this.groupBox1.Controls.Add(this.textBox_AppleID);
            this.groupBox1.Controls.Add(this.listView_ReserveData);
            this.groupBox1.Controls.Add(this.listView_Appleid);
            this.groupBox1.Location = new Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(793, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置选择";
            this.label_AppleID.AutoSize = true;
            this.label_AppleID.Location = new Point(6, 128);
            this.label_AppleID.Name = "label_AppleID";
            this.label_AppleID.Size = new Size(53, 12);
            this.label_AppleID.TabIndex = 21;
            this.label_AppleID.Text = "username";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(134, 129);
            this.label8.Name = "label8";
            this.label8.Size = new Size(29, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "密码";
            this.textBox_Count.Location = new Point(739, 125);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new Size(23, 21);
            this.textBox_Count.TabIndex = 19;
            this.textBox_TimeLeast.Location = new Point(696, 124);
            this.textBox_TimeLeast.Name = "textBox_TimeLeast";
            this.textBox_TimeLeast.Size = new Size(37, 21);
            this.textBox_TimeLeast.TabIndex = 18;
            this.textBox_EMail.Location = new Point(646, 150);
            this.textBox_EMail.Name = "textBox_EMail";
            this.textBox_EMail.Size = new Size(141, 21);
            this.textBox_EMail.TabIndex = 17;
            this.textBox_RTimeMax.Location = new Point(672, 124);
            this.textBox_RTimeMax.Name = "textBox_RTimeMax";
            this.textBox_RTimeMax.Size = new Size(20, 21);
            this.textBox_RTimeMax.TabIndex = 16;
            this.textBox_RTime.Location = new Point(646, 124);
            this.textBox_RTime.Name = "textBox_RTime";
            this.textBox_RTime.Size = new Size(20, 21);
            this.textBox_RTime.TabIndex = 15;
            this.button_Data_Up.Location = new Point(412, 150);
            this.button_Data_Up.Name = "button_Data_Up";
            this.button_Data_Up.Size = new Size(89, 23);
            this.button_Data_Up.TabIndex = 14;
            this.button_Data_Up.Text = "更新";
            this.button_Data_Up.UseVisualStyleBackColor = true;
            this.button_Data_Up.Click += new EventHandler(this.button_Data_Up_Click);
            this.button_AID_Del.Location = new Point(186, 151);
            this.button_AID_Del.Name = "button_AID_Del";
            this.button_AID_Del.Size = new Size(75, 23);
            this.button_AID_Del.TabIndex = 10;
            this.button_AID_Del.Text = "删除";
            this.button_AID_Del.UseVisualStyleBackColor = true;
            this.button_Data_Del.Location = new Point(528, 150);
            this.button_Data_Del.Name = "button_Data_Del";
            this.button_Data_Del.Size = new Size(80, 23);
            this.button_Data_Del.TabIndex = 13;
            this.button_Data_Del.Text = "删除";
            this.button_Data_Del.UseVisualStyleBackColor = true;
            this.button_Data_Del.Click += new EventHandler(this.button_Data_Del_Click);
            this.button_Data_Add.Location = new Point(311, 150);
            this.button_Data_Add.Name = "button_Data_Add";
            this.button_Data_Add.Size = new Size(84, 23);
            this.button_Data_Add.TabIndex = 12;
            this.button_Data_Add.Text = "添加";
            this.button_Data_Add.UseVisualStyleBackColor = true;
            this.button_Data_Add.Click += new EventHandler(this.button_Data_Add_Click);
            this.button_AID_Up.Location = new Point(96, 151);
            this.button_AID_Up.Name = "button_AID_Up";
            this.button_AID_Up.Size = new Size(72, 23);
            this.button_AID_Up.TabIndex = 11;
            this.button_AID_Up.Text = "更新";
            this.button_AID_Up.UseVisualStyleBackColor = true;
            this.button_AID_Add.Location = new Point(9, 151);
            this.button_AID_Add.Name = "button_AID_Add";
            this.button_AID_Add.Size = new Size(77, 23);
            this.button_AID_Add.TabIndex = 9;
            this.button_AID_Add.Text = "添加";
            this.button_AID_Add.UseVisualStyleBackColor = true;
            this.comboBox_IDType.FormattingEnabled = true;
            this.comboBox_IDType.Location = new Point(453, 124);
            this.comboBox_IDType.Name = "comboBox_IDType";
            this.comboBox_IDType.Size = new Size(65, 20);
            this.comboBox_IDType.TabIndex = 8;
            this.textBox_IDNum.Location = new Point(528, 124);
            this.textBox_IDNum.Name = "textBox_IDNum";
            this.textBox_IDNum.Size = new Size(113, 21);
            this.textBox_IDNum.TabIndex = 7;
            this.textBox_FName.Location = new Point(412, 124);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new Size(35, 21);
            this.textBox_FName.TabIndex = 6;
            this.textBox_LName.Location = new Point(382, 124);
            this.textBox_LName.Name = "textBox_LName";
            this.textBox_LName.Size = new Size(24, 21);
            this.textBox_LName.TabIndex = 5;
            this.textBox_pCode.Font = new Font("宋体", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
            this.textBox_pCode.Location = new Point(19, 299);
            this.textBox_pCode.Name = "textBox_pCode";
            this.textBox_pCode.Size = new Size(152, 38);
            this.textBox_pCode.TabIndex = 16;
            this.textBox_pCode.KeyDown += new KeyEventHandler(this.textBox_pCode_KeyDown);
            this.button_Refresh.Location = new Point(198, 224);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new Size(66, 34);
            this.button_Refresh.TabIndex = 17;
            this.button_Refresh.Text = "刷验证码";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new EventHandler(this.button_Refresh_Click);
            this.button_Login.Location = new Point(189, 299);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new Size(74, 35);
            this.button_Login.TabIndex = 18;
            this.button_Login.Text = "确认验证码";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new EventHandler(this.button_Login_Click);
            this.label_TextSend.AutoSize = true;
            this.label_TextSend.Location = new Point(1, 341);
            this.label_TextSend.Name = "label_TextSend";
            this.label_TextSend.Size = new Size(95, 12);
            this.label_TextSend.TabIndex = 19;
            this.label_TextSend.Text = "2.需发送短信码:";
            this.textBox_PhoneCode.Font = new Font("宋体", 18f, FontStyle.Regular, GraphicsUnit.Point, 134);
            this.textBox_PhoneCode.Location = new Point(12, 359);
            this.textBox_PhoneCode.Name = "textBox_PhoneCode";
            this.textBox_PhoneCode.Size = new Size(168, 35);
            this.textBox_PhoneCode.TabIndex = 21;
            this.button_Copy.Location = new Point(203, 359);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new Size(60, 35);
            this.button_Copy.TabIndex = 22;
            this.button_Copy.Text = "复制出";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new EventHandler(this.button_Copy_Click);
            this.textBox_PhoneR.Font = new Font("宋体", 18f, FontStyle.Regular, GraphicsUnit.Point, 134);
            this.textBox_PhoneR.Location = new Point(21, 419);
            this.textBox_PhoneR.Name = "textBox_PhoneR";
            this.textBox_PhoneR.Size = new Size(121, 35);
            this.textBox_PhoneR.TabIndex = 23;
            this.textBox_PhoneR.KeyDown += new KeyEventHandler(this.textBox_PhoneR_KeyDown);
            this.label_TextR.AutoSize = true;
            this.label_TextR.Location = new Point(19, 401);
            this.label_TextR.Name = "label_TextR";
            this.label_TextR.Size = new Size(71, 12);
            this.label_TextR.TabIndex = 24;
            this.label_TextR.Text = "回复验证码:";
            this.button_Paste.Location = new Point(148, 419);
            this.button_Paste.Name = "button_Paste";
            this.button_Paste.Size = new Size(51, 38);
            this.button_Paste.TabIndex = 25;
            this.button_Paste.Text = "粘贴";
            this.button_Paste.UseVisualStyleBackColor = true;
            this.button_Paste.Click += new EventHandler(this.button_Paste_Click);
            this.label3.AutoSize = true;
            this.label3.Location = new Point(8, 195);
            this.label3.Name = "label3";
            this.label3.Size = new Size(17, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "1.";
            this.checkBox_FreshWait.AutoSize = true;
            this.checkBox_FreshWait.Checked = true;
            this.checkBox_FreshWait.CheckState = CheckState.Checked;
            this.checkBox_FreshWait.Location = new Point(20, 195);
            this.checkBox_FreshWait.Name = "checkBox_FreshWait";
            this.checkBox_FreshWait.Size = new Size(144, 16);
            this.checkBox_FreshWait.TabIndex = 28;
            this.checkBox_FreshWait.Text = "刷新预定界面直到开启";
            this.checkBox_FreshWait.UseVisualStyleBackColor = true;
            this.button_Start_FW.Location = new Point(198, 264);
            this.button_Start_FW.Name = "button_Start_FW";
            this.button_Start_FW.Size = new Size(66, 33);
            this.button_Start_FW.TabIndex = 29;
            this.button_Start_FW.Text = "等开机";
            this.button_Start_FW.UseVisualStyleBackColor = true;
            this.button_Start_FW.Click += new EventHandler(this.button_Start_FW_Click);
            this.label4.AutoSize = true;
            this.label4.Location = new Point(196, 197);
            this.label4.Name = "label4";
            this.label4.Size = new Size(29, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "延时";
            this.textBox_Delay_FW.Location = new Point(221, 193);
            this.textBox_Delay_FW.Name = "textBox_Delay_FW";
            this.textBox_Delay_FW.Size = new Size(40, 21);
            this.textBox_Delay_FW.TabIndex = 16;
            this.textBox_Delay_FW.Text = "1000";
            this.button_StartPost.Location = new Point(6, 227);
            this.button_StartPost.Name = "button_StartPost";
            this.button_StartPost.Size = new Size(80, 38);
            this.button_StartPost.TabIndex = 34;
            this.button_StartPost.Text = "开刷";
            this.button_StartPost.UseVisualStyleBackColor = true;
            this.button_StartPost.Click += new EventHandler(this.button_StartPost_Click);
            this.groupBox3.Controls.Add(this.checkBox_Voice);
            this.groupBox3.Controls.Add(this.radioButton_ModeScan);
            this.groupBox3.Controls.Add(this.radioButton_ModeRob);
            this.groupBox3.Controls.Add(this.button_Stop);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox_StoreReDelay);
            this.groupBox3.Controls.Add(this.button_StartPost);
            this.groupBox3.Location = new Point(272, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(92, 277);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3.刷机设置";
            this.radioButton_ModeScan.AutoSize = true;
            this.radioButton_ModeScan.Location = new Point(10, 75);
            this.radioButton_ModeScan.Name = "radioButton_ModeScan";
            this.radioButton_ModeScan.Size = new Size(71, 16);
            this.radioButton_ModeScan.TabIndex = 46;
            this.radioButton_ModeScan.Text = "挂机模式";
            this.radioButton_ModeScan.UseVisualStyleBackColor = true;
            this.radioButton_ModeScan.CheckedChanged += new EventHandler(this.radioButton_ModeScan_CheckedChanged);
            this.radioButton_ModeRob.AutoSize = true;
            this.radioButton_ModeRob.Checked = true;
            this.radioButton_ModeRob.Location = new Point(10, 53);
            this.radioButton_ModeRob.Name = "radioButton_ModeRob";
            this.radioButton_ModeRob.Size = new Size(71, 16);
            this.radioButton_ModeRob.TabIndex = 45;
            this.radioButton_ModeRob.TabStop = true;
            this.radioButton_ModeRob.Text = "抢购模式";
            this.radioButton_ModeRob.UseVisualStyleBackColor = true;
            this.radioButton_ModeRob.CheckedChanged += new EventHandler(this.radioButton_ModeRob_CheckedChanged);
            this.button_Stop.Location = new Point(6, 187);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new Size(80, 38);
            this.button_Stop.TabIndex = 44;
            this.button_Stop.Text = "停止";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new EventHandler(this.button_Stop_Click);
            this.label6.AutoSize = true;
            this.label6.Location = new Point(10, 28);
            this.label6.Name = "label6";
            this.label6.Size = new Size(29, 12);
            this.label6.TabIndex = 43;
            this.label6.Text = "延时";
            this.textBox_StoreReDelay.Location = new Point(41, 24);
            this.textBox_StoreReDelay.Name = "textBox_StoreReDelay";
            this.textBox_StoreReDelay.Size = new Size(35, 21);
            this.textBox_StoreReDelay.TabIndex = 42;
            this.textBox_StoreReDelay.Text = "2500";
            this.textBox_StoreReDelay.TextChanged += new EventHandler(this.textBox_StoreReDelay_TextChanged);
            this.listView_Select.Columns.AddRange(new ColumnHeader[]
			{
				this.cLevel,
				this.cName,
				this.cStore,
				this.cCount,
				this.cState
			});
            this.listView_Select.GridLines = true;
            this.listView_Select.LabelEdit = true;
            this.listView_Select.Location = new Point(372, 220);
            this.listView_Select.MultiSelect = false;
            this.listView_Select.Name = "listView_Select";
            this.listView_Select.Size = new Size(413, 432);
            this.listView_Select.Sorting = SortOrder.Descending;
            this.listView_Select.TabIndex = 38;
            this.listView_Select.UseCompatibleStateImageBehavior = false;
            this.listView_Select.View = View.Details;
            this.cLevel.Text = "优先级";
            this.cLevel.Width = 50;
            this.cName.Text = "型号";
            this.cName.Width = 150;
            this.cStore.Text = "商店";
            this.cStore.Width = 40;
            this.cCount.Text = "量";
            this.cCount.Width = 25;
            this.cState.Text = "状态";
            this.cState.Width = 160;
            this.checkBox_AutoCopy.AutoSize = true;
            this.checkBox_AutoCopy.Location = new Point(102, 340);
            this.checkBox_AutoCopy.Name = "checkBox_AutoCopy";
            this.checkBox_AutoCopy.Size = new Size(120, 16);
            this.checkBox_AutoCopy.TabIndex = 39;
            this.checkBox_AutoCopy.Text = "自动复制到剪贴板";
            this.checkBox_AutoCopy.UseVisualStyleBackColor = true;
            this.button_PhoneVerify.Location = new Point(203, 419);
            this.button_PhoneVerify.Name = "button_PhoneVerify";
            this.button_PhoneVerify.Size = new Size(58, 38);
            this.button_PhoneVerify.TabIndex = 40;
            this.button_PhoneVerify.Text = "验证";
            this.button_PhoneVerify.UseVisualStyleBackColor = true;
            this.button_PhoneVerify.Click += new EventHandler(this.button_PhoneVerify_Click);
            this.checkBox_AutoVerify.AutoSize = true;
            this.checkBox_AutoVerify.Checked = true;
            this.checkBox_AutoVerify.CheckState = CheckState.Checked;
            this.checkBox_AutoVerify.Location = new Point(91, 400);
            this.checkBox_AutoVerify.Name = "checkBox_AutoVerify";
            this.checkBox_AutoVerify.Size = new Size(108, 16);
            this.checkBox_AutoVerify.TabIndex = 41;
            this.checkBox_AutoVerify.Text = "粘贴后自动验证";
            this.checkBox_AutoVerify.UseVisualStyleBackColor = true;
            this.comboBox_Stores.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_Stores.FormattingEnabled = true;
            this.comboBox_Stores.Location = new Point(443, 189);
            this.comboBox_Stores.Name = "comboBox_Stores";
            this.comboBox_Stores.Size = new Size(121, 20);
            this.comboBox_Stores.TabIndex = 42;
            this.comboBox_Stores.SelectedIndexChanged += new EventHandler(this.comboBox_Stores_SelectedIndexChanged);
            this.label7.AutoSize = true;
            this.label7.Location = new Point(375, 195);
            this.label7.Name = "label7";
            this.label7.Size = new Size(53, 12);
            this.label7.TabIndex = 43;
            this.label7.Text = "商店选择";
            this.richTextBox_Log.Location = new Point(9, 20);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.Size = new Size(348, 154);
            this.richTextBox_Log.TabIndex = 0;
            this.richTextBox_Log.Text = "";
            this.checkBox_AutoStart.AutoSize = true;
            this.checkBox_AutoStart.Checked = true;
            this.checkBox_AutoStart.CheckState = CheckState.Checked;
            this.checkBox_AutoStart.Location = new Point(88, 0);
            this.checkBox_AutoStart.Name = "checkBox_AutoStart";
            this.checkBox_AutoStart.Size = new Size(132, 16);
            this.checkBox_AutoStart.TabIndex = 26;
            this.checkBox_AutoStart.Text = "验证若成功自动开刷";
            this.checkBox_AutoStart.UseVisualStyleBackColor = true;
            this.label_Log.AutoSize = true;
            this.label_Log.Location = new Point(6, 177);
            this.label_Log.Name = "label_Log";
            this.label_Log.Size = new Size(29, 12);
            this.label_Log.TabIndex = 42;
            this.label_Log.Text = "状态";
            this.groupBox2.Controls.Add(this.label_Log);
            this.groupBox2.Controls.Add(this.checkBox_AutoStart);
            this.groupBox2.Controls.Add(this.richTextBox_Log);
            this.groupBox2.Location = new Point(3, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(363, 192);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            this.checkBox_Voice.AutoSize = true;
            this.checkBox_Voice.Checked = true;
            this.checkBox_Voice.CheckState = CheckState.Checked;
            this.checkBox_Voice.Location = new Point(10, 99);
            this.checkBox_Voice.Name = "checkBox_Voice";
            this.checkBox_Voice.Size = new Size(78, 16);
            this.checkBox_Voice.TabIndex = 47;
            this.checkBox_Voice.Text = " 语音提示";
            this.checkBox_Voice.UseVisualStyleBackColor = true;
            this.checkBox_Voice.CheckedChanged += new EventHandler(this.checkBox_Voice_CheckedChanged);
            //this.pictureBox_Code.Image = Resource1.pic_pCodeDefault;
            //this.pictureBox_PhoneCode.Image = Image.FromFile("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAR4AAAAiCAYAAACJBra0AAAIPElEQVR42u1cf2TdVxSPZ2ZmxsxMzYyZqnVtmqZJTEQbqqKqnlE1FVVhamomRk1FxP6pqaqIUjFVESMif0xNqZqamRBRNVWhoiqqSlRERDxez4nznZvTc+/33O+P9xLOh6vpe/d7vvd7v+d+7vl1X0uLwWAwGAwGg8FgMBgMBoPBYDAYDAaDwbBj0Nra+klHR8fRpB08eHB/Wh/e2tvbe9va2j5qxnjh3ntC/aHPAaf/Af49jPvLGHnw/S63f2dn54cpQ64cOnToJFx3HeZ2Gv6dgXYL/j7X1dX1vuaZsR/I6KfrEhmT0MZRDvx77MiRI29p39vevXvf1tyXXwf36tG8E6F1pN1TIeN//dSOP0Y2yP0C35UxQoMACj0Ailt32oyij6+t4/WoaA0c73hg4Rx2+tWkhYOLWSuP7t/v9of/Hw8tXOizGJivVWg/pBDdeeoXnHsYx5j2vcE8nFbMc7dw7UvlO/G1eeybU0bSFuCaX2Hj+CyDznj1F/pOwGay25hhZxGPq9zfNJN4cJeD7144/QY9C7sU4oHvTgnz8hDa30iCbK6uemT8rJ3vGOKR3rFw7+slEE/SJovQMWdDGS6IeJK2UubmachOPLjbjEG7gTsE/P+ZR0krzSAeNMXh81lnYU8HFljhxAM6+zl8t+b0e+G6eeiuEQF5rRA0/YU5HU1cAnCt3sF7w2cjSGiRxLMB7d2Qewjfv8pBPP/heGCsv5FbuCbIOpYi4wnp2FgiC9rvHl3DditCZzbHh+8a2hQ+lyDvgbHDNiMeVACuqKRk3OrpawbxsLEshGIpZRCPMBdV3gdjQ/D5stNnySVqkHuJybidFgeK3OnP+mTB+E94rlERDydBjP8Ji/t6rB464+tj1mzSzmcZH21UXA/qsFl8agyxvYmnBXdg2kndfmcaTTzs+1UMHqe4FEUTT4Xt8OuBe4/6rB4+LrQuc87VmpbIKHBd5y5hVuIhmVMhCyWGeEjeHnSJ2DXLUuBZMz647j3BBe4zhtjmxEPK8JK94P5GEg/65S75aYivaOIhN2uLWxrYuU/7Yh/kBmxxPfbt2/dBjrlawuCuGxuR5NHuv0Hz92dRxEPZuLov5hZLPL4YmPTONeMjeXzj7DGG2P7EU6GsVtDFKIt4yJxfSlOuBhDPUSbvReDeVdZ3MUBK2B5JJQERxPMTG/tA6Pn4s2YlHnIrXetkBVzDj/MSD1kpG7GBa49FtovHwaQSBcM2Ix5K+27JNnDlKpN44N97zmezWqUpmnjwmbkC+4LswsKuMSJfkLI40K4p6ofeIB5MPTNZ94T5uJO4iOQ+5yIe+Psr+GzOdfmkuFgW4mHjTdpcFuJBV1ZjFRm2D/HgAhkUzNTpBo0Xi+iuun4+ptK18soILsPnzzV1Mzyzhc2NUWB8ypNxqZMFcbElkDnkxEOW1D8uibmFn2Q11ui5JmiMWbJaT+E+d1nwfJPofDG3rMQjBPJfaYkHM3sYSBdcyiUNsRsaTDyU0pyh3UZKlT4vw9rxjGVRqGk53mTiGeKKjLEf1ueyRCg8OEoxo4eB7NQDX8Gbh3h+ZNd/7/S/wJ+roDoe3JRG0DXKo4ee68Y4IWcYn9sea4oSDc0hnlCbk14cHRtYj2lYPasYyx1hZ13WKk8ZxEMB2jlh8U1R3dPjJPDM589jwWC5wrAQQ3ML3g5riIfHMqDPfcd6SKyh5WQcGYlnneqAeFYMN6krytS/lnhuxFo8gSLMidjjGIbmEQ8q1xIVd1UjAqma6ucejatFhXRvWAIYo2gG8SRuCy7qgJLfF+pl1kL3xroSqd7E52JKxEOfbxkXnWVys3GjzvzkjfF0M/du00pNGWtMjGeSXfevQmeekMV+mycCGnXm0IgnG/FM4c4QE/XHbAyliNWNqnS1weWRmGrWoognrdYDj45QDcsjXHAY+wIZ39J3nHhmle8Mz1E9lSqbNcTDEwHofrkFi7D4vi6KeBw5U6FnzUE883myWgL5zBgr7KCsVhPHO+4o0T3BavouJjiZBFUD/c+xe/RmfRae3ubVvCFQIPg5PwqgIR43iJxYCXgtT+kXSTx0T271dechHjqPl/q+Q+MjS289rczAYMTjJR5ey+PEVroCi3/IF/PQxBTyBNGFrFYUiaVldHzEQ9fe9bhsv5RBPCRrzXdsI2MBIT/IuqGJH/HxCcmAVZ4MMBjxBI9MIMkIQc0ln+8uuDu1kJ+PsSPNcQilu7Qlm5KBuHh180Mt8QTidnsaZfHkIR68VpB3OeP4KuQKR7u9BiMet88FQSn/kuRhnEqolbnpIakzRcQDaBEusjk9wRbWKfisPUUGt+6uaYkHLQOBoOeFBZ6bePAoiyfQ3htJPBUKVk9LaXDfiXsNMbLfbkreybAxhBGPmnhowUwKynlFGbepkxt0ljJmVcG6qEm/1oigIwJoGQ1h8DnJruHZKBr/sxBhsKD3E3SpMKhNxW5ooV0USGeVlxCEiMcTWB0sgngoZvLSk1LXxKNcGUlbDshaDBWNRriCXGdq9rs8RjxRxEPneB4LAc2THrmXIn98yvsrfkQ8WlmjnkVwK0LGmpRdUxBPL91ns0mLt6QfAltIIcmYdjPt8GwE8ewSTrwvhAofDUY8EgHsFhRpRUrTJ3GXUO2NU3+zPzRGIp71lAUzG0rFU0VuTVERPOkLhKYRjzKOVFTl8gr0+wMrpTU/XRGSg5YaukG+95iVeOh5B4X7jhtTGEoHxU+q5GoNkCtWjTkDRkqMvxlTRTcpoxysWG53ZVDDv4/b6WmDwWAwGAwGg8FgMBgMBoPBYDAYDAaDwWAoGq8BJyItAqyX45QAAAAASUVORK5CYII=");
            this.pictureBox_Code.Location = new Point(19, 227);
            this.pictureBox_Code.Name = "pictureBox_Code";
            this.pictureBox_Code.Size = new Size(152, 66);
            this.pictureBox_Code.TabIndex = 6;
            this.pictureBox_Code.TabStop = false;
            this.pictureBox_Code.Click += new EventHandler(this.pictureBox_Code_Click);
            this.pictureBox_PhoneCode.Location = new Point(580, 189);
            this.pictureBox_PhoneCode.Name = "pictureBox_PhoneCode";
            this.pictureBox_PhoneCode.Size = new Size(286, 34);
            this.pictureBox_PhoneCode.TabIndex = 7;
            this.pictureBox_PhoneCode.TabStop = false;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(797, 654);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.comboBox_Stores);
            base.Controls.Add(this.checkBox_AutoVerify);
            base.Controls.Add(this.button_PhoneVerify);
            base.Controls.Add(this.checkBox_AutoCopy);
            base.Controls.Add(this.listView_Select);
            base.Controls.Add(this.button_Start_FW);
            base.Controls.Add(this.textBox_Delay_FW);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.checkBox_FreshWait);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.button_Paste);
            base.Controls.Add(this.label_TextR);
            base.Controls.Add(this.textBox_PhoneR);
            base.Controls.Add(this.button_Copy);
            base.Controls.Add(this.textBox_PhoneCode);
            base.Controls.Add(this.label_TextSend);
            base.Controls.Add(this.button_Login);
            base.Controls.Add(this.button_Refresh);
            base.Controls.Add(this.textBox_pCode);
            base.Controls.Add(this.pictureBox_Code);
            base.Controls.Add(this.pictureBox_PhoneCode);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox3);
            base.Name = "MainForm";
            this.Text = "Cracked By Jameshero";
            base.Shown += new EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((ISupportInitialize)this.pictureBox_Code).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        static MainForm()
        {
            Class2.e1eQOijzrvtg6();
            MainForm.m_p = "Hart1File";
            MainForm.m_sConfigPath = "ARConfig.xml";
            MainForm.m_ssPath = "NetTcp.dll";
            MainForm.m_sUserConfigPath = "UserConfig.xml";
            MainForm.m_sNodeReserve = "ReservInfo";
            MainForm.m_sUserMainNode = "UserConfig";
            MainForm.m_sNodeReserveAll = MainForm.m_sUserMainNode + "/" + MainForm.m_sNodeReserve;
            MainForm.m_UserConfigKeys = new string[]
			{
				"phone",
				"lname",
				"fname",
				"idtype",
				"idnum",
				"rtime",
				"rtimemax",
				"leasttime",
				"count",
				"email"
			};
            MainForm.m_URLSteps = null;
            MainForm.m_URLStepsPublic = new string[]
			{
				"https://reserve.cdn-apple.com/{0}/{1}_{0}/reserve/iPhone/availability.json",
				"https://reserve-{0}.apple.com/{1}/{2}_{1}/reserve/iPhone",
				"https://signin.apple.com/",
				"https://appleid.cdn-apple.com/",
				"https://reserve-{0}.apple.com/{1}/{2}_{1}/reserve/iPhone?execution={3}"
			};
            MainForm.m_URLLanguageJP = new string[]
			{
				"JP",
				"jp",
				"ja"
			};
            MainForm.m_URLLanguageCA = new string[]
			{
				"CA",
				"ca",
				"en"
			};
            MainForm.m_URLLanguageAU = new string[]
			{
				"AU",
				"au",
				"en"
			};
            MainForm.m_URLLanguageGB = new string[]
			{
				"GB",
				"gb",
				"en"
			};
            MainForm.m_URLLanguageHK = new string[]
			{
				"HK",
				"hk",
				"zh"
			};
            MainForm.m_URLLanguageCN = new string[]
			{
				"CN",
				"cn",
				"zh"
			};
            MainForm.m_URLLanguageDE = new string[]
			{
				"DE",
				"de",
				"de"
			};
            MainForm.fdbstr = "{\"U\":\"Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E)\",\"L\":\"zh-CN\",\"Z\":\"GMT+08:00\",\"V\":\"1.1\",\"F\":\"TF1;016;11;0;16518;6%2C1%2C7601%2C17514;6%2C1%2C7601%2C18222;;;;11%2C0%2C9600%2C16518;;;;;11%2C0%2C9600%2C16518;6%2C3%2C9600%2C16518;12%2C0%2C7601%2C18150;;11%2C0%2C9600%2C16518;6%2C1%2C7601%2C17514;;;Mozilla;Microsoft%20Internet%20Explorer;5.0%20%28compatible%3B%20MSIE%209.0%3B%20Windows%20NT%206.1%3B%20WOW64%3B%20Trident/7.0%3B%20SLCC2%3B%20.NET%20CLR%202.0.50727%3B%20.NET%20CLR%203.5.30729%3B%20.NET%20CLR%203.0.30729%3B%20Media%20Center%20PC%206.0%3B%20.NET4.0C%3B%20.NET4.0E%29;0;zh-CN;true;x86;true;Win32;zh-CN;Mozilla/5.0%20%28compatible%3B%20MSIE%209.0%3B%20Windows%20NT%206.1%3B%20WOW64%3B%20Trident/7.0%3B%20SLCC2%3B%20.NET%20CLR%202.0.50727%3B%20.NET%20CLR%203.5.30729%3B%20.NET%20CLR%203.0.30729%3B%20Media%20Center%20PC%206.0%3B%20.NET4.0C%3B%20.NET4.0E%29;zh-CN;gb2312;signin.apple.com;96;96;true;0;false;false;1411461856183;8;2005%u5E746%u67087%u65E5%2021%3A33%3A44;1680;1050;;WIN%2013%2C0%2C0%2C199;;;;;14;-480;-480;2014%u5E749%u670823%u65E5%2016%3A44%3A16;24;1680;1010;undefined;undefined;;;;;;;;;;;;;;;;;;;18;;;;;;;\"}";
            MainForm.m_APPID = "942";
            MainForm.m_sIDTypes = new string[]
			{
				"香港身份证",
				"香港回乡证",
				"港澳通行证",
				"澳门证",
				"大陆身份证",
				"护照",
                "中华人民共和国居民身份证",

			};
            MainForm.m_sIDTypesStr = new string[]
			{
				"idHongkong",
				"homeReturnCard",
				"travelPermitHKMacauTaiwan",
				"entryExitPass",
				"prcId",
				"passport",
                "idCardChina"
			};
        }
    }
}
