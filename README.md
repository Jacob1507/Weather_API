# Weather_API

## Project overeview
Project is based on API requests with allows to lookup in-time weather data. Data is stored in XML format.
All logic resposible for working with API requests is stored in API.cs class and only requires API key and city user is looking for.

If city form is not filled then processed and user will try to display data for whole week program will return error 400.
