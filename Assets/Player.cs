using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private string _horizontalAxis = "Horizontal", _verticalAxis = "Vertical";
    [SerializeField]
    private Rigidbody2D _rb2D;

    private Vector2 _input;

    [SerializeField]
    private float _speed = 3;
    private void FixedUpdate()
    {
        _rb2D.linearVelocity = _input * _speed;
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxisRaw(_horizontalAxis);
        float VerticalInput = Input.GetAxisRaw(_verticalAxis);
        _input = new Vector2(HorizontalInput, VerticalInput);
        _input.Normalize();
    }
}
