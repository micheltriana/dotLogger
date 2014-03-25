How to use dotLogger
=============

dotLogger is an extension of NLog, and meant to be simpler. All NLog documentation for the NLog.config file configuration are the same as NLog and can be found here (https://github.com/NLog/NLog/wiki/Configuration-file) 

dotLogger simplifies the process of logger initialization and use by having a singleton wrapper around NLog logger, allowing you to Log anything in 3 simple steps:

1. Install the nuget package named dotLogger.
2. Add using statements on the class where you wish to log text.
3. Call one of the 6 methods under the static Logger class (ErrorException, FatalException, Error, Debug, Warn, or Info) that matches your logging needs.

## Suggestions on when to use each method
NOTE: Note that all params Object[] parameters on each method input are optional params.
### ErrorException (Exception, String, params Object[])
Use to log HANDLED exceptions that indicate an error that needs operation review or correction, but is handled in a deterministic way by the application, ergo allowing the application to continue.
Examples:
- Missing files.
- Recoverable errors in a web page.

### FatalException (Exception, String, params Object[])
Same as ErrorException, but one can use this one for UNHANDLED exceptions.
Examples:
- In ASP.NET, we can use it in the Global.aspx error handler method to log catch-all unhandled exceptions.
- In WCF Data Services, we can use it in the HandleError override of the Service class.

### Error (String, params Object[])
Indicates a scenario where a normal operation cannot continue and needs review.

### Debug (String, params Object[])
Use for developer debugging and error detection during non-production deployments.

### Warn (String, params Object[])
Warning-type of messages usually indicating anomalies in the business logic of your application that should be reviewed.

### Info (String, params Object[])
Same as Debug, but used for production environments. Avoid logging PII or sensitive data, since the datasets are production.
