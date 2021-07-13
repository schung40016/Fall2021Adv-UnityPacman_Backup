using UnityEngine;

public class PowerPellet : Pellet
{
    public float duration = 8.0f;

    // Allows player to consume pellet.
    protected override void Eat()    // Protected allows subclass powerpellet to access it.
    {
        FindObjectOfType<GameManager>().PowerPelletEaten(this);
    }
}
