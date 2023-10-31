using System.Text;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace ChromeProtocol.Tests.Extensions.Logging;

public class XunitLogger : ILogger, IDisposable
{
  private ITestOutputHelper _output;
  private readonly string? _prefix;

  public XunitLogger(ITestOutputHelper output, string? prefix = null)
  {
    _output = output;
    _prefix = prefix;
  }

  public virtual void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception, string> formatter)
  {
    var builder = new StringBuilder();
    builder.Append($"{logLevel.ToString()} ");
    if (!string.IsNullOrEmpty(_prefix))
    {
      builder.Append(_prefix);
      builder.Append(": ");
    }
    builder.Append(state);
    if (exception != null)
    {
      builder.Append($", exception: {exception}");
    }
    _output.WriteLine(builder.ToString());
  }

  public bool IsEnabled(LogLevel logLevel)
  {
    return true;
  }

  public IDisposable BeginScope<TState>(TState state)
  {
    return this;
  }

  public void Dispose()
  {
  }
}
