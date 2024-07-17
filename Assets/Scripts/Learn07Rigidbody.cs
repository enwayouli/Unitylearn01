using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn07Rigidbody : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        #region 刚体添加力的方法
        //1. 添加力
        //相对世界坐标
        //rb.AddForce(Vector3.forward * 10);
        //相对本地坐标
        //rb.AddRelativeForce(Vector3.forward * 10);

        //2. 扭矩力
        //世界
        //rb.AddTorque(Vector3.forward * 10);
        //本地
        //rb.AddRelativeTorque(Vector3.up * 10);

        //3. 速度
        //rb.velocity = Vector3.forward * 5;

        //4. 模拟爆炸
        //rb.AddExplosionForce(10, Vector3.zero, 10);
        #endregion

        #region 力的几种模式
        //计算方式不同,最终移动速度不同
        rb.AddForce(Vector3.forward * 10, ForceMode.VelocityChange);

        //动量定理
        //Ft = mv
        //v = Ft/m
        //F: 力
        //t: 时间
        //m: 质量
        //v: 速度

        //1. Acceleration
        //给物体增加一个持续的加速度, 忽略其质量
        //2. Force
        //给物体添加一个持续的力, 与物体质量有关
        //3. Impulse
        //给物体添加一个瞬间的力, 与质量有关, 忽略时间 默认为1
        //4. VelocityChange
        //给物体添加一个瞬时的速度, 忽略质量, 忽略时间
        #endregion

        //刚体有休眠机制
        if (rb.IsSleeping())
        {
            rb.WakeUp();
        }
    }

    void Update()
    {

    }
}
