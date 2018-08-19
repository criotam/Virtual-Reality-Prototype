﻿using UnityEngine;

public class OperationsButtons : MonoBehaviour {
    
    public Material primaryMaterial, SecondaryMaterial;

    FrontOperation _frontOperation;
    public bool ButtonIsActive { get; set; }
    
    void Start() {
        ButtonIsActive = false;
        _frontOperation = GetComponentInParent<FrontOperation>();
    }

    public void SetButtonFalse() { ButtonIsActive = false; }

    public void OnPointerEnter() {
        if (ButtonIsActive) {
            return;
        }
        _frontOperation.SetButtonMaterial(SecondaryMaterial, this.gameObject);
    }

    public void OnPointerExit() {
        if (ButtonIsActive) {
            return;
        }
        _frontOperation.SetButtonMaterial(primaryMaterial, this.gameObject);
    }

    public void RunIsClicked() {

        if (GameObject.FindGameObjectWithTag("MonitorLevel") == null)
        {
            Debug.Log("No MonitorLevel in scene!");
            return;
        }

        MonitorControl mc = GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<MonitorControl>();
        bool value = mc.VerifyValues();
        if (value == false)
            return;

        BlanketControl bc = GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<BlanketControl>();
        value = bc.AllBlanketHasSheet();
        if (value == false)
        {
            Debug.Log("Blanket Does not have any sheets");
            return;
        }
            

        if (!ButtonIsActive)
        {
            _frontOperation.SetRunTrue();
            Debug.Log("Operation Buttons: ButtonIsActive true");
            ButtonIsActive = true;
        }
        else {
            _frontOperation.SetRunFalse();
            ButtonIsActive = false;
            Debug.Log("Operation Buttons: ButtonIsActive false");
        }
    }

    public void PaperIsClicked()
    {

        if (!ButtonIsActive)
        {
            bool temp = _frontOperation.SetPaperTrue();
            if (temp) {
                Debug.Log("Operation Buttons: ButtonIsActive true");
                ButtonIsActive = true;
            }
        }
        else
        {
            _frontOperation.SetPaperFalse();
            ButtonIsActive = false;
            Debug.Log("Operation Buttons: ButtonIsActive false");
        }
    }

    public void ImpressionIsClicked()
    {

        if (!ButtonIsActive)
        {
            bool temp = _frontOperation.SetImpressionTrue();
            if (temp) {
                Debug.Log("Operation Buttons: ButtonIsActive true");
                ButtonIsActive = true;
                GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<AudioController>().StartMachineAudio();
            }
        }
        else
        {
            _frontOperation.SetImpressionFalse();
            ButtonIsActive = false;
            Debug.Log("Operation Buttons: ButtonIsActive false");
            GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<AudioController>().StopMachineAudio();
        }
    }
}