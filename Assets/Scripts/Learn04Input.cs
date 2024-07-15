using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn04Input : MonoBehaviour
{
    void Update()
    {
        #region 鼠标在屏幕的位置
        //原点在屏幕左下角(0,0), 返回值Vector3的z为0
        //print(Input.mousePosition);
        #endregion

        #region 检查鼠标输入
        //鼠标按下一瞬间
        //0左键, 1右键, 2中建
        if (Input.GetMouseButtonDown(0))
        {
            print("按下鼠标左键");
        }
        //鼠标抬起
        if (Input.GetMouseButtonUp(0))
        {
            print("松开鼠标左键");
        }
        //鼠标长按
        if (Input.GetMouseButton(0))
        {
            print("长按鼠标左键");
        }

        //中建滚动
        //返回值的y = -1下, 0/1上
        print(Input.mouseScrollDelta);
        #endregion

        #region 检测键盘输入
        //键盘按下
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W按下");
        }
        //传入字符串的重载
        //这里传入的字符串不能为大写
        if (Input.GetKeyDown("q"))
        {
            print("Q按下");
        }
        //抬起
        if (Input.GetKeyUp(KeyCode.W))
        {
            print("W抬起");
        }
        //长按
        if (Input.GetKey(KeyCode.W))
        {
            print("W长按");
        }
        #endregion

        #region 检测默认轴输入
        //wa -1到1的值, sd -1到1的值
        //Vertical  Horizontal
        //键盘AD
        print(Input.GetAxis("Horizontal"));
        //键盘SW
        print(Input.GetAxis("Vertical"));

        //鼠标横向
        print(Input.GetAxis("Mouse X"));
        print(Input.GetAxis("Mouse Y"));//竖向

        //GetAxis 和 GetAxisRaw 使用相同,GetAxisRaw的返回值只会是-1 , 0, 1 GetAxis有渐变
        #endregion

        #region 其他(触摸 手柄 陀螺仪)
        //任意键
        if (Input.anyKey) { }
        if (Input.anyKeyDown)
        {
            //这一帧的键盘输入
            print(Input.inputString);
        }

        //手柄输入
        //得到所有按钮名
        string[] strs = Input.GetJoystickNames();
        //某一个手柄键按下
        if (Input.GetButton("Jump")) { }
        if (Input.GetButtonDown("Jump")) { }
        if (Input.GetButtonUp("Jump")) { }

        //移动设备触摸
        if(Input.touchCount > 0)
        {
            Touch t1 = Input.touches[0];
            //位置
            print(t1.position);
            //相对于上次位置的变化
            print(t1.deltaPosition);
        }
        //是否启用多点触控
        Input.multiTouchEnabled = false;

        //陀螺仪
        Input.gyro.enabled = true;
        //重力加速度向量
        print(Input.gyro.gravity);
        //旋转速度
        print(Input.gyro.rotationRate);
        //陀螺仪 当前的旋转四元数
        print(Input.gyro.attitude);
        #endregion

    }
}
