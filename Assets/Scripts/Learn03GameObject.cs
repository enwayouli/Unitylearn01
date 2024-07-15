using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Learn03GameObject : MonoBehaviour
{
    public GameObject obj;      //准备用来克隆的对象
    private void OnEnable()
    {
        #region gameObject中的成员变量
        print(gameObject.name);                 //名字
        print(gameObject.activeSelf);           //是否激活
        print(gameObject.isStatic);             //是否静态
        print(gameObject.layer);                //层级
        print(gameObject.tag);                  //标签
        print(gameObject.transform.position);   //transform
        #endregion

        #region gameObject中的静态方法
        GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);       //创建自带几何体
        GameObject obj2 = GameObject.Find("对象名");                            //查找单个对象        此方法效率低下, 因为他会查找场景中所有对象
        GameObject obj3 = GameObject.FindWithTag("player");                     //通过tag查找对象     如果有多个对象, 无法找到指定对象
        GameObject[] obj4 = GameObject.FindGameObjectsWithTag("player");        //通过tag查找多个对象
        GameObject.FindObjectOfType<Learn03GameObject>();                       //找打场景中挂载的某一个脚本对象 效率更低

        //实例化对象(克隆对象)的方法
        GameObject g = GameObject.Instantiate(obj);
        //删除对象
        GameObject.Destroy(g);
        //Destroy(g, 5);         //第二个参数为延迟时间, 单位秒
        //Destroy(this);                    //删除脚本对象
        //DestroyImmediate(g);              //立即删除

        //过场景不移除
        GameObject.DontDestroyOnLoad(this.gameObject);
        #endregion
        #region gameObject中的成员方法
        //创建空物体
        GameObject obj5 = new GameObject();
        GameObject obj6 = new GameObject(name, typeof(Learn03GameObject), typeof(Learn02BehaviourObj));

        //为对象添加脚本
        obj6.AddComponent<Learn01UnityAttribute>();

        //标签比较
        if (CompareTag("Player"))
        {
            
        }
        if(this.tag == "Player")
        {

        }

        //设置失活激活
        obj6.SetActive(false);

        //次要成员方法, 不建议使用
        //通知自己 执行什么行为
        SendMessage("TestFunc");
        BroadcastMessage("TestFunc");       //让自己和自己的子对象执行
        SendMessageUpwards("TestFunc");     //向父对象和自己发生消息, 并执行
        #endregion
    }
    void TestFunc()
    {

    }
}
