CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `Alunos` (
    `AlunoID` int NOT NULL AUTO_INCREMENT,
    `Nome` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Alunos` PRIMARY KEY (`AlunoID`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Disciplinas` (
    `DisciplinaID` int NOT NULL AUTO_INCREMENT,
    `Nome` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Disciplinas` PRIMARY KEY (`DisciplinaID`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Matriculas` (
    `MatriculaID` int NOT NULL AUTO_INCREMENT,
    `AlunoID` int NOT NULL,
    `DisciplinaID` int NOT NULL,
    CONSTRAINT `PK_Matriculas` PRIMARY KEY (`MatriculaID`),
    CONSTRAINT `FK_Matriculas_Alunos_AlunoID` FOREIGN KEY (`AlunoID`) REFERENCES `Alunos` (`AlunoID`) ON DELETE CASCADE,
    CONSTRAINT `FK_Matriculas_Disciplinas_DisciplinaID` FOREIGN KEY (`DisciplinaID`) REFERENCES `Disciplinas` (`DisciplinaID`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Notas` (
    `NotaID` int NOT NULL AUTO_INCREMENT,
    `Valor` double NOT NULL,
    `MatriculaID` int NOT NULL,
    CONSTRAINT `PK_Notas` PRIMARY KEY (`NotaID`),
    CONSTRAINT `FK_Notas_Matriculas_MatriculaID` FOREIGN KEY (`MatriculaID`) REFERENCES `Matriculas` (`MatriculaID`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_Matriculas_AlunoID` ON `Matriculas` (`AlunoID`);

CREATE INDEX `IX_Matriculas_DisciplinaID` ON `Matriculas` (`DisciplinaID`);

CREATE INDEX `IX_Notas_MatriculaID` ON `Notas` (`MatriculaID`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250622065314_firstMig', '8.0.13');

COMMIT;

