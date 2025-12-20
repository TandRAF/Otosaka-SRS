CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

START TRANSACTION;

CREATE TABLE `Notes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `DeskId` int NOT NULL,
    `NoteType` longtext NOT NULL,
    `ContentJSON` longtext NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `User` (
    `Id` int NOT NULL AUTO_INCREMENT,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Cards` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `NoteId` int NOT NULL,
    `Ordinal` longtext NOT NULL,
    `NextReviewDate` datetime(6) NOT NULL,
    `EaseFactor` double NOT NULL,
    `IntervalDays` double NOT NULL,
    `Repetitions` int NOT NULL,
    `Status` int NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Cards_Notes_NoteId` FOREIGN KEY (`NoteId`) REFERENCES `Notes` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Desks` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` int NOT NULL,
    `Title` longtext NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Desks_User_UserId` FOREIGN KEY (`UserId`) REFERENCES `User` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Profiles` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` int NOT NULL,
    `Bio` longtext NOT NULL,
    `Scope` longtext NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Profiles_User_UserId` FOREIGN KEY (`UserId`) REFERENCES `User` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Cards_NoteId` ON `Cards` (`NoteId`);

CREATE INDEX `IX_Desks_UserId` ON `Desks` (`UserId`);

CREATE UNIQUE INDEX `IX_Profiles_UserId` ON `Profiles` (`UserId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20251219205459_InitialCreate', '8.0.8');

COMMIT;

