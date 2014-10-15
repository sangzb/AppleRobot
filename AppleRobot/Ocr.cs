using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using asprise_ocr_api;
using AppleRobot.Properties;
namespace AppleRobot
{
    public class Ocr
    {

        
        private AspriseOCR ocr;
        private String currentLang;
        public void asprise_init()
        {
            bool browsed = false;
            int count = 0;

            string dllFilePath = AspriseOCR.getOcrDllPath();
            if (dllFilePath == null)
            {
                string parentFolder = AspriseOCR.detectOcrDllInParentFolders();
                //string parentFolder = @"C:\Users\Administrator\Desktop\asprise-ocr-csharp-vb.net-5.01\sample-projects";
                if (parentFolder != null)
                {
                    AspriseOCR.addToSystemPath(parentFolder);
                    //log("Folder containing ocr dll detected: " + parentFolder);
                }
            }

            String lang = null;
            if (lang == null || lang.Length == 0)
            {
                currentLang = "eng";
            }

            // Let user browse the ocr dll if it is not found in PATH.
            while (true)
            {
                dllFilePath = AspriseOCR.getOcrDllPath();
                if (dllFilePath != null)
                {
                    try
                    {
                        AspriseOCR.SetUp();
                        ocr = new AspriseOCR();

                        ocr.StartEngine("eng", AspriseOCR.SPEED_FASTEST);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    break;
                }
                else {
                    MessageBox.Show("error");
                    break;
                }
            }
        }

        private Thread threadOcr;
        public void buttonOcr_Click()
        {
            if (threadOcr != null && threadOcr.IsAlive)
            {
                MessageBox.Show("OCR in progress, please wait ...", "Info");
                return;
            }

            threadOcr = new Thread(this.doOcr);
            threadOcr.SetApartmentState(System.Threading.ApartmentState.STA);  
            threadOcr.Start();
        }

        void doOcr()
        {
            string recognizeType = AspriseOCR.RECOGNIZE_TYPE_ALL;

            string outputFormat = AspriseOCR.OUTPUT_FORMAT_PLAINTEXT;

            Dictionary<string, string> dict = new Dictionary<string, string>();

            DateTime timeStart = DateTime.Now;
            // Performs the actual recognition
            string s = ocr.Recognize("checkcode.png", -1, -1, -1, -1, -1, recognizeType, outputFormat, dict);
            Clipboard.SetText(s);
            DateTime timeEnd = DateTime.Now;
        }

    }
}
