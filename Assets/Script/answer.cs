using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer : MonoBehaviour
{
    private Text Ans;

    void OnMouseDown ()
    {
        if(GameObject.Find("Canvas").GetComponent<quiz>().answer == transform.GetChild(0).GetComponent<TextMesh>().text)
        {
            Debug.Log("Win !");
            Ans.text = "Bonne réponse !";
        }
        else
        {
            Debug.Log("Lose !");
            Ans.text = "Mauvaise réponse !";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Ans=GameObject.Find("Ans").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
