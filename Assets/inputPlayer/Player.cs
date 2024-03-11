using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private TerrainGenerator terrainGenerator;

    private Animator _animator;
    public Keyboard Keyboard;
    private bool _isHopping = false;

    // Start is called before the first frame update
    void Start()
    {
        Keyboard = Keyboard.current;
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!_isHopping && _animator != null)
        {
            if (Keyboard.wKey.isPressed || Keyboard.upArrowKey.isPressed)
            {
                float xDifference = 0;
                if(transform.position.z % 1  == 0)
                {
                    xDifference = Mathf.Round(transform.position.z) - transform.position.z;
                }
                moveCharacter(new Vector3(xDifference, 0, 1));
            }
            else if (Keyboard.aKey.isPressed || Keyboard.leftArrowKey.isPressed)
            {
                moveCharacter(new Vector3(-1, 0, 0));
            }
            else if (Keyboard.dKey.isPressed || Keyboard.rightArrowKey.isPressed)
            {
                moveCharacter(new Vector3(1, 0, 0));
            }
            if (Keyboard.sKey.isPressed || Keyboard.downArrowKey.isPressed)
            {
                float xDifference = 0;
                if (transform.position.z % 1 == 0)
                {
                    xDifference = Mathf.Round(transform.position.z) - transform.position.z;
                }
                moveCharacter(new Vector3(xDifference, 0, -1));
            }
        }
    }

    private void moveCharacter(Vector3 difference)
    {
        _animator.SetTrigger("hopping");
        _isHopping = true;
        transform.position = (transform.position + difference);
        terrainGenerator.SpawnTerrain(false, transform.position);
    }
    public void FinishHop()
    {
        _isHopping = false;
    }
}
