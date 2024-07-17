using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn09Mouse : MonoBehaviour
{
    public Texture2D cursorImg;
    void Update()
    {
        #region 隐藏鼠标
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Cursor.visible = false;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Cursor.visible = true;
        }
        #endregion

        #region 锁定鼠标

        if (Input.GetKeyDown(KeyCode.E))
        {
            //None: 不锁定
            //Locked: 锁定 鼠标会被限制在屏幕的中心, 还会被隐藏
            //Confined 限制在窗口范围
            Cursor.lockState = CursorLockMode.Confined;
        }
        #endregion
        #region 设置鼠标图片
        //参数1:  光标图片
        //参数2:  偏移位置 相对于图片左上角
        //参数3:  平台支持的光标模式 (硬件或软件)
        Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.Auto);
        #endregion
    }
}
