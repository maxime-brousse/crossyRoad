using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Terrain Data", menuName = "Terrain Data")]
public class TerrainData : ScriptableObject{
   public List<GameObject> possibleTerrain;
   //public List<GameObject> terrains;
   public int maxInSuccession;
}
