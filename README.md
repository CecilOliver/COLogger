# CO Logger (Cecil Oliver's Logger)

### How to install:
1. Download `COLogger.dll`
2. Reference `COLogger.dll` to your project
---
### How to use:
##### `Logger.Log(object message)` - Logs a message using the default `LogType` "Log".
##### `Logger.Log(object message, LogType logType)` - Logs a message using the specified `LogType`.
---
### Log types:
- `LogType.Log`:
	-  Writes the message to the console in white using the prefix `[LOG]`
- `LogType.Warning`:
	-  Writes the message to the console in dark yellow using the prefix `[WARNING]`
- `LogType.Error`:
	-  Writes the message to the console in red using the prefix `[ERROR]`
- `LogType.FatalError`:
	-  Writes the message to the console in dark red using the prefix `[FATAL ERROR]`. This also throws a new `Exception` using the message as the `Exception.Message`.