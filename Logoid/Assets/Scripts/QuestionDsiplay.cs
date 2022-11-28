using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionDsiplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public Sprite screenQuestionImage;
    public static Sprite newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;






    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PushTextOnScreen());
        
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<Image>().sprite = screenQuestionImage;
        answerA.GetComponent<TextMeshProUGUI>().text = newA;
        answerB.GetComponent<TextMeshProUGUI>().text = newB;
        answerC.GetComponent<TextMeshProUGUI>().text = newC;
        answerD.GetComponent<TextMeshProUGUI>().text = newD;
    }
    
}
