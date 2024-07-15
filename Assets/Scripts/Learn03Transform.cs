using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn03Transform : MonoBehaviour
{
    private void OnEnable()
    {
        /*
         * transform.position
         * transform.localPosition
         * transform.forward
         * 
         * Vector3.Distance(a, b);
         */
        Vector3 v1 = new Vector3();
        Vector3 v2 = new Vector3(10, 10, 10);
        //计算两点距离
        print(Vector3.Distance(v1, v2));

        //相对世界坐标系
        print("相对世界坐标系" + transform.position);
        //相对父对象
        print("相对父对象" + transform.localPosition);

        //不能单独改,只能整体改
        //transform.localPosition.x = 0;
        //transform.localPosition = new Vector3();

        //对象当前的各朝向
        //面朝向
        print("对象当前的各朝向" + transform.forward);

    }

    void Update()
    {
        //位移
        //路程 = 方向 * 速度 * 时间
        //transform.position += transform.forward * 1 * Time.deltaTime;   //Vector3.forward

        //方式2. Api
        //transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.World);
        transform.Translate(transform.forward * 1 * Time.deltaTime, Space.World);
    }
}
