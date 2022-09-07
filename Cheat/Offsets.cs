using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheat
{
    public static class Offsets
    {
        /*Offsets*/
        //For steam version v2022.8.24

        public static string AmongUs_LocalPlayerControl = "GameAssembly.dll+01F88BBC,5C,0";
        public static string AmongUs_AllPlayerControls = "GameAssembly.dll+01F5B0E0,5C,28";

        public static string AmongUs_CosmeticsManager = "GameAssembly.dll+8E267B";
        public static byte[] AmongUs_CosmeticsManager_Patch = new byte[] { 144, 144 };

        public static string AmongUs_NoClipFlag = AmongUs_LocalPlayerControl + ",70,8,20";
        public static string AmongUs_GhostFlag = AmongUs_LocalPlayerControl + ",48,2C";

        public static string AmongUs_SpeedFloat = AmongUs_LocalPlayerControl + ",74,30";

    }
}
