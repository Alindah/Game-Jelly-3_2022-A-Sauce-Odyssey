using UnityEngine;
public class OnCollision : MonoBehaviour
{
    private Player player;

    private void Start() {
        {
           player = gameObject.GetComponent<Player>(); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.health -= 1;
            Destroy(collision.gameObject);
            Debug.Log("Player has been hit, health is now: " + gameObject.GetComponent<Player>().health);
            if (player.health <= 0)
                Debug.Log("Game Over");
        }
    }

}
