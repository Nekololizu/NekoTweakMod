using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class SetNameOverride : GlobalItem // class name & vanilla hook
    {
        public override void SetDefaults(Item item) // SetDefaults allows you to set/change properties of items
        {
            if (item.type == ItemID.IvyWhip) item.SetNameOverride("Ivy Hook"); // Ocd fix due to summoners having whip weapons
            // specifies what item to change
            // Set the name of the specified item to "Name"
            // seperation between each "if" statement when trying to change another item
        }
    }
}