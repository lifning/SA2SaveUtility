﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SA2SaveUtility
{
    public partial class uc_Chao : UserControl
    {
        public uint chaoNumber { get; set; }
        public uint chaoBeginning { get; set; }

        public bool firstLoad { get; set; }

        Offsets offsets = new Offsets();

        public uc_Chao()
        {
            if (!Main.isSA && Main.isRTE) { chaoBeginning = 0; }
            if (Main.isSA && !Main.isRTE) { chaoBeginning = 0x818; }
            if (!Main.isSA && !Main.isRTE) { chaoBeginning = 0x3AA4; }
            firstLoad = true;
            InitializeComponent();
        }

        private void Tb_Name_TextChanged(object sender, EventArgs e)
        {
            if (!tb_Name.Focused) return;

            byte[] name = ChaoSave.SetName(tb_Name.Text);

            for (int i = 0; i < name.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Name + i)] = name[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Name + i), name[i]); }
            }
        }

        private void Nud_SwimLevel_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SwimLevel)] = (byte)nud_SwimLevel.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SwimLevel), (byte)nud_SwimLevel.Value); }
        }

        private void Nud_FlyLevel_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.FlyLevel)] = (byte)nud_FlyLevel.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.FlyLevel), (byte)nud_FlyLevel.Value); }
        }

        private void Nud_RunLevel_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.RunLevel)] = (byte)nud_RunLevel.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.RunLevel), (byte)nud_RunLevel.Value); }
        }

        private void Nud_PowerLevel_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.PowerLevel)] = (byte)nud_PowerLevel.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.PowerLevel), (byte)nud_PowerLevel.Value); }
        }

        private void Nud_StaminaLevel_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.StaminaLevel)] = (byte)nud_StaminaLevel.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.StaminaLevel), (byte)nud_StaminaLevel.Value); }
        }

        private void Nud_LuckLevel_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.LuckLevel)] = (byte)nud_LuckLevel.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.LuckLevel), (byte)nud_LuckLevel.Value); }
        }

        private void Nud_IntelligenceLevel_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.IntelligenceLevel)] = (byte)nud_IntelligenceLevel.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.IntelligenceLevel), (byte)nud_IntelligenceLevel.Value); }
        }

        private void Nud_SwimBar_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SwimBar)] = (byte)nud_SwimBar.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SwimBar), (byte)nud_SwimBar.Value); }
        }

        private void Nud_FlyBar_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.FlyBar)] = (byte)nud_FlyBar.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.FlyBar), (byte)nud_FlyBar.Value); }
        }

        private void Nud_RunBar_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.RunBar)] = (byte)nud_RunBar.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.RunBar), (byte)nud_RunBar.Value); }
        }

        private void Nud_PowerBar_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.PowerBar)] = (byte)nud_PowerBar.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.PowerBar), (byte)nud_PowerBar.Value); }
        }

        private void Nud_StaminaBar_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.StaminaBar)] = (byte)nud_StaminaBar.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.StaminaBar), (byte)nud_StaminaBar.Value); }
        }

        private void Nud_LuckBar_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.LuckBar)] = (byte)nud_LuckBar.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.LuckBar), (byte)nud_LuckBar.Value); }
        }

        private void Nud_IntelligenceBar_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.IntelligenceBar)] = (byte)nud_IntelligenceBar.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.IntelligenceBar), (byte)nud_IntelligenceBar.Value); }
        }

        private void Nud_SwimStat_ValueChanged(object sender, EventArgs e)
        {
            byte[] stat = BitConverter.GetBytes((UInt16)nud_SwimStat.Value);
            if (!Main.isPC) { Array.Reverse(stat); }
            for (int i = 0; i < stat.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SwimPoints + i)] = stat[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SwimPoints + i), stat[i]); }
            }
        }

        private void Nud_FlyStat_ValueChanged(object sender, EventArgs e)
        {
            byte[] stat = BitConverter.GetBytes((UInt16)nud_FlyStat.Value);
            if (!Main.isPC) { Array.Reverse(stat); }
            for (int i = 0; i < stat.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.FlyPoints + i)] = stat[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.FlyPoints + i), stat[i]); }
            }
        }

        private void Nud_RunStat_ValueChanged(object sender, EventArgs e)
        {
            byte[] stat = BitConverter.GetBytes((UInt16)nud_RunStat.Value);
            if (!Main.isPC) { Array.Reverse(stat); }
            for (int i = 0; i < stat.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.RunPoints + i)] = stat[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.RunPoints + i), stat[i]); }
            }
        }

        private void Nud_PowerStat_ValueChanged(object sender, EventArgs e)
        {
            byte[] stat = BitConverter.GetBytes((UInt16)nud_PowerStat.Value);
            if (!Main.isPC) { Array.Reverse(stat); }
            for (int i = 0; i < stat.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.PowerPoints + i)] = stat[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.PowerPoints + i), stat[i]); }
            }
        }

        private void Nud_StaminaStat_ValueChanged(object sender, EventArgs e)
        {
            byte[] stat = BitConverter.GetBytes((UInt16)nud_StaminaStat.Value);
            if (!Main.isPC) { Array.Reverse(stat); }
            for (int i = 0; i < stat.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.StaminaPoints + i)] = stat[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.StaminaPoints + i), stat[i]); }
            }
        }

        private void Nud_LuckStat_ValueChanged(object sender, EventArgs e)
        {
            byte[] stat = BitConverter.GetBytes((UInt16)nud_LuckStat.Value);
            if (!Main.isPC) { Array.Reverse(stat); }
            for (int i = 0; i < stat.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.LuckPoints + i)] = stat[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.LuckPoints + i), stat[i]); }
            }
        }

        private void Nud_IntelligenceStat_ValueChanged(object sender, EventArgs e)
        {
            byte[] stat = BitConverter.GetBytes((UInt16)nud_IntelligenceStat.Value);
            if (!Main.isPC) { Array.Reverse(stat); }
            for (int i = 0; i < stat.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.IntelligencePoints + i)] = stat[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.IntelligencePoints + i), stat[i]); }
            }
        }

        private void Cb_SwimGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SwimGrade)] = (byte)cb_SwimGrade.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SwimGrade), (byte)cb_SwimGrade.SelectedIndex); }
        }

        private void Cb_FlyGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.FlyGrade)] = (byte)cb_FlyGrade.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.FlyGrade), (byte)cb_FlyGrade.SelectedIndex); }
        }

        private void Cb_RunGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grade = cb_RunGrade.SelectedIndex;
            if (grade == 6) { grade = 7; }
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.RunGrade)] = (byte)grade; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.RunGrade), (byte)grade); }
        }

        private void Cb_PowerGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.PowerGrade)] = (byte)cb_PowerGrade.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.PowerGrade), (byte)cb_PowerGrade.SelectedIndex); }
        }

        private void Cb_StaminaGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.StaminaGrade)] = (byte)cb_StaminaGrade.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.StaminaGrade), (byte)cb_StaminaGrade.SelectedIndex); }
        }

        private void Cb_Garden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Garden)] = (byte)(cb_Garden.SelectedIndex + 1); }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Garden), (byte)(cb_Garden.SelectedIndex + 1)); }
        }

        private void Cb_Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Colour.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.chaoColours.Where(x => x.Key == cb_Colour.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Colour)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Colour), (byte)(flag)); }
            }
        }

        private void Cb_Texture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Texture)] = (byte)cb_Texture.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Texture), (byte)cb_Texture.SelectedIndex); }
        }

        private void Cb_BodyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.BodyType)] = (byte)cb_BodyType.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.BodyType), (byte)cb_BodyType.SelectedIndex); }
        }

        private void Checkb_Shiny_CheckedChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Shiny)] = (byte)(Convert.ToUInt32(checkb_Shiny.Checked)); }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Shiny), (byte)(Convert.ToUInt32(checkb_Shiny.Checked))); }
        }

        private void Checkb_MonoTone_CheckedChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.MonoTone)] = (byte)(Convert.ToUInt32(checkb_MonoTone.Checked)); }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.MonoTone), (byte)(Convert.ToUInt32(checkb_MonoTone.Checked))); }
        }

        private void Cb_Hat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Hat)] = (byte)cb_Hat.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Hat), (byte)cb_Hat.SelectedIndex); }
        }

        private void Cb_ChaoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chaoType = cb_ChaoType.SelectedIndex;
            if (cb_ChaoType.SelectedIndex == 0 || cb_ChaoType.SelectedIndex == 1) { chaoType = cb_ChaoType.SelectedIndex + 1; }
            if (cb_ChaoType.SelectedIndex > 1) { chaoType = cb_ChaoType.SelectedIndex + 3; }
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.ChaoType)] = (byte)(chaoType); }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.ChaoType), (byte)(chaoType)); }
        }

        private void Trackb_Alignment_Scroll(object sender, EventArgs e)
        {   
            float alignment = (float)(trackb_Alignment.Value * 0.0000001);
            byte[] alignmentBytes = BitConverter.GetBytes(alignment);
            lb_currentAlignment.Text = alignment.ToString();
            if (!Main.isPC) { Array.Reverse(alignmentBytes); }
            for (int i = 0; i < alignmentBytes.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Alignment + i)] = alignmentBytes[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Alignment + i), alignmentBytes[i]); }
            }
        }

        private void Trackb_Run2Power_Scroll(object sender, EventArgs e)
        {
            float run2Power = (float)(trackb_Run2Power.Value * 0.0000001);
            byte[] run2PowerBytes = BitConverter.GetBytes(run2Power);
            lb_currentRun2Power.Text = run2Power.ToString();
            if (!Main.isPC) { Array.Reverse(run2PowerBytes); }
            for (int i = 0; i < run2PowerBytes.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Run2PowerTranformation + i)] = run2PowerBytes[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Run2PowerTranformation + i), run2PowerBytes[i]); }
            }
        }

        private void Trackb_Swim2Fly_Scroll(object sender, EventArgs e)
        {
            float swim2Fly = (float)(trackb_Swim2Fly.Value * 0.0000001);
            byte[] swim2FlyBytes = BitConverter.GetBytes(swim2Fly);
            lb_currentSwim2Fly.Text = swim2Fly.ToString();
            if (!Main.isPC) { Array.Reverse(swim2FlyBytes); }
            for (int i = 0; i < swim2FlyBytes.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Swim2FlyTransformation + i)] = swim2FlyBytes[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Swim2FlyTransformation + i), swim2FlyBytes[i]); }
            }
        }

        private void Trackb_TransformationMagnitude_Scroll(object sender, EventArgs e)
        {
            float transformationMagnitude = (float)(trackb_TransformationMagnitude.Value * 0.0000001);
            byte[] transformationMagnitudeBytes = BitConverter.GetBytes(transformationMagnitude);
            lb_currentMagnitude.Text = transformationMagnitude.ToString();
            if (!Main.isPC) { Array.Reverse(transformationMagnitudeBytes); }
            for (int i = 0; i < transformationMagnitudeBytes.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.TransformationMagnitude + i)] = transformationMagnitudeBytes[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.TransformationMagnitude + i), transformationMagnitudeBytes[i]); }
            }
        }

        private void Cb_Medal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Medal)] = (byte)cb_Medal.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Medal), (byte)cb_Medal.SelectedIndex); }
        }

        private void Cb_BodyTypeAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.BodyTypeAnimal)] = (byte)cb_BodyTypeAnimal.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.BodyTypeAnimal), (byte)cb_BodyTypeAnimal.SelectedIndex); }
        }

        private void Cb_Eyes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Eyes)] = (byte)cb_Eyes.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Eyes), (byte)cb_Eyes.SelectedIndex); }
        }

        private void Cb_Emotiball_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Emotiball)] = (byte)cb_Emotiball.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Emotiball), (byte)cb_Emotiball.SelectedIndex); }
        }

        private void Cb_Mouth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Mouth)] = (byte)cb_Mouth.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Mouth), (byte)cb_Mouth.SelectedIndex); }
        }

        private void Checkb_FeetHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.HiddenFeet)] = (byte)(Convert.ToUInt32(checkb_FeetHidden.Checked)); }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.HiddenFeet), (byte)(Convert.ToUInt32(checkb_FeetHidden.Checked))); }
        }

        private void Cb_ArmsPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ArmsPart.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.animalParts.Where(x => x.Key == cb_ArmsPart.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2ArmsPart)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2ArmsPart), (byte)(flag)); }
            }
        }

        private void Cb_EarsPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_EarsPart.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.animalParts.Where(x => x.Key == cb_EarsPart.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2EarsPart)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2EarsPart), (byte)(flag)); }
            }
        }

        private void Cb_ForeheadPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ForeheadPart.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.animalParts.Where(x => x.Key == cb_ForeheadPart.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2ForeheadPart)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2ForeheadPart), (byte)(flag)); }
            }
        }

        private void Cb_HornsPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_HornsPart.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.animalParts.Where(x => x.Key == cb_HornsPart.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2HornsPart)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2HornsPart), (byte)(flag)); }
            }
        }

        private void Cb_LegsPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_LegsPart.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.animalParts.Where(x => x.Key == cb_LegsPart.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2LegsPart)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2LegsPart), (byte)(flag)); }
            }
        }

        private void Cb_TailPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TailPart.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.animalParts.Where(x => x.Key == cb_TailPart.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2TailPart)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2TailPart), (byte)(flag)); }
            }
        }

        private void Cb_WingsPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_WingsPart.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.animalParts.Where(x => x.Key == cb_WingsPart.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2WingsPart)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2WingsPart), (byte)(flag)); }
            }
        }

        private void Cb_FacePart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FacePart.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.animalParts.Where(x => x.Key == cb_FacePart.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2FacePart)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2FacePart), (byte)(flag)); }
            }
        }

        private void Cb_EggColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.EggColour)] = (byte)cb_EggColour.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.EggColour), (byte)cb_EggColour.SelectedIndex); }
        }

        private void Nud_Happiness_ValueChanged(object sender, EventArgs e)
        {
            byte[] happiness = BitConverter.GetBytes((Int16)nud_Happiness.Value);
            if (!Main.isPC) { Array.Reverse(happiness); }
            for (int i = 0; i < happiness.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Happiness + i)] = happiness[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Happiness + i), happiness[i]); }
            }
        }

        private void Btn_DupeChao_Click(object sender, EventArgs e)
        {
            byte[] chaoToDupe = Main.loadedSave.Skip((int)(chaoBeginning + (0x800 * chaoNumber))).Take(0x800).ToArray();
            byte[] array = Main.loadedSave.Skip(0x3AA4).Take(0xC000).ToArray();
            uint chaoIndex = 0;
            foreach (byte[] chao in Main.SplitByteArray(array, 0x800))
            {
                if ((chao[offsets.chao.Garden] == 0 || chao[offsets.chao.Garden] == 255) && chaoIndex != 24)
                {
                    List<byte> byteArray = new List<byte>();
                    byteArray.AddRange(Main.loadedSave.Take((int)(chaoBeginning + (0x800 * chaoIndex))).ToArray());
                    byteArray.AddRange(chaoToDupe);
                    byteArray.AddRange(Main.loadedSave.Skip((int)(chaoBeginning + (0x800 * (chaoIndex + 1)))).ToArray());
                    Main.loadedSave = byteArray.ToArray();
                    MessageBox.Show("Chao has been duped into slot " + (chaoIndex + 1) + ".", "Chao duped", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ChaoSave.GetChao();
                    break;
                }
                else if (chaoIndex == 24)
                {
                    MessageBox.Show("Failed to find a slot for the chao, you'll have to make room.", "Error duping chao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                chaoIndex++;
            }
        }

        private void Trackb_DesireToMate_Scroll(object sender, EventArgs e)
        {
            byte[] desire = BitConverter.GetBytes((UInt16)trackb_DesireToMate.Value);
            if (!Main.isPC) { Array.Reverse(desire); }
            for (int i = 0; i < desire.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DesireToMate + i)] = desire[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DesireToMate + i), desire[i]); }
            }
        }

        private void Trackb_Hunger_Scroll(object sender, EventArgs e)
        {
            byte[] hunger = BitConverter.GetBytes((UInt16)trackb_Hunger.Value);
            if (!Main.isPC) { Array.Reverse(hunger); }
            for (int i = 0; i < hunger.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Hunger + i)] = hunger[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Hunger + i), hunger[i]); }
            }
        }

        private void Trackb_Sleepiness_Scroll(object sender, EventArgs e)
        {
            byte[] sleepiness = BitConverter.GetBytes((UInt16)trackb_Sleepiness.Value);
            if (!Main.isPC) { Array.Reverse(sleepiness); }
            for (int i = 0; i < sleepiness.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Sleepiness + i)] = sleepiness[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Sleepiness + i), sleepiness[i]); }
            }
        }

        private void Trackb_Tiredness_Scroll(object sender, EventArgs e)
        {
            byte[] tiredness = BitConverter.GetBytes((UInt16)trackb_Tiredness.Value);
            if (!Main.isPC) { Array.Reverse(tiredness); }
            for (int i = 0; i < tiredness.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Tiredness + i)] = tiredness[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Tiredness + i), tiredness[i]); }
            }
        }

        private void Trackb_Boredom_Scroll(object sender, EventArgs e)
        {
            byte[] boredom = BitConverter.GetBytes((UInt16)trackb_Boredom.Value);
            if (!Main.isPC) { Array.Reverse(boredom); }
            for (int i = 0; i < boredom.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Boredom + i)] = boredom[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Boredom + i), boredom[i]); }
            }
        }

        private void Trackb_Energy_Scroll(object sender, EventArgs e)
        {
            byte[] energy = BitConverter.GetBytes((UInt16)trackb_Energy.Value);
            if (!Main.isPC) { Array.Reverse(energy); }
            for (int i = 0; i < energy.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Energy + i)] = energy[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Energy + i), energy[i]); }
            }
        }

        private void Trackb_Joy_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Joy)] = (byte)trackb_Joy.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Joy), (byte)trackb_Joy.Value); }
        }

        private void Trackb_UrgeToCry_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.UrgeToCry)] = (byte)trackb_UrgeToCry.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.UrgeToCry), (byte)trackb_UrgeToCry.Value); }
        }

        private void Trackb_Fear_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Fear)] = (byte)trackb_Fear.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Fear), (byte)trackb_Fear.Value); }
        }

        private void Trackb_Dizziness_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Dizziness)] = (byte)trackb_Dizziness.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Dizziness), (byte)trackb_Dizziness.Value); }
        }

        private void Trackb_SonicBond_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2SonicBond)] = (byte)trackb_SonicBond.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2SonicBond), (byte)trackb_SonicBond.Value); }
        }

        private void Trackb_TailsBond_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2TailsBond)] = (byte)trackb_TailsBond.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2TailsBond), (byte)trackb_TailsBond.Value); }
        }
        private void Trackb_KnucklesBond_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2KnucklesBond)] = (byte)trackb_KnucklesBond.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2KnucklesBond), (byte)trackb_KnucklesBond.Value); }
        }

        private void Trackb_ShadowBond_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2ShadowBond)] = (byte)trackb_ShadowBond.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2ShadowBond), (byte)trackb_ShadowBond.Value); }
        }

        private void Trackb_EggmanBond_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2EggmanBond)] = (byte)trackb_EggmanBond.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2EggmanBond), (byte)trackb_EggmanBond.Value); }
        }

        private void Trackb_RougeBond_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2RougeBond)] = (byte)trackb_RougeBond.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2RougeBond), (byte)trackb_RougeBond.Value); }
        }

        private void Btn_ResetChao_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will completely reset the chao, I recommend you save your chao first!" + Environment.NewLine + "Are you sure you want to reset your chao?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.ResetTrigger)] = (byte)0; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.ResetTrigger), (byte)0); }
            }
        }

        private void Trackb_Lifespan1_Scroll(object sender, EventArgs e)
        {
            byte[] lifespan = BitConverter.GetBytes((Int16)trackb_Lifespan1.Value);
            lb_currentLifespan1.Text = trackb_Lifespan1.Value.ToString();
            if (!Main.isPC) { Array.Reverse(lifespan); }
            for (int i = 0; i < lifespan.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Lifespan1 + i)] = lifespan[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Lifespan1 + i), lifespan[i]); }
            }
            if (trackb_Lifespan1.Value > trackb_Lifespan2.Value)
            {
                trackb_Lifespan2.Value = trackb_Lifespan1.Value;
                for (int i = 0; i < lifespan.Length; i++)
                {
                    if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Lifespan2 + i)] = lifespan[i]; }
                    else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Lifespan2 + i), lifespan[i]); }
                }
            }
        }

        private void Trackb_Lifespan2_Scroll(object sender, EventArgs e)
        {
            byte[] lifespan = BitConverter.GetBytes((Int16)trackb_Lifespan2.Value);
            lb_currentLifespan2.Text = trackb_Lifespan2.Value.ToString();
            if (!Main.isPC) { Array.Reverse(lifespan); }
            for (int i = 0; i < lifespan.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Lifespan2 + i)] = lifespan[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Lifespan2 + i), lifespan[i]); }
            }
        }

        private void Nud_Reincarnations_ValueChanged(object sender, EventArgs e)
        {
            byte[] reincarnations = BitConverter.GetBytes((UInt16)nud_Reincarnations.Value);
            if (!Main.isPC) { Array.Reverse(reincarnations); }
            for (int i = 0; i < reincarnations.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Reincarnations + i)] = reincarnations[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Reincarnations + i), reincarnations[i]); }
            }
        }

        private void SetSAAnimalBehaviours()
        {
            uint animalBehaviours = 0x00;
            if (checkb_SASeal.Checked) { animalBehaviours += 0x01; }
            if (checkb_SAPenguin.Checked) { animalBehaviours += (1 << 1); }
            if (checkb_SAOtter.Checked) { animalBehaviours += (1 << 2); }
            if (checkb_SAPeacock.Checked) { animalBehaviours += (1 << 3); }
            if (checkb_SASwallow.Checked) { animalBehaviours += (1 << 4); }
            if (checkb_SAParrot.Checked) { animalBehaviours += (1 << 5); }
            if (checkb_SADeer.Checked) { animalBehaviours += (1 << 6); }
            if (checkb_SARabbit.Checked) { animalBehaviours += (1 << 7); }
            if (checkb_SAKangaroo.Checked) { animalBehaviours += (1 << 8); }
            if (checkb_SAGorilla.Checked) { animalBehaviours += (1 << 9); }
            if (checkb_SALion.Checked) { animalBehaviours += (1 << 10); }
            if (checkb_SAElephant.Checked) { animalBehaviours += (1 << 11); }
            if (checkb_SAMole.Checked) { animalBehaviours += (1 << 12); }
            if (checkb_SAKoala.Checked) { animalBehaviours += (1 << 13); }
            if (checkb_SASkunk.Checked) { animalBehaviours += (1 << 14); }

            byte[] animalBehavioursBytes = BitConverter.GetBytes((UInt32)animalBehaviours);
            if (!Main.isPC) { Array.Reverse(animalBehavioursBytes); }
            for (int i = 0; i < animalBehavioursBytes.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SAAnimalBehaviours + i)] = animalBehavioursBytes[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SAAnimalBehaviours + i), animalBehavioursBytes[i]); }
            }
        }

        private void SetAnimalBehaviours()
        {
            uint animalBehaviours = 0x00;

            if (checkb_Penguin.Checked) { animalBehaviours += 0x01; }
            if (checkb_Seal.Checked) { animalBehaviours += (1 << 1); }
            if (checkb_Otter.Checked) { animalBehaviours += (1 << 2); }
            if (checkb_Rabbit.Checked) { animalBehaviours += (1 << 3); }
            if (checkb_Cheetah.Checked) { animalBehaviours += (1 << 4); }
            if (checkb_Warthog.Checked) { animalBehaviours += (1 << 5); }
            if (checkb_Bear.Checked) { animalBehaviours += (1 << 6); }
            if (checkb_Tiger.Checked) { animalBehaviours += (1 << 7); }
            if (checkb_Gorilla.Checked) { animalBehaviours += (1 << 8); }
            if (checkb_Peacock.Checked) { animalBehaviours += (1 << 9); }
            if (checkb_Parrot.Checked) { animalBehaviours += (1 << 10); }
            if (checkb_Condor.Checked) { animalBehaviours += (1 << 11); }
            if (checkb_Skunk.Checked) { animalBehaviours += (1 << 12); }
            if (checkb_Sheep.Checked) { animalBehaviours += (1 << 13); }
            if (checkb_Raccoon.Checked) { animalBehaviours += (1 << 14); }
            if (checkb_HalfFish.Checked) { animalBehaviours += (1 << 15); }
            if (checkb_SkeletonDog.Checked) { animalBehaviours += (1 << 16); }
            if (checkb_Bat.Checked) { animalBehaviours += (1 << 17); }
            if (checkb_Dragon.Checked) { animalBehaviours += (1 << 18); }
            if (checkb_Unicorn.Checked) { animalBehaviours += (1 << 19); }
            if (checkb_Phoenix.Checked) { animalBehaviours += (1 << 20); }

            byte[] animalBehavioursBytes = BitConverter.GetBytes((UInt32)animalBehaviours);
            if (!Main.isPC) { Array.Reverse(animalBehavioursBytes); }
            for (int i = 0; i < animalBehavioursBytes.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2AnimalBehaviours + i)] = animalBehavioursBytes[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2AnimalBehaviours + i), animalBehavioursBytes[i]); }
            }
        }

        private void SetToys()
        {
            uint toys = 0x00;

            if (checkb_Rattle.Checked) { toys += 0x01; }
            if (checkb_Car.Checked) { toys += (1 << 1); }
            if (checkb_PictureBook.Checked) { toys += (1 << 2); }
            if (checkb_SonicDoll.Checked) { toys += (1 << 4); }
            if (checkb_Broomstick.Checked) { toys += (1 << 5); }
            if (checkb_Glitch.Checked) { toys += (1 << 6); }
            if (checkb_PogoStick.Checked) { toys += (1 << 7); }
            if (checkb_Crayons.Checked) { toys += (1 << 8); }
            if (checkb_BubbleWand.Checked) { toys += (1 << 9); }
            if (checkb_Shovel.Checked) { toys += (1 << 10); }
            if (checkb_WateringCan.Checked) { toys += (1 << 11); }

            byte[] toysBytes = BitConverter.GetBytes((UInt32)toys);
            if (!Main.isPC) { Array.Reverse(toysBytes); }
            for (int i = 0; i < toysBytes.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2Toys + i)] = toysBytes[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2Toys + i), toysBytes[i]); }
            }
        }

        private void SetClassroomSkills()
        {
            int classroomSkills = 0x00;

            if (checkb_Drawing1.Checked) { classroomSkills += 0x01; }
            if (checkb_Drawing2.Checked) { classroomSkills += (1 << 1); }
            if (checkb_Drawing3.Checked) { classroomSkills += (1 << 2); }
            if (checkb_Drawing4.Checked) { classroomSkills += (1 << 3); }
            if (checkb_Drawing5.Checked) { classroomSkills += (1 << 4); }
            if (checkb_ShakeDance.Checked) { classroomSkills += (1 << 8); }
            if (checkb_SpinDance.Checked) { classroomSkills += (1 << 9); }
            if (checkb_StepDance.Checked) { classroomSkills += (1 << 10); }
            if (checkb_GoGoDance.Checked) { classroomSkills += (1 << 11); }
            if (checkb_Exercise.Checked) { classroomSkills += (1 << 12); }
            if (checkb_Song1.Checked) { classroomSkills += (1 << 16); }
            if (checkb_Song2.Checked) { classroomSkills += (1 << 17); }
            if (checkb_Song3.Checked) { classroomSkills += (1 << 18); }
            if (checkb_Song4.Checked) { classroomSkills += (1 << 19); }
            if (checkb_Song5.Checked) { classroomSkills += (1 << 20); }
            if (checkb_Bell.Checked) { classroomSkills += (1 << 24); }
            if (checkb_Castanets.Checked) { classroomSkills += (1 << 25); }
            if (checkb_Cymbals.Checked) { classroomSkills += (1 << 26); }
            if (checkb_Drum.Checked) { classroomSkills += (1 << 27); }
            if (checkb_Flute.Checked) { classroomSkills += (1 << 28); }
            if (checkb_Maracas.Checked) { classroomSkills += (1 << 29); }
            if (checkb_Trumpet.Checked) { classroomSkills += (1 << 30); }
            if (checkb_Tambourine.Checked) { classroomSkills += (1 << 31); }

            byte[] classroomSkillsBytes = BitConverter.GetBytes((Int32)classroomSkills);
            for (int i = 0; i < classroomSkillsBytes.Length; i++)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.SA2ClassroomSkills + i)] = classroomSkillsBytes[i]; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.SA2ClassroomSkills + i), classroomSkillsBytes[i]); }
            }
        }

        private void Checkb_Phoenix_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Unicorn_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Dragon_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Bat_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_SkeletonDog_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_HalfFish_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Raccoon_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Sheep_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Skunk_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Condor_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Parrot_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Peacock_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Gorilla_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Tiger_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Bear_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Warthog_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Cheetah_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Rabbit_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Otter_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Seal_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Checkb_Penguin_CheckedChanged(object sender, EventArgs e)
        {
            SetAnimalBehaviours();
        }

        private void Trackb_Normal2Curious_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Normal2Curious)] = (byte)(Int16)trackb_Normal2Curious.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Normal2Curious), (byte)(Int16)trackb_Normal2Curious.Value); }
        }

        private void Trackb_CryBaby2Energetic_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.CryBaby2Energetic)] = (byte)(Int16)trackb_CryBaby2Energetic.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.CryBaby2Energetic), (byte)(Int16)trackb_CryBaby2Energetic.Value); }
        }

        private void Trackb_Naive2Normal_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Naive2Normal)] = (byte)(Int16)trackb_Naive2Normal.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Naive2Normal), (byte)(Int16)trackb_Naive2Normal.Value); }
        }

        private void Trackb_Normal2BigEater_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Normal2BigEater)] = (byte)(Int16)trackb_Normal2BigEater.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Normal2BigEater), (byte)(Int16)trackb_Normal2BigEater.Value); }
        }

        private void Trackb_Normal2Carefree_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Normal2Carefree)] = (byte)(Int16)trackb_Normal2Carefree.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Normal2Carefree), (byte)(Int16)trackb_Normal2Carefree.Value); }
        }
        private void Cb_FavouriteFruit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FavouriteFruit.SelectedIndex == 8)
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.FavouriteFruit)] = 0x10; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.FavouriteFruit), 0x10); }
            }
            else
            {
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.FavouriteFruit)] = (byte)cb_FavouriteFruit.SelectedIndex; }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.FavouriteFruit), (byte)cb_FavouriteFruit.SelectedIndex); }
            }
        }

        private void Checkb_GoGoDance_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_StepDance_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_SpinDance_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_ShakeDance_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Tambourine_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Castanets_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Drawing5_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Drawing4_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Drawing3_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Drawing2_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Drawing1_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Cymbals_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Trumpet_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Exercise_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Excercise_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Flute_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Drum_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Bell_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Song5_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Song4_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Song3_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Song2_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Checkb_Song1_CheckedChanged(object sender, EventArgs e)
        {
            SetClassroomSkills();
        }

        private void Trackb_Cough_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Cough)] = (byte)(sbyte)trackb_Cough.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Cough), (byte)trackb_Cough.Value); }
        }

        private void Trackb_Cold_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Cold)] = (byte)(sbyte)trackb_Cold.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Cold), (byte)trackb_Cold.Value); }
        }

        private void Trackb_Rash_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Rash)] = (byte)(sbyte)trackb_Rash.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Rash), (byte)trackb_Rash.Value); }
        }

        private void Trackb_RunnyNose_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.RunnyNose)] = (byte)(sbyte)trackb_RunnyNose.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.RunnyNose), (byte)trackb_RunnyNose.Value); }
        }

        private void Trackb_Hiccups_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Hiccups)] = (byte)(sbyte)trackb_Hiccups.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Hiccups), (byte)trackb_Hiccups.Value); }
        }

        private void Trackb_StomachAche_Scroll(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.StomachAche)] = (byte)(sbyte)trackb_StomachAche.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.StomachAche), (byte)trackb_StomachAche.Value); }
        }

        private void Cb_Swim1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNASwimGrade1)] = (byte)cb_Swim1.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNASwimGrade1), (byte)cb_Swim1.SelectedIndex); }
        }

        private void Cb_Fly1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAFlyGrade1)] = (byte)cb_Fly1.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAFlyGrade1), (byte)cb_Fly1.SelectedIndex); }
        }

        private void Cb_Run1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grade = cb_Run1.SelectedIndex;
            if (grade == 6) { grade = 7; }
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNARunGrade1)] = (byte)grade; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNARunGrade1), (byte)grade); }
        }

        private void Cb_Power1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAPowerGrade1)] = (byte)cb_Power1.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAPowerGrade1), (byte)cb_Power1.SelectedIndex); }
        }

        private void Cb_Stamina1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAStaminaGrade1)] = (byte)cb_Stamina1.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAStaminaGrade1), (byte)cb_Stamina1.SelectedIndex); }
        }

        private void Cb_Swim2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNASwimGrade2)] = (byte)cb_Swim2.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNASwimGrade2), (byte)cb_Swim2.SelectedIndex); }
        }

        private void Cb_Fly2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAFlyGrade2)] = (byte)cb_Fly2.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAFlyGrade2), (byte)cb_Fly2.SelectedIndex); }
        }

        private void Cb_Run2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grade = cb_Run2.SelectedIndex;
            if (grade == 6) { grade = 7; }
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNARunGrade2)] = (byte)grade; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNARunGrade2), (byte)grade); }
        }

        private void Cb_Power2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAPowerGrade2)] = (byte)cb_Power2.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAPowerGrade2), (byte)cb_Power2.SelectedIndex); }
        }

        private void Cb_Stamina2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAStaminaGrade2)] = (byte)cb_Stamina2.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAStaminaGrade2), (byte)cb_Stamina2.SelectedIndex); }
        }

        private void Cb_Fruit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAFavouriteFruit1)] = (byte)cb_Fruit1.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAFavouriteFruit1), (byte)cb_Fruit1.SelectedIndex); }
        }

        private void Cb_Fruit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAFavouriteFruit2)] = (byte)cb_Fruit2.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAFavouriteFruit2), (byte)cb_Fruit2.SelectedIndex); }
        }

        private void Cb_Colour1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Colour1.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.chaoColours.Where(x => x.Key == cb_Colour1.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAColour1)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAColour1), (byte)(flag)); }
            }
        }

        private void Cb_Colour2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Colour2.SelectedItem.ToString() != "")
            {
                int flag = ChaoSave.chaoColours.Where(x => x.Key == cb_Colour2.SelectedItem.ToString()).First().Value;
                if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAColour2)] = (byte)(flag); }
                else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAColour2), (byte)(flag)); }
            }
        }

        private void Cb_EggColour1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAEggColour1)] = (byte)cb_EggColour1.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAEggColour1), (byte)cb_EggColour1.SelectedIndex); }
        }

        private void Cb_EggColour2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAEggColour2)] = (byte)cb_EggColour2.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAEggColour2), (byte)cb_EggColour2.SelectedIndex); }
        }

        private void Cb_Texture1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNATexture1)] = (byte)cb_Texture1.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNATexture1), (byte)cb_Texture1.SelectedIndex); }
        }

        private void Cb_Texture2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNATexture1)] = (byte)cb_Texture1.SelectedIndex; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNATexture1), (byte)cb_Texture1.SelectedIndex); }
        }

        private void Checkb_Shiny1_CheckedChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAShiny1)] = (byte)(Convert.ToUInt32(checkb_Shiny1.Checked)); }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAShiny1), (byte)(Convert.ToUInt32(checkb_Shiny1.Checked))); }
        }

        private void Checkb_Shiny2_CheckedChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAShiny2)] = (byte)(Convert.ToUInt32(checkb_Shiny2.Checked)); }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAShiny2), (byte)(Convert.ToUInt32(checkb_Shiny2.Checked))); }
        }

        private void Checkb_MonoTone1_CheckedChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAMonoTone1)] = (byte)(Convert.ToUInt32(checkb_MonoTone1.Checked)); }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAMonoTone1), (byte)(Convert.ToUInt32(checkb_MonoTone1.Checked))); }
        }

        private void Checkb_MonoTone2_CheckedChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAMonoTone2)] = (byte)(Convert.ToUInt32(checkb_MonoTone2.Checked)); }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAMonoTone2), (byte)(Convert.ToUInt32(checkb_MonoTone2.Checked))); }
        }

        private void Checkb_WateringCan_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_Car_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_Rattle_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_Broomstick_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_SonicDoll_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_PictureBook_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_BubbleWand_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_Crayons_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_PogoStick_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_Shovel_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Checkb_Glitch_CheckedChanged(object sender, EventArgs e)
        {
            SetToys();
        }

        private void Nud_LuckGrade_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.LuckGrade)] = (byte)nud_LuckGrade.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.LuckGrade), (byte)nud_LuckGrade.Value); }
        }

        private void Nud_IntelligenceGrade_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.IntelligenceGrade)] = (byte)nud_IntelligenceGrade.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.IntelligenceGrade), (byte)nud_IntelligenceGrade.Value); }
        }

        private void Nud_Luck1_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNALuckGrade1)] = (byte)nud_Luck1.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNALuckGrade1), (byte)nud_Luck1.Value); }
        }

        private void Nud_Luck2_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNALuckGrade2)] = (byte)nud_Luck2.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNALuckGrade2), (byte)nud_Luck2.Value); }
        }

        private void Nud_Intelligence1_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAIntelligenceGrade1)] = (byte)nud_Intelligence1.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAIntelligenceGrade1), (byte)nud_Intelligence1.Value); }
        }

        private void Nud_Intelligence2_ValueChanged(object sender, EventArgs e)
        {
            if (!Main.isRTE) { Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.DNAIntelligenceGrade2)] = (byte)nud_Intelligence2.Value; }
            else { Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.DNAIntelligenceGrade2), (byte)nud_Intelligence2.Value); }
        }

        private void Checkb_RealisticValues_CheckedChanged(object sender, EventArgs e)
        {
            CheckRealistic();
        }

        public void CheckRealistic()
        {
            int alignment = 0;
            int run2power = 0;
            int swim2fly = 0;
            int magnitude = 0;

            Invoke(new MethodInvoker(delegate () 
            {
                alignment = trackb_Alignment.Value;
                run2power = trackb_Run2Power.Value;
                swim2fly = trackb_Swim2Fly.Value;
                magnitude = trackb_TransformationMagnitude.Value;
            }));

            if (checkb_RealisticValues.Checked)
            {
                if (alignment > 10000000) { trackb_Alignment.InvokeCheck(() => trackb_Alignment.Value = 10000000); }
                if (alignment < -10000000) { trackb_Alignment.InvokeCheck(() => trackb_Alignment.Value = -10000000); }
                if (run2power > 10000000) { trackb_Run2Power.InvokeCheck(() => trackb_Run2Power.Value = 10000000); }
                if (run2power < -10000000) { trackb_Run2Power.InvokeCheck(() => trackb_Run2Power.Value = -10000000); }
                if (swim2fly > 10000000) { trackb_Run2Power.InvokeCheck(() => trackb_Run2Power.Value = 10000000); }
                if (swim2fly < -10000000) { trackb_Swim2Fly.InvokeCheck(() => trackb_Swim2Fly.Value = -10000000); }
                if (magnitude > 12000000) { trackb_TransformationMagnitude.InvokeCheck(() => trackb_TransformationMagnitude.Value = 12000000); }
                lb_Run.InvokeCheck(() => lb_Run.Text = "-1");
                lb_Power.InvokeCheck(() => lb_Power.Text = "1");
                trackb_Run2Power.InvokeCheck(() => trackb_Run2Power.Maximum = 10000000);
                trackb_Run2Power.InvokeCheck(() => trackb_Run2Power.Minimum = -10000000);
                trackb_Run2Power.InvokeCheck(() => trackb_Run2Power.SmallChange = 1000);
                trackb_Run2Power.InvokeCheck(() => trackb_Run2Power.LargeChange = 10000);
                lb_Swim.InvokeCheck(() => lb_Swim.Text = "-1");
                lb_Fly.InvokeCheck(() => lb_Fly.Text = "-1");
                trackb_Swim2Fly.InvokeCheck(() => trackb_Swim2Fly.Maximum = 10000000);
                trackb_Swim2Fly.InvokeCheck(() => trackb_Swim2Fly.Minimum = -10000000);
                trackb_Swim2Fly.InvokeCheck(() => trackb_Swim2Fly.SmallChange = 1000);
                trackb_Swim2Fly.InvokeCheck(() => trackb_Swim2Fly.LargeChange = 10000);
                lb_AlignmentDark.InvokeCheck(() => lb_AlignmentDark.Text = "-1");
                lb_AlignmentHero.InvokeCheck(() => lb_AlignmentHero.Text = "1");
                trackb_Alignment.InvokeCheck(() => trackb_Alignment.Maximum = 10000000);
                trackb_Alignment.InvokeCheck(() => trackb_Alignment.Minimum = -10000000);
                trackb_Alignment.InvokeCheck(() => trackb_Alignment.SmallChange = 1000);
                trackb_Alignment.InvokeCheck(() => trackb_Alignment.LargeChange = 10000);
                lb_TransformationMagnitudeUpper.InvokeCheck(() => lb_TransformationMagnitudeUpper.Text = "1.2");
                trackb_TransformationMagnitude.InvokeCheck(() => trackb_TransformationMagnitude.Maximum = 12000000);
            }
            else
            {
                lb_Run.InvokeCheck(() => lb_Run.Text = "-3");
                lb_Power.InvokeCheck(() => lb_Power.Text = "3");
                trackb_Run2Power.InvokeCheck(() => trackb_Run2Power.Maximum = 30000000);
                trackb_Run2Power.InvokeCheck(() => trackb_Run2Power.Minimum = -30000000);
                lb_Swim.InvokeCheck(() => lb_Swim.Text = "-3");
                lb_Fly.InvokeCheck(() => lb_Fly.Text = "-3");
                trackb_Swim2Fly.InvokeCheck(() => trackb_Swim2Fly.Maximum = 30000000);
                trackb_Swim2Fly.InvokeCheck(() => trackb_Swim2Fly.Minimum = -30000000);
                lb_AlignmentDark.InvokeCheck(() => lb_AlignmentDark.Text = "-3");
                lb_AlignmentHero.InvokeCheck(() => lb_AlignmentHero.Text = "3");
                trackb_Alignment.InvokeCheck(() => trackb_Alignment.Maximum = 30000000);
                trackb_Alignment.InvokeCheck(() => trackb_Alignment.Minimum = -30000000);
                lb_TransformationMagnitudeUpper.InvokeCheck(() => lb_TransformationMagnitudeUpper.Text = "1.8");
                trackb_TransformationMagnitude.InvokeCheck(() => trackb_TransformationMagnitude.Maximum = 18000000);
            }
        }

        private void Checkb_SASkunk_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SAKoala_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SAMole_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SAElephant_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SALion_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SAGorilla_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SAKangaroo_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SARabbit_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SADeer_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SAParrot_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SASwallow_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SAPeacock_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SAOtter_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SAPenguin_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_SASeal_CheckedChanged(object sender, EventArgs e)
        {
            SetSAAnimalBehaviours();
        }

        private void Checkb_InitChao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb_InitChao.Checked == true)
            {
                cb_ArmsPart.SelectedIndex = 0;
                cb_EarsPart.SelectedIndex = 0;
                cb_FacePart.SelectedIndex = 0;
                cb_ForeheadPart.SelectedIndex = 0;
                cb_HornsPart.SelectedIndex = 0;
                cb_LegsPart.SelectedIndex = 0;
                cb_TailPart.SelectedIndex = 0;
                cb_WingsPart.SelectedIndex = 0;
                cb_ChaoType.SelectedIndex = 0;
                trackb_Lifespan1.Value = 3600;
                trackb_Lifespan2.Value = 3600;
                if (!Main.isRTE)
                {
                    Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.InitChao)] = 0xFF;
                    Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.ResetTrigger)] = 0x01;
                }
                else
                {
                    Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.InitChao), 0xFF);
                    Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.ResetTrigger), 0x01);
                }

                byte[] lifespan = BitConverter.GetBytes((Int16)3600);
                if (!Main.isPC) { Array.Reverse(lifespan); }
                for (int i = 0; i < lifespan.Length; i++)
                {
                    if (!Main.isRTE)
                    {
                        Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Lifespan1 + i)] = lifespan[i];
                        Main.loadedSave[(int)(chaoBeginning + (0x800 * chaoNumber) + offsets.chao.Lifespan2 + i)] = lifespan[i];
                    }
                    else
                    {
                        Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Lifespan1 + i), lifespan[i]);
                        Memory.WriteByteAtAddress((int)(offsets.chaoMemoryStart + (0x800 * chaoNumber) + offsets.chao.Lifespan2 + i), lifespan[i]);
                    }
                }
                checkb_InitChao.Checked = false;
            }
        }
    }
}