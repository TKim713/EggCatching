using UnityEngine;
using UnityEngine.InputSystem; // Import Input System

public class BasketController : MonoBehaviour
{
    public float moveSpeed = 10f;

    private void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}
