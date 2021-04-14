using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTorpeda2 : MonoBehaviour
{
    public GameObject Torpeda2;
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(Torpeda2, new Vector3(Random.Range(-60f, 60f), -30f, 4f), Quaternion.identity);
            yield return new WaitForSeconds(8f);
        }
    }
}
