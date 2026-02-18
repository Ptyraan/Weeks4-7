using UnityEngine;
using UnityEngine.InputSystem;

public class Mimic : MonoBehaviour
{
    public GameObject player;
    public SpriteRenderer spriteRenderer;
    public Sprite closed;
    public Sprite open;
    public bool trapped = false;
    public int poise = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer.sprite = closed;
    }

    // Update is called once per frame
    void Update()
    {
        if (trapped)
        {
            player.transform.position = transform.position;
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                poise -= 1;
            }
            else 
            { 
                // do damage
            }
            if (poise <= 0)
            {
                trapped = false;
                spriteRenderer.sprite = closed;
            }
        }
        else
        {
            if (spriteRenderer.bounds.Contains(player.transform.position) == true
             && Mouse.current.leftButton.wasPressedThisFrame)
            {
                trapped = true;
                spriteRenderer.sprite = open;
            }
        }
    }
}
