using UnityEngine;

public class ObjectPoolClient : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject walker = ObjectPool.Instance.PullObject("Walker");
            walker.transform.Translate(Vector3.forward * Random.Range(-5f, 5f));
            walker.transform.Translate(Vector3.right * Random.Range(-5f, 5f));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            object[] objects = FindObjectsOfType(typeof(GameObject));

            foreach (object obj in objects)
            {
                GameObject ob = (GameObject)obj;

                if (ob.gameObject.GetComponent<Walker>() != null)
                {
                    ObjectPool.Instance.PoolObject(ob);
                }
            }
        }
    }
}
