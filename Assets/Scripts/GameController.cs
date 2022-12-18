using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform spawnerContainer;

    private Keyboard kb;

    // Start is called before the first frame update
    private void Start()
    {
        kb = Keyboard.current;
    }

    // Update is called once per frame
    private void Update()
    {
        if (kb.iKey.isPressed)
            Instantiate(enemyPrefab, spawnerContainer);
    }
}
