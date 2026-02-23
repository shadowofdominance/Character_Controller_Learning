using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    private CharacterController characterController;

    [Header("Movement Settings")]
    [SerializeField] private float walkSpeed = 5f;

    [Header("Input")]
    [SerializeField] private InputActionAsset inputActions;
    private InputAction moveAction;
    Vector2 moveInput;
    private float horizontalInput;
    private float verticalInput;

    private void OnEnable()
    {
        inputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        inputActions.FindActionMap("Player").Disable();
    }
    private void Awake()
    {
        moveAction = inputActions.FindAction("Move");

        moveInput = moveAction.ReadValue<Vector2>();

        horizontalInput = moveInput.x;
        verticalInput = moveInput.y;
    }

    private void Update()
    {
        InputManagement();
    }
    private void InputManagement()
    {

    }
    private void GroundMovement()
    {
        Vector3 move = new Vector3(horizontalInput, 0, verticalInput);
    }
}
