using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTorpeda : MonoBehaviour
{
    public GameObject Torpeda;
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(Torpeda, new Vector3(Random.Range(-60f, 60f), 30f, 4f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
