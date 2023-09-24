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
    float restTime = 0f;        //�Đ����̎��Ԃ��v��

    // Start is called before the first frame update
    void Start()
    {
        //timescale��1.0�ɃZ�b�g
        Time.timeScale = 1.0f;

        //gametimer�����Z�b�g
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
            //�����t
            controll.GameControll(oreoList, oreoObj, arrowObj);
        }

        //�Đ���
        //0.5�b�ҋ@���Ă��琶��
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
