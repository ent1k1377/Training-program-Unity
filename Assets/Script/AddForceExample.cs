using UnityEngine;

public class AddForceExample : MonoBehaviour
{
    // SerilizeField ��������� ������ ��������� ���� �� ���������
    [SerializeField] private float _forceJump = 400; 
    [SerializeField] private ForceMode _forceMode; 

    private Rigidbody _rigidbody;

    private void Start()
    {
        // � ���� _rigidbody ������� ���������, �� ������� ����������� ������ ������������� Rigidbody
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // ��� ������� �� ������ Space, ���������� ����� AddForce � ������� ���������� Vector3
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("����� Space");
            _rigidbody.AddForce(new Vector3(0, _forceJump, 0), _forceMode);
        }
    }
}

