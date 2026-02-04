using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.LowLevelPhysics;
using static UnityEngine.Rendering.ProbeAdjustmentVolume;

public class text : MonoBehaviour
{

    public GameObject triangle;
    public GameObject square;
    public GameObject circle;
    public TextMeshProUGUI topText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (within(triangle, 1))
        {
            topText.text = "Triangle";
        } else if (within(square, 1))
        {
            topText.text = "Square";
        } else if (within(circle, 1))
        {
            topText.text = "Circle";
        } else
        {
            topText.text = " ";
        }

    }

    bool within(GameObject shape, float size)
    {
        if ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - shape.transform.position.x < size / 2 &&
             Camera.main.ScreenToWorldPoint(Input.mousePosition).x - shape.transform.position.x > -size / 2) &&
            (Camera.main.ScreenToWorldPoint(Input.mousePosition).y - shape.transform.position.y < size / 2 &&
             Camera.main.ScreenToWorldPoint(Input.mousePosition).y - shape.transform.position.y > -size / 2)
             && shape.activeInHierarchy)
        {
            return true;
        } else
        {
            return false;
        }
    }
}


