using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionGenrerate : MonoBehaviour
{
    public static string actualAnswer;
    public Sprite screenQuestionImage;
    public static bool displayingQuestion = false;
    // Start is called before the first frame update
    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            QuestionDsiplay.newQuestion = screenQuestionImage;
            QuestionDsiplay.newA = " A. BurgerKing";
            QuestionDsiplay.newB = " B. McDonald's";
            QuestionDsiplay.newC = " C. The IceBerg";
            QuestionDsiplay.newD = " D. Burger N Bites's";
            actualAnswer = "B";
        }
    }

    
   
}
