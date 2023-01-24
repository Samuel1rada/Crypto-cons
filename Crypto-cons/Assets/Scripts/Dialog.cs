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

        Debug.Log("Index = " + index);
        Debug.Log("sentences = " + sentences.Length);
        Debug.Log("textdisplay.text" + textdisplay.text);
    }

    void Update()
    {
        if (textdisplay.text == sentences[index])
        {
            continuebutton.SetActive(true);
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
        Debug.Log("sentences = " + sentences.Length);
        if (index < sentences.Length)
        {
            index++;
            textdisplay.text = "";
            StartCoroutine(Type());

        }
        else
        {
            textdisplay.text = "";
        }

        if (index == sentences.Length)
        {
            if (Panel0.activeInHierarchy == true)
            {
                Panel1.SetActive(true);
            }
            else
            {
                Panel1.SetActive(false);
            }
        }
    }
}