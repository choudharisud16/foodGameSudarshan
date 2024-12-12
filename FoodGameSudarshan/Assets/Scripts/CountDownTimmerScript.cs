using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CountDownTimmerScript : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 15f;
    private TextMeshProUGUI countDownTimerText;
    public GameObject gameOver;

    public WinOrLose winOrLose;

    //public PlayerInventory playerInventory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        currentTime = startTime;
        countDownTimerText = GetComponent<TextMeshProUGUI>();
        gameOver.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        /* playerInventory = GetComponent<PlayerInventory>();
        Debug.Log(playerInventory);
        if(playerInventory!=null){
            playerInventory.GameOver();
            //gameObject.SetActive(false);
        } */

        currentTime -= 1 * Time.deltaTime;
        if(currentTime <= 3){
            countDownTimerText.color = Color.red;
        }
        countDownTimerText.text = "Timer: " + currentTime.ToString("0");
         if(currentTime <= 0f){
            winOrLose.UpdateGameOverText();
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
            //SceneManager.LoadScene(0);
        }
    }
}
