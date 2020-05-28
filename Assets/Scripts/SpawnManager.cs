using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public float minTime = 1f;
    public float maxTime = 2f;
    void Start()
    {
        StartCoroutine(SpawnCoroutine(0));
    }

    IEnumerator SpawnCoroutine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(itemPrefabs[Random.Range(0, itemPrefabs.Length)], transform.position,Quaternion.identity);
        StartCoroutine(SpawnCoroutine(Random.Range(minTime, maxTime)));
    }

}
