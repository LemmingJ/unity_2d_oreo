using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameGameOver : MonoBehaviour
{
    public GameObject canvas;
    public GameObject gameoverText;

    public void Gameover()
    {
        GameObject gameover = (GameObject)Instantiate(gameoverText);
        gameover.transform.SetParent(canvas.transform, false);
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
