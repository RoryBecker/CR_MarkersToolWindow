using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace MarkersToolWindow
{
  [Export(typeof(IVsixPluginExtension))]
  public class MarkersToolWindowExtension : IVsixPluginExtension { }
}