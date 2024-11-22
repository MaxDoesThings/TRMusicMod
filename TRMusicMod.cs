using Microsoft.Xna.Framework.Audio;
using Terraria.ModLoader;
using TerRoguelike.Systems;

namespace TRMusicMod
{
	public class TRMusicMod : Mod
	{
        public override void PostSetupContent()
        {
            // Welcome to this quick guide on how you can add, and replace, music in the mod.
            // Let's get straight into it.
            // To add music, you need to add it into the mod's "MusicDict" dictionary.
            // This is where it stores all of the tracks' paths to be used later.
            //
            // Use this statement below to add your song to the dictionary.
            // If, for example, you had your song in a folder called "Tracks",
            // in both quotes, it'd be: "YourModName/Tracks/YourSongName" (do not include the file extension, you just need the name).
            // MusicSystem.MusicDict.Add("YourModName/OtherFolders/YourSongName", ModContent.Request<SoundEffect>("YourModName/OtherFolders/YourSongName"));
            //
            // Now, you may be asking, "how do I know what I want to replace?"
            // If you had followed the link to the TerRoguelike Github to the specific file, scrolling down to
            // lines 63-185, you'll see various statements which may have names familiar to you.
            //
            // Let's look at the first class titled "FloorSoundtrack".
            // In the FloorSoundTrack class, there are 3 parameters to make it valid: The Calm Theme, The Combat Theme, and Volume.
            // The first two are simple enough. The third, volume, is mostly trial and error to see how loud it is in game.
            // Here's an example of how you'd add a new set of music for a Floor:
            //
            // MusicSystem.InsertFloorThemeName = new(
            //     "YourModName/OtherFolders/YourCalmSongName",
            //     "YourModName/OtherFolders/YourCombatSongName",
            //     0.20f);
            //
            // Now, let's look at the second class, "BossTheme".
            // In the BossTheme class, there are 4 parameters this time: The Main Loop, The Start Snippet, The End Snippet, and Volume.
            // Here's an example of how you'd add a new set of music for a Boss:
            //
            // MusicSystem.InsertBossThemeName = new(
            //     "YourModName/OtherFolders/YourMainLoopName",
            //     "YourModName/OtherFolders/YourStartSnippetName",
            //     "YourModName/OtherFolders/YourEndSnippetName",
            //     0.20f);
            //
            // If you had taken a gander at lines 63-66, those are easy enough to replace, as most are one track loops (refer to the steam guide for clarification).
            // But, just in case... example time:
            //
            // MusicSystem.InsertMiscThemesName = "YourModName/OtherFolders/YourMiscSongName";
            //
            // As a small example in this example mod, I have swapped the two starting area's themes, The Forest and The Base (catacombs? something idk).
            // Meaning, you'll hear the base music in the forest, and the forest music in the base floor.

            MusicSystem.ForestTheme = new(
                "TerRoguelike/Tracks/BaseThemeCalm",
                "TerRoguelike/Tracks/BaseThemeCombat",
                0.22f);

            MusicSystem.BaseTheme = new(
                "TerRoguelike/Tracks/ForestThemeCalm",
                "TerRoguelike/Tracks/ForestThemeCombat",
                0.22f);
        }
    }
}
