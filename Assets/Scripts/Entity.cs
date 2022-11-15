using UnityEngine;

/* This Entity class represents "organic" characters,
 * including the player and the enemies
 */
public class Entity : MonoBehaviour
{
    [Header("ATTRIBUTES")]
    public float speed;
    public int health;
    public int minYBoundary;
    public int maxYBoundary;

}
