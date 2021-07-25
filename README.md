# APICovidData

This Service will fetch Summary numbers from the API `https://api.covid19api.com` on a schedule.

From 10 to 10 minutes the service will be consumed and the data contained in the response from API will be stored in a JSON File.

The project interface is contained in the repository `marcelopbg/covid-app`.

## Build the Container

docker build -f Dockerfile .. -t covid

## Run the Container

docker run -d -p 4660:80 --name myapp covid 

- if the port is changed, it must be updated in the json file `assets/api.json` in the frontend repository `marcelopbg/covid-app`


## Development Environment

It's also possible to run and debug the application in Visual Studio in that case the build and run steps won't be necessary, those will be executed by the Visual Studio IDE. 
