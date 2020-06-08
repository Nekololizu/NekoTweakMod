using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items.Fishing
{
    public class AddItemToCrate : GlobalItem
    {
        public string Context;
        public bool RandomBool; // still no idea how either string or bool works here, but got errors without using InstancePerEntity & code works fine

        public override bool InstancePerEntity => true;
        // Need to use InstancePerEntity when bool is not static, something something~

        public override GlobalItem Clone(Item item, Item itemClone)
        {
            AddItemToCrate myClone = (AddItemToCrate)base.Clone(item, itemClone);
            myClone.Context = Context;
            myClone.RandomBool = RandomBool;
            return myClone;
        }
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "crate" && arg == ItemID.IronCrate)
            // if context & arg is = text & item id
            // Context has to be one of these examples: "present", "bossBag", "crate", "lockBox", "herbBag", or "goodieBag"
            // arg specifies the present/bag/crate itemid
            {
                // Each item here will roll individually, so its possible for several of them to drop together with each other
                // They will also not share any specific present/bag/crate loot pool with any other items
                // This means they will always get a chance to roll 100% of the time when a present/bag/crate is used
                // number/100 or "1 = 100%" chance/rng & Specifies the item to give
                //if (Main.rand.NextBool(33)) player.QuickSpawnItem(ItemID.WoodenSword); 
                // if (Main.rand.NextBool(25)) player.QuickSpawnItem(ItemID.Meowmere);
                // if (Main.rand.NextBool(50)) player.QuickSpawnItem(ItemID.PlanteraBossBag);
                // if (Main.rand.NextBool(75)) player.QuickSpawnItem(ItemID.HotlineFishingHook);

            }
        }
    }
}