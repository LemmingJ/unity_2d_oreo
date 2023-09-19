using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score = 0;

    //‰Á“_
    public void Add()
    {
        score += 1;
        scoreText.SetText("{0}", score);
    }

    //Œ¸“_
    public void Sub()
    {
        score -= 1;
        scoreText.SetText("{0}", score);
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
