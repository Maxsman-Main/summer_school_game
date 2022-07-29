using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool IsGrounded { get; private set; }

    private void Start()
    {
        IsGrounded = false;
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        IsGrounded = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        IsGrounded = false;
    }
}
