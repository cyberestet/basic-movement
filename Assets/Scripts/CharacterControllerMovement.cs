using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerMovement : BaseCharacterMovement
{
    private CharacterController characterController;
    private void Start() => characterController = GetComponent<CharacterController>();
    private new void Update()
    {
        base.Update();
        characterController.Move(movementVector * movementSpeed * Time.deltaTime);
    }
}
