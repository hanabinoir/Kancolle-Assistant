create table ShipInfo
(
	Ship_Name varchar(20), 
    Ship_No int(3), 
    Ship_Class varchar(20), 
    Ship_Type varchar(20)
);
/*select Ship_Name, Ship_No, Ship_Class, Ship_Type
from ShipStats;*/

alter table ShipInfo 
add constraint Ship_ID primary key (Ship_Name, Ship_No)