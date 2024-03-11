using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Terrain Data", menuName = "Terrain Data")]
public class TerrainData : ScriptableObject{
   public GameObject terrain;
   //public List<GameObject> terrains;
   public int maxInSuccession;
}
