using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionGenrerate : MonoBehaviour
{
    public static string actualAnswer;
    public Sprite screenQuestionImage1;
    public Sprite screenQuestionImage2;
    public Sprite screenQuestionImage3;
    public Sprite screenQuestionImage4;
    public static bool displayingQuestion = false;
    public int questionNumber;


    // Start is called before the first frame update
    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                QuestionDsiplay.newQuestion = screenQuestionImage1;
                QuestionDsiplay.newA = " A. McDonald's";
                QuestionDsiplay.newB = " B. Burger King";
                QuestionDsiplay.newC = " C. The IceBerg";
                QuestionDsiplay.newD = " D. Burger N Bites's";
                actualAnswer = "A";
            }

            if (questionNumber == 2)
            {
                QuestionDsiplay.newQuestion = screenQuestionImage2;
                QuestionDsiplay.newA = " A. Gucci";
                QuestionDsiplay.newB = " B. Dior";
                QuestionDsiplay.newC = " C. Versace";
                QuestionDsiplay.newD = " D. Victoria";
                actualAnswer = "C";
            }

            if (questionNumber == 3)
            {
                QuestionDsiplay.newQuestion = screenQuestionImage3;
                QuestionDsiplay.newA = " A. Coffee Day";
                QuestionDsiplay.newB = " B. StarBucks";
                QuestionDsiplay.newC = " C. Nescafe";
                QuestionDsiplay.newD = " D. Sleepy Owl";
                actualAnswer = "D";
            }

            if (questionNumber == 4)
            {
                QuestionDsiplay.newQuestion = screenQuestionImage4;
                QuestionDsiplay.newA = " A. Cube";
                QuestionDsiplay.newB = " B. Hybe";
                QuestionDsiplay.newC = " C. YG";
                QuestionDsiplay.newD = " D. JYP";
                actualAnswer = "B";
            }

            QuestionDsiplay.PleaseUpdate = false;
        }
    }

    
   
}
