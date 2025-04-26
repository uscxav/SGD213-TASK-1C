using UnityEngine;
using System.Collections;

public class SpawnOverTime : MonoBehaviour
{
    [SerializeField]
    protected GameObject spawnObject;
    [SerializeField]
    protected float spawnDelay = 2f;
    protected Renderer ourRenderer;


    void Spawn()
    {
        // create boundaries for the area the game object can spawn within
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;
        // Randomly pick a point within the spawn object and spawn game object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
