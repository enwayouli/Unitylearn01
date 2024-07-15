using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn03Scale : MonoBehaviour
{
    void Start()
    {
        #region 缩放
        //相对世界坐标系
        print(transform.lossyScale);
        //相对本地坐标系
        print(transform.localScale);
        #endregion

        #region 看向
        //看向一个点
        transform.LookAt(Vector3.zero);
        //看向一个对象
        //transform.LookAt(obj.transform);
        #endregion
    }

    void Update()
    {
        
    }
}
