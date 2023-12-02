# soccerbot-remote
A proof of concept MQTT Remote control application. Send basic d-pad and velocity instructions for a motor controller queue.

## Running the Codespace
`dotnet restore`

`cd ./soccerbot-remote-server/`

`dotnet run`

Service is available by default at `http://localhost:5180/`

## Using the Controller

1. Enter your MQTT broker's URL
2. Enter your MQTT port
3. Click 'Connect'
<img width="1102" alt="Connect Tab" src="https://github.com/thompcd/soccerbot-remote/assets/20342605/57206730-ae05-47a2-8b10-ee93cb6d16d2">
4. Change to controller tab and begin issuing commands
<img width="1102" alt="Remote Control Tab" src="https://github.com/thompcd/soccerbot-remote/assets/20342605/52c522b7-2070-447f-951f-c039e2c4261d">
