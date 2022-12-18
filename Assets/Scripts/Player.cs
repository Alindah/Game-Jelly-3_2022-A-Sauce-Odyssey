using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    [Header("MEATBALL PROJECTILES")]
    [SerializeField] private GameObject projectiles;
    [SerializeField] private GameObject meatball;
    [SerializeField] private float meatballCooldown = 0.5f;
    private float lastMeatballFiredTime = 0;

    private Keyboard kb;

    private void Start()
    {
        // Set keyboard
        kb = Keyboard.current;
    }

    private void FixedUpdate()
    {
        PlayerControls();
    }

    private void PlayerControls()
    {
        Keyboard kb = Keyboard.current;

        // Return if no keyboard detected
        if (kb == null)
            return;

        // If user presses UP arrow or W key, player moves up
        if (kb.upArrowKey.IsPressed() || kb.wKey.IsPressed())
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);

        // If user presses DOWN arrow or S key, player moves down
        if (kb.downArrowKey.IsPressed() || kb.sKey.IsPressed())
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);


        // Fires a meatball when spacebar is pressed
        if (kb.spaceKey.IsPressed())
        {
            if (meatballCooldown < Time.time - lastMeatballFiredTime)
            {
                lastMeatballFiredTime = Time.time;
                Instantiate(meatball, transform.position, transform.rotation, projectiles.transform);
            }
        }

        // Shakes main camera
        if (kb.oKey.IsPressed())
        {
            GameObject mainCamera = GameObject.Find("Main Camera");
            CameraEffects cameraEffects = mainCamera.GetComponent<CameraEffects>();
            cameraEffects.ShakeCamera(new Vector3(0, 0, -1.0f));
        }
    }
}
