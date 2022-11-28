using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Answer : MonoBehaviour
{
    public GameObject answerABlue; // waiting
    public GameObject answerAGreen; // correct
    public GameObject answerAred; // wrong

    public GameObject answerBBlue; // waiting
    public GameObject answerBGreen; // correct
    public GameObject answerBred; // wrong
    
    public GameObject answerCBlue; // waiting
    public GameObject answerCGreen; // correct
    public GameObject answerCred; // wrong

    public GameObject answerDBlue; // waiting
    public GameObject answerDGreen; // correct
    public GameObject answerDred; // wrong

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public GameObject currentScore;
    public int scoreValue;

    private void Update()
    {
        currentScore.GetComponent<TextMeshProUGUI>().text = "Score: " + scoreValue;
    }

    public void AnswerA()
    {
        if(QuestionGenrerate.actualAnswer == "A")
        {
            answerAGreen.SetActive(true);
            answerABlue.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerAred.SetActive(true);
            answerABlue.SetActive(false);
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenrerate.actualAnswer == "B")
        {
            answerBGreen.SetActive(true);
            answerBBlue.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerBred.SetActive(true);
            answerBBlue.SetActive(false);
            scoreValue = 0;
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (QuestionGenrerate.actualAnswer == "C")
        {
            answerCGreen.SetActive(true);
            answerCBlue.SetActive(false);
            scoreValue += 5; ;
        }
        else
        {
            answerCred.SetActive(true);
            answerCBlue.SetActive(false);
            scoreValue = 0;
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (QuestionGenrerate.actualAnswer == "D")
        {
            answerDGreen.SetActive(true);
            answerDBlue.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerDred.SetActive(true);
            answerDBlue.SetActive(false);
            scoreValue = 0;
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(2);

        answerAGreen.SetActive(false);
        answerBGreen.SetActive(false);
        answerCGreen.SetActive(false);
        answerDGreen.SetActive(false);

        answerAred.SetActive(false);
        answerBred.SetActive(false);
        answerCred.SetActive(false);
        answerDred.SetActive(false);

        answerABlue.SetActive(true);
        answerBBlue.SetActive(true);
        answerCBlue.SetActive(true);
        answerDBlue.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;
        QuestionGenrerate.displayingQuestion = false;


    }


}
