using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class SummonerItemSound : GlobalItem // class name & GlobalItem hook
    {
        public override void SetDefaults(Item item) // SetDefaults allows us to set/change properties of items if we are using the GlobalItem hook
        { // Single line "if" statements, as we are only changing 1 property for each item
          // Pre Hardmode summon weapons
          // if (item.type == ItemID.BabyBird) item.UseSound = SoundID.Item44; v1.4
            if (item.type == ItemID.SlimeStaff) item.UseSound = SoundID.Item44; // this code Change SlimeStaffs Use sound to SoundID item44
            //if the item is an item and its a "slimestaff", the items "Use" sound will be item44

            if (item.type == ItemID.HornetStaff) item.UseSound = SoundID.Item76;
            //if (item.type == ItemID.Vampirefroggstaff) item.UseSound = SoundID.Item44;
            if (item.type == ItemID.ImpStaff) item.UseSound = SoundID.Item77;
            // hardmode summon weapons
            if (item.type == ItemID.SpiderStaff) item.UseSound = SoundID.Item83;
            if (item.type == ItemID.OpticStaff) item.UseSound = SoundID.Item82;
            if (item.type == ItemID.PygmyStaff) item.UseSound = SoundID.Item44;
            if (item.type == ItemID.PirateStaff) item.UseSound = SoundID.Item44;
            if (item.type == ItemID.RavenStaff) item.UseSound = SoundID.Item44;
            // if (item.type == ItemID.bladestaff) item.UseSound = SoundID.Item77; v1.4
            // if (item.type == ItemID.Sanguinestaff) item.UseSound = SoundID.Item83;
            // if (item.type == ItemID.Deserttigerstaff) item.UseSound = SoundID.Item77;
            if (item.type == ItemID.DeadlySphereStaff) item.UseSound = SoundID.Item113;
            if (item.type == ItemID.TempestStaff) item.UseSound = SoundID.Item77;
            if (item.type == ItemID.XenoStaff) item.UseSound = SoundID.Item82;
            if (item.type == ItemID.StardustCellStaff) item.UseSound = SoundID.Item113;
            if (item.type == ItemID.StardustDragonStaff) item.UseSound = SoundID.Item113;
            // if (item.type == ItemID.EmpressBlade) item.UseSound = SoundID.Item113; // Terraprisma
            // Sentry Staves
            if (item.type == ItemID.QueenSpiderStaff) item.UseSound = SoundID.Item78;
            if (item.type == ItemID.StaffoftheFrostHydra) item.UseSound = SoundID.Item1;
            if (item.type == ItemID.RainbowCrystalStaff) item.UseSound = SoundID.Item1;
            if (item.type == ItemID.MoonlordTurretStaff) item.UseSound = SoundID.Item1; // Lunar Portal Staff
        }
    }
}

/*
Explanation/Idea by JohannSimm on the TCF:

 All the summon weapons introduced in 1.4, with the apparent exception of the Vampire Frog staff, use the Deadly Sphere Staff use sound effect, which is very metallic and digital-sounding. It doesn't suit many of the new summon weapons well at all, as it was intended to be the unique sound of the Deadly Sphere Staff. It seems almost as if the sound effect just got copied when the new items were created, and was never changed.

Summoner Weapon Sounds
Item_44 – The default summoner weapon sound. A diminutive croak.
Item_76 – The unique sound of the Hornet Staff. A fluttering whoosh.
Item_77 – The unique sound of the Imp Staff. A hollow whoosh.
Item_82 – The unique sound of the Optic Staff. A mechanical whoosh.
Item_83 – The unique sound of the Spider Staff. A chittering whoosh.
Item_113 – Formerly the unique sound of the Deadly Sphere Staff. A robotic/arcane whoosh. Currently used for six staves, five of which are new.

Meanwhile, large numbers of summon weapons introduced in previous updates still use the Item_44 sound effect, including both Stardust staves. The sound is extremely basic, and, in my opinion, ill-suited to the endgame summon staves.

Below are my suggestions for what I think should be changed, along with my reasoning:

Pre-Hardmode Summon Weapons
Finch Staff — Item_113 -> Item_44 (Item_44 is the best fit here, as it sounds like a small animal.)
Slime Staff — Item_44
Hornet Staff — Item_76
Vampire Frog Staff — Item_44
Imp Staff — Item_77

Hardmode Summon Weapons
Spider Staff — Item_83
Blade Staff — Item_113 -> Item_77 (The Imp Staff's sound is the most neutral of the sounds, and I think it suits an arcane dagger.)
Sanguine Staff — Item_113 -> Item_83 (The chittering Spider Staff sound is well-suited to a bat minion.)
Optic Staff — Item_82
Pirate Staff — Item_44
Pygmy Staff — Item_44
Raven Staff — Item_44
Desert Tiger Staff — Item_113 -> Item_77 (The Desert Tiger sound should be more majestic than Item_44, but not robotic like it is now. Once again, the Imp Staff's sound is the best fit.)
Tempest Staff — Item_44 -> Item_77 (The Imp Staff's whoosh is a better fit for an arcane shark-hurling whirlpool than the unassuming Item_44.)
Deadly Sphere Staff — Item_113
Xeno Staff — Item_44 -> Item_82 (The Optic Staff sound fits the flavour of a Martian Saucer better than Item_44.)
Stardust Cell Staff — Item_44 -> Item_113 (Item_113 sounds both technological and arcane, giving the Stardust staves the dramatic sound they deserve.)
Stardust Dragon Staff — Item_44 -> Item_113 (See above.)
Terraprisma — Item_113 (This one can be left as is, as the Deadly Sphere Staff sound already suits it well.)

I also have a suggestion for changes to the Sentry sound effects. For some reason, the Rainbow Crystal Staff and Lunar Portal Staff use the same sound effect as the Queen Spider Staff, which is very chittery and spider-like. It's too specific, and was obviously created for that staff alone. I think the two Moon Lord staves should use the same sounds as the Staff of the Frost Hydra.

(Clarification: The Queen Spider Staff and Staff of the Frost Hydra have both a "Use" sound effect and "Summon" sound effect. The Moon Lord staves only have a "Use" sound effect.)

Hardmode Sentry Staves (Tavernkeep sentries not included, as they have their own set of consistent sound effects.)
Queen Spider Staff — Item_78 + Item_46
Staff of the Frost Hydra — Item_1 + Item_46
Rainbow Crystal Staff — Item_78 -> [Item_1 + Item_46] (Change to same pair of sounds as Staff of the Frost Hydra.)
Lunar Portal Staff — Item_78 -> [Item_1 + Item_46] (Change to same pair of sounds as Staff of the Frost Hydra.)

(Possibly, Item_113 + Item_46 could be used for the Moon Lord staves.)
*/
