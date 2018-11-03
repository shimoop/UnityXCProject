using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace XC
{
    public class CreateXCConfig
    {
        [MenuItem("Assets/Create/XCConfig")]
        public static void CreateConfig()
        {
            XCConfig config = ScriptableObject.CreateInstance<XCConfig>();
            AssetDatabase.CreateAsset(config, "Assets/XCConfig.asset");
        }

    }
}
