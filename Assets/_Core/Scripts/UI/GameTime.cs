using UnityEngine;

public class GameTime : MonoBehaviour
{
    public void SetGameTime(float time)
    {
        Time.timeScale = time;
    }
}
