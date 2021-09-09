using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numberOfPlat = 50;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;



    void Start()
    {
        Vector3 spawnPos=new Vector3();

        for(int i = 0; i < numberOfPlat; i++)
        {
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(levelWidth, -levelWidth);
            Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
