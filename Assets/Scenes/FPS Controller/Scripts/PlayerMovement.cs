using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;

    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _gravity = -10f;
    [SerializeField] private float _jumpHeight = 3f;

    [SerializeField] private Transform _ground;
    [SerializeField] private float _groundDistance = 0.4f;
    [SerializeField] private LayerMask _groundMask;

    private Vector3 _velocity; // Ќаправление по оси Y
    private bool _isGrounded;

    private void Update()
    {
        // ¬ычесл€ет пересекает ли на заданном расто€нии физический слой земли
        _isGrounded = Physics.CheckSphere(_ground.position, _groundDistance, _groundMask);

        // ќбнул€ем переменную дл€ того, чтобы когда игрок упадет, он не прит€нулс€ вниз мгновенно
        if (_isGrounded && _velocity.y < 0)
            _velocity.y = 0;

        // «аписывает направление в какую сторону сейчас идет игрок
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        // перемещает игрока в заданном направлении
        _controller.Move(move * _speed * Time.deltaTime);

        // ≈сли игрок нажал кнопку прыжка и он на земле, значительно увеличиваем переменную
        if (Input.GetButtonDown("Jump") && _isGrounded)
            _velocity.y = Mathf.Sqrt(_jumpHeight * _gravity * -2);

        //  аждый кадр т€нем игрока вниз
        _velocity.y += _gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }
}


