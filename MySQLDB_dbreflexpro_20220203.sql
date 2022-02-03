CREATE DATABASE  IF NOT EXISTS `dbreflexpro` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `dbreflexpro`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dbreflexpro
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Temporary view structure for view `customerstreatments_monthly`
--

DROP TABLE IF EXISTS `customerstreatments_monthly`;
/*!50001 DROP VIEW IF EXISTS `customerstreatments_monthly`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `customerstreatments_monthly` AS SELECT 
 1 AS `Title`,
 1 AS `PatFName`,
 1 AS `PatSurname`,
 1 AS `TreatmentDate`,
 1 AS `TreatmentRef`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `lkgender`
--

DROP TABLE IF EXISTS `lkgender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lkgender` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `GenderCode` varchar(1) DEFAULT NULL,
  `GenderDesc` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COMMENT='Lookup Table for Patient Gender';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lkgender`
--

LOCK TABLES `lkgender` WRITE;
/*!40000 ALTER TABLE `lkgender` DISABLE KEYS */;
INSERT INTO `lkgender` VALUES (1,'M','Male'),(2,'F','Female'),(3,'T','Transgendered');
/*!40000 ALTER TABLE `lkgender` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lktitle`
--

DROP TABLE IF EXISTS `lktitle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lktitle` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3 COMMENT='Lookup for Patient Title';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lktitle`
--

LOCK TABLES `lktitle` WRITE;
/*!40000 ALTER TABLE `lktitle` DISABLE KEYS */;
INSERT INTO `lktitle` VALUES (1,'Mr'),(2,'Mrs'),(3,'Ms'),(4,'Miss'),(5,'Dr'),(6,'Mast'),(7,'Lord'),(8,'Lady'),(9,'Prof');
/*!40000 ALTER TABLE `lktitle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lktreatmentareaproblem`
--

DROP TABLE IF EXISTS `lktreatmentareaproblem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lktreatmentareaproblem` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `TreatmentAreaProblem` varchar(45) NOT NULL,
  PRIMARY KEY (`pkID`),
  UNIQUE KEY `pkID_UNIQUE` (`pkID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lktreatmentareaproblem`
--

LOCK TABLES `lktreatmentareaproblem` WRITE;
/*!40000 ALTER TABLE `lktreatmentareaproblem` DISABLE KEYS */;
INSERT INTO `lktreatmentareaproblem` VALUES (1,'Normal'),(2,'Swollen'),(3,'Puffy'),(4,'Crunchy'),(5,'Spongy');
/*!40000 ALTER TABLE `lktreatmentareaproblem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lktreatmentareaproblemfinding`
--

DROP TABLE IF EXISTS `lktreatmentareaproblemfinding`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lktreatmentareaproblemfinding` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `fkTreatmentAreaID` int NOT NULL,
  `fkTreatmentAreaProblemID` int NOT NULL,
  `TAProblemFindingDesc` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`pkID`),
  UNIQUE KEY `pkID_UNIQUE` (`pkID`)
) ENGINE=InnoDB AUTO_INCREMENT=389 DEFAULT CHARSET=utf8mb3 COMMENT='For each Treatment Area ID there are 4 possible findings';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lktreatmentareaproblemfinding`
--

LOCK TABLES `lktreatmentareaproblemfinding` WRITE;
/*!40000 ALTER TABLE `lktreatmentareaproblemfinding` DISABLE KEYS */;
INSERT INTO `lktreatmentareaproblemfinding` VALUES (1,1,1,'No Problem to report'),(2,1,2,'Potential issue - Check this area with the client'),(3,1,3,'Potential issue - Check this area with the client'),(4,1,4,'Potential issue - Check this area with the client'),(5,2,1,'No Problem to report'),(6,2,2,'Potential issue - Check this area with the client'),(7,2,3,'Potential issue - Check this area with the client'),(8,2,4,'Potential issue - Check this area with the client'),(9,3,1,'No Problem to report'),(10,3,2,'Potential issue - Check this area with the client'),(11,3,3,'Potential issue - Check this area with the client'),(12,3,4,'Potential issue - Check this area with the client'),(13,4,1,'No Problem to report'),(14,4,2,'Potential issue - Check this area with the client'),(15,4,3,'Potential issue - Check this area with the client'),(16,4,4,'Potential issue - Check this area with the client'),(17,5,1,'No Problem to report'),(18,5,2,'Potential issue - Check this area with the client'),(19,5,3,'Potential issue - Check this area with the client'),(20,5,4,'Potential issue - Check this area with the client'),(21,6,1,'No Problem to report'),(22,6,2,'Potential issue - Check this area with the client'),(23,6,3,'Potential issue - Check this area with the client'),(24,6,4,'Potential issue - Check this area with the client'),(25,7,1,'No Problem to report'),(26,7,2,'Potential issue - Check this area with the client'),(27,7,3,'Potential issue - Check this area with the client'),(28,7,4,'Potential issue - Check this area with the client'),(29,8,1,'No Problem to report'),(30,8,2,'Potential issue - Check this area with the client'),(31,8,3,'Potential issue - Check this area with the client'),(32,8,4,'Potential issue - Check this area with the client'),(33,9,1,'No Problem to report'),(34,9,2,'Potential issue - Check this area with the client'),(35,9,3,'Potential issue - Check this area with the client'),(36,9,4,'Potential issue - Check this area with the client'),(37,10,1,'No Problem to report'),(38,10,2,'Potential issue - Check this area with the client'),(39,10,3,'Potential issue - Check this area with the client'),(40,10,4,'Potential issue - Check this area with the client'),(41,11,1,'No Problem to report'),(42,11,2,'Potential issue - Check this area with the client'),(43,11,3,'Potential issue - Check this area with the client'),(44,11,4,'Potential issue - Check this area with the client'),(45,12,1,'No Problem to report'),(46,12,2,'Potential issue - Check this area with the client'),(47,12,3,'Potential issue - Check this area with the client'),(48,12,4,'Potential issue - Check this area with the client'),(49,13,1,'No Problem to report'),(50,13,2,'Potential issue - Check this area with the client'),(51,13,3,'Potential issue - Check this area with the client'),(52,13,4,'Potential issue - Check this area with the client'),(53,14,1,'No Problem to report'),(54,14,2,'Potential issue - Check this area with the client'),(55,14,3,'Potential issue - Check this area with the client'),(56,14,4,'Potential issue - Check this area with the client'),(57,15,1,'No Problem to report'),(58,15,2,'Potential issue - Check this area with the client'),(59,15,3,'Potential issue - Check this area with the client'),(60,15,4,'Potential issue - Check this area with the client'),(61,16,1,'No Problem to report'),(62,16,2,'Potential issue - Check this area with the client'),(63,16,3,'Potential issue - Check this area with the client'),(64,16,4,'Potential issue - Check this area with the client'),(65,17,1,'No Problem to report'),(66,17,2,'Potential issue - Check this area with the client'),(67,17,3,'Potential issue - Check this area with the client'),(68,17,4,'Potential issue - Check this area with the client'),(69,18,1,'No Problem to report'),(70,18,2,'Potential issue - Check this area with the client'),(71,18,3,'Potential issue - Check this area with the client'),(72,18,4,'Potential issue - Check this area with the client'),(73,19,1,'No Problem to report'),(74,19,2,'Potential issue - Check this area with the client'),(75,19,3,'Potential issue - Check this area with the client'),(76,19,4,'Potential issue - Check this area with the client'),(77,20,1,'No Problem to report'),(78,20,2,'Potential issue - Check this area with the client'),(79,20,3,'Potential issue - Check this area with the client'),(80,20,4,'Potential issue - Check this area with the client'),(81,21,1,'No Problem to report'),(82,21,2,'Potential issue - Check this area with the client'),(83,21,3,'Potential issue - Check this area with the client'),(84,21,4,'Potential issue - Check this area with the client'),(85,22,1,'No Problem to report'),(86,22,2,'Potential issue - Check this area with the client'),(87,22,3,'Potential issue - Check this area with the client'),(88,22,4,'Potential issue - Check this area with the client'),(89,23,1,'No Problem to report'),(90,23,2,'Potential issue - Check this area with the client'),(91,23,3,'Potential issue - Check this area with the client'),(92,23,4,'Potential issue - Check this area with the client'),(93,24,1,'No Problem to report'),(94,24,2,'Potential issue - Check this area with the client'),(95,24,3,'Potential issue - Check this area with the client'),(96,24,4,'Potential issue - Check this area with the client'),(97,25,1,'No Problem to report'),(98,25,2,'Potential issue - Check this area with the client'),(99,25,3,'Potential issue - Check this area with the client'),(100,25,4,'Potential issue - Check this area with the client'),(101,26,1,'No Problem to report'),(102,26,2,'Potential issue - Check this area with the client'),(103,26,3,'Potential issue - Check this area with the client'),(104,26,4,'Potential issue - Check this area with the client'),(105,27,1,'No Problem to report'),(106,27,2,'Potential issue - Check this area with the client'),(107,27,3,'Potential issue - Check this area with the client'),(108,27,4,'Potential issue - Check this area with the client'),(109,28,1,'No Problem to report'),(110,28,2,'Potential issue - Check this area with the client'),(111,28,3,'Potential issue - Check this area with the client'),(112,28,4,'Potential issue - Check this area with the client'),(113,29,1,'No Problem to report'),(114,29,2,'Potential issue - Check this area with the client'),(115,29,3,'Potential issue - Check this area with the client'),(116,29,4,'Potential issue - Check this area with the client'),(117,30,1,'No Problem to report'),(118,30,2,'Potential issue - Check this area with the client'),(119,30,3,'Potential issue - Check this area with the client'),(120,30,4,'Potential issue - Check this area with the client'),(121,31,1,'No Problem to report'),(122,31,2,'Potential issue - Check this area with the client'),(123,31,3,'Potential issue - Check this area with the client'),(124,31,4,'Potential issue - Check this area with the client'),(125,32,1,'No Problem to report'),(126,32,2,'Potential issue - Check this area with the client'),(127,32,3,'Potential issue - Check this area with the client'),(128,32,4,'Potential issue - Check this area with the client'),(129,33,1,'No Problem to report'),(130,33,2,'Potential issue - Check this area with the client'),(131,33,3,'Potential issue - Check this area with the client'),(132,33,4,'Potential issue - Check this area with the client'),(133,34,1,'No Problem to report'),(134,34,2,'Potential issue - Check this area with the client'),(135,34,3,'Potential issue - Check this area with the client'),(136,34,4,'Potential issue - Check this area with the client'),(137,35,1,'No Problem to report'),(138,35,2,'Potential issue - Check this area with the client'),(139,35,3,'Potential issue - Check this area with the client'),(140,35,4,'Potential issue - Check this area with the client'),(141,36,1,'No Problem to report'),(142,36,2,'Potential issue - Check this area with the client'),(143,36,3,'Potential issue - Check this area with the client'),(144,36,4,'Potential issue - Check this area with the client'),(145,37,1,'No Problem to report'),(146,37,2,'Potential issue - Check this area with the client'),(147,37,3,'Potential issue - Check this area with the client'),(148,37,4,'Potential issue - Check this area with the client'),(149,38,1,'No Problem to report'),(150,38,2,'Potential issue - Check this area with the client'),(151,38,3,'Potential issue - Check this area with the client'),(152,38,4,'Potential issue - Check this area with the client'),(153,39,1,'No Problem to report'),(154,39,2,'Potential issue - Check this area with the client'),(155,39,3,'Potential issue - Check this area with the client'),(156,39,4,'Potential issue - Check this area with the client'),(157,40,1,'No Problem to report'),(158,40,2,'Potential issue - Check this area with the client'),(159,40,3,'Potential issue - Check this area with the client'),(160,40,4,'Potential issue - Check this area with the client'),(161,41,1,'No Problem to report'),(162,41,2,'Potential issue - Check this area with the client'),(163,41,3,'Potential issue - Check this area with the client'),(164,41,4,'Potential issue - Check this area with the client'),(165,42,1,'No Problem to report'),(166,42,2,'Potential issue - Check this area with the client'),(167,42,3,'Potential issue - Check this area with the client'),(168,42,4,'Potential issue - Check this area with the client'),(169,43,1,'No Problem to report'),(170,43,2,'Potential issue - Check this area with the client'),(171,43,3,'Potential issue - Check this area with the client'),(172,43,4,'Potential issue - Check this area with the client'),(173,44,1,'No Problem to report'),(174,44,2,'Potential issue - Check this area with the client'),(175,44,3,'Potential issue - Check this area with the client'),(176,44,4,'Potential issue - Check this area with the client'),(177,45,1,'No Problem to report'),(178,45,2,'Potential issue - Check this area with the client'),(179,45,3,'Potential issue - Check this area with the client'),(180,45,4,'Potential issue - Check this area with the client'),(181,46,1,'No Problem to report'),(182,46,2,'Potential issue - Check this area with the client'),(183,46,3,'Potential issue - Check this area with the client'),(184,46,4,'Potential issue - Check this area with the client'),(185,47,1,'No Problem to report'),(186,47,2,'Potential issue - Check this area with the client'),(187,47,3,'Potential issue - Check this area with the client'),(188,47,4,'Potential issue - Check this area with the client'),(189,48,1,'No Problem to report'),(190,48,2,'Potential issue - Check this area with the client'),(191,48,3,'Potential issue - Check this area with the client'),(192,48,4,'Potential issue - Check this area with the client'),(193,49,1,'No Problem to report'),(194,49,2,'Potential issue - Check this area with the client'),(195,49,3,'Potential issue - Check this area with the client'),(196,49,4,'Potential issue - Check this area with the client'),(197,50,1,'No Problem to report'),(198,50,2,'Potential issue - Check this area with the client'),(199,50,3,'Potential issue - Check this area with the client'),(200,50,4,'Potential issue - Check this area with the client'),(201,51,1,'No Problem to report'),(202,51,2,'Potential issue - Check this area with the client'),(203,51,3,'Potential issue - Check this area with the client'),(204,51,4,'Potential issue - Check this area with the client'),(205,52,1,'No Problem to report'),(206,52,2,'Potential issue - Check this area with the client'),(207,52,3,'Potential issue - Check this area with the client'),(208,52,4,'Potential issue - Check this area with the client'),(209,53,1,'No Problem to report'),(210,53,2,'Potential issue - Check this area with the client'),(211,53,3,'Potential issue - Check this area with the client'),(212,53,4,'Potential issue - Check this area with the client'),(213,54,1,'No Problem to report'),(214,54,2,'Potential issue - Check this area with the client'),(215,54,3,'Potential issue - Check this area with the client'),(216,54,4,'Potential issue - Check this area with the client'),(217,55,1,'No Problem to report'),(218,55,2,'Potential issue - Check this area with the client'),(219,55,3,'Potential issue - Check this area with the client'),(220,55,4,'Potential issue - Check this area with the client'),(221,56,1,'No Problem to report'),(222,56,2,'Potential issue - Check this area with the client'),(223,56,3,'Potential issue - Check this area with the client'),(224,56,4,'Potential issue - Check this area with the client'),(225,57,1,'No Problem to report'),(226,57,2,'Potential issue - Check this area with the client'),(227,57,3,'Potential issue - Check this area with the client'),(228,57,4,'Potential issue - Check this area with the client'),(229,58,1,'No Problem to report'),(230,58,2,'Potential issue - Check this area with the client'),(231,58,3,'Potential issue - Check this area with the client'),(232,58,4,'Potential issue - Check this area with the client'),(233,59,1,'No Problem to report'),(234,59,2,'Potential issue - Check this area with the client'),(235,59,3,'Potential issue - Check this area with the client'),(236,59,4,'Potential issue - Check this area with the client'),(237,60,1,'No Problem to report'),(238,60,2,'Potential issue - Check this area with the client'),(239,60,3,'Potential issue - Check this area with the client'),(240,60,4,'Potential issue - Check this area with the client'),(241,61,1,'No Problem to report'),(242,61,2,'Potential issue - Check this area with the client'),(243,61,3,'Potential issue - Check this area with the client'),(244,61,4,'Potential issue - Check this area with the client'),(245,62,1,'No Problem to report'),(246,62,2,'Potential issue - Check this area with the client'),(247,62,3,'Potential issue - Check this area with the client'),(248,62,4,'Potential issue - Check this area with the client'),(249,63,1,'No Problem to report'),(250,63,2,'Potential issue - Check this area with the client'),(251,63,3,'Potential issue - Check this area with the client'),(252,63,4,'Potential issue - Check this area with the client'),(253,64,1,'No Problem to report'),(254,64,2,'Potential issue - Check this area with the client'),(255,64,3,'Potential issue - Check this area with the client'),(256,64,4,'Potential issue - Check this area with the client'),(257,65,1,'No Problem to report'),(258,65,2,'Potential issue - Check this area with the client'),(259,65,3,'Potential issue - Check this area with the client'),(260,65,4,'Potential issue - Check this area with the client'),(261,66,1,'No Problem to report'),(262,66,2,'Potential issue - Check this area with the client'),(263,66,3,'Potential issue - Check this area with the client'),(264,66,4,'Potential issue - Check this area with the client'),(265,67,1,'No Problem to report'),(266,67,2,'Potential issue - Check this area with the client'),(267,67,3,'Potential issue - Check this area with the client'),(268,67,4,'Potential issue - Check this area with the client'),(269,68,1,'No Problem to report'),(270,68,2,'Potential issue - Check this area with the client'),(271,68,3,'Potential issue - Check this area with the client'),(272,68,4,'Potential issue - Check this area with the client'),(273,69,1,'No Problem to report'),(274,69,2,'Potential issue - Check this area with the client'),(275,69,3,'Potential issue - Check this area with the client'),(276,69,4,'Potential issue - Check this area with the client'),(277,70,1,'No Problem to report'),(278,70,2,'Potential issue - Check this area with the client'),(279,70,3,'Potential issue - Check this area with the client'),(280,70,4,'Potential issue - Check this area with the client'),(281,71,1,'No Problem to report'),(282,71,2,'Potential issue - Check this area with the client'),(283,71,3,'Potential issue - Check this area with the client'),(284,71,4,'Potential issue - Check this area with the client'),(285,72,1,'No Problem to report'),(286,72,2,'Potential issue - Check this area with the client'),(287,72,3,'Potential issue - Check this area with the client'),(288,72,4,'Potential issue - Check this area with the client'),(289,73,1,'No Problem to report'),(290,73,2,'Potential issue - Check this area with the client'),(291,73,3,'Potential issue - Check this area with the client'),(292,73,4,'Potential issue - Check this area with the client'),(293,74,1,'No Problem to report'),(294,74,2,'Potential issue - Check this area with the client'),(295,74,3,'Potential issue - Check this area with the client'),(296,74,4,'Potential issue - Check this area with the client'),(297,75,1,'No Problem to report'),(298,75,2,'Potential issue - Check this area with the client'),(299,75,3,'Potential issue - Check this area with the client'),(300,75,4,'Potential issue - Check this area with the client'),(301,76,1,'No Problem to report'),(302,76,2,'Potential issue - Check this area with the client'),(303,76,3,'Potential issue - Check this area with the client'),(304,76,4,'Potential issue - Check this area with the client'),(305,77,1,'No Problem to report'),(306,77,2,'Potential issue - Check this area with the client'),(307,77,3,'Potential issue - Check this area with the client'),(308,77,4,'Potential issue - Check this area with the client'),(309,78,1,'No Problem to report'),(310,78,2,'Potential issue - Check this area with the client'),(311,78,3,'Potential issue - Check this area with the client'),(312,78,4,'Potential issue - Check this area with the client'),(313,79,1,'No Problem to report'),(314,79,2,'Potential issue - Check this area with the client'),(315,79,3,'Potential issue - Check this area with the client'),(316,79,4,'Potential issue - Check this area with the client'),(317,80,1,'No Problem to report'),(318,80,2,'Potential issue - Check this area with the client'),(319,80,3,'Potential issue - Check this area with the client'),(320,80,4,'Potential issue - Check this area with the client'),(321,81,1,'No Problem to report'),(322,81,2,'Potential issue - Check this area with the client'),(323,81,3,'Potential issue - Check this area with the client'),(324,81,4,'Potential issue - Check this area with the client'),(325,82,1,'No Problem to report'),(326,82,2,'Potential issue - Check this area with the client'),(327,82,3,'Potential issue - Check this area with the client'),(328,82,4,'Potential issue - Check this area with the client'),(329,83,1,'No Problem to report'),(330,83,2,'Potential issue - Check this area with the client'),(331,83,3,'Potential issue - Check this area with the client'),(332,83,4,'Potential issue - Check this area with the client'),(333,84,1,'No Problem to report'),(334,84,2,'Potential issue - Check this area with the client'),(335,84,3,'Potential issue - Check this area with the client'),(336,84,4,'Potential issue - Check this area with the client'),(337,85,1,'No Problem to report'),(338,85,2,'Potential issue - Check this area with the client'),(339,85,3,'Potential issue - Check this area with the client'),(340,85,4,'Potential issue - Check this area with the client'),(341,86,1,'No Problem to report'),(342,86,2,'Potential issue - Check this area with the client'),(343,86,3,'Potential issue - Check this area with the client'),(344,86,4,'Potential issue - Check this area with the client'),(345,87,1,'No Problem to report'),(346,87,2,'Potential issue - Check this area with the client'),(347,87,3,'Potential issue - Check this area with the client'),(348,87,4,'Potential issue - Check this area with the client'),(349,88,1,'No Problem to report'),(350,88,2,'Potential issue - Check this area with the client'),(351,88,3,'Potential issue - Check this area with the client'),(352,88,4,'Potential issue - Check this area with the client'),(353,89,1,'No Problem to report'),(354,89,2,'Potential issue - Check this area with the client'),(355,89,3,'Potential issue - Check this area with the client'),(356,89,4,'Potential issue - Check this area with the client'),(357,90,1,'No Problem to report'),(358,90,2,'Potential issue - Check this area with the client'),(359,90,3,'Potential issue - Check this area with the client'),(360,90,4,'Potential issue - Check this area with the client'),(361,91,1,'No Problem to report'),(362,91,2,'Potential issue - Check this area with the client'),(363,91,3,'Potential issue - Check this area with the client'),(364,91,4,'Potential issue - Check this area with the client'),(365,92,1,'No Problem to report'),(366,92,2,'Potential issue - Check this area with the client'),(367,92,3,'Potential issue - Check this area with the client'),(368,92,4,'Potential issue - Check this area with the client'),(369,93,1,'No Problem to report'),(370,93,2,'Potential issue - Check this area with the client'),(371,93,3,'Potential issue - Check this area with the client'),(372,93,4,'Potential issue - Check this area with the client'),(373,94,1,'No Problem to report'),(374,94,2,'Potential issue - Check this area with the client'),(375,94,3,'Potential issue - Check this area with the client'),(376,94,4,'Potential issue - Check this area with the client'),(377,95,1,'No Problem to report'),(378,95,2,'Potential issue - Check this area with the client'),(379,95,3,'Potential issue - Check this area with the client'),(380,95,4,'Potential issue - Check this area with the client'),(381,96,1,'No Problem to report'),(382,96,2,'Potential issue - Check this area with the client'),(383,96,3,'Potential issue - Check this area with the client'),(384,96,4,'Potential issue - Check this area with the client'),(385,97,1,'No Problem to report'),(386,97,2,'Potential issue - Check this area with the client'),(387,97,3,'Potential issue - Check this area with the client'),(388,97,4,'Potential issue - Check this area with the client');
/*!40000 ALTER TABLE `lktreatmentareaproblemfinding` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lktreatmentareas`
--

DROP TABLE IF EXISTS `lktreatmentareas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lktreatmentareas` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `fkTreatmentMapArea` int DEFAULT NULL,
  `TreatmentAreaCode` varchar(5) NOT NULL,
  `TreatmentAreaDesc` varchar(45) NOT NULL,
  `ZoneX` int DEFAULT '0',
  `ZoneY` int DEFAULT '0',
  `ZoneW` int DEFAULT '0',
  `ZoneH` int DEFAULT '0',
  PRIMARY KEY (`pkID`)
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lktreatmentareas`
--

LOCK TABLES `lktreatmentareas` WRITE;
/*!40000 ALTER TABLE `lktreatmentareas` DISABLE KEYS */;
INSERT INTO `lktreatmentareas` VALUES (1,1,'RS1','Brain',160,30,25,20),(2,1,'RS2','Hypothalamus',184,55,12,12),(3,1,'RS3','Pituitary',160,58,12,12),(4,1,'RS4','Pineal',177,68,12,12),(5,1,'RS5','Neck – big toe',160,90,25,15),(6,1,'RS6','Thyroid and Parathyroid',160,115,15,10),(7,1,'RS7','Occiput',147,80,10,10),(8,1,'RS8','Thymus',186,135,12,20),(9,1,'RS9','Heart',170,150,20,20),(10,1,'RS10','Thyroid Helper',151,180,33,20),(11,1,'RS11','Neck – toe 2',118,60,25,20),(12,1,'RS12','Sinus – toe 2',120,40,20,10),(13,1,'RS13','Neck – toe 3',90,70,25,20),(14,1,'RS14','Sinus – toe 3',93,50,20,10),(15,1,'RS15','Neck – toe 4',68,88,25,20),(16,1,'RS16','Sinus – toe 4',68,65,20,10),(17,1,'RS17','Neck – toe 5',40,110,20,15),(18,1,'RS18','Sinus – toe 5',50,95,20,10),(19,1,'RS19','Right eye',110,100,20,10),(20,1,'RS20','Right ear / Eustachian tube',85,103,20,10),(21,1,'RS21','Balance',60,116,20,10),(22,1,'RS22','Trapezius',145,106,30,10),(23,1,'RS23','Right shoulder',30,145,20,30),(24,1,'RS24','Right arm',30,180,20,20),(25,1,'RS25','Right lung / brochus',70,125,75,50),(26,1,'RS26','Diaphragm',70,185,40,15),(27,1,'RS27','Solar Plexus',110,192,25,15),(28,1,'RS28','Liver',80,210,40,40),(29,1,'RS29','Pancreas',145,253,25,15),(30,1,'RS30','Gall bladder',60,220,15,15),(31,1,'RS31','Adrenal gland',135,230,20,15),(32,1,'RS32','Kidney',110,250,30,35),(33,1,'RS33','Uretera',147,285,10,35),(34,1,'RS34','Bladder',165,330,10,25),(35,1,'RS35','Small intestine',80,295,60,50),(36,1,'RS36','Ileocaecal valve',70,350,15,15),(37,1,'RS37','Appendix',60,360,10,10),(38,1,'RS38','Ascending Colon',55,305,15,40),(39,1,'RS39','Transverse Colon',70,275,40,15),(40,1,'RS40','Pelvic muscles',80,390,60,40),(41,1,'RS41','Sciatic nerve',85,370,40,15),(42,2,'LS1','Brain',50,30,25,20),(43,2,'LS2','Pituitary',55,55,12,12),(44,2,'LS3','Hypothalamus',34,55,12,12),(45,2,'LS4','Pineal',37,65,15,15),(46,2,'LS5','Occiput',70,80,12,12),(47,2,'LS6','Neck – big toe',85,65,20,15),(48,2,'LS7','Thyroid / Parathyroid',45,114,20,10),(49,2,'LS8','Sinus – toe 2',85,65,20,25),(50,2,'LS9','Neck – toe 2',88,40,15,12),(51,2,'LS10','Sinus – toe 3',115,70,20,15),(52,2,'LS11','Neck – toe 3',118,48,15,12),(53,2,'LS12','Sinus – toe 4',137,80,20,15),(54,2,'LS13','Neck – toe 4',145,65,15,12),(55,2,'LS14','Sinus – toe 5',165,102,20,15),(56,2,'LS15','Neck – toe 5',165,90,15,12),(57,2,'LS16','Left Eye',98,98,20,10),(58,2,'LS17','Left Ear / Eustachian tube',125,103,20,10),(59,2,'LS18','Balance',155,113,20,10),(60,2,'LS19','Trapezius',165,130,30,10),(61,2,'LS20','Thymus ',30,130,10,20),(62,2,'LS21','Brochus',55,140,30,10),(63,2,'LS22','Heart',40,150,30,30),(64,2,'LS23','Thyroid Helper',43,185,30,10),(65,2,'LS24','Left shoulder',175,150,15,15),(66,2,'LS25','Left arm',175,178,15,15),(67,2,'LS26','Left lung',95,130,60,50),(68,2,'LS27','Oesophagus',50,125,15,10),(69,2,'LS28','Diaphragm',125,182,30,12),(70,2,'LS29','Solar Plexus',95,195,30,12),(71,2,'LS30','Liver',60,220,25,10),(72,2,'LS31','Stomach',105,215,25,25),(73,2,'LS32','Adrenal gland',75,230,17,15),(74,2,'LS33','Spleen',140,215,25,25),(75,2,'LS34','Pancreas',65,250,20,20),(76,2,'LS35','Kidney',85,245,30,30),(77,2,'LS36','Ureter',70,285,10,35),(78,2,'LS37','Bladder',60,325,10,15),(79,2,'LS38','Small intestine',90,285,65,50),(80,2,'LS39','Transverse Colon',125,270,30,10),(81,2,'LS40','Descending Colon',160,285,10,35),(82,2,'LS41','Sigmoid colon',125,350,30,10),(83,2,'LS42','Pelvic muscles',85,380,65,50),(84,2,'LS43','Sciatic nerve',110,365,30,10);
/*!40000 ALTER TABLE `lktreatmentareas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lktreatmentmaparea`
--

DROP TABLE IF EXISTS `lktreatmentmaparea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lktreatmentmaparea` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `TreatMentMapArea` varchar(45) NOT NULL,
  PRIMARY KEY (`pkID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lktreatmentmaparea`
--

LOCK TABLES `lktreatmentmaparea` WRITE;
/*!40000 ALTER TABLE `lktreatmentmaparea` DISABLE KEYS */;
INSERT INTO `lktreatmentmaparea` VALUES (1,'Sole Right'),(2,'Sole Left'),(3,'Dorsal Right'),(4,'Dorsal left'),(5,'Medial Right'),(6,'Medial Left'),(7,'Lateral Right'),(8,'Lateral Left');
/*!40000 ALTER TABLE `lktreatmentmaparea` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patientmedhistory`
--

DROP TABLE IF EXISTS `patientmedhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patientmedhistory` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `fkpatientID` int NOT NULL,
  `TreatmentDate` date NOT NULL,
  `Notes` longtext,
  PRIMARY KEY (`pkID`),
  UNIQUE KEY `pkID_UNIQUE` (`pkID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patientmedhistory`
--

LOCK TABLES `patientmedhistory` WRITE;
/*!40000 ALTER TABLE `patientmedhistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `patientmedhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patientrecord`
--

DROP TABLE IF EXISTS `patientrecord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patientrecord` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `fkPatientTitleID` int NOT NULL,
  `fkPatientGenderID` int NOT NULL,
  `PatSurname` varchar(45) NOT NULL,
  `PatFName` varchar(45) DEFAULT NULL,
  `PatMiddleNames` varchar(100) DEFAULT NULL,
  `PatAddressLn1` varchar(100) DEFAULT NULL,
  `PatAddressLn2` varchar(100) DEFAULT NULL,
  `PatAddressTown` varchar(50) DEFAULT NULL,
  `PatPostcode` varchar(10) DEFAULT NULL,
  `PatPhoneH` varchar(45) DEFAULT NULL COMMENT 'Home Phone',
  `PatPhoneM` varchar(45) DEFAULT '' COMMENT 'Mobile Phone',
  `PatEmail` varchar(60) DEFAULT NULL COMMENT 'Email Addr',
  `patBirthDate` date DEFAULT NULL COMMENT 'Patient DOB',
  `CurrentRecord` tinyint DEFAULT NULL COMMENT 'True/False',
  `RecordOpenedDt` date NOT NULL,
  `RecordLastModifiedDt` datetime DEFAULT NULL COMMENT 'Date Record was last modified',
  PRIMARY KEY (`pkID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COMMENT='Holds the personalised Patient Record associated with Treatments.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patientrecord`
--

LOCK TABLES `patientrecord` WRITE;
/*!40000 ALTER TABLE `patientrecord` DISABLE KEYS */;
INSERT INTO `patientrecord` VALUES (1,1,1,'VAN DEN BERG','RUDOLF','LEN','3 JACKSON CLOSE','','BRACKNELL','RG127JG','','07951320583','lenvdb64@gmail.com','1964-12-10',1,'2017-12-28','2018-01-19 13:23:06'),(2,3,2,'Duffy','Joanne','','69 Woodcock Close','','Egham','KT14 5BN','','123456789','joduffy@gmail.com','1975-07-30',1,'2018-03-02','2018-03-02 11:46:57'),(3,3,2,'Duffy','Leanne','','61 Woodcock Close','','Egham','KT14 5BN','','987654321','leaduffy@gmail.com','1975-07-30',1,'2018-03-02','2018-03-02 11:47:16');
/*!40000 ALTER TABLE `patientrecord` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `treatmentrecordareas`
--

DROP TABLE IF EXISTS `treatmentrecordareas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `treatmentrecordareas` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `fkPatientRecordID` int NOT NULL COMMENT 'Patient RecordID',
  `fkTreatmentRecordID` int NOT NULL,
  `fkTreatmentAreaID` int NOT NULL,
  `fkTreatmentAreaProblemID` int NOT NULL,
  PRIMARY KEY (`pkID`),
  UNIQUE KEY `pkID_UNIQUE` (`pkID`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `treatmentrecordareas`
--

LOCK TABLES `treatmentrecordareas` WRITE;
/*!40000 ALTER TABLE `treatmentrecordareas` DISABLE KEYS */;
INSERT INTO `treatmentrecordareas` VALUES (1,1,1,1,1),(2,1,1,24,1),(3,1,1,34,1),(4,1,2,22,1),(5,1,2,31,1),(6,1,1,4,1),(7,1,1,42,2),(8,1,1,42,3),(9,1,1,42,3),(10,1,1,43,1),(11,1,1,55,1),(12,1,1,78,2),(13,3,3,25,1),(14,3,3,28,1),(15,3,3,1,3),(16,3,3,23,3),(17,3,3,83,4),(18,3,3,72,2),(19,1,2,5,1),(20,1,2,12,2),(21,1,2,11,2),(22,1,2,17,3),(23,1,2,50,3),(24,1,2,54,2),(25,2,4,23,2),(26,2,4,24,2),(27,2,4,5,1),(28,2,4,11,1),(29,2,4,13,1),(30,2,4,5,1),(31,2,4,40,1),(32,2,4,50,1),(33,2,4,54,1),(34,2,4,72,1),(35,2,4,65,1),(36,2,4,84,2),(37,2,4,83,1);
/*!40000 ALTER TABLE `treatmentrecordareas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `treatmentrecords`
--

DROP TABLE IF EXISTS `treatmentrecords`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `treatmentrecords` (
  `pkID` int NOT NULL AUTO_INCREMENT,
  `fkPatientRecordID` int NOT NULL,
  `TreatmentDate` datetime DEFAULT NULL,
  `Notes_RSole` longtext,
  `Notes_LSole` longtext,
  `Notes_DorsalR` longtext,
  `Notes_DorsalL` longtext,
  `Notes_Plantar` longtext,
  `Notes_Medial` longtext,
  `TreatmentCompleted` tinyint DEFAULT '0',
  PRIMARY KEY (`pkID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `treatmentrecords`
--

LOCK TABLES `treatmentrecords` WRITE;
/*!40000 ALTER TABLE `treatmentrecords` DISABLE KEYS */;
INSERT INTO `treatmentrecords` VALUES (1,1,'2017-12-10 00:00:00','All sorts of problems','More problems - mostly stress related',NULL,NULL,NULL,NULL,0),(2,1,'2018-01-05 12:55:33',NULL,NULL,'Stiffness in the neck',NULL,NULL,NULL,0),(3,3,'2018-03-02 12:07:49',NULL,NULL,'Her brain area is puffy because her head is filled with air!\n','Stomach is swollen due to obesity',NULL,NULL,0),(4,2,'2021-09-15 00:00:00',NULL,NULL,'She complained of shoulder pain and stiffness','She also complained about her Sciatic Nerve',NULL,NULL,0);
/*!40000 ALTER TABLE `treatmentrecords` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'dbreflexpro'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_GetCustomersMonthly` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_GetCustomersMonthly`()
BEGIN
		SELECT pt.Title AS Title, 
		 pr.PatFName AS PatFName, 
		 pr.PatSurname AS PatSurname, 
		 tr.TreatmentDate AS TreatmentDate, 
		 tr.pkID AS TreatmentRef
	FROM dbreflexpro.patientrecord pr 
	LEFT JOIN treatmentrecords tr ON (pr.pkID = tr.fkPatientRecordID)
	LEFT JOIN patientmedhistory ph ON (pr.pkID = ph.fkpatientID)
	LEFT JOIN lktitle pt ON (pr.fkPatientTitleID = pt.pkID)
	ORDER BY tr.pkID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `customerstreatments_monthly`
--

/*!50001 DROP VIEW IF EXISTS `customerstreatments_monthly`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `customerstreatments_monthly` AS select `pt`.`Title` AS `Title`,`pr`.`PatFName` AS `PatFName`,`pr`.`PatSurname` AS `PatSurname`,`tr`.`TreatmentDate` AS `TreatmentDate`,`tr`.`pkID` AS `TreatmentRef` from (((`patientrecord` `pr` left join `treatmentrecords` `tr` on((`pr`.`pkID` = `tr`.`fkPatientRecordID`))) left join `patientmedhistory` `ph` on((`pr`.`pkID` = `ph`.`fkpatientID`))) left join `lktitle` `pt` on((`pr`.`fkPatientTitleID` = `pt`.`pkID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-03 12:54:22
