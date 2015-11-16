UPDATE `f_user24`.`ShipInfo` 
SET `Ship_Type`= substr(`Ship_Type`, 2)
WHERE `Ship_Type` like '\n%'