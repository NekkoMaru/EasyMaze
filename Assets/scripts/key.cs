using UnityEngine;

public class Key : MonoBehaviour
{
    // Статические переменные для ссылок на игрока, пункт назначения и игровой объект игрока
    public static Transform player;
    public static Transform destination;
    public static GameObject playerGameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Деактивация игрового объекта игрока
            playerGameObject.SetActive(false);

            // Телепортация игрока на указанную позицию
            player.position = destination.position;

            // Активация игрового объекта игрока
            playerGameObject.SetActive(true);
        }
    }
}
