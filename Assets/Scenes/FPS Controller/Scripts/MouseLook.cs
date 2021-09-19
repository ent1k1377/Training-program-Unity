using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float _mouseSensitivity = 100f; // ���������������� �����
    [SerializeField] private Transform _player; // ������ �� ������

    private float _xRotation = 0f;

    private void Start()
    {
        // ������� ������ �������
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Input.GetAxis(axisName) - ��������� �������� ����������� ���
        // Time.deltaTime - ���������� ������� ��������� � �������� �����
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        // ������������ ������ �� ��� Y, Vector3.up = new Vector(0, 1, 0)
        _player.Rotate(Vector3.up * mouseX);

        // ��������� ������� ������ �� ��� X
        _xRotation -= mouseY;
        // ���� ����� ������������ �������� �� -90 �� 90
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90);

        // �������� ������ �������� �� ��� X
        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
    }
}


