using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTorpeda3 : MonoBehaviour
{
    public GameObject Torpeda3;
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(Torpeda3, new Vector3(Random.Range(-120f, -110f), 0f, 4f), Quaternion.identity);
            yield return new WaitForSeconds(16f);
        }
    }
}
