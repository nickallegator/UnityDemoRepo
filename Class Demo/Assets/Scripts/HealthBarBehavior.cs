using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider hSlider;
    Health playerHealth;

    void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<Health>();
        hSlider.maxValue = playerHealth.health;

    }

    // Update is called once per frame
    void Update()
    {
        hSlider.value = playerHealth.health;
    }
}
