﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bombPrefab;
    private float maxX = 2.55f;
    private float minX = -2.55f;
    void Start()
    {
        StartCoroutine(SpawnBombs());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnBombs()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        Instantiate(bombPrefab, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity);

        StartCoroutine(SpawnBombs());
    }
}
