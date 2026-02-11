using UnityEngine;
using UnityEngine.InputSystem;

public class knoife : MonoBehaviour
{
    public GameObject barrel;
    public GameObject loss;
    public SpriteRenderer spriteRenderer;
    public bool clicked;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousePos) == true) {
            if (Mouse.current.leftButton.wasPressedThisFrame) 
            {
                if (clicked == false && loss.activeInHierarchy == false) 
                {
                    Vector3 destroy = new Vector3(0, 0, 0);
                    clicked = true;
                    

                    if (Random.Range(0, 100) > 80)
                    {
                        barrel.transform.localScale = destroy;
                        loss.SetActive(true);
                    }
                    else
                    {
                        transform.localScale = destroy;
                    }
                }
            
            }
            
        }
    }
}
