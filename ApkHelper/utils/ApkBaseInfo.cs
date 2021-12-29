using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkHelper
{
    internal class ApkBaseInfo
    {
        public String PackageName { get; set; }
        public String VersionName { get; set; }
        public String VersionCode { get; set; }
        public String MinSDKVerison { get; set; }
        public String Md5 { get; set; }
        public String FileSize { get; set; }

    }
}
