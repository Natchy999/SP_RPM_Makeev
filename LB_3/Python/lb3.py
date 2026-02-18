import pandas as pd
pd.set_option('display.max_columns', None)
df = pd.read_excel("../Tablica999.xlsx", sheet_name= [0, 1], skiprows=2, header=0)

print(df[0])
print(df[1])