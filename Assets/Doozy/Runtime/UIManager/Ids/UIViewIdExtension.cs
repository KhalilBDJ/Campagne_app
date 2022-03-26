// Copyright (c) 2015 - 2021 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using System.Collections.Generic;
// ReSharper disable All
namespace Doozy.Runtime.UIManager.Containers
{
    public partial class UIView
    {
        public static IEnumerable<UIView> GetViews(UIViewId.ARPage id) => GetViews(nameof(UIViewId.ARPage), id.ToString());
        public static void Show(UIViewId.ARPage id, bool instant = false) => Show(nameof(UIViewId.ARPage), id.ToString(), instant);
        public static void Hide(UIViewId.ARPage id, bool instant = false) => Hide(nameof(UIViewId.ARPage), id.ToString(), instant);

        public static IEnumerable<UIView> GetViews(UIViewId.Global id) => GetViews(nameof(UIViewId.Global), id.ToString());
        public static void Show(UIViewId.Global id, bool instant = false) => Show(nameof(UIViewId.Global), id.ToString(), instant);
        public static void Hide(UIViewId.Global id, bool instant = false) => Hide(nameof(UIViewId.Global), id.ToString(), instant);

        public static IEnumerable<UIView> GetViews(UIViewId.Homepage id) => GetViews(nameof(UIViewId.Homepage), id.ToString());
        public static void Show(UIViewId.Homepage id, bool instant = false) => Show(nameof(UIViewId.Homepage), id.ToString(), instant);
        public static void Hide(UIViewId.Homepage id, bool instant = false) => Hide(nameof(UIViewId.Homepage), id.ToString(), instant);

        public static IEnumerable<UIView> GetViews(UIViewId.Popup id) => GetViews(nameof(UIViewId.Popup), id.ToString());
        public static void Show(UIViewId.Popup id, bool instant = false) => Show(nameof(UIViewId.Popup), id.ToString(), instant);
        public static void Hide(UIViewId.Popup id, bool instant = false) => Hide(nameof(UIViewId.Popup), id.ToString(), instant);

        public static IEnumerable<UIView> GetViews(UIViewId.SplashScreen id) => GetViews(nameof(UIViewId.SplashScreen), id.ToString());
        public static void Show(UIViewId.SplashScreen id, bool instant = false) => Show(nameof(UIViewId.SplashScreen), id.ToString(), instant);
        public static void Hide(UIViewId.SplashScreen id, bool instant = false) => Hide(nameof(UIViewId.SplashScreen), id.ToString(), instant);
        public static IEnumerable<UIView> GetViews(UIViewId.Survey id) => GetViews(nameof(UIViewId.Survey), id.ToString());
        public static void Show(UIViewId.Survey id, bool instant = false) => Show(nameof(UIViewId.Survey), id.ToString(), instant);
        public static void Hide(UIViewId.Survey id, bool instant = false) => Hide(nameof(UIViewId.Survey), id.ToString(), instant);
    }
}

namespace Doozy.Runtime.UIManager
{
    public partial class UIViewId
    {
        public enum ARPage
        {
            HOME,
            POI1,
            POI2,
            POI3,
            POI4,
            POI5,
            VIEW1,
            VIEW2,
            VIEW3,
            VIEW4,
            VIEW5
        }

        public enum Global
        {
            Sidebar
        }

        public enum Homepage
        {
            AboutExplanation,
            AboutTitle,
            MainExplanation,
            MainLogo,
            MainTitle,
            SurveyContent,
            SurveyTitle
        }

        public enum Popup
        {
            Alert,
            YesNo
        }

        public enum SplashScreen
        {
            Main
        }
        public enum Survey
        {
            Age,
            App,
            End,
            Experience,
            Main,
            Next,
            Previous,
            Send,
            Suggestion,
            Top,
            Visit
        }    
    }
}