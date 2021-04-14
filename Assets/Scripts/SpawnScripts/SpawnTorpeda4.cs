using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTorpeda4 : MonoBehaviour
{
    public GameObject TorpedaBoss;
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(TorpedaBoss, new Vector3(Random.Range(120f, 110f), 0f, 4f), Quaternion.identity);
            yield return new WaitForSeconds(20f);
        }
    }
}
