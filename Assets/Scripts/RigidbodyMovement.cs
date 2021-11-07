using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyMovement : BaseCharacterMovement
{
   private new Rigidbody rigidbody;
   private void Start() => rigidbody = GetComponent<Rigidbody>();
   private void FixedUpdate() => rigidbody.MovePosition(transform.position + movementVector * movementSpeed * Time.fixedDeltaTime);
}
