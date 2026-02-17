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
        spriteRenderer.color = Color.black;
        prefab.transform.localScale = Vector3.one * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cursor = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        cursor.z = 0;
        transform.position = cursor;
        if (Mouse.current.leftButton.isPressed && !EventSystem.current.IsPointerOverGameObject())
        {
            spawnedPaint = Instantiate(prefab, transform.position, transform.rotation);
            count += 1;
            paint.Add(spawnedPaint);
        }
        transform.localScale = prefab.transform.localScale;
    }

    public void Colour()
    {
        spriteRenderer.color = Random.ColorHSV();
        penRenderer.color = spriteRenderer.color;
    }

    public void Clear()
    {
        for (int i = paint.Count - 1; i >= 0; i--)
        {
            GameObject dot = paint[i];
            paint.Remove(dot);
            Destroy(dot);
        }
    }
}
