import pandas as pd
import numpy as np
import json

df = pd.read_csv('CrimeDataset.csv')

#Convert to JSON 
result = df.to_json(orient="split")
parsed = json.loads(result)
json.dumps(parsed, indent=4)  

#Over here, figure out how to send JSON to openlayers so that we can automate building markers


#We will convert the csv to JSON

