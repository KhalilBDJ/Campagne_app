﻿// Copyright (c) 2015 - 2022 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

using Doozy.Runtime.UIManager.Utils;
using UnityEngine;
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable MemberCanBePrivate.Global

namespace Doozy.Runtime.UIManager.Animators
{
    [RequireComponent(typeof(RectTransform))]
    public abstract class BaseTargetComponentAnimator<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected RectTransform m_RectTransform;
        /// <summary> Reference to the RectTransform component </summary>
        public RectTransform rectTransform => m_RectTransform ? m_RectTransform : m_RectTransform = GetComponent<RectTransform>();
        
        [SerializeField] private T Controller;
        /// <summary> Target controller </summary>
        public T controller => Controller;
        
        /// <summary> Check if a target controller is referenced or not </summary>
        public bool hasController => controller != null;

        /// <summary> Flag that keeps track if this Animator is connected to a controller </summary>
        public bool isConnected { get; protected set; }
        
        protected bool animatorInitialized { get; set; }
        
        protected bool inLayoutGroup { get; set; }
        
        
        /// <summary> Set a new target controller and connect to it </summary>
        /// <param name="newTarget"> New target controller </param>
        public virtual void SetController(T newTarget)
        {
            if (hasController && isConnected) Disconnect();
            Controller = newTarget;
            if (!hasController) return;
            if (!isActiveAndEnabled) return;
            Connect();
        }
        
        #if UNITY_EDITOR
        protected virtual void Reset()
        {
            T[] array = gameObject.GetComponentsInParent<T>(true);
            Controller = array != null && array.Length > 0 ? array[0] : null;
            if (controller != null)
            {
                SetController(controller);
            }
            UpdateSettings();
        }
        #endif

        protected virtual void Awake()
        {
            if(!Application.isPlaying) return;
            animatorInitialized = false;
            m_RectTransform = GetComponent<RectTransform>();
            UpdateSettings();
            Connect();
        }

        protected virtual void Start()
        {
            if(!Application.isPlaying) return;
            InitializeAnimator();
        }

        protected virtual void OnEnable()
        {
            if(!Application.isPlaying) return;
            inLayoutGroup = rectTransform.InLayoutGroup();
        }

        protected virtual void OnDisable()
        {
            if(!Application.isPlaying) return;
            Disconnect();
        }

        protected virtual void OnDestroy() {}
        
        /// <summary> Connect to the referenced target controller </summary>
        protected virtual void Connect()
        {
            if (!hasController) return;
            if (isConnected) return;
            ConnectToController();
            isConnected = true;
        }

        /// <summary> Disconnect from the referenced target UISelectable </summary>
        protected virtual void Disconnect()
        {
            if (!hasController) return;
            if (!isConnected) return;
            DisconnectFromController();
            StopAllReactions();
            isConnected = false;
        }

        protected virtual void InitializeAnimator()
        {
            animatorInitialized = true;
        }
        
        protected abstract void ConnectToController();
        protected abstract void DisconnectFromController();
        
        public abstract void UpdateSettings();
        public abstract void StopAllReactions();
    }
}
