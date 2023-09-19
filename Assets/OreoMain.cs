using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class OreoMain : MonoBehaviour
{
    List<int> oreoList = new();     //oreoList
    List<GameObject> oreoObj = new();       //oreoObjList
    List<GameObject> arrowObj = new();
    OreoGenerate generate;
    OreoControll controll;
    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //oreo generate
        generate = GameObject.Find("Oreo_generate").GetComponent<OreoGenerate>();
        generate.Oreo(oreoList, oreoObj);
        //arrow generate
        generate.Arrow(oreoList, arrowObj);

        controll = GameObject.Find("Oreo_generate").GetComponent<OreoControll>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        controll.GameControll(oreoList, oreoObj, arrowObj);
        //Debug.Log(time);

        //Ä¶¬
        //0.5•b‘Ò‹@‚µ‚Ä‚©‚ç¶¬
        if (oreoList.Count == 0)
        {
            time += Time.deltaTime;
        }

        if (time >= 0.5f)
        {
            time -= 1f;
            generate.ReGenerate(oreoList, oreoObj, arrowObj);
            time = 0;
        }
    }
}
