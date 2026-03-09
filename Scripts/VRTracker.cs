using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRTracker : MonoBehaviour
{
    /*
    void Update()
    {
        // 1. 顔（ヘッドセット）の傾きを取得
        if (TryGetDeviceRotation(InputDeviceCharacteristics.HeadMounted, out Quaternion headRot))
        {
            // headRot.eulerAngles で X, Y, Z の回転角
            Debug.Log($"Head Rotation: {headRot.eulerAngles}");
        }

        // 2. 左手コントローラーの傾きを取得
        if (TryGetDeviceRotation(InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller, out Quaternion leftRot))
        {
            Debug.Log($"Left Controller Rotation: {leftRot.eulerAngles}");
        }
        // 左手コントローラーの入力を取得
        GetControllerInputs(InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller, "Left");

        // 右手コントローラーの入力を取得
        GetControllerInputs(InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller, "Right");
    }*/

    public bool TryGetDeviceRotation(
        InputDeviceCharacteristics characteristic, 
        out Quaternion rotation)
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(characteristic, devices);

        if (devices.Count > 0)
        {
            if (devices[0].TryGetFeatureValue(CommonUsages.deviceRotation, out rotation))
            {
                return true;
            }
        }
        rotation = Quaternion.identity;
        return false;
    }
    public bool TryGetControllerPosition(
        InputDeviceCharacteristics characteristic,
        out Vector3 position)
        {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(characteristic, devices);

        if (devices.Count > 0)
        {
            InputDevice device = devices[0];

            if (device.TryGetFeatureValue(CommonUsages.devicePosition, out position))
            {
                return true;
            }
        }

        position = Vector3.zero;
        return false;
    }

    public bool TryGetController(
        InputDeviceCharacteristics characteristic,
        string label,
        out float[] contValues)
    {
        contValues = new float[6];
        // 0: stickX
        // 1: stickY
        // 2: trigger
        // 3: grip
        // 4: primaryButton
        // 5: secondaryButton

        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(characteristic, devices);

        if (devices.Count > 0)
        {
            InputDevice device = devices[0];

            // Stick
            if (device.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 stickValue))
            {
                contValues[0] = stickValue.x;
                contValues[1] = stickValue.y;

                if (stickValue.magnitude > 0.1f)
                    Debug.Log($"{label} Stick: {stickValue}");
            }

            // Trigger
            if (device.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
            {
                contValues[2] = triggerValue;
                if (triggerValue > 0.01f)
                    Debug.Log($"{label} Trigger: {triggerValue}");
            }

            // Grip
            if (device.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
            {
                contValues[3] = gripValue;
                Debug.Log($"{label} Grip: {gripValue}");
            }

            // Primary Button
            if (device.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryPressed))
            {
                contValues[4] = primaryPressed ? 1f : 0f;

                if (primaryPressed)
                    Debug.Log($"{label} Primary Button Pressed!");
            }

            // Secondary Button
            if (device.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryPressed))
            {
                contValues[5] = secondaryPressed ? 1f : 0f;

                if (secondaryPressed)
                    Debug.Log($"{label} Secondary Button Pressed!");
            }

            return true;
        }

        return false;
    }
}
