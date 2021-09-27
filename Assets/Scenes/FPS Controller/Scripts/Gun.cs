using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnBullet;
    [SerializeField] private float _speedBullet;

    [SerializeField] private GameObject _player;
    
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0)) // ������� ����� ������ ����
        {
            GameObject bullet = Instantiate(_bulletPrefab, _spawnBullet.position, Quaternion.identity); // �������� ����
            // ���������� � ������ AddForce ������ Rigidbody ������� ���� � �������� ���������� ������ ���������� �� ��������
            //  �.�. ���� ������ ������ � ����������� ���� ������� �����
            bullet.GetComponent<Rigidbody>().AddForce(_camera.transform.forward * _speedBullet);
            Destroy(bullet, 15f); // ���������� ���� ����� 15 ������
        }
    }
}


