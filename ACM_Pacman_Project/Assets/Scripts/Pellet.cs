using UnityEngine;

public class Pellet : MonoBehaviour
{
    public int points = 10;

    // Allows player to consume pellet.
    protected virtual void Eat()    // Protected allows subclass powerpellet to access it.
    {
        FindObjectOfType<GameManager>().PelletEaten(this);
    }

    // Detect when playere hits a pellet.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            Eat();
        }
    }
}
