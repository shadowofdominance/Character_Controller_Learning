using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputActionAsset inputActions;

    InputAction moveAction;
    InputAction lookAction;
    InputAction jumpAction;

    private Vector2 moveInput;
    private Vector2 lookInput;

    public float speed = 5;
    public float rotateSpeed = 5;
    public float jumpSpeed = 5;

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
        moveAction = InputSystem.actions.FindAction("Move");
        lookAction = InputSystem.actions.FindAction("Look");
        jumpAction = InputSystem.actions.FindAction("Jump");

    }
    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        lookInput = lookAction.ReadValue<Vector2>();


    }
}
