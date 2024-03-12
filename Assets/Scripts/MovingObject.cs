using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovingObject : MonoBehaviour
{
    [SerializeField] private float speed;

    public int maxTtl = 100000;
    public int ttl = 0;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (ttl >= maxTtl)
        {
            Destroy(gameObject);
        }
        ttl++;
    }

}
