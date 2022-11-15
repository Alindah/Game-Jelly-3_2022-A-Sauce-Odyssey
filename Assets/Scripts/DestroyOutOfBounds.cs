using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [Header("BOUNDARIES")]
    public int minXDestroyBoundary = -15;
    public int maxXDestroyBoundary = 15;
    public int minYDestroyBoundary = -10;
    public int maxYDestroyBoundary = 10;

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
