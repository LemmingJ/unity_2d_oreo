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
    GameTimer gameTimer;
    float restTime = 0f;        //再生成の時間を計る

    // Start is called before the first frame update
    void Start()
    {
        //timescaleを1.0にセット
        Time.timeScale = 1.0f;

        //gametimerをリセット
        gameTimer = GameObject.Find("Timer").GetComponent<GameTimer>();
        gameTimer.timeFloat = 15.0f;

        //oreo generate
        generate = GameObject.Find("Oreo_generate").GetComponent<OreoGenerate>();
        generate.Oreo(oreoList, oreoObj);
        //arrow generate
        generate.Arrow(oreoList, arrowObj);

        controll = GameObject.Find("Oreo_generate").GetComponent<OreoControll>();

    }

    // Update is called once per frame
    void Update()
    {
        if (oreoList.Count != 0 && gameTimer.timeFloat > 0)
        {
            //操作受付
            controll.GameControll(oreoList, oreoObj, arrowObj);
        }

        //再生成
        //0.5秒待機してから生成
        if (oreoList.Count == 0)
        {
            restTime += Time.deltaTime;
        }

        if (restTime >= 0.5f)
        {
            generate.ReGenerate(oreoList, oreoObj, arrowObj);
            restTime = 0f;
        }
    }
}
