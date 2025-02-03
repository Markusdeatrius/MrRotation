using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private string _horizontalAxis = "Horizontal", _verticalAxis = "Vertical";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxisRaw(_horizontalAxis);
        float VerticalInput = Input.GetAxisRaw(_verticalAxis);
    }
}
