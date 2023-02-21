using System.IO;
using UnityEngine;
using UnityEditor;

public class GenerateAssetBundles
{
    [MenuItem("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles() {
        Debug.Log("hello");
        string assetBundleDirectory = "Assets/AssetBundles";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }// hm
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
	}
}
