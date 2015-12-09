A simple example of a solution using hexagonal architecture in the form of domain, ports and adaptors (both primary and secondary). 

In collaboration with Daniel Portella.

Some articles explaining hexagonal architecture:
* My LateRooms blog post: (will be published on 14th December 2015)
* Alistair Cockburn: http://alistair.cockburn.us/Hexagonal+architecture
* Garfixia Software: http://www.dossier-andreas.net/software_architecture/ports_and_adapters.html

This is a Visual Studio .Net solution in C#. Hopefully the project structure is reasonably self-explanatory, as is the physical folder structure.



OK, here are some very rough notes that I made after consulting with my colleagues on how I could make the awesome Making Bacon Pancakes song (from Adventure Time) be a theme tune for this project...

git web hook calls an API that uses the Sonos API

Write a node js app that's a web page with a song that you visit, always open on your machine. Use js to start the youtube player to play once every time you checkin.
Heroku gives you free web dinos that run all the time.
AppHub does too.

Chrome plugin which runs all the time, uses a web socket to connect to a nodejs websocket server that would have also an express endpoint that would accept webhook events from guthub. 
When it receives an event, publish a message to the websocket which triggers the chrome plugin on your PC.

(Making bacon pancakes: https://www.youtube.com/watch?v=TrcT7sseLZI
...although I suspect this might be a doctored version of the original? Apart from anything else, I presume the original wasn't on a loop - or maybe it was?)
