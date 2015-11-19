UPDATE `f_user24`.`ShipInfo` 
SET `Ship_Class`= substr(`Ship_Class`, 2)
WHERE `Ship_Class` like '\n%'