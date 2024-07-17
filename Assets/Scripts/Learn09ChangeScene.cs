using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Learn09ChangeScene : MonoBehaviour
{
    void Update()
    {
        #region 场景切换
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //切换到场景2
            //需要把场景加载到场景列表中 BuildSettings里添加Scene
            SceneManager.LoadScene("Learn09Scene01");
        }
        #endregion

        #region 退出
        if (Input.GetKeyDown(KeyCode.W))
        {
            //发布游戏后才有用
            Application.Quit();
        }
        #endregion

    }
}
