using Ex15_01;

var formatter1 = (string message) => "[LOG] " + message;
var formatter2 = (string message) => message.ToUpper();

var message = "This is sample.";
ConsoleLogger.WriteLog(message, formatter1);
ConsoleLogger.WriteLog(message, formatter2);
