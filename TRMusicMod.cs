using Microsoft.Xna.Framework.Audio;
using Terraria.ModLoader;
using TerRoguelike.Systems;

namespace TRMusicMod
{
	public class TRMusicMod : Mod
	{
        public override void PostSetupContent()
        {
            MusicSystem.MusicDict.Add("TRMusicMod/Tracks/thepainfulway", ModContent.Request<SoundEffect>("TRMusicMod/Tracks/thepainfulway"));

            MusicSystem.ForestTheme = new(
                "TRMusicMod/Tracks/thepainfulway",
                "TerRoguelike/Tracks/BaseThemeCombat",
                0.26f);

            MusicSystem.BaseTheme = new(
                "TRMusicMod/Tracks/thepainfulway",
                "TerRoguelike/Tracks/ForestThemeCombat",
                0.22f);
        }
    }
}
