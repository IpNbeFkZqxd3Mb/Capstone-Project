using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Gamemanager : MonoBehaviour
{
    TMP_InputField ip;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        setIP();
    }
    void Update(){
        //如果按下手機返回鈕或鍵盤的ESC，返回Menu
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(this == null) Debug.Log("gm not found."); 
            else this.Menu();
        }
    }

    public void startAR()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }
    public void Menu()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void setIP()
    {
        ip = GameObject.Find("IP").GetComponent<TMP_InputField>();
        Debug.Log(ip.text);
        PlayerPrefs.SetString("ip",ip.text);
    }
}
