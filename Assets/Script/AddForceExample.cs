using UnityEngine;

public class AddForceExample : MonoBehaviour
{
    // SerilizeField позволяет менять приватное поле из инпектора
    [SerializeField] private float _forceJump = 400; 
    [SerializeField] private ForceMode _forceMode; 

    private Rigidbody _rigidbody;

    private void Start()
    {
        // В поле _rigidbody берется компонент, на объекте обязательно должен присутсвовать Rigidbody
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // При нажатии на кнопку Space, вызывается метод AddForce в который передается Vector3
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Нажат Space");
            _rigidbody.AddForce(new Vector3(0, _forceJump, 0), _forceMode);
        }
    }
}

