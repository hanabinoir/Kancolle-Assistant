-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 17, 2016 at 01:24 AM
-- Server version: 10.1.9-MariaDB
-- PHP Version: 5.5.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kancolle`
--

-- --------------------------------------------------------

--
-- Table structure for table `consumables`
--

CREATE TABLE `consumables` (
  `Item` char(45) NOT NULL,
  `Effect` varchar(255) DEFAULT NULL,
  `Price` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consumables`
--

INSERT INTO `consumables` (`Item`, `Effect`, `Price`) VALUES
('Dev_material_shop', 'Gives 7 development materials', '5'),
('Instant_construction_shop', 'Gives 5 instant construction', '3'),
('Instant_repair_shop', 'Gives 5 instant repair buckets', '3'),
('Special_order_furniture_shop', 'Gives 1 special order furniture', '3');

-- --------------------------------------------------------

--
-- Table structure for table `recipe`
--

CREATE TABLE `recipe` (
  `Fuel` int(11) DEFAULT NULL,
  `Ammunition` int(11) DEFAULT NULL,
  `Steel` int(11) DEFAULT NULL,
  `Bauxite` int(11) DEFAULT NULL,
  `Ship_Type` varchar(45) NOT NULL,
  `Rare` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `recipe`
--

INSERT INTO `recipe` (`Fuel`, `Ammunition`, `Steel`, `Bauxite`, `Ship_Type`, `Rare`) VALUES
(400, 100, 600, 30, 'Battleship', 1),
(30, 30, 30, 30, 'Destroyer', 0),
(250, 130, 200, 30, 'Destroyer', 1),
(270, 30, 330, 130, 'Heavy Cruiser', 0),
(30, 30, 30, 30, 'Light Cruiser', 0),
(250, 130, 200, 30, 'Light Cruiser', 1),
(300, 30, 400, 300, 'Standard Carrier', 0),
(300, 300, 600, 600, 'Standard Carrier', 1);

-- --------------------------------------------------------

--
-- Table structure for table `recommended`
--

CREATE TABLE `recommended` (
  `Item` char(45) NOT NULL,
  `Effect` varchar(255) DEFAULT NULL,
  `Price` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `recommended`
--

INSERT INTO `recommended` (`Item`, `Effect`, `Price`) VALUES
('Dock_extension_set', 'Gives 1 key', '10'),
('Repair_goddess_shop', 'Gives 1 Repair Goddess', '5'),
('Repair_member_shop', 'Gives 1 Repair Team', '2'),
('Resource_Bundle', 'Gives 880 of each resource', '9');

-- --------------------------------------------------------

--
-- Table structure for table `resources`
--

CREATE TABLE `resources` (
  `Item` char(45) NOT NULL,
  `Effect` varchar(255) DEFAULT NULL,
  `Price` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `resources`
--

INSERT INTO `resources` (`Item`, `Effect`, `Price`) VALUES
('Ammo_shop', 'Gives 2 ammo', '1'),
('Bauxite_shop', 'Gives 1 bauxite', '1'),
('Fuel_shop', 'Gives 2 fuel', '1'),
('Steel_shop', 'Gives 150 steel', '1');

-- --------------------------------------------------------

--
-- Table structure for table `shipinfo`
--

CREATE TABLE `shipinfo` (
  `Ship_Name` varchar(45) NOT NULL,
  `Ship_No` int(3) NOT NULL,
  `Ship_Type` varchar(45) DEFAULT NULL,
  `Ship_Class` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shipinfo`
--

INSERT INTO `shipinfo` (`Ship_Name`, `Ship_No`, `Ship_Type`, `Ship_Class`) VALUES
('Abukuma', 110, 'Light Cruiser', 'Nagara'),
('Agano', 137, 'Light Cruiser', 'Agano'),
('Akagi', 6, 'Standard Carrier', 'Akagi'),
('Akatsuki', 71, 'Destroyer', 'Akatsuki'),
('Akebono', 68, 'Destroyer', 'Ayayami'),
('Amagi', 202, 'Standard Carrier', 'Unryuu'),
('Aoba', 54, 'Heavy Cruiser', 'Aoba'),
('Arashio', 88, 'Destroyer', 'Asashio'),
('Ashigara', 57, 'Heavy Cruiser', 'Myoukou'),
('Atago', 60, 'Heavy Cruiser', 'Takao'),
('Ayanami', 17, 'Destroyer', 'Ayanami'),
('Bismarck', 171, 'Battleship', 'Bismarck'),
('Chikuma', 64, 'Heavy Cruiser', 'Tone'),
('Choukai', 62, 'Heavy Cruiser', 'Takao'),
('Fubuki', 11, 'Destroyer', 'Fubuki'),
('Fumizuki', 34, 'Destroyer', 'Mutsuki'),
('Furutaka', 52, 'Heavy Cruiser', 'Furutaka'),
('Fusou', 26, 'Battleship', 'Fusou'),
('Haguro', 58, 'Heavy Cruiser', 'Myoukou'),
('Haruna', 23, 'Battleship', 'Kongou'),
('Harusame', 81, 'Destroyer', 'Shiratsuyu'),
('Harusame', 205, 'Destroyer', 'Shiratsuyu'),
('Hatsuharu', 75, 'Destroyer', 'Hatsuharu'),
('Hatsushimo', 78, 'Destroyer', 'Hatsuharu'),
('Hatsuyuki', 13, 'Destroyer', 'Fubuki'),
('Hibiki', 72, 'Destroyer', 'Akatsuki'),
('Hiei', 22, 'Battleship', 'Kongou'),
('Hiryuu', 9, 'Standard Carrier', 'Hiryuu'),
('Hyuuga', 4, 'Battleship', 'Ise'),
('Ikazuchi', 73, 'Destroyer', 'Akatsuki'),
('Ise', 3, 'Battleship', 'Ise'),
('Isonami', 16, 'Destroyer', 'Fubuki'),
('Isuzu', 43, 'Light Cruiser', 'Nagara'),
('Jintsuu', 47, 'Light Cruiser', 'Sendai'),
('Kaga', 7, 'Standard Carrier', 'Kaga'),
('Kako', 53, 'Heavy Cruiser', 'Furutaka'),
('Katori', 154, 'Light Cruiser', 'Katori'),
('Katsuragi', 203, 'Standard Carrier', 'Unryuu'),
('Kikuzuki', 36, 'Destroyer', 'Mutsuki'),
('Kinu', 109, 'Light Cruiser', 'Nagara'),
('Kinugasa', 120, 'Heavy Cruiser', 'Aoba'),
('Kirishima', 24, 'Battleship', 'Kongou'),
('Kisaragi', 32, 'Destroyer', 'Mutsuki'),
('Kiso', 41, 'Light Cruiser', 'Kuma'),
('Kitakami', 20, 'Light Cruiser', 'Kuma'),
('Kongou', 21, 'Battleship', 'Kongou'),
('Kuma', 39, 'Light Cruiser', 'Kuma'),
('Kumano', 125, 'Heavy Cruiser', 'Mogami'),
('Littorio', 241, 'Battleship', 'Vittorio Veneto'),
('Maya', 61, 'Heavy Cruiser', 'Takao'),
('Mikazuki', 37, 'Destroyer', 'Mutsuki'),
('Mikuma', 116, 'Heavy Cruiser', 'Mogami'),
('Miyuki', 14, 'Destroyer', 'Fubuki'),
('Mochizuki', 38, 'Destroyer', 'Mutsuki'),
('Mogami', 51, 'Heavy Cruiser', 'Mogami'),
('Murakumo', 15, 'Destroyer', 'Fubuki'),
('Musashi', 143, 'Battleship', 'Yamato'),
('Mutsu', 2, 'Battleship', 'Nagato'),
('Mutsuki', 31, 'Destroyer', 'Mutsuki'),
('Myoukou', 55, 'Heavy Cruiser', 'Myoukou'),
('Nachi', 56, 'Heavy Cruiser', 'Myoukou'),
('Nagara', 42, 'Light Cruiser', 'Nagara'),
('Nagato', 1, 'Battleship', 'Nagato'),
('Nagatsuki', 35, 'Destroyer', 'Mutsuki'),
('Naka', 48, 'Light Cruiser', 'Sendai'),
('Natori', 44, 'Light Cruiser', 'Nagara'),
('Nenohi', 76, 'Destroyer', 'Hatsuharu'),
('Noshiro', 138, 'Light Cruiser', 'Agano'),
('Oboro', 67, 'Destroyer', 'Ayayami'),
('Ooi', 19, 'Light Cruiser', 'Kuma'),
('Ooshio', 86, 'Destroyer', 'Asashio'),
('Ooyodo', 183, 'Light Cruiser', 'Ooyodo'),
('Prinz Eugen', 76, 'Heavy Cruiser', 'Admiral Hipper'),
('Roma', 242, 'Battleship', 'Vittorio Veneto'),
('Sakawa', 140, 'Light Cruiser', 'Agano'),
('Samidare', 83, 'Destroyer', 'Shiratsuyu'),
('Satsuki', 33, 'Destroyer', 'Mutsuki'),
('Sazanami', 69, 'Destroyer', 'Ayayami'),
('Sendai', 46, 'Light Cruiser', 'Sendai'),
('Shigure', 80, 'Destroyer', 'Shiratsuyu'),
('Shikinami', 18, 'Destroyer', 'Ayanami'),
('Shiratsuyu', 79, 'Destroyer', 'Shiratsuyu'),
('Shirayuki', 12, 'Destroyer', 'Fubuki'),
('Shoukaku', 106, 'Standard Carrier', 'Shoukaku'),
('Souryuu', 8, 'Standard Carrier', 'Souryuu'),
('Suzuya', 124, 'Heavy Cruiser', 'Mogami'),
('Taihou', 153, 'Standard Carrier', 'Taihou'),
('Takao', 59, 'Heavy Cruiser', 'Takao'),
('Tama', 40, 'Light Cruiser', 'Kuma'),
('Tatsuta', 29, 'Light Cruiser', 'Tenryuu'),
('Tenryuu', 28, 'Light Cruiser', 'Tenryuu'),
('Tone', 63, 'Heavy Cruiser', 'Tone'),
('Unryuu', 201, 'Standard Carrier', 'Unryuu'),
('Ushio', 70, 'Destroyer', 'Ayayami'),
('Uzuki', 165, 'Destroyer', 'Mutsuki'),
('Wakaba', 77, 'Destroyer', 'Hatsuharu'),
('Yahagi', 139, 'Light Cruiser', 'Agano'),
('Yamashiro', 27, 'Battleship', 'Fusou'),
('Yamato', 131, 'Battleship', 'Yamato'),
('Yayoi', 164, 'Destroyer', 'Mutsuki'),
('Yura', 45, 'Light Cruiser', 'Nagara'),
('Yuubari', 111, 'Light Cruiser', 'Yuubari'),
('Yuudachi', 82, 'Destroyer', 'Shiratsuyu'),
('Zuikaku', 107, 'Standard Carrier', 'Shoukaku');

-- --------------------------------------------------------

--
-- Table structure for table `ships`
--

CREATE TABLE `ships` (
  `Ship_Name` char(45) NOT NULL DEFAULT '',
  `Ship_No` int(3) NOT NULL DEFAULT '0',
  `Ship_Class` char(45) DEFAULT NULL,
  `Ship_Type` char(45) DEFAULT NULL,
  `HP` char(45) DEFAULT NULL,
  `Firepower` char(45) DEFAULT NULL,
  `Armor` char(45) DEFAULT NULL,
  `Torpedo` char(45) DEFAULT NULL,
  `Evasion` char(45) DEFAULT NULL,
  `AA` char(45) DEFAULT NULL,
  `Aircraft` char(45) DEFAULT NULL,
  `ASW` char(45) DEFAULT NULL,
  `Speed` char(45) DEFAULT NULL,
  `LOS` char(45) DEFAULT NULL,
  `Ship_Range` char(45) DEFAULT NULL,
  `Luck` char(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ships`
--

INSERT INTO `ships` (`Ship_Name`, `Ship_No`, `Ship_Class`, `Ship_Type`, `HP`, `Firepower`, `Armor`, `Torpedo`, `Evasion`, `AA`, `Aircraft`, `ASW`, `Speed`, `LOS`, `Ship_Range`, `Luck`) VALUES
('Abukuma', 110, 'Nagara', 'Light Cruiser', '27', '14 (39)', '10 (29)', '24 (79)', '39 (69)', '13 (49)', '2', '(59)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Agano', 137, 'Agano', 'Light Cruiser', '30', '20 (42)', '17 (32)', '24 (72)', '37 (72)', '17 (60)', '6', '25 (70)', 'Fast', '12 (45)', 'Medium', '10 (49)'),
('Akagi', 6, 'Akagi', 'Standard Carrier', '69', '0 (39)', '28 (54)', '0', '28 (49)', '32 (69)', '73', '0', 'Fast', '44 (69)', 'Short', '12 (49)'),
('Akatsuki', 71, 'Akatsuki', 'Destroyer', '15', '10 (29)', '6 (19)', '27 (79)', '42 (89)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Akebono', 68, 'Ayayami', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Amagi', 202, 'Unryuu', 'Standard Carrier', '48', '0 (25)', '26 (51)', '0', '33 (59)', '27 (72)', '51', '0', 'Fast', '38 (74)', 'Short', '13 (59)'),
('Aoba', 54, 'Aoba', 'Heavy Cruiser', '37', '30 (54)', '26 (37)', '12 (59)', '33 (69)', '16 (59)', '6', '0', 'Fast', '10 (39)', 'Medium', '20 (69)'),
('Arashio', 88, 'Asashio', 'Destroyer', '16', '10 (29)', '6 (19)', '24 (79)', '43 (79)', '12 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Ashigara', 57, 'Myoukou', 'Heavy Cruiser', '44', '40 (54)', '32 (49)', '24 (49)', '34 (59)', '16 (54)', '6', '0', 'Fast', '12 (39)', 'Medium', '10 (49)'),
('Atago', 60, 'Takao', 'Heavy Cruiser', '45', '40 (54)', '35 (49)', '24 (59)', '35 (59)', '18 (56)', '6', '0', 'Fast', '13 (39)', 'Medium', '10 (49)'),
('Ayanami', 17, 'Ayanami', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (79)', '41 (89)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Bismarck', 171, 'Bismarck', 'Battleship', '90', '64 (88)', '67 (83)', '0', '33 (63)', '18 (48)', '16', '0', 'Fast', '16 (42)', 'Long', '8 (69)'),
('Chikuma', 64, 'Tone', 'Heavy Cruiser', '44', '32 (59)', '36 (59)', '24 (59)', '36 (69)', '20 (67)', '9', '0', 'Fast', '20 (59)', 'Medium', '10 (49)'),
('Choukai', 62, 'Takao', 'Cruiser', '45', '40 (54)', '35 (49)', '24 (49)', '35 (59)', '18 (56)', '6', '0', 'Fast', '13 (39)', 'Medium', '10 (49)'),
('Fubuki', 11, 'Fubuki', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (79)', '40 (89)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '17 (49)'),
('Fumizuki', 34, 'Mutsuki', 'Destroyer', '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Furutaka', 52, 'Furutaka', 'Heavy Cruiser', '36', '30 (54)', '25 (34)', '12 (59)', '33 (69)', '16 (59)', '6', '0', 'Fast', '10 (39)', 'Medium', '10 (49)'),
('Fusou', 26, 'Fusou', 'Battleship', '67', '74 (94)', '59 (79)', '0', '19 (39)', '23 (79)', '12', '0', 'Slow', '9 (33)', 'Long', '5 (39)'),
('Haguro', 58, 'Myoukou', 'Heavy Cruiser', '44', '40 (54)', '32 (49)', '24 (49)', '34 (59)', '16 (54)', '6', '0', 'Fast', '12 (39)', 'Medium', '10 (49)'),
('Haruna', 23, 'Kongou', 'Battleship', '63', '63 (89)', '52 (69)', '0', '30 (59)', '24 (69)', '9', '0', 'Fast', '13 (39)', 'Long', '15 (69)'),
('Harusame', 81, 'Shiratsuyu', 'Destroyer', '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Harusame', 205, 'Shiratsuyu', 'Destroyer', '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Hatsuharu', 75, 'Hatsuharu', 'Destroyer', '16', '10 (29)', '6 (19)', '27 (79)', '43 (89)', '12 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Hatsushimo', 78, 'Hatsuharu', 'Destroyer', '16', '10 (29)', '6 (19)', '27 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Hatsuyuki', 13, 'Fubuki', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Hibiki', 72, 'Akatsuki', 'Destroyer', '15', '10 (29)', '6 (19)', '27 (69)', '42 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Hiei', 22, 'Kongou', 'Battleship', '63', '63 (89)', '52 (69)', '0', '30 (59)', '24 (69)', '9', '0', 'Fast', '13 (39)', 'Long', '10 (49)'),
('Hiryuu', 9, 'Hiryuu', 'Standard Carrier', '50', '0 (29)', '27 (49)', '0', '37 (69)', '26 (69)', '64', '0', 'Fast', '42 (69)', 'Short', '35 (89)'),
('Hyuuga', 4, 'Ise', 'Battleship', '74', '74 (94)', '70 (89)', '0', '22 (49)', '28 (79)', '12', '0', 'Slow', '10 (36)', 'Long', '15 (69)'),
('Ikazuchi', 73, 'Akatsuki', 'Destroyer', '15', '10 (29)', '6 (19)', '27 (69)', '42 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Ise', 3, 'Ise', 'Battleship', '74', '74 (89)', '70 (89)', '0', '22 (49)', '28 (79)', '12', '0', 'Slow', '10 (36)', 'Long', '15 (69)'),
('Isonami', 16, 'Fubuki', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Isuzu', 43, 'Nagara', 'Light Cruiser', '26', '14 (39)', '10 (29)', '24 (79)', '37 (69)', '13 (49)', '2', '40 (79)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Jintsuu', 47, 'Sendai', 'Light Cruiser', '26', '14 (39)', '11 (29)', '24 (79)', '38 (69)', '13 (49)', '2', '20 (69)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Kaga', 7, 'Kaga', 'Standard Carrier', '71', '0 (39)', '29 (59)', '0', '27 (49)', '28 (69)', '93', '0', 'Fast', '40 (69)', 'Short', '10 (49)'),
('Kako', 53, 'Furutaka', 'Heavy Cruiser', '36', '30 (49)', '25 (34)', '12 (49)', '33 (59)', '16 (49)', '6', '0', 'Fast', '10 (39)', 'Medium', '10 (49)'),
('Katori', 154, 'Katori', 'Training Cruiser', '36', '14 (28)', '9 (27)', '12 (28)', '24 (49)', '14 (42)', '3', '12 (42)', 'Slow', '10 (38)', 'Medium', '10 (49)'),
('Katsuragi', 203, 'Unryuu', 'Standard Carrier', '48', '0 (25)', '27 (52)', '0', '34 (59)', '27 (72)', '51', '0', 'Fast', '36 (70)', 'Short', '20 (69)'),
('Kikuzuki', 36, 'Mutsuki', 'Destroyer', '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Kinu', 109, ' Nagara', 'Light Cruiser', '26', '14 (39)', '10 (29)', '24 (79)', '38 (69)', '13 (49)', '2', '20 (59)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Kinugasa', 120, 'Aoba', 'Heavy Cruiser', '37', '30 (54)', '26 (37)', '12 (59)', '33 (69)', '16 (59)', '6', '0', 'Fast', '11 (39)', 'Medium', '20 (69)'),
('Kirishima', 24, 'Kongou', 'Battleship', '63', '63 (89)', '52 (69)', '0', '30 (59)', '24 (69)', '9', '0', 'Fast', '13 (39)', 'Long', '10 (49)'),
('Kisaragi', 32, 'Mutsuki', 'Destroyer', '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Kiso', 41, 'Kuma', 'Light Cruiser', '25', '14 (39)', '10 (29)', '24 (79)', '36 (69)', '13 (49)', '2', '19 (59)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Kitakami', 20, 'Kuma', 'Light Cruiser', '25', '14 (39)', '10 (29)', '24 (79)', '37 (77)', '13 (49)', '0', '19 (59)', 'Fast', '8 (39)', 'Medium', '15 (69)'),
('Kongou', 21, 'Kongou', 'Battleship', '63', '63 (89)', '52 (69)', '0', '30 (59)', '24 (69)', '9', '0', 'Fast', '13 (39)', 'Long', '12 (49)'),
('Kuma', 39, 'Kuma', 'Light Cruiser', '25', '14 (49)', '10 (29)', '24 (89)', '36 (79)', '13 (59)', '2', '19 (59)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Kumano', 125, 'Mogami', 'Heavy Cruiser', '40', '40 (59)', '30 (59)', '18 (69)', '31 (62)', '18 (59)', '6', '0', 'Fast', '14 (39)', 'Medium', '5 (49)'),
('Littorio', 241, 'Vittorio Veneto', 'Battleship', '88', '78 (97)', '72 (86)', '0', '8 (54)', '40 (72)', '12', '0', 'Fast', '15 (44)', 'Very Long', '20 (69)'),
('Maya', 61, 'Takao', 'Heavy Cruiser', '45', '40 (54)', '35 (49)', '24 (49)', '35 (59)', '18 (56)', '6', '0', 'Fast', '13 (39)', 'Medium', '10 (49)'),
('Mikazuki', 37, 'Mutsuki', 'Destroyer', '13', '6 (29)', '(18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Mikuma', 116, 'Mogami', 'Heavy Cruiser', '40', '40 (59)', '30 (59)', '18 (69)', '31 (62)', '18 (59)', '6', '0', 'Fast', '14 (39)', 'Medium', '5 (49)'),
('Miyuki', 14, 'Fubuki', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Mochizuki', 38, 'Mutsuki', 'Destroyer', '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Mogami', 51, 'Mogami', 'Heavy Cruiser', '41', '40 (59)', '31 (59)', '18 (69)', '35 (69)', '20 (59)', '6', '0', 'Fast', '14 (39)', 'Medium', '10 (49)'),
('Murakumo', 15, 'Fubuki', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Musashi', 143, 'Yamato', 'Battleship', '94', '96 (129)', '88 (108)', '0', '27 (59)', '50 (94)', '28', '0', 'Slow', '15 (39)', 'Very Long', '10 (79)'),
('Mutsu', 2, 'Nagato', 'Battleship', '80', '82 (99)', '75 (89)', '0', '24 (49)', '31 (89)', '12', '0', 'Slow', '12 (39)', 'Long', '3 (39)'),
('Mutsuki', 31, 'Mutsuki', 'Destroyer', '13', '6 (29)', '5 (18)', '18 (59)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '12 (49)'),
('Myoukou', 55, 'Myoukou', 'Heavy Cruiser', '44', '40 (59)', '32 (49)', '24 (59)', '34 (69)', '16 (64)', '6', '0', 'Fast', '12 (39)', 'Medium', '10 (49)'),
('Nachi', 56, 'Myoukou', 'Heavy Cruiser', '44', '40 (54)', '32 (49)', '24 (49)', '34 (59)', '16 (54)', '6', '0', 'Fast', '12 (39)', 'Medium', '10 (49)'),
('Nagara', 42, 'Nagara', 'Light Cruiser', '26', '14 (49)', '10 (29)', '24 (89)', '37 (79)', '13 (59)', '2', '20 (59)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Nagato', 1, 'Nagato', 'Battleship', '80', '82 (99)', '75 (89)', '0', '24 (49)', '31 (89)', '12', '0', 'Slow', '12 (39)', 'Long', '20 (79)'),
('Nagatsuki', 35, 'Mutsuki', 'Destroyer', '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '15 (69)'),
('Naka', 48, 'Sendai', 'Light Cruiser', '26', '14 (39)', '11 (29)', '24 (79)', '38 (69)', '13 (49)', '2', '24 (69)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Natori', 44, 'Nagara', 'Light Cruiser', '26', ' 14 (39)', '10 (29)', '24 (79)', '37 (69)', '13 (49)', '2', '20 (59)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Nenohi', 76, 'Hatsuharu', 'Destroyer', '16', '10 (29)', '6 (19)', '27 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Noshiro', 138, 'Agano', 'Light Cruiser', '30', '20 (42)', '17 (32)', '24 (72)', '37 (72)', '17 (60)', '6', '25 (70)', 'Fast', '12 (45)', 'Medium', '10 (49)'),
('Oboro', 67, 'Ayayami', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Ooi', 19, 'Kuma', 'Light Cruiser', '25', '14 (49)', '11 (29)', '24 (89)', '37 (77)', '13 (59)', '0', '19 (59)', 'Fast', '8 (39)', 'Medium', '17 (49)'),
('Ooshio', 86, 'Asashio', 'Destroyer', '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Ooyodo', 183, 'Ooyodo', 'Light Cruiser', '34', '24 (48)', '19 (34)', '0 (39)', '35 (70)', '18 (62)', '12', '0 (39)', 'Fast', '24 (80)', 'Medium', '24 (69)'),
('Prinz Eugen', 76, 'Admiral Hipper', 'Heavy Cruiser', '50', '38 (56)', '38 (64)', '32 (64)', '34 (68)', '16 (44)', '9', '0', 'Fast', '15 (40)', 'Medium', '30 (79)'),
('Roma', 242, 'Vittorio Veneto', 'Battleship', '88', '79 (98)', '71 (85)', '0', '27 (52)', '44 (74)', '12', '0', 'Fast', '17 (46)', 'Very Long', '6 (39)'),
('Sakawa', 140, 'Agano', 'Light Cruiser', '31', '19 (41)', '17 (32)', '23 (71)', '36 (72)', '17 (62)', '6', '27 (72)', 'Fast', '12 (45)', 'Medium', '20 (49)'),
('Samidare', 83, 'Shiratsuyu', 'Destroyer', ' 16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Satsuki', 33, 'Mutsuki', 'Destroyer', '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Sazanami', 69, 'Ayayami', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Sendai', 46, 'Sendai', 'Light Cruiser', '26', '14 (49)', '11 (29)', '24 (89)', '38 (79)', '13 (59)', '2', '20 (69)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Shigure', 80, 'Shiratsuyu', 'Destroyer', '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Shikinami', 18, 'Ayanami', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Shiratsuyu', 79, 'Shiratsuyu', 'Destroyer', '16', '10 (29)', '6 (19)', '24 (79)', '43 (79)', '12 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Shirayuki', 12, 'Fubuki', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Shoukaku', 106, 'Shoukaku', 'Standard Carrier', '62', '0 (39)', '33 (49)', '0', '36 (59)', '29 (69)', '75', '0', 'Fast', '44 (69)', 'Short', '10 (49)'),
('Souryuu', 8, 'Souryuu', 'Standard Carrier', '50', '0 (29)', '27 (49)	', '0', '33 (59)', '26 (69)', '64', '0', 'Fast', '42 (69)', 'Short', '10 (49)'),
('Suzuya', 124, 'Mogami', 'Heavy Cruiser', '40', '40 (59)', '30 (59)', '18 (69)', '31 (62)', '18 (59)', '6', '0', 'Fast', '14 (39)', 'Medium', '5 (49)'),
('Taihou', 153, 'Taihou', 'Armored Carrier', '67', '0 (49)', '40 (79)', '0', '33 (57)', '42 (79)', '61', '0', 'Fast', '47 (74)', 'Short', '2 (19)'),
('Takao', 59, 'Takao', 'Heavy Cruiser', '45', '40 (59)', '35 (49)', '24 (59)', '35 (69)', '18 (66)', '6', '0', 'Fast', '13 (39)', 'Medium', '10 (49)'),
('Tama', 40, 'Kuma', ' Light Cruiser', '25', '14 (39)', '10 (29)', '24 (79)', '36 (69)', '13 (49)', '2', '19 (59)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Tatsuta', 29, 'Tenryuu', 'Light Cruiser', '23', '11 (39)', '7 (29)', '18 (59)', '35 (69)', '8 (39)', '0', '18 (59)', 'Fast', '7 (19)', 'Medium', '17 (49)'),
('Tenryuu', 28, 'Tenryuu', 'Light Cruiser', '23', '11 (39)', '7 (29)', '18 (59)', '35 (69)', '8 (39)', '0', '18 (59)', 'Fast', '7 (19)', 'Medium', '17 (49)'),
('Tone', 63, 'Tone', 'Heavy Cruiser', '44', '32 (59)', '36 (59)', '24 (59)', '36 (69)', '20 (67)', '9', '0', 'Fast', '20 (59)', 'Medium', '10 (49)'),
('Unryuu', 201, 'Unryuu', 'Standard Carrier', '48', '0 (27)', '26 (52)', '0', '32 (59)', '28 (72)', '51', '0', 'Fast', '40 (72)', 'Short', '10 (49)'),
('Ushio', 70, 'Ayayami', 'Destroyer', '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '20 (79)'),
('Uzuki', 165, 'Mutsuki', 'Destroyer', '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Wakaba', 77, 'Hatsuharu', 'Destroyer', '16', '10 (29)', '6 (19)', '27 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Yahagi', 139, 'Agano', 'Light Cruiser', '31', '20 (42)', '17 (33)', '24 (72)', '38 (72)', '17 (63)', '6', '25 (70)', 'Fast', '13 (45)', 'Medium', '13 (59)'),
('Yamashiro', 27, 'Fusou', 'Battleship', '67', '74 (94)', '59 (79)', '0', '19 (39)', '23 (79)', '12', '0', 'Slow', '9 (33)', 'Long', '5 (39)'),
('Yamato', 131, 'Yamato', 'Battleship', '93', '96 (129)', '88 (108)', '0', '27 (59)', '50 (94)', '28', '0', 'Slow', '15 (39)', 'Very Long', '12 (79)'),
('Yayoi', 164, 'Mutsuki', 'Destroyer', '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Yura', 45, 'Nagara', 'Light Cruiser', ' 26', '14 (39)', '10 (29)', '24 (79)', '37 (69)', '13 (49)', '2', '40 (59)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Yuubari', 111, 'Yuubari', 'Light Cruiser', '19', '17 (42)', '10 (29)', '20 (69)', '42 (69)', '10 (42)', '0', '13 (39)', 'Fast', '6 (39)', 'Medium', '12 (49)'),
('Yuudachi', 82, 'Shiratsuyu', 'Destroyer', '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Zuikaku', 107, 'Shoukaku', 'Standard Carrier', '62', '0 (39)', '33 (49)', '0', '39 (69)', '29 (69)', '75', '0', 'Fast', '44 (69)', 'Short', '40 (89)');

-- --------------------------------------------------------

--
-- Table structure for table `shipstats`
--

CREATE TABLE `shipstats` (
  `Ship_Name` char(20) NOT NULL DEFAULT '',
  `Ship_No` int(3) NOT NULL DEFAULT '0',
  `HP` char(10) DEFAULT NULL,
  `Firepower` char(10) DEFAULT NULL,
  `Armor` char(10) DEFAULT NULL,
  `Torpedo` char(10) DEFAULT NULL,
  `Evasion` char(10) DEFAULT NULL,
  `AA` char(10) DEFAULT NULL,
  `Aircraft` char(10) DEFAULT NULL,
  `ASW` char(10) DEFAULT NULL,
  `Speed` char(10) DEFAULT NULL,
  `LOS` char(10) DEFAULT NULL,
  `Ship_Range` char(10) DEFAULT NULL,
  `Luck` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shipstats`
--

INSERT INTO `shipstats` (`Ship_Name`, `Ship_No`, `HP`, `Firepower`, `Armor`, `Torpedo`, `Evasion`, `AA`, `Aircraft`, `ASW`, `Speed`, `LOS`, `Ship_Range`, `Luck`) VALUES
('Abukuma', 110, '27', '14 (39)', '10 (29)', '24 (79)', '39 (69)', '13 (49)', '2', '(59)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Agano', 137, '30', '20 (42)', '17 (32)', '24 (72)', '37 (72)', '17 (60)', '6', '25 (70)', 'Fast', '12 (45)', 'Medium', '10 (49)'),
('Akagi', 6, '69', '0 (39)', '28 (54)', '0', '28 (49)', '32 (69)', '73', '0', 'Fast', '44 (69)', 'Short', '12 (49)'),
('Akatsuki', 71, '15', '10 (29)', '6 (19)', '27 (79)', '42 (89)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Akebono', 68, '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Amagi', 202, '48', '0 (25)', '26 (51)', '0', '33 (59)', '27 (72)', '51', '0', 'Fast', '38 (74)', 'Short', '13 (59)'),
('Aoba', 54, '37', '30 (54)', '26 (37)', '12 (59)', '33 (69)', '16 (59)', '6', '0', 'Fast', '10 (39)', 'Medium', '20 (69)'),
('Arashio', 88, '16', '10 (29)', '6 (19)', '24 (79)', '43 (79)', '12 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Ashigara', 57, '44', '40 (54)', '32 (49)', '24 (49)', '34 (59)', '16 (54)', '6', '0', 'Fast', '12 (39)', 'Medium', '10 (49)'),
('Atago', 60, '45', '40 (54)', '35 (49)', '24 (59)', '35 (59)', '18 (56)', '6', '0', 'Fast', '13 (39)', 'Medium', '10 (49)'),
('Ayanami', 17, '15', '10 (29)', '5 (19)', '27 (79)', '41 (89)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Bismarck', 171, '90', '64 (88)', '67 (83)', '0', '33 (63)', '18 (48)', '16', '0', 'Fast', '16 (42)', 'Long', '8 (69)'),
('Chikuma', 64, '44', '32 (59)', '36 (59)', '24 (59)', '36 (69)', '20 (67)', '9', '0', 'Fast', '20 (59)', 'Medium', '10 (49)'),
('Choukai', 62, '45', '40 (54)', '35 (49)', '24 (49)', '35 (59)', '18 (56)', '6', '0', 'Fast', '13 (39)', 'Medium', '10 (49)'),
('Fubuki', 11, '15', '10 (29)', '5 (19)', '27 (79)', '40 (89)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '17 (49)'),
('Fumizuki', 34, '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Furutaka', 52, '36', '30 (54)', '25 (34)', '12 (59)', '33 (69)', '16 (59)', '6', '0', 'Fast', '10 (39)', 'Medium', '10 (49)'),
('Fusou', 26, '67', '74 (94)', '59 (79)', '0', '19 (39)', '23 (79)', '12', '0', 'Slow', '9 (33)', 'Long', '5 (39)'),
('Haguro', 58, '44', '40 (54)', '32 (49)', '24 (49)', '34 (59)', '16 (54)', '6', '0', 'Fast', '12 (39)', 'Medium', '10 (49)'),
('Haruna', 23, '63', '63 (89)', '52 (69)', '0', '30 (59)', '24 (69)', '9', '0', 'Fast', '13 (39)', 'Long', '15 (69)'),
('Harusame', 81, '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Harusame', 205, '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Hatsuharu', 75, '16', '10 (29)', '6 (19)', '27 (79)', '43 (89)', '12 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Hatsushimo', 78, '16', '10 (29)', '6 (19)', '27 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Hatsuyuki', 13, '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Hibiki', 72, '15', '10 (29)', '6 (19)', '27 (69)', '42 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Hiei', 22, '63', '63 (89)', '52 (69)', '0', '30 (59)', '24 (69)', '9', '0', 'Fast', '13 (39)', 'Long', '10 (49)'),
('Hiryuu', 9, '50', '0 (29)', '27 (49)', '0', '37 (69)', '26 (69)', '64', '0', 'Fast', '42 (69)', 'Short', '35 (89)'),
('Hyuuga', 4, '74', '74 (94)', '70 (89)', '0', '22 (49)', '28 (79)', '12', '0', 'Slow', '10 (36)', 'Long', '15 (69)'),
('Ikazuchi', 73, '15', '10 (29)', '6 (19)', '27 (69)', '42 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Ise', 3, '74', '74 (89)', '70 (89)', '0', '22 (49)', '28 (79)', '12', '0', 'Slow', '10 (36)', 'Long', '15 (69)'),
('Isonami', 16, '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Isuzu', 43, '26', '14 (39)', '10 (29)', '24 (79)', '37 (69)', '13 (49)', '2', '40 (79)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Jintsuu', 47, '26', '14 (39)', '11 (29)', '24 (79)', '38 (69)', '13 (49)', '2', '20 (69)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Kaga', 7, '71', '0 (39)', '29 (59)', '0', '27 (49)', '28 (69)', '93', '0', 'Fast', '40 (69)', 'Short', '10 (49)'),
('Kako', 53, '36', '30 (49)', '25 (34)', '12 (49)', '33 (59)', '16 (49)', '6', '0', 'Fast', '10 (39)', 'Medium', '10 (49)'),
('Katori', 154, '36', '14 (28)', '9 (27)', '12 (28)', '24 (49)', '14 (42)', '3', '12 (42)', 'Slow', '10 (38)', 'Medium', '10 (49)'),
('Katsuragi', 203, '48', '0 (25)', '27 (52)', '0', '34 (59)', '27 (72)', '51', '0', 'Fast', '36 (70)', 'Short', '20 (69)'),
('Kikuzuki', 36, '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Kinu', 109, '26', '14 (39)', '10 (29)', '24 (79)', '38 (69)', '13 (49)', '2', '20 (59)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Kinugasa', 120, '37', '30 (54)', '26 (37)', '12 (59)', '33 (69)', '16 (59)', '6', '0', 'Fast', '11 (39)', 'Medium', '20 (69)'),
('Kirishima', 24, '63', '63 (89)', '52 (69)', '0', '30 (59)', '24 (69)', '9', '0', 'Fast', '13 (39)', 'Long', '10 (49)'),
('Kisaragi', 32, '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Kiso', 41, '25', '14 (39)', '10 (29)', '24 (79)', '36 (69)', '13 (49)', '2', '19 (59)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Kitakami', 20, '25', '14 (39)', '10 (29)', '24 (79)', '37 (77)', '13 (49)', '0', '19 (59)', 'Fast', '8 (39)', 'Medium', '15 (69)'),
('Kongou', 21, '63', '63 (89)', '52 (69)', '0', '30 (59)', '24 (69)', '9', '0', 'Fast', '13 (39)', 'Long', '12 (49)'),
('Kuma', 39, '25', '14 (49)', '10 (29)', '24 (89)', '36 (79)', '13 (59)', '2', '19 (59)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Kumano', 125, '40', '40 (59)', '30 (59)', '18 (69)', '31 (62)', '18 (59)', '6', '0', 'Fast', '14 (39)', 'Medium', '5 (49)'),
('Littorio', 241, '88', '78 (97)', '72 (86)', '0', '8 (54)', '40 (72)', '12', '0', 'Fast', '15 (44)', 'Very Long', '20 (69)'),
('Maya', 61, '45', '40 (54)', '35 (49)', '24 (49)', '35 (59)', '18 (56)', '6', '0', 'Fast', '13 (39)', 'Medium', '10 (49)'),
('Mikazuki', 37, '13', '6 (29)', '(18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Mikuma', 116, '40', '40 (59)', '30 (59)', '18 (69)', '31 (62)', '18 (59)', '6', '0', 'Fast', '14 (39)', 'Medium', '5 (49)'),
('Miyuki', 14, '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Mochizuki', 38, '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Mogami', 51, '41', '40 (59)', '31 (59)', '18 (69)', '35 (69)', '20 (59)', '6', '0', 'Fast', '14 (39)', 'Medium', '10 (49)'),
('Murakumo', 15, '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Musashi', 143, '94', '96 (129)', '88 (108)', '0', '27 (59)', '50 (94)', '28', '0', 'Slow', '15 (39)', 'Very Long', '10 (79)'),
('Mutsu', 2, '80', '82 (99)', '75 (89)', '0', '24 (49)', '31 (89)', '12', '0', 'Slow', '12 (39)', 'Long', '3 (39)'),
('Mutsuki', 31, '13', '6 (29)', '5 (18)', '18 (59)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '12 (49)'),
('Myoukou', 55, '44', '40 (59)', '32 (49)', '24 (59)', '34 (69)', '16 (64)', '6', '0', 'Fast', '12 (39)', 'Medium', '10 (49)'),
('Nachi', 56, '44', '40 (54)', '32 (49)', '24 (49)', '34 (59)', '16 (54)', '6', '0', 'Fast', '12 (39)', 'Medium', '10 (49)'),
('Nagara', 42, '26', '14 (49)', '10 (29)', '24 (89)', '37 (79)', '13 (59)', '2', '20 (59)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Nagato', 1, ' 80', '82 (99)', '75 (89)', '0', '24 (49)', '31 (89)', '12', '0', 'Slow', '12 (39)', 'Long', '20 (79)'),
('Nagatsuki', 35, '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '15 (69)'),
('Naka', 48, '26', '14 (39)', '11 (29)', '24 (79)', '38 (69)', '13 (49)', '2', '24 (69)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Natori', 44, '26', ' 14 (39)', '10 (29)', '24 (79)', '37 (69)', '13 (49)', '2', '20 (59)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Nenohi', 76, '16', '10 (29)', '6 (19)', '27 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Noshiro', 138, '30', '20 (42)', '17 (32)', '24 (72)', '37 (72)', '17 (60)', '6', '25 (70)', 'Fast', '12 (45)', 'Medium', '10 (49)'),
('Oboro', 67, '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Ooi', 19, '25', '14 (49)', '11 (29)', '24 (89)', '37 (77)', '13 (59)', '0', '19 (59)', 'Fast', '8 (39)', 'Medium', '17 (49)'),
('Ooshio', 86, '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Ooyodo', 183, '34', '24 (48)', '19 (34)', '0 (39)', '35 (70)', '18 (62)', '12', '0 (39)', 'Fast', '24 (80)', 'Medium', '24 (69)'),
('Prinz Eugen', 76, '50', '38 (56)', '38 (64)', '32 (64)', '34 (68)', '16 (44)', '9', '0', 'Fast', '15 (40)', 'Medium', '30 (79)'),
('Roma', 242, '88', '79 (98)', '71 (85)', '0', '27 (52)', '44 (74)', '12', '0', 'Fast', '17 (46)', 'Very Long', '6 (39)'),
('Sakawa', 140, '31', '19 (41)', '17 (32)', '23 (71)', '36 (72)', '17 (62)', '6', '27 (72)', 'Fast', '12 (45)', 'Medium', '20 (49)'),
('Samidare', 83, ' 16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Satsuki', 33, '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Sazanami', 69, '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Sendai', 46, '26', '14 (49)', '11 (29)', '24 (89)', '38 (79)', '13 (59)', '2', '20 (69)', 'Fast', '8 (39)', 'Medium', '12 (49)'),
('Shigure', 80, '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Shikinami', 18, '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Shiratsuyu', 79, '16', '10 (29)', '6 (19)', '24 (79)', '43 (79)', '12 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '12 (49)'),
('Shirayuki', 12, '15', '10 (29)', '5 (19)', '27 (69)', '40 (79)', '10 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Shoukaku', 106, '62', '0 (39)', '33 (49)', '0', '36 (59)', '29 (69)', '75', '0', 'Fast', '44 (69)', 'Short', '10 (49)'),
('Souryuu', 8, '50', '0 (29)', '27 (49)	', '0', '33 (59)', '26 (69)', '64', '0', 'Fast', '42 (69)', 'Short', '10 (49)'),
('Suzuya', 124, '40', '40 (59)', '30 (59)', '18 (69)', '31 (62)', '18 (59)', '6', '0', 'Fast', '14 (39)', 'Medium', '5 (49)'),
('Taihou', 153, '67', '0 (49)', '40 (79)', '0', '33 (57)', '42 (79)', '61', '0', 'Fast', '47 (74)', 'Short', '2 (19)'),
('Takao', 59, '45', '40 (59)', '35 (49)', '24 (59)', '35 (69)', '18 (66)', '6', '0', 'Fast', '13 (39)', 'Medium', '10 (49)'),
('Tama', 40, '25', '14 (39)', '10 (29)', '24 (79)', '36 (69)', '13 (49)', '2', '19 (59)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Tatsuta', 29, '23', '11 (39)', '7 (29)', '18 (59)', '35 (69)', '8 (39)', '0', '18 (59)', 'Fast', '7 (19)', 'Medium', '17 (49)'),
('Tenryuu', 28, '23', '11 (39)', '7 (29)', '18 (59)', '35 (69)', '8 (39)', '0', '18 (59)', 'Fast', '7 (19)', 'Medium', '17 (49)'),
('Tone', 63, '44', '32 (59)', '36 (59)', '24 (59)', '36 (69)', '20 (67)', '9', '0', 'Fast', '20 (59)', 'Medium', '10 (49)'),
('Unryuu', 201, '48', '0 (27)', '26 (52)', '0', '32 (59)', '28 (72)', '51', '0', 'Fast', '40 (72)', 'Short', '10 (49)'),
('Ushio', 70, '15', '10 (29)', '5 (19)', '27 (69)', '41 (79)', '12 (39)', '0', '20 (49)', 'Fast', '5 (19)', 'Short', '20 (79)'),
('Uzuki', 165, '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Wakaba', 77, '16', '10 (29)', '6 (19)', '27 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Yahagi', 139, '31', '20 (42)', '17 (33)', '24 (72)', '38 (72)', '17 (63)', '6', '25 (70)', 'Fast', '13 (45)', 'Medium', '13 (59)'),
('Yamashiro', 27, '67', '74 (94)', '59 (79)', '0', '19 (39)', '23 (79)', '12', '0', 'Slow', '9 (33)', 'Long', '5 (39)'),
('Yamato', 131, '93', '96 (129)', '88 (108)', '0', '27 (59)', '50 (94)', '28', '0', 'Slow', '15 (39)', 'Very Long', '12 (79)'),
('Yayoi', 164, '13', '6 (29)', '5 (18)', '18 (49)', '37 (69)', '7 (29)', '0', '16 (39)', 'Fast', '4 (17)', 'Short', '10 (49)'),
('Yura', 45, ' 26', '14 (39)', '10 (29)', '24 (79)', '37 (69)', '13 (49)', '2', '40 (59)', 'Fast', '8 (39)', 'Medium', '10 (49)'),
('Yuubari', 111, '19', '17 (42)', '10 (29)', '20 (69)', '42 (69)', '10 (42)', '0', '13 (39)', 'Fast', '6 (39)', 'Medium', '12 (49)'),
('Yuudachi', 82, '16', '10 (29)', '6 (19)', '24 (69)', '43 (79)', '9 (39)', '0', '21 (49)', 'Fast', '5 (19)', 'Short', '10 (49)'),
('Zuikaku', 107, '62', '0 (39)', '33 (49)', '0', '39 (69)', '29 (69)', '75', '0', 'Fast', '44 (69)', 'Short', '40 (89)');

-- --------------------------------------------------------

--
-- Table structure for table `special`
--

CREATE TABLE `special` (
  `Item` char(45) NOT NULL,
  `Effect` varchar(255) DEFAULT NULL,
  `Price` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `special`
--

INSERT INTO `special` (`Item`, `Effect`, `Price`) VALUES
('Bargain_resources_set_shop', 'Gives 15 steel, 2 ammo, 2 fuel, 2 bauxite and 2 development materials', '7'),
('Bargain_sortie_set_shop', 'Gives 5 fuel, 5 ammo, 2 steel and 2 instant repairs', '3'),
('Bauxite_pack_shop', 'Gives 550 bauxite', '3'),
('Food_set', 'Gives 1 Food Supply Ship Mamiya (instant fatigue recovery for a whole fleet)', '3'),
('Fuel_pack_shop', 'Gives 10 fuel', '3'),
('Papers_and_ring', 'A set of marriage papers and ring that allows you to marry the ship of your choice', '7'),
('Port_extension_shop', 'Increases your ship capacity by 10 and your equipment capacity by 40', '10'),
('Shop_Food_Pack_2', 'Gives 5 Food Supply Ship Irako (instant fatigue recovery for a whole fleet)', '10'),
('Shop_Improvement_Pack', 'Gives 10 Improvement Materials', '7'),
('Shop_Sortie_Morale_Booster', 'Gives 3 Morale Boost support items', '3'),
('Shop_Support_Slot', 'Gives 1 Reinforcement Expansion item', '5');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `consumables`
--
ALTER TABLE `consumables`
  ADD PRIMARY KEY (`Item`);

--
-- Indexes for table `recipe`
--
ALTER TABLE `recipe`
  ADD PRIMARY KEY (`Ship_Type`,`Rare`);

--
-- Indexes for table `recommended`
--
ALTER TABLE `recommended`
  ADD PRIMARY KEY (`Item`);

--
-- Indexes for table `resources`
--
ALTER TABLE `resources`
  ADD PRIMARY KEY (`Item`);

--
-- Indexes for table `shipinfo`
--
ALTER TABLE `shipinfo`
  ADD PRIMARY KEY (`Ship_Name`,`Ship_No`);

--
-- Indexes for table `ships`
--
ALTER TABLE `ships`
  ADD PRIMARY KEY (`Ship_Name`,`Ship_No`);

--
-- Indexes for table `shipstats`
--
ALTER TABLE `shipstats`
  ADD PRIMARY KEY (`Ship_Name`,`Ship_No`);

--
-- Indexes for table `special`
--
ALTER TABLE `special`
  ADD PRIMARY KEY (`Item`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
