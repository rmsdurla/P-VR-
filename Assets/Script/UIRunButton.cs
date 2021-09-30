using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIRunButton : MonoBehaviour
{
    public Text sourceText;

    public void Run()
    {
        sourceText.text = "안녕하세요";
    }


  
}
