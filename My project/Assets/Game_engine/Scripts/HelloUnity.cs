using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    int number;
    public string playerName = "name";
    public int playerLevel = 1;
    public float playerSpeed = 0;

    private int IQ = 90;
    void Start()
    {
        // 우리의 첫 프로그램!
        Debug.Log("게임이 시작되었습니다!");
     
    }

    void Update()
    {
        number += 1;
        Debug.Log("매 프레임마다 실행됩니다!");
        Debug.Log(number);
    }
}