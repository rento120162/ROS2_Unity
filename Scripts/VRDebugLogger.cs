using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;

public class VRDebugLogger : MonoBehaviour
{
    [SerializeField] private VRTracker vrtracker;

    [SerializeField] private TextMeshProUGUI head_console;
    [SerializeField] private TextMeshProUGUI lhRot_console;
    [SerializeField] private TextMeshProUGUI lhPos_console;
    [SerializeField] private TextMeshProUGUI lhInput_console;
    [SerializeField] private TextMeshProUGUI rhRot_console;
    [SerializeField] private TextMeshProUGUI rhPos_console;
    [SerializeField] private TextMeshProUGUI rhInput_console;

    void Update()
    {
        if (vrtracker == null) return;

        if (vrtracker.TryGetDeviceRotation(InputDeviceCharacteristics.HeadMounted, out Quaternion headRot))
        {
            head_console.text = "Head Rotation : " + headRot.eulerAngles;
        }

        if (vrtracker.TryGetDeviceRotation(
            InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller,
            out Quaternion leftRot))
        {
            lhRot_console.text = "Left Hand Rotation: " + leftRot.eulerAngles;
        }

        if (vrtracker.TryGetDeviceRotation(
            InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller,
            out Quaternion rightRot))
        {
            rhRot_console.text = "Right Hand Rotation: " + rightRot.eulerAngles;
        }

        if (vrtracker.TryGetControllerPosition(
            InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller,
            out Vector3 leftPos))
        {
            lhPos_console.text = "Left Hand Position: " + leftPos;
        }

        if (vrtracker.TryGetControllerPosition(
            InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller,
            out Vector3 rightPos))
        {
            rhPos_console.text = "Right Hand Position: " + rightPos;
        }

        if (vrtracker.TryGetController(
            InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller,
            "Left",
            out float[] lcontInput))
        {
            lhInput_console.text =
                $"Stick({lcontInput[0]:F2}, {lcontInput[1]:F2}) " +
                $"Trig({lcontInput[2]:F2}) Grip({lcontInput[3]:F2})"+
                $"botton({lcontInput[4]}, {lcontInput[5]})";
        }

        if (vrtracker.TryGetController(
            InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller,
            "Right",
            out float[] rcontInput))
        {
            rhInput_console.text =
                $"Stick({rcontInput[0]:F2}, {rcontInput[1]:F2}) " +
                $"Trig({rcontInput[2]:F2}) Grip({rcontInput[3]:F2})"+
                $"botton({rcontInput[4]}, {rcontInput[5]})";
        }
    }
}

