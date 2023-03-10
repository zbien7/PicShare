# PicShare 

'Picshare' 

Założenia projektu: 

- Możliwość założenia konta 

- Możliwość udostępniania zdjęć 

- Możliwość podgladu udostepnionych zdjęć 

- Możliwość usuwania wszystkich zdjęć z poziomu administratora

Aby uruchomić aplikacje trzeba zmienić : 

connectionString "PicShareDbContextConnection": "Server=<serwersql>;Database=MVCAuthDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  
 Migracja danych:  
  - add-migration 
  - update-database
