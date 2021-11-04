using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubePooler : MonoBehaviour
{
    // Start is called before the first frame update

    //public GameObject cubePrefab;

    public GameObject redPrefab;
    public GameObject greenPrefab;
    public GameObject yellowPrefab;

    public int size = 50;


    public List<GameObject> pools;


    void Awake()
    {
        for (int i = 0; i < size; i++)
        {
            var point = new Vector3(
                               Random.Range(-1f, 1f),
                               Random.Range(0f, 1f),
                               Random.Range(-1f, 1f));

            if (i % 3 == 0)
            {
                GameObject obj = Instantiate(redPrefab, point, Quaternion.identity);
                pools.Add(obj);
            }

            if (i % 3 == 1)
            {
                GameObject obj = Instantiate(greenPrefab, point, Quaternion.identity);
                pools.Add(obj);
            }

            if (i % 3 == 2)
            {
                GameObject obj = Instantiate(yellowPrefab, point, Quaternion.identity);
                pools.Add(obj);
            }
        }
    }
    
    /*
    private void Start()
    {
        Instantiate(hapticPrefab, Vector3.zero, Quaternion.identity);
    }*/

}


