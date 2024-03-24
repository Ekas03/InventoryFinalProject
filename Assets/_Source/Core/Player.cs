using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public int Health;
    public int Experience;
    public TMP_Text HealthText;
    public TMP_Text ExperienceText;

    private void Awake()
    {
        Instance = this;
    }

    public void IncreaseHealth(int value)
    {
        Health += value;
        HealthText.text = $"HP: {Health}";
    }
    
    public void IncreaseExperience(int value)
    {
        Experience += value;
        ExperienceText.text = $"XP: {Experience}";
    }
}
