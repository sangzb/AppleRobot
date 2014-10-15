using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
namespace AppleRobot
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
    public class Resource1
    {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(Resource1.resourceMan, null))
                {
                    ResourceManager resourceManager = new ResourceManager("AppleRobot.Resource1", typeof(Resource1).Assembly);
                    Resource1.resourceMan = resourceManager;
                }
                return Resource1.resourceMan;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture
        {
            get
            {
                return Resource1.resourceCulture;
            }
            set
            {
                Resource1.resourceCulture = value;
            }
        }
        public static UnmanagedMemoryStream money
        {
            get
            {
                return Resource1.ResourceManager.GetStream("money", Resource1.resourceCulture);
            }
        }
        public static Bitmap pic_pCodeDefault
        {
            get
            {
                object @object = Resource1.ResourceManager.GetObject("pic_pCodeDefault", Resource1.resourceCulture);
                return (Bitmap)@object;
            }
        }
        public static UnmanagedMemoryStream warning2
        {
            get
            {
                return Resource1.ResourceManager.GetStream("warning2", Resource1.resourceCulture);
            }
        }
        internal Resource1()
        {
            Class2.e1eQOijzrvtg6();
        }
    }
}
