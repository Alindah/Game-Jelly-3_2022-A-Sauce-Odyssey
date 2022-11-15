using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectBoundary : MonoBehaviour
{
    public static void destroyOutOfBoundsEntity(Entity entity)
    {
        if (entity.transform.position.x > entity.maxXDestroyBoundary || 
            entity.transform.position.x < entity.minXDestroyBoundary || 
            entity.transform.position.y > entity.maxYDestroyBoundary || 
            entity.transform.position.y < entity.minYDestroyBoundary )
        {
            Destroy(entity.gameObject);
        }
    }
}
