using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float minX = -2.5f, maxX = 2.5f;
    [SerializeField] private GameObject rock;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSecondsRealtime(Random.Range(0f, 2f));
        Instantiate(rock, new Vector2(Random.Range(minX,maxX), 6), Quaternion.identity);

        StartCoroutine(SpawnEnemy());
    }
}
