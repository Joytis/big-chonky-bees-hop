using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

[RequireComponent(typeof(Rigidbody2D))]
public class BuzzyBeeController : MonoBehaviour
{   
    [SerializeField] float _horizontalSpeed = 6f;
    Rigidbody2D _rb2d = null;
    Vector2 _currentMoveDirection = default;

    void Awake() => _rb2d = GetComponent<Rigidbody2D>();

    // Update is called once per frame
    void Update() {
        var horizontalSpeed = _horizontalSpeed * Time.deltaTime * _currentMoveDirection.x;
        _rb2d.velocity = new Vector2(horizontalSpeed, _rb2d.velocity.y);
    }

    public void MoveHorizontal(CallbackContext value) {
        var currentMoveDirection =  value.ReadValue<Vector2>();
        Debug.Log(currentMoveDirection);
        _currentMoveDirection = currentMoveDirection;
    }

    public void Jump(CallbackContext value) {

    }

    public void Buzz(CallbackContext value) {

    }
}
