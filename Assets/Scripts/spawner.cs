using UnityEngine;
using UnityEngine.InputSystem;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cursor = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        cursor.z = 0;
        transform.position = cursor;
        if (Mouse.current.leftButton.isPressed)
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
