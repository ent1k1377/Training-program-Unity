using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private float shootingDistance;

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
        RaycastHit hit;
        Debug.DrawLine(_camera.transform.position, _camera.transform.forward * shootingDistance, Color.red);
        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, shootingDistance))
        {

        }

    }
}
