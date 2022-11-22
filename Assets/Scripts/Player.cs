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
            Vector3 initialCameraPos = new Vector3(0.0f, 0.0f, -10.0f);
            CameraEffects.ShakeCamera(Camera.main, 0.5f, 0.1f, initialCameraPos);
        }
    }
}
