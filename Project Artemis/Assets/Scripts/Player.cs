using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{


    private float health;

    public float defaulthealth = 10;

    [SerializeField]
    private float XP = 0;

    private int level = 0;

    private int skillpoints = 0;

    public Slider HealthSlider;

    public Slider XPSlider;
    public TextMeshProUGUI LevelText;
    public TextMeshProUGUI SkillPointsText;

    [Range(1,50)]
    public int[] LevelValues;

    // Start is called before the first frame update
    void Start()
    {
        health = defaulthealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (skillpoints > 0) { SkillPointsText.text = "[F] You have " + skillpoints + " Skill Point to spend";
            SkillPointsText.enabled = true;
        } else
        {
            SkillPointsText.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.F) && skillpoints > 0) skillpoints--;
    }

    public void TakeDamage(int DamagePoints)
    {

        health -= DamagePoints;
        HealthSlider.value = (health / defaulthealth);
    }

    public void GainXP (int xp)
    {
        XP += xp;
        XPSlider.value = XP / LevelValues[level] ;
        while (XP >= LevelValues[level])
        {
            XP -= LevelValues[level];
            level++;
            XPSlider.value = XP / LevelValues[level];
            LevelText.text = "Level " + (level + 1);
            skillpoints++;
            Debug.Log("Level Uped");
        }
        
    }
}
