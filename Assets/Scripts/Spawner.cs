using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float minX = -2.5f, maxX = 2.5f;

    public GameObject rock;

    // Start is called before the first frame update

    private void Awake()
    {
        rock = GameObject.FindGameObjectWithTag("Enemy");
    }
    void Start()
    {
        /*rock = GameObject.FindGameObjectWithTag("Enemy").GetComponent<GameObject>();*/
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSecondsRealtime(Random.Range(0f, 2f));
        Instantiate(rock, new Vector2(Random.Range(minX,maxX), 6), Quaternion.identity);

        StartCoroutine(SpawnEnemy());
    }
}
