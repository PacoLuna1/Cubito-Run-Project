using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorJuego : MonoBehaviour {
    bool JuegoTermino = false;
    public float restartDelay = 1f;
    public GameObject completeLeveUI;
    public GameObject corazonCubito;
    public GameObject corazonCubito1;
    public GameObject corazonCubito2;
    public static int muertes=0;



    public void CompleteLevel()
    {
        completeLeveUI.SetActive(true);
    }

    public void GameOver()
    {
        
           
            if (JuegoTermino == false && muertes !=2 )
            {
                muertes = muertes + 1;
                JuegoTermino = true;
                Invoke("Restart", restartDelay);
                 Debug.Log("Muertes pequeñas "+ muertes);
             }else if(JuegoTermino == false && muertes ==2) {
                
                    JuegoTermino = true;
                    muertes = 0;
                    SceneManager.LoadScene("Menu");
                Debug.Log("Muertes gameover " + muertes);

                
            }

        
           
                  
    }

    void Start()
    {
        gameOverMenu();
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void gameOverMenu()
    {
        
        if (muertes == 1)
        {
            Destroy(corazonCubito2);
            Debug.Log(muertes);
        }
        else if (muertes == 2)
        {
            Destroy(corazonCubito2);
            Destroy(corazonCubito1);            
            Debug.Log(muertes);
        }
        
    }

}

