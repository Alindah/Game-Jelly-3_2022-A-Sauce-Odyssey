using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        // Set keyboard
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

        if (kb.oKey.IsPressed())
        {
            GameObject mainCamera = GameObject.Find("Main Camera");
            CameraEffects cameraEffects = mainCamera.GetComponent<CameraEffects>();
            cameraEffects.ShakeCamera(new Vector3(0, 0, -1.0f));
        }
    }
}
