#Async & Await in C#
When we are dealing with UI, and on button click, we use a long-running method like reading a large file or something else which will take a long time, in that case, the entire application must wait to complete the whole task. In other words, if any process is blocked in a synchronous application, the whole application gets blocked, and our application stops responding until the whole task completes.
Asynchronous programming is very helpful in this condition. By using Asynchronous programming, the Application can continue with the other work that does not depend on the completion of the entire task.
 
We will get all the benefits of traditional Asynchronous programming with much less effort with the help of async and await keywords.

The return type of Async method is :- void, Task, Task<t>
By using Async Keyword we can make our method Asynchronous.
