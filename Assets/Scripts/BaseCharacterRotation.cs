using UnityEngine;

public class BaseCharacterRotation : MonoBehaviour
{
    [SerializeField]
    protected float sensitivity = 1.5f;
    [SerializeField]
    protected float smooth = 10;
    [SerializeField]
    protected Transform character;
    protected float yRotation;
    protected float xRotation;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    protected void Update()
    {
        yRotation += Input.GetAxis("Mouse X") * sensitivity;
        xRotation -= Input.GetAxis("Mouse Y") * sensitivity;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }

    protected void RotateCharacter()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(xRotation, yRotation, 0), Time.deltaTime * smooth);
        character.rotation = Quaternion.Lerp(character.rotation, Quaternion.Euler(0, yRotation, 0), Time.deltaTime * smooth);
    }
}
