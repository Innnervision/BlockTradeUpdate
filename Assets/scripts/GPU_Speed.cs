using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class GPU_Speed : MonoBehaviour
{
    public NavMeshAgent agent;
    public Button[] button;

    //Calling another script as a object
    public GpuController1 controller;
    public TokenProgressBar progressBar;

    //calling the clicker script for calculating the money
    public Clicker clicker;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        for (int i = 0; i < button.Length; i++)
        {
            button[i].GetComponent<Button>().interactable = false;
        }

        // Attach button click listeners only once in the Start method
        AttachButtonClickListeners();
    }

    private void AttachButtonClickListeners()
    {

        button[0].onClick.AddListener(FactoryLevel2);
        button[1].onClick.AddListener(FactoryLevel3);
        button[2].onClick.AddListener(FactoryLevel4);
        button[3].onClick.AddListener(FactoryLevel5);
        button[4].onClick.AddListener(FactoryLevel6);
        button[5].onClick.AddListener(FactoryLevel7);
        button[6].onClick.AddListener(FactoryLevel8);
        button[7].onClick.AddListener(FactoryLevel9);
        button[8].onClick.AddListener(FactoryLevel10);
    }

    private void Update()
    {
        FactoryLevel2();
        FactoryLevel3();
        FactoryLevel4();
        FactoryLevel5();
        FactoryLevel6();
        FactoryLevel7();
        FactoryLevel8();
        FactoryLevel9();
        FactoryLevel10();
    }

    public void FactoryLevel2()
    {
        if (controller.count == progressBar.slider.value && clicker.CurrentScore >= clicker.factory2prize)
        {
            button[0].GetComponent<Button>().interactable = true;
            agent.speed = 6f;
        }
        else
        {
            button[0].GetComponent<Button>().interactable = false;
        }
    }

    public void FactoryLevel3()
    {
        if (controller.count == progressBar.slider.value && clicker.CurrentScore >= clicker.factory3prize)
        {
            button[1].GetComponent<Button>().interactable = true;
            agent.speed = 7f;
        }
        else
        {
            button[1].GetComponent<Button>().interactable = false;
        }
    }

    public void FactoryLevel4()
    {
        if (controller.count == progressBar.slider.value && clicker.CurrentScore >= clicker.factory4prize)
        {
            button[2].GetComponent<Button>().interactable = true;
            agent.speed = 8f;
        }
        else
        {
            button[2].GetComponent<Button>().interactable = false;
        }
    }

    public void FactoryLevel5()
    {
        if (controller.count == progressBar.slider.value && clicker.CurrentScore >= clicker.factory5prize)
        {
            button[3].GetComponent<Button>().interactable = true;
            agent.speed = 9f;
        }
        else
        {
            button[3].GetComponent<Button>().interactable = false;
        }
    }

    public void FactoryLevel6()
    {
        if (controller.count == progressBar.slider.value && clicker.CurrentScore >= clicker.factory6prize)
        {
            button[4].GetComponent<Button>().interactable = true;
            agent.speed = 10f;
        }
        else
        {
            button[4].GetComponent<Button>().interactable = false;
        }
    }

    public void FactoryLevel7()
    {
        if (controller.count == progressBar.slider.value && clicker.CurrentScore >= clicker.factory2prize)
        {
            button[5].GetComponent<Button>().interactable = true;
            agent.speed = 11f;
        }
        else
        {
            button[5].GetComponent<Button>().interactable = false;
        }
    }

    public void FactoryLevel8()
    {
        if (controller.count == progressBar.slider.value && clicker.CurrentScore >= clicker.factory8prize)
        {
            button[6].GetComponent<Button>().interactable = true;
            agent.speed = 12f;
        }
        else
        {
            button[6].GetComponent<Button>().interactable = false;
        }
    }

    public void FactoryLevel9()
    {
        if (controller.count == progressBar.slider.value && clicker.CurrentScore >= clicker.factory9prize)
        {
            button[7].GetComponent<Button>().interactable = true;
            agent.speed = 13f;
        }
        else
        {
            button[7].GetComponent<Button>().interactable = false;
        }
    }

    public void FactoryLevel10()
    {
        if (controller.count == progressBar.slider.value && clicker.CurrentScore >= clicker.factory10prize)
        {
            button[8].GetComponent<Button>().interactable = true;

            agent.speed = 100f;
            agent.acceleration = 300f;
        }
        else
        {
            button[8].GetComponent<Button>().interactable = false;
        }

    }
}