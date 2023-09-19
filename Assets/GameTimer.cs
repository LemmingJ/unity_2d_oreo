using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float timeFloat;
    public TextMeshProUGUI timeText;
    GameGameOver ggo;
    
    // Start is called before the first frame update
    void Start()
    {
        timeFloat = 15.0f;
    }

    //Time.scale = 0Ç≈í‚é~
    void FixedUpdate()
    {
        timeFloat -= Time.deltaTime;
        timeText.SetText("{0:00.00}", timeFloat);

        if (timeFloat < 0)
        {
            Debug.Log("gameover");
            ggo = GameObject.Find("OreoGameOver").GetComponent<GameGameOver>();
            ggo.Gameover();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFloat < 0)
        {
            Time.timeScale = 0;
        }
    }
}
