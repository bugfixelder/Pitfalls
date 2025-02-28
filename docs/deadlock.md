# Async/Await Deadlock demo application
## Overview
This application demonstrates a **deadlock** scenario in asynchronous programming (async/await)
when using Wait() or Result on the synchronization context (UI thread).

## Purpose
- Understand the cause of deadlocks when mixing synchronous and asynchronous programming incorrectly
- Learn the proper use of async/await in environemtns wih a synchronization context (e.g, UI thread)

## Technical notes
- Deadlock occurs: The UI thread is blocked by Wait() or Result, while the async method needs the UI thread
to complete (due to the synchronization context)
- Fix: Use await to return control to the UI thread's message loop instead of blocking it.