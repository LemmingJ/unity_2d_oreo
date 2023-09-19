using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

public class OreoGenerate : MonoBehaviour
{
    public GameObject oreo_ue;      //oreo object
    public GameObject oreo_naka;
    public GameObject oreo_sita;
    GameObject oreo_rnd;

    public GameObject arrow_up;     //arrow
    public GameObject arrow_left;
    public GameObject arrow_right;
    GameObject arrow_d;

    public float space = 0.5f;              //spaces of oreo    

    public void Oreo (List<int> oreoList, List<GameObject> oreoObj)
    {
        int n;      //number of oreos
        int type;                //types of oreo
        float oreo_y = -4.5f;    //y-coordinate
        GameObject oreo;

        n = new System.Random().Next(3, 11);

        //oreo generation
        for (int i = 0; i < n; i++)
        {

            type = new System.Random().Next(0, 3);

            switch (type)
            {
                case 0:
                    oreo_rnd = oreo_ue;
                    oreoList.Add(0); break;

                case 1:
                    oreo_rnd = oreo_naka;
                    oreoList.Add(1); break;

                case 2:
                    oreo_rnd = oreo_sita;
                    oreoList.Add(2); break;
            }

            Vector3 pos = new(0f, oreo_y, 0f);
            //インスタンス化したオブジェクトへの参照が oreo に入る
            oreo = Instantiate(oreo_rnd, pos, Quaternion.identity);

            //oreoObj配列にoreoを入れる
            oreoObj.Add(oreo);

            //インスタンス化したオブジェクトのSortingOrderをカウンターの値にする
            oreo.GetComponent<SpriteRenderer>().sortingOrder = i + 1;

            oreo_y += space;

        }
    }

    public void Arrow (List<int> list, List<GameObject> arrowObj)
    {
        float arrow_y = -4.5f;    //y-coordinate
        GameObject arrow;

        for (int i = 0; i < list.Count; i++)
        {

            //Debug.Log("arrow" + list[i]);

            switch (list[i])
            {
                case 0: arrow_d = arrow_up; break;
                case 1: arrow_d = arrow_left; break;
                case 2: arrow_d = arrow_right; break;
            }

            Vector3 pos = new(3.3f, arrow_y, 0);
            arrow = Instantiate(arrow_d, pos, Quaternion.identity);

            arrowObj.Add(arrow);

            arrow.GetComponent<SpriteRenderer>().sortingOrder = i + 1;

            arrow_y += space;
        }
    }

    //再生成
    public void ReGenerate(List<int> oreoList, List<GameObject> oreoObj, List<GameObject> arrowObj)
    {
        //oreo generate
        OreoGenerate generate = GameObject.Find("Oreo_generate").GetComponent<OreoGenerate>();
        generate.Oreo(oreoList, oreoObj);
        //arrow generate
        generate.Arrow(oreoList, arrowObj);
    }
}
