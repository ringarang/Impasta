using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using Memory;

namespace Cheat
{
    public partial class Impasta : Form
    {
        Mem Memory = new Mem();
        static float OldSpeed;

        public Impasta()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void CheatOutput(string message)
        {
            Output_Box.Text = message;
        }

        private void Impasta_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                CheatOutput("Waiting for Among Us to open!");
                while (!Memory.OpenProcess("Among Us")){}
                CheatOutput("Got among us! Enjoy! - <3 from ringarang");

                while (true)
                {
                    Thread.Sleep(100);
                    Role_Information.Text = RoleFetcher.FetchRoles(Memory);
                }
            }).Start();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Cheats Begin*/

        private void Cheat_UnlockCosmetics_Click(object sender, EventArgs e)
        {
            Memory.WriteBytes(Offsets.AmongUs_CosmeticsManager, Offsets.AmongUs_CosmeticsManager_Patch);
            CheatOutput("Unlocked all cosmetics! Will reset when you close the game!");
        }

        private void Cheat_Noclip_CheckedChanged(object sender)
        {
            if (Cheat_Noclip.Checked)
            {
                Memory.WriteMemory(Offsets.AmongUs_NoClipFlag, "int", "0"); //0 for noclip
                CheatOutput("Noclip Enabled!");
            }
            else
            {
                Memory.WriteMemory(Offsets.AmongUs_NoClipFlag, "int", "257"); //257 for clip
                CheatOutput("Noclip Disabled!");
            }
        }

        private void Cheat_Ghost_CheckedChanged(object sender)
        {
            if (!Cheat_Ghost.Checked) //flipped because of toggle
            {
                Memory.WriteMemory(Offsets.AmongUs_GhostFlag, "int", "0"); //0 for dead
                CheatOutput("Ghost Disabled!");
            }
            else
            {
                Memory.WriteMemory(Offsets.AmongUs_GhostFlag, "int", "1"); //1 for alive
                CheatOutput("Ghost Enabled!");
            }
        }

        private void Cheat_Xray_CheckedChanged(object sender)
        {
            CheatOutput("Not implemented yet. Sorry!");
            Cheat_Xray.Checked = false;
        }

        private void Cheat_SuperSpeed_CheckedChanged(object sender)
        {
            if (Cheat_SuperSpeed.Checked)
            {
                OldSpeed = Memory.ReadFloat(Offsets.AmongUs_SpeedFloat);
                Memory.WriteMemory(Offsets.AmongUs_SpeedFloat, "float", "5"); //5 for max speed
                CheatOutput("Super speed enabled!");
            }
            else
            {
                Memory.WriteMemory(Offsets.AmongUs_SpeedFloat, "float", OldSpeed.ToString()); //restore old speed
                CheatOutput("Super speed disabled!");
            }
        }

        private void Cheat_DbgMode_CheckedChanged(object sender)
        {
            CheatOutput("Not implemented yet. Sorry!");
            Cheat_Xray.Checked = false;
        }
    }
}
