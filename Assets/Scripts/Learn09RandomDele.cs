using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Learn09RandomDele : MonoBehaviour
{
    void Start()
    {
        #region �����
        //Unity�������
        print(Random.Range(0, 100));        //0-99      ������100
        print(Random.Range(1.1f, 99.9f));   //1.1-99.9  ���Ҷ�����

        //C#
        System.Random r = new System.Random();
        #endregion

        #region ί��
        //C#
        System.Action ac = () => { print("a"); };
        //Unity
        UnityAction ua = () => { print("b"); };
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
