using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Generator : MonoBehaviour
{
    public GameObject platformPrefabLevel2;

    public int numberOfPlatformsLevel2 = 30;

    public float levelWidth = 2f;
    public float minY = 5f;
    public float maxY = 15f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatformsLevel2; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefabLevel2, spawnPosition, Quaternion.identity);
        }   
    }

}
