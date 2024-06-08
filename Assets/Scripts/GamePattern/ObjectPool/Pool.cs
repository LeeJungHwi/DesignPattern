using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// 각 객체 풀 : 풀링 할 오브젝트 관리
public class Pool
{
    // 풀
    private Stack<PoolObject> poolStack = new Stack<PoolObject>();

    // 풀 정보
    private bool isFixedSize;
    private GameObject poolPref;
    private int poolSize;
    private string poolName;

    // 생성자 => 풀 오브젝트를 생성하고 생성된 오브젝트를 풀에 추가
    public Pool(string poolName, GameObject poolPref, int initCount, bool fixedSize)
    {
        this.poolName = poolName;
        this.poolPref = poolPref;
        poolSize = initCount;
        isFixedSize = fixedSize;

        for(int i = 0; i < initCount; i++) AddPool(NewObjectInstance());
    }

    // 생성된 오브젝트 풀에 추가
    private void AddPool(PoolObject po)
    {
        po.gameObject.SetActive(false);
        poolStack.Push(po);
        po.IsPool = true;
    }

    // 풀 오브젝트 생성
    private PoolObject NewObjectInstance()
    {
        GameObject go = (GameObject)GameObject.Instantiate(poolPref);
        PoolObject po = go.GetComponent<PoolObject>();
        if(po == null) po.AddComponent<PoolObject>();
        po.PoolName = poolName;
        return po;
    }

    // 풀 내부 다음 오브젝트 반환
    public PoolObject NextPoolObject(Vector3 pos, Quaternion rot)
    {
        PoolObject po = null;
        if(poolStack.Count > 0) po = poolStack.Pop();
        else if(!isFixedSize)
        {
            poolSize++;
            Debug.Log(string.Format("{0} 풀 크기 증가, 새로운 크기 : {1}", poolName, poolSize));
            po = NewObjectInstance();
        }
        else Debug.LogWarning(poolName + "에 이용 가능한 오브젝트가 없고 풀 크기를 증가 할 수 없음");

        GameObject result = null;
        if(po != null)
        {
            po.IsPool = false;
            result = po.gameObject;
            result.SetActive(true);
            result.transform.position = pos;
            result.transform.rotation = rot;
        }

        return po;
    }

    // 풀에 반환
    public void ReturnPool(PoolObject po)
    {
        if(poolName.Equals(po.PoolName))
        {
            if(po.IsPool) Debug.Log(po.gameObject.name + " 이 이미 풀에 있음");
            else AddPool(po);
        }
        else Debug.LogError(string.Format("올바르지 않은 풀에 추가 시도 중 {0} {1}", po.PoolName, poolName));
    }
}
