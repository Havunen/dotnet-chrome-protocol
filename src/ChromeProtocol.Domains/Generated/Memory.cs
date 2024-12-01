// <auto-generated />
#nullable enable

namespace ChromeProtocol.Domains
{
  public static partial class Memory
  {
    /// <summary>Memory pressure level.</summary>
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record PressureLevelType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <summary>Heap profile sample.</summary>
    /// <param name="Size">Size of the sampled allocation.</param>
    /// <param name="Total">Total bytes attributed to this sample.</param>
    /// <param name="Stack">Execution stack at the point of allocation.</param>
    public record SamplingProfileNodeType(
      [property: System.Text.Json.Serialization.JsonPropertyName("size")]
      double Size,
      [property: System.Text.Json.Serialization.JsonPropertyName("total")]
      double Total,
      [property: System.Text.Json.Serialization.JsonPropertyName("stack")]
      System.Collections.Generic.IReadOnlyList<string> Stack
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Array of heap profile samples.</summary>
    public record SamplingProfileType(
      [property: System.Text.Json.Serialization.JsonPropertyName("samples")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Memory.SamplingProfileNodeType> Samples,
      [property: System.Text.Json.Serialization.JsonPropertyName("modules")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Memory.ModuleType> Modules
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Executable module information</summary>
    /// <param name="Name">Name of the module.</param>
    /// <param name="Uuid">UUID of the module.</param>
    /// <param name="BaseAddress">
    /// Base address where the module is loaded into memory. Encoded as a decimal<br/>
    /// or hexadecimal (0x prefixed) string.<br/>
    /// </param>
    /// <param name="Size">Size of the module in bytes.</param>
    public record ModuleType(
      [property: System.Text.Json.Serialization.JsonPropertyName("name")]
      string Name,
      [property: System.Text.Json.Serialization.JsonPropertyName("uuid")]
      string Uuid,
      [property: System.Text.Json.Serialization.JsonPropertyName("baseAddress")]
      string BaseAddress,
      [property: System.Text.Json.Serialization.JsonPropertyName("size")]
      double Size
    ) : ChromeProtocol.Core.IType
    {
    }
    public static ChromeProtocol.Domains.Memory.GetDOMCountersRequest GetDOMCounters()    
    {
      return new ChromeProtocol.Domains.Memory.GetDOMCountersRequest();
    }
    [ChromeProtocol.Core.MethodName("Memory.getDOMCounters")]
    public record GetDOMCountersRequest() : ChromeProtocol.Core.ICommand<GetDOMCountersRequestResult>
    {
    }
    public record GetDOMCountersRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("documents")]
      int Documents,
      [property: System.Text.Json.Serialization.JsonPropertyName("nodes")]
      int Nodes,
      [property: System.Text.Json.Serialization.JsonPropertyName("jsEventListeners")]
      int JsEventListeners
    ) : ChromeProtocol.Core.IType
    {
    }
    public static ChromeProtocol.Domains.Memory.PrepareForLeakDetectionRequest PrepareForLeakDetection()    
    {
      return new ChromeProtocol.Domains.Memory.PrepareForLeakDetectionRequest();
    }
    [ChromeProtocol.Core.MethodName("Memory.prepareForLeakDetection")]
    public record PrepareForLeakDetectionRequest() : ChromeProtocol.Core.ICommand<PrepareForLeakDetectionRequestResult>
    {
    }
    public record PrepareForLeakDetectionRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Simulate OomIntervention by purging V8 memory.</summary>
    public static ChromeProtocol.Domains.Memory.ForciblyPurgeJavaScriptMemoryRequest ForciblyPurgeJavaScriptMemory()    
    {
      return new ChromeProtocol.Domains.Memory.ForciblyPurgeJavaScriptMemoryRequest();
    }
    /// <summary>Simulate OomIntervention by purging V8 memory.</summary>
    [ChromeProtocol.Core.MethodName("Memory.forciblyPurgeJavaScriptMemory")]
    public record ForciblyPurgeJavaScriptMemoryRequest() : ChromeProtocol.Core.ICommand<ForciblyPurgeJavaScriptMemoryRequestResult>
    {
    }
    public record ForciblyPurgeJavaScriptMemoryRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Enable/disable suppressing memory pressure notifications in all processes.</summary>
    /// <param name="Suppressed">If true, memory pressure notifications will be suppressed.</param>
    public static ChromeProtocol.Domains.Memory.SetPressureNotificationsSuppressedRequest SetPressureNotificationsSuppressed(bool Suppressed)    
    {
      return new ChromeProtocol.Domains.Memory.SetPressureNotificationsSuppressedRequest(Suppressed);
    }
    /// <summary>Enable/disable suppressing memory pressure notifications in all processes.</summary>
    /// <param name="Suppressed">If true, memory pressure notifications will be suppressed.</param>
    [ChromeProtocol.Core.MethodName("Memory.setPressureNotificationsSuppressed")]
    public record SetPressureNotificationsSuppressedRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("suppressed")]
      bool Suppressed
    ) : ChromeProtocol.Core.ICommand<SetPressureNotificationsSuppressedRequestResult>
    {
    }
    public record SetPressureNotificationsSuppressedRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Simulate a memory pressure notification in all processes.</summary>
    /// <param name="Level">Memory pressure level of the notification.</param>
    public static ChromeProtocol.Domains.Memory.SimulatePressureNotificationRequest SimulatePressureNotification(ChromeProtocol.Domains.Memory.PressureLevelType Level)    
    {
      return new ChromeProtocol.Domains.Memory.SimulatePressureNotificationRequest(Level);
    }
    /// <summary>Simulate a memory pressure notification in all processes.</summary>
    /// <param name="Level">Memory pressure level of the notification.</param>
    [ChromeProtocol.Core.MethodName("Memory.simulatePressureNotification")]
    public record SimulatePressureNotificationRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("level")]
      ChromeProtocol.Domains.Memory.PressureLevelType Level
    ) : ChromeProtocol.Core.ICommand<SimulatePressureNotificationRequestResult>
    {
    }
    public record SimulatePressureNotificationRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Start collecting native memory profile.</summary>
    /// <param name="SamplingInterval">Average number of bytes between samples.</param>
    /// <param name="SuppressRandomness">Do not randomize intervals between samples.</param>
    public static ChromeProtocol.Domains.Memory.StartSamplingRequest StartSampling(int? SamplingInterval = default, bool? SuppressRandomness = default)    
    {
      return new ChromeProtocol.Domains.Memory.StartSamplingRequest(SamplingInterval, SuppressRandomness);
    }
    /// <summary>Start collecting native memory profile.</summary>
    /// <param name="SamplingInterval">Average number of bytes between samples.</param>
    /// <param name="SuppressRandomness">Do not randomize intervals between samples.</param>
    [ChromeProtocol.Core.MethodName("Memory.startSampling")]
    public record StartSamplingRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("samplingInterval")]
      int? SamplingInterval = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("suppressRandomness")]
      bool? SuppressRandomness = default
    ) : ChromeProtocol.Core.ICommand<StartSamplingRequestResult>
    {
    }
    public record StartSamplingRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Stop collecting native memory profile.</summary>
    public static ChromeProtocol.Domains.Memory.StopSamplingRequest StopSampling()    
    {
      return new ChromeProtocol.Domains.Memory.StopSamplingRequest();
    }
    /// <summary>Stop collecting native memory profile.</summary>
    [ChromeProtocol.Core.MethodName("Memory.stopSampling")]
    public record StopSamplingRequest() : ChromeProtocol.Core.ICommand<StopSamplingRequestResult>
    {
    }
    public record StopSamplingRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Retrieve native memory allocations profile<br/>
    /// collected since renderer process startup.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.Memory.GetAllTimeSamplingProfileRequest GetAllTimeSamplingProfile()    
    {
      return new ChromeProtocol.Domains.Memory.GetAllTimeSamplingProfileRequest();
    }
    /// <summary>
    /// Retrieve native memory allocations profile<br/>
    /// collected since renderer process startup.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("Memory.getAllTimeSamplingProfile")]
    public record GetAllTimeSamplingProfileRequest() : ChromeProtocol.Core.ICommand<GetAllTimeSamplingProfileRequestResult>
    {
    }
    public record GetAllTimeSamplingProfileRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("profile")]
      ChromeProtocol.Domains.Memory.SamplingProfileType Profile
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Retrieve native memory allocations profile<br/>
    /// collected since browser process startup.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.Memory.GetBrowserSamplingProfileRequest GetBrowserSamplingProfile()    
    {
      return new ChromeProtocol.Domains.Memory.GetBrowserSamplingProfileRequest();
    }
    /// <summary>
    /// Retrieve native memory allocations profile<br/>
    /// collected since browser process startup.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("Memory.getBrowserSamplingProfile")]
    public record GetBrowserSamplingProfileRequest() : ChromeProtocol.Core.ICommand<GetBrowserSamplingProfileRequestResult>
    {
    }
    public record GetBrowserSamplingProfileRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("profile")]
      ChromeProtocol.Domains.Memory.SamplingProfileType Profile
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Retrieve native memory allocations profile collected since last<br/>
    /// `startSampling` call.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.Memory.GetSamplingProfileRequest GetSamplingProfile()    
    {
      return new ChromeProtocol.Domains.Memory.GetSamplingProfileRequest();
    }
    /// <summary>
    /// Retrieve native memory allocations profile collected since last<br/>
    /// `startSampling` call.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("Memory.getSamplingProfile")]
    public record GetSamplingProfileRequest() : ChromeProtocol.Core.ICommand<GetSamplingProfileRequestResult>
    {
    }
    public record GetSamplingProfileRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("profile")]
      ChromeProtocol.Domains.Memory.SamplingProfileType Profile
    ) : ChromeProtocol.Core.IType
    {
    }
  }
}
