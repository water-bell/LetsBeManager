using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectBtn : MonoBehaviour
{
    public InputField changeInput;
    public Text changeText;
    
    private Button changeButton;
    private string originalText;
    public void Start()
    {
        originalText = "";
        changeInput.text = "";
        changeButton = this.transform.GetComponent<Button>();
        if(changeButton != null)
        {
            changeButton.onClick.AddListener(Cor);
        }
    }

    public void Cor()
    {
        gameObject.transform.Find("test").gameObject.SetActive(true);
        changeText.text = $"{changeInput.text}";
        if(originalText != changeText.text)
        {
            gameObject.transform.Find("test").gameObject.SetActive(false);
            originalText = changeText.text;
        }
        
    }
}
