using System.Net.Mime;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz : MonoBehaviour
{
    private Text TxtQuestion;
    // private Text RespL;
    // private Text RespR;
    private TextMesh RespL;
    private TextMesh RespR;
    private int nbrand;
    public string answer;

    //Déclaration tableau
    string[] quizz = new string[5];

    // Start is called before the first frame update
    void Start()
    {
        //Component
        TxtQuestion=GameObject.Find("TxtQuestion").GetComponent<Text>();
        //RespL = GameObject.Find("btn1").GetComponent<Text>();
        //RespR = GameObject.Find("btn2").GetComponent<Text>();
        RespL = GameObject.Find("R1").GetComponent<TextMesh>();
        RespR = GameObject.Find("R2").GetComponent<TextMesh>();

        //Declaration du contenu du tableau
        quizz[0]= "Le cube immersif est conçu pour fonctionner avec la VR,Vrai,Faux,Faux";
        quizz[1]= "Le cube doit être un espace clôt,Vrai,Faux,Faux";
        quizz[2]= "Le cube immersif permet de scénariser l’activité,Vrai,Faux,Vrai";
        quizz[3]= "La réalité virtuelle est identique à la vidéo 360 ?,Vrai,Faux,Faux";
        quizz[4]= "La réalité virtuelle et la réalité augmentée sont des techniques identiques,Vrai,Faux,Faux";

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
