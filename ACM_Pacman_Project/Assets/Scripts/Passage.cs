using UnityEngine;

public class Passage : MonoBehaviour
{
    // Exit coordinates.
    public Transform connection;

    // Telaports character when they enter the tunnel.
    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 position = other.transform.position;
        position.x = this.connection.position.x;
        position.y = this.connection.position.y;
        other.transform.position = position;
    }
}
