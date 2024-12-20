// <auto-generated />
#nullable enable

namespace ChromeProtocol.Domains
{
  /// <summary>TBD</summary>
  public static partial class DotnetDebugger
  {
    /// <summary>TBD.</summary>
    /// <param name="ScriptId">Script identifier as reported in the `Debugger.scriptParsed`.</param>
    /// <param name="LineNumber">Line number in the script (0-based).</param>
    /// <param name="ColumnNumber">Column number in the script (0-based).</param>
    public record SourceLocationType(
      [property: System.Text.Json.Serialization.JsonPropertyName("scriptId")]
      ChromeProtocol.Domains.Runtime.ScriptIdType ScriptId,
      [property: System.Text.Json.Serialization.JsonPropertyName("lineNumber")]
      int LineNumber,
      [property: System.Text.Json.Serialization.JsonPropertyName("columnNumber")]
      int? ColumnNumber = default
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>TBD.</summary>
    /// <param name="JustMyCodeStepping">If true, enables stepping only into user code, not library one.</param>
    public static ChromeProtocol.Domains.DotnetDebugger.SetDebuggerPropertyRequest SetDebuggerProperty(bool JustMyCodeStepping)    
    {
      return new ChromeProtocol.Domains.DotnetDebugger.SetDebuggerPropertyRequest(JustMyCodeStepping);
    }
    /// <summary>TBD.</summary>
    /// <param name="JustMyCodeStepping">If true, enables stepping only into user code, not library one.</param>
    [ChromeProtocol.Core.MethodName("DotnetDebugger.setDebuggerProperty")]
    public record SetDebuggerPropertyRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("JustMyCodeStepping")]
      bool JustMyCodeStepping
    ) : ChromeProtocol.Core.ICommand<SetDebuggerPropertyRequestResult>
    {
    }
    /// <param name="JustMyCodeEnabled">TBD</param>
    public record SetDebuggerPropertyRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("justMyCodeEnabled")]
      bool? JustMyCodeEnabled = default
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>TBD</summary>
    /// <param name="Location">TBD</param>
    public static ChromeProtocol.Domains.DotnetDebugger.SetNextIPRequest SetNextIP(ChromeProtocol.Domains.DotnetDebugger.SourceLocationType Location)    
    {
      return new ChromeProtocol.Domains.DotnetDebugger.SetNextIPRequest(Location);
    }
    /// <summary>TBD</summary>
    /// <param name="Location">TBD</param>
    [ChromeProtocol.Core.MethodName("DotnetDebugger.setNextIP")]
    public record SetNextIPRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("location")]
      ChromeProtocol.Domains.DotnetDebugger.SourceLocationType Location
    ) : ChromeProtocol.Core.ICommand<SetNextIPRequestResult>
    {
    }
    public record SetNextIPRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>TBD</summary>
    /// <param name="ModuleGUID">TBD</param>
    /// <param name="Dmeta">The metadata changes to be applied</param>
    /// <param name="Dil">The IL changes to be applied</param>
    /// <param name="Dpdb">The PDB changes to be applied</param>
    public static ChromeProtocol.Domains.DotnetDebugger.ApplyUpdatesRequest ApplyUpdates(string ModuleGUID, string Dmeta, string Dil, string Dpdb)    
    {
      return new ChromeProtocol.Domains.DotnetDebugger.ApplyUpdatesRequest(ModuleGUID, Dmeta, Dil, Dpdb);
    }
    /// <summary>TBD</summary>
    /// <param name="ModuleGUID">TBD</param>
    /// <param name="Dmeta">The metadata changes to be applied</param>
    /// <param name="Dil">The IL changes to be applied</param>
    /// <param name="Dpdb">The PDB changes to be applied</param>
    [ChromeProtocol.Core.MethodName("DotnetDebugger.applyUpdates")]
    public record ApplyUpdatesRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("moduleGUID")]
      string ModuleGUID,
      [property: System.Text.Json.Serialization.JsonPropertyName("dmeta")]
      string Dmeta,
      [property: System.Text.Json.Serialization.JsonPropertyName("dil")]
      string Dil,
      [property: System.Text.Json.Serialization.JsonPropertyName("dpdb")]
      string Dpdb
    ) : ChromeProtocol.Core.ICommand<ApplyUpdatesRequestResult>
    {
    }
    public record ApplyUpdatesRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Note: this command will never respond, so don&#39;t wait for the response. When succeeded, it will emit &#39;Debugger.scriptParsed&#39; event per each parsed .NET source file.</summary>
    /// <param name="Url">TBD</param>
    public static ChromeProtocol.Domains.DotnetDebugger.AddSymbolServerUrlRequest AddSymbolServerUrl(string Url)    
    {
      return new ChromeProtocol.Domains.DotnetDebugger.AddSymbolServerUrlRequest(Url);
    }
    /// <summary>Note: this command will never respond, so don&#39;t wait for the response. When succeeded, it will emit &#39;Debugger.scriptParsed&#39; event per each parsed .NET source file.</summary>
    /// <param name="Url">TBD</param>
    [ChromeProtocol.Core.MethodName("DotnetDebugger.addSymbolServerUrl")]
    public record AddSymbolServerUrlRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("url")]
      string Url
    ) : ChromeProtocol.Core.ICommand<AddSymbolServerUrlRequestResult>
    {
    }
    public record AddSymbolServerUrlRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>TBD</summary>
    /// <param name="AssemblyName">TBD</param>
    /// <param name="TypeName">TBD</param>
    /// <param name="MethodName">TBD</param>
    public static ChromeProtocol.Domains.DotnetDebugger.GetMethodLocationRequest GetMethodLocation(string AssemblyName, string TypeName, string MethodName)    
    {
      return new ChromeProtocol.Domains.DotnetDebugger.GetMethodLocationRequest(AssemblyName, TypeName, MethodName);
    }
    /// <summary>TBD</summary>
    /// <param name="AssemblyName">TBD</param>
    /// <param name="TypeName">TBD</param>
    /// <param name="MethodName">TBD</param>
    [ChromeProtocol.Core.MethodName("DotnetDebugger.getMethodLocation")]
    public record GetMethodLocationRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("assemblyName")]
      string AssemblyName,
      [property: System.Text.Json.Serialization.JsonPropertyName("typeName")]
      string TypeName,
      [property: System.Text.Json.Serialization.JsonPropertyName("methodName")]
      string MethodName
    ) : ChromeProtocol.Core.ICommand<GetMethodLocationRequestResult>
    {
    }
    /// <param name="Line">TBD</param>
    /// <param name="Column">TBD</param>
    /// <param name="Url">TBD</param>
    public record GetMethodLocationRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("line")]
      int Line,
      [property: System.Text.Json.Serialization.JsonPropertyName("column")]
      int Column,
      [property: System.Text.Json.Serialization.JsonPropertyName("url")]
      string Url
    ) : ChromeProtocol.Core.IType
    {
    }
  }
}
