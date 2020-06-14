using System;
using System.ComponentModel;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Buffs
{
    public class SlimySlimes : GlobalNPC
    {
        public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit) // allows us to change what happens when an npc hit/hurt the player
        {
            // If the npc type is a greenslime, it will apply the slimed debuff for 15seconds(1sec = 60ticks, 60x15 = 900) when it attacks the player 
            if (npc.type == NPCID.GreenSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed,899); 
            if (npc.type == NPCID.BlueSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.RedSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.PurpleSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.YellowSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.BlackSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.IceSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.SandSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.JungleSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.SpikedIceSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.SpikedJungleSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.MotherSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.BabySlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.LavaSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.DungeonSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.Pinky) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.KingSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.SlimeSpiked) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.UmbrellaSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.BunnySlimed) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.SlimeRibbonWhite) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.SlimeRibbonYellow) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.SlimeRibbonGreen) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.SlimeRibbonRed) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.ToxicSludge) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.CorruptSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.Slimeling) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.Slimer) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.Slimer2) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.Crimslime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.BigCrimslime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.LittleCrimslime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.Gastropod) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.IlluminantSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.RainbowSlime) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899);
            if (npc.type == NPCID.HoppinJack) Main.LocalPlayer.AddBuff(BuffID.Slimed, 899); // Halloween event slime
        }
    }
}
