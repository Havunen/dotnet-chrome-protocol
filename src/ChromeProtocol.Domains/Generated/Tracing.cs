// <auto-generated />
#nullable enable

namespace ChromeProtocol.Domains
{
  public static partial class Tracing
  {
    /// <summary>Configuration for memory dump. Used only when &quot;memory-infra&quot; category is enabled.</summary>
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(ChromeProtocol.Core.ObjectTypeConverter))]
    public record MemoryDumpConfigType(
      System.Collections.Generic.IReadOnlyDictionary<System.String, System.Text.Json.Nodes.JsonNode?> Properties
    ) : ChromeProtocol.Core.IObjectType
    {
    }
    /// <param name="RecordMode">Controls how the trace buffer stores data.</param>
    /// <param name="TraceBufferSizeInKb">
    /// Size of the trace buffer in kilobytes. If not specified or zero is passed, a default value<br/>
    /// of 200 MB would be used.<br/>
    /// </param>
    /// <param name="EnableSampling">Turns on JavaScript stack sampling.</param>
    /// <param name="EnableSystrace">Turns on system tracing.</param>
    /// <param name="EnableArgumentFilter">Turns on argument filter.</param>
    /// <param name="IncludedCategories">Included category filters.</param>
    /// <param name="ExcludedCategories">Excluded category filters.</param>
    /// <param name="SyntheticDelays">Configuration to synthesize the delays in tracing.</param>
    /// <param name="MemoryDumpConfig">Configuration for memory dump triggers. Used only when &quot;memory-infra&quot; category is enabled.</param>
    public record TraceConfigType(
      [property: System.Text.Json.Serialization.JsonPropertyName("recordMode")]
      string? RecordMode = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("traceBufferSizeInKb")]
      double? TraceBufferSizeInKb = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("enableSampling")]
      bool? EnableSampling = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("enableSystrace")]
      bool? EnableSystrace = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("enableArgumentFilter")]
      bool? EnableArgumentFilter = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("includedCategories")]
      System.Collections.Generic.IReadOnlyList<string>? IncludedCategories = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("excludedCategories")]
      System.Collections.Generic.IReadOnlyList<string>? ExcludedCategories = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("syntheticDelays")]
      System.Collections.Generic.IReadOnlyList<string>? SyntheticDelays = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("memoryDumpConfig")]
      ChromeProtocol.Domains.Tracing.MemoryDumpConfigType? MemoryDumpConfig = default
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Data format of a trace. Can be either the legacy JSON format or the<br/>
    /// protocol buffer format. Note that the JSON format will be deprecated soon.<br/>
    /// </summary>
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record StreamFormatType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <summary>Compression type to use for traces returned via streams.</summary>
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record StreamCompressionType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <summary>
    /// Details exposed when memory request explicitly declared.<br/>
    /// Keep consistent with memory_dump_request_args.h and<br/>
    /// memory_instrumentation.mojom<br/>
    /// </summary>
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record MemoryDumpLevelOfDetailType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <summary>
    /// Backend type to use for tracing. `chrome` uses the Chrome-integrated<br/>
    /// tracing service and is supported on all platforms. `system` is only<br/>
    /// supported on Chrome OS and uses the Perfetto system tracing service.<br/>
    /// `auto` chooses `system` when the perfettoConfig provided to Tracing.start<br/>
    /// specifies at least one non-Chrome data source; otherwise uses `chrome`.<br/>
    /// </summary>
    [System.Text.Json.Serialization.JsonConverterAttribute(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record TracingBackendType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <param name="PercentFull">
    /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its<br/>
    /// total size.<br/>
    /// </param>
    /// <param name="EventCount">An approximate number of events in the trace log.</param>
    /// <param name="Value">
    /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its<br/>
    /// total size.<br/>
    /// </param>
    [ChromeProtocol.Core.MethodName("Tracing.bufferUsage")]
    public record BufferUsage(
      [property: System.Text.Json.Serialization.JsonPropertyName("percentFull")]
      double? PercentFull = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("eventCount")]
      double? EventCount = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("value")]
      double? Value = default
    ) : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>
    /// Contains a bucket of collected trace events. When tracing is stopped collected events will be<br/>
    /// sent as a sequence of dataCollected events followed by tracingComplete event.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("Tracing.dataCollected")]
    public record DataCollected(
      [property: System.Text.Json.Serialization.JsonPropertyName("value")]
      System.Collections.Generic.IReadOnlyList<System.Text.Json.Nodes.JsonObject> Value
    ) : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>
    /// Signals that tracing is stopped and there is no trace buffers pending flush, all data were<br/>
    /// delivered via dataCollected events.<br/>
    /// </summary>
    /// <param name="DataLossOccurred">
    /// Indicates whether some trace data is known to have been lost, e.g. because the trace ring<br/>
    /// buffer wrapped around.<br/>
    /// </param>
    /// <param name="Stream">A handle of the stream that holds resulting trace data.</param>
    /// <param name="TraceFormat">Trace data format of returned stream.</param>
    /// <param name="StreamCompression">Compression format of returned stream.</param>
    [ChromeProtocol.Core.MethodName("Tracing.tracingComplete")]
    public record TracingComplete(
      [property: System.Text.Json.Serialization.JsonPropertyName("dataLossOccurred")]
      bool DataLossOccurred,
      [property: System.Text.Json.Serialization.JsonPropertyName("stream")]
      ChromeProtocol.Domains.IO.StreamHandleType? Stream = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("traceFormat")]
      ChromeProtocol.Domains.Tracing.StreamFormatType? TraceFormat = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("streamCompression")]
      ChromeProtocol.Domains.Tracing.StreamCompressionType? StreamCompression = default
    ) : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>Stop trace events collection.</summary>
    public static ChromeProtocol.Domains.Tracing.EndRequest End()    
    {
      return new ChromeProtocol.Domains.Tracing.EndRequest();
    }
    /// <summary>Stop trace events collection.</summary>
    [ChromeProtocol.Core.MethodName("Tracing.end")]
    public record EndRequest() : ChromeProtocol.Core.ICommand<EndRequestResult>
    {
    }
    public record EndRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Gets supported tracing categories.</summary>
    public static ChromeProtocol.Domains.Tracing.GetCategoriesRequest GetCategories()    
    {
      return new ChromeProtocol.Domains.Tracing.GetCategoriesRequest();
    }
    /// <summary>Gets supported tracing categories.</summary>
    [ChromeProtocol.Core.MethodName("Tracing.getCategories")]
    public record GetCategoriesRequest() : ChromeProtocol.Core.ICommand<GetCategoriesRequestResult>
    {
    }
    /// <param name="Categories">A list of supported tracing categories.</param>
    public record GetCategoriesRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("categories")]
      System.Collections.Generic.IReadOnlyList<string> Categories
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Record a clock sync marker in the trace.</summary>
    /// <param name="SyncId">The ID of this clock sync marker</param>
    public static ChromeProtocol.Domains.Tracing.RecordClockSyncMarkerRequest RecordClockSyncMarker(string SyncId)    
    {
      return new ChromeProtocol.Domains.Tracing.RecordClockSyncMarkerRequest(SyncId);
    }
    /// <summary>Record a clock sync marker in the trace.</summary>
    /// <param name="SyncId">The ID of this clock sync marker</param>
    [ChromeProtocol.Core.MethodName("Tracing.recordClockSyncMarker")]
    public record RecordClockSyncMarkerRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("syncId")]
      string SyncId
    ) : ChromeProtocol.Core.ICommand<RecordClockSyncMarkerRequestResult>
    {
    }
    public record RecordClockSyncMarkerRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Request a global memory dump.</summary>
    /// <param name="Deterministic">Enables more deterministic results by forcing garbage collection</param>
    /// <param name="LevelOfDetail">Specifies level of details in memory dump. Defaults to &quot;detailed&quot;.</param>
    public static ChromeProtocol.Domains.Tracing.RequestMemoryDumpRequest RequestMemoryDump(bool? Deterministic = default, ChromeProtocol.Domains.Tracing.MemoryDumpLevelOfDetailType? LevelOfDetail = default)    
    {
      return new ChromeProtocol.Domains.Tracing.RequestMemoryDumpRequest(Deterministic, LevelOfDetail);
    }
    /// <summary>Request a global memory dump.</summary>
    /// <param name="Deterministic">Enables more deterministic results by forcing garbage collection</param>
    /// <param name="LevelOfDetail">Specifies level of details in memory dump. Defaults to &quot;detailed&quot;.</param>
    [ChromeProtocol.Core.MethodName("Tracing.requestMemoryDump")]
    public record RequestMemoryDumpRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("deterministic")]
      bool? Deterministic = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("levelOfDetail")]
      ChromeProtocol.Domains.Tracing.MemoryDumpLevelOfDetailType? LevelOfDetail = default
    ) : ChromeProtocol.Core.ICommand<RequestMemoryDumpRequestResult>
    {
    }
    /// <param name="DumpGuid">GUID of the resulting global memory dump.</param>
    /// <param name="Success">True iff the global memory dump succeeded.</param>
    public record RequestMemoryDumpRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("dumpGuid")]
      string DumpGuid,
      [property: System.Text.Json.Serialization.JsonPropertyName("success")]
      bool Success
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Start trace events collection.</summary>
    /// <param name="Categories">Category/tag filter</param>
    /// <param name="Options">Tracing options</param>
    /// <param name="BufferUsageReportingInterval">If set, the agent will issue bufferUsage events at this interval, specified in milliseconds</param>
    /// <param name="TransferMode">
    /// Whether to report trace events as series of dataCollected events or to save trace to a<br/>
    /// stream (defaults to `ReportEvents`).<br/>
    /// </param>
    /// <param name="StreamFormat">
    /// Trace data format to use. This only applies when using `ReturnAsStream`<br/>
    /// transfer mode (defaults to `json`).<br/>
    /// </param>
    /// <param name="StreamCompression">
    /// Compression format to use. This only applies when using `ReturnAsStream`<br/>
    /// transfer mode (defaults to `none`)<br/>
    /// </param>
    /// <param name="PerfettoConfig">
    /// Base64-encoded serialized perfetto.protos.TraceConfig protobuf message<br/>
    /// When specified, the parameters `categories`, `options`, `traceConfig`<br/>
    /// are ignored. (Encoded as a base64 string when passed over JSON)<br/>
    /// </param>
    /// <param name="TracingBackend">Backend type (defaults to `auto`)</param>
    public static ChromeProtocol.Domains.Tracing.StartRequest Start(string? Categories = default, string? Options = default, double? BufferUsageReportingInterval = default, string? TransferMode = default, ChromeProtocol.Domains.Tracing.StreamFormatType? StreamFormat = default, ChromeProtocol.Domains.Tracing.StreamCompressionType? StreamCompression = default, ChromeProtocol.Domains.Tracing.TraceConfigType? TraceConfig = default, string? PerfettoConfig = default, ChromeProtocol.Domains.Tracing.TracingBackendType? TracingBackend = default)    
    {
      return new ChromeProtocol.Domains.Tracing.StartRequest(Categories, Options, BufferUsageReportingInterval, TransferMode, StreamFormat, StreamCompression, TraceConfig, PerfettoConfig, TracingBackend);
    }
    /// <summary>Start trace events collection.</summary>
    /// <param name="Categories">Category/tag filter</param>
    /// <param name="Options">Tracing options</param>
    /// <param name="BufferUsageReportingInterval">If set, the agent will issue bufferUsage events at this interval, specified in milliseconds</param>
    /// <param name="TransferMode">
    /// Whether to report trace events as series of dataCollected events or to save trace to a<br/>
    /// stream (defaults to `ReportEvents`).<br/>
    /// </param>
    /// <param name="StreamFormat">
    /// Trace data format to use. This only applies when using `ReturnAsStream`<br/>
    /// transfer mode (defaults to `json`).<br/>
    /// </param>
    /// <param name="StreamCompression">
    /// Compression format to use. This only applies when using `ReturnAsStream`<br/>
    /// transfer mode (defaults to `none`)<br/>
    /// </param>
    /// <param name="PerfettoConfig">
    /// Base64-encoded serialized perfetto.protos.TraceConfig protobuf message<br/>
    /// When specified, the parameters `categories`, `options`, `traceConfig`<br/>
    /// are ignored. (Encoded as a base64 string when passed over JSON)<br/>
    /// </param>
    /// <param name="TracingBackend">Backend type (defaults to `auto`)</param>
    [ChromeProtocol.Core.MethodName("Tracing.start")]
    public record StartRequest(
      [property: System.Obsolete("This property marked as deprecated in the corresponding CDP definition schema. It may be removed in the future releases.", false)]
      [property: System.Text.Json.Serialization.JsonPropertyName("categories")]
      string? Categories = default,
      [property: System.Obsolete("This property marked as deprecated in the corresponding CDP definition schema. It may be removed in the future releases.", false)]
      [property: System.Text.Json.Serialization.JsonPropertyName("options")]
      string? Options = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("bufferUsageReportingInterval")]
      double? BufferUsageReportingInterval = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("transferMode")]
      string? TransferMode = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("streamFormat")]
      ChromeProtocol.Domains.Tracing.StreamFormatType? StreamFormat = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("streamCompression")]
      ChromeProtocol.Domains.Tracing.StreamCompressionType? StreamCompression = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("traceConfig")]
      ChromeProtocol.Domains.Tracing.TraceConfigType? TraceConfig = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("perfettoConfig")]
      string? PerfettoConfig = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("tracingBackend")]
      ChromeProtocol.Domains.Tracing.TracingBackendType? TracingBackend = default
    ) : ChromeProtocol.Core.ICommand<StartRequestResult>
    {
    }
    public record StartRequestResult() : ChromeProtocol.Core.IType
    {
    }
  }
}
