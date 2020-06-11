/*using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Fishing.Items
{
    public class AddItemToCrate : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "crate" && arg == ItemID.oasis crate) 
            // if context & arg is = "Context" & item id
            // Context in this case specifies what type of thing we are opening, has to be one of these: "present", "bossBag", "crate", "lockBox", "herbBag", or "goodieBag"
            // arg specifies the itemid of the present/bag/crate we are trying to open
            {
                // "number/100" or "1 = 100%" chance/rng &  Itemid Specifies the item to give to the player
                // Each item here will roll individually, so its possible for several of them to drop together with each other
                // They will also not share any specific present/bag/crate loot pool with any other items
                // This means they will always get a chance to roll 100% of the time when a present/bag/crate is used
                // if (Main.rand.NextBool(33)) player.QuickSpawnItem(ItemID.sandstorm in a bottle); 
                // if (Main.rand.NextBool(25)) player.QuickSpawnItem(ItemID.Meowmere);
                // if (Main.rand.NextBool(50)) player.QuickSpawnItem(ItemID.PlanteraBossBag);
                // if (Main.rand.NextBool(75)) player.QuickSpawnItem(ItemID.HotlineFishingHook);

            }
            {
                if (context == "crate" && arg == ItemID.oasiscratehardmode) // hardmode oasis crate
                {
                    if (Main.rand.NextBool(33)) player.QuickSpawnItem(ItemID.WoodenSword);
                }
            }
            {
                if (context == "crate" && arg == ItemID.oceancrate)
                {
                   if (Main.rand.NextBool(95)) player.QuickSpawnItem(ItemID.WaterWalkingBoots); // 5% chance for each ocean biome crate
                }
            }
            {
                if (context == "crate" && arg == ItemID.oceancratehardmode) // hard mode version of ocean crate
                {
                    if (Main.rand.NextBool(95)) player.QuickSpawnItem(ItemID.WaterWalkingBoots);
                }
            }
            {
                if (context == "crate" && arg == ItemID.lavacrate)
                {
                    if (Main.rand.NextBool(97)) player.QuickSpawnItem(ItemID.LavaCharm); // 3% chance for each lava crate
                }
            }
            {
                if (context == "crate" && arg == ItemID.lavacrate) // hardmode version of lava crate
                {
                    if (Main.rand.NextBool(97)) player.QuickSpawnItem(ItemID.LavaCharm);
                }
            } 
        }
    }
}
*/
/*
        ~InstancePerEntity explanation~ 
        Thanks to absoluteAquarian for helping me understand all this gibberish

        public string Context;
        public bool RandomBool; 

        public override bool InstancePerEntity => true;
        // Usually the Global classes just have 1 instance active at a time
        // InstancePerEntity tells the game to make a new separte instance for whatever it should be attached to
        // instead of having only 1 central instance
        // This can be used for when you want to change static fields to not be static anymore

        public override GlobalItem Clone(Item item, Item itemClone) // clones the global class
        {
            AddItemToCrate myClone = (AddItemToCrate)base.Clone(item, itemClone); // creates a public clone from the Class name
            myClone.Context = Context; // creates a clone of the String 
            myClone.RandomBool = RandomBool; // creates a clone of the bool
            return myClone; // Returns/Gives us the clone value/s
        }
*/
