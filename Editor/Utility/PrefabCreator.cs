namespace Tilia.Trackers.ColliderFollower.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Trackers/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.trackers.colliderfollower.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabColliderFollower = "Trackers.ColliderFollower";

        [MenuItem(menuItemRoot + prefabColliderFollower, false, priority)]
        private static void AddColliderFollower()
        {
            string prefab = prefabColliderFollower + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}