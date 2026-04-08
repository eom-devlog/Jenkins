using UnityEditor;
using UnityEngine;

public class BuildScript
{
    public static void PerformBuild()
    {
        string[] scenes = new[] {
            "Assets/Scenes/MainScene.unity",
            "Assets/Scenes/LobbySecne.unity",
            "Assets/Scenes/BattleScene.unity"
        };


        BuildPipeline.BuildPlayer(scenes, "Builds/BuildTest.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
