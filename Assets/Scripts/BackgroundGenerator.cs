using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour
{
    public GameObject[] backgroundSprites;

    // Use this for initialization
    void Start()
    {
        /*backgroundSpriteRenderer.sprite = backgroundSprites[Random.Range(0, backgroundSprites.Length)];*/
        Instantiate(backgroundSprites[Random.Range(0, backgroundSprites.Length)], new Vector2(0f, 0f), Quaternion.identity);
    }
}
