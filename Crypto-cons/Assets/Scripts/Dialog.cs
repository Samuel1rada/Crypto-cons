using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UIElements;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textdisplay;
    public string[] sentences;
    private int index;
    public float Typingspeed;

    public GameObject continuebutton;
    public GameObject Panel1;
    public GameObject Panel0;

    void Start()
    {
        StartCoroutine(Type());
        continuebutton.SetActive(false);
        Panel1.SetActive(false);
        Panel0.SetActive(true);
    }

    void Update()
    {
        if (textdisplay.text == sentences[index])
        {
            if (Panel1.activeSelf== false)
            {
                continuebutton.SetActive(true);
            }
            
        }
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textdisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }

    }
    public void Nextsentence()
    {
        continuebutton.SetActive(false);
    
            Debug.Log("Index = " + index);

        if (index < sentences.Length - 1)
        {
            index++;
            textdisplay.text = "";
            StartCoroutine(Type());
            
        }
        else
        {
            textdisplay.text = "";
        }
        Panel1.SetActive(true);
    }
    public void Panel1Nextscene()
    {
        if (index > 1) 
        {
            Panel1.SetActive(true);
        }
        
        if (Panel0.activeSelf== false)
        {
            continuebutton.SetActive(false);
        }
    }
}