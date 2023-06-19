-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: tenis
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ediciones`
--

DROP TABLE IF EXISTS `ediciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ediciones` (
  `Anualidad` int NOT NULL,
  `Torneo` int NOT NULL,
  `Ganadora` int NOT NULL,
  PRIMARY KEY (`Anualidad`,`Torneo`),
  KEY `FK_Edi_Tou_idx` (`Torneo`),
  KEY `FK_Edi_Pla_idx` (`Ganadora`),
  CONSTRAINT `FK_Edi_Pla` FOREIGN KEY (`Ganadora`) REFERENCES `jugadoras` (`idJugadora`),
  CONSTRAINT `FK_Edi_Tou` FOREIGN KEY (`Torneo`) REFERENCES `torneos` (`idTorneo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ediciones`
--

LOCK TABLES `ediciones` WRITE;
/*!40000 ALTER TABLE `ediciones` DISABLE KEYS */;
INSERT INTO `ediciones` VALUES (2017,1,1),(2020,14,1),(2021,1,2),(2020,7,3),(2017,2,4),(2020,11,4),(2020,9,6),(2018,2,7),(2022,5,7),(2014,10,8),(2020,2,9),(2020,5,9),(2020,6,9),(2021,5,9),(2018,12,10),(2020,3,10),(2019,1,11),(2020,13,11),(2020,4,12),(2020,8,14),(2020,15,14);
/*!40000 ALTER TABLE `ediciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `juegos`
--

