using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VehiculeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject vehicule;
    [SerializeField] private Transform spawnPos;
    [SerializeField] private float minSeparationTime;
    [SerializeField] private float maxSeparationTime;

    private void Start()
    {
        StartCoroutine(SpawnVehicle());
    }

    private IEnumerator SpawnVehicle()
    {
        while(true){
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));
            GameObject go = Instantiate(vehicule, spawnPos.position, Quaternion.identity);
            go.transform.Rotate(new Vector3(0, 180 + 90, 0));
        }
    }
}
