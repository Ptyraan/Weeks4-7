using UnityEngine;

public class colour : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PickRandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
