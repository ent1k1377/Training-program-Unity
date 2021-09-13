using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    void Update()
    {
        // Создание луча с двумя параметра, 1 - позиция начала луча, 2 - направление луча
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.green); // Рисует зеленный луч 
        // Проверка попал ли луч хотя бы в один объект и записывает в переменную hit
        // Переменная hit хранит информацию о объектах которые попали в луч - имя, дистанцию и т.д.
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            //Проверяется слой объекта попавшего в луч то, что он Box
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Box"))
            {
                // Меняется цвет материала на красный
                hit.transform.GetComponent<Renderer>().material.color = Color.red;
            }  
        }
    }
}
