using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public void EndGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
     Application.Quit();
#endif
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
