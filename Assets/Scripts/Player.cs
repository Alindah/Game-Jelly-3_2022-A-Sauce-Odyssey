using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    [SerializeField] private GameObject meatball;
    private Keyboard kb;

    private void Start()
    {
        // Set keyboard
        kb = Keyboard.current;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
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
        
        // we need to fix this. currently fires a meatball for every frame that spacebar is depressed 
        if (kb.spaceKey.IsPressed())
            Instantiate(meatball, transform.position, transform.rotation, gameObject.transform);
    }
}
