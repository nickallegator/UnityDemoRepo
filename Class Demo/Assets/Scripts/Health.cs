using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    // Start is called before the first frame update

    public int health = 100;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // When H is hit
        if(Input.GetKeyDown(KeyCode.H))
        {
            // add 500 points to score
            OnDamage(10);
        }
    }

    public void OnDamage(int damage){
        health -= damage;
        if (health <= 0)
        {
            if(gameObject.tag == "Player")
            {
                Cursor.visible = true;
                SceneManager.LoadScene("MainMenu");
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
}
