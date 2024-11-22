using Microsoft.Xna.Framework.Audio;
using Terraria.ModLoader;
using TerRoguelike.Systems;

namespace TRMusicMod
{
	public class TRMusicMod : Mod
	{
        public override void PostSetupContent()
        {
            // MusicSystem.MusicDict.Add("Path/To/Your/Song", ModContent.Request<SoundEffect>("Path/To/Your/Song"));

            MusicSystem.ForestTheme = new(
                "TRMusicMod/Tracks/BaseThemeCalm",
                "TerRoguelike/Tracks/BaseThemeCombat",
                0.26f);

            MusicSystem.BaseTheme = new(
                "TRMusicMod/Tracks/ForestThemeCalm",
                "TerRoguelike/Tracks/ForestThemeCombat",
                0.22f);
        }
    }
}
