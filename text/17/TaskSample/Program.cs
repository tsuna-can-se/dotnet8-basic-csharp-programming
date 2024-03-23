using TaskSample;

await new MultipleAwait1().DoSomethingAsync();
Console.WriteLine("==========================");

await new MultipleAwait2().DoSomethingAsync();
Console.WriteLine("==========================");

await new MultipleAwait3().DoSomethingAsync();
Console.WriteLine("==========================");

await new TaskT1().DoSomethingAsync1();
Console.WriteLine("==========================");

await new TaskT1().DoSomethingAsync2();
Console.WriteLine("==========================");

new TaskT1().DoSomething();
Console.WriteLine("==========================");

new ForgetAwait().DoSomething();
Console.WriteLine("==========================");
