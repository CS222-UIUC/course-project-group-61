# course-project-group-61

Our project is called "Crime Mapping and Clustering", its purpose is to create a criminal map of Urbana-Champaign, IL. Users will be able to see a google maps style map that shows crimes reported by Urbana-Champaign police. When the 
API is started, a request is sent to our python backend to send the location data and criminal data for each crime on our data set. The backend then converts the
csv data of the criminal data into latitude and longitude coordinates using GeoPy along with the name of crime as a JSON file. This JSON file is then sent over to our front end where we use the OpenLayers API to convert the JSON data into tags on an interactive map of Urbana-Champaign, IL. A feature we planned to add when planning the project was an algorithm that used a predictive machine learning model to give the safest route between any two points in Urbana-Champaign. Unfortunately, this was over optimistic as we didn't have enough time to implement this feature. As for existing software, there are criminal maps of Champaign out there that shade in neighborhoods a certain color depending on their frequency of crime, however they don't show every individual crime on the map which makes our project unique. Another advantage that we have is we are using the most up to date information for our crime map due to having police data from this year that is accurate.



(Describes technical architecture)

C# -> Frontend part of application, provides effective and easy functionality for user to see map, while also allowing for an easy way to launch the openlayers and application overall.

Jupyter Notebook -> Essential for cleaning and correcting the dataset we received, prevented any unknown or stray data points from being displayed on the map, interacted with openlayers to give information for latitude, longitude, and address to markers in openlayers. Also talk about Geopy and how that was used to convert the mapping address into latitude and longitude.

Openlayers -> Backend mapping technology used to display markers where crime occurred with location and name, interacted with Jupyter Notebook to receive the necessary data and convert to JSON, interacted with C# to be integrated into the frontend and be launched easily. Added in opacity layering in order to show users where a higher concentration of crime is occurring so they have a better understanding of the area around them.


(Provides reproducible installation instructions)
Running Frontend with C#:

Running only Openlayers API:

- cd into map_api folder
- run npm install to get node_modules
- run npm start
- copy and past localhost url to view map

(Group members and their roles)

Aadarsh:
Shaarav: 
Krushank:
Michael:



