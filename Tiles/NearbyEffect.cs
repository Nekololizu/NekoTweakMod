using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Tiles
//Namespace is where the code start and end with { & }
{
    public class NearbyEffect : GlobalTile // class name & vanilla tiles
    {
        public override void NearbyEffects(int i, int j, int type, bool closer) //Apply something if nearby specified tile
        //Methods inside the Class
        {
            if (type == TileID.AmmoBox) Main.LocalPlayer.AddBuff(BuffID.AmmoBox, 35999); // Duration is set in ticks not seconds. 60ticks = 1second. 36000 = 10 minutes
            //Gives this specific tile a NearbyEffect
            // (BuffID.BuffName, duration); 
            //NearbyEffect makes an item do something while nearby it.  In this case the Tiles give the player a buff  
            if (type == TileID.BewitchingTable) Main.LocalPlayer.AddBuff(BuffID.Bewitched, 35999);
            if (type == TileID.CrystalBall) Main.LocalPlayer.AddBuff(BuffID.Clairvoyance, 35999);
            if (type == TileID.SharpeningStation) Main.LocalPlayer.AddBuff(BuffID.Sharpened, 35999);
            //if (type == TileID.SliceOfCake) Main.LocalPlayer.AddBuff(BuffID.SugarRush, 35999); temporary disabled until tmod v1.4
        }
    }
}
// Thanks to jopojelly for explaining the full code & syntax
// & absoluteAquarian for explaing how to add the timing parameter to AddBuff