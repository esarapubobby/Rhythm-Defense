using UnityEngine;
using UnityEngine.UI;

public class TrashProgress : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    public float value = 0;

    void Update()
    {
       
        value -= 1.1f * Time.deltaTime;

        if (value < 0) value = 0;
        if (value > 100) value = 100;

        slider.value = value;

       
        if (value < 50)
            fill.color = Color.red;
        else if (value < 80)
            fill.color = Color.yellow;
        else
            fill.color = Color.green;
    }

    public void AddTrash()
    {
        value += 10;
    }

    public void HitBomb()
    {
        value -= 20;
    }
}