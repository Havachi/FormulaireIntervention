-- --------------------------------------------------------
-- Hôte :                        127.0.0.1
-- Version du serveur:           10.4.10-MariaDB - mariadb.org binary distribution
-- SE du serveur:                Win64
-- HeidiSQL Version:             10.3.0.5771
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Listage de la structure de la base pour formulaireintervention
CREATE DATABASE IF NOT EXISTS `formulaireintervention` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `formulaireintervention`;

-- Listage de la structure de la table formulaireintervention. clients
CREATE TABLE IF NOT EXISTS `clients` (
  `ClientID` int(11) NOT NULL AUTO_INCREMENT,
  `ClientFirstName` varchar(50) DEFAULT NULL,
  `ClientLastName` varchar(50) DEFAULT NULL,
  `ClientAddress` varchar(50) DEFAULT NULL,
  `ClientPhoneNumber` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ClientID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Les données exportées n'étaient pas sélectionnées.

-- Listage de la structure de la table formulaireintervention. intervenant
CREATE TABLE IF NOT EXISTS `intervenant` (
  `IntervenantID` int(11) NOT NULL AUTO_INCREMENT,
  `IntervenantFirstName` varchar(50) NOT NULL DEFAULT '',
  `IntervenantLastName` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`IntervenantID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Les données exportées n'étaient pas sélectionnées.

-- Listage de la structure de la table formulaireintervention. intervention
CREATE TABLE `intervention` (
	`InterventionID` INT(11) NOT NULL AUTO_INCREMENT,
	`InterventionIntervenantID` INT(11) NOT NULL,
	`InterventionClientID` INT(11) NOT NULL,
	`InterventionDuration` INT(11) NOT NULL,
	`InterventionType` VARCHAR(50) NOT NULL DEFAULT '',
	PRIMARY KEY (`InterventionID`),
	INDEX `FK_intervention_intervenant` (`InterventionIntervenantID`),
	INDEX `FK_intervention_clients` (`InterventionClientID`),
	CONSTRAINT `FK_intervention_clients` FOREIGN KEY (`InterventionClientID`) REFERENCES `clients` (`ClientID`) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT `FK_intervention_intervenant` FOREIGN KEY (`InterventionIntervenantID`) REFERENCES `intervenant` (`IntervenantID`) ON UPDATE CASCADE ON DELETE CASCADE
)
COLLATE='latin1_swedish_ci'
ENGINE=INNODB;

-- Les données exportées n'étaient pas sélectionnées.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
