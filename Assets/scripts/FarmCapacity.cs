using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FarmCapacity : MonoBehaviour
{
    public int size = 0;
    public GpuController1 gpuController1;
    //public Button[] buttons;

    //calling the alert manager script here
    public AlertManager alertManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("gpu"))
        {
            size++;
            Debug.Log("House capacity: " + size);
            other.gameObject.SetActive(false);
        }


        //checking the condition here for collision
        if (size > gpuController1.capacity1)
        {
            alertManager.ShowAlert1();
        }

        if (size > gpuController1.capacity2)
        {
            alertManager.ShowAlert2();
        }

        if (size > gpuController1.capacity3)
        {
            alertManager.ShowAlert3();
        }

        if (size > gpuController1.capacity4)
        {
            alertManager.ShowAlert4();
        }

        if (size > gpuController1.capacity5)
        {
            alertManager.ShowAlert5();
        }
    }
}