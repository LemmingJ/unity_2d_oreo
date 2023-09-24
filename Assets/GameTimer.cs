using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float timeFloat = 15.0f;     //カウントダウンタイマー（これをそのまま表示）
    public TextMeshProUGUI timeText;
    GameOver gameover;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Time.scale = 0で停止
    void FixedUpdate()
    {
        timeFloat -= Time.deltaTime;
        timeText.SetText("{0:00.00}", timeFloat);

        if (timeFloat < 0)
        {
            Debug.Log("gameover");
            gameover = GameObject.Find("OreoGameOver").GetComponent<GameOver>();
            gameover.Gameover();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFloat < 0)
        {
            Time.timeScale = 0;
            timeFloat = 0;
        }
    }
}
