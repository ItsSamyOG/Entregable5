using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;
    private float startTime = 0.5f;
    private float repeatRate = 1f;

    //El oobstacle aparacera a los 0.5 y cada segundo
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startTime, repeatRate);
    }

    //  El siguiente obstáculo se instanciará a una altura aleatoria a 50  metros más adelante que el anterior.
    public Vector3 RandomSpawnPosition()
    {
        randomY = Random.Range(-10, 10);
        return new Vector3(0, randomY, spawnPos.z + 50);
    }

    // Instancia el prefab obstaclePrefab en la posición spawnPos y con la rotación del prefab obstaclePrefab
    public void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos,
           obstaclePrefab.transform.rotation);

        spawnPos = RandomSpawnPosition();

        
    }
}
