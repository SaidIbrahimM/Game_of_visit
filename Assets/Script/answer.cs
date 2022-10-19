using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answer : MonoBehaviour
{
    void OnMouseDown ()
    {
        if(GameObject.Find("Canvas").GetComponent<quiz>().answer == transform.GetChild(0).GetComponent<TextMesh>().text)
        {
            Debug.Log("Win");
        }
        else
        {
            Debug.Log("Lose");
        }
    }

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
