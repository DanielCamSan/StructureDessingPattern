**Problem:**
the main problem is that the flight process is subdivided into much smaller and independient processes and for that it was necessary to 
create many instances of that smaller process

**Solution**
To solve the main problem, i use the Structure dessign pattern Facade, where i can implement the smaller processes into a facade and work
with that smaller process individually and just return one thing when you call Facade and not create a lot of many processes that gives 
more returns