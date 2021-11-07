using UnityEngine;

public class BaseCharacterMovement : MonoBehaviour
{
    [SerializeField]
    protected float movementSpeed = 6;
    protected Vector3 movementVector;
    protected void Update() => movementVector = (transform.right * Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") * transform.forward).normalized;
}
