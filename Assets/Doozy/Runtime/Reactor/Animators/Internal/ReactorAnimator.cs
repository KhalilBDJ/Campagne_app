﻿// Copyright (c) 2015 - 2022 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

using System;
using System.Collections;
using UnityEngine;

namespace Doozy.Runtime.Reactor.Animators.Internal
{
    [Serializable]
    public abstract class ReactorAnimator : MonoBehaviour
    {
        /// <summary> Animator name </summary>
        public string AnimatorName;

        /// <summary> animator behaviour on Start </summary>
        public AnimatorBehaviour OnStartBehaviour = AnimatorBehaviour.Disabled;
        
        /// <summary> animator behaviour on Enable </summary>
        public AnimatorBehaviour OnEnableBehaviour = AnimatorBehaviour.Disabled;
        
        protected bool animatorInitialized { get; set; }
        
        protected virtual void Awake()
        {
            if(!Application.isPlaying) return;
            animatorInitialized = false;
            ValidateAnimation();
        }
        
        protected virtual void OnEnable()
        {
            if(!Application.isPlaying) return;
            ValidateAnimation();
            // UpdateValues();
            RunBehaviour(OnEnableBehaviour);
        }

        protected virtual void Start()
        {
            if(!Application.isPlaying) return;
            ValidateAnimation();
            // UpdateValues();
            RunBehaviour(OnStartBehaviour);
        }

        protected virtual void OnDestroy()
        {
            if(!Application.isPlaying) return;
            Recycle();
        }

        protected virtual void InitializeAnimator()
        {
            animatorInitialized = true;
        }
        
        protected void RunBehaviour(AnimatorBehaviour behaviour)
        {
            if (!animatorInitialized)
            {
                StartCoroutine(RunBehaviourDelayed(behaviour));
                return;
            }
            
            switch (behaviour)
            {
                case AnimatorBehaviour.Disabled:
                    //ignored
                    return;
                
                case AnimatorBehaviour.PlayForward:
                  
                    Play(PlayDirection.Forward);
                    return;
                
                case AnimatorBehaviour.PlayReverse:
                    Play(PlayDirection.Reverse);
                    return;
                
                case AnimatorBehaviour.SetFromValue:
                    SetProgressAtZero();
                    return;
                
                case AnimatorBehaviour.SetToValue:
                    SetProgressAtOne();
                    return;
                
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected IEnumerator RunBehaviourDelayed(AnimatorBehaviour behaviour)
        {
            yield return new WaitUntil(() => animatorInitialized);
            RunBehaviour(behaviour);
        }

        public virtual void Play(bool inReverse = false) =>
            ValidateAnimation();

        public virtual void Play(PlayDirection playDirection) =>
            ValidateAnimation();

        public abstract void SetTarget(object target);
        public abstract void ResetToStartValues(bool forced = false);
        public abstract void ValidateAnimation();
        public abstract void UpdateValues();

        public abstract void PlayToProgress(float toProgress);
        public abstract void PlayFromProgress(float fromProgress);
        public abstract void PlayFromToProgress(float fromProgress, float toProgress);

        public abstract void Stop();
        public abstract void Finish();
        public abstract void Reverse();
        public abstract void Rewind();
        public abstract void Pause();
        public abstract void Resume();

        public abstract void SetProgressAtOne();
        public abstract void SetProgressAtZero();
        public abstract void SetProgressAt(float targetProgress);
        protected abstract void Recycle();
    }
}
