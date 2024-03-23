using AbstractClassSample;

string message = "ログテキスト";

FlatTextConsoleLogger flatTextConsoleLogger = new FlatTextConsoleLogger();
flatTextConsoleLogger.WriteLog(message);

JsonConsoleLogger jsonConsoleLogger = new JsonConsoleLogger();
jsonConsoleLogger.WriteLog(message);
