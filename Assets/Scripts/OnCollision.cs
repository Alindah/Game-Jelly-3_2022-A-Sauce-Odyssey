using UnityEngine;
public class OnCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.GetComponent<Player>().health -= 1;
            Destroy(collision.gameObject);
            Debug.Log("Player has been hit, health is now: " + gameObject.GetComponent<Player>().health);
        }
    }

}
