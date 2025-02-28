
//Console.WriteLine($"Main thread ID: {Thread.CurrentThread.ManagedThreadId} - Starting");

//// Call asynchronous method
//Task longTask = DoSomethingAsync();

//// Main thread while waiting for await in DoSomethingAsync
//Console.WriteLine($"Main thread ID: {Thread.CurrentThread.ManagedThreadId} - Doing other work...");
//for (int i = 0; i < 3; i++)
//{
//    await Task.Delay(300); // Simulate the short task
//    Console.WriteLine($"Main thread ID: {Thread.CurrentThread.ManagedThreadId} - Work {i + 1}");
//}

//// Wait for longTask completion
////await longTask;
//Console.WriteLine($"Main thread ID: {Thread.CurrentThread.ManagedThreadId} - All done!");

//static async Task DoSomethingAsync()
//{
//    Console.WriteLine($"DoSomethingAsync thread ID: {Thread.CurrentThread.ManagedThreadId} - Starting long task");
//    await Task.Delay(2000); // Simulate a long task (2 second)
//    Console.WriteLine($"DoSomethingAsync thread ID: {Thread.CurrentThread.ManagedThreadId} - Long task finished");
//}

//Console.ReadLine();