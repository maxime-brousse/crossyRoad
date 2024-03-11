using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TerrainGenerator : MonoBehaviour {
    [SerializeField] private int minDistanceFromPlayer;
    [SerializeField] private int maxTerrainCount;
    [SerializeField] private List<TerrainData> terrainDatas = new List<TerrainData>();
    [SerializeField] private Transform terrainHolder;

    private List<GameObject> currentTerrains = new List<GameObject>();

    public Vector3 currentPosition = new Vector3(0, -1, 0);
    public Keyboard Keyboard;

    private void Start(){
        Keyboard = Keyboard.current;
        for (int i =0; i < maxTerrainCount; i++){
            SpawnTerrain(true, new Vector3(0, 0, 0));
        }
        maxTerrainCount = currentTerrains.Count;
    }

    public void SpawnTerrain(bool isStart, Vector3 playerPos){
        if ((currentPosition.z - playerPos.z < minDistanceFromPlayer) || (isStart))
        {
            int whichTerrain = Random.Range(0, terrainDatas.Count);
            int terrainInSuccession = Random.Range(1, terrainDatas[whichTerrain].maxInSuccession);

            for (int i = 0; i < terrainInSuccession; i++)
            {
                GameObject terrain = Instantiate(terrainDatas[whichTerrain].terrain, currentPosition, Quaternion.identity, terrainHolder);
                currentTerrains.Add(terrain);
                if (!isStart)
                {
                    if (currentTerrains.Count > maxTerrainCount)
                    {
                        Destroy(currentTerrains[0]);
                        currentTerrains.RemoveAt(0);
                    }
                }

                currentPosition.z++;
            }
        }
    }
}