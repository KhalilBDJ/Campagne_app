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
namespace Doozy.Runtime.UIManager.Components
{
    public partial class UIButton
    {
        public static IEnumerable<UIButton> GetButtons(UIButtonId.Homepage id) => GetButtons(nameof(UIButtonId.Homepage), id.ToString());
        public static bool SelectButton(UIButtonId.Homepage id) => SelectButton(nameof(UIButtonId.Homepage), id.ToString());

        public static IEnumerable<UIButton> GetButtons(UIButtonId.Popup id) => GetButtons(nameof(UIButtonId.Popup), id.ToString());
        public static bool SelectButton(UIButtonId.Popup id) => SelectButton(nameof(UIButtonId.Popup), id.ToString());

        public static IEnumerable<UIButton> GetButtons(UIButtonId.Sidebar id) => GetButtons(nameof(UIButtonId.Sidebar), id.ToString());
        public static bool SelectButton(UIButtonId.Sidebar id) => SelectButton(nameof(UIButtonId.Sidebar), id.ToString());
        public static IEnumerable<UIButton> GetButtons(UIButtonId.Survey id) => GetButtons(nameof(UIButtonId.Survey), id.ToString());
        public static bool SelectButton(UIButtonId.Survey id) => SelectButton(nameof(UIButtonId.Survey), id.ToString());
    }
}

namespace Doozy.Runtime.UIManager
{
    public partial class UIButtonId
    {
        public enum Homepage
        {
            About,
            Start,
            Survey
        }

        public enum Popup
        {
            Close,
            No,
            Yes
        }

        public enum Sidebar
        {
            Experience,
            Home,
            Settings,
            Survey
        }
        public enum Survey
        {
            Close,
            Next,
            Previous,
            Send,
            Start
        }    
    }
}