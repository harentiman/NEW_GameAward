﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomInputKey
{

    /// <summary>
    /// Custom InputKey
    /// </summary>
    public static class CustomInput
    {
        static bool isCheck_Input;
        static bool preventContinuityInput;

        static float buttonDownTime;
        static float timer;

        /// <summary>
        /// Simultaneous input prohibited
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool SingleInputKeyDown(KeyCode key)
        {
            if (Input.anyKeyDown == false) isCheck_Input = false;

            if (isCheck_Input == false)
            {
                if (Input.GetKeyDown(key))
                {
                    isCheck_Input = true;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Continuity input prohibited
        /// </summary>
        /// <param name="key"></param>
        /// <param name="intervalSeconds"></param>
        /// <returns></returns>
        public static bool Interval_InputKeydown(KeyCode key, float intervalSeconds)
        {
            timer = Time.time;

            if (Input.GetKeyDown(key) && timer - buttonDownTime >= intervalSeconds)
            {
                if (preventContinuityInput == false)
                {
                    preventContinuityInput = true;
                    buttonDownTime = Time.time;
                    return true;
                }
                else if (preventContinuityInput)
                {
                    preventContinuityInput = false;
                    buttonDownTime = Time.time;
                    return true;
                }
            }

            return false;
        }

        public static bool Interval_InputKeydown(string name, float intervalSeconds)
        {
            timer = Time.time;

            if (Input.GetKeyDown(name) && timer - buttonDownTime >= intervalSeconds)
            {
                if (preventContinuityInput == false)
                {
                    preventContinuityInput = true;
                    buttonDownTime = Time.time;
                    return true;
                }
                else if (preventContinuityInput)
                {
                    preventContinuityInput = false;
                    buttonDownTime = Time.time;
                    return true;
                }
            }

            return false;
        }
    }

    namespace CustomInputKey2
    {

        /// <summary>
        /// Custom InputKey
        /// </summary>
        public static class CustomInput2
        {
            static bool isCheck_Input;
            static bool preventContinuityInput;

            static float buttonDownTime;
            static float timer;

            /// <summary>
            /// Simultaneous input prohibited
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public static bool SingleInputKeyDown2(KeyCode key)
            {
                if (Input.anyKeyDown == false) isCheck_Input = false;

                if (isCheck_Input == false)
                {
                    if (Input.GetKeyDown(key))
                    {
                        isCheck_Input = true;
                        return true;
                    }
                }
                return false;
            }

            /// <summary>
            /// Continuity input prohibited
            /// </summary>
            /// <param name="key"></param>
            /// <param name="intervalSeconds"></param>
            /// <returns></returns>
            public static bool Interval_InputKeydown2(KeyCode key, float intervalSeconds)
            {
                timer = Time.time;

                if (Input.GetKeyDown(key) && timer - buttonDownTime >= intervalSeconds)
                {
                    if (preventContinuityInput == false)
                    {
                        preventContinuityInput = true;
                        buttonDownTime = Time.time;
                        return true;
                    }
                    else if (preventContinuityInput)
                    {
                        preventContinuityInput = false;
                        buttonDownTime = Time.time;
                        return true;
                    }
                }

                return false;
            }

            public static bool Interval_InputKeydown2(string name, float intervalSeconds)
            {
                timer = Time.time;

                if (Input.GetKeyDown(name) && timer - buttonDownTime >= intervalSeconds)
                {
                    if (preventContinuityInput == false)
                    {
                        preventContinuityInput = true;
                        buttonDownTime = Time.time;
                        return true;
                    }
                    else if (preventContinuityInput)
                    {
                        preventContinuityInput = false;
                        buttonDownTime = Time.time;
                        return true;
                    }
                }

                return false;
            }
        }
    }

}
