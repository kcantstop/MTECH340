using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public bool flag;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (flag)
        {
            Debug.Log("Boolean flag is set");
        }
        else
        {
            Debug.Log("Boolean flag isn't set");
        }

        for (int i = 0; i < 11; i++)
        {
            Debug.Log($"The {i} power of 2 is {Mathf.Pow(2, i)}");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}