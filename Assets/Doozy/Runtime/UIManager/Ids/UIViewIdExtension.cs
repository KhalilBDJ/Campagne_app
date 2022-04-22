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
        public static IEnumerable<UIView> GetViews(UIViewId.Accueil id) => GetViews(nameof(UIViewId.Accueil), id.ToString());
        public static void Show(UIViewId.Accueil id, bool instant = false) => Show(nameof(UIViewId.Accueil), id.ToString(), instant);
        public static void Hide(UIViewId.Accueil id, bool instant = false) => Hide(nameof(UIViewId.Accueil), id.ToString(), instant);

        public static IEnumerable<UIView> GetViews(UIViewId.Activités id) => GetViews(nameof(UIViewId.Activités), id.ToString());
        public static void Show(UIViewId.Activités id, bool instant = false) => Show(nameof(UIViewId.Activités), id.ToString(), instant);
        public static void Hide(UIViewId.Activités id, bool instant = false) => Hide(nameof(UIViewId.Activités), id.ToString(), instant);

        public static IEnumerable<UIView> GetViews(UIViewId.Teams id) => GetViews(nameof(UIViewId.Teams), id.ToString());
        public static void Show(UIViewId.Teams id, bool instant = false) => Show(nameof(UIViewId.Teams), id.ToString(), instant);
        public static void Hide(UIViewId.Teams id, bool instant = false) => Hide(nameof(UIViewId.Teams), id.ToString(), instant);
    }
}

namespace Doozy.Runtime.UIManager
{
    public partial class UIViewId
    {
        public enum Accueil
        {
            Main,
            MoreMenu
        }

        public enum Activités
        {
            Activitésdujour,
            AllosDuJour,
            Opésdujour
        }

        public enum Teams
        {
            AEIREPSOOPE,
            BDA,
            BDS,
            BUREAU,
            COM,
            KAWA,
            OPES,
            PARTENRARIAT,
            SOIREE
        }    
    }
}