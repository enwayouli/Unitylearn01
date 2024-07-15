using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn03TransformChange : MonoBehaviour
{
    void Start()
    {
        #region 世界坐标转本地坐标
        //世界坐标系的点 转换 为相对本地坐标系的点
        print(Vector3.forward);
        print("转化后:" + transform.InverseTransformPoint(Vector3.forward));

        //世界坐标系方向 转换 为相对本地坐标系的方向
        print("转换后的方向:"+ transform.InverseTransformDirection(Vector3.forward));

        //受到缩放影响
        print("转换后的方向(受到缩放影响):" + transform.InverseTransformVector(Vector3.forward));
        #endregion

        #region 本地坐标转世界坐标
        print("本地转世界点:" + transform.TransformPoint(Vector3.forward));
        print("本地转世界方向:" + transform.TransformDirection(Vector3.forward));
        //受到缩放影响
        print("本地转世界方向:" + transform.TransformVector(Vector3.forward));
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
