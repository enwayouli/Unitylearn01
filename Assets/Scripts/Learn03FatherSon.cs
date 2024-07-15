using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn03FatherSon : MonoBehaviour
{
    void Start()
    {
        #region 获取父对象
        print(transform.parent);
        //设置父对象
        //transform.parent = null;
        //参数:(父对象, 是否保留世界坐标位置信息)
        transform.SetParent(GameObject.Find("Father").transform, true);


        //断绝与子对象关系
        //transform.DetachChildren();

        #endregion

        #region 获取子对象
        transform.Find("Grandson");
        //遍历子对象 transform.childCount
        //transform.GetChild(0)
        for (int i = 0; i < transform.childCount; i++)
        {
            print(transform.GetChild(i).name);
        }
        #endregion

        #region 子对象操作
        //判断是否为某个对象的子对象
        if (transform.IsChildOf(transform.parent))
        {
            
        }

        //得到作为子对象的编号
        print(transform.GetSiblingIndex());

        //设置为第一个子对象
        transform.SetAsFirstSibling();
        //transform.SetAsLastSibling();

        //设置编号
        transform.SetSiblingIndex(0);
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
