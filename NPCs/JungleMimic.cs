using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using NekoTweakMod.Items.Banners;
using System;
using System.Security.Cryptography.X509Certificates;

namespace NekoTweakMod.NPCs
{
    public class JungleMimic : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            
            if (npc.type == NPCID.BigMimicJungle)
            {
                Item.NPCtoBanner(NPCID.BigMimicJungle);

                // need to specify the banner that should drop

                // Item.BannerToItem<JungleMimicBanner>;
                // npc.BannerID = ItemType<JungleMimicBanner>();
                // Item.BannerToItem(JungleMimicBanner());
                // npc.BannerID(JungleMimicBanner);
                // Item.NPCtoBanner(JungleMimicBanner)
                // ItemType<JungleMimicBanner>();
            }
        }
    }
}