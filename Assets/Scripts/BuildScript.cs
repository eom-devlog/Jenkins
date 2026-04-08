using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class BuildScript
{
    public static void PerformBuild()
    {
        List<string> scenes = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            scenes.Add(scene.path);
        }

        BuildPipeline.BuildPlayer(scenes.ToArray(), "Builds/BuildTest.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
