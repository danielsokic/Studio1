using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] public Rigidbody sphereRigidbody;
    [SerializeField] public float ballSpeed = 5f;
    
    public void MoveBall(Vector2 input){
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
