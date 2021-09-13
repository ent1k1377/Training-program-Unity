using UnityEngine;

public class OnCollisionEnterAndOnTriggerEnter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject + " OnCollisionEnter " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject + "OnTriggerEnter " + other.gameObject.name);
    }
}
