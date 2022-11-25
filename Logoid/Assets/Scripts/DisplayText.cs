using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayText : MonoBehaviour
{
    public TextMeshProUGUI obj_text;
    public TMP_InputField display;
    // Start is called before the first frame update
    void Start()
    {
        obj_text.text = PlayerPrefs.GetString("user_name");
    }

    // Update is called once per frame
    public void create()
    {
        obj_text.text = display.text;
        PlayerPrefs.SetString("user_name", obj_text.text);
        PlayerPrefs.Save();


    }
}
