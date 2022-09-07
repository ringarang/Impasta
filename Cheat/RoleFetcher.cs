using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Memory;

namespace Cheat
{
    public static class RoleFetcher
    {
        public static string EnumToRoleString(int Index)
        {
            string Return;
            switch (Index)
            {
                case 1:
                    Return = "Imposter";
                    break;
                case 2:
                    Return = "Scientist";
                    break;
                case 3:
                    Return = "Engineer";
                    break;
                case 4:
                    Return = "Guardian Angel";
                    break;
                case 5:
                    Return = "Shapeshifter";
                    break;
                default:
                    Return = ""; //should never happen
                    break;
            }

            return Return;
        }

        public static string FetchRoles(Mem Instance)
        {
            //Could make this a lot cleaner.
            StringBuilder RoleInformationString = new StringBuilder();
            int PlayerArraySize = Instance.ReadInt(Offsets.AmongUs_AllPlayerControls + ",0C");
            for (int Index = 0; Index < PlayerArraySize; Index++) 
            { 
                string CurrentPlayerControl = Offsets.AmongUs_AllPlayerControls + ",8," + (16 + Index * 4).ToString("X");
                int CurrentPlayerRoleId = Instance.ReadInt(CurrentPlayerControl + ",48,14");
                string CurrentPlayerUsername = CurrentPlayerRoleId > 0 ? Instance.ReadString(CurrentPlayerControl + ",3C,1C,80,0C", "", 32, true, Encoding.Unicode) : "";
                string CurrentPlayerRole = CurrentPlayerRoleId > 0 ? EnumToRoleString(CurrentPlayerRoleId) : "";
                //0 = crewmate, we dont record crewmates.
                if(CurrentPlayerRoleId != 0) 
                {
                    RoleInformationString.Append(CurrentPlayerUsername + " => " + CurrentPlayerRole + "\r\n");
                }
            }
            return String.IsNullOrWhiteSpace(RoleInformationString.ToString()) ? "In Lobby!\r\nRole information will appear once game starts!\r\nRemember! Only non-crewmate roles are listed!" : RoleInformationString.ToString();
        }
    }
}
