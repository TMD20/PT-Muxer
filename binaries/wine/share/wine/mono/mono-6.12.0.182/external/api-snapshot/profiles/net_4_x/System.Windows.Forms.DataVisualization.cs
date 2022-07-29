// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Windows.Forms.DataVisualization.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Windows.Forms.DataVisualization.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Windows.Forms.DataVisualization.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityRulesAttribute(System.Security.SecurityRuleSet.Level1)]
namespace System
{
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
namespace System.Windows.Forms.DataVisualization.Charting
{
    public abstract partial class Annotation : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        protected Annotation() { }
        public virtual System.Drawing.ContentAlignment Alignment { get { throw null; } set { } }
        public virtual bool AllowAnchorMoving { get { throw null; } set { } }
        public virtual bool AllowMoving { get { throw null; } set { } }
        public virtual bool AllowPathEditing { get { throw null; } set { } }
        public virtual bool AllowResizing { get { throw null; } set { } }
        public virtual bool AllowSelecting { get { throw null; } set { } }
        public virtual bool AllowTextEditing { get { throw null; } set { } }
        public virtual System.Drawing.ContentAlignment AnchorAlignment { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.DataPoint AnchorDataPoint { get { throw null; } set { } }
        public virtual string AnchorDataPointName { get { throw null; } set { } }
        public virtual double AnchorOffsetX { get { throw null; } set { } }
        public virtual double AnchorOffsetY { get { throw null; } set { } }
        public virtual double AnchorX { get { throw null; } set { } }
        public virtual double AnchorY { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AnnotationGroup AnnotationGroup { get { throw null; } }
        public abstract string AnnotationType { get; }
        public virtual System.Windows.Forms.DataVisualization.Charting.Axis AxisX { get { throw null; } set { } }
        public virtual string AxisXName { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Axis AxisY { get { throw null; } set { } }
        public virtual string AxisYName { get { throw null; } set { } }
        public virtual System.Drawing.Color BackColor { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public virtual System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public virtual double Bottom { get { throw null; } set { } }
        public virtual string ClipToChartArea { get { throw null; } set { } }
        public virtual System.Drawing.Font Font { get { throw null; } set { } }
        public virtual System.Drawing.Color ForeColor { get { throw null; } set { } }
        public virtual double Height { get { throw null; } set { } }
        public virtual bool IsSelected { get { throw null; } set { } }
        public virtual bool IsSizeAlwaysRelative { get { throw null; } set { } }
        public virtual System.Drawing.Color LineColor { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { throw null; } set { } }
        public virtual int LineWidth { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public virtual double Right { get { throw null; } set { } }
        public virtual System.Drawing.Color ShadowColor { get { throw null; } set { } }
        public virtual int ShadowOffset { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AnnotationSmartLabelStyle SmartLabelStyle { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { throw null; } set { } }
        public virtual string ToolTip { get { throw null; } set { } }
        public virtual bool Visible { get { throw null; } set { } }
        public virtual double Width { get { throw null; } set { } }
        public virtual double X { get { throw null; } set { } }
        public virtual double Y { get { throw null; } set { } }
        public virtual string YAxisName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public virtual void BeginPlacement() { }
        [System.MonoTODOAttribute]
        public virtual void BringToFront() { }
        [System.MonoTODOAttribute]
        protected override void Dispose(bool disposing) { }
        [System.MonoTODOAttribute]
        public virtual void EndPlacement() { }
        [System.MonoTODOAttribute]
        public virtual void ResizeToContent() { }
        [System.MonoTODOAttribute]
        public virtual void SendToBack() { }
        [System.MonoTODOAttribute]
        public void SetAnchor(System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint) { }
        [System.MonoTODOAttribute]
        public void SetAnchor(System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1, System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2) { }
    }
    public partial class AnnotationCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.Annotation>
    {
        public AnnotationCollection() { }
        [System.MonoTODOAttribute]
        public override System.Windows.Forms.DataVisualization.Charting.Annotation FindByName(string name) { throw null; }
    }
    public partial class AnnotationGroup : System.Windows.Forms.DataVisualization.Charting.Annotation
    {
        public AnnotationGroup() { }
        public override System.Drawing.ContentAlignment Alignment { get { throw null; } set { } }
        public override bool AllowAnchorMoving { get { throw null; } set { } }
        public override bool AllowMoving { get { throw null; } set { } }
        public override bool AllowPathEditing { get { throw null; } set { } }
        public override bool AllowResizing { get { throw null; } set { } }
        public override bool AllowSelecting { get { throw null; } set { } }
        public override bool AllowTextEditing { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AnnotationCollection Annotations { get { throw null; } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public override System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public override string ClipToChartArea { get { throw null; } set { } }
        public override System.Drawing.Font Font { get { throw null; } set { } }
        public override System.Drawing.Color ForeColor { get { throw null; } set { } }
        public override bool IsSelected { get { throw null; } set { } }
        public override bool IsSizeAlwaysRelative { get { throw null; } set { } }
        public override System.Drawing.Color LineColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { throw null; } set { } }
        public override int LineWidth { get { throw null; } set { } }
        public override System.Drawing.Color ShadowColor { get { throw null; } set { } }
        public override int ShadowOffset { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { throw null; } set { } }
        public override bool Visible { get { throw null; } set { } }
    }
    public partial class AnnotationPathPoint : System.Windows.Forms.DataVisualization.Charting.ChartElement
    {
        public AnnotationPathPoint() { }
        public AnnotationPathPoint(float x, float y) { }
        public AnnotationPathPoint(float x, float y, byte type) { }
        public string Name { get { throw null; } }
        public byte PointType { get { throw null; } set { } }
        public float X { get { throw null; } set { } }
        public float Y { get { throw null; } set { } }
    }
    public partial class AnnotationPathPointCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint>
    {
        public AnnotationPathPointCollection() { }
        protected override void Dispose(bool disposing) { }
        public override void Invalidate() { }
    }
    public partial class AnnotationPositionChangingEventArgs : System.EventArgs
    {
        public AnnotationPositionChangingEventArgs() { }
        public System.Windows.Forms.DataVisualization.Charting.Annotation Annotation { get { throw null; } set { } }
        public System.Drawing.PointF NewAnchorLocation { get { throw null; } set { } }
        public double NewAnchorLocationX { get { throw null; } set { } }
        public double NewAnchorLocationY { get { throw null; } set { } }
        public double NewLocationX { get { throw null; } set { } }
        public double NewLocationY { get { throw null; } set { } }
        public System.Drawing.RectangleF NewPosition { get { throw null; } set { } }
        public double NewSizeHeight { get { throw null; } set { } }
        public double NewSizeWidth { get { throw null; } set { } }
    }
    public partial class AnnotationSmartLabelStyle : System.Windows.Forms.DataVisualization.Charting.SmartLabelStyle
    {
        public AnnotationSmartLabelStyle() { }
    }
    public partial class AnovaResult
    {
        public AnovaResult() { }
        public double DegreeOfFreedomBetweenGroups { get { throw null; } }
        public double DegreeOfFreedomTotal { get { throw null; } }
        public double DegreeOfFreedomWithinGroups { get { throw null; } }
        public double FCriticalValue { get { throw null; } }
        public double FRatio { get { throw null; } }
        public double MeanSquareVarianceBetweenGroups { get { throw null; } }
        public double MeanSquareVarianceWithinGroups { get { throw null; } }
        public double SumOfSquaresBetweenGroups { get { throw null; } }
        public double SumOfSquaresTotal { get { throw null; } }
        public double SumOfSquaresWithinGroups { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum AntiAliasingStyles
    {
        All = 3,
        Graphics = 2,
        None = 0,
        Text = 1,
    }
    [System.FlagsAttribute]
    public enum AreaAlignmentOrientations
    {
        All = 3,
        Horizontal = 2,
        None = 0,
        Vertical = 1,
    }
    [System.FlagsAttribute]
    public enum AreaAlignmentStyles
    {
        All = 15,
        AxesView = 4,
        Cursor = 8,
        None = 0,
        PlotPosition = 2,
        Position = 1,
    }
    public partial class ArrowAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation
    {
        public ArrowAnnotation() { }
        public override System.Drawing.ContentAlignment AnchorAlignment { get { throw null; } set { } }
        public override string AnnotationType { get { throw null; } }
        public virtual int ArrowSize { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.ArrowStyle ArrowStyle { get { throw null; } set { } }
    }
    public enum ArrowStyle
    {
        DoubleArrow = 1,
        Simple = 0,
        Tailed = 2,
    }
    public partial class Axis : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement, System.IDisposable
    {
        public Axis() { }
        public Axis(System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea, System.Windows.Forms.DataVisualization.Charting.AxisName axisTypeName) { }
        public System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle ArrowStyle { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.AxisName AxisName { get { throw null; } }
        public virtual double Crossing { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.CustomLabelCollection CustomLabels { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.AxisEnabled Enabled { get { throw null; } set { } }
        public System.Drawing.Color InterlacedColor { get { throw null; } set { } }
        public double Interval { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode IntervalAutoMode { get { throw null; } set { } }
        public double IntervalOffset { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { throw null; } set { } }
        public bool IsInterlaced { get { throw null; } set { } }
        public bool IsLabelAutoFit { get { throw null; } set { } }
        public bool IsLogarithmic { get { throw null; } set { } }
        public bool IsMarginVisible { get { throw null; } set { } }
        public virtual bool IsMarksNextToAxis { get { throw null; } set { } }
        public bool IsReversed { get { throw null; } set { } }
        public bool IsStartedFromZero { get { throw null; } set { } }
        public int LabelAutoFitMaxFontSize { get { throw null; } set { } }
        public int LabelAutoFitMinFontSize { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles LabelAutoFitStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LabelStyle LabelStyle { get { throw null; } set { } }
        public System.Drawing.Color LineColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { throw null; } set { } }
        public int LineWidth { get { throw null; } set { } }
        public double LogarithmBase { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Grid MajorGrid { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.TickMark MajorTickMark { get { throw null; } set { } }
        public double Maximum { get { throw null; } set { } }
        public float MaximumAutoSize { get { throw null; } set { } }
        public double Minimum { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Grid MinorGrid { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.TickMark MinorTickMark { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle ScaleBreakStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisScaleView ScaleView { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisScrollBar ScrollBar { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.StripLinesCollection StripLines { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.TextOrientation TextOrientation { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public System.Drawing.StringAlignment TitleAlignment { get { throw null; } set { } }
        public System.Drawing.Font TitleFont { get { throw null; } set { } }
        public System.Drawing.Color TitleForeColor { get { throw null; } set { } }
        public string ToolTip { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public double GetPosition(double axisValue) { throw null; }
        [System.MonoTODOAttribute]
        public double PixelPositionToValue(double position) { throw null; }
        [System.MonoTODOAttribute]
        public double PositionToValue(double position) { throw null; }
        [System.MonoTODOAttribute]
        public void RoundAxisValues() { }
        [System.MonoTODOAttribute]
        public double ValueToPixelPosition(double axisValue) { throw null; }
        [System.MonoTODOAttribute]
        public double ValueToPosition(double axisValue) { throw null; }
    }
    public enum AxisArrowStyle
    {
        Lines = 3,
        None = 0,
        SharpTriangle = 2,
        Triangle = 1,
    }
    public enum AxisEnabled
    {
        Auto = 0,
        False = 2,
        True = 1,
    }
    public enum AxisName
    {
        X = 0,
        X2 = 2,
        Y = 1,
        Y2 = 3,
    }
    public partial class AxisScaleBreakStyle
    {
        public AxisScaleBreakStyle() { }
        public System.Windows.Forms.DataVisualization.Charting.BreakLineStyle BreakLineStyle { get { throw null; } set { } }
        public int CollapsibleSpaceThreshold { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public System.Drawing.Color LineColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { throw null; } set { } }
        public int LineWidth { get { throw null; } set { } }
        public int MaxNumberOfBreaks { get { throw null; } set { } }
        public double Spacing { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.StartFromZero StartFromZero { get { throw null; } set { } }
    }
    public partial class AxisScaleView
    {
        public AxisScaleView() { }
        public bool IsZoomed { get { throw null; } }
        public double MinSize { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType MinSizeType { get { throw null; } set { } }
        public double Position { get { throw null; } set { } }
        public double Size { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType SizeType { get { throw null; } set { } }
        public double SmallScrollMinSize { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType SmallScrollMinSizeType { get { throw null; } set { } }
        public double SmallScrollSize { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType SmallScrollSizeType { get { throw null; } set { } }
        public double ViewMaximum { get { throw null; } }
        public double ViewMinimum { get { throw null; } }
        public bool Zoomable { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public void Scroll(System.DateTime newPosition) { }
        [System.MonoTODOAttribute]
        public void Scroll(double newPosition) { }
        [System.MonoTODOAttribute]
        public void Scroll(System.Windows.Forms.DataVisualization.Charting.ScrollType scrollType) { }
        [System.MonoTODOAttribute]
        public void Zoom(double viewStart, double viewEnd) { }
        [System.MonoTODOAttribute]
        public void Zoom(double viewPosition, double viewSize, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType viewSizeType) { }
        [System.MonoTODOAttribute]
        public void Zoom(double viewPosition, double viewSize, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType viewSizeType, bool saveState) { }
        [System.MonoTODOAttribute]
        public void ZoomReset() { }
        [System.MonoTODOAttribute]
        public void ZoomReset(int numberOfViews) { }
    }
    public partial class AxisScrollBar : System.IDisposable
    {
        public AxisScrollBar() { }
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { throw null; } }
        public System.Drawing.Color BackColor { get { throw null; } set { } }
        public System.Drawing.Color ButtonColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles ButtonStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { throw null; } }
        public bool Enabled { get { throw null; } set { } }
        public bool IsPositionedInside { get { throw null; } set { } }
        public bool IsVisible { get { throw null; } }
        public System.Drawing.Color LineColor { get { throw null; } set { } }
        public double Size { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public void Dispose() { }
        [System.MonoTODOAttribute]
        protected virtual void Dispose(bool disposing) { }
    }
    public enum AxisType
    {
        Primary = 0,
        Secondary = 1,
    }
    public partial class Border3DAnnotation : System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation
    {
        public Border3DAnnotation() { }
        public override string AnnotationType { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.BorderSkin BorderSkin { get { throw null; } set { } }
    }
    public partial class BorderSkin : System.Windows.Forms.DataVisualization.Charting.ChartElement
    {
        public BorderSkin() { }
        public System.Drawing.Color BackColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public string BackImage { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { throw null; } set { } }
        public System.Drawing.Color BackImageTransparentColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { throw null; } set { } }
        public System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public System.Drawing.Color BorderColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { throw null; } set { } }
        public int BorderWidth { get { throw null; } set { } }
        public System.Drawing.Color PageColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle SkinStyle { get { throw null; } set { } }
    }
    public enum BorderSkinStyle
    {
        Emboss = 1,
        FrameThin1 = 4,
        FrameThin2 = 5,
        FrameThin3 = 6,
        FrameThin4 = 7,
        FrameThin5 = 8,
        FrameThin6 = 9,
        FrameTitle1 = 10,
        FrameTitle2 = 11,
        FrameTitle3 = 12,
        FrameTitle4 = 13,
        FrameTitle5 = 14,
        FrameTitle6 = 15,
        FrameTitle7 = 16,
        FrameTitle8 = 17,
        None = 0,
        Raised = 2,
        Sunken = 3,
    }
    public enum BreakLineStyle
    {
        None = 0,
        Ragged = 3,
        Straight = 1,
        Wave = 2,
    }
    public partial class CalloutAnnotation : System.Windows.Forms.DataVisualization.Charting.TextAnnotation
    {
        public CalloutAnnotation() { }
        public override System.Drawing.ContentAlignment AnchorAlignment { get { throw null; } set { } }
        public override double AnchorOffsetX { get { throw null; } set { } }
        public override double AnchorOffsetY { get { throw null; } set { } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public override System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle CalloutAnchorCap { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.CalloutStyle CalloutStyle { get { throw null; } set { } }
        public override System.Drawing.Color LineColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { throw null; } set { } }
        public override int LineWidth { get { throw null; } set { } }
    }
    public enum CalloutStyle
    {
        Borderline = 1,
        Cloud = 2,
        Ellipse = 5,
        Perspective = 6,
        Rectangle = 3,
        RoundedRectangle = 4,
        SimpleLine = 0,
    }
    public partial class Chart : System.Windows.Forms.Control, System.ComponentModel.ISupportInitialize, System.IDisposable
    {
        public Chart() { }
        public System.Windows.Forms.DataVisualization.Charting.AnnotationCollection Annotations { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles AntiAliasing { get { throw null; } set { } }
        public override System.Drawing.Color BackColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public override System.Drawing.Image BackgroundImage { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public string BackImage { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { throw null; } set { } }
        public System.Drawing.Color BackImageTransparentColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { throw null; } set { } }
        public System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public System.Drawing.Color BorderColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { throw null; } set { } }
        public System.Drawing.Color BorderlineColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderlineDashStyle { get { throw null; } set { } }
        public int BorderlineWidth { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.BorderSkin BorderSkin { get { throw null; } set { } }
        public int BorderWidth { get { throw null; } set { } }
        public string BuildNumber { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartAreaCollection ChartAreas { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.DataManipulator DataManipulator { get { throw null; } }
        public object DataSource { get { throw null; } set { } }
        protected override System.Drawing.Size DefaultSize { get { throw null; } }
        public override System.Drawing.Color ForeColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.NamedImagesCollection Images { get { throw null; } }
        public bool IsSoftShadows { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendCollection Legends { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartColorPalette Palette { get { throw null; } set { } }
        public System.Drawing.Color[] PaletteCustomColors { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.PrintingManager Printing { get { throw null; } }
        public double RenderingDpiX { get { throw null; } set { } }
        public double RenderingDpiY { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartSerializer Serializer { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.SeriesCollection Series { get { throw null; } }
        public bool SuppressExceptions { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality TextAntiAliasingQuality { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.TitleCollection Titles { get { throw null; } }
        public event System.EventHandler AnnotationPlaced { add { } remove { } }
        public event System.EventHandler AnnotationPositionChanged { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.AnnotationPositionChangingEventArgs> AnnotationPositionChanging { add { } remove { } }
        public event System.EventHandler AnnotationSelectionChanged { add { } remove { } }
        public event System.EventHandler AnnotationTextChanged { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ScrollBarEventArgs> AxisScrollBarClicked { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs> AxisViewChanged { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs> AxisViewChanging { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs> CursorPositionChanged { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs> CursorPositionChanging { add { } remove { } }
        public event System.EventHandler Customize { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CustomizeLegendEventArgs> CustomizeLegend { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.FormatNumberEventArgs> FormatNumber { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs> GetToolTipText { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs> PostPaint { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs> PrePaint { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs> SelectionRangeChanged { add { } remove { } }
        public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs> SelectionRangeChanging { add { } remove { } }
        [System.MonoTODOAttribute]
        public void AlignDataPointsByAxisLabel() { }
        [System.MonoTODOAttribute]
        public void AlignDataPointsByAxisLabel(string series) { }
        [System.MonoTODOAttribute]
        public void AlignDataPointsByAxisLabel(string series, System.Windows.Forms.DataVisualization.Charting.PointSortOrder sortingOrder) { }
        [System.MonoTODOAttribute]
        public void AlignDataPointsByAxisLabel(System.Windows.Forms.DataVisualization.Charting.PointSortOrder sortingOrder) { }
        [System.MonoTODOAttribute]
        public void ApplyPaletteColors() { }
        [System.MonoTODOAttribute]
        public void BeginInit() { }
        [System.MonoTODOAttribute]
        public void DataBind() { }
        [System.MonoTODOAttribute]
        public void DataBindCrossTable(System.Collections.IEnumerable dataSource, string seriesGroupByField, string xField, string yFields, string otherFields) { }
        [System.MonoTODOAttribute]
        public void DataBindCrossTable(System.Collections.IEnumerable dataSource, string seriesGroupByField, string xField, string yFields, string otherFields, System.Windows.Forms.DataVisualization.Charting.PointSortOrder sortingOrder) { }
        [System.MonoTODOAttribute]
        public void DataBindTable(System.Collections.IEnumerable dataSource) { }
        [System.MonoTODOAttribute]
        public void DataBindTable(System.Collections.IEnumerable dataSource, string xField) { }
        protected override void Dispose(bool disposing) { }
        [System.MonoTODOAttribute]
        public void EndInit() { }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.HitTestResult HitTest(int x, int y) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.HitTestResult HitTest(int x, int y, bool ignoreTransparent) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.HitTestResult[] HitTest(int x, int y, bool ignoreTransparent, params System.Windows.Forms.DataVisualization.Charting.ChartElementType[] requestedElement) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.HitTestResult HitTest(int x, int y, System.Windows.Forms.DataVisualization.Charting.ChartElementType requestedElement) { throw null; }
        [System.MonoTODOAttribute]
        public void LoadTemplate(System.IO.Stream stream) { }
        [System.MonoTODOAttribute]
        public void LoadTemplate(string name) { }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent) { }
        protected virtual void OnPostPaint(System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e) { }
        protected virtual void OnPrePaint(System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e) { }
        [System.MonoTODOAttribute]
        public void ResetAutoValues() { }
        [System.MonoTODOAttribute]
        public void SaveImage(System.IO.Stream imageStream, System.Drawing.Imaging.ImageFormat format) { }
        [System.MonoTODOAttribute]
        public void SaveImage(System.IO.Stream imageStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat format) { }
        [System.MonoTODOAttribute]
        public void SaveImage(string imageFileName, System.Drawing.Imaging.ImageFormat format) { }
        [System.MonoTODOAttribute]
        public void SaveImage(string imageFileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat format) { }
    }
    public partial class ChartArea : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public ChartArea() { }
        public ChartArea(string name) { }
        public System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations AlignmentOrientation { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles AlignmentStyle { get { throw null; } set { } }
        public string AlignWithChartArea { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea3DStyle Area3DStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis[] Axes { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis AxisX { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis AxisX2 { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis AxisY { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis AxisY2 { get { throw null; } set { } }
        public System.Drawing.Color BackColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public string BackImage { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { throw null; } set { } }
        public System.Drawing.Color BackImageTransparentColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { throw null; } set { } }
        public System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public System.Drawing.Color BorderColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { throw null; } set { } }
        public int BorderWidth { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Cursor CursorX { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Cursor CursorY { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition InnerPlotPosition { get { throw null; } set { } }
        public bool IsSameFontSizeForAllAxes { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { get { throw null; } set { } }
        public System.Drawing.Color ShadowColor { get { throw null; } set { } }
        public int ShadowOffset { get { throw null; } set { } }
        public virtual bool Visible { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override void Dispose(bool disposing) { }
        [System.MonoTODOAttribute]
        public float GetSeriesDepth(System.Windows.Forms.DataVisualization.Charting.Series series) { throw null; }
        [System.MonoTODOAttribute]
        public float GetSeriesZPosition(System.Windows.Forms.DataVisualization.Charting.Series series) { throw null; }
        [System.MonoTODOAttribute]
        public void RecalculateAxesScale() { }
        [System.MonoTODOAttribute]
        public void TransformPoints(System.Windows.Forms.DataVisualization.Charting.Point3D[] points) { }
    }
    public partial class ChartArea3DStyle
    {
        public ChartArea3DStyle() { }
        public ChartArea3DStyle(System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea) { }
        public bool Enable3D { get { throw null; } set { } }
        public int Inclination { get { throw null; } set { } }
        public bool IsClustered { get { throw null; } set { } }
        public bool IsRightAngleAxes { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LightStyle LightStyle { get { throw null; } set { } }
        public int Perspective { get { throw null; } set { } }
        public int PointDepth { get { throw null; } set { } }
        public int PointGapDepth { get { throw null; } set { } }
        public int Rotation { get { throw null; } set { } }
        public int WallWidth { get { throw null; } set { } }
    }
    public partial class ChartAreaCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.ChartArea>
    {
        public ChartAreaCollection() { }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea Add(string name) { throw null; }
    }
    public enum ChartColorPalette
    {
        Berry = 8,
        Bright = 1,
        BrightPastel = 12,
        Chocolate = 9,
        EarthTones = 6,
        Excel = 3,
        Fire = 10,
        Grayscale = 2,
        Light = 4,
        None = 0,
        Pastel = 5,
        SeaGreen = 11,
        SemiTransparent = 7,
    }
    public enum ChartDashStyle
    {
        Dash = 1,
        DashDot = 2,
        DashDotDot = 3,
        Dot = 4,
        NotSet = 0,
        Solid = 5,
    }
    public abstract partial class ChartElement : System.IDisposable
    {
        protected ChartElement() { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public object Tag { get { throw null; } set { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class ChartElementCollection<T> : System.Collections.ObjectModel.Collection<T> where T : System.Windows.Forms.DataVisualization.Charting.ChartElement
    {
        protected ChartElementCollection() { }
        protected override void ClearItems() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected override void InsertItem(int index, T item) { }
        public virtual void Invalidate() { }
        protected override void RemoveItem(int index) { }
        public virtual void ResumeUpdates() { }
        protected override void SetItem(int index, T item) { }
        public virtual void SuspendUpdates() { }
    }
    public enum ChartElementType
    {
        Annotation = 22,
        Axis = 3,
        AxisLabelImage = 7,
        AxisLabels = 8,
        AxisTitle = 9,
        DataPoint = 16,
        DataPointLabel = 17,
        Gridlines = 5,
        LegendArea = 18,
        LegendHeader = 20,
        LegendItem = 21,
        LegendTitle = 19,
        Nothing = 0,
        PlottingArea = 2,
        ScrollBarLargeDecrement = 13,
        ScrollBarLargeIncrement = 14,
        ScrollBarSmallDecrement = 11,
        ScrollBarSmallIncrement = 12,
        ScrollBarThumbTracker = 10,
        ScrollBarZoomReset = 15,
        StripLines = 6,
        TickMarks = 4,
        Title = 1,
    }
    public partial class ChartGraphics : System.Windows.Forms.DataVisualization.Charting.ChartElement, System.IDisposable
    {
        internal ChartGraphics() { }
        public System.Drawing.Graphics Graphics { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override void Dispose(bool disposing) { }
        [System.MonoTODOAttribute]
        public System.Drawing.PointF GetAbsolutePoint(System.Drawing.PointF point) { throw null; }
        [System.MonoTODOAttribute]
        public System.Drawing.RectangleF GetAbsoluteRectangle(System.Drawing.RectangleF rectangle) { throw null; }
        [System.MonoTODOAttribute]
        public System.Drawing.SizeF GetAbsoluteSize(System.Drawing.SizeF size) { throw null; }
        [System.MonoTODOAttribute]
        public double GetPositionFromAxis(string chartAreaName, System.Windows.Forms.DataVisualization.Charting.AxisName axis, double axisValue) { throw null; }
        [System.MonoTODOAttribute]
        public System.Drawing.PointF GetRelativePoint(System.Drawing.PointF point) { throw null; }
        [System.MonoTODOAttribute]
        public System.Drawing.RectangleF GetRelativeRectangle(System.Drawing.RectangleF rectangle) { throw null; }
        [System.MonoTODOAttribute]
        public System.Drawing.SizeF GetRelativeSize(System.Drawing.SizeF size) { throw null; }
    }
    public enum ChartHatchStyle
    {
        BackwardDiagonal = 1,
        Cross = 2,
        DarkDownwardDiagonal = 3,
        DarkHorizontal = 4,
        DarkUpwardDiagonal = 5,
        DarkVertical = 6,
        DashedDownwardDiagonal = 7,
        DashedHorizontal = 8,
        DashedUpwardDiagonal = 9,
        DashedVertical = 10,
        DiagonalBrick = 11,
        DiagonalCross = 12,
        Divot = 13,
        DottedDiamond = 14,
        DottedGrid = 15,
        ForwardDiagonal = 16,
        Horizontal = 17,
        HorizontalBrick = 18,
        LargeCheckerBoard = 19,
        LargeConfetti = 20,
        LargeGrid = 21,
        LightDownwardDiagonal = 22,
        LightHorizontal = 23,
        LightUpwardDiagonal = 24,
        LightVertical = 25,
        NarrowHorizontal = 26,
        NarrowVertical = 27,
        None = 0,
        OutlinedDiamond = 28,
        Percent05 = 29,
        Percent10 = 30,
        Percent20 = 31,
        Percent25 = 32,
        Percent30 = 33,
        Percent40 = 34,
        Percent50 = 35,
        Percent60 = 36,
        Percent70 = 37,
        Percent75 = 38,
        Percent80 = 39,
        Percent90 = 40,
        Plaid = 41,
        Shingle = 42,
        SmallCheckerBoard = 43,
        SmallConfetti = 44,
        SmallGrid = 45,
        SolidDiamond = 46,
        Sphere = 47,
        Trellis = 48,
        Vertical = 49,
        Wave = 50,
        Weave = 51,
        WideDownwardDiagonal = 52,
        WideUpwardDiagonal = 53,
        ZigZag = 54,
    }
    public enum ChartImageAlignmentStyle
    {
        Bottom = 5,
        BottomLeft = 6,
        BottomRight = 4,
        Center = 8,
        Left = 7,
        Right = 3,
        Top = 1,
        TopLeft = 0,
        TopRight = 2,
    }
    public enum ChartImageFormat
    {
        Bmp = 2,
        Emf = 5,
        EmfDual = 6,
        EmfPlus = 7,
        Gif = 4,
        Jpeg = 0,
        Png = 1,
        Tiff = 3,
    }
    public enum ChartImageWrapMode
    {
        Scaled = 4,
        Tile = 0,
        TileFlipX = 1,
        TileFlipXY = 3,
        TileFlipY = 2,
        Unscaled = 100,
    }
    public abstract partial class ChartNamedElement : System.Windows.Forms.DataVisualization.Charting.ChartElement
    {
        public ChartNamedElement() { }
        public ChartNamedElement(string name) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string Name { get { throw null; } set { } }
    }
    public partial class ChartNamedElementCollection<T> : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<T> where T : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public ChartNamedElementCollection() { }
        public T this[string name] { get { throw null; } set { } }
        protected virtual string NamePrefix { get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual T FindByName(string name) { throw null; }
        [System.MonoTODOAttribute]
        public int IndexOf(string name) { throw null; }
        [System.MonoTODOAttribute]
        protected override void InsertItem(int index, T item) { }
        [System.MonoTODOAttribute]
        public virtual bool IsUniqueName(string name) { throw null; }
        [System.MonoTODOAttribute]
        public virtual string NextUniqueName() { throw null; }
        [System.MonoTODOAttribute]
        protected override void RemoveItem(int index) { }
        [System.MonoTODOAttribute]
        protected override void SetItem(int index, T item) { }
    }
    public partial class ChartPaintEventArgs : System.EventArgs
    {
        internal ChartPaintEventArgs() { }
        public System.Windows.Forms.DataVisualization.Charting.Chart Chart { get { throw null; } }
        public object ChartElement { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartGraphics ChartGraphics { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { get { throw null; } }
    }
    public partial class ChartSerializer
    {
        public ChartSerializer() { }
        public System.Windows.Forms.DataVisualization.Charting.SerializationContents Content { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.SerializationFormat Format { get { throw null; } set { } }
        public bool IsResetWhenLoading { get { throw null; } set { } }
        public bool IsTemplateMode { get { throw null; } set { } }
        public bool IsUnknownAttributeIgnored { get { throw null; } set { } }
        public string NonSerializableContent { get { throw null; } set { } }
        public string SerializableContent { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected string GetContentString(System.Windows.Forms.DataVisualization.Charting.SerializationContents content, bool serializable) { throw null; }
        [System.MonoTODOAttribute]
        public void Load(System.IO.Stream stream) { }
        [System.MonoTODOAttribute]
        public void Load(System.IO.TextReader reader) { }
        [System.MonoTODOAttribute]
        public void Load(string fileName) { }
        [System.MonoTODOAttribute]
        public void Load(System.Xml.XmlReader reader) { }
        [System.MonoTODOAttribute]
        public void Reset() { }
        [System.MonoTODOAttribute]
        public void Save(System.IO.Stream stream) { }
        [System.MonoTODOAttribute]
        public void Save(System.IO.TextWriter writer) { }
        [System.MonoTODOAttribute]
        public void Save(string fileName) { }
        [System.MonoTODOAttribute]
        public void Save(System.Xml.XmlWriter writer) { }
    }
    public enum ChartValueType
    {
        Auto = 0,
        Date = 9,
        DateTime = 8,
        DateTimeOffset = 11,
        Double = 1,
        Int32 = 3,
        Int64 = 4,
        Single = 2,
        String = 7,
        Time = 10,
        UInt32 = 5,
        UInt64 = 6,
    }
    public enum CompareMethod
    {
        EqualTo = 2,
        LessThan = 1,
        LessThanOrEqualTo = 4,
        MoreThan = 0,
        MoreThanOrEqualTo = 3,
        NotEqualTo = 5,
    }
    public partial class Cursor : System.IDisposable
    {
        public Cursor() { }
        public bool AutoScroll { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisType AxisType { get { throw null; } set { } }
        public double Interval { get { throw null; } set { } }
        public double IntervalOffset { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { throw null; } set { } }
        public bool IsUserEnabled { get { throw null; } set { } }
        public bool IsUserSelectionEnabled { get { throw null; } set { } }
        public System.Drawing.Color LineColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { throw null; } set { } }
        public int LineWidth { get { throw null; } set { } }
        public double Position { get { throw null; } set { } }
        public System.Drawing.Color SelectionColor { get { throw null; } set { } }
        public double SelectionEnd { get { throw null; } set { } }
        public double SelectionStart { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public void Dispose() { }
        [System.MonoTODOAttribute]
        protected virtual void Dispose(bool disposing) { }
        [System.MonoTODOAttribute]
        public void SetCursorPixelPosition(System.Drawing.PointF point, bool roundToBoundary) { }
        [System.MonoTODOAttribute]
        public void SetCursorPosition(double newPosition) { }
        [System.MonoTODOAttribute]
        public void SetSelectionPixelPosition(System.Drawing.PointF startPoint, System.Drawing.PointF endPoint, bool roundToBoundary) { }
        [System.MonoTODOAttribute]
        public void SetSelectionPosition(double newStart, double newEnd) { }
    }
    public partial class CursorEventArgs : System.EventArgs
    {
        public CursorEventArgs(System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea, System.Windows.Forms.DataVisualization.Charting.Axis axis, double newPosition) { }
        public CursorEventArgs(System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea, System.Windows.Forms.DataVisualization.Charting.Axis axis, double newSelectionStart, double newSelectionEnd) { }
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { throw null; } }
        public double NewPosition { get { throw null; } set { } }
        public double NewSelectionEnd { get { throw null; } set { } }
        public double NewSelectionStart { get { throw null; } set { } }
    }
    public partial class CustomizeLegendEventArgs : System.EventArgs
    {
        public CustomizeLegendEventArgs() { }
        public System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection LegendItems { get { throw null; } }
        public string LegendName { get { throw null; } }
    }
    public partial class CustomLabel : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public CustomLabel() { }
        public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle) { }
        public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle, System.Windows.Forms.DataVisualization.Charting.GridTickTypes gridTick) { }
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { throw null; } }
        public System.Drawing.Color ForeColor { get { throw null; } set { } }
        public double FromPosition { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.GridTickTypes GridTicks { get { throw null; } set { } }
        public string Image { get { throw null; } set { } }
        public System.Drawing.Color ImageTransparentColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle LabelMark { get { throw null; } set { } }
        public System.Drawing.Color MarkColor { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public int RowIndex { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public string ToolTip { get { throw null; } set { } }
        public double ToPosition { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.CustomLabel Clone() { throw null; }
    }
    public partial class CustomLabelCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.CustomLabel>
    {
        public CustomLabelCollection() { }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.CustomLabel Add(double fromPosition, double toPosition, string text) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.CustomLabel Add(double fromPosition, double toPosition, string text, int rowIndex, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.CustomLabel Add(double fromPosition, double toPosition, string text, int rowIndex, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle, System.Windows.Forms.DataVisualization.Charting.GridTickTypes gridTick) { throw null; }
        [System.MonoTODOAttribute]
        public void Add(double labelsStep, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType intervalType) { }
        [System.MonoTODOAttribute]
        public void Add(double labelsStep, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType intervalType, double min, double max, string format, int rowIndex, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle) { }
        [System.MonoTODOAttribute]
        public void Add(double labelsStep, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType intervalType, string format) { }
        [System.MonoTODOAttribute]
        public void Add(double labelsStep, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType intervalType, string format, int rowIndex, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle) { }
    }
    public partial class CustomProperties
    {
        public CustomProperties() { }
    }
    public partial class DataFormula
    {
        public DataFormula() { }
        public bool IsEmptyPointIgnored { get { throw null; } set { } }
        public bool IsStartFromFirst { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.StatisticFormula Statistics { get { throw null; } }
        [System.MonoTODOAttribute]
        public void CopySeriesValues(string inputSeries, string outputSeries) { }
        [System.MonoTODOAttribute]
        public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, string inputSeries) { }
        [System.MonoTODOAttribute]
        public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, string inputSeries, string outputSeries) { }
        [System.MonoTODOAttribute]
        public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, string parameters, string inputSeries, string outputSeries) { }
        [System.MonoTODOAttribute]
        public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, string parameters, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
        [System.MonoTODOAttribute]
        public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
        [System.MonoTODOAttribute]
        public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
    }
    public partial class DataManipulator : System.Windows.Forms.DataVisualization.Charting.DataFormula
    {
        public DataManipulator() { }
        public bool FilterMatchedPoints { get { throw null; } set { } }
        public bool FilterSetEmptyPoints { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Data.DataSet ExportSeriesValues() { throw null; }
        [System.MonoTODOAttribute]
        public System.Data.DataSet ExportSeriesValues(string seriesNames) { throw null; }
        [System.MonoTODOAttribute]
        public System.Data.DataSet ExportSeriesValues(System.Windows.Forms.DataVisualization.Charting.Series series) { throw null; }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, string inputSeriesNames) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, string inputSeriesNames, string outputSeriesNames) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, string inputSeriesNames, string outputSeriesNames, string usingValue) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries, string usingValue) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, string inputSeriesNames) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, string inputSeriesNames, string outputSeriesNames) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.IDataPointFilter filterInterface, string inputSeriesNames) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.IDataPointFilter filterInterface, string inputSeriesNames, string outputSeriesNames) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.IDataPointFilter filterInterface, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
        [System.MonoTODOAttribute]
        public void Filter(System.Windows.Forms.DataVisualization.Charting.IDataPointFilter filterInterface, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
        [System.MonoTODOAttribute]
        public void FilterTopN(int pointCount, string inputSeriesNames) { }
        [System.MonoTODOAttribute]
        public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames) { }
        [System.MonoTODOAttribute]
        public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames, string usingValue) { }
        [System.MonoTODOAttribute]
        public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames, string usingValue, bool getTopValues) { }
        [System.MonoTODOAttribute]
        public void FilterTopN(int pointCount, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
        [System.MonoTODOAttribute]
        public void FilterTopN(int pointCount, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
        [System.MonoTODOAttribute]
        public void FilterTopN(int pointCount, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries, string usingValue) { }
        [System.MonoTODOAttribute]
        public void FilterTopN(int pointCount, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries, string usingValue, bool getTopValues) { }
        [System.MonoTODOAttribute]
        public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, string inputSeriesName) { }
        [System.MonoTODOAttribute]
        public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, string inputSeriesName, string outputSeriesName) { }
        [System.MonoTODOAttribute]
        public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
        [System.MonoTODOAttribute]
        public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
        [System.MonoTODOAttribute]
        public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, string inputSeriesName) { }
        [System.MonoTODOAttribute]
        public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, string inputSeriesName, string outputSeriesName) { }
        [System.MonoTODOAttribute]
        public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
        [System.MonoTODOAttribute]
        public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
        [System.MonoTODOAttribute]
        public void GroupByAxisLabel(string formula, string inputSeriesName) { }
        [System.MonoTODOAttribute]
        public void GroupByAxisLabel(string formula, string inputSeriesName, string outputSeriesName) { }
        [System.MonoTODOAttribute]
        public void GroupByAxisLabel(string formula, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
        [System.MonoTODOAttribute]
        public void GroupByAxisLabel(string formula, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
        [System.MonoTODOAttribute]
        public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, double fromXValue, double toXValue, string seriesName) { }
        [System.MonoTODOAttribute]
        public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, double fromXValue, double toXValue, System.Windows.Forms.DataVisualization.Charting.Series series) { }
        [System.MonoTODOAttribute]
        public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, string seriesName) { }
        [System.MonoTODOAttribute]
        public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, System.Windows.Forms.DataVisualization.Charting.Series series) { }
        [System.MonoTODOAttribute]
        public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, string seriesName) { }
        [System.MonoTODOAttribute]
        public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, System.Windows.Forms.DataVisualization.Charting.Series series) { }
        [System.MonoTODOAttribute]
        public void Sort(System.Collections.Generic.IComparer<System.Windows.Forms.DataVisualization.Charting.DataPoint> comparer, string seriesName) { }
        [System.MonoTODOAttribute]
        public void Sort(System.Collections.Generic.IComparer<System.Windows.Forms.DataVisualization.Charting.DataPoint> comparer, System.Windows.Forms.DataVisualization.Charting.Series series) { }
        [System.MonoTODOAttribute]
        public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, string seriesName) { }
        [System.MonoTODOAttribute]
        public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, string sortBy, string seriesName) { }
        [System.MonoTODOAttribute]
        public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, string sortBy, System.Windows.Forms.DataVisualization.Charting.Series series) { }
        [System.MonoTODOAttribute]
        public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, System.Windows.Forms.DataVisualization.Charting.Series series) { }
    }
    public partial class DataPoint : System.Windows.Forms.DataVisualization.Charting.DataPointCustomProperties
    {
        public DataPoint() { }
        public DataPoint(double xValue, double yValue) { }
        public DataPoint(double xValue, double[] yValues) { }
        [System.MonoTODOAttribute]
        public DataPoint(double xValue, string yValues) { }
        [System.MonoTODOAttribute]
        public DataPoint(System.Windows.Forms.DataVisualization.Charting.Series series) { }
        public bool IsEmpty { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public double XValue { get { throw null; } set { } }
        public double[] YValues { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DataPoint Clone() { throw null; }
        public double GetValueByName(string valueName) { throw null; }
        public void SetValueXY(object xValue, params object[] yValue) { }
        public void SetValueY(params object[] yValue) { }
    }
    public partial class DataPointCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.DataPoint>
    {
        public DataPointCollection() { }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint Add(params double[] y) { throw null; }
        [System.MonoTODOAttribute]
        public int AddXY(double xValue, double yValue) { throw null; }
        [System.MonoTODOAttribute]
        public int AddXY(object xValue, params object[] yValue) { throw null; }
        [System.MonoTODOAttribute]
        public int AddY(double yValue) { throw null; }
        [System.MonoTODOAttribute]
        public int AddY(params object[] yValue) { throw null; }
        [System.MonoTODOAttribute]
        protected override void ClearItems() { }
        [System.MonoTODOAttribute]
        public void DataBind(System.Collections.IEnumerable dataSource, string xField, string yFields, string otherFields) { }
        [System.MonoTODOAttribute]
        public void DataBindXY(System.Collections.IEnumerable xValue, params System.Collections.IEnumerable[] yValues) { }
        [System.MonoTODOAttribute]
        public void DataBindXY(System.Collections.IEnumerable xValue, string xField, System.Collections.IEnumerable yValue, string yFields) { }
        [System.MonoTODOAttribute]
        public void DataBindY(System.Collections.IEnumerable yValue, string yFields) { }
        [System.MonoTODOAttribute]
        public void DataBindY(params System.Collections.IEnumerable[] yValue) { }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IEnumerable<System.Windows.Forms.DataVisualization.Charting.DataPoint> FindAllByValue(double valueToFind) { throw null; }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IEnumerable<System.Windows.Forms.DataVisualization.Charting.DataPoint> FindAllByValue(double valueToFind, string useValue) { throw null; }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IEnumerable<System.Windows.Forms.DataVisualization.Charting.DataPoint> FindAllByValue(double valueToFind, string useValue, int startIndex) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint FindByValue(double valueToFind) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint FindByValue(double valueToFind, string useValue) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint FindByValue(double valueToFind, string useValue, int startIndex) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMaxByValue() { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMaxByValue(string useValue) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMaxByValue(string useValue, int startIndex) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMinByValue() { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMinByValue(string useValue) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMinByValue(string useValue, int startIndex) { throw null; }
        [System.MonoTODOAttribute]
        public void InsertXY(int index, object xValue, params object[] yValue) { }
        [System.MonoTODOAttribute]
        public void InsertY(int index, params object[] yValue) { }
    }
    public partial class DataPointCustomProperties : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public DataPointCustomProperties() { }
        public virtual string AxisLabel { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public string BackImage { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { throw null; } set { } }
        public System.Drawing.Color BackImageTransparentColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { throw null; } set { } }
        public System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public System.Drawing.Color BorderColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { throw null; } set { } }
        public int BorderWidth { get { throw null; } set { } }
        public System.Drawing.Color Color { get { throw null; } set { } }
        public string CustomProperties { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.CustomProperties CustomPropertiesExtended { get { throw null; } set { } }
        public System.Drawing.Font Font { get { throw null; } set { } }
        public bool IsValueShownAsLabel { get { throw null; } set { } }
        public bool IsVisibleInLegend { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string this[int idx] { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string this[string name] { get { throw null; } set { } }
        public virtual string Label { get { throw null; } set { } }
        public int LabelAngle { get { throw null; } set { } }
        public System.Drawing.Color LabelBackColor { get { throw null; } set { } }
        public System.Drawing.Color LabelBorderColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LabelBorderDashStyle { get { throw null; } set { } }
        public int LabelBorderWidth { get { throw null; } set { } }
        public System.Drawing.Color LabelForeColor { get { throw null; } set { } }
        public string LabelFormat { get { throw null; } set { } }
        public string LabelToolTip { get { throw null; } set { } }
        public string LegendText { get { throw null; } set { } }
        public string LegendToolTip { get { throw null; } set { } }
        public System.Drawing.Color MarkerBorderColor { get { throw null; } set { } }
        public int MarkerBorderWidth { get { throw null; } set { } }
        public System.Drawing.Color MarkerColor { get { throw null; } set { } }
        public string MarkerImage { get { throw null; } set { } }
        public System.Drawing.Color MarkerImageTransparentColor { get { throw null; } set { } }
        public int MarkerSize { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.MarkerStyle MarkerStyle { get { throw null; } set { } }
        public string ToolTip { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public virtual void DeleteCustomProperty(string name) { }
        [System.MonoTODOAttribute]
        public virtual string GetCustomProperty(string name) { throw null; }
        [System.MonoTODOAttribute]
        public virtual bool IsCustomPropertySet(string name) { throw null; }
        [System.MonoTODOAttribute]
        public void ResetIsValueShownAsLabel() { }
        [System.MonoTODOAttribute]
        public void ResetIsVisibleInLegend() { }
        [System.MonoTODOAttribute]
        public virtual void SetCustomProperty(string name, string propertyValue) { }
        [System.MonoTODOAttribute]
        public virtual void SetDefault(bool clearAll) { }
    }
    public enum DateRangeType
    {
        DayOfMonth = 3,
        DayOfWeek = 2,
        Hour = 4,
        Minute = 5,
        Month = 1,
        Year = 0,
    }
    public enum DateTimeIntervalType
    {
        Auto = 0,
        Days = 5,
        Hours = 6,
        Milliseconds = 9,
        Minutes = 7,
        Months = 3,
        NotSet = 10,
        Number = 1,
        Seconds = 8,
        Weeks = 4,
        Years = 2,
    }
    public enum Docking
    {
        Bottom = 2,
        Left = 3,
        Right = 1,
        Top = 0,
    }
    public partial class ElementPosition : System.Windows.Forms.DataVisualization.Charting.ChartElement
    {
        public ElementPosition() { }
        public ElementPosition(float x, float y, float width, float height) { }
        public bool Auto { get { throw null; } set { } }
        public float Bottom { get { throw null; } }
        public float Height { get { throw null; } set { } }
        public float Right { get { throw null; } }
        public System.Drawing.SizeF Size { get { throw null; } }
        public float Width { get { throw null; } set { } }
        public float X { get { throw null; } set { } }
        public float Y { get { throw null; } set { } }
        public void FromRectangleF(System.Drawing.RectangleF rect) { }
        public System.Drawing.RectangleF ToRectangleF() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EllipseAnnotation : System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation
    {
        public EllipseAnnotation() { }
    }
    public enum FinancialFormula
    {
        AccumulationDistribution = 0,
        AverageTrueRange = 1,
        BollingerBands = 2,
        ChaikinOscillator = 3,
        CommodityChannelIndex = 4,
        DetrendedPriceOscillator = 5,
        EaseOfMovement = 6,
        Envelopes = 7,
        ExponentialMovingAverage = 8,
        Forecasting = 9,
        MassIndex = 11,
        MedianPrice = 12,
        MoneyFlow = 13,
        MovingAverage = 21,
        MovingAverageConvergenceDivergence = 10,
        NegativeVolumeIndex = 14,
        OnBalanceVolume = 15,
        Performance = 16,
        PositiveVolumeIndex = 17,
        PriceVolumeTrend = 18,
        RateOfChange = 19,
        RelativeStrengthIndex = 20,
        StandardDeviation = 22,
        StochasticIndicator = 23,
        TriangularMovingAverage = 24,
        TripleExponentialMovingAverage = 25,
        TypicalPrice = 26,
        VolatilityChaikins = 27,
        VolumeOscillator = 28,
        WeightedClose = 29,
        WeightedMovingAverage = 30,
        WilliamsR = 31,
    }
    public partial class FormatNumberEventArgs : System.EventArgs
    {
        internal FormatNumberEventArgs() { }
        public System.Windows.Forms.DataVisualization.Charting.ChartElementType ElementType { get { throw null; } }
        public string Format { get { throw null; } }
        public string LocalizedValue { get { throw null; } set { } }
        public object SenderTag { get { throw null; } }
        public double Value { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartValueType ValueType { get { throw null; } }
    }
    public partial class FTestResult
    {
        public FTestResult() { }
        public double FCriticalValueOneTail { get { throw null; } }
        public double FirstSeriesMean { get { throw null; } }
        public double FirstSeriesVariance { get { throw null; } }
        public double FValue { get { throw null; } }
        public double ProbabilityFOneTail { get { throw null; } }
        public double SecondSeriesMean { get { throw null; } }
        public double SecondSeriesVariance { get { throw null; } }
    }
    public enum GradientStyle
    {
        Center = 3,
        DiagonalLeft = 4,
        DiagonalRight = 5,
        HorizontalCenter = 6,
        LeftRight = 1,
        None = 0,
        TopBottom = 2,
        VerticalCenter = 7,
    }
    public partial class Grid
    {
        public Grid() { }
        public bool Enabled { get { throw null; } set { } }
        public double Interval { get { throw null; } set { } }
        public double IntervalOffset { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { throw null; } set { } }
        public System.Drawing.Color LineColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { throw null; } set { } }
        public int LineWidth { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum GridTickTypes
    {
        All = 3,
        Gridline = 2,
        None = 0,
        TickMark = 1,
    }
    public partial class HitTestResult
    {
        public HitTestResult() { }
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartElementType ChartElementType { get { throw null; } set { } }
        public object Object { get { throw null; } set { } }
        public int PointIndex { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Series Series { get { throw null; } set { } }
        public object SubObject { get { throw null; } set { } }
    }
    public partial class HorizontalLineAnnotation : System.Windows.Forms.DataVisualization.Charting.LineAnnotation
    {
        public HorizontalLineAnnotation() { }
    }
    public partial interface IDataPointFilter
    {
        bool FilterDataPoint(System.Windows.Forms.DataVisualization.Charting.DataPoint point, System.Windows.Forms.DataVisualization.Charting.Series series, int pointIndex);
    }
    public partial class ImageAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation
    {
        public ImageAnnotation() { }
        public override System.Drawing.ContentAlignment Alignment { get { throw null; } set { } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public override System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public override System.Drawing.Font Font { get { throw null; } set { } }
        public override System.Drawing.Color ForeColor { get { throw null; } set { } }
        public virtual string Image { get { throw null; } set { } }
        public System.Drawing.Color ImageTransparentColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode ImageWrapMode { get { throw null; } set { } }
        public override System.Drawing.Color LineColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { throw null; } set { } }
        public override int LineWidth { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { throw null; } set { } }
    }
    public enum IntervalAutoMode
    {
        FixedCount = 0,
        VariableCount = 1,
    }
    public enum IntervalType
    {
        Days = 4,
        Hours = 5,
        Milliseconds = 8,
        Minutes = 6,
        Months = 2,
        Number = 0,
        Seconds = 7,
        Weeks = 3,
        Years = 1,
    }
    [System.FlagsAttribute]
    public enum LabelAlignmentStyles
    {
        Bottom = 2,
        BottomLeft = 64,
        BottomRight = 128,
        Center = 256,
        Left = 8,
        Right = 4,
        Top = 1,
        TopLeft = 16,
        TopRight = 32,
    }
    [System.FlagsAttribute]
    public enum LabelAutoFitStyles
    {
        DecreaseFont = 2,
        IncreaseFont = 1,
        LabelsAngleStep30 = 8,
        LabelsAngleStep45 = 16,
        LabelsAngleStep90 = 32,
        None = 0,
        StaggeredLabels = 4,
        WordWrap = 64,
    }
    public enum LabelCalloutStyle
    {
        Box = 2,
        None = 0,
        Underlined = 1,
    }
    public enum LabelMarkStyle
    {
        Box = 3,
        LineSideMark = 2,
        None = 0,
        SideMark = 1,
    }
    public enum LabelOutsidePlotAreaStyle
    {
        No = 1,
        Partial = 2,
        Yes = 0,
    }
    public partial class LabelStyle : System.Windows.Forms.DataVisualization.Charting.ChartElement
    {
        public LabelStyle() { }
        public int Angle { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public System.Drawing.Font Font { get { throw null; } set { } }
        public System.Drawing.Color ForeColor { get { throw null; } set { } }
        public string Format { get { throw null; } set { } }
        public double Interval { get { throw null; } set { } }
        public double IntervalOffset { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { throw null; } set { } }
        public bool IsEndLabelVisible { get { throw null; } set { } }
        public bool IsStaggered { get { throw null; } set { } }
        public bool TruncatedLabels { get { throw null; } set { } }
    }
    public partial class Legend : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public Legend() { }
        public Legend(string name) { }
        public System.Drawing.StringAlignment Alignment { get { throw null; } set { } }
        public int AutoFitMinFontSize { get { throw null; } set { } }
        public System.Drawing.Color BackColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public string BackImage { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { throw null; } set { } }
        public System.Drawing.Color BackImageTransparentColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { throw null; } set { } }
        public System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public System.Drawing.Color BorderColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { throw null; } set { } }
        public int BorderWidth { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendCellColumnCollection CellColumns { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection CustomItems { get { throw null; } }
        public string DockedToChartArea { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Docking Docking { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public System.Drawing.Font Font { get { throw null; } set { } }
        public System.Drawing.Color ForeColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle HeaderSeparator { get { throw null; } set { } }
        public System.Drawing.Color HeaderSeparatorColor { get { throw null; } set { } }
        public string InsideChartArea { get { throw null; } set { } }
        public bool InterlacedRows { get { throw null; } set { } }
        public System.Drawing.Color InterlacedRowsColor { get { throw null; } set { } }
        public bool IsDockedInsideChartArea { get { throw null; } set { } }
        public bool IsEquallySpacedItems { get { throw null; } set { } }
        public bool IsTextAutoFit { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle ItemColumnSeparator { get { throw null; } set { } }
        public System.Drawing.Color ItemColumnSeparatorColor { get { throw null; } set { } }
        public int ItemColumnSpacing { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendItemOrder LegendItemOrder { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendStyle LegendStyle { get { throw null; } set { } }
        public float MaximumAutoSize { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { get { throw null; } set { } }
        public System.Drawing.Color ShadowColor { get { throw null; } set { } }
        public int ShadowOffset { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendTableStyle TableStyle { get { throw null; } set { } }
        public int TextWrapThreshold { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public System.Drawing.StringAlignment TitleAlignment { get { throw null; } set { } }
        public System.Drawing.Color TitleBackColor { get { throw null; } set { } }
        public System.Drawing.Font TitleFont { get { throw null; } set { } }
        public System.Drawing.Color TitleForeColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle TitleSeparator { get { throw null; } set { } }
        public System.Drawing.Color TitleSeparatorColor { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override void Dispose(bool disposing) { }
    }
    public partial class LegendCell : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public LegendCell() { }
        public LegendCell(string text) { }
        public LegendCell(System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text) { }
        public LegendCell(System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { }
        public virtual System.Drawing.ContentAlignment Alignment { get { throw null; } set { } }
        public virtual System.Drawing.Color BackColor { get { throw null; } set { } }
        public virtual int CellSpan { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LegendCellType CellType { get { throw null; } set { } }
        public virtual System.Drawing.Font Font { get { throw null; } set { } }
        public virtual System.Drawing.Color ForeColor { get { throw null; } set { } }
        public virtual string Image { get { throw null; } set { } }
        public virtual System.Drawing.Size ImageSize { get { throw null; } set { } }
        public virtual System.Drawing.Color ImageTransparentColor { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Legend Legend { get { throw null; } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LegendItem LegendItem { get { throw null; } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Margins Margins { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public virtual System.Drawing.Size SeriesSymbolSize { get { throw null; } set { } }
        public virtual string Text { get { throw null; } set { } }
        public virtual string ToolTip { get { throw null; } set { } }
    }
    public partial class LegendCellCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.LegendCell>
    {
        public LegendCellCollection() { }
        [System.MonoTODOAttribute]
        public int Add(System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { throw null; }
        [System.MonoTODOAttribute]
        public void Insert(int index, System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { }
    }
    public partial class LegendCellColumn : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public LegendCellColumn() { }
        public virtual System.Drawing.ContentAlignment Alignment { get { throw null; } set { } }
        public virtual System.Drawing.Color BackColor { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType ColumnType { get { throw null; } set { } }
        public virtual System.Drawing.Font Font { get { throw null; } set { } }
        public virtual System.Drawing.Color ForeColor { get { throw null; } set { } }
        public System.Drawing.StringAlignment HeaderAlignment { get { throw null; } set { } }
        public virtual System.Drawing.Color HeaderBackColor { get { throw null; } set { } }
        public virtual System.Drawing.Font HeaderFont { get { throw null; } set { } }
        public virtual System.Drawing.Color HeaderForeColor { get { throw null; } set { } }
        public virtual string HeaderText { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Legend Legend { get { throw null; } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Margins Margins { get { throw null; } set { } }
        public virtual int MaximumWidth { get { throw null; } set { } }
        public virtual int MinimumWidth { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public virtual System.Drawing.Size SeriesSymbolSize { get { throw null; } set { } }
        public virtual string Text { get { throw null; } set { } }
        public virtual string ToolTip { get { throw null; } set { } }
    }
    public partial class LegendCellColumnCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.LegendCellColumn>
    {
        public LegendCellColumnCollection() { }
        [System.MonoTODOAttribute]
        protected override void Dispose(bool disposing) { }
    }
    public enum LegendCellColumnType
    {
        SeriesSymbol = 1,
        Text = 0,
    }
    public enum LegendCellType
    {
        Image = 2,
        SeriesSymbol = 1,
        Text = 0,
    }
    public partial class LegendCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.Legend>
    {
        public LegendCollection() { }
    }
    public enum LegendImageStyle
    {
        Line = 1,
        Marker = 2,
        Rectangle = 0,
    }
    public partial class LegendItem : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public LegendItem() { }
        public LegendItem(string name, System.Drawing.Color color, string image) { }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public System.Drawing.Color BackImageTransparentColor { get { throw null; } set { } }
        public System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public System.Drawing.Color BorderColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { throw null; } set { } }
        public int BorderWidth { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendCellCollection Cells { get { throw null; } }
        public System.Drawing.Color Color { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public string Image { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendImageStyle ImageStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Legend Legend { get { throw null; } }
        public System.Drawing.Color MarkerBorderColor { get { throw null; } set { } }
        public int MarkerBorderWidth { get { throw null; } set { } }
        public System.Drawing.Color MarkerColor { get { throw null; } set { } }
        public string MarkerImage { get { throw null; } set { } }
        public System.Drawing.Color MarkerImageTransparentColor { get { throw null; } set { } }
        public int MarkerSize { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.MarkerStyle MarkerStyle { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public System.Drawing.Color SeparatorColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle SeparatorType { get { throw null; } set { } }
        public string SeriesName { get { throw null; } set { } }
        public int SeriesPointIndex { get { throw null; } set { } }
        public System.Drawing.Color ShadowColor { get { throw null; } set { } }
        public int ShadowOffset { get { throw null; } set { } }
        public string ToolTip { get { throw null; } set { } }
    }
    public enum LegendItemOrder
    {
        Auto = 0,
        ReversedSeriesOrder = 2,
        SameAsSeriesOrder = 1,
    }
    public partial class LegendItemsCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.LegendItem>
    {
        public LegendItemsCollection() { }
        [System.MonoTODOAttribute]
        public int Add(System.Drawing.Color color, string text) { throw null; }
        [System.MonoTODOAttribute]
        public int Add(string image, string text) { throw null; }
        [System.MonoTODOAttribute]
        public void Insert(int index, System.Drawing.Color color, string text) { }
        [System.MonoTODOAttribute]
        public void Insert(int index, string image, string text) { }
        [System.MonoTODOAttribute]
        public void Reverse() { }
    }
    public enum LegendSeparatorStyle
    {
        DashLine = 4,
        DotLine = 5,
        DoubleLine = 3,
        GradientLine = 6,
        Line = 1,
        None = 0,
        ThickGradientLine = 7,
        ThickLine = 2,
    }
    public enum LegendStyle
    {
        Column = 0,
        Row = 1,
        Table = 2,
    }
    public enum LegendTableStyle
    {
        Auto = 0,
        Tall = 2,
        Wide = 1,
    }
    public enum LightStyle
    {
        None = 0,
        Realistic = 2,
        Simplistic = 1,
    }
    public enum LineAnchorCapStyle
    {
        Arrow = 1,
        Diamond = 2,
        None = 0,
        Round = 4,
        Square = 3,
    }
    public partial class LineAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation
    {
        public LineAnnotation() { }
        public override System.Drawing.ContentAlignment Alignment { get { throw null; } set { } }
        public override System.Drawing.ContentAlignment AnchorAlignment { get { throw null; } set { } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public override System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle EndCap { get { throw null; } set { } }
        public override System.Drawing.Font Font { get { throw null; } set { } }
        public override System.Drawing.Color ForeColor { get { throw null; } set { } }
        public virtual bool IsInfinitive { get { throw null; } set { } }
        public override bool IsSizeAlwaysRelative { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle StartCap { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { throw null; } set { } }
    }
    public partial class Margins
    {
        public Margins() { }
        public Margins(int top, int bottom, int left, int right) { }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Bottom { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Left { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Right { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Top { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        [System.MonoTODOAttribute]
        public override int GetHashCode() { throw null; }
        public bool IsEmpty() { throw null; }
        public System.Drawing.RectangleF ToRectangleF() { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    public enum MarkerStyle
    {
        Circle = 2,
        Cross = 5,
        Diamond = 3,
        None = 0,
        Square = 1,
        Star10 = 9,
        Star4 = 6,
        Star5 = 7,
        Star6 = 8,
        Triangle = 4,
    }
    [System.ComponentModel.DefaultPropertyAttribute("Name")]
    public partial class NamedImage : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement, System.IDisposable
    {
        public NamedImage() { }
        public NamedImage(string name, System.Drawing.Image image) { }
        [System.ComponentModel.BindableAttribute(false)]
        public System.Drawing.Image Image { get { throw null; } set { } }
        [System.ComponentModel.BindableAttribute(false)]
        public override string Name { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
    }
    public partial class NamedImagesCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.NamedImage>
    {
        public NamedImagesCollection() { }
    }
    public partial class Point3D
    {
        public Point3D() { }
        public Point3D(float x, float y, float z) { }
        [System.ComponentModel.BindableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("0f, 0f")]
        public System.Drawing.PointF PointF { get { throw null; } set { } }
        [System.ComponentModel.BindableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(0f)]
        public float X { get { throw null; } set { } }
        [System.ComponentModel.BindableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(0f)]
        public float Y { get { throw null; } set { } }
        [System.ComponentModel.BindableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(0f)]
        public float Z { get { throw null; } set { } }
    }
    public enum PointSortOrder
    {
        Ascending = 0,
        Descending = 1,
    }
    public partial class PolygonAnnotation : System.Windows.Forms.DataVisualization.Charting.PolylineAnnotation
    {
        public PolygonAnnotation() { }
    }
    public partial class PolylineAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation
    {
        public PolylineAnnotation() { }
        public override System.Drawing.ContentAlignment Alignment { get { throw null; } set { } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public override System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle EndCap { get { throw null; } set { } }
        public override System.Drawing.Font Font { get { throw null; } set { } }
        public override System.Drawing.Color ForeColor { get { throw null; } set { } }
        public virtual System.Drawing.Drawing2D.GraphicsPath GraphicsPath { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AnnotationPathPointCollection GraphicsPathPoints { get { throw null; } }
        public virtual bool IsFreeDrawPlacement { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle StartCap { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { throw null; } set { } }
    }
    public partial class PrintingManager : System.IDisposable
    {
        public PrintingManager() { }
        public System.Drawing.Printing.PrintDocument PrintDocument { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public void Dispose() { }
        [System.MonoTODOAttribute]
        protected virtual void Dispose(bool disposing) { }
        [System.MonoTODOAttribute]
        public void PageSetup() { }
        [System.MonoTODOAttribute]
        public void Print(bool showPrintDialog) { }
        [System.MonoTODOAttribute]
        public void PrintPaint(System.Drawing.Graphics graphics, System.Drawing.Rectangle position) { }
        [System.MonoTODOAttribute]
        public void PrintPreview() { }
    }
    public partial class RectangleAnnotation : System.Windows.Forms.DataVisualization.Charting.TextAnnotation
    {
        public RectangleAnnotation() { }
        public override string AnnotationType { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum ScrollBarButtonStyles
    {
        All = 3,
        None = 0,
        ResetZoom = 2,
        SmallScroll = 1,
    }
    public enum ScrollBarButtonType
    {
        LargeDecrement = 3,
        LargeIncrement = 4,
        SmallDecrement = 1,
        SmallIncrement = 2,
        ThumbTracker = 0,
        ZoomReset = 5,
    }
    public partial class ScrollBarEventArgs : System.EventArgs
    {
        public ScrollBarEventArgs() { }
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonType ButtonType { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { throw null; } }
        public bool IsHandled { get { throw null; } set { } }
        public int MousePositionX { get { throw null; } }
        public int MousePositionY { get { throw null; } }
    }
    public enum ScrollType
    {
        First = 4,
        LargeDecrement = 2,
        LargeIncrement = 3,
        Last = 5,
        SmallDecrement = 0,
        SmallIncrement = 1,
    }
    [System.FlagsAttribute]
    public enum SerializationContents
    {
        All = 7,
        Appearance = 4,
        Data = 2,
        Default = 1,
    }
    public enum SerializationFormat
    {
        Binary = 1,
        Xml = 0,
    }
    public partial class Series : System.Windows.Forms.DataVisualization.Charting.DataPointCustomProperties
    {
        public Series() { }
        public Series(string name) { }
        public Series(string name, int yValues) { }
        public override string AxisLabel { get { throw null; } set { } }
        public string ChartArea { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.SeriesChartType ChartType { get { throw null; } set { } }
        public string ChartTypeName { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DataPointCustomProperties EmptyPointStyle { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public bool IsXValueIndexed { get { throw null; } set { } }
        public string Legend { get { throw null; } set { } }
        public int MarkerStep { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartColorPalette Palette { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DataPointCollection Points { get { throw null; } }
        public System.Drawing.Color ShadowColor { get { throw null; } set { } }
        public int ShadowOffset { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.SmartLabelStyle SmartLabelStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisType XAxisType { get { throw null; } set { } }
        public string XValueMember { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartValueType XValueType { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisType YAxisType { get { throw null; } set { } }
        public string YValueMembers { get { throw null; } set { } }
        public int YValuesPerPoint { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartValueType YValueType { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override void Dispose(bool disposing) { }
        [System.MonoTODOAttribute]
        public void Sort(System.Collections.Generic.IComparer<System.Windows.Forms.DataVisualization.Charting.DataPoint> comparer) { }
        [System.MonoTODOAttribute]
        public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder) { }
        [System.MonoTODOAttribute]
        public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, string sortBy) { }
    }
    public enum SeriesChartType
    {
        Area = 13,
        Bar = 7,
        BoxPlot = 28,
        Bubble = 2,
        Candlestick = 20,
        Column = 10,
        Doughnut = 18,
        ErrorBar = 27,
        FastLine = 6,
        FastPoint = 1,
        Funnel = 33,
        Kagi = 31,
        Line = 3,
        Pie = 17,
        Point = 0,
        PointAndFigure = 32,
        Polar = 26,
        Pyramid = 34,
        Radar = 25,
        Range = 21,
        RangeBar = 23,
        RangeColumn = 24,
        Renko = 29,
        Spline = 4,
        SplineArea = 14,
        SplineRange = 22,
        StackedArea = 15,
        StackedArea100 = 16,
        StackedBar = 8,
        StackedBar100 = 9,
        StackedColumn = 11,
        StackedColumn100 = 12,
        StepLine = 5,
        Stock = 19,
        ThreeLineBreak = 30,
    }
    public partial class SeriesCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.Series>
    {
        public SeriesCollection() { }
        public System.Windows.Forms.DataVisualization.Charting.Series Add(string name) { throw null; }
    }
    public partial class SmartLabelStyle
    {
        public SmartLabelStyle() { }
        public virtual System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle AllowOutsidePlotArea { get { throw null; } set { } }
        public virtual System.Drawing.Color CalloutBackColor { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle CalloutLineAnchorCapStyle { get { throw null; } set { } }
        public virtual System.Drawing.Color CalloutLineColor { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.ChartDashStyle CalloutLineDashStyle { get { throw null; } set { } }
        public virtual int CalloutLineWidth { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle CalloutStyle { get { throw null; } set { } }
        public virtual bool Enabled { get { throw null; } set { } }
        public virtual bool IsMarkerOverlappingAllowed { get { throw null; } set { } }
        public virtual bool IsOverlappedHidden { get { throw null; } set { } }
        public virtual double MaxMovingDistance { get { throw null; } set { } }
        public virtual double MinMovingDistance { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles MovingDirection { get { throw null; } set { } }
    }
    public enum StartFromZero
    {
        Auto = 0,
        No = 2,
        Yes = 1,
    }
    public partial class StatisticFormula
    {
        public StatisticFormula() { }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.AnovaResult Anova(double probability, string inputSeriesNames) { throw null; }
        [System.MonoTODOAttribute]
        public double BetaFunction(double m, double n) { throw null; }
        [System.MonoTODOAttribute]
        public double Correlation(string firstInputSeriesName, string secondInputSeriesName) { throw null; }
        [System.MonoTODOAttribute]
        public double Covariance(string firstInputSeriesName, string secondInputSeriesName) { throw null; }
        [System.MonoTODOAttribute]
        public double FDistribution(double value, int firstDegreeOfFreedom, int secondDegreeOfFreedom) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.FTestResult FTest(double probability, string firstInputSeriesName, string secondInputSeriesName) { throw null; }
        [System.MonoTODOAttribute]
        public double GammaFunction(double value) { throw null; }
        [System.MonoTODOAttribute]
        public double InverseFDistribution(double probability, int firstDegreeOfFreedom, int secondDegreeOfFreedom) { throw null; }
        [System.MonoTODOAttribute]
        public double InverseNormalDistribution(double probability) { throw null; }
        [System.MonoTODOAttribute]
        public double InverseTDistribution(double probability, int degreeOfFreedom) { throw null; }
        [System.MonoTODOAttribute]
        public double Mean(string inputSeriesName) { throw null; }
        [System.MonoTODOAttribute]
        public double Median(string inputSeriesName) { throw null; }
        [System.MonoTODOAttribute]
        public double NormalDistribution(double zValue) { throw null; }
        [System.MonoTODOAttribute]
        public double TDistribution(double value, int degreeOfFreedom, bool oneTail) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.TTestResult TTestEqualVariances(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.TTestResult TTestPaired(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.TTestResult TTestUnequalVariances(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName) { throw null; }
        [System.MonoTODOAttribute]
        public double Variance(string inputSeriesName, bool sampleVariance) { throw null; }
        [System.MonoTODOAttribute]
        public System.Windows.Forms.DataVisualization.Charting.ZTestResult ZTest(double hypothesizedMeanDifference, double varianceFirstGroup, double varianceSecondGroup, double probability, string firstInputSeriesName, string secondInputSeriesName) { throw null; }
    }
    public partial class StripLine : System.Windows.Forms.DataVisualization.Charting.ChartElement
    {
        public StripLine() { }
        public System.Drawing.Color BackColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public string BackImage { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { throw null; } set { } }
        public System.Drawing.Color BackImageTransparentColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { throw null; } set { } }
        public System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public System.Drawing.Color BorderColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { throw null; } set { } }
        public int BorderWidth { get { throw null; } set { } }
        public System.Drawing.Font Font { get { throw null; } set { } }
        public System.Drawing.Color ForeColor { get { throw null; } set { } }
        public double Interval { get { throw null; } set { } }
        public double IntervalOffset { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public double StripWidth { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType StripWidthType { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public System.Drawing.StringAlignment TextAlignment { get { throw null; } set { } }
        public System.Drawing.StringAlignment TextLineAlignment { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.TextOrientation TextOrientation { get { throw null; } set { } }
        public string ToolTip { get { throw null; } set { } }
    }
    public partial class StripLinesCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.StripLine>
    {
        public StripLinesCollection() { }
    }
    public partial class TextAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation
    {
        public TextAnnotation() { }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public override System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public override System.Drawing.Font Font { get { throw null; } set { } }
        public virtual bool IsMultiline { get { throw null; } set { } }
        public override System.Drawing.Color LineColor { get { throw null; } set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { throw null; } set { } }
        public override int LineWidth { get { throw null; } set { } }
        public virtual string Text { get { throw null; } set { } }
    }
    public enum TextAntiAliasingQuality
    {
        High = 1,
        Normal = 0,
        SystemDefault = 2,
    }
    public enum TextOrientation
    {
        Auto = 0,
        Horizontal = 1,
        Rotated270 = 3,
        Rotated90 = 2,
        Stacked = 4,
    }
    public enum TextStyle
    {
        Default = 0,
        Embed = 3,
        Emboss = 2,
        Frame = 4,
        Shadow = 1,
    }
    public partial class TickMark : System.Windows.Forms.DataVisualization.Charting.Grid
    {
        public TickMark() { }
        public float Size { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.TickMarkStyle TickMarkStyle { get { throw null; } set { } }
    }
    public enum TickMarkStyle
    {
        AcrossAxis = 3,
        InsideArea = 2,
        None = 0,
        OutsideArea = 1,
    }
    public partial class Title : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement, System.IDisposable
    {
        public Title() { }
        public Title(string text) { }
        public Title(string text, System.Windows.Forms.DataVisualization.Charting.Docking docking) { }
        public Title(string text, System.Windows.Forms.DataVisualization.Charting.Docking docking, System.Drawing.Font font, System.Drawing.Color color) { }
        public System.Drawing.ContentAlignment Alignment { get { throw null; } set { } }
        public System.Drawing.Color BackColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { throw null; } set { } }
        public string BackImage { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { throw null; } set { } }
        public System.Drawing.Color BackImageTransparentColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { throw null; } set { } }
        public System.Drawing.Color BackSecondaryColor { get { throw null; } set { } }
        public System.Drawing.Color BorderColor { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { throw null; } set { } }
        public int BorderWidth { get { throw null; } set { } }
        public string DockedToChartArea { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.Docking Docking { get { throw null; } set { } }
        public int DockingOffset { get { throw null; } set { } }
        public System.Drawing.Font Font { get { throw null; } set { } }
        public System.Drawing.Color ForeColor { get { throw null; } set { } }
        public bool IsDockedInsideChartArea { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { get { throw null; } set { } }
        public System.Drawing.Color ShadowColor { get { throw null; } set { } }
        public int ShadowOffset { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.TextOrientation TextOrientation { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { throw null; } set { } }
        public string ToolTip { get { throw null; } set { } }
        public virtual bool Visible { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override void Dispose(bool disposing) { }
    }
    public partial class TitleCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.Title>
    {
        public TitleCollection() { }
    }
    public partial class ToolTipEventArgs : System.EventArgs
    {
        public ToolTipEventArgs(int x, int y, string text, System.Windows.Forms.DataVisualization.Charting.HitTestResult result) { }
        public System.Windows.Forms.DataVisualization.Charting.HitTestResult HitTestResult { get { throw null; } }
        public string Text { get { throw null; } set { } }
        public int X { get { throw null; } }
        public int Y { get { throw null; } }
    }
    public partial class TTestResult
    {
        public TTestResult() { }
        public double DegreeOfFreedom { get { throw null; } }
        public double FirstSeriesMean { get { throw null; } }
        public double FirstSeriesVariance { get { throw null; } }
        public double ProbabilityTOneTail { get { throw null; } }
        public double ProbabilityTTwoTail { get { throw null; } }
        public double SecondSeriesMean { get { throw null; } }
        public double SecondSeriesVariance { get { throw null; } }
        public double TCriticalValueOneTail { get { throw null; } }
        public double TCriticalValueTwoTail { get { throw null; } }
        public double TValue { get { throw null; } }
    }
    public partial class VerticalLineAnnotation : System.Windows.Forms.DataVisualization.Charting.LineAnnotation
    {
        public VerticalLineAnnotation() { }
    }
    public partial class ViewEventArgs : System.EventArgs
    {
        public ViewEventArgs() { }
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { throw null; } }
        public double NewPosition { get { throw null; } set { } }
        public double NewSize { get { throw null; } set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType NewSizeType { get { throw null; } set { } }
    }
    public partial class ZTestResult
    {
        public ZTestResult() { }
        public double FirstSeriesMean { get { throw null; } }
        public double FirstSeriesVariance { get { throw null; } }
        public double ProbabilityZOneTail { get { throw null; } }
        public double ProbabilityZTwoTail { get { throw null; } }
        public double SecondSeriesMean { get { throw null; } }
        public double SecondSeriesVariance { get { throw null; } }
        public double ZCriticalValueOneTail { get { throw null; } }
        public double ZCriticalValueTwoTail { get { throw null; } }
        public double ZValue { get { throw null; } }
    }
}
