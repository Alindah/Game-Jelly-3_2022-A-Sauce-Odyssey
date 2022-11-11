using UnityEngine;

public class Enemy : Entity
{
    private void FixedUpdate()
    {
        //MoveForward();
        MoveDiagonallyUpwards();
    }

    // Enemy moves in a straight line
    private void MoveForward()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }

    // Enemy moves upward diagonally
    private void MoveDiagonallyUpwards()
    {
        // KAYLA - IMPLEMENT CODE
    }
}
