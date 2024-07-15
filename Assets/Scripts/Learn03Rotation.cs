using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn03Rotation : MonoBehaviour
{
    void Start()
    {
        #region 角度相关
        //相对世界坐标角度
        print(transform.eulerAngles);

        //相对父对象
        print(transform.localEulerAngles);
        #endregion

    }

    void Update()
    {
        #region 旋转相关
        //自转
        //参数一 相当于 旋转角度
        //参数二 默认不填 相对于自己坐标系
        //transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
        //transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime, Space.World);

        //相对于某个轴 转多少度
        //参数一 轴
        //参数二 角度
        //参数三 相对于本身还是世界 Space.World
        //transform.Rotate(Vector3.up, 10 * Time.deltaTime);

        //相对于某一个点
        //参数: (相对于哪一个点, 相对于哪一个点的哪一个轴, 转的度数(速度 * 时间))
        transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
        #endregion
    }
}