DROP TABLE IF EXISTS `juegos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `juegos` (
  `Jugadora` int NOT NULL,
  `Partido` int NOT NULL,
  `Set1` int NOT NULL,
  `Set2` int NOT NULL,
  `Set3` int DEFAULT NULL,
  PRIMARY KEY (`Jugadora`,`Partido`),
  KEY `FK_Pla_Mat_idx` (`Partido`),
  CONSTRAINT `FK_Pla_Mat` FOREIGN KEY (`Partido`) REFERENCES `partidos` (`idPartido`),
  CONSTRAINT `FK_Pla_Pla` FOREIGN KEY (`Jugadora`) REFERENCES `jugadoras` (`idJugadora`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `juegos`
--

LOCK TABLES `juegos` WRITE;
/*!40000 ALTER TABLE `juegos` DISABLE KEYS */;
INSERT INTO `juegos` VALUES (1,3,2,6,6),(1,6,3,6,6),(1,7,6,6,0),(1,17,0,2,0),(1,24,1,0,0),(1,38,6,6,0),(1,41,2,6,2),(1,59,6,6,0),(1,62,1,0,0),(1,71,6,2,6),(1,75,6,3,6),(1,77,6,3,2),(1,81,0,6,3),(1,102,2,6,2),(1,115,2,0,0),(1,130,6,6,0),(1,132,0,6,6),(1,133,2,0,0),(1,135,6,6,0),(1,138,6,6,0),(1,140,1,6,6),(2,2,3,6,6),(2,5,6,6,0),(2,7,0,0,0),(2,17,6,6,0),(2,20,6,6,0),(2,21,6,6,0),(2,23,1,0,0),(2,30,0,1,0),(2,81,6,1,6),(2,83,2,6,6),(2,84,6,3,1),(2,86,6,6,0),(2,89,1,6,2),(2,95,1,6,2),(2,101,6,6,0),(2,104,2,6,6),(2,105,6,1,2),(2,114,6,6,0),(2,117,3,3,0),(2,121,2,6,2),(2,142,2,6,6),(2,145,3,0,0),(3,32,6,6,0),(3,34,1,6,2),(3,39,0,6,0),(3,51,3,6,0),(3,67,6,6,0),(3,69,1,6,1),(3,74,6,6,0),(3,76,0,2,0),(3,87,2,6,6),(3,90,2,1,0),(3,94,6,2,6),(3,97,1,1,0),(3,99,2,6,6),(3,103,6,6,0),(3,105,0,6,6),(3,130,3,1,0),(3,144,6,1,6),(3,146,6,6,0),(3,147,2,6,0),(4,8,1,6,6),(4,12,6,2,6),(4,14,6,1,2),(4,15,6,6,0),(4,19,2,6,6),(4,21,2,0,0),(4,22,6,6,0),(4,26,6,6,0),(4,28,6,6,0),(4,29,0,2,0),(4,36,6,6,0),(4,40,6,6,0),(4,42,6,0,2),(4,50,3,1,0),(4,80,2,1,0),(4,94,2,6,1),(4,108,6,2,0),(4,123,6,6,0),(4,125,6,2,6),(4,126,6,0,6),(4,127,6,6,0),(4,131,1,1,0),(4,136,6,6,0),(4,139,6,3,6),(4,140,6,1,3),(5,1,2,6,2),(5,43,1,6,0),(5,57,6,6,0),(5,61,2,3,0),(5,64,2,1,0),(5,78,2,6,6),(5,82,6,0,1),(5,85,1,6,6),(5,89,6,1,6),(5,91,2,1,0),(5,92,3,1,0),(5,99,6,3,2),(5,106,6,2,1),(5,113,6,3,6),(5,117,6,6,0),(5,119,2,1,0),(5,120,6,6,0),(5,124,1,2,0),(5,134,2,3,0),(5,141,1,1,0),(6,10,6,6,0),(6,13,2,3,0),(6,60,1,0,0),(6,67,3,3,0),(6,79,2,1,0),(6,93,6,2,6),(6,96,2,6,0),(6,100,1,1,0),(6,109,1,6,1),(6,116,6,6,0),(6,118,2,6,6),(6,119,6,6,0),(6,135,0,1,0),(6,144,3,6,1),(7,9,1,6,6),(7,12,3,6,0),(7,16,1,2,0),(7,23,6,6,0),(7,26,0,1,0),(7,30,6,6,0),(7,33,6,6,0),(7,35,2,6,6),(7,44,1,6,6),(7,47,6,6,0),(7,49,6,6,0),(7,58,6,1,2),(7,65,6,1,1),(7,74,2,2,0),(7,86,2,2,0),(7,100,6,6,0),(7,103,1,3,0),(7,107,3,6,1),(7,114,0,2,0),(7,137,3,1,0),(8,1,6,1,6),(8,5,3,1,0),(8,52,0,6,1),(8,59,2,2,0),(8,64,6,6,0),(8,68,6,1,6),(8,70,6,6,0),(8,71,3,6,2),(8,85,6,0,2),(8,115,6,6,0),(8,118,6,1,3),(8,120,1,3,0),(8,127,2,1,0),(8,134,6,6,0),(8,138,2,0,0),(9,4,2,6,2),(9,11,1,1,0),(9,18,1,6,6),(9,20,0,2,0),(9,31,0,6,3),(9,39,6,1,6),(9,41,6,1,6),(9,42,3,6,6),(9,45,2,6,6),(9,48,0,2,0),(9,52,6,1,6),(9,55,6,1,6),(9,56,6,6,0),(9,58,1,6,6),(9,61,6,6,0),(9,63,6,6,0),(9,66,0,1,0),(9,87,6,2,1),(9,95,6,1,6),(9,97,6,6,0),(9,98,6,6,0),(9,101,2,2,0),(9,122,6,6,0),(9,125,3,6,1),(9,129,1,6,6),(9,132,6,1,3),(9,137,6,6,0),(9,139,0,6,1),(9,143,6,6,0),(9,146,3,3,0),(10,9,6,1,1),(10,16,6,6,0),(10,19,6,1,0),(10,25,6,2,6),(10,27,6,1,1),(10,32,1,2,0),(10,37,6,2,2),(10,46,6,0,3),(10,73,3,6,6),(10,76,6,6,0),(10,77,1,6,6),(10,79,6,6,0),(10,82,2,6,6),(10,84,3,6,6),(10,88,0,6,1),(10,93,1,6,1),(10,107,6,1,6),(10,110,6,1,1),(10,121,6,2,6),(10,124,6,6,0),(10,126,1,6,1),(11,2,6,0,1),(11,11,6,6,0),(11,13,6,6,0),(11,14,2,6,6),(11,18,6,2,2),(11,37,1,6,6),(11,40,1,2,0),(11,44,6,1,1),(11,53,3,6,1),(11,65,1,6,6),(11,68,2,6,2),(11,72,1,1,0),(11,102,6,2,6),(11,104,6,0,0),(11,123,1,2,0),(11,128,6,6,0),(11,131,6,6,0),(11,133,6,6,0),(11,142,6,1,2),(12,4,6,1,6),(12,6,6,2,3),(12,25,1,6,2),(12,38,2,3,0),(12,46,1,6,6),(12,48,6,6,0),(12,49,0,1,0),(12,51,6,2,6),(12,54,2,1,0),(12,72,6,6,0),(12,75,2,6,2),(12,80,6,6,0),(12,83,6,3,0),(12,88,6,3,6),(12,90,6,6,0),(12,91,6,6,0),(12,109,6,1,6),(12,111,2,2,0),(12,116,2,2,0),(12,122,3,1,0),(12,128,0,3,0),(13,3,6,2,1),(13,10,2,1,0),(13,24,6,6,0),(13,27,1,6,6),(13,28,1,3,0),(13,31,6,1,6),(13,34,6,1,6),(13,35,6,2,2),(13,45,6,3,1),(13,53,6,1,6),(13,55,3,6,3),(13,60,6,6,0),(13,62,6,6,0),(13,63,2,1,0),(13,66,6,6,0),(13,69,6,0,6),(13,70,2,1,0),(13,73,6,1,1),(13,78,6,1,1),(13,92,6,6,0),(13,96,6,1,6),(13,98,1,1,0),(13,108,2,6,6),(13,111,6,6,0),(13,112,6,0,1),(13,129,6,1,1),(13,136,2,1,0),(13,143,0,0,0),(14,22,2,1,0),(14,29,6,6,0),(14,33,2,1,0),(14,36,2,3,0),(14,57,2,2,0),(14,106,1,6,6),(14,110,1,6,6),(14,112,2,6,6),(14,113,0,6,1),(14,141,6,6,0),(14,145,6,6,0),(14,147,6,3,6),(15,8,6,0,2),(15,15,1,1,0),(15,43,6,1,6),(15,47,3,1,0),(15,50,6,6,0),(15,54,6,6,0),(15,56,3,1,0);
/*!40000 ALTER TABLE `juegos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugadoras`
--

DROP TABLE IF EXISTS `jugadoras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jugadoras` (
  `idJugadora` int NOT NULL AUTO_INCREMENT,
  `NombreJugadora` varchar(45) NOT NULL,
  `FechaNacimientoJugadora` date NOT NULL,
  `PuntosJugadora` int NOT NULL,
  `PaisJugadora` char(3) NOT NULL,
  PRIMARY KEY (`idJugadora`),
  UNIQUE KEY `PlayerName_UNIQUE` (`NombreJugadora`),
  KEY `FK_Pla_Cou_idx` (`PaisJugadora`),
  CONSTRAINT `FK_Pla_Cou` FOREIGN KEY (`PaisJugadora`) REFERENCES `paises` (`idPais`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugadoras`
