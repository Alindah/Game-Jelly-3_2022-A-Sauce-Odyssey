using UnityEngine;

public class Enemy : Entity
{
    private void FixedUpdate()
    {
        MoveZigzag();
    }

    // Enemy moves in a straight line
    private void MoveForward()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }

    // Enemy moves in a zig-zag pattern
    private void MoveZigzag()
    {
        // KAYLA - IMPLEMENT CODE
    }
}
