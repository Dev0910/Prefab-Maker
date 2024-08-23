using CustomPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestPooler : MonoBehaviour
{
    public Pool pool;
    private float count;
    private void Start()
    {
        count = 0;
        //PoolOperator.InitalSpawn(pool, this.transform);
        InvokeRepeating("EachSec", 1f, 1f);
    }

    private void EachSec()
    {
        GameObject temp = PoolManager.Instance.TakeFromPool(EPool.A);
        if (temp != null)
        {
            temp.transform.position = this.transform.position + new Vector3(count, 0, 0);
            count += 2;
        }
        else
        {
            Debug.LogWarning(EPool.A + " Pool emty");
        }
    }

    //public Pool pool;
    //GameObject temp;
    //private void Start()
    //{
    //    pool.InitalSpawn(this.transform);
    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        temp = pool.TakeFromList();
    //    }
    //}
}
