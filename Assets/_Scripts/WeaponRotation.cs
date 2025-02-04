using UnityEngine;

public class WeaponRotation : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb2d;
    [SerializeField]
    private float _rotationSpeed = 200f;
    private void FixedUpdate()
    {
        _rb2d.MoveRotation(_rb2d.rotation + _rotationSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
