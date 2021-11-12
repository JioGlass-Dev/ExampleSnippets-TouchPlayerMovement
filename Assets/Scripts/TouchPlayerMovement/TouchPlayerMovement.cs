using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JMRSDK.InputModule;
using System;
using TMPro;

namespace JMRSDKExampleSnippets.TouchPlayerMovement
{
    /// <summary>
    /// The TouchPlayerMovement class handles the functionality for making the player move using Touch Actions.
    /// </summary>
    /// <remarks>
    /// Please make sure that JMRInteraction Script is attached 
    /// </remarks>
    public class TouchPlayerMovement : MonoBehaviour
    {
        /// <summary>
        /// The reference to the JMRMixedReality GameObject in the scene
        /// </summary>
        public GameObject jMRMixedReality;
        /// <summary>
        /// The reference to the JMRRig GameObject in the Scene. The JMRRig is a child of JMRMixedReality
        /// </summary>
        public GameObject jMRRig;
        /// <summary>
        /// The speed of the movement of the player
        /// </summary>
        public float speed = 10f;

        Vector3 direction;

        /// <summary>
        /// Check for movement every frame and call function for movement
        /// </summary>
        public void Update()
        {
            Vector2 touchValue = GetTouchValue();
            float yValue = touchValue.y;
            float xValue = touchValue.x;


            if (Mathf.Abs(yValue - 0.0f) <= 0.3f && Mathf.Abs(xValue - 0.5f) <= 0.3f)
            {
                MoveForward();
            }

            if (Mathf.Abs(yValue - 1.0f) <= 0.3f && Mathf.Abs(xValue - 0.5f) <= 0.3f)
            {
                MoveBack();
            }

            if (Mathf.Abs(xValue - 0.0f) <= 0.3f && Mathf.Abs(yValue - 0.5f) <= 0.3f)
            {
                MoveLeft();
            }

            if (Mathf.Abs(xValue - 1.0f) <= 0.3f && Mathf.Abs(yValue - 0.5f) <= 0.3f)
            {
                MoveRight();
            }
        }

        /// <summary>
        /// Get the Touch Value of the Trackpad
        /// </summary>
        /// <returns>Touchpad Value</returns>
        public Vector2 GetTouchValue()
        {
            return JMRInteraction.GetTouch();
        }

        /// <summary>
        /// Handles functionality for moving right
        /// </summary>
        public void MoveRight()
        {
            direction = jMRRig.transform.right * speed * Time.deltaTime;
            direction.y = 0;

            jMRMixedReality.transform.position += direction;
        }


        /// <summary>
        /// Handles functionality for moving left
        /// </summary>
        public void MoveLeft()
        {
            direction = jMRRig.transform.right * speed * Time.deltaTime;
            direction.y = 0;

            jMRMixedReality.transform.position -= direction;
        }

        /// <summary>
        /// Handles functionality for moving forward
        /// </summary>
        public void MoveForward()
        {
            direction = jMRRig.transform.forward * speed * Time.deltaTime;
            direction.y = 0;

            jMRMixedReality.transform.position += direction;
        }

        /// <summary>
        /// Handles functionality for moving back
        /// </summary>
        public void MoveBack()
        {
            direction = jMRRig.transform.forward * speed * Time.deltaTime;
            direction.y = 0;

            jMRMixedReality.transform.position -= direction;
        }
    }
}

