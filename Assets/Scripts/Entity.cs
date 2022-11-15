using UnityEngine;

/* This Entity class represents "organic" characters,
 * including the player and the enemies
 */
public class Entity : MonoBehaviour
{
    public float speed;
    public int health;
    public int minYBoundary;
    public int maxYBoundary;
    public int minXDestroyBoundary = -15;
    public int maxXDestroyBoundary = 15;
    public int minYDestroyBoundary = -10;
    public int maxYDestroyBoundary = 10;

}
