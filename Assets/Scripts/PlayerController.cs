using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private CharacterController characterController;

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
    }

    private void Update()
    {
        InputManagement();
        Movement();
    }
    private void InputManagement()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        horizontalInput = moveInput.x;
        verticalInput = moveInput.y;

        Debug.Log($"Move Input: {moveInput} | H: {horizontalInput} | V: {verticalInput}");
    }
    private void GroundMovement()
    {
        Vector3 move = new Vector3(horizontalInput, 0, verticalInput);

        move.y = 0;

        move *= walkSpeed;

        Debug.Log($"Moving: {move * Time.deltaTime}");

        characterController.Move(move * Time.deltaTime);
    }
    private void Movement()
    {
        GroundMovement();
    }
    private void Turn()
    {

    }
}
