// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Windows.Forms.DataVisualization.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Windows.Forms.DataVisualization.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Windows.Forms.DataVisualization.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(1))]
namespace System
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
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
        public virtual System.Drawing.ContentAlignment Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool AllowAnchorMoving { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool AllowMoving { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool AllowPathEditing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool AllowResizing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool AllowSelecting { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool AllowTextEditing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.ContentAlignment AnchorAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.DataPoint AnchorDataPoint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string AnchorDataPointName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double AnchorOffsetX { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double AnchorOffsetY { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double AnchorX { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double AnchorY { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AnnotationGroup AnnotationGroup { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract string AnnotationType { get; }
        public virtual System.Windows.Forms.DataVisualization.Charting.Axis AxisX { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string AxisXName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Axis AxisY { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string AxisYName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double Bottom { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string ClipToChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double Height { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsSelected { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsSizeAlwaysRelative { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int LineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color ShadowColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int ShadowOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AnnotationSmartLabelStyle SmartLabelStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string ToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool Visible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double Width { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double X { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double Y { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string YAxisName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public override System.Drawing.ContentAlignment Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool AllowAnchorMoving { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool AllowMoving { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool AllowPathEditing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool AllowResizing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool AllowSelecting { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool AllowTextEditing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AnnotationCollection Annotations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string ClipToChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool IsSelected { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool IsSizeAlwaysRelative { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override int LineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color ShadowColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override int ShadowOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool Visible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class AnnotationPathPoint : System.Windows.Forms.DataVisualization.Charting.ChartElement
    {
        public AnnotationPathPoint() { }
        public AnnotationPathPoint(float x, float y) { }
        public AnnotationPathPoint(float x, float y, byte type) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public byte PointType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public float X { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public float Y { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.Annotation Annotation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.PointF NewAnchorLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double NewAnchorLocationX { get { throw null; } set { } }
        public double NewAnchorLocationY { get { throw null; } set { } }
        public double NewLocationX { get { throw null; } set { } }
        public double NewLocationY { get { throw null; } set { } }
        public System.Drawing.RectangleF NewPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public double DegreeOfFreedomBetweenGroups { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double DegreeOfFreedomTotal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double DegreeOfFreedomWithinGroups { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double FCriticalValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double FRatio { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double MeanSquareVarianceBetweenGroups { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double MeanSquareVarianceWithinGroups { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double SumOfSquaresBetweenGroups { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double SumOfSquaresTotal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double SumOfSquaresWithinGroups { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
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
        public override System.Drawing.ContentAlignment AnchorAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string AnnotationType { get { throw null; } }
        public virtual int ArrowSize { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.ArrowStyle ArrowStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle ArrowStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.AxisName AxisName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual double Crossing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.CustomLabelCollection CustomLabels { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.AxisEnabled Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color InterlacedColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Interval { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode IntervalAutoMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double IntervalOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsInterlaced { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsLabelAutoFit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsLogarithmic { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsMarginVisible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsMarksNextToAxis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsReversed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsStartedFromZero { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int LabelAutoFitMaxFontSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int LabelAutoFitMinFontSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles LabelAutoFitStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LabelStyle LabelStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int LineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double LogarithmBase { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Grid MajorGrid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.TickMark MajorTickMark { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Maximum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public float MaximumAutoSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Minimum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Grid MinorGrid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.TickMark MinorTickMark { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { get { throw null; } set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle ScaleBreakStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisScaleView ScaleView { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisScrollBar ScrollBar { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.StripLinesCollection StripLines { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.TextOrientation TextOrientation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Title { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.StringAlignment TitleAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Font TitleFont { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color TitleForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.BreakLineStyle BreakLineStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int CollapsibleSpaceThreshold { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int LineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MaxNumberOfBreaks { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Spacing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.StartFromZero StartFromZero { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class AxisScaleView
    {
        public AxisScaleView() { }
        public bool IsZoomed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double MinSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType MinSizeType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Size { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType SizeType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double SmallScrollMinSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType SmallScrollMinSizeType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double SmallScrollSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType SmallScrollSizeType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double ViewMaximum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double ViewMinimum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Zoomable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ButtonColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles ButtonStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsPositionedInside { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsVisible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Size { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.BorderSkin BorderSkin { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class BorderSkin : System.Windows.Forms.DataVisualization.Charting.ChartElement
    {
        public BorderSkin() { }
        public System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BackImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int BorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color PageColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle SkinStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public override System.Drawing.ContentAlignment AnchorAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override double AnchorOffsetX { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override double AnchorOffsetY { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle CalloutAnchorCap { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.CalloutStyle CalloutStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override int LineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.AnnotationCollection Annotations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles AntiAliasing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Image BackgroundImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BackImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BorderlineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderlineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int BorderlineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.BorderSkin BorderSkin { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int BorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BuildNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartAreaCollection ChartAreas { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.DataManipulator DataManipulator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object DataSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected override System.Drawing.Size DefaultSize { get { throw null; } }
        public new System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.NamedImagesCollection Images { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsSoftShadows { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendCollection Legends { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartColorPalette Palette { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color[] PaletteCustomColors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.PrintingManager Printing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double RenderingDpiX { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double RenderingDpiY { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartSerializer Serializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.SeriesCollection Series { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public new System.Drawing.Size Size { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool SuppressExceptions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality TextAntiAliasingQuality { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.TitleCollection Titles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
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
        public System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations AlignmentOrientation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles AlignmentStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string AlignWithChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea3DStyle Area3DStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis[] Axes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis AxisX { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis AxisX2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis AxisY { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Axis AxisY2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BackImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int BorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Cursor CursorX { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Cursor CursorY { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition InnerPlotPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsSameFontSizeForAllAxes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ShadowColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int ShadowOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool Visible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public bool Enable3D { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int Inclination { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsClustered { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsRightAngleAxes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LightStyle LightStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int Perspective { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int PointDepth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int PointGapDepth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int Rotation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int WallWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public object Tag { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Drawing.Graphics Graphics { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public virtual string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ChartNamedElementCollection<T> : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<T> where T : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public ChartNamedElementCollection() { }
        public T this[string name] { get { throw null; } set { } }
        protected virtual string NamePrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
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
        public System.Windows.Forms.DataVisualization.Charting.Chart Chart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object ChartElement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartGraphics ChartGraphics { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ChartSerializer
    {
        public ChartSerializer() { }
        public System.Windows.Forms.DataVisualization.Charting.SerializationContents Content { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.SerializationFormat Format { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsResetWhenLoading { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsTemplateMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsUnknownAttributeIgnored { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string NonSerializableContent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string SerializableContent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public bool AutoScroll { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisType AxisType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Interval { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double IntervalOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsUserEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsUserSelectionEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int LineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color SelectionColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double SelectionEnd { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double SelectionStart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double NewPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double NewSelectionEnd { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double NewSelectionStart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class CustomizeLegendEventArgs : System.EventArgs
    {
        public CustomizeLegendEventArgs() { }
        public System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection LegendItems { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string LegendName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class CustomLabel : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public CustomLabel() { }
        public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle) { }
        public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle, System.Windows.Forms.DataVisualization.Charting.GridTickTypes gridTick) { }
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double FromPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.GridTickTypes GridTicks { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Image { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle LabelMark { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color MarkColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int RowIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double ToPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public bool IsEmptyPointIgnored { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsStartFromFirst { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.StatisticFormula Statistics { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
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
        public bool FilterMatchedPoints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool FilterSetEmptyPoints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public bool IsEmpty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double XValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double[] YValues { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public virtual string AxisLabel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BackImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int BorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color Color { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string CustomProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.CustomProperties CustomPropertiesExtended { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsValueShownAsLabel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsVisibleInLegend { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public string this[int idx] { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string this[string propName] { get { throw null; } set { } }
        public virtual string Label { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int LabelAngle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color LabelBackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color LabelBorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LabelBorderDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int LabelBorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color LabelForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string LabelFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string LabelToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string LegendText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string LegendToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color MarkerBorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MarkerBorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color MarkerColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string MarkerImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color MarkerImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MarkerSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.MarkerStyle MarkerStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public bool Auto { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public float Bottom { get { throw null; } }
        public float Height { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public float Right { get { throw null; } }
        public System.Drawing.SizeF Size { get { throw null; } }
        public float Width { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public float X { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public float Y { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.ChartElementType ElementType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Format { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string LocalizedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object SenderTag { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartValueType ValueType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class FTestResult
    {
        public FTestResult() { }
        public double FCriticalValueOneTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double FirstSeriesMean { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double FirstSeriesVariance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double FValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double ProbabilityFOneTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double SecondSeriesMean { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double SecondSeriesVariance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
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
        public bool Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Interval { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double IntervalOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int LineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartElementType ChartElementType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object Object { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int PointIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Series Series { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object SubObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public override System.Drawing.ContentAlignment Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string Image { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode ImageWrapMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override int LineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public int Angle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Format { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Interval { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double IntervalOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsEndLabelVisible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsStaggered { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool TruncatedLabels { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class Legend : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public Legend() { }
        public Legend(string name) { }
        public System.Drawing.StringAlignment Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int AutoFitMinFontSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BackImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int BorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendCellColumnCollection CellColumns { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection CustomItems { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string DockedToChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Docking Docking { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle HeaderSeparator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color HeaderSeparatorColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string InsideChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool InterlacedRows { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color InterlacedRowsColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsDockedInsideChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsEquallySpacedItems { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsTextAutoFit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle ItemColumnSeparator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ItemColumnSeparatorColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int ItemColumnSpacing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendItemOrder LegendItemOrder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendStyle LegendStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public float MaximumAutoSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ShadowColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int ShadowOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendTableStyle TableStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int TextWrapThreshold { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Title { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.StringAlignment TitleAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color TitleBackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Font TitleFont { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color TitleForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle TitleSeparator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color TitleSeparatorColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        protected override void Dispose(bool disposing) { }
    }
    public partial class LegendCell : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement
    {
        public LegendCell() { }
        public LegendCell(string text) { }
        public LegendCell(System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text) { }
        public LegendCell(System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { }
        public virtual System.Drawing.ContentAlignment Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int CellSpan { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LegendCellType CellType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string Image { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Size ImageSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color ImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Legend Legend { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LegendItem LegendItem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Margins Margins { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Size SeriesSymbolSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string ToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public virtual System.Drawing.ContentAlignment Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType ColumnType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.StringAlignment HeaderAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color HeaderBackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Font HeaderFont { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color HeaderForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string HeaderText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Legend Legend { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual System.Windows.Forms.DataVisualization.Charting.Margins Margins { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int MaximumWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int MinimumWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Size SeriesSymbolSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string ToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int BorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendCellCollection Cells { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Drawing.Color Color { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Image { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendImageStyle ImageStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Legend Legend { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Drawing.Color MarkerBorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MarkerBorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color MarkerColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string MarkerImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color MarkerImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MarkerSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.MarkerStyle MarkerStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color SeparatorColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle SeparatorType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string SeriesName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int SeriesPointIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ShadowColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int ShadowOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public override System.Drawing.ContentAlignment Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.ContentAlignment AnchorAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle EndCap { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsInfinitive { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool IsSizeAlwaysRelative { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle StartCap { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class Margins
    {
        public Margins() { }
        public Margins(int top, int bottom, int left, int right) { }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Bottom { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Top { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Drawing.Image Image { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public float X { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.BindableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(0f)]
        public float Y { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.BindableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(0f)]
        public float Z { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public override System.Drawing.ContentAlignment Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle EndCap { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Drawing2D.GraphicsPath GraphicsPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AnnotationPathPointCollection GraphicsPathPoints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual bool IsFreeDrawPlacement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle StartCap { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class PrintingManager : System.IDisposable
    {
        public PrintingManager() { }
        public System.Drawing.Printing.PrintDocument PrintDocument { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonType ButtonType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MousePositionX { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int MousePositionY { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
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
        public override string AxisLabel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.SeriesChartType ChartType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ChartTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DataPointCustomProperties EmptyPointStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsXValueIndexed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Legend { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MarkerStep { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartColorPalette Palette { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DataPointCollection Points { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Drawing.Color ShadowColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int ShadowOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.SmartLabelStyle SmartLabelStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisType XAxisType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string XValueMember { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartValueType XValueType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.AxisType YAxisType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string YValueMembers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int YValuesPerPoint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartValueType YValueType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public virtual System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle AllowOutsidePlotArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color CalloutBackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle CalloutLineAnchorCapStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Drawing.Color CalloutLineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.ChartDashStyle CalloutLineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int CalloutLineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle CalloutStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsMarkerOverlappingAllowed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsOverlappedHidden { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double MaxMovingDistance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual double MinMovingDistance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles MovingDirection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BackImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int BorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double Interval { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double IntervalOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double StripWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType StripWidthType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.StringAlignment TextAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.StringAlignment TextLineAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.TextOrientation TextOrientation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class StripLinesCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.StripLine>
    {
        public StripLinesCollection() { }
    }
    public partial class TextAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation
    {
        public TextAnnotation() { }
        public override string AnnotationType { get { throw null; } }
        public override System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsMultiline { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Drawing.Color LineColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override int LineWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public float Size { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.TickMarkStyle TickMarkStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Drawing.ContentAlignment Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BackImage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackImageTransparentColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BackSecondaryColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color BorderColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int BorderWidth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string DockedToChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.Docking Docking { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int DockingOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Font Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ForeColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsDockedInsideChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Drawing.Color ShadowColor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int ShadowOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.TextOrientation TextOrientation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ToolTip { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool Visible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public System.Windows.Forms.DataVisualization.Charting.HitTestResult HitTestResult { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int X { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int Y { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class TTestResult
    {
        public TTestResult() { }
        public double DegreeOfFreedom { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double FirstSeriesMean { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double FirstSeriesVariance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double ProbabilityTOneTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double ProbabilityTTwoTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double SecondSeriesMean { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double SecondSeriesVariance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double TCriticalValueOneTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double TCriticalValueTwoTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double TValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class VerticalLineAnnotation : System.Windows.Forms.DataVisualization.Charting.LineAnnotation
    {
        public VerticalLineAnnotation() { }
    }
    public partial class ViewEventArgs : System.EventArgs
    {
        public ViewEventArgs() { }
        public System.Windows.Forms.DataVisualization.Charting.Axis Axis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double NewPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double NewSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType NewSizeType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ZTestResult
    {
        public ZTestResult() { }
        public double FirstSeriesMean { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double FirstSeriesVariance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double ProbabilityZOneTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double ProbabilityZTwoTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double SecondSeriesMean { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double SecondSeriesVariance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double ZCriticalValueOneTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double ZCriticalValueTwoTail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public double ZValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
