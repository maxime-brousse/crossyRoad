using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private Text ScoreObect;

    public int ScoreNumber = 0;
    public Keyboard Keyboard;

    private void ScoreUpdate()
    {
        ScoreNumber += 15;
        ScoreObect.text = "Score : " + ScoreNumber;
    }

    // Start is called before the first frame update
    private void Start()
    {
        Keyboard = Keyboard.current;
        InvokeRepeating("ScoreUpdate", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.wKey.isPressed || Keyboard.upArrowKey.isPressed)
        {
            ScoreNumber += 5;
            ScoreObect.text = "Score : " + ScoreNumber;
        }
    }
}
