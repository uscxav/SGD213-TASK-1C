using UnityEngine;
using System.Collections;

/// <summary>
/// PlayerMovementScript handles all of the movement specifc state and behaviour for the player.
/// </summary>
public class PlayerMovement : EngineBase
{
   


    // local references
    private PlayerMovement playerMovement;

    void Start()
    {
        // populate ourRigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
        playerMovement = GetComponent<PlayerMovement>();
    }
 
    

    public void MovePlayer(Vector2 direction)
    {
        // a horizontalInput of 0 has no effect, as we want our ship to drift
        if (direction.magnitude != 0)
        {
            playerMovement.Accelerate(direction);
        }
    }
}
