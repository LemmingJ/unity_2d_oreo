using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreoControll : MonoBehaviour
{
    int i = 1;

    //“ü—Í”»’è
    public void GameControll (List<int> list, List<GameObject> oreoObj, List<GameObject> arrowObj)
    {
        OreoDecide od = GameObject.Find("Oreo_generate").GetComponent<OreoDecide>();    ////ok”»’è

        //UpArrow >> oreo_ue
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (list[(list.Count - i)] == 0)
            {
                Debug.Log("ok");
                od.Success(list, oreoObj, arrowObj);     //ok‚Ì‚Æ‚«ˆê”Ôã‚ğíœ
            } else
            {
                Debug.Log("no");
                od.Unsuccess();
            }
        }

        //LeftArrow >> oreo_naka
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (list[(list.Count - i)] == 1)
            {
                Debug.Log("ok");
                od.Success(list, oreoObj, arrowObj);     //ok‚Ì‚Æ‚«ˆê”Ôã‚ğíœ
            }  else
            {
                Debug.Log("no");
                od.Unsuccess();
            }
        }

        //RightArrow >> oreo_sita
        if (Input.GetKeyDown (KeyCode.RightArrow))
        {
            if (list[(list.Count - i)] == 2)
            {
                Debug.Log("ok");
                od.Success(list, oreoObj, arrowObj);     //ok‚Ì‚Æ‚«ˆê”Ôã‚ğíœ
            }
            else
            {
                Debug.Log("no");
                od.Unsuccess();
            }
        }

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
