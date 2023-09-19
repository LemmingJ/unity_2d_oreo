using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreoDecide : MonoBehaviour
{
    int size;

    public void Success (List<int> oreoList, List<GameObject> oreoObj, List<GameObject> arrowObj)
    {
        size = oreoList.Count - 1;      //���X�g�̈�ԏ�������[�u
        oreoList.RemoveAt(size);

        Destroy(oreoObj[size]);         //�I�u�W�F�N�g���X�g�̈�ԏ�������[�u
        oreoObj.RemoveAt(size);

        Destroy(arrowObj[size]);
        arrowObj.RemoveAt(size);        //���폜

        GameScore gameScore = GameObject.Find("Oreo_generate").GetComponent<GameScore>();
        gameScore.Add();  //�X�R�A���Z���\�b�h�Ăяo��
    }

    public void Unsuccess ()
    {
        GameScore gameScore = GameObject.Find("Oreo_generate").GetComponent<GameScore>();
        gameScore.Sub();  //���Z
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
