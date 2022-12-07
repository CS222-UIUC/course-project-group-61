# course-project-group-61

Our project is called "Crime Mapping and Clustering", its purpose is to create a criminal map of Urbana-Champaign, IL. Users will be able to see a google maps style map that shows crimes reported by Urbana-Champaign police. When the 
API is started, a request is sent to our python backend to send the location data and criminal data for each crime on our data set. The backend then converts the
csv data of the criminal data into latitude and longitude coordinates using GeoPy along with the name of crime as a JSON file. This JSON file is then sent over to our front end where we use the OpenLayers API to covert the JSON data into tags on an interactive map of Urbana-Champaign, IL. A feauture we planned to add when planning the project was an algorithm that used a predictive machine learning model to give the safest route between any two points in Urbana-Champaign. Unfortunalty, this was over optimistic as we didn't have enough time to implement this feauture. As for existing software, there are criminal maps of Champaign out there that shade in neighborhoods a certain color depending on their frequency of crime, however they don't show every individual crime on the map which makes out project unique. Another advantage that we have is we are using the most up to date information for our crime map due to having police data from this year that is accurate.

(Describes technical architecture)

(Provides reproducible installation instructions)

(Group members and their roles)



