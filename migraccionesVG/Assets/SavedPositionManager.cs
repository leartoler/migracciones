using UnityEngine;
using System.Collections.Generic;

public static class SavedPositionManager // Static class to remember player positions per scene.
{
    public static Dictionary<int, Vector3> savedPositions = new Dictionary<int, Vector3>();
}