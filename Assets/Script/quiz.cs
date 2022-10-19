using System.Net.Mime;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz : MonoBehaviour
{
    private Text TxtQuestion;
    private TextMesh RespL;
    private TextMesh RespR;
    private int nbrand;
    public string answer;

    //Déclaration tableau
    string[] quizz = new string[3];

    // Start is called before the first frame update
    void Start()
    {
        //Component
        TxtQuestion=GameObject.Find("TxtQuestion").GetComponent<Text>();
        RespL = GameObject.Find("RespL").GetComponent<TextMesh>();
        RespR = GameObject.Find("RespR").GetComponent<TextMesh>();

        //Declaration du contenu du tableau
        quizz[0]= "question 1 ?,R1,R2,R1";
        quizz[1]= "question 2 ?,R11,R12,R12";
        quizz[2]= "question 3 ?,R21,R222,R21";

        Ask();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(quizz.Length);
    }

    void Ask()
    {
        nbrand = Random.Range(0, quizz.Length-1);
        string[] col = quizz[nbrand].Split(',');
        TxtQuestion.text=col[0];
        RespL.text = col[1];
        RespR.text = col[2];
        answer = col[3];
    }
}
