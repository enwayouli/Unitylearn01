using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn07Trigger : MonoBehaviour
{

    #region 物理碰撞检测函数
    //碰撞触发接触时触发 自动执行函数
    private void OnCollisionEnter(Collision collision)
    {
        //碰撞器 collision.collider
        //collision.gameObject
        //
        //碰撞点数相关
        //ContactPoint[] contacts = collision.contacts;
        print("碰撞器:我:"+gameObject.name);
        print("碰撞器:对象:" + collision.gameObject.name);
    }
    //碰撞结束分离
    private void OnCollisionExit(Collision collision)
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
    #endregion


    #region  触发器检测函数
    private void OnTriggerEnter(Collider other)
    {
        print("触发器:我:" + gameObject.name);
        print("触发器:对象:" + other.gameObject.name);
    }
    #endregion

}
