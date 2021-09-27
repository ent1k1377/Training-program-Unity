using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{   
    [SerializeField] private GameObject _player;
    [SerializeField] private float distance;

    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _agent.SetDestination(_player.transform.position); // ������������� ����� ����������

        // ���������� ��������� �� ���� �� �����
        if (Vector3.Distance(transform.position, _player.transform.position) < distance)
            _agent.isStopped = false; // ���������� ��������� �� ��������
        else
            _agent.isStopped = true; // ������������ ��������� �� ��������
    }
}


