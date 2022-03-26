// Copyright (c) 2015 - 2021 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using UnityEngine;
// ReSharper disable All

namespace Doozy.Runtime.Signals
{
    public partial class Signal
    {
        public static bool Send(StreamId.Navigation id, string message = "") => SignalsService.SendSignal(nameof(StreamId.Navigation), id.ToString(), message);
        public static bool Send(StreamId.Navigation id, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.Navigation), id.ToString(), signalSource, message);
        public static bool Send(StreamId.Navigation id, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.Navigation), id.ToString(), signalProvider, message);
        public static bool Send(StreamId.Navigation id, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.Navigation), id.ToString(), signalSender, message);
        public static bool Send<T>(StreamId.Navigation id, T signalValue, string message = "") => SignalsService.SendSignal(nameof(StreamId.Navigation), id.ToString(), signalValue, message);
        public static bool Send<T>(StreamId.Navigation id, T signalValue, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.Navigation), id.ToString(), signalValue, signalSource, message);
        public static bool Send<T>(StreamId.Navigation id, T signalValue, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.Navigation), id.ToString(), signalValue, signalProvider, message);
        public static bool Send<T>(StreamId.Navigation id, T signalValue, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.Navigation), id.ToString(), signalValue, signalSender, message);

        public static bool Send(StreamId.Network id, string message = "") => SignalsService.SendSignal(nameof(StreamId.Network), id.ToString(), message);
        public static bool Send(StreamId.Network id, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.Network), id.ToString(), signalSource, message);
        public static bool Send(StreamId.Network id, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.Network), id.ToString(), signalProvider, message);
        public static bool Send(StreamId.Network id, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.Network), id.ToString(), signalSender, message);
        public static bool Send<T>(StreamId.Network id, T signalValue, string message = "") => SignalsService.SendSignal(nameof(StreamId.Network), id.ToString(), signalValue, message);
        public static bool Send<T>(StreamId.Network id, T signalValue, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.Network), id.ToString(), signalValue, signalSource, message);
        public static bool Send<T>(StreamId.Network id, T signalValue, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.Network), id.ToString(), signalValue, signalProvider, message);
        public static bool Send<T>(StreamId.Network id, T signalValue, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.Network), id.ToString(), signalValue, signalSender, message);

        public static bool Send(StreamId.Scenes id, string message = "") => SignalsService.SendSignal(nameof(StreamId.Scenes), id.ToString(), message);
        public static bool Send(StreamId.Scenes id, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.Scenes), id.ToString(), signalSource, message);
        public static bool Send(StreamId.Scenes id, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.Scenes), id.ToString(), signalProvider, message);
        public static bool Send(StreamId.Scenes id, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.Scenes), id.ToString(), signalSender, message);
        public static bool Send<T>(StreamId.Scenes id, T signalValue, string message = "") => SignalsService.SendSignal(nameof(StreamId.Scenes), id.ToString(), signalValue, message);
        public static bool Send<T>(StreamId.Scenes id, T signalValue, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.Scenes), id.ToString(), signalValue, signalSource, message);
        public static bool Send<T>(StreamId.Scenes id, T signalValue, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.Scenes), id.ToString(), signalValue, signalProvider, message);
        public static bool Send<T>(StreamId.Scenes id, T signalValue, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.Scenes), id.ToString(), signalValue, signalSender, message);

        public static bool Send(StreamId.Survey id, string message = "") => SignalsService.SendSignal(nameof(StreamId.Survey), id.ToString(), message);
        public static bool Send(StreamId.Survey id, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.Survey), id.ToString(), signalSource, message);
        public static bool Send(StreamId.Survey id, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.Survey), id.ToString(), signalProvider, message);
        public static bool Send(StreamId.Survey id, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.Survey), id.ToString(), signalSender, message);
        public static bool Send<T>(StreamId.Survey id, T signalValue, string message = "") => SignalsService.SendSignal(nameof(StreamId.Survey), id.ToString(), signalValue, message);
        public static bool Send<T>(StreamId.Survey id, T signalValue, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.Survey), id.ToString(), signalValue, signalSource, message);
        public static bool Send<T>(StreamId.Survey id, T signalValue, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.Survey), id.ToString(), signalValue, signalProvider, message);
        public static bool Send<T>(StreamId.Survey id, T signalValue, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.Survey), id.ToString(), signalValue, signalSender, message);

        public static bool Send(StreamId.TrackedImage id, string message = "") => SignalsService.SendSignal(nameof(StreamId.TrackedImage), id.ToString(), message);
        public static bool Send(StreamId.TrackedImage id, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.TrackedImage), id.ToString(), signalSource, message);
        public static bool Send(StreamId.TrackedImage id, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.TrackedImage), id.ToString(), signalProvider, message);
        public static bool Send(StreamId.TrackedImage id, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.TrackedImage), id.ToString(), signalSender, message);
        public static bool Send<T>(StreamId.TrackedImage id, T signalValue, string message = "") => SignalsService.SendSignal(nameof(StreamId.TrackedImage), id.ToString(), signalValue, message);
        public static bool Send<T>(StreamId.TrackedImage id, T signalValue, GameObject signalSource, string message = "") => SignalsService.SendSignal(nameof(StreamId.TrackedImage), id.ToString(), signalValue, signalSource, message);
        public static bool Send<T>(StreamId.TrackedImage id, T signalValue, SignalProvider signalProvider, string message = "") => SignalsService.SendSignal(nameof(StreamId.TrackedImage), id.ToString(), signalValue, signalProvider, message);
        public static bool Send<T>(StreamId.TrackedImage id, T signalValue, Object signalSender, string message = "") => SignalsService.SendSignal(nameof(StreamId.TrackedImage), id.ToString(), signalValue, signalSender, message);   
    }

    public partial class StreamId
    {
        public enum Navigation
        {
            ChangeSceneAction,
            OnViewsHidden,
            TargetSceneName
        }

        public enum Network
        {
            GetError,
            GetStart,
            GetSuccess,
            PostError,
            PostStart,
            PostSuccess
        }

        public enum Scenes
        {
            ARApp,
            Homepage,
            None,
            OnBoarding,
            SplashScreen,
            Survey
        }

        public enum Survey
        {
            EndError,
            EndSuccess,
            NextError,
            NextRequest,
            NextSuccess
        }
        public enum TrackedImage
        {
            CircleAnimEnded,
            Found,
            Lost,
            Targeted
        }         
    }
}
