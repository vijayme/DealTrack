# DealTrack
A sample react App with asp.net core backend
Setup
1. Install latest docker desktop
2. Run this to start docker daemon
With Powershell:
	Open Powershell as administrator
	Launch command: & 'C:\Program Files\Docker\Docker\DockerCli.exe' -SwitchDaemon
Make sure docker is running. You can use "docker ps" to check.

3. Build API docker image using below command. Execute this command from DealTrackAPI folder
	docker build -t dealer_track_api .

4. run the image using below command
	docker run -p 9090:80 dealer_track_api

5. Run "docker build -t dealtrackui" command in DealTrackUI\my-app.

6. Run this command - "docker run -p 8060:3000 -t dealtrackui"

7. UI can now be accessed through http://localhost:8060/
