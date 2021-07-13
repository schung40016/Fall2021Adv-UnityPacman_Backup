using UnityEngine;
//TODO: ADD GHOSTEYES TO GHOST_BASE PREFAB >> EYES
// 3:22:00 of video

//NOTE: his github code had this line here 
//"[RequireComponent(typeof(SpriteRenderer))]" 
//but his video didn't
public class GhostEyes : MonoBehaviour
{
    //eye directions
    public Sprite up;
    public Sprite down;
    public Sprite left;
    public Sprite right;
    public SpriteRenderer spriteRenderer { get; private set; }
    public Movement movement { get; private set; }

    private void Awake()
    {
        //reference to sprite
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        //reference to movement
        this.movement = GetComponentInParent<Movement>();
    }

    //decide which direction
    private void Update()
    {
        if (this.movement.direction == Vector2.up)
        {
            this.spriteRenderer.sprite = this.up;
        }
        else if (this.movement.direction == Vector2.down)
        {
            this.spriteRenderer.sprite = this.down;
        }
        else if (this.movement.direction == Vector2.left)
        {
            this.spriteRenderer.sprite = this.left;
        }
        else if (this.movement.direction == Vector2.right)
        {
            this.spriteRenderer.sprite = this.right;
        }
    }
}