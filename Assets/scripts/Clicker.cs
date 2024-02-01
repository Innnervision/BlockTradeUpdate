using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clicker : MonoBehaviour
{
    //clicker
    public TMP_Text scoretext;
    public TMP_Text timetext;
    public float CurrentScore;
    public float hitPower;
    public float ScoreIncreasedPerSecond;
    public float x;


    //SHOP for buy farms
    public int farm1prize;
    public int farm2prize;
    public int farm3prize;
    public int farm4prize;
    public int farm5prize;
    public int farm6prize;
    public int farm7prize;
    public int farm8prize;
    public int farm9prize;

    // SHOP for buy Energy Supply
    public int energy2prize;
    public int energy3prize;
    public int energy4prize;
    public int energy5prize;
    public int energy6prize;
    public int energy7prize;
    public int energy8prize;
    public int energy9prize;
    public int energy10prize;

    // Shop for the cactory Upgrades
    public int factory2prize;
    public int factory3prize;
    public int factory4prize;
    public int factory5prize;
    public int factory6prize;
    public int factory7prize;
    public int factory8prize;
    public int factory9prize;
    public int factory10prize;


    //time manage
    public float YourTimeBasedIncreaseAmount = 0.5f;
    public float timeamount = 1f;

    void Start()
    {
        //CLICKER
        CurrentScore = 5000;
        hitPower = 1;
        ScoreIncreasedPerSecond = 1;
        x = 0f;

        // set all default variables for farm prizes before load 
        farm1prize = 10;
        farm2prize = 20;
        farm3prize = 30;
        farm4prize = 40;
        farm5prize = 45;
        farm6prize = 50;
        farm7prize = 55;
        farm8prize = 60;
        farm9prize = 65;

        // Energy supply prizes
        energy2prize = 1;
        energy3prize = 2;
        energy4prize = 3;
        energy5prize = 4;
        energy6prize = 5;
        energy7prize = 6;
        energy8prize = 7;
        energy9prize = 8;
        energy10prize = 9;

        //Factory Upgrade Prizes
        factory2prize = 5;
        factory3prize = 10;
        factory4prize = 15;
        factory5prize = 20;
        factory6prize = 25;
        factory7prize = 35;
        factory8prize = 40;
        factory9prize = 45;
        factory10prize = 50;


    }

    // Update is called once per frame
    void Update()
    {
        //CLICKER
        scoretext.text = (int)CurrentScore + " $";
        ScoreIncreasedPerSecond = x * Time.deltaTime;
        CurrentScore = CurrentScore + ScoreIncreasedPerSecond;
    }


    // hits on the button
    public void Hit()
    {
        CurrentScore += hitPower;
    }

    //FARMS
    public void Farm1()
    {
        if (CurrentScore >= farm1prize)
        {
            CurrentScore -= farm1prize;
            x += 0.2f;
        }
    }

    public void Farm2()
    {
        if (CurrentScore >= farm2prize)
        {
            CurrentScore -= farm2prize;
            x += 0.2f;
        }
    }

    public void Farm3()
    {
        if (CurrentScore >= farm3prize)
        {
            CurrentScore -= farm3prize;
            x += 0.2f;
        }
    }

    public void Farm4()
    {
        if (CurrentScore >= farm4prize)
        {
            CurrentScore -= farm4prize;
            x += 0.2f;
        }
    }

    public void Farm5()
    {
        if (CurrentScore >= farm5prize)
        {
            CurrentScore -= farm5prize;
            x += 0.2f;
        }
    }

    public void Farm6()
    {
        if (CurrentScore >= farm6prize)
        {
            CurrentScore -= farm6prize;
            x += 0.2f;
        }
    }

    public void Farm7()
    {
        if (CurrentScore >= farm7prize)
        {
            CurrentScore -= farm7prize;
            x += 0.2f;
        }
    }

    public void Farm8()
    {
        if (CurrentScore >= farm8prize)
        {
            CurrentScore -= farm8prize;
            x += 0.2f;
        }
    }

    public void Farm9()
    {
        if (CurrentScore >= farm9prize)
        {
            CurrentScore -= farm9prize;
            x += 0.2f;
        }
    }


    //Energy Supplies function

    public void Energy2()
    {
        if (CurrentScore >= energy2prize)
        {
            CurrentScore -= energy2prize;
            x += 0.2f;
        }
    }

    public void Energy3()
    {
        if (CurrentScore >= energy3prize)
        {
            CurrentScore -= energy3prize;
            x += 0.2f;
        }
    }

    public void Energy4()
    {
        if (CurrentScore >= energy4prize)
        {
            CurrentScore -= energy4prize;
            x += 0.2f;
        }
    }

    public void Energy5()
    {
        if (CurrentScore >= energy5prize)
        {
            CurrentScore -= energy5prize;
            x += 0.2f;
        }
    }

    public void Energy6()
    {
        if (CurrentScore >= energy6prize)
        {
            CurrentScore -= energy6prize;
            x += 0.2f;
        }
    }

    public void Energy7()
    {
        if (CurrentScore >= energy7prize)
        {
            CurrentScore -= energy7prize;
            x += 0.2f;
        }
    }

    public void Energy8()
    {
        if (CurrentScore >= energy8prize)
        {
            CurrentScore -= energy8prize;
            x += 0.2f;
        }
    }

    public void Energy9()
    {
        if (CurrentScore >= energy9prize)
        {
            CurrentScore -= energy9prize;
            x += 0.2f;
        }
    }

    public void Energy10()
    {
        if (CurrentScore >= energy10prize)
        {
            CurrentScore -= energy10prize;
            x += 0.2f;
        }
    }

    // Factory Upgrade Function

    public void Factory2()
    {
        if (CurrentScore >= factory2prize)
        {
            CurrentScore -= factory2prize;
            x += 0.2f;
        }
    }

    public void Factory3()
    {
        if (CurrentScore >= factory3prize)
        {
            CurrentScore -= factory3prize;
            x += 0.2f;
        }
    }

    public void Factory4()
    {
        if (CurrentScore >= factory4prize)
        {
            CurrentScore -= factory4prize;
            x += 0.2f;
        }
    }

    public void Factory5()
    {
        if (CurrentScore >= factory5prize)
        {
            CurrentScore -= factory5prize;
            x += 0.2f;
        }
    }

    public void Factory6()
    {
        if (CurrentScore >= factory6prize)
        {
            CurrentScore -= factory6prize;
            x += 0.2f;
        }
    }

    public void Factory7()
    {
        if (CurrentScore >= factory7prize)
        {
            CurrentScore -= factory7prize;
            x += 0.2f;
        }
    }

    public void Factory8()
    {
        if (CurrentScore >= factory8prize)
        {
            CurrentScore -= factory8prize;
            x += 0.2f;
        }
    }

    public void Factory9()
    {
        if (CurrentScore >= factory9prize)
        {
            CurrentScore -= factory9prize;
            x += 0.2f;
        }
    }

    public void Factory10()
    {
        if (CurrentScore >= factory10prize)
        {
            CurrentScore -= factory10prize;
            x += 0.2f;
        }
    }
}