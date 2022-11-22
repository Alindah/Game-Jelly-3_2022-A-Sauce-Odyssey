using UnityEngine;

public class Propel : MonoBehaviour
{
    [SerializeField] private int propelSpeed = 8;

    private void FixedUpdate()
    {
        PropelObject();
    }

    private void PropelObject() {
        transform.position = new Vector2(transform.position.x + propelSpeed * Time.deltaTime, transform.position.y);
    }
}
