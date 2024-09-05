using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Prefab dizisi

    private float startDelay = 1.0f;
    private float spawnInterval = 6.5f;

    private float minSpawnRangeZ = 35;
    private float spawnRangeZ = 45;
    private float spawnPosX = 25;


    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        // Update fonksiyonunuz boş olmalı veya gerekli kodları içermelidir.
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3( spawnPosX, 0, Random.Range(minSpawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);


    }

}

        