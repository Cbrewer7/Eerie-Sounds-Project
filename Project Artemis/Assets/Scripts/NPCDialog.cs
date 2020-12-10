using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCDialog : MonoBehaviour
{

    public string[] lines;

    public string name;

    public TextMeshProUGUI nameText;

    public TextMeshProUGUI DialogBox;

    public GameObject DialogBoxObject;


    private bool talking = false;

    public void Talk()
    {
        if (!talking)
        {
            talking = true;
            DialogBoxObject.SetActive(true);
            DialogBox.text = "";
            nameText.text = name;
            StartCoroutine(Speak());
        }
        else
        {
            talking = false;
            DialogBoxObject.SetActive(false); 
        }
    }

    private IEnumerator Speak()
    {
        foreach (string line in lines)
        {
            char[] linechar = line.ToCharArray();
            foreach (char letter in linechar)
            {
                DialogBox.text += letter;
                yield return new WaitForSeconds(0.04f);
            }
            DialogBox.text += "\n";
        }
    }

}
