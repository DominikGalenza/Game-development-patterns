using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : Singleton<ObjectPool>
{
    public GameObject[] objectsToPool;
    public List<GameObject>[] pooledObjects;
    public int[] amountToBuffer;
    public int defaultBufferAmount = 3;

    protected GameObject containerObject;

    private void Start()
    {
        containerObject = new GameObject("ObjectPool");
        pooledObjects = new List<GameObject>[objectsToPool.Length];
        int i = 0;

        foreach (GameObject obj in objectsToPool)
        {
            pooledObjects[i] = new List<GameObject>();
            int bufferAmount;

            if (i < amountToBuffer.Length)
            {
                bufferAmount = amountToBuffer[i];
            }
            else
            {
                bufferAmount = defaultBufferAmount;
            }

            for (int n = 0; n < bufferAmount; n++)
            {
                GameObject newObject = Instantiate(obj) as GameObject;
                newObject.name = obj.name;
                PoolObject(newObject);
            }
        }
    }

    public GameObject PullObject(string objectType)
    {
        bool onlyPooled = false;

        for (int i = 0; i < objectsToPool.Length; i++)
        {
            GameObject prefab = objectsToPool[i];

            if (prefab.name == objectType)
            {
                if (pooledObjects[i].Count > 0)
                {
                    GameObject pooledObject = pooledObjects[i][0];
                    pooledObject.SetActive(true);
                    pooledObject.transform.parent = null;

                    pooledObjects[i].Remove(pooledObject);

                    return pooledObject;
                }
                else if (!onlyPooled)
                {
                    return Instantiate(objectsToPool[i]) as GameObject;
                }

                break;
            }  
        }

        return null;
    }    

    public void PoolObject(GameObject obj)
    {
        for (int i = 0; i < objectsToPool.Length; i++)
        {
            if (objectsToPool[i].name == obj.name)
            {
                obj.SetActive(false);
                obj.transform.parent = containerObject.transform;
                pooledObjects[i].Add(obj);
                return;
            }
        }

        Destroy(obj);
    }
}
