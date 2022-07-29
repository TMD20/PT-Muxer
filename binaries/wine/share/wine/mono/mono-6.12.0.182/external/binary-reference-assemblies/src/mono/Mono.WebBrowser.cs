// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Development version")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2007, 2008 Andreia Gaita")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Managed Wrapper for xulrunner engine, to support WebBrowser")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono.WebBrowser")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.WebBrowser")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace Mono.WebBrowser
{
    public partial class AlertEventArgs : System.EventArgs
    {
        public AlertEventArgs() { }
        public bool BoolReturn { get { throw null; } set { } }
        public System.Collections.Specialized.StringCollection Buttons { get { throw null; } set { } }
        public string CheckMessage { get { throw null; } set { } }
        public bool CheckState { get { throw null; } set { } }
        public Mono.WebBrowser.DialogButtonFlags DialogButtons { get { throw null; } set { } }
        public int IntReturn { get { throw null; } set { } }
        public System.Collections.Specialized.StringCollection Options { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public string StringReturn { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public string Text2 { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public Mono.WebBrowser.DialogType Type { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
    }
    public delegate void AlertEventHandler(object sender, Mono.WebBrowser.AlertEventArgs e);
    public partial class ContextMenuEventArgs : System.EventArgs
    {
        public ContextMenuEventArgs(int x, int y) { }
        public int X { get { throw null; } }
        public int Y { get { throw null; } }
    }
    public delegate void ContextMenuEventHandler(object sender, Mono.WebBrowser.ContextMenuEventArgs e);
    public partial class CreateNewWindowEventArgs : System.EventArgs
    {
        public CreateNewWindowEventArgs(bool isModal) { }
        public bool IsModal { get { throw null; } }
    }
    public delegate bool CreateNewWindowEventHandler(object sender, Mono.WebBrowser.CreateNewWindowEventArgs e);
    [System.FlagsAttribute]
    public enum DialogButtonFlags
    {
        BUTTON_DELAY_ENABLE = 67108864,
        BUTTON_POS_0 = 1,
        BUTTON_POS_0_DEFAULT = 0,
        BUTTON_POS_1 = 256,
        BUTTON_POS_1_DEFAULT = 16777216,
        BUTTON_POS_2 = 65536,
        BUTTON_POS_2_DEFAULT = 33554432,
        BUTTON_TITLE_CANCEL = 2,
        BUTTON_TITLE_DONT_SAVE = 6,
        BUTTON_TITLE_IS_STRING = 127,
        BUTTON_TITLE_NO = 4,
        BUTTON_TITLE_OK = 1,
        BUTTON_TITLE_REVERT = 7,
        BUTTON_TITLE_SAVE = 5,
        BUTTON_TITLE_YES = 3,
        STD_OK_CANCEL_BUTTONS = 513,
    }
    public enum DialogType
    {
        Alert = 1,
        AlertCheck = 2,
        Confirm = 3,
        ConfirmCheck = 5,
        ConfirmEx = 4,
        Prompt = 6,
        PromptPassword = 8,
        PromptUsernamePassword = 7,
        Select = 9,
    }
    public partial class Exception : System.Exception
    {
        internal Exception() { }
    }
    public enum FocusOption
    {
        FocusFirstElement = 1,
        FocusLastElement = 2,
        None = 0,
    }
    public partial interface IWebBrowser
    {
        Mono.WebBrowser.DOM.IDocument Document { get; }
        bool Initialized { get; }
        Mono.WebBrowser.DOM.INavigation Navigation { get; }
        bool Offline { get; set; }
        Mono.WebBrowser.DOM.IWindow Window { get; }
        event Mono.WebBrowser.AlertEventHandler Alert;
        event Mono.WebBrowser.ContextMenuEventHandler ContextMenuShown;
        event Mono.WebBrowser.CreateNewWindowEventHandler CreateNewWindow;
        event System.EventHandler Focus;
        event Mono.WebBrowser.DOM.NodeEventHandler KeyDown;
        event Mono.WebBrowser.DOM.NodeEventHandler KeyPress;
        event Mono.WebBrowser.DOM.NodeEventHandler KeyUp;
        event Mono.WebBrowser.LoadCommitedEventHandler LoadCommited;
        event Mono.WebBrowser.LoadFinishedEventHandler LoadFinished;
        event Mono.WebBrowser.LoadStartedEventHandler LoadStarted;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseClick;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseDoubleClick;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseDown;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseEnter;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseLeave;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseMove;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseUp;
        event Mono.WebBrowser.NavigationRequestedEventHandler NavigationRequested;
        event Mono.WebBrowser.ProgressChangedEventHandler ProgressChanged;
        event Mono.WebBrowser.SecurityChangedEventHandler SecurityChanged;
        event Mono.WebBrowser.StatusChangedEventHandler StatusChanged;
        void Activate();
        void Deactivate();
        void ExecuteScript(string script);
        void FocusIn(Mono.WebBrowser.FocusOption focus);
        void FocusOut();
        bool Load(System.IntPtr handle, int width, int height);
        void Render(byte[] data);
        void Render(string html);
        void Render(string html, string uri, string contentType);
        void Resize(int width, int height);
        void Shutdown();
    }
    public partial class LoadCommitedEventArgs : System.EventArgs
    {
        public LoadCommitedEventArgs(string uri) { }
        public string Uri { get { throw null; } }
    }
    public delegate void LoadCommitedEventHandler(object sender, Mono.WebBrowser.LoadCommitedEventArgs e);
    public partial class LoadFinishedEventArgs : System.EventArgs
    {
        public LoadFinishedEventArgs(string uri) { }
        public string Uri { get { throw null; } }
    }
    public delegate void LoadFinishedEventHandler(object sender, Mono.WebBrowser.LoadFinishedEventArgs e);
    public partial class LoadStartedEventArgs : System.ComponentModel.CancelEventArgs
    {
        public LoadStartedEventArgs(string uri, string frameName) { }
        public string FrameName { get { throw null; } }
        public string Uri { get { throw null; } }
    }
    public delegate void LoadStartedEventHandler(object sender, Mono.WebBrowser.LoadStartedEventArgs e);
    public sealed partial class Manager
    {
        public Manager() { }
        public static Mono.WebBrowser.IWebBrowser GetNewInstance() { throw null; }
        public static Mono.WebBrowser.IWebBrowser GetNewInstance(Mono.WebBrowser.Platform platform) { throw null; }
    }
    public partial class NavigationRequestedEventArgs : System.ComponentModel.CancelEventArgs
    {
        public NavigationRequestedEventArgs(string uri) { }
        public string Uri { get { throw null; } }
    }
    public delegate void NavigationRequestedEventHandler(object sender, Mono.WebBrowser.NavigationRequestedEventArgs e);
    public enum Platform
    {
        Gtk = 2,
        Unknown = 0,
        Winforms = 1,
    }
    public partial class ProgressChangedEventArgs : System.EventArgs
    {
        public ProgressChangedEventArgs(int progress, int maxProgress) { }
        public int MaxProgress { get { throw null; } }
        public int Progress { get { throw null; } }
    }
    public delegate void ProgressChangedEventHandler(object sender, Mono.WebBrowser.ProgressChangedEventArgs e);
    public enum ReloadOption : uint
    {
        Full = (uint)2,
        None = (uint)0,
        Proxy = (uint)1,
    }
    public partial class SecurityChangedEventArgs : System.EventArgs
    {
        public SecurityChangedEventArgs(Mono.WebBrowser.SecurityLevel state) { }
        public Mono.WebBrowser.SecurityLevel State { get { throw null; } set { } }
    }
    public delegate void SecurityChangedEventHandler(object sender, Mono.WebBrowser.SecurityChangedEventArgs e);
    public enum SecurityLevel
    {
        Insecure = 1,
        Mixed = 2,
        Secure = 3,
    }
    public partial class StatusChangedEventArgs : System.EventArgs
    {
        public StatusChangedEventArgs(string message, int status) { }
        public string Message { get { throw null; } set { } }
        public int Status { get { throw null; } set { } }
    }
    public delegate void StatusChangedEventHandler(object sender, Mono.WebBrowser.StatusChangedEventArgs e);
}
namespace Mono.WebBrowser.DOM
{
    public partial interface IAttribute : Mono.WebBrowser.DOM.INode
    {
        string Name { get; }
        new int GetHashCode();
    }
    public partial interface IAttributeCollection : Mono.WebBrowser.DOM.INodeList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        Mono.WebBrowser.DOM.IAttribute this[string name] { get; }
        bool Exists(string name);
        new int GetHashCode();
    }
    public partial interface IDocument : Mono.WebBrowser.DOM.INode
    {
        Mono.WebBrowser.DOM.IElement Active { get; }
        string ActiveLinkColor { get; set; }
        Mono.WebBrowser.DOM.IElementCollection Anchors { get; }
        Mono.WebBrowser.DOM.IElementCollection Applets { get; }
        string BackColor { get; set; }
        string Background { get; set; }
        Mono.WebBrowser.DOM.IElement Body { get; }
        string Charset { get; set; }
        string Cookie { get; set; }
        Mono.WebBrowser.DOM.IDocumentType DocType { get; }
        Mono.WebBrowser.DOM.IElement DocumentElement { get; }
        string Domain { get; }
        string ForeColor { get; set; }
        Mono.WebBrowser.DOM.IElementCollection Forms { get; }
        Mono.WebBrowser.DOM.IElementCollection Images { get; }
        Mono.WebBrowser.DOM.IDOMImplementation Implementation { get; }
        string LinkColor { get; set; }
        Mono.WebBrowser.DOM.IElementCollection Links { get; }
        Mono.WebBrowser.DOM.IStylesheetList Stylesheets { get; }
        string Title { get; set; }
        string Url { get; }
        string VisitedLinkColor { get; set; }
        Mono.WebBrowser.DOM.IWindow Window { get; }
        event System.EventHandler LoadStopped;
        Mono.WebBrowser.DOM.IAttribute CreateAttribute(string name);
        Mono.WebBrowser.DOM.IElement CreateElement(string tagName);
        Mono.WebBrowser.DOM.IElement GetElement(int x, int y);
        Mono.WebBrowser.DOM.IElement GetElementById(string id);
        Mono.WebBrowser.DOM.IElementCollection GetElementsByTagName(string id);
        new int GetHashCode();
        string InvokeScript(string script);
        void Write(string text);
    }
    public partial interface IDocumentType : Mono.WebBrowser.DOM.INode
    {
        Mono.WebBrowser.DOM.INamedNodeMap Entities { get; }
        string InternalSubset { get; }
        string Name { get; }
        Mono.WebBrowser.DOM.INamedNodeMap Notations { get; }
        string PublicId { get; }
        string SystemId { get; }
    }
    public partial interface IDOMImplementation
    {
        Mono.WebBrowser.DOM.IDocument CreateDocument(string namespaceURI, string qualifiedName, Mono.WebBrowser.DOM.IDocumentType doctype);
        Mono.WebBrowser.DOM.IDocumentType CreateDocumentType(string qualifiedName, string publicId, string systemId);
        bool HasFeature(string feature, string version);
    }
    public partial interface IElement : Mono.WebBrowser.DOM.INode
    {
        Mono.WebBrowser.DOM.IElementCollection All { get; }
        Mono.WebBrowser.DOM.IElementCollection Children { get; }
        int ClientHeight { get; }
        int ClientWidth { get; }
        System.IO.Stream ContentStream { get; }
        bool Disabled { get; set; }
        string InnerHTML { get; set; }
        string InnerText { get; set; }
        int OffsetHeight { get; }
        int OffsetLeft { get; }
        Mono.WebBrowser.DOM.IElement OffsetParent { get; }
        int OffsetTop { get; }
        int OffsetWidth { get; }
        string OuterHTML { get; set; }
        string OuterText { get; set; }
        int ScrollHeight { get; }
        int ScrollLeft { get; set; }
        int ScrollTop { get; set; }
        int ScrollWidth { get; }
        string Style { get; set; }
        int TabIndex { get; set; }
        string TagName { get; }
        Mono.WebBrowser.DOM.IElement AppendChild(Mono.WebBrowser.DOM.IElement child);
        void Blur();
        void Focus();
        string GetAttribute(string name);
        Mono.WebBrowser.DOM.IElementCollection GetElementsByTagName(string id);
        new int GetHashCode();
        bool HasAttribute(string name);
        void ScrollIntoView(bool alignWithTop);
        void SetAttribute(string name, string value);
    }
    public partial interface IElementCollection : Mono.WebBrowser.DOM.INodeList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        new Mono.WebBrowser.DOM.IElement this[int index] { get; set; }
        new int GetHashCode();
    }
    public partial interface IHistory
    {
        int Count { get; }
        void Back(int count);
        void Forward(int count);
        void GoToIndex(int index);
        void GoToUrl(string url);
    }
    public partial interface IMediaList
    {
    }
    public partial interface INamedNodeMap : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        new Mono.WebBrowser.DOM.INode this[int index] { get; set; }
        Mono.WebBrowser.DOM.INode this[string name] { get; set; }
        Mono.WebBrowser.DOM.INode this[string namespaceURI, string localName] { get; set; }
        Mono.WebBrowser.DOM.INode RemoveNamedItem(string name);
        Mono.WebBrowser.DOM.INode RemoveNamedItemNS(string namespaceURI, string localName);
    }
    public partial interface INavigation
    {
        bool CanGoBack { get; }
        bool CanGoForward { get; }
        int HistoryCount { get; }
        bool Back();
        bool Forward();
        void Go(int index);
        void Go(int index, bool relative);
        void Go(string url);
        void Go(string url, Mono.WebBrowser.DOM.LoadFlags flags);
        void Home();
        void Reload();
        void Reload(Mono.WebBrowser.ReloadOption option);
        void Stop();
    }
    public partial interface INode
    {
        System.IntPtr AccessibleObject { get; }
        Mono.WebBrowser.DOM.IAttributeCollection Attributes { get; }
        Mono.WebBrowser.DOM.INodeList ChildNodes { get; }
        Mono.WebBrowser.DOM.INode FirstChild { get; }
        Mono.WebBrowser.DOM.INode LastChild { get; }
        string LocalName { get; }
        Mono.WebBrowser.DOM.INode Next { get; }
        Mono.WebBrowser.DOM.IDocument Owner { get; }
        Mono.WebBrowser.DOM.INode Parent { get; }
        Mono.WebBrowser.DOM.INode Previous { get; }
        Mono.WebBrowser.DOM.NodeType Type { get; }
        string Value { get; set; }
        event Mono.WebBrowser.DOM.NodeEventHandler Click;
        event Mono.WebBrowser.DOM.NodeEventHandler DoubleClick;
        event Mono.WebBrowser.DOM.NodeEventHandler KeyDown;
        event Mono.WebBrowser.DOM.NodeEventHandler KeyPress;
        event Mono.WebBrowser.DOM.NodeEventHandler KeyUp;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseDown;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseEnter;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseLeave;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseMove;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseOver;
        event Mono.WebBrowser.DOM.NodeEventHandler MouseUp;
        event Mono.WebBrowser.DOM.NodeEventHandler OnBlur;
        event Mono.WebBrowser.DOM.NodeEventHandler OnFocus;
        Mono.WebBrowser.DOM.INode AppendChild(Mono.WebBrowser.DOM.INode child);
        void AttachEventHandler(string eventName, System.Delegate handler);
        void AttachEventHandler(string eventName, System.EventHandler handler);
        void DetachEventHandler(string eventName, System.Delegate handler);
        void DetachEventHandler(string eventName, System.EventHandler handler);
        bool Equals(object obj);
        void FireEvent(string eventName);
        int GetHashCode();
        Mono.WebBrowser.DOM.INode InsertBefore(Mono.WebBrowser.DOM.INode newChild, Mono.WebBrowser.DOM.INode refChild);
        Mono.WebBrowser.DOM.INode RemoveChild(Mono.WebBrowser.DOM.INode child);
        Mono.WebBrowser.DOM.INode ReplaceChild(Mono.WebBrowser.DOM.INode newChild, Mono.WebBrowser.DOM.INode oldChild);
    }
    public partial interface INodeList : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        new Mono.WebBrowser.DOM.INode this[int index] { get; set; }
        int GetHashCode();
    }
    public partial interface IStylesheet
    {
        bool Disabled { get; set; }
        string Href { get; }
        Mono.WebBrowser.DOM.IMediaList Media { get; }
        Mono.WebBrowser.DOM.INode OwnerNode { get; }
        Mono.WebBrowser.DOM.IStylesheet ParentStyleSheet { get; }
        string Title { get; }
        string Type { get; }
    }
    public partial interface IStylesheetList : System.Collections.IEnumerable
    {
        int Count { get; }
        Mono.WebBrowser.DOM.IStylesheet this[int index] { get; set; }
    }
    public partial interface IWindow
    {
        Mono.WebBrowser.DOM.IDocument Document { get; }
        Mono.WebBrowser.DOM.IWindowCollection Frames { get; }
        Mono.WebBrowser.DOM.IHistory History { get; }
        string Name { get; set; }
        Mono.WebBrowser.DOM.IWindow Parent { get; }
        string StatusText { get; }
        Mono.WebBrowser.DOM.IWindow Top { get; }
        event System.EventHandler Error;
        event System.EventHandler Load;
        event System.EventHandler OnBlur;
        event System.EventHandler OnFocus;
        event System.EventHandler Scroll;
        event System.EventHandler Unload;
        void AttachEventHandler(string eventName, System.EventHandler handler);
        void DetachEventHandler(string eventName, System.EventHandler handler);
        bool Equals(object obj);
        void Focus();
        int GetHashCode();
        void Open(string url);
        void ScrollTo(int x, int y);
    }
    public partial interface IWindowCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        new Mono.WebBrowser.DOM.IWindow this[int index] { get; set; }
    }
    [System.FlagsAttribute]
    public enum LoadFlags : uint
    {
        AsLinkClick = (uint)32,
        AsMetaRefresh = (uint)16,
        BypassHistory = (uint)64,
        BypassLocalCache = (uint)256,
        BypassProxy = (uint)512,
        CharsetChange = (uint)1024,
        None = (uint)0,
        ReplaceHistory = (uint)128,
    }
    public partial class NodeEventArgs : System.EventArgs
    {
        public NodeEventArgs(Mono.WebBrowser.DOM.INode node) { }
        public Mono.WebBrowser.DOM.IDocument Document { get { throw null; } }
        public Mono.WebBrowser.DOM.IElement Element { get { throw null; } }
        public Mono.WebBrowser.DOM.INode Node { get { throw null; } }
    }
    public delegate void NodeEventHandler(object sender, Mono.WebBrowser.DOM.NodeEventArgs e);
    public enum NodeType
    {
        Attribute = 2,
        CDataSection = 4,
        Comment = 8,
        Document = 9,
        DocumentFragment = 11,
        DocumentType = 10,
        Element = 1,
        Entity = 6,
        EntityReference = 5,
        Notation = 12,
        ProcessingInstruction = 7,
        Text = 3,
    }
    public partial class WindowEventArgs : System.EventArgs
    {
        public WindowEventArgs(Mono.WebBrowser.DOM.IWindow window) { }
        public Mono.WebBrowser.DOM.IWindow Window { get { throw null; } }
    }
    public delegate void WindowEventHandler(object sender, Mono.WebBrowser.DOM.WindowEventArgs e);
}