--

LOCK TABLES `jugadoras` WRITE;
/*!40000 ALTER TABLE `jugadoras` DISABLE KEYS */;
INSERT INTO `jugadoras` VALUES (1,'Serena Williams','1981-09-26',5260,'EST'),(2,'Garbiñe Muguruza','1993-10-08',3460,'ESP'),(3,'Ashleigh Barty','1996-04-24',3330,'AUS'),(4,'Barbora Krejcikova','1995-12-18',5460,'REP'),(5,'Iga Swiatek','2001-05-31',6966,'BIE'),(6,'Paula Badosa','1997-11-15',5215,'ESP'),(7,'Karolina Pliskova','1992-03-21',4562,'REP'),(8,'Emma Raducanu','2002-11-13',2941,'ING'),(9,'Maria Sakkari','1995-04-07',5415,'GRE'),(10,'Aryna Sabalenka','1998-05-05',5042,'BIE'),(11,'Danielle Collins','1993-12-13',3496,'EST'),(12,'Ons Jabeur','1994-09-28',3310,'TUN'),(13,'Jelena Ostapenko','1997-06-08',3210,'LET'),(14,'Jessica Pegula','1994-02-24',2800,'EST'),(15,'Cori Coco Gauff','2004-03-13',2440,'EST');
/*!40000 ALTER TABLE `jugadoras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paises`
--

DROP TABLE IF EXISTS `paises`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paises` (
  `idPais` char(3) NOT NULL,
  `NombrePais` varchar(45) NOT NULL,
  PRIMARY KEY (`idPais`),
  UNIQUE KEY `CountryName_UNIQUE` (`NombrePais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paises`
--

LOCK TABLES `paises` WRITE;
/*!40000 ALTER TABLE `paises` DISABLE KEYS */;
INSERT INTO `paises` VALUES ('EMI',' Emiratos Árabes Unidos'),('ALE','Alemania'),('AUS','Australia'),('BEL','Belgica'),('BIE','Bielorrusia'),('CAN','Canada'),('CHI','China'),('ESP','España'),('EST','Estados Unidos'),('FRA','Francia'),('GRE','Grecia'),('HUN','Hungria'),('ING','Inglaterra'),('ITA','Italia'),('LET','Letonia'),('MEX','Mexico'),('POL','Polonia'),('REP','Republica Checa'),('RUS','Rusia'),('TUN','Tunez');
/*!40000 ALTER TABLE `paises` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partidos`
--

DROP TABLE IF EXISTS `partidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partidos` (
  `idPartido` int NOT NULL AUTO_INCREMENT,
  `Anualidad` int NOT NULL,
  `Torneo` int NOT NULL,
  `Ganadora` int NOT NULL,
  `Ronda` char(1) NOT NULL,
  PRIMARY KEY (`idPartido`),
  KEY `FK_Mat_Edi_idx` (`Anualidad`,`Torneo`),
  KEY `FK_Mat_Play_idx` (`Ganadora`),
  CONSTRAINT `FK_Mat_Edi` FOREIGN KEY (`Anualidad`, `Torneo`) REFERENCES `ediciones` (`Anualidad`, `Torneo`),
  CONSTRAINT `FK_Mat_Play` FOREIGN KEY (`Ganadora`) REFERENCES `jugadoras` (`idJugadora`)
) ENGINE=InnoDB AUTO_INCREMENT=148 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidos`
--

LOCK TABLES `partidos` WRITE;
/*!40000 ALTER TABLE `partidos` DISABLE KEYS */;
INSERT INTO `partidos` VALUES (1,2017,1,8,'c'),(2,2017,1,2,'c'),(3,2017,1,1,'c'),(4,2017,1,12,'c'),(5,2017,1,2,'s'),(6,2017,1,1,'s'),(7,2017,1,1,'f'),(8,2019,1,4,'c'),(9,2019,1,7,'c'),(10,2019,1,6,'c'),(11,2019,1,11,'c'),(12,2019,1,4,'s'),(13,2019,1,11,'s'),(14,2019,1,11,'f'),(15,2021,1,4,'c'),(16,2021,1,10,'c'),(17,2021,1,2,'c'),(18,2021,1,9,'c'),(19,2021,1,4,'s'),(20,2021,1,2,'s'),(21,2021,1,2,'f'),(22,2017,2,4,'c'),(23,2017,2,7,'c'),(24,2017,2,13,'c'),(25,2017,2,10,'c'),(26,2017,2,4,'s'),(27,2017,2,13,'s'),(28,2017,2,4,'f'),(29,2018,2,14,'c'),(30,2018,2,7,'c'),(31,2018,2,13,'c'),(32,2018,2,3,'c'),(33,2018,2,7,'s'),(34,2018,2,13,'s'),(35,2018,2,7,'f'),(36,2020,2,4,'c'),(37,2020,2,11,'c'),(38,2020,2,1,'c'),(39,2020,2,9,'c'),(40,2020,2,4,'s'),(41,2020,2,9,'s'),(42,2020,2,9,'f'),(43,2022,5,15,'c'),(44,2022,5,7,'c'),(45,2022,5,9,'c'),(46,2022,5,12,'c'),(47,2022,5,7,'s'),(48,2022,5,12,'s'),(49,2022,5,7,'f'),(50,2021,5,15,'c'),(51,2021,5,12,'c'),(52,2021,5,9,'c'),(53,2021,5,13,'c'),(54,2021,5,15,'s'),(55,2021,5,9,'s'),(56,2021,5,9,'f'),(57,2020,5,5,'c'),(58,2020,5,9,'c'),(59,2020,5,1,'c'),(60,2020,5,13,'c'),(61,2020,5,9,'s'),(62,2020,5,13,'s'),(63,2020,5,9,'f'),(64,2014,10,8,'c'),(65,2014,10,11,'c'),(66,2014,10,13,'c'),(67,2014,10,3,'c'),(68,2014,10,8,'s'),(69,2014,10,13,'s'),(70,2014,10,8,'f'),(71,2018,12,1,'c'),(72,2018,12,12,'c'),(73,2018,12,10,'c'),(74,2018,12,3,'c'),(75,2018,12,1,'s'),(76,2018,12,10,'s'),(77,2018,12,10,'f'),(78,2020,3,5,'c'),(79,2020,3,10,'c'),(80,2020,3,12,'c'),(81,2020,3,2,'c'),(82,2020,3,10,'s'),(83,2020,3,2,'s'),(84,2020,3,10,'f'),(85,2020,4,5,'c'),(86,2020,4,2,'c'),(87,2020,4,3,'c'),(88,2020,4,12,'c'),(89,2020,4,5,'s'),(90,2020,4,12,'s'),(91,2020,4,12,'f'),(92,2020,6,13,'c'),(93,2020,6,6,'c'),(94,2020,6,3,'c'),(95,2020,6,9,'c'),(96,2020,6,13,'s'),(97,2020,6,9,'s'),(98,2020,6,9,'f'),(99,2020,7,3,'c'),(100,2020,7,7,'c'),(101,2020,7,2,'c'),(102,2020,7,11,'c'),(103,2020,7,3,'s'),(104,2020,7,2,'s'),(105,2020,7,3,'f'),(106,2020,8,14,'c'),(107,2020,8,10,'c'),(108,2020,8,13,'c'),(109,2020,8,12,'c'),(110,2020,8,14,'s'),(111,2020,8,13,'s'),(112,2020,8,14,'f'),(113,2020,9,5,'c'),(114,2020,9,2,'c'),(115,2020,9,8,'c'),(116,2020,9,6,'c'),(117,2020,9,5,'s'),(118,2020,9,6,'s'),(119,2020,9,6,'f'),(120,2020,11,5,'c'),(121,2020,11,10,'c'),(122,2020,11,9,'c'),(123,2020,11,4,'c'),(124,2020,11,10,'s'),(125,2020,11,4,'s'),(126,2020,11,4,'f'),(127,2020,13,4,'c'),(128,2020,13,11,'c'),(129,2020,13,9,'c'),(130,2020,13,1,'c'),(131,2020,13,11,'s'),(132,2020,13,1,'s'),(133,2020,13,11,'f'),(134,2020,14,8,'c'),(135,2020,14,1,'c'),(136,2020,14,4,'c'),(137,2020,14,9,'c'),(138,2020,14,1,'s'),(139,2020,14,4,'s'),(140,2020,14,1,'f'),(141,2020,15,14,'c'),(142,2020,15,2,'c'),(143,2020,15,9,'c'),(144,2020,15,3,'c'),(145,2020,15,14,'s'),(146,2020,15,3,'s'),(147,2020,15,14,'f');
/*!40000 ALTER TABLE `partidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `torneos`
--

DROP TABLE IF EXISTS `torneos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `torneos` (
  `idTorneo` int NOT NULL AUTO_INCREMENT,
  `NombreTorneo` varchar(45) NOT NULL,
  `CiudadTorneo` varchar(45) NOT NULL,
  `PaisTorneo` char(3) NOT NULL,
  PRIMARY KEY (`idTorneo`),
  UNIQUE KEY `TournamentName_UNIQUE` (`NombreTorneo`),
  KEY `FK_Tou_Cou_idx` (`PaisTorneo`),
  CONSTRAINT `FK_Tou_Cou` FOREIGN KEY (`PaisTorneo`) REFERENCES `paises` (`idPais`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `torneos`
--

LOCK TABLES `torneos` WRITE;
/*!40000 ALTER TABLE `torneos` DISABLE KEYS */;
INSERT INTO `torneos` VALUES (1,'Roland Garros','Paris','FRA'),(2,'Mutua Madrid Open','Madrid','ESP'),(3,'Internazionali BNL d\'Italia','Roma','ITA'),(4,'Abierto de Australia','Melbourne','AUS'),(5,'Wimbledon','Londres','ING'),(6,'Abierto de Estados Unidos','Queens','EST'),(7,'WTA Finals',' Guadalajara','MEX'),(8,'Dubai Duty','Dubai','EMI'),(9,'Indian Wells','California','EST'),(10,'Miami Open','Miami','EST'),(11,'Rogers Cup','Toronto','CAN'),(12,'Wuhan Open','Wuhan','CHI'),(13,'Pekin Open','Pekin','CHI'),(14,'Sydney International','Sidney','AUS'),(15,'VTB Kremlin Cup','Moscú','RUS');
/*!40000 ALTER TABLE `torneos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-21 14:00:54
