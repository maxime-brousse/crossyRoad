using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cubeRotating : MonoBehaviour
{
    public Vector3 editRotation;
    public Keyboard Keyboard;

    // Start is called before the first frame update
    void Start()
    {
        Keyboard = Keyboard.current;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard != null && Keyboard.wKey.isPressed)
        {
            transform.Rotate(editRotation * Time.deltaTime);
            Debug.Log(this.transform.rotation);
        }
        else if(Keyboard != null && Keyboard.sKey.isPressed)
        {
            transform.Rotate(- (editRotation * Time.deltaTime));
            Debug.Log(this.transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

    }


}
