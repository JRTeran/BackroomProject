using UnityEngine;

public class ControlFPS : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Movimiento con teclado
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDirection = new Vector3(horizontalInput, 0f, verticalInput);
        inputDirection = transform.TransformDirection(inputDirection);
        moveDirection = inputDirection * moveSpeed;

        // Salto
        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            moveDirection.y = jumpForce;
        }

        // Aplicar gravedad
        moveDirection.y -= 9.81f * Time.deltaTime;

        // Mover al personaje
        controller.Move(moveDirection * Time.deltaTime);
    }
}
