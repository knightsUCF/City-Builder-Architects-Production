using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// GameTime sets the pie charts at the end of each "turn"



public class PieCharts : MonoBehaviour
{


    public Sprite pieChart0;
    public Sprite pieChart25;
    public Sprite pieChart50;
    public Sprite pieChart75;
    public Sprite pieChart100;

    
    public Image foodPieChart;
    public Image apparelPieChart;
    public Image electronicsPieChart;

    Market market;



    void Awake()
    {
        market = FindObjectOfType<Market>();
    }



    public void Set()
    {
        foodPieChart.sprite = TabulatePieChart(market.totalFoodStores);
        apparelPieChart.sprite = TabulatePieChart(market.totalApparelStores);
        electronicsPieChart.sprite = TabulatePieChart(market.totalElectronicsStores);   
    }



    Sprite TabulatePieChart(int count)
    {
        if (count < 1) return pieChart0;
        if (count > 0 && count < 3) return pieChart25;
        if (count > 3 && count < 6) return pieChart50;
        if (count > 6) return pieChart100;
        else return pieChart100;
    }
}
