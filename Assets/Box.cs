using CustomPool;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using UnityEngine;

public class Box : MonoBehaviour
{
    public TestPooler pooler;
    private void Awake()
    {
        pooler = GameObject.Find("TestPooler").GetComponent<TestPooler>();
    }
    private void OnMouseDown()
    {
        //PoolOperator.AddToList(this.gameObject, pooler.pool);
        PoolManager.Instance.AddToPool(this.gameObject,EPool.A);
    }

    //private void OnMouseDown()
    //{
    //    TestPooler.poolList.Add(this.gameObject);
    //    this.gameObject.SetActive(false);
    //}
}
