using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.iOS.Xcode.Custom;

namespace XC
{
    [System.Serializable]
    public class FrameworkSetting
    {
        public string Name;
        public bool Weak;
    }
    [System.Serializable]
    public class TBDSetting
    {
        public string OriPath;
        public string DstPath;
        public PBXSourceTree SourceTree = PBXSourceTree.Sdk;
    }
    [System.Serializable]
    public class CommonResourceSetting
    {
        public string OriPath;
        public string DstPath;
        public PBXSourceTree SourceTree = PBXSourceTree.Source;
    }
    [System.Serializable]
    public class CustomSourceSetting
    {
        public string OriPath;
        public string DstPath;
        public PBXSourceTree SourceTree = PBXSourceTree.Source;
    }
    [System.Serializable]
    public class CopyFileSetting
    {
        public string OriPath;
        public string DstPath;
        public PBXSourceTree SourceTree = PBXSourceTree.Source;
    }
    [System.Serializable]
    public class AddBuildProperty
    {
        public string PropertyName;
        public string PropertyValue;
    }
    [System.Serializable]
    public class SetBuildProperty
    {
        public string PropertyName;
        public string PropertyValue;
    }
}
