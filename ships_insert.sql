load data local infile "c:/temp/ships.txt" 
into table ShipStats
fields terminated by ', '
lines terminated by '\r\n';