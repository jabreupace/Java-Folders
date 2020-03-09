using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    // Start is called before the first frame update
    public static int lives = 3;
    public static int level = 1;

    public static bool isWin = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void reset()
    {
        lives = 3;
        level = 1;

        isWin = false;
    }
}
