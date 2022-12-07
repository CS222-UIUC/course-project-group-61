# course-project-group-61

Our project is called "Crime Mapping and Clustering", its purpose is to create a criminal map of Urbana-Champaign, IL. Users will be able to see a google maps style map that shows crimes reported by Urbana-Champaign police. When the 
API is started, a request is sent to our python backend to send the location data and criminal data for each crime on our data set. The backend then converts the
csv data of the criminal data into latitude and longitude coordinates using GeoPy along with the name of crime as a JSON file. This JSON file is then sent over to our front end where we use the OpenLayers API to convert the JSON data into tags on an interactive map of Urbana-Champaign, IL. A feature we planned to add when planning the project was an algorithm that used a predictive machine learning model to give the safest route between any two points in Urbana-Champaign. Unfortunately, this was over optimistic as we didn't have enough time to implement this feature. As for existing software, there are criminal maps of Champaign out there that shade in neighborhoods a certain color depending on their frequency of crime, however they don't show every individual crime on the map which makes our project unique. Another advantage that we have is we are using the most up to date information for our crime map due to having police data from this year that is accurate.



Technical architecture:

C# -> Frontend part of application, provides effective and easy functionality for user to see map, while also allowing for an easy way to launch the openlayers and application overall.

Jupyter Notebook -> Essential for cleaning and correcting the dataset we received, prevented any unknown or stray data points from being displayed on the map, interacted with openlayers to give information for latitude, longitude, and address to markers in openlayers. Also talk about Geopy and how that was used to convert the mapping address into latitude and longitude.

Openlayers -> Backend mapping technology used to display markers where crime occurred with location and name, interacted with Jupyter Notebook to receive the necessary data and convert to JSON, interacted with C# to be integrated into the frontend and be launched easily. Added in opacity layering in order to show users where a higher concentration of crime is occurring so they have a better understanding of the area around them.


Reproducible installation instructions:

Running Frontend with C#:

The project contains a .exe file in the crimeMap subdirectory which is our final application. This exe launches the windows application and allows you to view all the crime data from openlayers. There is also a .msi file which acts as a custom installer.

Running only Openlayers API:

- cd into map_api folder
- run npm install to get node_modules
- run npm start
- copy and past localhost url to view map

Group members and their roles

Aadarsh: Worked on C# front end utilizing the .NET Framework in Visual Studio 2022. The frontend interacts with the Openlayers API and the internet to be able to pull recent crime data and to view all crime data in a single application. Also added in the ability to connect to Google Maps through our User Interface for convenient routing based on the safety of areas shown by our crime clustering.

Shaarav: Worked on the data preprocessing which included creating a heatmap, checking for the null values, and ensuring the dataset was accurate. Used Geopy to convert the given string mapping address into latitude and longitude coordinates, and wrote everything into a new csv to send to OpenLayers.


Krushank: Worked on the Openlayers API and integrated the dataset from Jupyter Notebook into Openlayers. Added in opacity layering in the Openlayers map API to show users where a higher concentration of crime is occurring so they have a better understanding of the area around them.

Michael: Worked in Jupyter Notebooks in Visual Studio to help clean the csv of any incomplete data points with Shaarav. Tried working in TensorFlow to create
a predictive ML model to predict where crime was going to happen next in Champaign-Urbana but this ended up taking too much time to complete.



