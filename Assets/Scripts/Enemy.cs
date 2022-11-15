using UnityEngine;

public class Enemy : Entity
{
    public int movementDirection = 1;

    private void FixedUpdate()
    {
        MoveEnemyZigZag();
        DestroyObjectBoundary.destroyOutOfBoundsEntity(this);
    }

    // General Zig-zag Enemy movement
    private void MoveEnemyZigZag()
    {
        if (transform.position.y >= maxYBoundary)
        {
            movementDirection = -1;
        }
        else if (transform.position.y <= minYBoundary)
        {
            movementDirection = 1;
        }
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y + movementDirection * speed * Time.deltaTime);
    }
}
