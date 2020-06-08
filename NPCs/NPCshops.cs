using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.NPCs
{
    public class NPCshops : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot) // Allows you to add items to NPC shops
        {
            if(type == NPCID.Merchant) // Specifies the npc we are changing
            {
                shop.item[nextSlot].SetDefaults(ItemID.MiningShirt); // Add an item with the itemid to the next available slot in the NPCs shop
                shop.item[nextSlot].shopCustomPrice = 40000; // sets the purchase cost,  40000 = 4 gold
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.MiningPants);
                shop.item[nextSlot].shopCustomPrice = 40000;
                nextSlot++;
                // 1000000=1plat  10000=1gold, 100=1silver 1=1copper
            }
            {
                if(type == NPCID.Dryad) // adds corruption/crimson items all the time
                {
                    shop.item[nextSlot].SetDefaults(ItemID.VilePowder); 
                    shop.item[nextSlot].shopCustomPrice = 1000; 
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.ViciousPowder);
                    shop.item[nextSlot].shopCustomPrice = 1000;  
                    nextSlot++;
                    /*shop.item[nextSlot].SetDefaults(ItemID.CrimsonGrassEcho);  v1.4
                    shop.item[nextSlot].shopCustomPrice = 10; 
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.CorruptGrassEcho);
                    shop.item[nextSlot].shopCustomPrice = 10; 
                    nextSlot++; */
                    shop.item[nextSlot].SetDefaults(ItemID.PygmyNecklace);
                    shop.item[nextSlot].shopCustomPrice = 150000;
                    nextSlot++;
                }
            }
            {
                if(type == NPCID.Steampunker) // adds corruption/crimson/hallow items all the time
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SteampunkGoggles);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.PurpleSolution);
                    shop.item[nextSlot].shopCustomPrice = 2500;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.RedSolution);
                    shop.item[nextSlot].shopCustomPrice = 2500;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.BlueSolution);
                    shop.item[nextSlot].shopCustomPrice = 2500;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.FleshCloningVaat);
                    shop.item[nextSlot].shopCustomPrice = 100000;
                    nextSlot++;
                    //shop.item[nextSlot].SetDefaults(ItemID.LesionStation); v1.4
                    //shop.item[nextSlot].shopCustomPrice = 100000;
                    // nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicsRod);
                    shop.item[nextSlot].shopCustomPrice = 400000; 
                    nextSlot++;
                }
            }
            {
                if (type == NPCID.DyeTrader)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.DyeTraderTurban);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.DyeTraderRobe);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                }
            }
            {
                if (type == NPCID.Painter)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.DeadlandComesAlive);
                    shop.item[nextSlot].shopCustomPrice = 10000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.LightlessChasms);
                    shop.item[nextSlot].shopCustomPrice = 10000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.PaintingTheSeason);
                    shop.item[nextSlot].shopCustomPrice = 10000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.PaintingSnowfellas);
                    shop.item[nextSlot].shopCustomPrice = 10000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.PaintingCursedSaint);
                    shop.item[nextSlot].shopCustomPrice = 10000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.PaintingColdSnap);
                    shop.item[nextSlot].shopCustomPrice = 10000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.PaintingAcorns);
                    shop.item[nextSlot].shopCustomPrice = 10000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.ChristmasTreeWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.CandyCaneWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.StarsWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.SnowflakeWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.BluegreenWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.OrnamentWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.FestiveWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.SquigglesWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.KrampusHornWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.GrinchFingerWallpaper);
                    shop.item[nextSlot].shopCustomPrice = 100;
                    nextSlot++;
                }
            }
            {
                if (type == NPCID.ArmsDealer)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.NurseHat); // 3 gold each
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.NurseShirt);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.NursePants);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                }
            }
            {
                if (type == NPCID.DD2Bartender)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.DefenderMedal); 
                    shop.item[nextSlot].shopCustomPrice = 1000000; // 1plat
                    nextSlot++;
                }
            }
            {
                if (type == NPCID.WitchDoctor)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Cauldron);
                    shop.item[nextSlot].shopCustomPrice = 15000;
                    nextSlot++;
                }
            }
            {
                if (type == NPCID.Clothier)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GuyFawkesMask);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.ClothierJacket);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.ClothierPants);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                }
            }
            {
                if (type == NPCID.Wizard)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.WizardsHat);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                }
            }
            {
                if (type == NPCID.Cyborg)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CyborgHelmet);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.CyborgShirt);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.CyborgPants);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                }
            }
        }
    }
}