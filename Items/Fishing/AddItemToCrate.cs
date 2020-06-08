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
                // Each item here will roll individually, but it is possible to get multiple of them at once
                if (Main.rand.NextBool(33)) player.QuickSpawnItem(ItemID.WoodenSword); // number/100 or "100% if its at 1" chance/rng & also Specifies the item to add to the present/bag/crate
               // if (Main.rand.NextBool(25)) player.QuickSpawnItem(ItemID.Meowmere);
               // if (Main.rand.NextBool(50)) player.QuickSpawnItem(ItemID.PlanteraBossBag);
               // if (Main.rand.NextBool(75)) player.QuickSpawnItem(ItemID.HotlineFishingHook);

            }
        }
    }
}