using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            _animator.SetBool("isRun", true);
        else
            _animator.SetBool("isRun", false);

        if (Input.GetKeyDown(KeyCode.Space))
            _animator.SetBool("isAttack", true);
        else
            _animator.SetBool("isAttack", false);
    }
}

