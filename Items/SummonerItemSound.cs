using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class SummonerItemSound : GlobalItem // class name & vanilla hook
    {
        public override void SetDefaults(Item item) // SetDefaults allows you to set/change properties of items
        { // Single line "if" statements as we are only changing 1 property
          // if (item.type == ItemID.BabyBird) item.UseSound = SoundID.Item44; v1.4
          // if (item.type == ItemID.bladestaff) item.UseSound = SoundID.Item77;
          // if (item.type == ItemID.Sanguinestaff) item.UseSound = SoundID.Item83;
          // if (item.type == ItemID.Deserttigerstaff) item.UseSound = SoundID.Item77;
            if (item.type == ItemID.TempestStaff) item.UseSound = SoundID.Item77;
            if (item.type == ItemID.XenoStaff) item.UseSound = SoundID.Item82;
            if (item.type == ItemID.StardustCellStaff) item.UseSound = SoundID.Item113;
            if (item.type == ItemID.StardustDragonStaff) item.UseSound = SoundID.Item113;
        }
    }
}