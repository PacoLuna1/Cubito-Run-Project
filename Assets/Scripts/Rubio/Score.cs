using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text scoreText;
    private float score = 0.0f;
    private  int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;
    private bool isDead = false;
    public DeathMenu deathMenu;


	// Use this for initialization
	void Start () {
        scoreText.text = "???";
	}

	// Update is called once per frame
	void Update () {
        if (isDead)
            return ;

        if (score >= scoreToNextLevel)
            LevelUp();
        score += Time.deltaTime * difficultyLevel;
        scoreText.text = ((int)score).ToString();

	}

    void LevelUp()
    {
        if (difficultyLevel == maxDifficultyLevel)
            return;

        scoreToNextLevel *= 2;
        difficultyLevel++;
        if (difficultyLevel <= 5)
            GetComponent<PlayerMotor>().SetSpeed(difficultyLevel);
        else
            GetComponent<PlayerMotor>().SetSpeed(difficultyLevel * 1.5f);

        Debug.Log(difficultyLevel);
    }

    public void onDeath()
    {
        isDead = true;
        if (PlayerPrefs.GetFloat("Highscore") < score)
            PlayerPrefs.SetFloat("Highscore", score);

        deathMenu.ToggleEndMenu(score);
    }

}
