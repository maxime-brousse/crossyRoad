using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TerrainGenerator : MonoBehaviour {
    private Vector3 currentPosition = new Vector3(0, -1, 0);

    public Keyboard Keyboard;
    [SerializeField] private List<GameObject> terrains = new List<GameObject>();

    private void Start(){
        Keyboard = Keyboard.current;
        //SpawnTerrain();
    }

    private void Update(){
        if (Keyboard.wKey.isPressed)
        {
            //SpawnTerrain();
        }
    }

    private void SpawnTerrain(){
        Instantiate(terrains[Random.Range(0, terrains.Count - 1)], currentPosition, Quaternion.identity);
        currentPosition.x++;
    }
}
