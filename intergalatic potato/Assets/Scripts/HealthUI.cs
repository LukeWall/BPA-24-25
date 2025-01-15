using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public GameObject enemy;
    public GameObject healthBar;
    public GameObject[] healthbarSprites;
    public GameObject newHealth;
    HealthManager healthManager;
    // Start is called before the first frame update
    void Start()
    {
        healthManager = this.GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
            if (GetComponent<HealthManager>().Health >= 90 && this.GetComponent<HealthManager>().Health < 100)
            {
            Debug.Log("100");
            Destroy(newHealth);
            newHealth = Instantiate(healthbarSprites[0], healthBar.transform, false);
            }
            else if (GetComponent<HealthManager>().Health >= 80 && this.GetComponent<HealthManager>().Health < 90)
            {
            Debug.Log("90");
            Destroy(newHealth);
            newHealth = Instantiate(healthbarSprites[1], healthBar.transform, false);
            }
            else if (GetComponent<HealthManager>().Health >= 70 && this.GetComponent<HealthManager>().Health < 80)
            {
            Debug.Log("80");
            Destroy(newHealth);
            newHealth = Instantiate(healthbarSprites[2], healthBar.transform, false);
            }
            else if (this.GetComponent<HealthManager>().Health >= 60 && this.GetComponent<HealthManager>().Health < 70)
            {
            Debug.Log("70");
            Destroy(newHealth);
            newHealth = Instantiate(healthbarSprites[3], healthBar.transform, false);
            }
            else if (this.GetComponent<HealthManager>().Health >= 50 && this.GetComponent<HealthManager>().Health < 60)
            {
            Destroy(newHealth);
            newHealth = Instantiate(healthbarSprites[4], healthBar.transform, false);
            }
            else if (this.GetComponent<HealthManager>().Health >= 40 && this.GetComponent<HealthManager>().Health < 50)
            {
            Destroy(newHealth);
            newHealth = Instantiate(healthbarSprites[5], healthBar.transform, false);
            }
            else if (GetComponent<HealthManager>().Health >= 30 && this.GetComponent<HealthManager>().Health < 40)
            {
            Destroy(newHealth);
            newHealth = Instantiate(healthbarSprites[6], healthBar.transform, false);
            }
            else if (this.GetComponent<HealthManager>().Health >= 20 && this.GetComponent<HealthManager>().Health < 30)
            {
            Destroy(newHealth);
            newHealth = Instantiate(healthbarSprites[7], healthBar.transform, false);
            }
            else if (this.GetComponent<HealthManager>().Health > 10 && this.GetComponent<HealthManager>().Health < 20)
            {
            Destroy(newHealth);
            newHealth = Instantiate(healthbarSprites[8], healthBar.transform, false);
            }
            else if (this.GetComponent<HealthManager>().Health <= 0)
            {
            Destroy(enemy);
            Destroy(this);
            newHealth = Instantiate(healthbarSprites[9], healthBar.transform, false);
            }

        }
    
}
