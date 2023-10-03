using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager Instance;

    public Color[] CellColors;
    public Color PointsDarkColor;
    public Color PointsLightColor;

    private void Awake()
    {
        
        if (Instance == null)
        {
             Instance = this;
        }
        else
        {
           Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}