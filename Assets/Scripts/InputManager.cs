using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W)){
            inputVector += Vector2.up;
            Debug.Log("User's Input: up");
        }
        if (Input.GetKey(KeyCode.S)){
            inputVector += Vector2.down;
            Debug.Log("User's Input: down");
        }
        if (Input.GetKey(KeyCode.A)){
            inputVector += Vector2.left;
            Debug.Log("User's Input: left");
        }
        if (Input.GetKey(KeyCode.D)){
            inputVector += Vector2.right;
            Debug.Log("User's Input: right");
        }
        OnMove?.Invoke(inputVector);

    }
}
