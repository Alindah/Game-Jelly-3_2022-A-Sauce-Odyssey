using UnityEngine;
public class OnCollision : MonoBehaviour
{
    private Player player;

    private void Start() 
    {
        player = gameObject.GetComponent<Player>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.health -= 1;
            Destroy(collision.gameObject);
            Debug.Log("Player has been hit, health is now: " + player.health);
            if (player.health <= 0)
                Debug.Log("Game Over");
        }
    }

}
