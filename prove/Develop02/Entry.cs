


/*
Display method

The Entry class doesn't have too many behaviors. 
It's main responsibility is to hold data. And yet, because 
it is in charge of everything that has to do with entries, 
it would make sense for it to at least have it's own display method.
 Then, the Journal display method could iterate through all Entry objects and call the
  Entry display method. The Journal wouldn't have to worry about the details 
  of how the Entry was displayed, 
this would all be contained within the Entry class.


What are the key parts of an Entry? It should have a member variable for each of these.
*/