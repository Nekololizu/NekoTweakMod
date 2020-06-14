using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class PreserveMinionOnDeath : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            base.Update(type, player, ref buffIndex);
          //  if(player.buffType(BuffID.BabySlime))
            {
            //    BuffID.BabySlime = Main.persistentBuff;
            }
        }
    }
}