In C#, it is recommended to avoid using **async void** because it can lead to uncontrolable issues in asynchronous programming.

1. Inability to track or wait for completion
- With **async Task** you can use **await** to wait the method to complete or check its status. However, with **async void**, 
there is noway to wait or tracking when the method finishes.
- This is especially dangerous in applications need to guarantee the order of execution or handle errors, as you cannot actively determine when
the method has completed.

2. Inability to handle exceptions clearly
- When **async Task** throws an exception, you can catch and handle it by using a **try-catch** block. However, with **async void**, if an exception occurs, it is pushed directly to the thread's synchronization context (typically the UI thread or main thread), and there is noway to catch it directly from the caller.
- This can cause the application to crash or lead to unexpected behavior without clear notification

3. Inconsistent behavior with Synchronization Context
- **async void** typically is used in the event handlers because they don't require a return value and are designed to run asynchronously without waiting. However, if not handled carefully, it can lead to problems with the synchronization context, such as deadlock or thread failures
- While **async Task** allow you to better control the execution flow, **async void** fully depends on calling context, which can result in unpredictable behavior

4. Hard to debug and maintain
- Due to inability to wait for completion or handle errors effectively, debugging an **async void** method is more complicated. if an error occurs, you have to rely on the logging or indirectly methods to detect the problem.
- Code that uses **async void** is generally harder to read and maintain, especially in the large system.