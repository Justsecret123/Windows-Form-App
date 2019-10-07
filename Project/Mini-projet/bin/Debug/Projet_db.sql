-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: projet
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `admin` (
  `ID_ADMIN` int(3) NOT NULL AUTO_INCREMENT,
  `ID_GARE` int(2) DEFAULT NULL,
  `NOM_ADMIN` longtext,
  `ADRESSE_ADMIN` text,
  `LOGIN` text,
  `MOT_DE_PASSE` text,
  PRIMARY KEY (`ID_ADMIN`),
  KEY `FK_TRAVAILLER` (`ID_GARE`),
  CONSTRAINT `FK_TRAVAILLER` FOREIGN KEY (`ID_GARE`) REFERENCES `gare` (`id_gare`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES (1,1,'Ibrahim Serouis','279, Bir Anzarane','Ibrahim_99','Eyeshield 21'),(2,1,'root','Adresse_root','root','Eyeshield 21');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `annonce`
--

DROP TABLE IF EXISTS `annonce`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `annonce` (
  `ID_ANNONCE` int(3) NOT NULL AUTO_INCREMENT,
  `ID_VOYAGE` int(3) DEFAULT NULL,
  `ID_GARE` int(2) DEFAULT NULL,
  `TYPE_ANNONCE` int(11) DEFAULT NULL,
  `LIBELLE` text,
  PRIMARY KEY (`ID_ANNONCE`),
  KEY `FK_AVOIR` (`ID_GARE`),
  KEY `FK_CONCERNE` (`ID_VOYAGE`),
  CONSTRAINT `FK_AVOIR` FOREIGN KEY (`ID_GARE`) REFERENCES `gare` (`id_gare`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_CONCERNE` FOREIGN KEY (`ID_VOYAGE`) REFERENCES `voyage` (`id_voyage`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `annonce`
--

LOCK TABLES `annonce` WRITE;
/*!40000 ALTER TABLE `annonce` DISABLE KEYS */;
INSERT INTO `annonce` VALUES (1,1,1,1,'Retard d\'01h30 concernant le voyage vers Rabat Agdal prévu pour le 05/01 à 00:00.'),(3,2,1,2,'Le voyage à destination de Rabat Agdal prévu pour le 05/01 à 06:40 est annulé.'),(5,1,4,1,'Test 1 '),(6,1,3,2,'Test 2 '),(7,1,2,3,'Test 3 ');
/*!40000 ALTER TABLE `annonce` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `client` (
  `ID_CLIENT` int(5) NOT NULL AUTO_INCREMENT,
  `ID_FORMULE` int(2) DEFAULT NULL,
  `NOM_CLIENT` tinytext,
  `ADRESSE_CLIENT` tinytext,
  `TELEPHONE` decimal(10,0) DEFAULT NULL,
  `TYPE_CLIENT` int(11) DEFAULT NULL,
  `SECRET_CODE` tinytext,
  PRIMARY KEY (`ID_CLIENT`),
  KEY `FK_POSSEDER` (`ID_FORMULE`),
  CONSTRAINT `FK_POSSEDER` FOREIGN KEY (`ID_FORMULE`) REFERENCES `formule_abo` (`id_formule`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,2,'Ibrahim Serouis','Arreda Imm 25 APT 02',649653598,2,'00000000'),(17,2,'Alexandra Kwedi','',674744774,2,'a3df503a'),(18,2,'Leslie Mabou','',4746434747,2,'4ed0ff10'),(19,2,'Same Banimb','Bochum, 123, Deutshcland',647784747,2,'53e2a354');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `desservir`
--

DROP TABLE IF EXISTS `desservir`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `desservir` (
  `ID_GARE` int(2) NOT NULL,
  `ID_VOYAGE` int(3) NOT NULL,
  PRIMARY KEY (`ID_GARE`,`ID_VOYAGE`),
  KEY `FK_DESSERVIR_` (`ID_VOYAGE`),
  CONSTRAINT `FK_DESSERVIR` FOREIGN KEY (`ID_GARE`) REFERENCES `gare` (`id_gare`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_DESSERVIR_` FOREIGN KEY (`ID_VOYAGE`) REFERENCES `voyage` (`id_voyage`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `desservir`
--

LOCK TABLES `desservir` WRITE;
/*!40000 ALTER TABLE `desservir` DISABLE KEYS */;
/*!40000 ALTER TABLE `desservir` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formule_abo`
--

DROP TABLE IF EXISTS `formule_abo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `formule_abo` (
  `ID_FORMULE` int(2) NOT NULL AUTO_INCREMENT,
  `REDUCTION` decimal(2,0) DEFAULT NULL,
  PRIMARY KEY (`ID_FORMULE`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formule_abo`
--

LOCK TABLES `formule_abo` WRITE;
/*!40000 ALTER TABLE `formule_abo` DISABLE KEYS */;
INSERT INTO `formule_abo` VALUES (1,25),(2,20),(3,15),(4,30);
/*!40000 ALTER TABLE `formule_abo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gare`
--

DROP TABLE IF EXISTS `gare`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `gare` (
  `ID_GARE` int(2) NOT NULL AUTO_INCREMENT,
  `NOM_GARE` longtext,
  `DISPONIBILITE_GARE` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_GARE`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gare`
--

LOCK TABLES `gare` WRITE;
/*!40000 ALTER TABLE `gare` DISABLE KEYS */;
INSERT INTO `gare` VALUES (1,'Casa Port',1),(2,'Casa Voyageurs',1),(3,'Casa Oasis',1),(4,'Rabat Agdal',1),(5,'Rabat Ville',1),(6,'Marrakech',1),(7,'Agadir',0),(8,'Ain Sebaa',0);
/*!40000 ALTER TABLE `gare` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `reservation` (
  `ID_RESERVATION` int(5) NOT NULL AUTO_INCREMENT,
  `ID_VOYAGE` int(3) NOT NULL,
  `ID_CLIENT` int(5) DEFAULT NULL,
  `CLASSE` char(1) DEFAULT NULL,
  `PRIX_RESERVATION` decimal(3,0) DEFAULT NULL,
  `DATE_RESERVATION` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_RESERVATION`),
  KEY `FK_POUR` (`ID_VOYAGE`),
  KEY `FK_RESERVER` (`ID_CLIENT`),
  CONSTRAINT `FK_POUR` FOREIGN KEY (`ID_VOYAGE`) REFERENCES `voyage` (`id_voyage`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_RESERVER` FOREIGN KEY (`ID_CLIENT`) REFERENCES `client` (`id_client`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservation`
--

LOCK TABLES `reservation` WRITE;
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
INSERT INTO `reservation` VALUES (7,1,NULL,'B',35,'2019-01-13 19:02:29'),(13,1,1,'A',28,'2019-01-15 00:47:54'),(14,1,1,'A',28,'2019-01-15 01:53:09'),(15,1,1,'A',28,'2019-01-16 21:22:09');
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `train`
--

DROP TABLE IF EXISTS `train`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `train` (
  `ID_TRAIN` int(5) NOT NULL AUTO_INCREMENT,
  `DISPONIBILITE_TRAIN` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_TRAIN`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `train`
--

LOCK TABLES `train` WRITE;
/*!40000 ALTER TABLE `train` DISABLE KEYS */;
INSERT INTO `train` VALUES (1,1),(2,1),(3,1),(4,1),(5,1),(6,1),(7,1);
/*!40000 ALTER TABLE `train` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `voyage`
--

DROP TABLE IF EXISTS `voyage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `voyage` (
  `ID_VOYAGE` int(3) NOT NULL AUTO_INCREMENT,
  `ID_GARE` int(2) NOT NULL,
  `GAR_ID_GARE` int(2) NOT NULL,
  `ID_TRAIN` int(5) DEFAULT NULL,
  `DATE` datetime DEFAULT NULL,
  `DUREE` time(5) DEFAULT NULL,
  `PRIX_VOYAGE` decimal(3,0) DEFAULT NULL,
  PRIMARY KEY (`ID_VOYAGE`),
  KEY `FK_ARRIVEE` (`GAR_ID_GARE`),
  KEY `FK_DEPART` (`ID_GARE`),
  KEY `FK_VIA` (`ID_TRAIN`),
  CONSTRAINT `FK_ARRIVEE` FOREIGN KEY (`GAR_ID_GARE`) REFERENCES `gare` (`id_gare`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_DEPART` FOREIGN KEY (`ID_GARE`) REFERENCES `gare` (`id_gare`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_VIA` FOREIGN KEY (`ID_TRAIN`) REFERENCES `train` (`id_train`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `voyage`
--

LOCK TABLES `voyage` WRITE;
/*!40000 ALTER TABLE `voyage` DISABLE KEYS */;
INSERT INTO `voyage` VALUES (1,1,4,1,'2019-01-05 00:00:00','01:05:00.00000',35),(2,1,4,2,'2019-01-05 06:40:00','01:07:00.00000',35),(3,1,4,6,'2019-01-05 15:58:00','01:02:00.00000',35),(6,1,2,1,'2019-01-18 08:18:00','00:10:00.00000',10),(7,1,3,2,'2019-01-18 23:23:00','00:10:00.00000',10),(8,1,4,3,'2019-01-18 18:23:00','01:02:00.00000',34),(9,1,5,1,'2019-01-18 02:49:00','01:15:00.00000',37),(10,1,6,5,'2019-01-18 16:49:00','02:25:00.00000',54),(11,1,7,7,'2019-01-18 23:49:00','06:34:00.00000',67),(12,1,8,3,'2019-01-18 02:58:00','00:15:23.00000',15),(13,2,1,1,'2019-01-18 21:58:00','00:10:00.00000',10),(14,2,3,1,'2019-01-18 13:58:00','00:10:00.00000',10),(15,2,4,7,'2019-01-18 11:58:00','01:02:00.00000',34),(16,2,5,4,'2019-01-18 04:15:00','01:15:00.00000',37),(17,2,6,6,'2019-01-18 23:01:00','02:25:00.00000',54),(18,2,7,6,'2019-01-18 10:01:00','06:34:00.00000',67),(19,2,7,3,'2019-01-18 00:01:00','06:34:00.00000',67),(20,2,8,5,'2019-01-18 23:01:00','00:15:23.00000',15),(21,3,5,1,'2019-01-18 12:01:00','01:15:00.00000',37),(22,3,8,4,'2019-01-18 10:01:00','00:15:23.00000',15),(23,4,3,2,'2019-01-18 23:01:00','01:02:00.00000',34),(24,4,6,2,'2019-01-18 20:01:00','02:45:00.00000',68),(25,6,5,5,'2019-01-18 10:01:00','03:00:00.00000',70);
/*!40000 ALTER TABLE `voyage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'projet'
--

--
-- Dumping routines for database 'projet'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-17 16:11:26
