using UnityEngine;

public class Propel : MonoBehaviour
{
    [SerializeField] private int propelSpeed = 8;
    [SerializeField] private int launchAngle = 45;
    private float launchAngleRadians;

    private void Start() 
    {
        launchAngleRadians = launchAngle * 2 * Mathf.PI / 360;
    }

    private void FixedUpdate()
    {
        PropelObject();
    }

    private void PropelObject() {
        float xChange = Mathf.Cos(launchAngleRadians) * propelSpeed;
        float yChange = Mathf.Sin(launchAngleRadians) * propelSpeed;
        transform.position = new Vector2(transform.position.x + xChange * Time.deltaTime, transform.position.y + yChange * Time.deltaTime);
    }
}
