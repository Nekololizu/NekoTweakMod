using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class DisplayName : GlobalItem // class name & vanilla hook
    {
        public override void SetDefaults(Item item) // SetDefaults allows you to set/change properties of items
        {
            base.SetDefaults(item);
            if (item.type == ItemID.CopperShortsword) // specifies what item to change
                item.SetNameOverride("LeShortSword"); // Set the name of the specified item to "Name"
            { // seperation between each "if" statement when trying to change another item

                if (item.type == ItemID.WoodenBow) // Second item that will get changed
                    item.SetNameOverride("MagicalWoodenBow");
                {
                    if (item.type == ItemID.WoodenSword)
                        item.SetNameOverride("StoneSwordOfWood");
                }
            }
        }
    }
}