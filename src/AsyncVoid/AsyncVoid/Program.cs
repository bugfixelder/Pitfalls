
// Thiết lập SynchronizationContext giả lập như trong UI
SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());

Console.WriteLine($"Main thread ID: {Thread.CurrentThread.ManagedThreadId} - Starting");

TriggerAsyncAvoid();

// Chặn main thread để chờ (giả lập hành vi UI thread
