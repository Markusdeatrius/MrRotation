using UnityEngine;

public class CloudsControl : MonoBehaviour
{


    [SerializeField]
    private Transform[] _clouds = new Transform[6];
    [SerializeField]
    private float _speed = 1.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < _clouds.Length; i++)
        {
            _clouds[i].position = 
                _clouds[i].position + Vector3.right * Time.deltaTime * _speed;
        }
    }
}
