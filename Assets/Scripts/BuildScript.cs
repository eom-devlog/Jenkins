using UnityEditor;
using System.Collections.Generic;
using UnityEngine;

public class BuildScript
{
    public static void Build()
    {
        List<string> scenes = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            scenes.Add(scene.path);
        }

        Debug.Log("Build");
        BuildPipeline.BuildPlayer(scenes.ToArray(), "Builds/BuildTest.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
