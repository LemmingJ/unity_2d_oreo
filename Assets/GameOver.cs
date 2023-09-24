using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject canvas;
    public GameObject gameoverText;
    public GameObject gameoverScreen;
    public GameObject gameoverButton;

    public void Gameover()
    {
        //GameOver表示
        GameObject gameover = (GameObject)Instantiate(gameoverText);
        gameover.transform.SetParent(canvas.transform, false);
        //半透明の白い背景
        Instantiate(gameoverScreen);

        //リトライボタン
        GameObject retry = (GameObject)Instantiate(gameoverButton);
        retry.transform.SetParent(canvas.transform, false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
