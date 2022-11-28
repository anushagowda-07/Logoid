using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public GameObject answerABlue; // waiting
    public GameObject answerAGreen; // correct
    public GameObject answerAred; // wrong

    public void AnswerA()
    {
        if(QuestionGenrerate.actualAnswer == "A")
        {
            answerAGreen.SetActive(true);
            answerABlue.SetActive(false);
        }
    }

  
}
