using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : SpawnOverTime
{
    // Start is called before the first frame update
    void Start()
    {
        // get ourRenderer, make invisible.
        ourRenderer = GetComponent<Renderer>();
        ourRenderer.enabled = false;
        // continously spawn game object with delay
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }



}
