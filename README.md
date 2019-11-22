# SignalrWebNotificationClient

A .NET 3.0 SignalR hub and WebAPI for broadcasting messages to all listening clients.

## SignalR Client

To test with a client that connects to this hub check out my Angular application here:
https://github.com/chrisfaria/signalr-web-notification-client

## Run Instructions
Use Postman to hit the API and broadcast a notification:

Steps:

- open Postman (https://www.getpostman.com/)
- setup a POST message
- add the address http://localhost:51000/api/notify
- set a header Key: **Content-Type** & Value: **application/json**
- include a body with the following format: **{"type": "success",	"message": "Message to display"}**. *Note: The type on the message can be "success", "info", "warn", or "error"*


