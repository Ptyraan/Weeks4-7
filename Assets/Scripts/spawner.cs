using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnedPaint;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer penRenderer;
    public List<GameObject> paint;
    public int count = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // reset prefab colour and size because apparently it's not done automatically when you end play mode unlike literally everything else
        spriteRenderer.color = Color.black;
        prefab.transform.localScale = Vector3.one * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // cursor position
        Vector3 cursor = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        cursor.z = 0;
        transform.position = cursor;
        // start drawing
        if (Mouse.current.leftButton.isPressed && !EventSystem.current.IsPointerOverGameObject())
        {
            spawnedPaint = Instantiate(prefab, transform.position, transform.rotation);
            count += 1;
            paint.Add(spawnedPaint);
        }
        // didn't find a way to efficiently make size changes of the pen cursor preview, so I'm just gonna have to run it every frame
        transform.localScale = prefab.transform.localScale;
    }

    public void Colour()
    {
        // change colour of the prefab
        spriteRenderer.color = Random.ColorHSV();
        // change the pen preview to be the same colour too
        penRenderer.color = spriteRenderer.color;
    }

    public void Clear()
    {
        // delete everything
        for (int i = paint.Count - 1; i >= 0; i--)
        {
            GameObject dot = paint[i];
            paint.Remove(dot);
            Destroy(dot);
        }
    }
}
