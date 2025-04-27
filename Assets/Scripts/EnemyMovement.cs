using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// EnemyMovement handles all of the movement specifc state and behaviour for the enemy.
/// </summary>
public class EnemyMovement : EngineBase {



    // local references
    private EnemyMovement enemyMovement;
    

    void Start() {
        // populate ourRigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
        enemyMovement = GetComponent<EnemyMovement>();

    }

    /// <summary>
    /// MoveEnemy takes a direction as a parameter, and applies a force in this provided direction
    /// to ourRigidbody, based on the enemyAcceleration variables and the delta time.
    /// </summary>
    /// <param name="horizontalInput">A direction vector, expected to be a unit vector (magnitude of 1).</param>
    public void MoveEnemy(Vector2 direction) {
        enemyMovement.Accelerate(direction);
    }
}
