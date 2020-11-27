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

    private Queue<string> sentances;

    void Start()
    {
        sentances = new Queue<string>();
    }

    public void Talk()
    {
        foreach (string line in lines)
        {
            sentances.Enqueue(line);
        }
        DialogBoxObject.SetActive(true);
        nameText.text = name;
        StartCoroutine(Speak());
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
