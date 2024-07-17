using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Learn09RandomDele : MonoBehaviour
{
    void Start()
    {
        #region 随机数
        //Unity的随机数
        print(Random.Range(0, 100));        //0-99      不包含100
        print(Random.Range(1.1f, 99.9f));   //1.1-99.9  左右都包含

        //C#
        System.Random r = new System.Random();
        #endregion

        #region 委托
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
