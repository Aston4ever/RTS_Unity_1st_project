using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewLevelData", menuName = "Geometry Dash/New Level Data")]
public class LevelDataSO : ScriptableObject {
   public string Name;
   public Sprite Difficulty;
   public int SceneInd;
}
