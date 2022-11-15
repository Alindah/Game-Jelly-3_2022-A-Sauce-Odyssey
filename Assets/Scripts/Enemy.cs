using UnityEngine;

public class Enemy : Entity
{
    public int movementDirection = 1;

    private void FixedUpdate()
    {
        MoveForward();
        //MoveEnemyZigZag();
        DestroyObjectBoundary.DestroyOutOfBoundsEntity(this);
    }

    // Enemy moves in a straight line
    private void MoveForward()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }

    // General Zig-zag Enemy movement
    private void MoveEnemyZigZag()
    {
        if (transform.position.y >= maxYBoundary) movementDirection = -1;
        else if (transform.position.y <= minYBoundary) movementDirection = 1;
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y + movementDirection * speed * Time.deltaTime);
    }
}
