using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    void Update()
    {
        // �������� ���� � ����� ���������, 1 - ������� ������ ����, 2 - ����������� ����
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.green); // ������ �������� ��� 
        // �������� ����� �� ��� ���� �� � ���� ������ � ���������� � ���������� hit
        // ���������� hit ������ ���������� � �������� ������� ������ � ��� - ���, ��������� � �.�.
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            //����������� ���� ������� ��������� � ��� ��, ��� �� Box
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Box"))
            {
                // �������� ���� ��������� �� �������
                hit.transform.GetComponent<Renderer>().material.color = Color.red;
            }  
        }
    }
}
