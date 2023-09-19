using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreoDecide : MonoBehaviour
{
    int size;

    public void Success (List<int> oreoList, List<GameObject> oreoObj, List<GameObject> arrowObj)
    {
        size = oreoList.Count - 1;      //リストの一番上をリムーブ
        oreoList.RemoveAt(size);

        Destroy(oreoObj[size]);         //オブジェクトリストの一番上をリムーブ
        oreoObj.RemoveAt(size);

        Destroy(arrowObj[size]);
        arrowObj.RemoveAt(size);        //矢印削除

        GameScore gameScore = GameObject.Find("Oreo_generate").GetComponent<GameScore>();
        gameScore.Add();  //スコア加算メソッド呼び出し
    }

    public void Unsuccess ()
    {
        GameScore gameScore = GameObject.Find("Oreo_generate").GetComponent<GameScore>();
        gameScore.Sub();  //減算
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
