create table Ships
(
	Ship_Name char(20),
    Ship_No int(3),
    HP char(10),
    Firepower char(10),
    Armor char(10),
    Torpedo char(10),
    Evasion char(10),
    AA char(10),
    Aircraft char(10),
    ASW char(10),
    Speed char(10),
    LOS char(10),
    Ship_Range char(10),
    Luck char(10), 
    constraint Ship_ID primary key (Ship_Name, Ship_No)
)