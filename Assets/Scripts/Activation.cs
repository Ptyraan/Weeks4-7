using UnityEngine;

public class Activation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void off()
    {
        gameObject.SetActive(false);
    }

    public void on()
    {
        gameObject.SetActive(true);
    }
}
