using UnityEngine;

public class AcelerateMovement : IMovementStrategy
{
    public void Move(Transform transform, Player player, float direction)
    {
        float movement = direction * (player.Velocidad + player.Aceleracion) * Time.deltaTime;
        transform.Translate(movement, 0, 0);
    }
}
