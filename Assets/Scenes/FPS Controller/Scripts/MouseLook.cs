using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float _mouseSensitivity = 100f; // Чувствительность мышки
    [SerializeField] private Transform _player; // Ссылка на плеера

    private float _xRotation = 0f;

    private void Start()
    {
        // Убирает значок курсора
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Input.GetAxis(axisName) - возращает значение виртуальной оси
        // Time.deltaTime - количество времени прошедшее с прошлого кадра
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        // Поворачиваем игрока по оси Y, Vector3.up = new Vector(0, 1, 0)
        _player.Rotate(Vector3.up * mouseX);

        // Вычесляем текущий градус по оси X
        _xRotation -= mouseY;
        // Этот метод ограничивает значение от -90 до 90
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90);

        // Изменяем градус поворота по оси X
        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
    }
}


