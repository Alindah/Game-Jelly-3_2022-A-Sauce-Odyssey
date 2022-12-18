using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [Header("BOUNDARIES")]

    [SerializeField] private int minXDestroyBoundary = -15;
    [SerializeField] private int maxXDestroyBoundary = 15;
    [SerializeField] private int minYDestroyBoundary = -10;
    [SerializeField] private int maxYDestroyBoundary = 10;

    private void Update()
    {
        DestroyOutOfBoundsEntity();
    }

    private void DestroyOutOfBoundsEntity ()
    {
        if (transform.position.x > maxXDestroyBoundary || 
            transform.position.x < minXDestroyBoundary || 
            transform.position.y > maxYDestroyBoundary || 
            transform.position.y < minYDestroyBoundary )
        {
            Destroy(gameObject);
        }
    }
}
