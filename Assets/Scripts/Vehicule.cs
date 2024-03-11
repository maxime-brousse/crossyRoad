using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicule : MonoBehaviour
{
    [SerializeField] private float speed;

    public int maxTtl = 100000;
    public int ttl = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (ttl >= maxTtl)
        {
            Destroy(gameObject);
        }
        ttl++;
    }
}
