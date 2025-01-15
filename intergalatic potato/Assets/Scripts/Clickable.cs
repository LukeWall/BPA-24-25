using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clickable : MonoBehaviour
{
    
    public GameObject Potato;
    public GameObject PotatoSkin;
    public GameObject Potatopeeler;

    
    public GameObject EnemyPotato;
    public GameObject EnemyPotatoSkin;
    public GameObject EnemyPotatopeeler;

    private Text GamesPlayed;
    private Text HabenthePotatoScore;
    private Text PuzzleScore;
    private int GamesPlayedInt;

    public GameObject regularScreen;
    public GameObject EndScreen;

    private int score;
    private int Enemyscore;

    public GameObject HabenWins;
    public GameObject HabenLost;
    public GameObject TryAgain;

    private int choice;
    void Start()
    {
        GameObject GPlayed = GameObject.Find("GamesPlayed");
        GamesPlayed = GPlayed.GetComponent<Text>();
        GamesPlayed.text = "0";

        GameObject PScore = GameObject.Find("PlayerScore");
        HabenthePotatoScore = PScore.GetComponent<Text>();

        GameObject EScore = GameObject.Find("CompScore");
        PuzzleScore = EScore.GetComponent<Text>();

    }

    void Update()
    {
    }

    private void OnMouseDown()
    {
        GamesPlayedInt = int.Parse(GamesPlayed.text);

        choice = 0;
        if (GamesPlayedInt < 10)
        {
            if (tag.Equals("Potato = rock"))
            {
                Instantiate(Potato, new Vector3(-20f, -1f, 7.2f), transform.rotation);
                choice = 1;
                CompMove();
            }
            if (tag.Equals("PotatoSkin = paper"))
            {
                Instantiate(PotatoSkin, new Vector3(-20f, -1f, 7.2f), transform.rotation);
                choice = 2;
                CompMove();
            }
            if (tag.Equals("Potatopeeler = scissors"))
            {
                Instantiate(Potatopeeler, new Vector3(-20f, -1f, 7.2f), transform.rotation);
                choice = 3;
                CompMove();
            }
            GamesPlayedInt++; 
            GamesPlayed.text = GamesPlayedInt.ToString();
        }
        if (GamesPlayedInt >= 10f)
        {
            StartCoroutine(waitfoursecs()); 
        }
    }

    void CompMove()
    {
        int r = Random.Range(1,4); 

        if (r == 1) Instantiate(EnemyPotato, new Vector3(20f, -1f, 7.2f), transform.rotation);
        else if (r == 2) Instantiate(EnemyPotatoSkin, new Vector3(20f, -1f, 7.2f), transform.rotation);
        else if (r == 3) Instantiate(EnemyPotatopeeler, new Vector3(20f, -1f, 7.2f), transform.rotation);
        
    }
    IEnumerator waitfoursecs()
    {
        yield return new WaitForSeconds(4f);
        displayEndScreen();
    }

    void displayEndScreen()
    {
        EndScreen.SetActive(true);
        regularScreen.SetActive(false);

        score = int.Parse(HabenthePotatoScore.text);
        Enemyscore = int.Parse(PuzzleScore.text);

        if (score > Enemyscore) HabenWins.SetActive(true);
        else if (score < Enemyscore) HabenLost.SetActive(true);
        else if (score == Enemyscore) TryAgain.SetActive(true);
    }

    public void resetScore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}