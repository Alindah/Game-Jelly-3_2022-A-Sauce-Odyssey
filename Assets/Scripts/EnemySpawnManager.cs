using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    // Game object that the spawner will be attached to
    [SerializeField] GameObject attachedGameObject;
    [SerializeField] float distanceToAttachedObject;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float startDelay;
    [SerializeField] private float repeatedRate;
    [SerializeField] private float minYPos;
    [SerializeField] private float maxYPos;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, repeatedRate);
    }

    void Update()
    {
        AdjustSpawnerPosition();
    }

    void SpawnEnemy()
    {
        Transform gameObjectPos = gameObject.transform;
        float randomYPos = Random.Range(minYPos, maxYPos);
        Instantiate(enemyPrefab, new Vector3(gameObjectPos.position.x, randomYPos, gameObjectPos.position.z), Quaternion.identity);
    }

    // Adjusts the spawner to a given distance in front of the given game object
    void AdjustSpawnerPosition()
    {
        Vector3 position = attachedGameObject.transform.position;
        position.x += distanceToAttachedObject;
        gameObject.transform.position = new Vector3(position.x, 0, 0);
    }
}
